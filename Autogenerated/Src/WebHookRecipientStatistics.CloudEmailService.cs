namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Core;
	using Core.DB;

	#region Class: RecipientStatistics

	public class RecipientStatistics : BaseWebHook
	{

		#region Properties: Public

		public Guid RecipientUId {
			get;
			set;
		}

		public Guid EmailId {
			get;
			set;
		}

		public string ResponseCode {
			get;
			set;
		}

		public int Opens {
			get;
			set;
		}

		public int Clicks {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		public override string GetGroupKey() {
			return base.GetGroupKey() + RecipientUId.ToString();
		}

		public override void HandleWebHook(UserConnection userConnection) {
			long timeStamp = WebHookUtilities.GetEpochTime(EventDate);
			new Insert(userConnection)
				.Into("MandrillMessageResponse")
				.Set("MandrillId", Column.Parameter(RecipientUId))
				.Set("ResponseCode", Column.Parameter(ResponseCode))
				.Set("Opens", Column.Parameter(Opens))
				.Set("Clicks", Column.Parameter(Clicks))
				.Set("TimeStamp", Column.Parameter(timeStamp))
				.Set("BulkEmailId", Column.Parameter(EmailId))
				.Execute();
		}

		#endregion

	}

	#endregion

}
