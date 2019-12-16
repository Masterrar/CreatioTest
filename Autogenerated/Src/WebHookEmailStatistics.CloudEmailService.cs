namespace Terrasoft.Configuration
{
	using System;
	using Core;
	using Core.DB;
	
	#region Class: EmailStatistics

	public class EmailStatistics : BaseWebHook
	{

		#region Properties: Public

		public Guid EmailId {
			get;
			set;
		}

		public int Clicks {
			get;
			set;
		}

		public int Opens {
			get;
			set;
		}

		public int SoftBounce {
			get;
			set;
		}

		public int HardBounce {
			get;
			set;
		}

		public int Spam {
			get;
			set;
		}

		public int Delivered {
			get;
			set;
		}

		public int Sent {
			get;
			set;
		}

		public int Rejected {
			get;
			set;
		}

		public int Unsubscribe {
			get;
			set;
		}

		public int DeliveryError {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		public override string GetGroupKey() {
			return base.GetGroupKey() + EmailId.ToString();
		}

		public override void HandleWebHook(UserConnection userConnection) {
			new Update(userConnection, "BulkEmail")
				.Set("SendCount", Column.Parameter(Sent))
				.Set("HardBounceCount", Column.Parameter(HardBounce))
				.Set("SoftBounceCount", Column.Parameter(SoftBounce))
				.Set("RejectedCount", Column.Parameter(Rejected))
				.Set("UnsubscribeCount", Column.Parameter(Unsubscribe))
				.Set("SpamCount", Column.Parameter(Spam))
				.Set("ClicksCount", Column.Parameter(Clicks))
				.Set("OpensCount", Column.Parameter(Opens))
				.Set("DeliveredCount", Column.Parameter(Delivered))
				.Set("ModifiedById", Column.Parameter(MarketingConsts.MandrillUserId))
				.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
				.Set("StatisticDate", Column.Parameter(DateTime.UtcNow))
				.Set("DeliveryError", Column.Parameter(DeliveryError))
				.Where("Id").IsEqual(Column.Parameter(EmailId)).Execute();
		}

		#endregion

	}
	
	#endregion
}
