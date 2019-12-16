namespace Terrasoft.Configuration.CaseSequenceService
{
	using System;
	using System.ServiceModel;
	using System.ServiceModel.Web;
	using System.ServiceModel.Activation;
	using System.Text;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Web.Common;
	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;

	//TODO Remove this class after complete #SD-3271
	#region Class: CaseSequence

	[Obsolete("Class will be removed in 7.10.2 version")]
	public class CaseSequence
	{

		#region Constructors: Public

		public CaseSequence(UserConnection userConnection, string sequenceName) {
			UserConnection = userConnection;
			SequenceName = sequenceName;
		}

		#endregion

		#region Properties: Public

		public UserConnection UserConnection { get; private set; }

		public string SequenceName { get; private set; }

		#endregion

		#region Methods: Private


		/*SELECT NEXT VALUE FOR [dbo].[Test.CountGetOne] */
		private string BuildNextValueSequenceSqlText(string sequenceName) {
			StringBuilder sb = new StringBuilder(50);
			sb.Append("SELECT NEXT VALUE FOR [dbo].[");
			sb.Append(sequenceName);
			sb.Append("]");
			return sb.ToString();
		}

		private int GetNextValue(string sqlText) {
			var customQuery = new CustomQuery(UserConnection, sqlText);
			return customQuery.ExecuteScalar<int>();
		}

		#endregion

		#region Methods: Public

		public string GetSqlText() {
			return BuildNextValueSequenceSqlText(SequenceName);
		}

		public int NextValue() {
			var sqlText = GetSqlText();
			return GetNextValue(sqlText);
		}

		#endregion

	}

	#endregion

	[Obsolete("Service will be removed in 7.10.2 version")]
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class CaseSequenceService : BaseService
	{
		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public string GetIncrementValueVsMask(string sysSettingName, string sysSettingMaskName) {
			string sysSettingsCodeMask = (string)CoreSysSettings.GetValue(UserConnection, sysSettingMaskName);
			var coreSysSettings = new CoreSysSettings(UserConnection);
			string result = string.Empty;
			if (GlobalAppSettings.UseDBSequence) {
				var sequence = new CaseSequence(UserConnection, sysSettingName);
				result = string.Format(sysSettingsCodeMask, sequence.NextValue());
				return result;
			}
			if (coreSysSettings.FetchFromDB("Code", sysSettingName)) {
				int sysSettingsLastNumber = Convert.ToInt32(CoreSysSettings.GetDefValue(UserConnection, sysSettingName));
				++sysSettingsLastNumber;
				CoreSysSettings.SetDefValue(UserConnection, sysSettingName, sysSettingsLastNumber);
				result = string.Format(sysSettingsCodeMask, sysSettingsLastNumber);
			}
			return result;
		}

		#endregion
	}
}
