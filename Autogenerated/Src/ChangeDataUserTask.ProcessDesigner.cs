﻿namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: ChangeDataUserTaskSchema

	/// <exclude/>
	public class ChangeDataUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public ChangeDataUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public ChangeDataUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3021ca7-7450-4678-a117-060171eb2976");
			RealUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976");
			Name = "ChangeDataUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("7110cdfd-e133-4075-aeea-1112c8b841bd");
			ParametersEditPageSchemaV2UId = new Guid("f9c58aa4-3c7c-4266-a967-013164e169f1");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,81,111,155,48,16,126,134,95,65,121,168,136,20,161,238,185,138,180,44,77,163,72,107,183,150,102,123,152,246,224,192,37,88,117,108,102,159,215,177,41,255,189,103,96,173,129,104,171,132,4,220,221,119,247,221,231,79,126,31,243,93,148,44,37,114,172,179,188,132,3,219,172,139,116,249,195,50,97,146,149,229,244,125,168,176,158,76,162,63,97,160,1,173,150,209,142,114,112,25,30,67,31,22,129,255,51,139,54,6,244,66,73,9,57,114,37,83,191,244,134,73,182,7,157,174,0,215,210,32,147,57,124,168,105,236,144,198,228,50,116,228,238,33,87,186,88,40,97,15,242,11,19,22,76,218,189,22,202,74,140,102,179,232,194,167,135,218,54,236,126,50,221,35,117,103,65,215,196,76,194,83,180,28,198,147,255,243,157,246,186,165,183,236,0,196,112,52,33,165,78,243,226,192,229,61,223,151,104,104,96,167,215,184,114,189,151,74,195,21,55,149,96,117,187,19,149,175,132,218,50,49,175,170,12,16,185,220,155,244,26,24,109,6,39,202,215,242,138,33,115,220,31,152,121,52,167,134,204,139,98,46,68,27,105,69,52,73,167,236,218,220,48,204,75,90,187,224,110,107,211,200,248,89,171,28,140,249,219,116,131,92,80,150,228,206,42,200,249,174,94,102,119,215,92,32,104,51,16,109,26,97,201,77,95,166,233,248,8,166,97,16,56,214,153,178,58,135,174,21,49,10,182,74,137,136,155,198,112,109,152,212,24,47,212,33,188,211,39,172,91,231,172,143,61,63,127,11,248,93,179,115,224,204,178,107,114,43,173,108,245,175,193,223,46,190,71,204,140,45,212,166,73,98,209,202,65,172,26,90,126,219,51,178,159,21,194,113,243,194,67,35,19,110,160,66,235,233,32,56,134,238,113,93,123,21,45,10,75,173,158,26,123,223,210,140,79,186,41,88,254,202,161,114,116,18,151,248,168,114,38,248,111,182,21,144,161,38,115,37,113,252,0,90,51,163,118,72,52,52,196,177,59,159,32,142,59,27,116,198,41,153,220,131,239,181,244,165,113,250,154,252,202,177,244,104,197,241,196,157,235,241,229,170,120,21,167,147,215,11,156,82,156,110,136,33,112,224,57,234,191,169,10,134,48,170,27,14,232,59,145,112,254,117,17,63,3,180,178,191,34,8,5,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateIsMatchConditionsParameter());
			Parameters.Add(CreateDataSourceFiltersParameter());
			Parameters.Add(CreateRecordColumnValuesParameter());
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("bd2cf1ae-bbc6-4d91-8d6e-c6b40f057e95"),
				Name = "EntitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsMatchConditionsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("d6c84ba1-b6ca-4952-b517-880f22e21fdc"),
				Name = "IsMatchConditions",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDataSourceFiltersParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("03166c4b-2e15-4768-a343-750c16b69691"),
				Name = "DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordColumnValuesParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("effa11ce-90c7-4efe-8a02-be7a659d27e9"),
				Name = "RecordColumnValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateUpdateEntityCollectionMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("52fca718-c7ac-437b-9267-8d393a6dc1cc"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3a8a8efd-87b4-44e2-92ae-c3e975701b97"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("2ede4635-4427-4153-9fb2-d9d46cae996c")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3585e965-d43b-43f1-97ee-06a8679a50c8"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e62c4114-493a-4303-8cde-814bd0c5e856"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("33392bc2-629e-423d-ad3e-1e59ec675a7a"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateEntityCollectionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c6de7011-ba42-4d78-9943-9f4c045f0d03"),
				Name = "UpdateEntityCollection",
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fce65d67-6cdc-4dbd-8a66-7f5b6279a7a1"),
				Name = "entityCollection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c56c2f30-e948-4de7-bb00-489093c18a94"),
				Name = "entitySchema",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntitySchema",
				CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,81,201,78,195,48,16,61,167,95,225,163,43,85,249,1,40,18,148,8,33,138,136,186,112,31,220,73,99,234,216,145,61,137,136,80,255,29,111,21,185,120,172,153,55,111,177,27,99,17,68,203,248,8,150,161,38,73,19,147,58,223,54,70,41,20,36,141,94,178,223,69,65,118,10,165,104,210,14,127,195,233,19,212,128,53,72,123,239,200,74,125,94,49,243,245,237,87,30,152,48,106,232,116,156,7,194,29,10,99,79,155,255,166,43,83,137,204,69,81,69,193,189,104,177,131,132,202,12,108,157,205,164,89,249,130,52,71,61,77,239,72,80,3,181,124,166,88,122,107,203,187,192,155,236,176,49,250,88,207,93,37,253,8,146,13,227,181,53,2,157,59,58,180,7,112,151,35,73,37,73,122,155,94,240,213,85,93,79,211,214,152,203,208,127,216,103,32,60,200,14,35,1,143,212,171,204,92,250,25,196,254,97,234,113,153,195,21,55,121,61,40,21,21,175,225,72,185,202,61,210,236,93,114,140,85,178,28,67,4,112,198,122,123,143,167,78,234,157,60,183,228,60,99,3,202,197,16,55,50,24,145,199,102,88,189,50,1,20,126,183,250,17,216,135,143,100,152,60,109,205,185,172,172,53,150,39,224,226,250,7,55,98,180,162,10,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ChangeDataUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3021ca7-7450-4678-a117-060171eb2976"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection, ProcessSchemaUserTask schemaUserTask) {
			return new Dictionary<Guid, string>();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new ChangeDataUserTask(userConnection) {
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976")
			};
		}

		#endregion

	}

	#endregion

	#region Class: ChangeDataUserTask

	[DesignModeProperty(Name = "EntitySchemaUId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d3021ca774504678a117060171eb2976", CaptionResourceItem = "Parameters.EntitySchemaUId.Caption", DescriptionResourceItem = "Parameters.EntitySchemaUId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsMatchConditions", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d3021ca774504678a117060171eb2976", CaptionResourceItem = "Parameters.IsMatchConditions.Caption", DescriptionResourceItem = "Parameters.IsMatchConditions.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "DataSourceFilters", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d3021ca774504678a117060171eb2976", CaptionResourceItem = "Parameters.DataSourceFilters.Caption", DescriptionResourceItem = "Parameters.DataSourceFilters.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordColumnValues", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d3021ca774504678a117060171eb2976", CaptionResourceItem = "Parameters.RecordColumnValues.Caption", DescriptionResourceItem = "Parameters.RecordColumnValues.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class ChangeDataUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public ChangeDataUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976");
			_isMatchConditions = () => { return true; };
		}

		#endregion

		#region Properties: Public

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		private Func<bool> _isMatchConditions;
		public virtual bool IsMatchConditions {
			get {
				return (_isMatchConditions ?? (_isMatchConditions = () => false)).Invoke();
			}
			set {
				_isMatchConditions = () => { return value; };
			}
		}

		public virtual string DataSourceFilters {
			get;
			set;
		}

		private EntityColumnMappingValues _recordColumnValues;
		public virtual EntityColumnMappingValues RecordColumnValues {
			get {
				return _recordColumnValues ?? ( _recordColumnValues = new EntityColumnMappingValues (
					new Dictionary<string, object>(),
					new Dictionary<string, string>()));
			}
			set {
				_recordColumnValues = value;
			}
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (EntitySchemaUId.Equals(Guid.Empty)) {
				return false;
			}
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			if (RecordColumnValues.Values.Count == 0) {
				return true;
			}
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, entitySchema.Name);
			entitySchemaQuery.UseAdminRights = false;
			entitySchemaQuery.IgnoreDisplayValues = GlobalAppSettings.FeatureIgnoreDisplayValuesInDataUserTasks;
			entitySchemaQuery.AddAllSchemaColumns();
			if (IsMatchConditions) {
				ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, entitySchemaQuery,
					DataSourceFilters);
				bool isEmptyFilter = entitySchemaQuery.Filters.Count == 0;
				if (!isEmptyFilter && entitySchemaQuery.Filters.Count == 1) {
					var filterGroup = entitySchemaQuery.Filters[0] as EntitySchemaQueryFilterCollection;
					if (filterGroup != null && filterGroup.Count == 0) {
						isEmptyFilter = true;
					}
				}
				if (isEmptyFilter) {
					throw new NullOrEmptyException(new LocalizableString("Terrasoft.Core",
						"ProcessSchemaChangeDataUserTask.Exception.ChangeDataWithEmptyFilter"));
				}
			}
			EntityCollection entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
			UpdateEntityCollection(entityCollection, entitySchema);
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual void UpdateFiltersRightExprMetaDataByParameterValue(Process process, DataSourceFilterCollection filters) {
			foreach (var filter in filters) {
				if (filter is DataSourceFilterCollection) {
					UpdateFiltersRightExprMetaDataByParameterValue(process, (DataSourceFilterCollection)filter);
					continue;
				}	
				var dataSourcefilter = (DataSourceFilter)filter;
				if (dataSourcefilter.RightExpression == null) {
					continue;
				}
				if (dataSourcefilter.RightExpression.Type == DataSourceFilterExpressionType.Custom) {
					dataSourcefilter.RightExpression.Type = DataSourceFilterExpressionType.Parameter;
					if (dataSourcefilter.RightExpression.Parameters.Count == 2) {
						var parameters = dataSourcefilter.RightExpression.Parameters;
						var metaPath = parameters[1].Value;
						parameters[1].Value = process.GetParameterValueByMetaPath((string)metaPath);
						parameters.RemoveAt(0);
					}
					if (dataSourcefilter.SubFilters != null && dataSourcefilter.SubFilters.Count > 0) {
						UpdateFiltersRightExprMetaDataByParameterValue(process, dataSourcefilter.SubFilters);
					}
				}
			}
		}

		public virtual void UpdateEntityCollection(EntityCollection entityCollection, EntitySchema entitySchema) {
			foreach (var entity in entityCollection) {
				try {
					foreach(KeyValuePair<string, object> columnValue in RecordColumnValues.Values) {
						EntitySchemaColumn column = entitySchema.GetSchemaColumnByMetaPath(columnValue.Key);
						object value = columnValue.Value;
						if (ProcessUserTaskUtilities.GetIsEmptyLookupOrDateTimeValue(value, column.DataValueType)) {
							value = null;
						}
						entity.SetColumnValue(column, value);
					}
					entity.UseAdminRights = false;
					entity.Save(false);
				} catch (Exception e) {
					Log.Error(e);
				}
			}
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("EntitySchemaUId")) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("IsMatchConditions")) {
				writer.WriteValue("IsMatchConditions", IsMatchConditions, false);
			}
			if (!HasMapping("DataSourceFilters")) {
				writer.WriteValue("DataSourceFilters", DataSourceFilters, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "EntitySchemaUId":
					EntitySchemaUId = reader.GetGuidValue();
				break;
				case "IsMatchConditions":
					IsMatchConditions = reader.GetBoolValue();
				break;
				case "DataSourceFilters":
					DataSourceFilters = reader.GetStringValue();
				break;
				case "RecordColumnValues":
					if (UseFlowEngineMode) {
						RecordColumnValues = reader.GetValue<EntityColumnMappingValues>();
					}
				break;
			}
		}

		#endregion

	}

	#endregion

}

