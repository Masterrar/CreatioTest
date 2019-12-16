namespace Terrasoft.Configuration.Calendars
{
	using System;
	using System.Collections.Generic;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Core;
	using Core.Factories;
	using Newtonsoft.Json;
	using TermCalculationService;
	using Terrasoft.Web.Common;

	#region Class : CaseTermCalculationService

	/// <summary>
	/// A class-service for case term calculation.
	/// </summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class CaseTermCalculationService : BaseService
	{

		#region Class: ServiceTermStringResponse

		[Serializable]
		[DataContract]
		protected class ServiceTermStringResponse
		{
			#region Properties: Public

			[DataMember(Name = "ReactionTime")]
			public string ReactionTime {
				get;
				set;
			}

			[DataMember(Name = "SolutionTime")]
			public string SolutionTime {
				get;
				set;
			}

			#endregion

		}

		#endregion

		#region Fields : Private

		private static readonly string _dateFormat = "yyyy'-'MM'-'dd HH':'mm':'ss";
		private UserConnection _userConnection;

		#endregion

		#region Methods: Private

		/// <summary>
		/// Replaces strings in given dictionary by guids.
		/// </summary>
		/// <param name="oldDictionary">Initial dictionary.</param>
		/// <returns>Dictionary with guids.</returns>
		private Dictionary<string, object> GetDictionaryWithGuids(Dictionary<string, object> oldDictionary) {
			var resultDictionary = new Dictionary<string, object>();
			foreach (var element in oldDictionary) {
				Guid guid;
				var value = Guid.TryParse(element.Value.ToString(), out guid) ? guid : element.Value;
				resultDictionary.Add(element.Key, value);
			}
			return resultDictionary;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Counts reaction time and a solution time to Case.
		/// </summary>
		/// <param name="conditions">Json-formatted string conditions for terms counting.</param>
		/// <param name="registrationDate">Json-formatted string of case registration date.</param>
		/// <returns>An object that contains the reaction time and solution time.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
			ResponseFormat = WebMessageFormat.Json)]
		public string CalculateTerms(Dictionary<string, object> arguments, string registrationDate) {
			Dictionary<string, object> featuredDictionary = GetDictionaryWithGuids(arguments);
			var parsedRegistrationDate = DateTime.Parse(registrationDate);
			var stringResponse = new ServiceTermStringResponse();
			try {
				var userConnectionArg = new ConstructorArgument("userConnection", UserConnection);
				var entryPoint = ClassFactory.Get<CaseTermCalculateEntryPoint>(userConnectionArg);
				ServiceTermResponse response = entryPoint.CalculateTerms(featuredDictionary, parsedRegistrationDate);
				if (response.ReactionTime != null) {
					stringResponse.ReactionTime = response.ReactionTime.Value.ToString(_dateFormat);
				}
				if (response.SolutionTime != null) {
					stringResponse.SolutionTime = response.SolutionTime.Value.ToString(_dateFormat);
				}
			} catch (Exception e) {
				return e.Message;
			}
			return JsonConvert.SerializeObject(stringResponse);
		}

		#endregion

	}

	#endregion

}
