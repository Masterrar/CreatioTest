namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using global::Common.Logging;
	using ServiceStack.ServiceClient.Web;
	using ServiceStack.Text;
	using Terrasoft.Common;
	using Terrasoft.Core.Factories;
	using Terrasoft.ML.Interfaces;
	using Terrasoft.ML.Interfaces.Requests;
	using Terrasoft.ML.Interfaces.Responses;
	using Terrasoft.Web.Http.Abstractions;

	#region Interface: IMLServiceProxy

	/// <summary>
	/// Interface for calling machine learning service.
	/// </summary>
	public interface IMLServiceProxy
	{

		#region Methods: Public

		/// <summary>
		/// Starts new train session.
		/// </summary>
		/// <param name="metaData">Meta data of the model's input and output.</param>
		/// <param name="modelSchemaId">ML model schema identifier.</param>
		/// <returns>The identifier of the started session.</returns>
		Guid StartTrainSession(string metaData, Guid modelSchemaId);

		/// <summary>
		/// Uploads data to the service.
		/// </summary>
		/// <param name="data">Data to upload.</param>
		/// <param name="sessionId">The identifier of the training session.</param>
		void UploadData(string data, Guid sessionId);

		/// <summary>
		/// Begins the training.
		/// </summary>
		/// <param name="trainSessionId">The train session identifier.</param>
		/// <param name="methodName">Name of the web method.</param>
		void BeginTraining(Guid trainSessionId, string methodName);

		/// <summary>
		/// Gets information about the training session.
		/// </summary>
		/// <param name="trainSessionId">The train session identifier.</param>
		/// <returns></returns>
		GetSessionInfoResponse GetTrainingSessionInfo(Guid trainSessionId);

		/// <summary>
		/// Calls classification service.
		/// </summary>
		/// <param name="modelInstanceUId">The model instance id.</param>
		/// <param name="data">Input data fields for classification model.</param>
		/// <returns>List of <see cref="ClassificationResult"/>.</returns>
		List<ClassificationResult> Classify(Guid modelInstanceUId, Dictionary<string, object> data);

		/// <summary>
		/// Scores rate for item with the given data using the specified model.
		/// </summary>
		/// <param name="model">Model, that should perform scoring.</param>
		/// <param name="data">The data of the item that should be scored.</param>
		/// <param name="predictContributions">
		/// Indicates, if service should return individual feature contributions to overall prediction.
		/// </param>
		/// <returns>Predicted score rate.</returns>
		ScoringOutput Score(MLModelConfig model, Dictionary<string, object> data, bool predictContributions);

		/// <summary>
		/// Scores rates for list of items with the given data using the specified model.
		/// </summary>
		/// <param name="model">Model, that should perform scoring.</param>
		/// <param name="dataList">The list of data of items that should be scored.</param>
		/// <param name="predictContributions">
		/// Indicates, if service should return individual feature contributions to overall prediction.
		/// </param>
		/// <returns>Predicted score rates.</returns>
		List<ScoringOutput> Score(MLModelConfig model, IList<Dictionary<string, object>> dataList,
			bool predictContributions);

		/// <summary>
		/// Performs regression of numeric value for list of items with the given data using the specified model.
		/// </summary>
		/// <param name="modelInstanceUId">The model instance identifier.</param>
		/// <param name="dataList">The list of data of items for regression.</param>
		/// <returns>Predicted numeric value.</returns>
		List<double> Regress(Guid modelInstanceUId, IList<Dictionary<string, object>> dataList);

		#endregion

	}

	#endregion

	#region Class: MLServiceProxy

	/// <summary>
	/// Base implementation of <see cref="IMLServiceProxy"/>.
	/// </summary>
	/// <seealso cref="IMLServiceProxy" />
	[DefaultBinding(typeof(IMLServiceProxy))]
	public class MLServiceProxy : IMLServiceProxy
	{

		#region Constants: Private

		private const string WebExceptionMessage =
			"There's network or timeout exception handled during call '{0}'. Status: {1}, Message: {2}";
		private const string CloudServicesApiKey = "CloudServicesAPIKey";

		#endregion

		#region Fields: Protected

		/// <summary>
		/// The logger.
		/// </summary>
		protected static readonly ILog Log = LogManager.GetLogger("ML");

		/// <summary>
		/// The web service client.
		/// </summary>
		protected ServiceClientBase _serviceClient;

		/// <summary>
		/// The API key.
		/// </summary>
		protected readonly string _apiKey;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLServiceProxy" /> class.
		/// </summary>
		/// <param name="serviceUrl">The service URL.</param>
		/// <param name="apiKey">The API key.</param>
		/// <exception cref="IncorrectConfigurationException">Required system settings are not set.</exception>
		public MLServiceProxy(string serviceUrl, string apiKey) {
			CheckRequiredSetting("MLProblemType.ServiceUrl", serviceUrl);
			CheckRequiredSetting(CloudServicesApiKey, apiKey);
			ClassifyTimeoutSec = 5;
			_apiKey = apiKey;
			if (ClassFactory.TryGet("MLServiceClient", out _serviceClient)) {
				_serviceClient.BaseUri = serviceUrl;
			} else {
				_serviceClient = new JsonServiceClient(serviceUrl);
			}
			_serviceClient.LocalHttpWebRequestFilter = request => {
				request.Headers.Add("ApiKey", apiKey);
			};
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MLServiceProxy" /> class for the custom scoring and
		/// classification endpoints.
		/// </summary>
		/// <param name="serviceUrl">The service URL.</param>
		/// <param name="apiKey">The API key.</param>
		/// <param name="classifyMethodName">Classification endpoint.</param>
		/// <param name="scoreMethodName">Scoring endpoint.</param>
		/// <exception cref="IncorrectConfigurationException">Required system settings are not set.</exception>
		public MLServiceProxy(string serviceUrl, string apiKey, string classifyMethodName, string scoreMethodName)
				: this(serviceUrl, apiKey) {
			ClassifyMethodName = classifyMethodName;
			ScoreMethodName = scoreMethodName;
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// The default request timeout (sec).
		/// </summary>
		protected virtual int DefaultTimeoutSec { get; } = 30;

		/// <summary>
		/// Upload data request timeout (sec).
		/// </summary>
		protected virtual int UploadDataTimeoutSec { get; } = 60;

		/// <summary>
		/// Classification request timeout (sec).
		/// </summary>
		protected virtual int ClassifyTimeoutSec { get; } = 5;

		/// <summary>
		/// Scoring request timeout (sec).
		/// </summary>
		protected virtual int ScoreTimeoutSec { get; } = 5;

		/// <summary>
		/// Batch scoring request timeout (sec).
		/// </summary>
		protected virtual int BatchScoreTimeoutSec { get; } = 300;

		/// <summary>
		/// Regression request timeout (sec).
		/// </summary>
		protected virtual int RegressionTimeoutSec { get; } = 5;

		/// <summary>
		/// Batch regression request timeout (sec).
		/// </summary>
		protected virtual int BatchRegressionTimeoutSec { get; } = 300;

		/// <summary>
		/// Start session request service endpoint.
		/// </summary>
		protected virtual string StartSessionMethodName { get; } = "/session/start";

		/// <summary>
		/// Upload data request service endpoint.
		/// </summary>
		protected virtual string UploadDataMethodName { get; } = "/data/upload";

		/// <summary>
		/// Get session info request service endpoint.
		/// </summary>
		protected virtual string GetSessionInfoMethodName { get; } = "/session/info/get";

		/// <summary>
		/// Classification request service endpoint.
		/// </summary>
		protected virtual string ClassifyMethodName { get; } = "classifier/predict";

		/// <summary>
		/// Scoring request service endpoint.
		/// </summary>
		protected virtual string ScoreMethodName { get; } = "scorer/predict";

		/// <summary>
		/// Regression request service endpoint.
		/// </summary>
		protected virtual string RegressMethodName { get; } = "regressor/predict";

		#endregion

		#region Method: Private

		private static void CheckRequiredSetting(string settingName, string settingValue) {
			if (settingValue.IsNullOrEmpty()) {
				throw new IncorrectConfigurationException(settingName);
			}
		}

		private TOut Predict<TIn, TOut>(Guid modelInstanceUId, IList<Dictionary<string, object>> dataList,
				string methodName, int timeoutSec, bool predictContributions)
				where TIn : PredictionRequest<PredictionInput>, new() {
			modelInstanceUId.CheckArgumentEmpty(nameof(modelInstanceUId));
			dataList.CheckArgumentNullOrEmpty(nameof(dataList));
			var request = new TIn {
				ApiKey = _apiKey,
				ModelId = modelInstanceUId,
				Data = new List<PredictionInput>(),
				PredictContributions = predictContributions
			};
			foreach (Dictionary<string, object> data in dataList) {
				var input = new PredictionInput();
				data.ForEach(keyValue => input.Add(keyValue.Key, keyValue.Value));
				request.Data.Add(input);
			}
			TOut response = Post<TOut>(methodName, request, timeoutSec);
			return response;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Posts data to the specified method.
		/// </summary>
		/// <typeparam name="T">Response output type.</typeparam>
		/// <param name="methodName">Name of the service method.</param>
		/// <param name="requestBody">The request body.</param>
		/// <param name="timeoutSec">The timeout sec.</param>
		/// <returns>Response's output.</returns>
		protected T Post<T>(string methodName, object requestBody, int timeoutSec) {
			T response;
			try {
				using (var scope = JsConfig.BeginScope()) {
					scope.DateHandler = JsonDateHandler.ISO8601;
					_serviceClient.Timeout = TimeSpan.FromSeconds(timeoutSec);
					response = _serviceClient.Post<T>(methodName, requestBody);
				}
			} catch (WebServiceException ex) {
				switch (ex.StatusCode) {
					case (int)HttpStatusCode.Unauthorized:
						throw new IncorrectConfigurationException(CloudServicesApiKey, _apiKey);
					case (int)HttpStatusCode.NotFound:
						throw new IncorrectConfigurationException("Service method", methodName,
							"Service method not found");
					case (int)HttpStatusCode.Forbidden:
						throw new Exception(ex.ErrorMessage, ex);
					case (int)HttpStatusCode.InternalServerError:
						string message = $"[{HttpStatusCode.InternalServerError}] {ex.ResponseStatus?.Message}";
						Log.Error(message, ex);
						throw new HttpException(ex.StatusCode, message, ex);
					case (int)HttpStatusCode.BadRequest:
						string errorMessage = $"[{HttpStatusCode.BadRequest}] methodName: "
							+ $"{methodName} {ex.ResponseDto?.SerializeAndFormat()}";
						Log.Error(errorMessage);
						throw new HttpException(ex.StatusCode, errorMessage, ex);
					default:
						throw;
				}
			} catch (WebException ex) {
				Log.ErrorFormat(WebExceptionMessage, methodName, ex.Status, ex.Message);
				throw;
			}
			return response;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Starts new train session.
		/// </summary>
		/// <param name="metaData">Meta data of the model's input and output.</param>
		/// <param name="modelSchemaId">ML model schema identifier.</param>
		/// <returns>
		/// The identifier of the started session.
		/// </returns>
		public Guid StartTrainSession(string metaData, Guid modelSchemaId) {
			var request = new StartSessionRequest {
				ApiKey = _apiKey, // TODO 7.14.1 | Remove api key from request's body
				ModelSchemaMetadata = metaData,
				ModelSchemaId = modelSchemaId
			};
			StartSessionResponse response = Post<StartSessionResponse>(StartSessionMethodName, request,
				DefaultTimeoutSec);
			return response.SessionId;
		}

		/// <summary>
		/// Uploads data to the service.
		/// </summary>
		/// <param name="data">Data to upload.</param>
		/// <param name="sessionId">The identifier of the upload / training session.</param>
		public void UploadData(string data, Guid sessionId) {
			data.CheckArgumentNull("data");
			sessionId.CheckArgumentEmpty("sessionId");
			var request = new UploadDataRequest {
				Data = data,
				SessionId = sessionId,
				ApiKey = _apiKey
			};
			Post<string>(UploadDataMethodName, request, UploadDataTimeoutSec);
		}

		/// <summary>
		/// Begins the training.
		/// </summary>
		/// <param name="trainSessionId">The train session identifier.</param>
		/// <param name="methodName">Name of the web method.</param>
		public void BeginTraining(Guid trainSessionId, string methodName) {
			trainSessionId.CheckArgumentEmpty("trainSessionId");
			var request = new BeginClassifierTrainingRequest {
				SessionId = trainSessionId,
				ApiKey = _apiKey
			};
			Post<string>(methodName, request, DefaultTimeoutSec);
		}

		/// <summary>
		/// Gets information about the training session.
		/// </summary>
		/// <param name="trainSessionId">The train session identifier.</param>
		/// <returns>Session state. If session is completed, returns information about the training.</returns>
		public GetSessionInfoResponse GetTrainingSessionInfo(Guid trainSessionId) {
			trainSessionId.CheckArgumentEmpty("trainSessionId");
			var request = new GetSessionInfoRequest {
				SessionId = trainSessionId,
				ApiKey = _apiKey
			};
			GetSessionInfoResponse response =
				Post<GetSessionInfoResponse>(GetSessionInfoMethodName, request, DefaultTimeoutSec);
			return response;
		}

		/// <summary>
		/// Calls classification service.
		/// </summary>
		/// <param name="modelInstanceUId">The model instance id.</param>
		/// <param name="data">Input data fields for classification model.</param>
		/// <returns>
		/// List of <see cref="ClassificationResult" />.
		/// </returns>
		public List<ClassificationResult> Classify(Guid modelInstanceUId, Dictionary<string, object> data) {
			ClassificationResponse response = Predict<ClassificationRequest, ClassificationResponse>(modelInstanceUId,
				new List<Dictionary<string, object>> { data }, ClassifyMethodName, ClassifyTimeoutSec, false);
			return response.Outputs.FirstOrDefault();
		}

		/// <summary>
		/// Scores rate for item with the given data using the specified model.
		/// </summary>
		/// <param name="model">Model, that should perform scoring.</param>
		/// <param name="data">The data of the item that should be scored.</param>
		/// <param name="predictContributions">
		/// Indicates, if service should return individual feature contributions to overall prediction.
		/// </param>
		/// <returns>Predicted score rate.</returns>
		public ScoringOutput Score(MLModelConfig model, Dictionary<string, object> data, bool predictContributions) {
			ScoringResponse response = Predict<ScoringRequest, ScoringResponse>(model.ModelInstanceUId,
				new List<Dictionary<string, object>> { data }, model.PredictionEndpoint,
				ScoreTimeoutSec, predictContributions);
			return response.Outputs.FirstOrDefault();
		}

		/// <summary>
		/// Scores rates for list of items with the given data using the specified model.
		/// </summary>
		/// <param name="model">Model, that should perform scoring.</param>
		/// <param name="dataList">The list of data of items that should be scored.</param>
		/// <param name="predictContributions">
		/// Indicates, if service should return individual feature contributions to overall prediction.
		/// </param>
		/// <returns>Predicted score rates.</returns>
		public List<ScoringOutput> Score(MLModelConfig model, IList<Dictionary<string, object>> dataList,
				bool predictContributions) {
			int count = Math.Min(1, dataList.Count);
			int timeout = Math.Max(ScoreTimeoutSec * count, BatchScoreTimeoutSec);
			ScoringResponse response = Predict<ScoringRequest, ScoringResponse>(model.ModelInstanceUId,
				dataList, model.PredictionEndpoint, timeout, predictContributions);
			return response.Outputs;
		}

		/// <summary>
		/// Performs regression of numeric value for list of items with the given data using the specified model.
		/// </summary>
		/// <param name="modelInstanceUId">The model instance identifier.</param>
		/// <param name="dataList">The list of data of items for regression.</param>
		/// <returns>
		/// Predicted numeric value.
		/// </returns>
		public List<double> Regress(Guid modelInstanceUId, IList<Dictionary<string, object>> dataList) {
			int timeout = Math.Max(RegressionTimeoutSec * dataList.Count, BatchRegressionTimeoutSec);
			List<double> response = Predict<RegressionRequest, List<double>>(modelInstanceUId, dataList,
				RegressMethodName, timeout, false);
			return response;
		}

		#endregion

	}

	#endregion

}

