namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.MandrillService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UpdateTargetAudienceProcessHelper

	/// <exclude/>
	public class UpdateTargetAudienceProcessHelper
	{


		public UpdateTargetAudienceProcessHelper(UserConnection userConnection) {
			this.UserConnection = userConnection;
		}

		#region Properties: Public
		protected string _name = "UpdateTargetAudienceProcessHelper";
		public virtual string Name {
			get {
				return _name;
			}
			set {
				_name = value;
			}
		}
		
		
		public virtual Guid TargetSchemaUId {
			get;
			set;
		}

		public virtual Guid TargetFolderSchemaUId {
			get;
			set;
		}

		public virtual Guid RootSchemaRecordId {
			get;
			set;
		}

		public virtual string TargetSchemaName {
			get;
			set;
		}

		public virtual string TargetSchemaBindingColumnValueName {
			get;
			set;
		}
		protected string _rootSchemaName;
		public virtual string RootSchemaName {
				get;set;
		}

		public virtual string SegmentSchemaName {
			get;
			set;
		}

		public virtual Guid DefResponseId {
			get;
			set;
		}

		public virtual string ResponseColumnName {
			get;
			set;
		}

		public virtual string TargetName {
			get;
			set;
		}

		public virtual string SegmentTargetReferenceSchemaName {
			get;
			set;
		}

		public virtual Object Logger {
			get;
			set;
		}

		public virtual string SessionKey {
			get;
			set;
		}

		public virtual int RootSchemaRecordRId {
			get;
			set;
		}

		public virtual Guid SuccessStatusId {
			get;
			set;
		}

		public virtual bool IsSetCampaignFirstStep {
			get;
			set;
		}

		public UserConnection UserConnection {
			get;set;
		}

		public LocalizableString SuccessMessage {
			get {
				return GetLczString("SuccessMessage");
			}
		}

		public LocalizableString RemindingCaption {
			get {
				return GetLczString("RemindingCaption");
			}
		}

		public LocalizableString EventRemindingCaption {
			get {
				return GetLczString("EventRemindingCaption");
			}
		}

		public LocalizableString CampaignRemindingCaption {
			get {
				return GetLczString("CampaignRemindingCaption");
			}
		}

		public LocalizableString FailMessage {
			get {
				return GetLczString("FailMessag");
			}
		}

		#endregion

		#region Methods: Private

		private string GetLczString(string lczName) {
			string localizableStringName = string.Format("LocalizableStrings.{0}.Value", lczName);
			return new LocalizableString(
				UserConnection.Workspace.ResourceStorage, 
				"UpdateTargetAudienceProcessHelper", 
				localizableStringName
			);
		}

		private void AddConditionForSubscribtion(Select resultSelect) {
			Select subQuery = CreateUnsubscribedSubQuery(RootSchemaRecordId);
			if (resultSelect.HasCondition) {
				resultSelect.And().Not().Exists(subQuery);
			} else {
				resultSelect.Where().Not().Exists(subQuery);
			}
		}

		#endregion

		#region Methods: Public

		public virtual void UpdateTargetAudience() {
			if (string.IsNullOrEmpty(RootSchemaName) || RootSchemaRecordId.IsEmpty()) {
				return;
			}
			switch(RootSchemaName) {
					case "Event":
						DefResponseId = MarketingConsts.EventResponsePlannedId;
						TargetSchemaBindingColumnValueName = "EventId";
						TargetSchemaName = "EventTarget";
						SegmentSchemaName = "EventSegment";
						ResponseColumnName = "EventResponseId";
						break;
					case "BulkEmail":
						RootSchemaRecordRId = GetBulkEmailRootSchemaRecordRId(RootSchemaRecordId);
						TargetSchemaBindingColumnValueName = "BulkEmailRId";
						TargetSchemaName = "MandrillRecipient";
						SegmentSchemaName = "BulkEmailSegment";
						if(RootSchemaRecordRId == 0){
							return;
						}
						break;
					case "Campaign":
						DefResponseId = MarketingConsts.CampaignTargetStatusPlannedId;
						TargetSchemaBindingColumnValueName = "CampaignId";
						TargetSchemaName = "CampaignTarget";
						SegmentSchemaName = "CampaignSegment";
						ResponseColumnName = "CampaignResponseId";
						break;
				}
			TargetSchemaUId = new Guid("16BE3651-8FE2-4159-8DD0-A803D4683DD3");//SysSchema - Contact
			TargetFolderSchemaUId = new Guid("8B5C01A2-59E9-40DC-855B-6E3BEBDDC6EE");//SysSchema - ContactFolder
			TargetName = "Contact";
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, SegmentSchemaName);
			esq.AddColumn("Segment");
			esq.AddColumn("Segment.FolderType");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
					false, RootSchemaName, RootSchemaRecordId));
			int targetAudienceCounter = 0;
				processStart:
			try {
				var selectList = new List<Select>();
				SetRootStatus(MarketingConsts.SegmentStatusUpdatingId, -1, DateTime.MinValue);
				EntityCollection folders = esq.GetEntityCollection(UserConnection);
				if (!folders.Any()) {
					return;
				}
				List<Guid> staticFolders = new List<Guid>();
				foreach(Entity folder in folders) {
					Guid folderId = folder.GetTypedColumnValue<Guid>("SegmentId");
					Guid folderTypeId = folder.GetTypedColumnValue<Guid>("Segment_FolderTypeId");
					if (folderTypeId == MarketingConsts.FolderTypeDynamicId) {
						selectList.Add(ProcessDynamicFolder(folderId));
					} else {
						staticFolders.Add(folderId);
					}
				}
				if (staticFolders.Any()) {
					var staticFolder = ProcessStaticFolders(staticFolders);
					if (staticFolder != null) {
						selectList.Add(staticFolder);
					}
				}
				if (selectList.Any()) {
					targetAudienceCounter = ExecuteSelectInsert(selectList);
				}
			} catch (Exception e) {
				LogError("Error updating a target audience.", e);
				FailOperation();
				return;
			}
			if (targetAudienceCounter == -1) {
				esq.ResetSelectQuery();
				goto processStart;
			}
			SuccessOperation(targetAudienceCounter);
		}

		public virtual Select ProcessStaticFolders(List<Guid> folders) {
			Select resultSelect;
switch(RootSchemaName) {
	case "Event":
		resultSelect = GetContactInEventStaticFolderProcessingQuery(folders);
		break;
	case "BulkEmailSplit":
	case "BulkEmail":
		resultSelect = GetContactInBulkEmailStaticFolderProcessingQuery(folders);
		break;
	case "Campaign":
		resultSelect = GetContactInCampaignStaticFolderProcessingQuery(folders);
		break;
	default:
		resultSelect = null;
		break;
}
return resultSelect;
		}

		public virtual Select ProcessDynamicFolder(Guid folderId) {
			var dataValueTypeManager = (DataValueTypeManager)UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
DataValueType dateTimeDataValueType = dataValueTypeManager.GetInstanceByName("DateTime");
DataValueType guidDataValueType = dataValueTypeManager.GetInstanceByName("Guid");
DataValueType intDataValueType = dataValueTypeManager.GetInstanceByName("Integer");
EntitySchema targetSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(TargetSchemaUId);
IEntitySchemaQueryFilterItem filters = CommonUtilities.GetFolderEsqFilters(
	UserConnection, folderId, TargetFolderSchemaUId, TargetSchemaUId, true);
var esq = new EntitySchemaQuery(targetSchema);
if(RootSchemaName.Equals("BulkEmail") || RootSchemaName.Equals("BulkEmailSplit")) {
	esq.AddColumn(RootSchemaRecordRId, intDataValueType).SetForcedQueryColumnValueAlias("RootSchemaRecordId");
	esq.AddColumn("Email");
} else {
	esq.AddColumn(RootSchemaRecordId, guidDataValueType).SetForcedQueryColumnValueAlias("RootSchemaRecordId");;
	esq.AddColumn(DefResponseId, guidDataValueType);
	esq.AddColumn(true, dataValueTypeManager.GetInstanceByName("Boolean"));
	esq.AddColumn(UserConnection.CurrentUser.ContactId, guidDataValueType);
	esq.AddColumn(UserConnection.CurrentUser.ContactId, guidDataValueType);
	esq.AddColumn("Id").SetForcedQueryColumnValueAlias("ContactRecordId");
	if(IsSetCampaignFirstStep == true && RootSchemaName == "Campaign") {
		var campaignFirstStepId = GetCampaignFirstStep(RootSchemaRecordId);
		esq.AddColumn(campaignFirstStepId, guidDataValueType).SetForcedQueryColumnValueAlias("CurrentStepId");
	}
}
if (filters != null) {
	esq.Filters.Add(filters);
}
Select folderQuery = esq.GetSelectQuery(UserConnection);
Select resultSelect;
switch(RootSchemaName) {
	case "Event":
		resultSelect = GetContactInEventDynamicFolderProcessingQuery(folderQuery);
		break;
	case "BulkEmailSplit":
	case "BulkEmail":
		resultSelect = GetContactInBulkEmailDynamicFolderProcessingQuery(folderQuery);
		break;
	case "Campaign":
		resultSelect = GetContactInCampaignDynamicFolderProcessingQuery(folderQuery);
		break;
	default:
		resultSelect = null;
		break;
}
return resultSelect;
		}

		public virtual void ClearCurrentTargets() {
			new Delete(UserConnection)
	.From(TargetSchemaName)
	.Where("IsFromGroup").IsEqual(Column.Parameter(true))
	.And(TargetSchemaBindingColumnValueName).IsEqual(Column.Parameter(RootSchemaRecordId))
	.And(ResponseColumnName).IsEqual(Column.Parameter(DefResponseId))
	.Execute();
		}

		public virtual void SetRootStatus(Guid StatusId, int RecipientCount, DateTime ProcessingDate) {
			var update = new Update(UserConnection, RootSchemaName)
	.Set("SegmentsStatusId", Column.Parameter(StatusId))
	.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
	.Set("ModifiedById", Column.Parameter(MarketingConsts.MandrillUserId));
if ((ProcessingDate != DateTime.MinValue) &&
		(RootSchemaName.Equals("Event", StringComparison.CurrentCultureIgnoreCase) ||
		RootSchemaName.Equals("BulkEmail", StringComparison.CurrentCultureIgnoreCase))) {
	update = update.Set("LastActualizeDate", Column.Parameter(ProcessingDate));
}
string targetCounterColumnName;
switch (RootSchemaName) {
	case "Campaign":
		targetCounterColumnName = "TargetTotal";
		break;
	case "BulkEmailSplit":
	case "Event":
	case "BulkEmail":
		targetCounterColumnName = "RecipientCount";
		break;
	default:
		targetCounterColumnName = string.Empty;
		break;
}
if (!string.IsNullOrEmpty(targetCounterColumnName) && RecipientCount >= 0) {
	update = update.Set(targetCounterColumnName, Column.Parameter(RecipientCount));
}
update.Where("Id").IsEqual(Column.Parameter(RootSchemaRecordId));
update.Execute();
		}

		public virtual Entity GetRootEntity() {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName(RootSchemaName);
Entity entity = schema.CreateEntity(UserConnection);
var columnsToFetch = new[] {
	schema.PrimaryColumn,
	schema.PrimaryDisplayColumn
};
if (!entity.FetchFromDB(schema.PrimaryColumn, RootSchemaRecordId, columnsToFetch)) {
	return null;
}
return entity;
		}

		public virtual bool CheckIsProcessRestartRequired() {
			Select checkStatusQuery = (Select)new Select(UserConnection)
	.Column("Id")
	.From(RootSchemaName)
	.Where("Id").IsEqual(Column.Parameter(RootSchemaRecordId))
	.And("SegmentsStatusId").IsEqual(Column.Parameter(MarketingConsts.SegmentStatusRequiresUpdatingId));
using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
	using (IDataReader reader = checkStatusQuery.ExecuteReader(dbExecutor)) {
		return reader.Read();
	}
}
		}

		public virtual int GetRestTargetAudienceCount() {
			Select countQuery = new Select(UserConnection)
	.Column(Func.Count("Id"))
	.From(TargetSchemaName);
if(TargetSchemaName.Equals("MandrillRecipient")) {
	countQuery.Where(TargetSchemaBindingColumnValueName)
		.IsEqual(Column.Parameter(RootSchemaRecordRId));
} else if (!RootSchemaName.Equals("BulkEmailSplit")) {
	countQuery.Where(TargetSchemaBindingColumnValueName)
	.IsEqual(Column.Parameter(RootSchemaRecordId));
}
return (countQuery as Select).ExecuteScalar<int>();
		}

		public virtual Select GetContactInEventStaticFolderProcessingQuery(List<Guid> folders) {
			var resultSelect = new Select(UserConnection)
	.Column(Column.Const(RootSchemaRecordId)).As("RootSchemaRecordId")
	.Column(Column.Const(DefResponseId)).As("EventResponseId")
	.Column(Column.Const(true)).As("IsFromGroup")
	.Column(Column.Const(UserConnection.CurrentUser.ContactId)).As("CreatedById")
	.Column(Column.Const(UserConnection.CurrentUser.ContactId)).As("ModifiedById")
	.Column("Contact", "Id").As("ContactRecordId")
	.From("Contact")
	.Where().Exists(new Select(UserConnection)
		.Column(Column.Parameter("Id"))
		.From("ContactInFolder")
		.Where("ContactId").IsEqual("Contact", "Id")
		.And("FolderId").In(Column.Parameters(folders)))
	.And().Not().Exists(
		new Select(UserConnection)
			.Column("Id")
			.From("EventTarget")
		.Where("EventId").IsEqual(Column.Parameter(RootSchemaRecordId))
			.And("ContactId").IsEqual("Contact", "Id")
	) as Select;
return resultSelect;
		}

		public virtual Select GetContactInBulkEmailStaticFolderProcessingQuery(List<Guid> folders) {
			string emptyEmail = " ";
			var resultSelect = new Select(UserConnection)
	.Column(Column.Const(RootSchemaRecordRId)).As("RootSchemaRecordId")
	.Column(Func.IsNull(Column.SourceColumn("Contact", "Email"), Column.Const(emptyEmail))).As("EmailAddress")
	.Column("Contact", "RId").As("ContactRecordId")
	.From("Contact")
	.Where().Exists(new Select(UserConnection)
		.Column(Column.Parameter("Id"))
		.From("ContactInFolder")
		.Where("ContactId").IsEqual("Contact", "Id")
		.And("FolderId").In(Column.Parameters(folders))
	) as Select;
bool checkSubscription = IsBulkEmailIsSignable(RootSchemaRecordId);
if (checkSubscription) {
	AddConditionForSubscribtion(resultSelect);
}
return resultSelect;
		}

		public virtual Select GetContactInEventDynamicFolderProcessingQuery(Select dynamicFilterSelect) {
			return dynamicFilterSelect;
		}

		public virtual Select GetContactInBulkEmailDynamicFolderProcessingQuery(Select dynamicFilterSelect) {
			dynamicFilterSelect.Column("Contact", "RId").As("ContactRecordId");
bool checkSubscription = IsBulkEmailIsSignable(RootSchemaRecordId);
if (checkSubscription) {
				AddConditionForSubscribtion(dynamicFilterSelect);
			}
return dynamicFilterSelect;
		}

		public virtual bool IsBulkEmailIsSignable(Guid recordId) {
			Select checkSelect = new Select(UserConnection)
	.Column("bulkEmailType", "IsSignable")
	.From("BulkEmailType").As("bulkEmailType")
	.InnerJoin("BulkEmail").As("bulkEmail").On("bulkEmailType", "Id")
	.IsEqual("bulkEmail", "TypeId") as Select;
if (RootSchemaName.Equals("BulkEmailSplit")) {
	checkSelect.Where("bulkEmail", "SplitTestId").IsEqual(Column.Parameter(recordId));
} else {
	checkSelect.Where("bulkEmail", "Id").IsEqual(Column.Parameter(recordId));
}
bool isSignable = false;
using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
	using (IDataReader reader = checkSelect.ExecuteReader(dbExecutor)) {
		while (reader.Read()) {
			bool isSignableValue = UserConnection.DBTypeConverter.DBValueToBool(reader.GetValue(0));
			isSignable = isSignable || isSignableValue;
		}
	}
}
return isSignable;
		}

		public virtual Select CreateUnsubscribedSubQuery(Guid recordId) {
			var select = new Select(UserConnection)
	.Column(Column.Const(1))
	.From("BulkEmailSubscription")
	.Where("ContactId").IsEqual("Contact", "Id")
	.And("BulkEmailSubsStatusId").IsEqual(Column.Parameter(MarketingConsts.BulkEmailContactUnsubscribed)) as Select;
if (RootSchemaName.Equals("BulkEmailSplit")) {
	select.And("BulkEmailTypeId").In(
		new Select(UserConnection)
			.Column("BulkEmail", "TypeId")
			.From("BulkEmail")
			.InnerJoin("BulkEmailType").On("BulkEmail", "TypeId").IsEqual("BulkEmailType", "Id")
			.Where("BulkEmailType", "IsSignable").IsEqual(Column.Parameter(true))
			.And("SplitTestId").IsEqual(Column.Parameter(recordId))
	);
} else {
	select.And("BulkEmailTypeId").In(
		new Select(UserConnection)
			.Column("TypeId")
			.From("BulkEmail")
			.Where("Id").IsEqual(Column.Parameter(recordId))
	);
}
return select;
		}

		public virtual Select GetContactInCampaignStaticFolderProcessingQuery(List<Guid> folders) {
			var resultSelect = new Select(UserConnection)
	.Column(Column.Const(RootSchemaRecordId)).As("RootSchemaRecordId")
	.Column(Column.Const(DefResponseId)).As("CampaignTargetStatusId")
	.Column(Column.Const(true)).As("IsFromGroup")
	.Column(Column.Const(MarketingConsts.MandrillUserId)).As("ModifiedById")
	.Column("Contact", "Id").As("ContactRecordId");
if(IsSetCampaignFirstStep == true && RootSchemaName == "Campaign") {
	var campaignFirstStepId = GetCampaignFirstStep(RootSchemaRecordId);
	resultSelect.Column(Column.Const(campaignFirstStepId)).As("CurrentStepId");
}
resultSelect.From("Contact")
	.Where().Exists(new Select(UserConnection)
		.Column(Column.Parameter("Id"))
		.From("ContactInFolder")
		.Where("ContactId").IsEqual("Contact", "Id")
		.And("FolderId").In(Column.Parameters(folders)))
	.And().Not().Exists(
		new Select(UserConnection)
			.Column("Id")
			.From("CampaignTarget")
			.Where("CampaignId").IsEqual(Column.Parameter(RootSchemaRecordId))
			.And("ContactId").IsEqual("Contact", "Id")
	);
return (resultSelect as Select);
		}

		public virtual Select GetContactInCampaignDynamicFolderProcessingQuery(Select dynamicFilterSelect) {
			return dynamicFilterSelect;
		}

		public virtual int ExecuteSelectInsert(IList<Select> selects) {
			const int packageSize = 50000;

Select unionSelect = selects[0];
for (var i = 1; i < selects.Count; i++) {
	unionSelect = unionSelect.Union(selects[i]) as Select;
}
unionSelect.SpecifyNoLockHints(true);
var execSelect = new Select(UserConnection)
	.Top(packageSize)
	.Column(Column.Asterisk("ResultSelect"))
	.From(unionSelect).As("ResultSelect");
var iterateInsertedCount = 0;
var insertedCount = 0;
var insertSelect = GetInsertSelect(execSelect);
using (var dbExecutor = UserConnection.EnsureDBConnection()) {
	dbExecutor.CommandTimeout = 1800;
	do {
		iterateInsertedCount = insertSelect.Execute(dbExecutor);
		insertedCount += iterateInsertedCount;
		if (CheckIsProcessRestartRequired()) {
			insertedCount = -1;
			break;
		}
	} while (iterateInsertedCount == packageSize);
}
return insertedCount;
		}

		public virtual InsertSelect GetInsertSelect(Select select) {
			InsertSelect insertSelect;
switch(RootSchemaName) {
	case "Event":
		var eventTargetExistsSelect = new Select(UserConnection)
			.From("EventTarget").Column("Id")
			.Where("ContactId").IsEqual("ResultSelect", "ContactRecordId")
			.And("EventId").IsEqual("ResultSelect","RootSchemaRecordId") as Select;
		eventTargetExistsSelect.SpecifyNoLockHints(true);
		insertSelect = new InsertSelect(UserConnection)
			.Into("EventTarget")
			.Set("EventId", "EventResponseId", "IsFromGroup", "CreatedById",
				"ModifiedById", "ContactId")
			.FromSelect(select.Where().Not().Exists(
				eventTargetExistsSelect
			));
		break;
	case "BulkEmailSplit":
	case "BulkEmail":
		var mandrillRecipientExistsSelect = new Select(UserConnection)
			.From(TargetSchemaName).Column("Id")
			.Where("ContactRId").IsEqual("ResultSelect", "ContactRecordId")
			.And(TargetSchemaBindingColumnValueName).IsEqual("ResultSelect","RootSchemaRecordId") as Select;
		mandrillRecipientExistsSelect.SpecifyNoLockHints(true);
		insertSelect = new InsertSelect(UserConnection)
					.Into(TargetSchemaName)
			.Set(TargetSchemaBindingColumnValueName, "EmailAddress", "ContactRId")
			.FromSelect(select.Where().Not().Exists(
				mandrillRecipientExistsSelect
			));
			break;
	case "Campaign":
		var campaignTargetExistsSelect = new Select(UserConnection)
			.From("CampaignTarget").Column("Id")
			.Where("ContactId").IsEqual("ResultSelect", "ContactRecordId")
			.And("CampaignId").IsEqual("ResultSelect", "RootSchemaRecordId") as Select;
		campaignTargetExistsSelect.SpecifyNoLockHints(true);
		insertSelect = new InsertSelect(UserConnection)
			.Into("CampaignTarget");
		if(IsSetCampaignFirstStep == false) {
			insertSelect.Set("CampaignId", "CampaignTargetStatusId", "IsFromGroup",
				"ModifiedById", "ContactId");
		} else {
			insertSelect.Set("CampaignId", "CampaignTargetStatusId", "IsFromGroup",
				"ModifiedById", "ContactId", "CurrentStepId");
		}
		insertSelect.FromSelect(select.Where().Not().Exists(
			campaignTargetExistsSelect
		));
			break;
	default:
		insertSelect = null;
		break;
}
return insertSelect;
		}

		public virtual void FailOperation() {
			int totalTargetAudienceCounter = GetRestTargetAudienceCount();
SetRootStatus(MarketingConsts.SegmentStatusUpdatedId, totalTargetAudienceCounter, DateTime.MinValue);
var refColumn = string.Format("{0}Id", RootSchemaName);
var deleteSegments = new Delete(UserConnection)
	.From(SegmentSchemaName)
	.Where(refColumn).IsEqual(Column.Parameter(RootSchemaRecordId));
deleteSegments.Execute();
string remindingCaption = GetRemindingCaption();
if (string.IsNullOrEmpty(remindingCaption)) {
	return;
}
MandrillUtilities.CreateReminding(UserConnection,  GetRootEntity(),
	FailMessage.ToString(), remindingCaption);
		}

		public virtual void SuccessOperation(int targetAudienceCounter) {
			int totalTargetAudienceCounter = GetRestTargetAudienceCount();
var processingDate = DateTime.UtcNow;
Guid segmentStatus = MarketingConsts.SegmentStatusUpdatedId;
if (!Guid.Empty.Equals(SuccessStatusId)) {
	segmentStatus = SuccessStatusId;
}
SetRootStatus(segmentStatus, totalTargetAudienceCounter, processingDate);
var refColumn = RootSchemaName + "Id";
new Delete(UserConnection)
		.From(SegmentSchemaName)
		.Where(refColumn).IsEqual(Column.Parameter(RootSchemaRecordId))
		.Execute();
string remindingCaption = GetRemindingCaption();
if (string.IsNullOrEmpty(remindingCaption)) {
	return;
}
MandrillUtilities.CreateReminding(UserConnection, GetRootEntity(), string.Format(SuccessMessage.ToString(), 
		targetAudienceCounter), remindingCaption);
		}

		public virtual string GetRemindingCaption() {
			string remindingCaption;
Entity rootEntity = GetRootEntity();
switch(RootSchemaName) {
	case "Event":
		remindingCaption = EventRemindingCaption.ToString();
		break;
	case "BulkEmail":
		remindingCaption = string.Format(RemindingCaption.ToString(), rootEntity.Schema.Caption);
		break;
	case "Campaign":
		remindingCaption = CampaignRemindingCaption.ToString();
		break;
	default:
		remindingCaption = string.Empty;
		break;
}
return remindingCaption;
		}

		public virtual void LogInfo(string message) {
			var logger = GetLogger();
logger.Info(string.Format("{0}: [{1}] {2};", this.Name, SessionKey, message));
		}

		public virtual void LogError(string message, Exception e) {
			var logger = GetLogger();
			logger.ErrorFormat("{0}: [{1}] {2};", e, this.Name, SessionKey, message);
		}

		public virtual global::Common.Logging.ILog GetLogger() {
			var logger = Logger as global::Common.Logging.ILog;
if (logger == null) {
	logger = global::Common.Logging.LogManager.GetLogger(this.Name);
	Logger = logger;
}
if (string.IsNullOrEmpty(SessionKey)) {
	SessionKey = Guid.NewGuid().ToString("N");
}
return logger;
		}

		public virtual int GetBulkEmailRootSchemaRecordRId(Guid bulkEmailId) {
			var select = new Select(UserConnection)
	.Column("RId")
	.From("BulkEmail")
	.Where("Id").IsEqual(Column.Parameter(bulkEmailId)) as Select;
return select.ExecuteScalar<int>();
		}

		public virtual Guid GetCampaignFirstStep(Guid campaignId) {
					var select = new Select(UserConnection)
			.Column("Id")
			.From("CampaignStep")
			.Where("CampaignId").IsEqual(Column.Parameter(campaignId))
			.And("TypeId").IsEqual(Column.Const(CampaignConsts.AudienceCampaignStepTypeId)) as Select;
		return select.ExecuteScalar<Guid>();
		}

		#endregion

	}

	#endregion

}


