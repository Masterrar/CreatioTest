namespace Terrasoft.Configuration.CampaignService
{
	using System;
	using global::Common.Logging;
	
	#region Class: CampaignUtilities
	
	public static class CampaignUtilities
	{

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("CampaignService");

		#endregion

		#region Properties: Public

		/// <summary>
		/// ###### ### ########## # CampaignService.
		/// </summary>
		public static ILog Log {
			get {
				return _log;
			}
		}

		#endregion

	}

	#endregion

}
