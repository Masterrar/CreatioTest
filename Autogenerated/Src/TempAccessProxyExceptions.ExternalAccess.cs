namespace Terrasoft.Configuration.ExternalAccessPackage
{
	using System;

	#region Class: ApiServerException

	/// <summary>
	/// The exception that is thrown when proxy got error from api server.
	/// </summary>
	public class ApiServerException : Exception
	{

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="ApiServerException"/> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public ApiServerException(string message)
			: base(message) {
		}

		#endregion

	}

	#endregion

	#region Class: ApiServerConnectivityException

	/// <summary>
	/// The exception that is thrown when api call failed due client timeout, network problems, DNS failure, etc.
	/// </summary>
	public class ApiServerConnectivityException : Exception
	{

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="ApiServerException"/> class.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public ApiServerConnectivityException(string message)
			: base(message) {
		}

		#endregion

	}

	#endregion

}
