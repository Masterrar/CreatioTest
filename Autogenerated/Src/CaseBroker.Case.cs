namespace Terrasoft.Configuration.CaseService
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;

	#region Class: CaseBroker

	/// <summary>
	/// Class represents an intermediary for working with Case entity.
	/// </summary>
	public class CaseBroker
	{

		#region Methods: Private

		private Entity GetEntity(Entity currentEntity, bool needFetch) {
			Entity localEntity = currentEntity;
			if (needFetch) {
				var clearSchema = currentEntity.EntitySchemaManager.FindInstanceByName(currentEntity.SchemaName);
				localEntity = clearSchema.CreateEntity(currentEntity.UserConnection);
				localEntity.UseAdminRights = false;
				localEntity.FetchFromDB(currentEntity.PrimaryColumnValue);
			}
			return localEntity;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Reopen case entity whether condition of predicate is correct.
		/// </summary>
		/// <param name="entities">List of case entities.</param>
		/// <param name="predicate">Predicate to check the condition for reopen.</param>
		/// <param name="needFetch">Need reload entity from data base.</param>
		/// <returns>Count of reopened cases.</returns>
		public virtual int ReopenOnCondition(IEnumerable<Entity> entities, Predicate<Entity> predicate,
				bool needFetch = false) {
			int reopened = 0;
			foreach (Entity entity in entities) {
				if (predicate(entity)) {
					var localEntity = GetEntity(entity, needFetch);
					localEntity.SetColumnValue("StatusId", CaseConsts.CaseStatusReopenedId);
					var userConnection = localEntity.UserConnection;
					var clearAssigneeOnCaseReopening = Core.Configuration.SysSettings
						.GetValue<bool>(userConnection, "ClearAssigneeOnCaseReopening", true);
					if (clearAssigneeOnCaseReopening) {
						localEntity.SetColumnValue("OwnerId", null);
					}
					localEntity.Save(false);
					reopened++;
				}
			}
			return reopened;
		}

		/// <summary>
		/// Close case entity whether condition of predicate is correct.
		/// </summary>
		/// <param name="entity">Case entity.</param>
		/// <param name="predicate">Predicate to check the condition for case closing.</param>
		/// <param name="needFetch">Need reload entity from database.</param>
		/// <returns>Is case saved.</returns>
		public virtual bool CloseOnCondition(Entity entity, Predicate<Entity> predicate,
			bool needFetch = false) {
			var userConnection = entity.UserConnection;
			var closureCodeId = SystemSettings.GetValue(userConnection,
				"CaseClosureCodeDef", Guid.Empty);
			return CloseOnCondition(entity, predicate, CaseConsts.CaseStatusClosedId, closureCodeId, needFetch);
		}

		/// <summary>
		/// Close case entity whether condition of predicate is correct.
		/// </summary>
		/// <param name="entity">Case entity.</param>
		/// <param name="predicate">Predicate to check the condition for case closing.</param>
		/// <param name="statusId">Status identifier.</param>
		/// <param name="closureCodeId">Closure code identifier.</param>
		/// <param name="needFetch">Need reload entity from database.</param>
		/// <returns>Is case saved.</returns>
		public virtual bool CloseOnCondition(Entity entity, Predicate<Entity> predicate, Guid statusId, 
			Guid closureCodeId, bool needFetch = false) {
			if (predicate(entity)) {
				var userConnection = entity.UserConnection;
				var localEntity = GetEntity(entity, needFetch);
				localEntity.SetColumnValue("StatusId", statusId);
				localEntity.SetColumnValue("ClosureDate", userConnection.CurrentUser.GetCurrentDateTime());
				localEntity.SetColumnValue("ClosureCodeId", closureCodeId);
				localEntity.Save(false);
				return true;
			}
			return false;
		}

		/// <summary>
		/// Checks whether case status is final.
		/// </summary>
		/// <param name="caseId">Case identifier.</param>
		/// <param name="userConnection">User connection.</param>
		/// <returns></returns>
		public virtual bool IsCaseFinal(Guid caseId, UserConnection userConnection) {
			if (caseId == default(Guid)) {
				return true;
			}
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "Case");
			esq.AddColumn("Status.IsFinal");
			var @case = esq.GetEntity(userConnection, caseId);
			bool isFinal = @case == null ? true : @case.GetTypedColumnValue<bool>("Status_IsFinal");
			return isFinal;
		}

		#endregion

	}

	#endregion

}
