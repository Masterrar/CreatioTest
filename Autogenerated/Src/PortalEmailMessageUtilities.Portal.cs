﻿namespace Terrasoft.Configuration
{
	using System;
	using global::Common.Logging;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region PortalEmailMessageUtilities

	/// <summary>
	/// Represents utility class for work with portal email messages.
	/// </summary>
	public static class PortalEmailMessageUtilities
	{

		private const string ActivitySchemaName = "Activity";
		private static readonly ILog _log = LogManager.GetLogger("PortalEmailMessage");

		#region Methods: Private

		/// <summary>
		/// Gets message history identifier for the activity.
		/// </summary>
		/// <param name="activity">Activity entity.</param>
		/// <returns>Identifier of CaseMessageHistory record to be add to the PortalEmailMessage.</returns>
		private static Guid GetCaseMesssageHistoryId(Entity activity) {
			var select = GetCaseMessageHistorySelect(activity);
			return select.ExecuteScalar<Guid>();
		}

		/// <summary>
		/// Creates select query to CaseMessageHistory with filter by CaseContact in ActivityParticipants.
		/// </summary>
		/// <param name="activity">Activity entity.</param>
		/// <returns>Select query with filters by case CaseContact in ActivityParticipants.</returns>
		private static Select GetCaseMessageHistorySelect(Entity activity) {
			Guid activityId = activity.GetTypedColumnValue<Guid>("Id");
			Guid caseId = activity.GetTypedColumnValue<Guid>("CaseId");
			return new Select(activity.UserConnection)
				.Top(1)
				.Column("CaseMessageHistory", "Id")
				.From("Case")
				.Join(JoinType.Inner, "Activity")
					.On("Case", "Id").IsEqual("Activity", "CaseId")
				.Join(JoinType.Inner, "CaseMessageHistory")
					.On("Case", "Id").IsEqual("CaseMessageHistory", "CaseId")
					.And("Activity", "Id").IsEqual("CaseMessageHistory", "RecordId")
				.Join(JoinType.Inner, "ActivityParticipant")
					.On("Activity", "Id").IsEqual("ActivityParticipant", "ActivityId")
					.And("ActivityParticipant", "ParticipantId").IsEqual("Case", "ContactId")
				.Where("Activity", "Id").IsEqual(Column.Parameter(activityId))
				.And("Case", "Id").IsEqual(Column.Parameter(caseId))
			.And().Not().Exists(
				new Select(activity.UserConnection)
					.Column("PortalEmailMessage", "Id")
					.From("PortalEmailMessage")
					.Where("PortalEmailMessage", "CaseMessageHistoryId")
					.IsEqual("CaseMessageHistory", "Id") as Select
			) as Select;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Shows email on portal if CaseContact exists in ActivityParticipants.
		/// </summary>
		/// <param name="activity">Activity entity.</param>
		/// <returns>True, if record was showed, otherwise - false.</returns>
		/// <exception cref="NotSupportedException">Throws when <paramref name="activity"/> isn't an Activity.</exception>
		public static bool ShowOnPortal(Entity activity) {
			if (activity.SchemaName != ActivitySchemaName) {
				throw new NotSupportedException();
			}
			var caseMessageHistoryId = GetCaseMesssageHistoryId(activity);
			if (caseMessageHistoryId != Guid.Empty) {
				Guid id = Guid.NewGuid();
				var insert = new Insert(activity.UserConnection)
					.Into("PortalEmailMessage")
					.Set("Id", Column.Parameter(id))
					.Set("CaseMessageHistoryId", Column.Parameter(caseMessageHistoryId))
					.Set("Recipient", Column.Parameter(activity.GetTypedColumnValue<string>("Recepient")))
					.Set("Sender", Column.Parameter(activity.GetTypedColumnValue<string>("Sender")))
					.Set("SendDate", Column.Parameter(activity.GetTypedColumnValue<DateTime>("SendDate")))
					.Set("IsHtmlBody", Column.Parameter(activity.GetTypedColumnValue<bool>("IsHtmlBody")))
					.Set("MessageTypeId", Column.Parameter(activity.GetTypedColumnValue<Guid>("MessageTypeId")));
				bool insertExecuted = insert.Execute() == 1;
				if (insertExecuted) {
					Guid sysAdminUnitId = activity.UserConnection.CurrentUser.Id;
					_log.InfoFormat($"Record with Id {id} and CaseMessageHistoryId {caseMessageHistoryId} " +
						$"was added by SysAdminUnit {sysAdminUnitId}");
				}
				return insertExecuted;
			}
			return false;
		}

		#endregion

	}

	#endregion

}