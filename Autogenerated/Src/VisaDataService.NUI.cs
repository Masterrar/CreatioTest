namespace Terrasoft.Configuration
{
	using System;
	using System.Data;
	using Terrasoft.Core;
	using Terrasoft.Common;
	using Terrasoft.Core.DB;
	using System.ServiceModel;
	using System.ServiceModel.Web;
	using Terrasoft.Core.Entities;
	using CoreEntitySchema = Terrasoft.Core.Entities.EntitySchema;
	using Terrasoft.Core.Factories;
	using System.Collections.Generic;
	using System.Runtime.Serialization;
	using System.ServiceModel.Activation;
	using Terrasoft.Nui.ServiceModel.Extensions;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Web.Common;

	#region Class: VisaDataService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class VisaDataService : BaseService
	{

		#region Methods: Private

		private VisaHelper GetVisaHelper(Guid sysAdminUnitId) {
			return ClassFactory.Get<VisaHelper>(new ConstructorArgument("sysAdminUnitId", sysAdminUnitId),
				new ConstructorArgument("userConnection", UserConnection));
		}

		#endregion

		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
		BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
		public string GetVisaEntities(Guid sysAdminUnitId, RequestOptions requestOptions) {
			var helper = GetVisaHelper(sysAdminUnitId);
			SelectQueryResponse result = helper.GetEntities(requestOptions);
			return ServiceStackTextHelper.Serialize(result);
		}
		
		#endregion
	}
	
	#endregion

	#region Class: VisaHelper
	
	public class VisaHelper {
		
		#region Fields: Private
		
		private UserConnection _userConnection;

		private Guid _sysAdminUnitId;
		
		#endregion
		
		#region Constructord: Public
		
		public VisaHelper(Guid sysAdminUnitId, UserConnection userConnection) {
			_sysAdminUnitId = sysAdminUnitId;
			_userConnection = userConnection;
		}
		
		#endregion
		
		#region Methods: Private
		
		private Select WrapSelect(Select sourceSelect) {
			Select select = 
				new Select(_userConnection)
					.Column("Id")
					.Column("CreatedOn")
					.Column("CreatedById")
					.Column("ModifiedOn")
					.Column("ModifiedById")
					.Column("ProcessListeners")
					.Column("Objective")
					.Column("VisaOwnerId")
					.Column("IsAllowedToDelegate")
					.Column("DelegatedFromId")
					.Column("StatusId")
					.Column("SetById")
					.Column("SetDate")
					.Column("IsCanceled")
					.Column("Comment")
					.Column("VisaSchemaName")
					.Column("Title")
					.Column("VisaObjectId")
					.Column("VisaSchemaTypeId")
					.Column("VisaTypeName")
					.Column("VisaSchemaCaption")
					.Column("SchemaName")
				.From(sourceSelect).As("InternalSelect")
				.OrderBy(OrderDirectionStrict.Descending, "ModifiedOn") as Select;
			return select;
		}
		
		private void ApplyOptions(ref Select select, RequestOptions requestOptions) {
			if (requestOptions.IsPageable) {
				select.Top(requestOptions.RowCount);
			}
		}
		
		private Dictionary<string, string> GetColumnNameMap(Select select) {
			var map = new Dictionary<string, string>();
			foreach(var column in select.Columns) {
				string columnName = column.Alias;
				if (string.IsNullOrEmpty(columnName)) {
					columnName = column.SourceColumnAlias;
				}
				map[columnName] = columnName;
			}
			return map;
		}
		
		private CoreEntitySchema GetExtendedBaseVisaEntitySchema() {
			var entitySchemaManager = _userConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var baseVisaEntitySchema = entitySchemaManager.GetInstanceByName("BaseVisa");
			CoreEntitySchema baseVisaSchema = new CoreEntitySchema(baseVisaEntitySchema, false);
			baseVisaSchema.AddColumn("LongText", "Title");
			baseVisaSchema.AddColumn("LongText", "VisaSchemaName");
			baseVisaSchema.AddColumn("Guid", "VisaObjectId");
			baseVisaSchema.AddColumn("Guid", "VisaSchemaTypeId");
			baseVisaSchema.AddColumn("LongText", "VisaTypeName");
			baseVisaSchema.AddColumn("LongText", "VisaSchemaCaption");
			baseVisaSchema.AddColumn("LongText", "SchemaName");
			return baseVisaSchema;
		}
		
		private EntitySchemaQuery GetExtendedBaseVisaESQ(CoreEntitySchema schema) {
			EntitySchemaQuery entitySchemaQuery = new EntitySchemaQuery(schema);
			entitySchemaQuery.RootSchema.IsVirtual = false;
			entitySchemaQuery.AddAllSchemaColumns();
			return entitySchemaQuery;
		}

		private Select GetSelectFromProviders() {
			Dictionary<string, object> parameters = new Dictionary<string, object>();
			parameters.Add("sysAdminUnitId", _sysAdminUnitId);
			parameters.Add("userConnection", _userConnection);
			NotificationUtilities notificationUtilities = new NotificationUtilities();
			Select mainSelect = null;
			List<string> classNames = notificationUtilities
				.GetNotificationProviderClassNames(NotificationProviderType.Visa, _userConnection);
			if (classNames.Count == 0) {
				return null;
			}
			object[] objectParams = new object[] { parameters };
			foreach (string className in classNames) {
				var classInstance = notificationUtilities.GetClassInstance(className, objectParams);
				Select providerSelect = ((INotificationProvider)classInstance).GetEntitiesSelect();
				if (providerSelect != null) {
					mainSelect = mainSelect == null
						? providerSelect
						: mainSelect.UnionAll(providerSelect) as Select;
				}
			}
			return mainSelect;
		}

		#endregion

		#region Methods: Public

		public SelectQueryResponse GetEntities(RequestOptions requestOptions) {
			Select selectFromProviders = GetSelectFromProviders();
			if (selectFromProviders == null) {
				return new SelectQueryResponse {
					Rows = null,
					RowsAffected = 0,
					RowConfig = null
				};
			}
			Select entitiesSelect = WrapSelect(selectFromProviders);
			ApplyOptions(ref entitiesSelect, requestOptions);
			Dictionary<string, string> serverToClientColumnNameMap = GetColumnNameMap(entitiesSelect);
			CoreEntitySchema baseVisaSchema = GetExtendedBaseVisaEntitySchema();
			EntitySchemaQuery baseVisaESQ = GetExtendedBaseVisaESQ(baseVisaSchema);
			Terrasoft.Core.Entities.EntityCollection collection = 
				new Terrasoft.Core.Entities.EntityCollection(_userConnection, baseVisaSchema);
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = entitiesSelect.ExecuteReader(dbExecutor)) {
					collection.Load(dataReader);
				}
			}
			var convertedEntities = QueryExtension.GetEntityCollection(collection, serverToClientColumnNameMap);
			Dictionary<string, object> config = QueryExtension.GetColumnConfig(baseVisaESQ, serverToClientColumnNameMap);
			SelectQueryResponse response = new SelectQueryResponse {
				Rows = convertedEntities,
				RowsAffected = convertedEntities.Count,
				RowConfig = config
			};
			return response;
		}
		
		#endregion
	}
	
	#endregion
	
	#region Class: RequestOptions
	
	[DataContract, Serializable]
	public class RequestOptions {

		#region Properties: Public

		[DataMember(Name = "isPageable")]
		public bool IsPageable {
			get; set;
		}

		[DataMember(Name = "rowCount")]
		public int RowCount {
			get; set;
		}

		#endregion
	}
	
	#endregion
	
	#region Class: ConditionalValues
	
	[DataContract, Serializable]
	public class ConditionalValues {
		
		#region Properties: Public

		[DataMember(Name = "columnName")]
		public string ColumnName {
			get; set;
		}

		[DataMember(Name = "value")]
		public object Value {
			get; set;
		}

		[DataMember(Name = "valueType")]
		public int ValueType {
			get; set;
		}
		
		#endregion
	}
	
	#endregion

}

