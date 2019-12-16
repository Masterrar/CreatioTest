namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: LeadManagementDistributionSchema

	/// <exclude/>
	public class LeadManagementDistributionSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementDistributionSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementDistributionSchema(LeadManagementDistributionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementDistribution";
			UId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.11.1.1735";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"LeadManagementDistribution";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe");
			Version = 0;
			PackageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("30cf6943-a881-4c30-a088-ff65572e4241"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"LeadId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateReminderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9cd3f863-0eda-4338-895e-97f82adfe406"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"CreateReminder",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{cd5eefc4-6c19-4719-be10-6babbc9acc6e}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateResponsibleIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("77bfc541-1a1a-4b5e-bd77-3e429c4b637f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ResponsibleId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{0d01d7bb-ccf9-4184-a64f-953b68988ea4}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateShowDistributionPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("51139bfa-4db4-45f7-aa2f-590d604f8469"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ShowDistributionPage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateCreateReminderParameter());
			Parameters.Add(CreateResponsibleIdParameter());
			Parameters.Add(CreateShowDistributionPageParameter());
		}

		protected virtual void InitializeSaveLeadHandoffParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("188fdd38-de95-4c10-8ab3-34128e7e82c9"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"EntitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cad839f-9e67-4603-a369-f4c25fce8216"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"IsMatchConditions",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51b908e1-277f-4fd9-954b-c200b506502f"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,69,182,198,178,236,30,151,109,89,40,105,160,105,41,36,75,24,75,163,172,192,127,54,182,76,19,204,126,247,202,235,108,10,57,148,210,91,193,135,209,216,239,167,55,143,241,124,239,199,143,190,9,52,84,14,155,145,146,105,103,43,38,108,86,103,136,192,51,5,5,7,43,5,199,210,104,14,160,92,46,108,129,194,32,75,58,108,169,98,171,122,107,125,96,137,15,212,142,213,237,252,27,26,134,137,146,123,119,62,124,53,7,106,241,219,114,1,164,232,116,73,37,47,114,81,115,160,186,230,218,160,225,206,201,178,86,160,33,37,195,86,47,168,4,101,26,136,231,18,4,135,28,11,94,103,96,121,90,80,14,153,148,145,3,44,105,200,133,237,211,113,160,113,244,125,87,205,244,90,223,60,31,163,203,245,238,77,223,76,109,199,146,150,2,94,99,56,68,58,9,130,220,32,55,80,230,28,28,21,28,101,105,185,196,186,200,10,77,169,74,11,150,24,60,134,5,203,118,150,37,22,3,126,199,102,162,51,121,246,209,99,38,69,170,115,21,181,169,52,28,100,38,184,86,186,224,206,42,87,146,84,101,89,219,75,94,159,38,31,107,63,94,77,45,13,222,188,196,78,49,191,126,168,102,211,119,97,232,155,5,125,117,254,252,134,158,194,26,238,203,171,31,235,64,33,246,23,17,59,37,211,72,155,198,83,23,182,157,233,173,239,30,86,230,233,20,37,237,17,7,63,94,82,216,62,78,216,176,100,240,15,135,63,166,181,153,198,208,183,255,209,168,73,28,51,50,226,146,157,237,46,59,104,253,120,108,240,249,124,174,216,187,199,169,15,31,62,19,218,181,98,111,20,21,187,99,82,24,167,74,144,28,181,78,57,152,101,235,133,214,113,41,85,158,23,25,65,6,233,29,139,46,254,129,125,187,27,191,252,236,46,255,192,234,122,255,62,118,223,52,174,47,202,106,254,27,59,167,253,98,104,127,138,207,47,177,221,110,55,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e91b04af-7a52-4f54-a02b-32ac50a9f8ad"),
				ContainerUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"RecordColumnValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,219,110,219,70,16,253,21,129,201,163,71,216,251,69,175,73,129,26,112,90,163,78,242,98,251,97,47,51,141,80,73,52,72,42,69,42,232,223,59,164,237,218,10,26,219,72,80,212,69,202,135,165,184,171,51,51,187,115,206,206,236,154,151,195,167,43,108,22,205,91,236,186,212,183,52,204,95,181,29,206,79,187,182,96,223,207,79,218,146,86,203,63,82,94,225,105,234,210,26,7,236,222,167,213,22,251,147,101,63,28,205,14,97,205,81,243,242,227,180,218,44,206,119,205,241,128,235,119,199,149,173,23,85,157,145,58,65,149,37,130,65,235,32,186,92,160,134,224,36,37,178,222,43,6,151,118,181,93,111,222,224,144,78,211,240,161,89,236,154,201,26,27,200,69,140,54,4,216,164,43,152,96,4,164,100,16,138,19,152,188,119,168,132,107,246,71,77,95,62,224,58,77,78,239,192,70,38,10,17,35,120,43,50,123,207,25,66,73,5,136,116,204,142,141,73,44,35,248,230,255,119,192,243,23,39,109,251,219,246,106,174,148,54,178,84,9,54,107,13,166,176,251,40,164,4,71,222,69,141,228,208,152,121,193,236,69,214,5,98,176,196,49,58,15,9,125,129,16,40,214,234,165,112,33,188,184,28,29,213,101,127,181,74,159,222,127,209,223,217,144,126,197,249,143,105,83,91,162,217,208,206,250,180,194,254,26,124,117,144,135,251,240,221,197,117,58,47,154,197,197,151,18,122,243,62,155,206,233,48,165,159,103,243,162,57,186,104,206,218,109,87,70,139,122,252,184,61,221,201,131,184,121,224,111,134,219,231,218,198,4,123,147,54,188,169,238,39,246,56,193,167,165,215,105,72,147,243,183,28,247,173,225,172,162,21,94,18,120,76,35,91,156,130,80,101,130,40,99,38,237,181,34,82,19,250,23,36,236,112,83,240,48,176,167,100,107,194,79,158,239,130,185,37,30,207,108,182,171,213,228,160,159,246,63,50,249,38,240,155,149,215,247,82,120,207,66,91,151,180,196,122,188,249,154,163,218,55,251,253,209,125,217,68,196,160,148,241,160,107,80,96,140,52,204,173,36,33,145,19,169,196,34,181,18,15,202,198,170,32,189,54,129,15,65,72,48,66,90,72,222,57,40,89,138,226,179,181,166,132,127,66,54,231,199,253,207,191,111,176,187,62,133,5,165,85,143,151,115,158,253,108,226,47,2,46,118,222,103,42,214,72,144,137,83,109,178,69,200,213,243,214,209,168,88,76,118,218,211,254,242,49,253,76,94,255,215,201,211,116,34,93,70,237,172,132,64,200,244,146,54,50,190,242,205,26,132,174,198,5,93,171,254,79,232,68,214,164,5,21,3,89,21,100,154,243,165,155,139,25,105,238,172,86,166,202,138,241,65,157,40,31,9,53,10,240,177,8,48,20,4,228,36,8,200,186,74,202,88,50,177,60,19,157,196,82,53,5,167,65,96,101,157,104,29,32,68,22,75,244,20,84,170,132,70,184,199,117,242,170,195,52,224,172,195,245,114,83,177,155,81,219,205,218,239,73,59,81,48,55,50,5,16,68,133,185,207,23,79,240,62,130,50,74,240,143,68,81,248,135,180,243,228,192,158,187,118,44,138,236,45,101,80,218,113,137,160,202,151,64,228,218,153,125,96,2,59,197,163,125,80,59,201,136,228,12,37,72,220,138,177,248,144,123,59,227,29,36,203,5,170,82,206,81,211,191,169,157,31,86,184,198,205,176,216,105,110,59,157,224,98,136,44,103,48,156,125,136,85,85,176,66,56,23,149,18,217,224,254,80,108,92,125,61,23,76,4,116,158,59,9,49,214,94,77,26,148,20,10,201,50,53,124,122,92,108,156,199,161,91,230,237,176,108,55,179,171,177,179,59,27,219,185,89,93,126,92,246,60,247,189,104,238,91,235,149,173,193,88,151,13,72,38,45,152,138,22,178,224,33,17,183,51,228,124,180,229,217,106,238,114,255,39,45,21,12,90,108,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeSaveLeadNoInterestParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("a147d2f0-eb4f-4a91-bda3-6b4d5423014b"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"EntitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d71bf98b-10c9-4b4e-9da3-927f4c707df2"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"IsMatchConditions",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8b04704d-b57f-4aed-8143-0ba2dc774953"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,245,225,30,151,109,89,40,105,160,105,41,36,75,144,165,81,86,224,143,141,37,211,4,179,255,189,242,58,155,66,14,165,244,86,208,97,52,154,247,230,205,99,52,223,135,248,49,180,9,198,218,155,54,2,158,118,174,70,69,229,20,48,197,8,5,230,9,23,162,36,186,162,21,113,86,73,203,37,99,32,27,132,123,211,65,141,86,244,214,133,132,112,72,208,197,250,118,254,77,154,198,9,240,189,63,95,190,218,3,116,230,219,210,128,83,227,149,6,77,100,85,52,132,67,211,16,101,141,37,222,51,221,8,174,56,5,139,86,45,76,23,66,230,90,82,22,174,36,220,8,75,180,84,146,72,224,180,148,90,59,90,50,132,91,240,105,251,116,28,33,198,48,244,245,12,175,241,205,243,49,171,92,123,111,134,118,234,122,132,59,72,230,218,164,67,141,12,20,192,43,107,136,229,186,34,220,131,36,134,105,71,152,105,100,41,21,80,65,37,194,214,28,211,66,139,118,14,97,103,146,249,110,218,9,206,204,115,200,26,75,86,80,85,137,140,165,204,18,206,202,130,40,145,53,122,39,188,6,38,180,110,220,197,175,79,83,200,113,136,87,83,7,99,176,47,182,67,246,111,24,235,217,14,125,26,135,118,161,190,58,151,223,192,83,90,205,125,121,250,177,14,148,114,126,1,161,19,158,34,108,218,0,125,218,246,118,112,161,127,88,57,79,167,12,233,142,102,12,241,226,194,246,113,50,45,194,99,120,56,252,209,173,205,20,211,208,253,71,163,226,60,102,230,200,75,118,150,187,236,160,11,241,216,154,231,243,189,70,239,30,167,33,125,248,12,198,173,17,122,131,168,209,29,98,133,245,66,115,70,140,82,148,112,203,10,98,10,165,242,82,138,170,146,37,240,146,211,59,148,85,252,3,247,237,46,126,249,217,95,254,192,170,122,255,62,103,223,36,174,47,200,122,254,27,57,167,253,34,104,127,202,231,23,171,70,92,220,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("63cb5219-81b3-4e2c-8f12-bb56e164296d"),
				ContainerUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"RecordColumnValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,77,111,27,71,12,253,43,194,38,71,83,152,239,15,93,155,30,12,56,110,16,167,185,196,62,112,56,156,70,168,172,53,180,171,20,169,161,255,94,106,109,39,118,208,184,134,139,0,49,146,133,176,130,102,247,145,20,201,199,55,115,217,61,31,63,94,112,183,232,222,240,102,131,67,223,198,249,47,253,134,231,175,54,61,241,48,204,143,122,194,213,242,111,44,43,126,133,27,60,231,145,55,111,113,181,229,225,104,57,140,7,179,187,176,238,160,123,254,97,122,218,45,222,93,118,135,35,159,255,126,88,197,122,97,39,159,152,161,182,146,193,41,34,72,218,100,176,129,114,142,70,215,152,247,96,234,87,219,243,245,75,30,241,21,142,239,187,197,101,55,89,219,27,32,69,166,6,5,30,109,5,151,156,2,68,199,64,65,49,198,24,216,168,208,237,14,186,129,222,243,57,78,78,63,131,157,198,150,50,103,136,94,21,112,92,10,36,66,130,214,108,46,65,140,105,166,61,248,250,253,207,192,119,207,142,250,254,207,237,197,220,24,235,52,85,13,190,88,11,142,196,125,86,90,67,104,49,100,203,45,176,115,115,175,177,146,101,2,235,149,188,84,180,196,168,196,97,42,108,139,98,173,155,74,207,206,246,142,234,114,184,88,225,199,183,95,245,119,50,226,31,60,63,238,199,217,114,45,25,231,97,228,122,5,189,184,83,133,219,224,203,211,171,98,158,118,139,211,175,149,243,250,251,100,202,210,221,130,126,89,203,211,238,224,180,59,233,183,27,218,91,180,251,31,55,185,157,60,168,235,11,254,229,118,115,93,217,152,96,47,113,45,127,105,115,44,30,39,248,244,232,5,142,56,57,127,35,113,223,24,46,38,123,21,117,131,200,40,189,194,193,64,170,26,33,235,92,154,141,214,180,102,38,244,107,110,146,154,53,241,221,192,30,82,171,9,63,121,254,28,204,77,219,201,202,122,187,90,77,14,134,233,255,239,251,248,58,240,235,39,47,110,21,240,150,133,190,46,219,146,235,225,250,49,169,218,117,187,221,193,109,210,184,210,130,202,92,193,168,100,192,229,80,161,68,182,144,164,161,130,33,172,30,243,189,164,201,197,196,76,49,128,50,90,50,209,188,6,164,26,192,102,27,88,171,144,75,117,223,146,52,181,105,162,20,32,152,72,224,170,220,176,74,93,85,229,196,92,176,200,28,152,183,152,84,8,213,2,70,203,226,70,94,47,37,103,144,105,17,27,149,236,138,121,40,105,142,153,235,76,152,51,110,135,159,212,121,28,117,30,80,177,39,65,29,171,117,172,210,235,80,168,32,56,79,1,178,83,194,36,54,58,89,111,89,81,187,151,58,222,36,29,173,75,50,63,148,22,193,210,94,26,52,4,32,153,234,20,139,247,142,210,183,160,206,187,195,225,183,191,214,188,185,202,194,162,225,106,224,179,185,172,126,177,240,235,138,207,121,61,46,46,45,251,16,148,4,202,205,73,201,125,105,144,171,169,224,149,208,42,27,163,138,227,157,0,62,117,236,226,210,39,75,10,99,5,153,45,2,145,144,166,6,129,86,2,33,182,166,77,171,187,179,255,34,157,212,113,220,44,203,118,92,246,235,217,197,94,174,166,192,127,82,237,97,84,211,65,118,5,65,38,114,106,44,195,93,251,44,248,42,59,134,164,108,117,33,217,90,237,147,160,90,112,182,154,96,132,26,156,69,100,66,34,200,205,59,17,45,173,49,186,200,196,245,94,170,137,70,53,22,70,130,104,149,18,149,74,10,10,170,6,205,135,218,140,243,210,215,244,84,169,70,213,51,55,114,16,72,11,36,202,173,136,242,66,144,89,90,40,35,81,224,199,80,237,53,159,47,215,149,55,179,214,111,102,253,143,196,187,172,74,144,204,39,80,173,137,68,105,39,12,138,114,176,48,78,118,73,49,98,203,42,222,199,187,7,7,246,189,243,46,198,74,122,63,182,137,176,137,66,5,7,50,121,156,164,36,165,232,43,138,78,221,191,59,68,167,48,184,134,114,72,97,209,72,197,123,141,148,205,34,250,76,90,206,105,37,219,246,84,121,151,140,137,162,215,12,28,162,12,37,133,178,243,181,205,130,209,202,112,243,210,26,17,31,195,187,19,92,241,48,171,203,15,203,65,214,126,20,206,253,95,173,243,53,57,31,138,3,237,101,204,187,202,30,228,60,44,59,170,38,187,169,22,98,246,244,221,114,238,108,247,15,135,170,124,219,36,17,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeAddReminderParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("55dd5f60-cee9-44b6-8f68-b543a4174bf2"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"EntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae7a5bc6-115f-4ed2-97c5-13f5c5142c37",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7a3aa063-9af4-482e-adbf-9312dad8b0bf"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2e6f433c-09c2-46dc-89d2-80e6a8f6ebda"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordAddMode",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			recordAddModeParameter.SourceValue = new ProcessSchemaParameterValue(recordAddModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordAddModeParameter);
			var filterEntitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("ddff7e72-873c-4e34-a274-b1fe98dc4dc5"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"FilterEntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("95dfe792-7d3e-4db6-8add-2effff3ca7f4"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordDefValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,93,111,83,71,16,253,43,87,23,30,90,41,107,237,247,236,230,173,2,90,69,2,138,8,229,37,206,195,236,238,44,177,234,216,145,125,13,162,81,254,123,103,111,66,73,40,117,82,20,36,32,241,131,63,174,239,204,238,206,204,57,115,230,158,246,15,135,247,39,212,239,246,175,104,181,194,245,178,14,147,71,203,21,77,94,172,150,153,214,235,201,211,101,198,249,236,47,76,115,122,129,43,60,166,129,86,175,113,190,161,245,211,217,122,216,233,174,154,245,59,253,195,183,227,191,253,238,193,105,191,55,208,241,31,123,133,189,123,235,139,6,235,68,205,5,133,133,224,5,66,169,2,140,84,5,148,201,16,42,27,231,229,124,115,188,120,70,3,190,192,225,168,223,61,237,71,111,236,128,124,165,10,214,139,138,46,10,43,37,137,0,158,191,89,11,198,38,133,90,154,254,108,167,95,231,35,58,198,113,209,143,198,72,128,46,101,47,148,114,85,88,42,90,68,200,78,40,83,93,118,202,234,108,160,25,95,220,255,209,112,65,239,186,223,54,179,242,211,180,183,10,107,136,20,5,56,153,216,71,74,34,100,204,162,86,19,147,183,193,42,202,211,254,231,230,166,204,214,39,115,124,255,250,118,188,157,92,9,251,101,127,167,211,243,236,77,251,221,233,127,229,239,226,115,127,12,203,213,12,126,154,188,105,191,51,237,247,151,155,85,110,30,77,251,241,33,152,227,10,242,226,37,62,243,246,225,117,238,99,52,123,134,11,124,67,171,231,188,226,104,62,254,245,24,7,28,23,127,197,251,254,224,56,233,232,36,40,174,6,66,206,40,121,45,66,81,40,162,138,169,26,48,186,86,61,90,191,164,74,43,90,100,186,186,49,212,197,74,64,37,184,182,172,176,198,90,129,25,148,8,1,45,233,84,99,214,97,180,31,87,254,184,153,15,117,198,87,22,155,249,124,92,96,61,158,191,21,238,197,198,47,254,121,124,41,167,151,60,44,203,172,206,168,236,45,190,36,84,103,253,217,217,206,101,148,228,164,77,133,146,132,207,186,8,27,60,137,152,37,138,156,117,37,159,193,6,133,91,81,98,165,178,70,229,34,84,113,154,177,161,162,64,85,149,0,239,1,141,179,182,232,124,251,40,57,120,112,176,183,254,253,221,130,86,231,81,216,173,56,95,211,225,132,175,126,114,225,159,2,220,61,5,72,53,59,171,132,66,78,181,77,142,68,42,0,194,144,213,49,219,228,13,212,179,195,7,135,219,0,117,240,96,92,245,252,166,123,156,92,135,19,229,19,25,239,24,24,149,184,58,20,19,105,40,69,10,12,210,20,235,131,41,197,124,23,56,49,217,114,67,49,89,88,238,27,173,5,84,17,125,84,162,42,194,18,48,69,91,195,86,156,72,167,162,53,181,112,15,137,236,192,112,56,82,182,70,228,154,64,214,100,117,144,246,27,193,137,145,185,122,222,44,103,41,40,62,176,225,124,201,16,184,83,120,231,64,51,90,172,186,30,39,79,57,48,119,5,38,154,53,69,112,30,152,250,90,137,24,45,69,240,1,68,45,190,70,6,64,140,169,108,131,201,141,55,246,173,195,196,90,93,178,99,250,119,13,28,86,179,190,8,150,170,48,82,187,234,149,46,169,228,173,48,201,4,53,130,12,194,229,196,253,200,40,47,18,26,166,158,232,201,24,21,157,209,95,5,38,251,239,215,175,113,53,107,162,115,242,104,179,226,28,13,156,105,122,53,59,166,235,10,157,77,249,252,221,219,79,204,187,194,246,29,46,74,55,176,147,110,188,255,174,224,161,104,69,145,170,21,89,122,150,71,82,49,217,233,208,148,180,194,160,64,177,104,178,119,2,15,21,163,150,196,120,40,94,165,166,142,164,72,54,58,14,137,75,30,34,183,14,178,91,241,128,149,20,119,7,16,20,85,3,148,97,60,64,1,225,108,42,206,5,80,49,124,133,33,132,217,123,185,252,115,115,50,41,57,39,74,193,9,135,60,47,88,158,31,68,172,149,88,236,33,98,78,156,206,226,38,232,125,145,129,148,208,196,26,146,36,111,20,155,134,148,82,57,87,100,163,67,119,109,183,56,95,239,249,114,224,240,103,28,102,203,69,119,158,185,201,47,155,225,104,121,175,184,110,168,184,110,146,177,239,2,58,41,73,151,67,180,66,107,158,41,44,218,22,3,30,95,53,229,196,197,22,201,202,184,21,58,53,200,18,21,176,210,175,145,223,188,2,145,60,67,7,107,173,152,84,138,197,193,237,67,103,127,88,205,22,111,184,134,22,92,197,60,118,63,39,42,29,199,167,187,185,20,123,50,167,99,110,32,187,167,148,41,24,159,188,40,174,112,8,218,128,133,88,165,136,6,89,61,39,158,64,157,61,187,170,221,138,147,30,148,102,150,80,58,55,230,101,193,105,114,22,206,148,32,81,27,173,29,52,147,39,139,97,54,188,127,52,6,143,39,35,227,89,229,33,48,95,19,91,49,107,137,36,13,135,222,57,157,184,235,242,104,100,154,226,219,225,147,116,203,218,13,71,212,229,229,98,192,60,124,233,217,98,114,21,108,169,130,227,3,28,96,102,142,164,137,143,234,181,9,46,70,11,177,126,114,54,206,27,104,205,186,34,129,37,46,109,214,165,193,24,195,90,3,139,178,146,60,65,254,247,217,208,229,140,16,121,250,128,194,138,66,7,100,171,154,88,96,68,157,74,137,80,107,24,207,198,71,123,135,235,238,164,145,4,21,206,218,176,236,142,184,127,47,107,189,230,41,203,150,156,191,100,21,220,45,218,239,70,78,147,95,103,171,245,208,205,154,94,224,48,174,104,189,153,15,108,202,193,156,207,41,55,214,155,52,168,109,139,244,232,113,222,222,46,174,255,15,167,215,31,241,199,39,88,151,209,176,66,229,153,70,201,54,221,52,213,30,61,10,195,195,40,122,172,152,107,190,19,218,68,18,211,72,96,36,200,16,185,83,240,164,206,19,169,9,66,58,228,222,33,73,241,151,173,4,11,213,102,71,177,209,106,115,192,202,174,61,4,147,130,129,109,138,102,202,72,234,43,104,147,207,129,237,158,95,191,3,126,237,110,151,96,111,135,95,111,143,91,111,112,188,31,159,92,75,73,6,21,145,144,64,129,17,197,234,53,1,87,123,225,234,81,33,73,89,239,200,131,16,15,0,69,87,35,84,155,249,44,48,236,81,7,86,175,152,149,87,100,10,168,237,15,66,136,192,132,196,227,158,83,129,177,165,51,156,235,248,104,32,25,158,15,172,172,229,246,201,117,218,183,199,118,211,126,27,24,47,223,115,95,209,63,114,69,31,158,253,13,107,77,72,105,173,29,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2af26cad-fdd2-4138-9712-bb3c00009344"),
				ContainerUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				Name = @"RecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("88b815f6-9ed2-474a-a40e-f96b169054b4"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,107,7,109,64,58,237,108,77,20,22,141,43,13,103,121,213,20,76,54,220,50,205,65,50,107,108,137,185,203,27,173,36,161,61,116,88,147,21,189,181,62,18,234,35,118,161,190,157,127,147,198,113,66,122,239,206,201,87,115,192,14,190,45,13,36,7,167,52,106,86,21,89,195,36,54,13,83,6,12,115,78,232,166,148,74,114,52,100,213,98,11,157,73,173,145,85,198,85,76,106,80,76,59,37,24,20,38,19,194,102,80,112,78,104,139,46,110,159,142,35,134,224,135,190,158,241,53,190,121,62,38,149,107,239,205,208,78,93,79,104,135,17,174,33,30,106,2,152,161,44,12,48,35,117,154,212,97,197,64,104,203,4,52,85,94,41,228,37,175,8,53,112,140,11,45,217,89,66,45,68,248,14,237,132,103,230,217,39,141,185,200,184,42,202,132,229,194,48,41,242,140,169,82,85,204,217,210,105,20,165,214,141,189,248,245,105,242,41,246,225,106,234,112,244,230,197,118,76,254,13,99,61,155,161,143,227,208,46,212,87,231,231,55,248,20,87,115,95,174,126,172,3,197,84,95,64,228,68,167,128,155,214,99,31,183,189,25,172,239,31,86,206,211,41,65,186,35,140,62,92,92,216,62,78,208,18,58,250,135,195,31,221,218,76,33,14,221,127,52,42,77,99,38,142,180,100,103,185,203,14,90,31,142,45,60,159,243,154,188,123,156,134,248,225,51,130,93,35,242,6,81,147,59,34,50,227,74,45,211,106,41,197,153,52,34,99,144,41,149,150,178,44,138,42,71,153,75,126,71,146,138,127,224,190,221,133,47,63,251,203,31,88,85,239,223,167,234,155,194,245,5,89,207,127,35,231,180,95,4,237,79,233,252,2,246,133,21,47,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c774b4b-6e9a-4ef1-bd4d-4af18e1f5a68"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4a5fff69-b63a-49e0-a7c9-da42ff12623b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b730802-2250-4ca2-84c5-b50b5d4a07fb"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("be3ad5ec-1ac1-4d88-8421-74079d80259b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("19076150-3efa-4513-be4e-b624b7233322"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9adb2ee5-70ec-4c6c-b1ab-4cb1ddf4c59b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,1,114,66,42,11,82,227,193,34,6,86,6,58,129,165,137,57,153,105,153,169,41,206,249,121,37,137,201,37,8,25,207,20,16,5,0,82,99,140,34,63,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("81e8d9be-76bf-41e2-a013-9bfb7a60bbf7"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a4b4eb8-5619-4c19-a817-49e7435ddac0"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("18ee65b6-9004-44b1-b810-660c4b69eb54"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2ba36ea2-087d-4183-8f2e-029d86d94b6b"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("39c22bae-af9c-474a-8c12-e087a1cc5bcc"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("befd9ddf-c017-4e87-bf55-98e25f140075"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2fd8069c-26a9-41c0-9022-20c047525340"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("b92dc5ab-c714-451b-b938-04990fc76593"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("904a1de6-b8cd-43d7-a193-0a8234806d6f"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("addb84e6-59ea-4d30-acaf-3f26b8c94365"),
				ContainerUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
		}

		protected virtual void InitializeReadLeadTypeParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ca3d3049-0f26-41a3-bca2-dd669a7d3396"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,193,106,220,48,16,134,95,101,209,161,39,107,145,45,89,146,221,99,216,148,92,210,208,166,165,144,132,32,75,163,68,32,219,27,91,166,9,102,223,189,227,117,182,133,28,74,78,133,130,17,146,172,255,159,153,79,163,249,62,140,231,33,38,24,106,111,226,8,217,116,225,106,98,185,168,84,99,24,149,185,6,42,44,115,212,232,210,81,85,152,188,210,80,50,239,4,201,58,211,66,77,86,245,206,133,68,178,144,160,29,235,155,249,143,105,26,38,200,238,253,113,241,213,62,66,107,190,45,1,128,185,6,154,162,160,162,226,56,0,0,6,240,5,53,133,80,166,244,22,180,214,100,205,133,131,42,133,102,130,10,15,56,228,92,208,170,241,150,230,130,57,193,29,175,140,50,36,139,224,211,238,121,63,192,56,134,190,171,103,248,61,191,126,217,99,150,107,236,179,62,78,109,71,178,22,146,185,50,233,177,38,6,24,136,210,26,106,69,85,46,33,20,53,188,114,148,155,70,21,74,67,46,115,69,50,107,246,105,177,37,23,142,100,206,36,243,221,196,9,142,206,115,192,28,11,206,114,93,74,212,230,220,82,193,11,70,181,212,138,122,39,125,5,92,86,85,227,78,188,62,77,1,231,97,188,156,90,24,130,125,197,14,200,175,31,234,217,246,93,26,250,184,88,95,30,143,95,195,115,90,225,190,254,250,177,22,148,112,127,17,145,67,54,141,112,22,3,116,105,215,217,222,133,238,97,245,60,28,80,210,238,205,16,198,19,133,221,211,100,34,201,134,240,240,248,87,90,103,211,152,250,246,63,42,53,195,50,209,3,155,236,152,238,210,131,46,140,251,104,94,142,235,154,124,120,154,250,244,241,11,24,183,137,56,108,207,195,48,166,205,210,175,155,222,111,176,248,41,38,180,219,216,62,70,176,203,101,111,47,1,220,38,97,6,171,150,188,137,81,147,91,98,125,46,177,121,75,170,75,235,241,157,32,145,74,48,75,161,129,162,204,189,173,114,197,182,58,7,237,170,6,168,146,13,30,202,1,219,156,229,124,233,226,70,25,201,154,198,171,109,105,101,37,21,118,185,44,64,83,81,50,142,88,241,56,56,41,45,119,78,114,87,222,18,36,240,79,234,186,185,24,63,255,236,78,47,118,101,124,183,197,221,55,27,187,8,45,94,6,222,229,59,64,28,80,112,117,10,85,207,239,193,178,72,118,93,10,233,101,125,185,245,252,30,78,135,187,133,212,221,1,191,95,243,2,190,158,223,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9bb7fdf0-23d9-4a53-9bfc-b65d5b2b58ef"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1fc1bf95-66f6-437e-ae96-ab0226deef9f"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b6eaed28-95a3-4e02-bc92-584da91d9666"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8af81470-64e6-4c25-bc4e-996386dd37c1"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("876c91d3-f5fd-430b-99a7-6da066af2251"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a511d00e-3b57-438c-ad43-a0b965ac41ff"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("d5067126-b12c-401d-83cc-53d80a232257"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c25ddf34-5ec7-43ef-9f1b-1f022d5afa06"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("39e87f5c-2965-45a4-8ce7-4446e1173001"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3aec9151-bb18-4f05-9f98-6ef24b8eb8fa"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8319a4e6-2ecb-470d-b2fd-9af8514e9ab2"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e55a545-db7b-429c-8850-c3c910df6b27"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d246ad4e-36de-4230-bc79-a36f43b1befe"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				UId = new Guid("7ad11547-1b9b-4507-b7ff-0d224aa61262"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5bfef119-7795-4c1c-8d01-0d38138f2a41"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3e1d582a-dce9-475f-9eed-bc65b2d11830"),
				ContainerUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
		}

		protected virtual void InitializeReadLeadContactParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe828bdd-0b5b-4b21-8d0d-7fe8bbb6c978"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,75,107,220,48,16,199,191,202,162,67,79,214,98,89,15,203,238,49,108,74,46,105,250,164,144,132,160,199,40,17,248,177,177,101,154,96,246,187,119,188,206,182,144,67,201,169,80,108,140,36,107,254,51,255,159,70,243,93,28,207,99,147,96,168,131,105,70,200,166,11,95,19,163,152,224,70,148,52,247,86,83,33,100,160,182,16,57,45,116,176,202,230,58,84,220,145,172,51,45,212,100,141,222,249,152,72,22,19,180,99,125,61,255,17,77,195,4,217,93,56,78,190,184,7,104,205,183,37,1,83,22,184,146,140,234,0,5,21,76,86,84,123,159,83,163,115,238,133,210,220,123,78,214,90,100,48,10,10,93,82,172,201,80,1,86,210,74,107,65,165,51,165,198,71,178,178,32,89,3,33,237,158,246,3,140,99,236,187,122,134,223,227,175,207,123,172,114,205,125,214,55,83,219,145,172,133,100,174,76,122,64,167,144,131,64,41,234,68,37,169,8,80,82,195,43,79,185,177,101,81,106,96,138,149,36,115,102,159,22,89,114,225,73,230,77,50,223,77,51,193,81,121,142,88,99,193,115,166,165,194,88,198,29,21,188,200,169,86,88,114,240,42,84,104,180,170,172,63,241,250,48,69,28,199,241,114,106,97,136,238,5,59,32,191,126,168,103,215,119,105,232,155,69,250,242,184,253,43,60,165,21,238,203,175,31,171,161,132,235,75,16,57,100,211,8,103,77,132,46,237,58,215,251,216,221,175,154,135,3,134,180,123,51,196,241,68,97,247,56,153,134,100,67,188,127,248,43,173,179,105,76,125,251,31,89,205,208,38,106,96,147,29,203,93,122,208,199,113,223,152,231,227,188,38,239,30,167,62,189,255,12,198,111,26,252,108,207,227,48,166,205,210,175,155,62,108,208,252,212,36,148,219,184,190,105,192,45,135,189,253,132,172,98,136,224,55,102,220,44,21,25,151,86,25,242,42,93,77,110,136,11,76,9,0,73,181,116,129,10,135,112,42,145,59,10,22,10,201,130,171,88,153,111,53,3,237,43,11,180,84,22,55,49,236,125,147,51,78,43,27,108,105,84,110,109,40,183,198,139,42,247,82,211,92,46,13,239,53,54,124,33,20,245,94,11,165,192,242,74,243,27,130,48,254,181,197,235,139,241,227,207,238,116,143,87,242,183,91,92,125,181,176,107,160,197,35,194,19,126,3,147,3,6,92,157,82,213,243,91,8,45,33,187,46,197,244,188,222,231,122,126,11,178,195,237,2,237,246,128,239,47,10,149,52,23,245,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b4af7ceb-60b9-467c-a8b3-81953d377341"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("311fcede-bca4-4fec-9a42-0f943fe03159"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ReadSomeTopRecords",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4f32f247-07f2-471b-ba49-b42cae200cf0"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"NumberOfRecords",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d72c0941-da6e-42f6-b7a5-0b3ffe8b2c2e"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"FunctionType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3356dca2-6b01-46e0-9fe2-d0de44ff97b0"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"AggregationColumnName",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d550d767-aeda-4cf2-9b2a-90c7c38be81b"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"OrderInfo",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("fff72291-b74e-4830-8333-56ad140e6e7c"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("05f02083-70af-4052-8ee7-2b228747244c"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultCountParameter.SourceValue = new ProcessSchemaParameterValue(resultCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCountParameter);
			var resultIntegerFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("123bb774-23e8-4cbe-a707-c0bf2149c012"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultIntegerFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultIntegerFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultIntegerFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultIntegerFunctionParameter);
			var resultFloatFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a43adf8a-3d3f-4d55-bbb1-030b98ca7464"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultFloatFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("Float4")
			};
			resultFloatFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultFloatFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultFloatFunctionParameter);
			var resultDateTimeFunctionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2a298fa9-f151-46ad-b486-c3c3bcb89af4"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultDateTimeFunction",
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime")
			};
			resultDateTimeFunctionParameter.SourceValue = new ProcessSchemaParameterValue(resultDateTimeFunctionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultDateTimeFunctionParameter);
			var resultRowsCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51b3ba73-2cd0-43a5-b1bb-d655502ea451"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultRowsCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultRowsCountParameter.SourceValue = new ProcessSchemaParameterValue(resultRowsCountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultRowsCountParameter);
			var canReadUncommitedDataParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bd94e2da-67c7-4c33-985e-1f6fdecc4562"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"CanReadUncommitedData",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			canReadUncommitedDataParameter.SourceValue = new ProcessSchemaParameterValue(canReadUncommitedDataParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(canReadUncommitedDataParameter);
			var resultEntityCollectionParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("53665a2a-42d9-47f3-8bf4-e4ebbd2e10f3"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntityCollection",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f382eb7c-1c7a-4c11-93b3-5b6271585801"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"EntityColumnMetaPathes",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("377fdd7e-2835-4e98-a892-93bd77cfe77f"),
				ContainerUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"IgnoreDisplayValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			ignoreDisplayValuesParameter.SourceValue = new ProcessSchemaParameterValue(ignoreDisplayValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ignoreDisplayValuesParameter);
		}

		protected virtual void InitializeDistributionLeadPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var titleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bbe769c2-34d8-4a8b-a580-a9e4311e6053"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Title",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			titleParameter.SourceValue = new ProcessSchemaParameterValue(titleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Distribution page",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(titleParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5160bb63-99ee-4be0-ad4e-f804a2c25915"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"Recommendation",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var clientUnitSchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2021bd48-f45e-4cd3-b993-7b97a0c3308d"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"ClientUnitSchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			clientUnitSchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(clientUnitSchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"65a13f26-c1c8-49e6-9744-ce1c028164df",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(clientUnitSchemaUIdParameter);
			var entityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1905b493-d577-4148-a465-5b25ff5f0ab4"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"EntityId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entityIdParameter.SourceValue = new ProcessSchemaParameterValue(entityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entityIdParameter);
			var entryPointIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("702a610c-eae3-442a-b9e5-1eae1657abca"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"EntryPointId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entryPointIdParameter.SourceValue = new ProcessSchemaParameterValue(entryPointIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entryPointIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("ab6017ca-8f69-4ec1-95d6-57eb04cec232"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"EntitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var useCardProcessModuleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1babcc34-fbcc-4e3e-84fe-432c05fdbbe5"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"UseCardProcessModule",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			useCardProcessModuleParameter.SourceValue = new ProcessSchemaParameterValue(useCardProcessModuleParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(useCardProcessModuleParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("583c0a7d-9ed9-49b6-919b-fb6caaff12fd"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"OwnerId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3aeda084-6af5-44ea-8738-d38edc340131"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"ShowExecutionPage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{51139bfa-4db4-45f7-aa2f-590d604f8469}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("63033799-a11b-4b1e-9c2b-6e17977e2c43"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"InformationOnStep",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var isRunningParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("809907b4-6caf-4cda-8cd8-58f9c1196633"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				Name = @"IsRunning",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isRunningParameter.SourceValue = new ProcessSchemaParameterValue(isRunningParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isRunningParameter);
			var leadIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("345b747f-6492-4686-a503-0062acd716e0"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"LeadId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			leadIdParameter.SourceValue = new ProcessSchemaParameterValue(leadIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{30cf6943-a881-4c30-a088-ff65572e4241}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(leadIdParameter);
			var resultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a9e78508-ae1b-4141-abe0-24ed11eadb13"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"Result",
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText")
			};
			resultParameter.SourceValue = new ProcessSchemaParameterValue(resultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(resultParameter);
			var remindToOwnerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd5eefc4-6c19-4719-be10-6babbc9acc6e"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"RemindToOwner",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			remindToOwnerParameter.SourceValue = new ProcessSchemaParameterValue(remindToOwnerParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(remindToOwnerParameter);
			var leadOwnerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("0d01d7bb-ccf9-4184-a64f-953b68988ea4"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"LeadOwnerId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			leadOwnerIdParameter.SourceValue = new ProcessSchemaParameterValue(leadOwnerIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(leadOwnerIdParameter);
			var opportunityDepartmentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8227a76e-e673-40a1-a3f3-2102ef5efe7a"),
				ContainerUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"OpportunityDepartment",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			opportunityDepartmentParameter.SourceValue = new ProcessSchemaParameterValue(opportunityDepartmentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(opportunityDepartmentParameter);
		}

		protected virtual void InitializeSaveLeadByDefaultParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("560bc47f-ebc5-4687-aa0c-08705e061a9a"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"EntitySchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c4e20e54-2a71-4e75-a167-24858aec6fcb"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"IsMatchConditions",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba1c792f-b05d-43b6-b1d4-1f6f092ae9d7"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"DataSourceFilters",
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,197,178,100,75,114,143,203,182,44,148,52,208,180,20,146,37,140,165,81,86,224,63,27,75,166,9,102,191,123,181,118,54,133,28,74,233,173,224,195,104,236,247,230,55,15,121,190,247,225,163,111,35,142,181,131,54,96,54,237,108,77,132,211,166,41,154,134,10,107,56,21,96,129,170,162,212,84,200,28,65,241,178,105,242,130,100,61,116,88,147,85,189,181,62,146,204,71,236,66,125,59,255,54,141,227,132,217,189,91,14,95,205,1,59,248,182,12,96,224,148,70,77,101,153,167,41,152,70,41,3,134,58,199,117,83,9,37,24,26,178,178,96,195,36,56,224,20,25,43,18,139,49,180,1,89,80,205,19,5,151,92,88,157,88,90,116,113,251,116,28,49,4,63,244,245,140,175,245,205,243,49,81,174,179,55,67,59,117,61,201,58,140,112,13,241,80,19,192,28,69,105,128,26,161,75,42,28,74,10,92,91,202,161,145,133,84,200,42,38,73,102,224,24,207,182,100,103,73,102,33,194,119,104,39,92,156,103,159,24,11,158,51,85,86,73,203,184,161,130,23,57,85,149,146,212,217,202,105,228,149,214,141,189,228,245,105,242,169,246,225,106,234,112,244,230,37,118,76,249,13,99,61,155,161,143,227,208,158,173,175,150,207,111,240,41,174,225,190,188,250,177,46,20,83,255,44,34,167,108,10,184,105,61,246,113,219,155,193,250,254,97,245,60,157,146,164,59,194,232,195,37,133,237,227,4,45,201,70,255,112,248,99,90,155,41,196,161,251,143,86,205,210,154,201,35,93,178,5,247,124,7,173,15,199,22,158,151,115,77,222,61,78,67,252,240,25,193,174,21,121,163,168,201,29,225,185,113,149,22,156,130,82,140,10,195,115,10,185,82,233,82,86,101,41,11,20,133,96,119,36,81,252,131,247,237,46,124,249,217,95,254,129,149,122,255,62,117,223,52,174,47,202,122,254,27,156,211,254,12,180,63,165,231,23,66,164,233,35,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f3fd0d58-28e8-457f-8737-49c12cc4cc1d"),
				ContainerUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				Name = @"RecordColumnValues",
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,75,111,220,70,12,254,43,11,37,71,211,152,247,99,175,73,15,6,146,214,168,211,92,108,31,56,51,100,179,192,62,12,73,78,145,46,246,191,151,43,175,99,59,109,156,32,151,184,72,4,65,90,205,204,71,114,72,126,228,236,182,123,62,126,184,162,110,222,189,161,190,199,97,195,227,241,139,77,79,199,167,253,166,210,48,28,191,218,84,92,46,254,198,178,164,83,236,113,69,35,245,111,113,121,77,195,171,197,48,30,205,30,194,186,163,238,249,251,105,182,155,159,111,187,147,145,86,127,156,52,145,222,154,109,149,21,2,102,74,224,124,97,192,234,34,216,152,141,105,172,201,55,39,224,186,89,94,175,214,175,105,196,83,28,223,117,243,109,55,73,19,1,222,36,29,173,19,108,85,26,156,210,30,48,134,0,181,104,85,99,241,222,213,212,237,142,186,161,190,163,21,78,74,239,192,78,35,167,76,25,162,87,5,28,149,2,169,98,5,102,155,75,112,201,105,170,123,240,97,253,29,240,252,217,249,201,240,219,95,107,234,207,38,185,115,198,229,64,151,199,50,250,201,192,71,231,204,183,49,22,174,222,105,208,168,17,92,241,4,165,69,217,43,57,147,171,43,193,70,222,93,62,187,220,107,108,139,225,106,137,31,222,254,91,241,164,245,102,209,213,3,199,223,95,182,189,184,137,223,69,55,191,248,92,4,15,239,27,123,31,198,240,211,240,93,116,71,23,221,217,230,186,175,123,137,118,255,113,235,206,73,131,58,92,240,31,143,219,235,70,198,4,123,141,107,252,147,250,95,69,227,4,159,166,94,226,136,147,242,55,98,247,173,224,98,178,87,81,51,68,194,44,1,10,6,82,19,231,101,157,11,219,104,13,179,153,208,191,19,83,79,235,74,15,13,211,161,144,13,94,67,98,50,224,180,207,130,111,10,48,41,219,92,72,86,242,111,194,79,154,239,140,185,205,52,25,89,95,47,151,147,130,97,218,255,62,117,15,134,31,102,94,222,11,213,61,9,155,182,224,5,181,147,245,183,184,106,215,237,118,71,247,121,82,92,210,186,133,8,190,16,129,51,206,67,246,28,197,37,202,41,231,124,51,190,60,202,19,19,51,147,37,5,49,87,5,142,147,130,130,138,129,125,104,44,226,216,229,250,68,120,146,107,179,156,130,5,69,77,120,98,109,130,148,133,44,57,114,50,216,152,156,10,95,230,201,139,158,112,164,89,79,171,197,186,81,63,227,77,63,219,252,72,220,201,170,4,169,167,9,20,115,149,220,151,194,147,98,204,96,156,81,242,3,57,171,248,24,119,190,218,176,167,206,29,85,156,41,53,52,104,166,72,234,83,150,30,99,164,136,88,149,48,58,173,80,238,199,123,76,85,140,49,7,40,42,89,241,164,9,210,164,132,13,149,91,171,198,123,155,81,125,79,238,252,178,164,21,173,199,249,214,146,15,65,73,51,36,161,243,77,55,205,205,52,240,74,133,32,13,85,60,65,187,135,100,243,201,86,133,177,65,166,38,16,49,105,42,174,192,37,84,68,102,109,184,125,153,108,18,199,177,95,148,235,113,177,89,207,174,36,65,143,127,182,169,31,177,77,73,105,209,217,165,42,199,47,150,141,20,220,83,173,122,48,213,24,100,225,91,50,254,81,170,161,83,24,28,203,121,80,145,212,126,69,146,142,46,10,223,124,174,186,113,41,217,242,255,149,106,201,152,40,103,83,2,10,81,202,136,212,29,64,203,22,140,86,134,216,75,106,68,252,22,170,157,225,146,134,89,91,188,95,12,50,246,147,115,95,199,57,223,146,243,161,56,208,94,78,69,174,145,151,242,46,15,100,249,231,192,33,102,169,250,79,149,115,151,187,127,0,78,23,15,135,160,13,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLeadDistributionProcess = CreateLeadDistributionProcessLaneSet();
			LaneSets.Add(schemaLeadDistributionProcess);
			ProcessSchemaLane schemaLeadDistribution = CreateLeadDistributionLane();
			schemaLeadDistributionProcess.Lanes.Add(schemaLeadDistribution);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent terminatehandoff = CreateTerminateHandoffTerminateEvent();
			FlowElements.Add(terminatehandoff);
			ProcessSchemaExclusiveGateway exclusivegatewayisleadset = CreateExclusiveGatewayIsLeadSetExclusiveGateway();
			FlowElements.Add(exclusivegatewayisleadset);
			ProcessSchemaTerminateEvent terminateleadisnotset = CreateTerminateLeadIsNotSetTerminateEvent();
			FlowElements.Add(terminateleadisnotset);
			ProcessSchemaUserTask saveleadhandoff = CreateSaveLeadHandoffUserTask();
			FlowElements.Add(saveleadhandoff);
			ProcessSchemaUserTask saveleadnointerest = CreateSaveLeadNoInterestUserTask();
			FlowElements.Add(saveleadnointerest);
			ProcessSchemaTerminateEvent terminatenointerest = CreateTerminateNoInterestTerminateEvent();
			FlowElements.Add(terminatenointerest);
			ProcessSchemaTerminateEvent terminatecontinuedistribution = CreateTerminateContinueDistributionTerminateEvent();
			FlowElements.Add(terminatecontinuedistribution);
			ProcessSchemaUserTask addreminder = CreateAddReminderUserTask();
			FlowElements.Add(addreminder);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaUserTask readleadtype = CreateReadLeadTypeUserTask();
			FlowElements.Add(readleadtype);
			ProcessSchemaUserTask readleadcontact = CreateReadLeadContactUserTask();
			FlowElements.Add(readleadcontact);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			ProcessSchemaUserTask distributionleadpage = CreateDistributionLeadPageUserTask();
			FlowElements.Add(distributionleadpage);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask saveleadbydefault = CreateSaveLeadByDefaultUserTask();
			FlowElements.Add(saveleadbydefault);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlowCreateReminderConditionalFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlowNoReminderSequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5fb58e15-c3e0-48b9-b270-c3878ba5ec8d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7a92b7ab-7ed4-4582-8e65-9e766afb2829"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("5805d2d7-5516-4f97-9107-0c6b5c4bbc5c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{30cf6943-a881-4c30-a088-ff65572e4241}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(182, 288),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("28c1efc4-e3b9-4c23-8307-4e19e53453b3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("290d5fde-c5b4-44ae-9d6b-38bd65766e89"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(598, 322),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("721db265-d834-462e-bd2d-515b03c3eaf9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowCreateReminderConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowCreateReminder",
				UId = new Guid("97e8e894-d220-43dc-9cfa-0e37f8166e2a"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{9cd3f863-0eda-4338-895e-97f82adfe406}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(648, 154),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("e7b9f7af-f3f3-45b3-b5ef-e55931027930"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(677, 155),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e0fc6ab2-437d-4492-a531-191b3013d93d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowNoReminderSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowNoReminder",
				UId = new Guid("74e4203e-f8b4-42a4-9a72-43c7354d017c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(916, 130),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4",
				UId = new Guid("8e0f40d1-6611-4d88-a2b3-db13f8f8268e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(220, 155),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("f5da7633-709e-40ac-ab2f-51d79b4f1e75"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{a9e78508-ae1b-4141-abe0-24ed11eadb13}]#] == ""TransferToSale""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(480, 152),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("15c1b993-b41b-4b3d-be24-96f8a835c457"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3e566048-ef49-45bf-9d2d-500669220b4e}].[Parameter:{a9e78508-ae1b-4141-abe0-24ed11eadb13}]#] == ""NotInteresting""",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(468, 226),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("7f0e3663-1ccd-4022-9a63-af412567e1dd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(348, 154),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow10",
				UId = new Guid("1d497f73-83f1-49f1-922b-d98d94ddb5e6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(562, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow11",
				UId = new Guid("68e53e5d-ec55-45bb-8ce1-febdee9aa067"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(562, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb6102fb-8548-4fa4-aae5-b307af30608f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8693d20e-d10c-4049-b6c4-7b603c0c353d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(1144, 166),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("a69b197e-c39e-4b7f-b3e2-f9f7e49e02ff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(809, 166),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("efeba810-1988-471e-8f37-8fdf1b4013e7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(920, 168),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("a2112edf-8702-462c-8323-8546cb7408a8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				CurveCenterPosition = new Point(1026, 168),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadDistributionProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadDistributionProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4d9afef7-9066-439f-b71e-60e2c82e61da"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"LeadDistributionProcess",
				Position = new Point(5, 5),
				Size = new Size(1344, 436)
			};
			return schemaLeadDistributionProcess;
		}

		protected virtual ProcessSchemaLane CreateLeadDistributionLane() {
			ProcessSchemaLane schemaLeadDistribution = new ProcessSchemaLane(this) {
				UId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("4d9afef7-9066-439f-b71e-60e2c82e61da"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"LeadDistribution",
				Position = new Point(29, 0),
				Size = new Size(1315, 436)
			};
			return schemaLeadDistribution;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("7a92b7ab-7ed4-4582-8e65-9e766afb2829"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"Start",
				Position = new Point(50, 23),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateHandoffTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("e0fc6ab2-437d-4492-a531-191b3013d93d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"TerminateHandoff",
				Position = new Point(1059, 247),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayIsLeadSetExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ExclusiveGatewayIsLeadSet",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(36, 121),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateLeadIsNotSetTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("28c1efc4-e3b9-4c23-8307-4e19e53453b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"TerminateLeadIsNotSet",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(50, 247),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateSaveLeadHandoffUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"SaveLeadHandoff",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(371, 121),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeSaveLeadHandoffParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateSaveLeadNoInterestUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"SaveLeadNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(320, 233),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeSaveLeadNoInterestParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateNoInterestTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("721db265-d834-462e-bd2d-515b03c3eaf9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"TerminateNoInterest",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(440, 247),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateContinueDistributionTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("cb6102fb-8548-4fa4-aae5-b307af30608f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"TerminateContinueDistribution",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(440, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateAddReminderUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"AddReminder",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(929, 121),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddReminderParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ReadLeadData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(531, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadTypeUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ReadLeadType",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(800, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadTypeParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadContactUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ReadLeadContact",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(671, 121),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadContactParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1045, 121),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateDistributionLeadPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"DistributionLeadPage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(131, 121),
				SchemaUId = new Guid("ac2ef13c-30dd-4023-9c04-58f580743b48"),
				SerializeToDB = true,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeDistributionLeadPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(240, 121),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateSaveLeadByDefaultUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e6e824c2-16a4-43c0-a73a-7309e704e6e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("65fa192b-1ddc-4120-9cd7-c89cc2cad577"),
				CreatedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"),
				Name = @"SaveLeadByDefault",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(320, 20),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeSaveLeadByDefaultParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementDistribution(userConnection);
		}

		public override object Clone() {
			return new LeadManagementDistributionSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementDistribution

	/// <exclude/>
	public class LeadManagementDistribution : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadDistribution

		/// <exclude/>
		public class ProcessLeadDistribution : ProcessLane
		{

			public ProcessLeadDistribution(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: SaveLeadHandoffFlowElement

		/// <exclude/>
		public class SaveLeadHandoffFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public SaveLeadHandoffFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveLeadHandoff";
				IsLogging = true;
				SchemaElementUId = new Guid("79bed3ce-b5f5-4199-a64d-91f1eede0c61");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("ceb70b3c-985f-4867-ae7c-88f9dd710688"));
				_recordColumnValues_Owner = () => (Guid)((process.ResponsibleId));
				_recordColumnValues_RemindToOwner = () => (bool)((process.CreateReminder));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.DistributionLeadPage.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private  Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_RemindToOwner", () => _recordColumnValues_RemindToOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<Guid> _recordColumnValues_Owner;
			internal Func<bool> _recordColumnValues_RemindToOwner;
			internal Func<Guid> _recordColumnValues_OpportunityDepartment;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private bool _isMatchConditions = true;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,69,182,198,178,236,30,151,109,89,40,105,160,105,41,36,75,24,75,163,172,192,127,54,182,76,19,204,126,247,202,235,108,10,57,148,210,91,193,135,209,216,239,167,55,143,241,124,239,199,143,190,9,52,84,14,155,145,146,105,103,43,38,108,86,103,136,192,51,5,5,7,43,5,199,210,104,14,160,92,46,108,129,194,32,75,58,108,169,98,171,122,107,125,96,137,15,212,142,213,237,252,27,26,134,137,146,123,119,62,124,53,7,106,241,219,114,1,164,232,116,73,37,47,114,81,115,160,186,230,218,160,225,206,201,178,86,160,33,37,195,86,47,168,4,101,26,136,231,18,4,135,28,11,94,103,96,121,90,80,14,153,148,145,3,44,105,200,133,237,211,113,160,113,244,125,87,205,244,90,223,60,31,163,203,245,238,77,223,76,109,199,146,150,2,94,99,56,68,58,9,130,220,32,55,80,230,28,28,21,28,101,105,185,196,186,200,10,77,169,74,11,150,24,60,134,5,203,118,150,37,22,3,126,199,102,162,51,121,246,209,99,38,69,170,115,21,181,169,52,28,100,38,184,86,186,224,206,42,87,146,84,101,89,219,75,94,159,38,31,107,63,94,77,45,13,222,188,196,78,49,191,126,168,102,211,119,97,232,155,5,125,117,254,252,134,158,194,26,238,203,171,31,235,64,33,246,23,17,59,37,211,72,155,198,83,23,182,157,233,173,239,30,86,230,233,20,37,237,17,7,63,94,82,216,62,78,216,176,100,240,15,135,63,166,181,153,198,208,183,255,209,168,73,28,51,50,226,146,157,237,46,59,104,253,120,108,240,249,124,174,216,187,199,169,15,31,62,19,218,181,98,111,20,21,187,99,82,24,167,74,144,28,181,78,57,152,101,235,133,214,113,41,85,158,23,25,65,6,233,29,139,46,254,129,125,187,27,191,252,236,46,255,192,234,122,255,62,118,223,52,174,47,202,106,254,27,59,167,253,98,104,127,138,207,47,177,221,110,55,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,219,110,219,70,16,253,21,129,201,163,71,216,251,69,175,73,129,26,112,90,163,78,242,98,251,97,47,51,141,80,73,52,72,42,69,42,232,223,59,164,237,218,10,26,219,72,80,212,69,202,135,165,184,171,51,51,187,115,206,206,236,154,151,195,167,43,108,22,205,91,236,186,212,183,52,204,95,181,29,206,79,187,182,96,223,207,79,218,146,86,203,63,82,94,225,105,234,210,26,7,236,222,167,213,22,251,147,101,63,28,205,14,97,205,81,243,242,227,180,218,44,206,119,205,241,128,235,119,199,149,173,23,85,157,145,58,65,149,37,130,65,235,32,186,92,160,134,224,36,37,178,222,43,6,151,118,181,93,111,222,224,144,78,211,240,161,89,236,154,201,26,27,200,69,140,54,4,216,164,43,152,96,4,164,100,16,138,19,152,188,119,168,132,107,246,71,77,95,62,224,58,77,78,239,192,70,38,10,17,35,120,43,50,123,207,25,66,73,5,136,116,204,142,141,73,44,35,248,230,255,119,192,243,23,39,109,251,219,246,106,174,148,54,178,84,9,54,107,13,166,176,251,40,164,4,71,222,69,141,228,208,152,121,193,236,69,214,5,98,176,196,49,58,15,9,125,129,16,40,214,234,165,112,33,188,184,28,29,213,101,127,181,74,159,222,127,209,223,217,144,126,197,249,143,105,83,91,162,217,208,206,250,180,194,254,26,124,117,144,135,251,240,221,197,117,58,47,154,197,197,151,18,122,243,62,155,206,233,48,165,159,103,243,162,57,186,104,206,218,109,87,70,139,122,252,184,61,221,201,131,184,121,224,111,134,219,231,218,198,4,123,147,54,188,169,238,39,246,56,193,167,165,215,105,72,147,243,183,28,247,173,225,172,162,21,94,18,120,76,35,91,156,130,80,101,130,40,99,38,237,181,34,82,19,250,23,36,236,112,83,240,48,176,167,100,107,194,79,158,239,130,185,37,30,207,108,182,171,213,228,160,159,246,63,50,249,38,240,155,149,215,247,82,120,207,66,91,151,180,196,122,188,249,154,163,218,55,251,253,209,125,217,68,196,160,148,241,160,107,80,96,140,52,204,173,36,33,145,19,169,196,34,181,18,15,202,198,170,32,189,54,129,15,65,72,48,66,90,72,222,57,40,89,138,226,179,181,166,132,127,66,54,231,199,253,207,191,111,176,187,62,133,5,165,85,143,151,115,158,253,108,226,47,2,46,118,222,103,42,214,72,144,137,83,109,178,69,200,213,243,214,209,168,88,76,118,218,211,254,242,49,253,76,94,255,215,201,211,116,34,93,70,237,172,132,64,200,244,146,54,50,190,242,205,26,132,174,198,5,93,171,254,79,232,68,214,164,5,21,3,89,21,100,154,243,165,155,139,25,105,238,172,86,166,202,138,241,65,157,40,31,9,53,10,240,177,8,48,20,4,228,36,8,200,186,74,202,88,50,177,60,19,157,196,82,53,5,167,65,96,101,157,104,29,32,68,22,75,244,20,84,170,132,70,184,199,117,242,170,195,52,224,172,195,245,114,83,177,155,81,219,205,218,239,73,59,81,48,55,50,5,16,68,133,185,207,23,79,240,62,130,50,74,240,143,68,81,248,135,180,243,228,192,158,187,118,44,138,236,45,101,80,218,113,137,160,202,151,64,228,218,153,125,96,2,59,197,163,125,80,59,201,136,228,12,37,72,220,138,177,248,144,123,59,227,29,36,203,5,170,82,206,81,211,191,169,157,31,86,184,198,205,176,216,105,110,59,157,224,98,136,44,103,48,156,125,136,85,85,176,66,56,23,149,18,217,224,254,80,108,92,125,61,23,76,4,116,158,59,9,49,214,94,77,26,148,20,10,201,50,53,124,122,92,108,156,199,161,91,230,237,176,108,55,179,171,177,179,59,27,219,185,89,93,126,92,246,60,247,189,104,238,91,235,149,173,193,88,151,13,72,38,45,152,138,22,178,224,33,17,183,51,228,124,180,229,217,106,238,114,255,39,45,21,12,90,108,13,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "d6c59cedf94c477daef17418c7544cfe",
							"BaseElements.SaveLeadHandoff.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordColumnValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordColumnValues", getColumnValue);
					}
					return _recordColumnValues;
				}
				set {
					_recordColumnValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: SaveLeadNoInterestFlowElement

		/// <exclude/>
		public class SaveLeadNoInterestFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public SaveLeadNoInterestFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveLeadNoInterest";
				IsLogging = true;
				SchemaElementUId = new Guid("7969b2cd-51e0-490c-b289-63e0473f9af3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifyStatus = () => (Guid)(new Guid("51adc3ec-3503-4b10-a00b-8be3b0e11f08"));
				_recordColumnValues_LeadTypeStatus = () => (Guid)(new Guid("f78066d3-a73e-4e86-bb99-e477fcb94b28"));
				_recordColumnValues_Owner = () => (Guid)((process.DistributionLeadPage.OwnerId));
				_recordColumnValues_RemindToOwner = () => (bool)((process.DistributionLeadPage.RemindToOwner));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.DistributionLeadPage.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private  Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifyStatus", () => _recordColumnValues_QualifyStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_LeadTypeStatus", () => _recordColumnValues_LeadTypeStatus.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_RemindToOwner", () => _recordColumnValues_RemindToOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifyStatus;
			internal Func<Guid> _recordColumnValues_LeadTypeStatus;
			internal Func<Guid> _recordColumnValues_Owner;
			internal Func<bool> _recordColumnValues_RemindToOwner;
			internal Func<Guid> _recordColumnValues_OpportunityDepartment;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private bool _isMatchConditions = true;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,245,225,30,151,109,89,40,105,160,105,41,36,75,144,165,81,86,224,143,141,37,211,4,179,255,189,242,58,155,66,14,165,244,86,208,97,52,154,247,230,205,99,52,223,135,248,49,180,9,198,218,155,54,2,158,118,174,70,69,229,20,48,197,8,5,230,9,23,162,36,186,162,21,113,86,73,203,37,99,32,27,132,123,211,65,141,86,244,214,133,132,112,72,208,197,250,118,254,77,154,198,9,240,189,63,95,190,218,3,116,230,219,210,128,83,227,149,6,77,100,85,52,132,67,211,16,101,141,37,222,51,221,8,174,56,5,139,86,45,76,23,66,230,90,82,22,174,36,220,8,75,180,84,146,72,224,180,148,90,59,90,50,132,91,240,105,251,116,28,33,198,48,244,245,12,175,241,205,243,49,171,92,123,111,134,118,234,122,132,59,72,230,218,164,67,141,12,20,192,43,107,136,229,186,34,220,131,36,134,105,71,152,105,100,41,21,80,65,37,194,214,28,211,66,139,118,14,97,103,146,249,110,218,9,206,204,115,200,26,75,86,80,85,137,140,165,204,18,206,202,130,40,145,53,122,39,188,6,38,180,110,220,197,175,79,83,200,113,136,87,83,7,99,176,47,182,67,246,111,24,235,217,14,125,26,135,118,161,190,58,151,223,192,83,90,205,125,121,250,177,14,148,114,126,1,161,19,158,34,108,218,0,125,218,246,118,112,161,127,88,57,79,167,12,233,142,102,12,241,226,194,246,113,50,45,194,99,120,56,252,209,173,205,20,211,208,253,71,163,226,60,102,230,200,75,118,150,187,236,160,11,241,216,154,231,243,189,70,239,30,167,33,125,248,12,198,173,17,122,131,168,209,29,98,133,245,66,115,70,140,82,148,112,203,10,98,10,165,242,82,138,170,146,37,240,146,211,59,148,85,252,3,247,237,46,126,249,217,95,254,192,170,122,255,62,103,223,36,174,47,200,122,254,27,57,167,253,34,104,127,202,231,23,171,70,92,220,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,77,111,27,71,12,253,43,194,38,71,83,152,239,15,93,155,30,12,56,110,16,167,185,196,62,112,56,156,70,168,172,53,180,171,20,169,161,255,94,106,109,39,118,208,184,134,139,0,49,146,133,176,130,102,247,145,20,201,199,55,115,217,61,31,63,94,112,183,232,222,240,102,131,67,223,198,249,47,253,134,231,175,54,61,241,48,204,143,122,194,213,242,111,44,43,126,133,27,60,231,145,55,111,113,181,229,225,104,57,140,7,179,187,176,238,160,123,254,97,122,218,45,222,93,118,135,35,159,255,126,88,197,122,97,39,159,152,161,182,146,193,41,34,72,218,100,176,129,114,142,70,215,152,247,96,234,87,219,243,245,75,30,241,21,142,239,187,197,101,55,89,219,27,32,69,166,6,5,30,109,5,151,156,2,68,199,64,65,49,198,24,216,168,208,237,14,186,129,222,243,57,78,78,63,131,157,198,150,50,103,136,94,21,112,92,10,36,66,130,214,108,46,65,140,105,166,61,248,250,253,207,192,119,207,142,250,254,207,237,197,220,24,235,52,85,13,190,88,11,142,196,125,86,90,67,104,49,100,203,45,176,115,115,175,177,146,101,2,235,149,188,84,180,196,168,196,97,42,108,139,98,173,155,74,207,206,246,142,234,114,184,88,225,199,183,95,245,119,50,226,31,60,63,238,199,217,114,45,25,231,97,228,122,5,189,184,83,133,219,224,203,211,171,98,158,118,139,211,175,149,243,250,251,100,202,210,221,130,126,89,203,211,238,224,180,59,233,183,27,218,91,180,251,31,55,185,157,60,168,235,11,254,229,118,115,93,217,152,96,47,113,45,127,105,115,44,30,39,248,244,232,5,142,56,57,127,35,113,223,24,46,38,123,21,117,131,200,40,189,194,193,64,170,26,33,235,92,154,141,214,180,102,38,244,107,110,146,154,53,241,221,192,30,82,171,9,63,121,254,28,204,77,219,201,202,122,187,90,77,14,134,233,255,239,251,248,58,240,235,39,47,110,21,240,150,133,190,46,219,146,235,225,250,49,169,218,117,187,221,193,109,210,184,210,130,202,92,193,168,100,192,229,80,161,68,182,144,164,161,130,33,172,30,243,189,164,201,197,196,76,49,128,50,90,50,209,188,6,164,26,192,102,27,88,171,144,75,117,223,146,52,181,105,162,20,32,152,72,224,170,220,176,74,93,85,229,196,92,176,200,28,152,183,152,84,8,213,2,70,203,226,70,94,47,37,103,144,105,17,27,149,236,138,121,40,105,142,153,235,76,152,51,110,135,159,212,121,28,117,30,80,177,39,65,29,171,117,172,210,235,80,168,32,56,79,1,178,83,194,36,54,58,89,111,89,81,187,151,58,222,36,29,173,75,50,63,148,22,193,210,94,26,52,4,32,153,234,20,139,247,142,210,183,160,206,187,195,225,183,191,214,188,185,202,194,162,225,106,224,179,185,172,126,177,240,235,138,207,121,61,46,46,45,251,16,148,4,202,205,73,201,125,105,144,171,169,224,149,208,42,27,163,138,227,157,0,62,117,236,226,210,39,75,10,99,5,153,45,2,145,144,166,6,129,86,2,33,182,166,77,171,187,179,255,34,157,212,113,220,44,203,118,92,246,235,217,197,94,174,166,192,127,82,237,97,84,211,65,118,5,65,38,114,106,44,195,93,251,44,248,42,59,134,164,108,117,33,217,90,237,147,160,90,112,182,154,96,132,26,156,69,100,66,34,200,205,59,17,45,173,49,186,200,196,245,94,170,137,70,53,22,70,130,104,149,18,149,74,10,10,170,6,205,135,218,140,243,210,215,244,84,169,70,213,51,55,114,16,72,11,36,202,173,136,242,66,144,89,90,40,35,81,224,199,80,237,53,159,47,215,149,55,179,214,111,102,253,143,196,187,172,74,144,204,39,80,173,137,68,105,39,12,138,114,176,48,78,118,73,49,98,203,42,222,199,187,7,7,246,189,243,46,198,74,122,63,182,137,176,137,66,5,7,50,121,156,164,36,165,232,43,138,78,221,191,59,68,167,48,184,134,114,72,97,209,72,197,123,141,148,205,34,250,76,90,206,105,37,219,246,84,121,151,140,137,162,215,12,28,162,12,37,133,178,243,181,205,130,209,202,112,243,210,26,17,31,195,187,19,92,241,48,171,203,15,203,65,214,126,20,206,253,95,173,243,53,57,31,138,3,237,101,204,187,202,30,228,60,44,59,170,38,187,169,22,98,246,244,221,114,238,108,247,15,135,170,124,219,36,17,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "d6c59cedf94c477daef17418c7544cfe",
							"BaseElements.SaveLeadNoInterest.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordColumnValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordColumnValues", getColumnValue);
					}
					return _recordColumnValues;
				}
				set {
					_recordColumnValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddReminderFlowElement

		/// <exclude/>
		public class AddReminderFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddReminderFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddReminder";
				IsLogging = true;
				SchemaElementUId = new Guid("acf07003-ffee-46aa-832b-5d378b97f75e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_SysEntitySchema = () => (Guid)(new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
				_recordDefValues_Contact = () => (Guid)((process.ResponsibleId));
				_recordDefValues_SubjectId = () => (Guid)((process.LeadId));
				_recordDefValues_RemindTime = () => (DateTime)(((DateTime)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentDateTime")));
				_recordDefValues_Source = () => (Guid)(new Guid("a66d08e1-2e2d-e011-ac0a-00155d043205"));
				_recordDefValues_SubjectCaption = () => new LocalizableString(String.Concat("Need ", ((process.ReadLeadType.ResultEntity.IsColumnValueLoaded(process.ReadLeadType.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadType.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " of the contact ", ((process.ReadLeadContact.ResultEntity.IsColumnValueLoaded(process.ReadLeadContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadContact.ResultEntity.GetTypedColumnValue<string>("Name") : null))," was proceeded to handoff"));
				_recordDefValues_Description = () => new LocalizableString(String.Concat("Need", ((process.ReadLeadType.ResultEntity.IsColumnValueLoaded(process.ReadLeadType.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadType.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " of the contact ", ((process.ReadLeadContact.ResultEntity.IsColumnValueLoaded(process.ReadLeadContact.ResultEntity.Schema.Columns.GetByName("Name").ColumnValueName) ? process.ReadLeadContact.ResultEntity.GetTypedColumnValue<string>("Name") : null)), " was proceeded to handoff"));
				_recordDefValues_TypeCaption = () => new LocalizableString("Lead");
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private  Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_SysEntitySchema", () => _recordDefValues_SysEntitySchema.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SubjectId", () => _recordDefValues_SubjectId.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_RemindTime", () => _recordDefValues_RemindTime.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Source", () => _recordDefValues_Source.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SubjectCaption", () => _recordDefValues_SubjectCaption.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Description", () => _recordDefValues_Description.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_TypeCaption", () => _recordDefValues_TypeCaption.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_SysEntitySchema;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_SubjectId;
			internal Func<DateTime> _recordDefValues_RemindTime;
			internal Func<Guid> _recordDefValues_Source;
			internal Func<string> _recordDefValues_SubjectCaption;
			internal Func<string> _recordDefValues_Description;
			internal Func<string> _recordDefValues_TypeCaption;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("ae7a5bc6-115f-4ed2-97c5-13f5c5142c37");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,93,111,83,71,16,253,43,87,23,30,90,41,107,237,247,236,230,173,2,90,69,2,138,8,229,37,206,195,236,238,44,177,234,216,145,125,13,162,81,254,123,103,111,66,73,40,117,82,20,36,32,241,131,63,174,239,204,238,206,204,57,115,230,158,246,15,135,247,39,212,239,246,175,104,181,194,245,178,14,147,71,203,21,77,94,172,150,153,214,235,201,211,101,198,249,236,47,76,115,122,129,43,60,166,129,86,175,113,190,161,245,211,217,122,216,233,174,154,245,59,253,195,183,227,191,253,238,193,105,191,55,208,241,31,123,133,189,123,235,139,6,235,68,205,5,133,133,224,5,66,169,2,140,84,5,148,201,16,42,27,231,229,124,115,188,120,70,3,190,192,225,168,223,61,237,71,111,236,128,124,165,10,214,139,138,46,10,43,37,137,0,158,191,89,11,198,38,133,90,154,254,108,167,95,231,35,58,198,113,209,143,198,72,128,46,101,47,148,114,85,88,42,90,68,200,78,40,83,93,118,202,234,108,160,25,95,220,255,209,112,65,239,186,223,54,179,242,211,180,183,10,107,136,20,5,56,153,216,71,74,34,100,204,162,86,19,147,183,193,42,202,211,254,231,230,166,204,214,39,115,124,255,250,118,188,157,92,9,251,101,127,167,211,243,236,77,251,221,233,127,229,239,226,115,127,12,203,213,12,126,154,188,105,191,51,237,247,151,155,85,110,30,77,251,241,33,152,227,10,242,226,37,62,243,246,225,117,238,99,52,123,134,11,124,67,171,231,188,226,104,62,254,245,24,7,28,23,127,197,251,254,224,56,233,232,36,40,174,6,66,206,40,121,45,66,81,40,162,138,169,26,48,186,86,61,90,191,164,74,43,90,100,186,186,49,212,197,74,64,37,184,182,172,176,198,90,129,25,148,8,1,45,233,84,99,214,97,180,31,87,254,184,153,15,117,198,87,22,155,249,124,92,96,61,158,191,21,238,197,198,47,254,121,124,41,167,151,60,44,203,172,206,168,236,45,190,36,84,103,253,217,217,206,101,148,228,164,77,133,146,132,207,186,8,27,60,137,152,37,138,156,117,37,159,193,6,133,91,81,98,165,178,70,229,34,84,113,154,177,161,162,64,85,149,0,239,1,141,179,182,232,124,251,40,57,120,112,176,183,254,253,221,130,86,231,81,216,173,56,95,211,225,132,175,126,114,225,159,2,220,61,5,72,53,59,171,132,66,78,181,77,142,68,42,0,194,144,213,49,219,228,13,212,179,195,7,135,219,0,117,240,96,92,245,252,166,123,156,92,135,19,229,19,25,239,24,24,149,184,58,20,19,105,40,69,10,12,210,20,235,131,41,197,124,23,56,49,217,114,67,49,89,88,238,27,173,5,84,17,125,84,162,42,194,18,48,69,91,195,86,156,72,167,162,53,181,112,15,137,236,192,112,56,82,182,70,228,154,64,214,100,117,144,246,27,193,137,145,185,122,222,44,103,41,40,62,176,225,124,201,16,184,83,120,231,64,51,90,172,186,30,39,79,57,48,119,5,38,154,53,69,112,30,152,250,90,137,24,45,69,240,1,68,45,190,70,6,64,140,169,108,131,201,141,55,246,173,195,196,90,93,178,99,250,119,13,28,86,179,190,8,150,170,48,82,187,234,149,46,169,228,173,48,201,4,53,130,12,194,229,196,253,200,40,47,18,26,166,158,232,201,24,21,157,209,95,5,38,251,239,215,175,113,53,107,162,115,242,104,179,226,28,13,156,105,122,53,59,166,235,10,157,77,249,252,221,219,79,204,187,194,246,29,46,74,55,176,147,110,188,255,174,224,161,104,69,145,170,21,89,122,150,71,82,49,217,233,208,148,180,194,160,64,177,104,178,119,2,15,21,163,150,196,120,40,94,165,166,142,164,72,54,58,14,137,75,30,34,183,14,178,91,241,128,149,20,119,7,16,20,85,3,148,97,60,64,1,225,108,42,206,5,80,49,124,133,33,132,217,123,185,252,115,115,50,41,57,39,74,193,9,135,60,47,88,158,31,68,172,149,88,236,33,98,78,156,206,226,38,232,125,145,129,148,208,196,26,146,36,111,20,155,134,148,82,57,87,100,163,67,119,109,183,56,95,239,249,114,224,240,103,28,102,203,69,119,158,185,201,47,155,225,104,121,175,184,110,168,184,110,146,177,239,2,58,41,73,151,67,180,66,107,158,41,44,218,22,3,30,95,53,229,196,197,22,201,202,184,21,58,53,200,18,21,176,210,175,145,223,188,2,145,60,67,7,107,173,152,84,138,197,193,237,67,103,127,88,205,22,111,184,134,22,92,197,60,118,63,39,42,29,199,167,187,185,20,123,50,167,99,110,32,187,167,148,41,24,159,188,40,174,112,8,218,128,133,88,165,136,6,89,61,39,158,64,157,61,187,170,221,138,147,30,148,102,150,80,58,55,230,101,193,105,114,22,206,148,32,81,27,173,29,52,147,39,139,97,54,188,127,52,6,143,39,35,227,89,229,33,48,95,19,91,49,107,137,36,13,135,222,57,157,184,235,242,104,100,154,226,219,225,147,116,203,218,13,71,212,229,229,98,192,60,124,233,217,98,114,21,108,169,130,227,3,28,96,102,142,164,137,143,234,181,9,46,70,11,177,126,114,54,206,27,104,205,186,34,129,37,46,109,214,165,193,24,195,90,3,139,178,146,60,65,254,247,217,208,229,140,16,121,250,128,194,138,66,7,100,171,154,88,96,68,157,74,137,80,107,24,207,198,71,123,135,235,238,164,145,4,21,206,218,176,236,142,184,127,47,107,189,230,41,203,150,156,191,100,21,220,45,218,239,70,78,147,95,103,171,245,208,205,154,94,224,48,174,104,189,153,15,108,202,193,156,207,41,55,214,155,52,168,109,139,244,232,113,222,222,46,174,255,15,167,215,31,241,199,39,88,151,209,176,66,229,153,70,201,54,221,52,213,30,61,10,195,195,40,122,172,152,107,190,19,218,68,18,211,72,96,36,200,16,185,83,240,164,206,19,169,9,66,58,228,222,33,73,241,151,173,4,11,213,102,71,177,209,106,115,192,202,174,61,4,147,130,129,109,138,102,202,72,234,43,104,147,207,129,237,158,95,191,3,126,237,110,151,96,111,135,95,111,143,91,111,112,188,31,159,92,75,73,6,21,145,144,64,129,17,197,234,53,1,87,123,225,234,81,33,73,89,239,200,131,16,15,0,69,87,35,84,155,249,44,48,236,81,7,86,175,152,149,87,100,10,168,237,15,66,136,192,132,196,227,158,83,129,177,165,51,156,235,248,104,32,25,158,15,172,172,229,246,201,117,218,183,199,118,211,126,27,24,47,223,115,95,209,63,114,69,31,158,253,13,107,77,72,105,173,29,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "d6c59cedf94c477daef17418c7544cfe",
							"BaseElements.AddReminder.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadLeadDataFlowElement

		/// <exclude/>
		public class ReadLeadDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("cf164ee5-85cf-4c3c-940c-ebe251fc9170");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,36,21,203,146,109,201,61,46,219,178,80,210,64,211,82,72,150,48,150,70,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,107,7,109,64,58,237,108,77,20,22,141,43,13,103,121,213,20,76,54,220,50,205,65,50,107,108,137,185,203,27,173,36,161,61,116,88,147,21,189,181,62,18,234,35,118,161,190,157,127,147,198,113,66,122,239,206,201,87,115,192,14,190,45,13,36,7,167,52,106,86,21,89,195,36,54,13,83,6,12,115,78,232,166,148,74,114,52,100,213,98,11,157,73,173,145,85,198,85,76,106,80,76,59,37,24,20,38,19,194,102,80,112,78,104,139,46,110,159,142,35,134,224,135,190,158,241,53,190,121,62,38,149,107,239,205,208,78,93,79,104,135,17,174,33,30,106,2,152,161,44,12,48,35,117,154,212,97,197,64,104,203,4,52,85,94,41,228,37,175,8,53,112,140,11,45,217,89,66,45,68,248,14,237,132,103,230,217,39,141,185,200,184,42,202,132,229,194,48,41,242,140,169,82,85,204,217,210,105,20,165,214,141,189,248,245,105,242,41,246,225,106,234,112,244,230,197,118,76,254,13,99,61,155,161,143,227,208,46,212,87,231,231,55,248,20,87,115,95,174,126,172,3,197,84,95,64,228,68,167,128,155,214,99,31,183,189,25,172,239,31,86,206,211,41,65,186,35,140,62,92,92,216,62,78,208,18,58,250,135,195,31,221,218,76,33,14,221,127,52,42,77,99,38,142,180,100,103,185,203,14,90,31,142,45,60,159,243,154,188,123,156,134,248,225,51,130,93,35,242,6,81,147,59,34,50,227,74,45,211,106,41,197,153,52,34,99,144,41,149,150,178,44,138,42,71,153,75,126,71,146,138,127,224,190,221,133,47,63,251,203,31,88,85,239,223,167,234,155,194,245,5,89,207,127,35,231,180,95,4,237,79,233,252,2,246,133,21,47,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,212,241,1,114,66,42,11,82,227,193,34,6,86,6,58,129,165,137,57,153,105,153,169,41,206,249,121,37,137,201,37,8,25,207,20,16,5,0,82,99,140,34,63,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadLeadTypeFlowElement

		/// <exclude/>
		public class ReadLeadTypeFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadTypeFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadType";
				IsLogging = true;
				SchemaElementUId = new Guid("ece836b6-d5d9-4d52-aaf0-93a3d4b40754");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,193,106,220,48,16,134,95,101,209,161,39,107,145,45,89,146,221,99,216,148,92,210,208,166,165,144,132,32,75,163,68,32,219,27,91,166,9,102,223,189,227,117,182,133,28,74,78,133,130,17,146,172,255,159,153,79,163,249,62,140,231,33,38,24,106,111,226,8,217,116,225,106,98,185,168,84,99,24,149,185,6,42,44,115,212,232,210,81,85,152,188,210,80,50,239,4,201,58,211,66,77,86,245,206,133,68,178,144,160,29,235,155,249,143,105,26,38,200,238,253,113,241,213,62,66,107,190,45,1,128,185,6,154,162,160,162,226,56,0,0,6,240,5,53,133,80,166,244,22,180,214,100,205,133,131,42,133,102,130,10,15,56,228,92,208,170,241,150,230,130,57,193,29,175,140,50,36,139,224,211,238,121,63,192,56,134,190,171,103,248,61,191,126,217,99,150,107,236,179,62,78,109,71,178,22,146,185,50,233,177,38,6,24,136,210,26,106,69,85,46,33,20,53,188,114,148,155,70,21,74,67,46,115,69,50,107,246,105,177,37,23,142,100,206,36,243,221,196,9,142,206,115,192,28,11,206,114,93,74,212,230,220,82,193,11,70,181,212,138,122,39,125,5,92,86,85,227,78,188,62,77,1,231,97,188,156,90,24,130,125,197,14,200,175,31,234,217,246,93,26,250,184,88,95,30,143,95,195,115,90,225,190,254,250,177,22,148,112,127,17,145,67,54,141,112,22,3,116,105,215,217,222,133,238,97,245,60,28,80,210,238,205,16,198,19,133,221,211,100,34,201,134,240,240,248,87,90,103,211,152,250,246,63,42,53,195,50,209,3,155,236,152,238,210,131,46,140,251,104,94,142,235,154,124,120,154,250,244,241,11,24,183,137,56,108,207,195,48,166,205,210,175,155,222,111,176,248,41,38,180,219,216,62,70,176,203,101,111,47,1,220,38,97,6,171,150,188,137,81,147,91,98,125,46,177,121,75,170,75,235,241,157,32,145,74,48,75,161,129,162,204,189,173,114,197,182,58,7,237,170,6,168,146,13,30,202,1,219,156,229,124,233,226,70,25,201,154,198,171,109,105,101,37,21,118,185,44,64,83,81,50,142,88,241,56,56,41,45,119,78,114,87,222,18,36,240,79,234,186,185,24,63,255,236,78,47,118,101,124,183,197,221,55,27,187,8,45,94,6,222,229,59,64,28,80,112,117,10,85,207,239,193,178,72,118,93,10,233,101,125,185,245,252,30,78,135,187,133,212,221,1,191,95,243,2,190,158,223,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadLeadContactFlowElement

		/// <exclude/>
		public class ReadLeadContactFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadContactFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadContact";
				IsLogging = true;
				SchemaElementUId = new Guid("9b5f74df-eed7-4e2d-b2e6-d6238599479f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,75,107,220,48,16,199,191,202,162,67,79,214,98,89,15,203,238,49,108,74,46,105,250,164,144,132,160,199,40,17,248,177,177,101,154,96,246,187,119,188,206,182,144,67,201,169,80,108,140,36,107,254,51,255,159,70,243,93,28,207,99,147,96,168,131,105,70,200,166,11,95,19,163,152,224,70,148,52,247,86,83,33,100,160,182,16,57,45,116,176,202,230,58,84,220,145,172,51,45,212,100,141,222,249,152,72,22,19,180,99,125,61,255,17,77,195,4,217,93,56,78,190,184,7,104,205,183,37,1,83,22,184,146,140,234,0,5,21,76,86,84,123,159,83,163,115,238,133,210,220,123,78,214,90,100,48,10,10,93,82,172,201,80,1,86,210,74,107,65,165,51,165,198,71,178,178,32,89,3,33,237,158,246,3,140,99,236,187,122,134,223,227,175,207,123,172,114,205,125,214,55,83,219,145,172,133,100,174,76,122,64,167,144,131,64,41,234,68,37,169,8,80,82,195,43,79,185,177,101,81,106,96,138,149,36,115,102,159,22,89,114,225,73,230,77,50,223,77,51,193,81,121,142,88,99,193,115,166,165,194,88,198,29,21,188,200,169,86,88,114,240,42,84,104,180,170,172,63,241,250,48,69,28,199,241,114,106,97,136,238,5,59,32,191,126,168,103,215,119,105,232,155,69,250,242,184,253,43,60,165,21,238,203,175,31,171,161,132,235,75,16,57,100,211,8,103,77,132,46,237,58,215,251,216,221,175,154,135,3,134,180,123,51,196,241,68,97,247,56,153,134,100,67,188,127,248,43,173,179,105,76,125,251,31,89,205,208,38,106,96,147,29,203,93,122,208,199,113,223,152,231,227,188,38,239,30,167,62,189,255,12,198,111,26,252,108,207,227,48,166,205,210,175,155,62,108,208,252,212,36,148,219,184,190,105,192,45,135,189,253,132,172,98,136,224,55,102,220,44,21,25,151,86,25,242,42,93,77,110,136,11,76,9,0,73,181,116,129,10,135,112,42,145,59,10,22,10,201,130,171,88,153,111,53,3,237,43,11,180,84,22,55,49,236,125,147,51,78,43,27,108,105,84,110,109,40,183,198,139,42,247,82,211,92,46,13,239,53,54,124,33,20,245,94,11,165,192,242,74,243,27,130,48,254,181,197,235,139,241,227,207,238,116,143,87,242,183,91,92,125,181,176,107,160,197,35,194,19,126,3,147,3,6,92,157,82,213,243,91,8,45,33,187,46,197,244,188,222,231,122,126,11,178,195,237,2,237,246,128,239,47,10,149,52,23,245,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: DistributionLeadPageFlowElement

		/// <exclude/>
		public class DistributionLeadPageFlowElement : PreconfiguredPageUserTask
		{

			#region Constructors: Public

			public DistributionLeadPageFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "DistributionLeadPage";
				IsLogging = true;
				SchemaElementUId = new Guid("3e566048-ef49-45bf-9d2d-500669220b4e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadDistribution;
				SerializeToDB = true;
				_showExecutionPage = () => (bool)((process.ShowDistributionPage));
				_leadId = () => (Guid)((process.LeadId));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _title;
			public override LocalizableString Title {
				get {
					return _title ?? (_title = GetLocalizableString("d6c59cedf94c477daef17418c7544cfe",
						 "BaseElements.DistributionLeadPage.Parameters.Title.Value"));
				}
				set {
					_title = value;
				}
			}

			private Guid _clientUnitSchemaUId = new Guid("65a13f26-c1c8-49e6-9744-ce1c028164df");
			public override Guid ClientUnitSchemaUId {
				get {
					return _clientUnitSchemaUId;
				}
				set {
					_clientUnitSchemaUId = value;
				}
			}

			private bool _useCardProcessModule = true;
			public override bool UseCardProcessModule {
				get {
					return _useCardProcessModule;
				}
				set {
					_useCardProcessModule = value;
				}
			}

			internal Func<bool> _showExecutionPage;
			public override bool ShowExecutionPage {
				get {
					return (_showExecutionPage ?? (_showExecutionPage = () => false)).Invoke();
				}
				set {
					_showExecutionPage = () => { return value; };
				}
			}

			internal Func<Guid> _leadId;
			public  virtual Guid LeadId {
				get {
					return (_leadId ?? (_leadId = () => Guid.Empty)).Invoke();
				}
				set {
					_leadId = () => { return value; };
				}
			}

			public  virtual string Result {
				get;
				set;
			}

			public  virtual bool RemindToOwner {
				get;
				set;
			}

			public  virtual Guid LeadOwnerId {
				get;
				set;
			}

			public  virtual Guid OpportunityDepartment {
				get;
				set;
			}

			#endregion

		}

		#endregion

		#region Class: SaveLeadByDefaultFlowElement

		/// <exclude/>
		public class SaveLeadByDefaultFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public SaveLeadByDefaultFlowElement(UserConnection userConnection, LeadManagementDistribution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SaveLeadByDefault";
				IsLogging = true;
				SchemaElementUId = new Guid("6621ece7-a75a-4921-a234-3d2fa74faf4c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Owner = () => (Guid)((process.ResponsibleId));
				_recordColumnValues_RemindToOwner = () => (bool)((process.CreateReminder));
				_recordColumnValues_SalesOwner = () => (Guid)((process.DistributionLeadPage.OwnerId));
				_recordColumnValues_OpportunityDepartment = () => (Guid)((process.DistributionLeadPage.OpportunityDepartment));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private  Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Owner", () => _recordColumnValues_Owner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_RemindToOwner", () => _recordColumnValues_RemindToOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_SalesOwner", () => _recordColumnValues_SalesOwner.Invoke());
						_getColumnValueFunctions.Add("_recordColumnValues_OpportunityDepartment", () => _recordColumnValues_OpportunityDepartment.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Owner;
			internal Func<bool> _recordColumnValues_RemindToOwner;
			internal Func<Guid> _recordColumnValues_SalesOwner;
			internal Func<Guid> _recordColumnValues_OpportunityDepartment;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private bool _isMatchConditions = true;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,197,178,100,75,114,143,203,182,44,148,52,208,180,20,146,37,140,165,81,86,224,63,27,75,166,9,102,191,123,181,118,54,133,28,74,233,173,224,195,104,236,247,230,55,15,121,190,247,225,163,111,35,142,181,131,54,96,54,237,108,77,132,211,166,41,154,134,10,107,56,21,96,129,170,162,212,84,200,28,65,241,178,105,242,130,100,61,116,88,147,85,189,181,62,146,204,71,236,66,125,59,255,54,141,227,132,217,189,91,14,95,205,1,59,248,182,12,96,224,148,70,77,101,153,167,41,152,70,41,3,134,58,199,117,83,9,37,24,26,178,178,96,195,36,56,224,20,25,43,18,139,49,180,1,89,80,205,19,5,151,92,88,157,88,90,116,113,251,116,28,49,4,63,244,245,140,175,245,205,243,49,81,174,179,55,67,59,117,61,201,58,140,112,13,241,80,19,192,28,69,105,128,26,161,75,42,28,74,10,92,91,202,161,145,133,84,200,42,38,73,102,224,24,207,182,100,103,73,102,33,194,119,104,39,92,156,103,159,24,11,158,51,85,86,73,203,184,161,130,23,57,85,149,146,212,217,202,105,228,149,214,141,189,228,245,105,242,169,246,225,106,234,112,244,230,37,118,76,249,13,99,61,155,161,143,227,208,158,173,175,150,207,111,240,41,174,225,190,188,250,177,46,20,83,255,44,34,167,108,10,184,105,61,246,113,219,155,193,250,254,97,245,60,157,146,164,59,194,232,195,37,133,237,227,4,45,201,70,255,112,248,99,90,155,41,196,161,251,143,86,205,210,154,201,35,93,178,5,247,124,7,173,15,199,22,158,151,115,77,222,61,78,67,252,240,25,193,174,21,121,163,168,201,29,225,185,113,149,22,156,130,82,140,10,195,115,10,185,82,233,82,86,101,41,11,20,133,96,119,36,81,252,131,247,237,46,124,249,217,95,254,129,149,122,255,62,117,223,52,174,47,202,122,254,27,156,211,254,12,180,63,165,231,23,66,164,233,35,202,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,75,111,220,70,12,254,43,11,37,71,211,152,247,99,175,73,15,6,146,214,168,211,92,108,31,56,51,100,179,192,62,12,73,78,145,46,246,191,151,43,175,99,59,109,156,32,151,184,72,4,65,90,205,204,71,114,72,126,228,236,182,123,62,126,184,162,110,222,189,161,190,199,97,195,227,241,139,77,79,199,167,253,166,210,48,28,191,218,84,92,46,254,198,178,164,83,236,113,69,35,245,111,113,121,77,195,171,197,48,30,205,30,194,186,163,238,249,251,105,182,155,159,111,187,147,145,86,127,156,52,145,222,154,109,149,21,2,102,74,224,124,97,192,234,34,216,152,141,105,172,201,55,39,224,186,89,94,175,214,175,105,196,83,28,223,117,243,109,55,73,19,1,222,36,29,173,19,108,85,26,156,210,30,48,134,0,181,104,85,99,241,222,213,212,237,142,186,161,190,163,21,78,74,239,192,78,35,167,76,25,162,87,5,28,149,2,169,98,5,102,155,75,112,201,105,170,123,240,97,253,29,240,252,217,249,201,240,219,95,107,234,207,38,185,115,198,229,64,151,199,50,250,201,192,71,231,204,183,49,22,174,222,105,208,168,17,92,241,4,165,69,217,43,57,147,171,43,193,70,222,93,62,187,220,107,108,139,225,106,137,31,222,254,91,241,164,245,102,209,213,3,199,223,95,182,189,184,137,223,69,55,191,248,92,4,15,239,27,123,31,198,240,211,240,93,116,71,23,221,217,230,186,175,123,137,118,255,113,235,206,73,131,58,92,240,31,143,219,235,70,198,4,123,141,107,252,147,250,95,69,227,4,159,166,94,226,136,147,242,55,98,247,173,224,98,178,87,81,51,68,194,44,1,10,6,82,19,231,101,157,11,219,104,13,179,153,208,191,19,83,79,235,74,15,13,211,161,144,13,94,67,98,50,224,180,207,130,111,10,48,41,219,92,72,86,242,111,194,79,154,239,140,185,205,52,25,89,95,47,151,147,130,97,218,255,62,117,15,134,31,102,94,222,11,213,61,9,155,182,224,5,181,147,245,183,184,106,215,237,118,71,247,121,82,92,210,186,133,8,190,16,129,51,206,67,246,28,197,37,202,41,231,124,51,190,60,202,19,19,51,147,37,5,49,87,5,142,147,130,130,138,129,125,104,44,226,216,229,250,68,120,146,107,179,156,130,5,69,77,120,98,109,130,148,133,44,57,114,50,216,152,156,10,95,230,201,139,158,112,164,89,79,171,197,186,81,63,227,77,63,219,252,72,220,201,170,4,169,167,9,20,115,149,220,151,194,147,98,204,96,156,81,242,3,57,171,248,24,119,190,218,176,167,206,29,85,156,41,53,52,104,166,72,234,83,150,30,99,164,136,88,149,48,58,173,80,238,199,123,76,85,140,49,7,40,42,89,241,164,9,210,164,132,13,149,91,171,198,123,155,81,125,79,238,252,178,164,21,173,199,249,214,146,15,65,73,51,36,161,243,77,55,205,205,52,240,74,133,32,13,85,60,65,187,135,100,243,201,86,133,177,65,166,38,16,49,105,42,174,192,37,84,68,102,109,184,125,153,108,18,199,177,95,148,235,113,177,89,207,174,36,65,143,127,182,169,31,177,77,73,105,209,217,165,42,199,47,150,141,20,220,83,173,122,48,213,24,100,225,91,50,254,81,170,161,83,24,28,203,121,80,145,212,126,69,146,142,46,10,223,124,174,186,113,41,217,242,255,149,106,201,152,40,103,83,2,10,81,202,136,212,29,64,203,22,140,86,134,216,75,106,68,252,22,170,157,225,146,134,89,91,188,95,12,50,246,147,115,95,199,57,223,146,243,161,56,208,94,78,69,174,145,151,242,46,15,100,249,231,192,33,102,169,250,79,149,115,151,187,127,0,78,23,15,135,160,13,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "d6c59cedf94c477daef17418c7544cfe",
							"BaseElements.SaveLeadByDefault.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordColumnValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordColumnValues", getColumnValue);
					}
					return _recordColumnValues;
				}
				set {
					_recordColumnValues = value;
				}
			}

			#endregion

		}

		#endregion

		public LeadManagementDistribution(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementDistribution";
			SchemaUId = new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			_createReminder = () => { return (bool)((DistributionLeadPage.RemindToOwner)); };
			_responsibleId = () => { return (Guid)((DistributionLeadPage.LeadOwnerId)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("d6c59ced-f94c-477d-aef1-7418c7544cfe");
			}
		}

		#endregion

		#region Properties: Public

		public  virtual Guid LeadId {
			get;
			set;
		}

		private Func<bool> _createReminder;
		public  virtual bool CreateReminder {
			get {
				return (_createReminder ?? (_createReminder = () => false)).Invoke();
			}
			set {
				_createReminder = () => { return value; };
			}
		}

		private Func<Guid> _responsibleId;
		public  virtual Guid ResponsibleId {
			get {
				return (_responsibleId ?? (_responsibleId = () => Guid.Empty)).Invoke();
			}
			set {
				_responsibleId = () => { return value; };
			}
		}

		public  virtual bool ShowDistributionPage {
			get;
			set;
		}

		private ProcessLeadDistribution _leadDistribution;
		public  ProcessLeadDistribution LeadDistribution {
			get {
				return _leadDistribution ?? ((_leadDistribution) = new ProcessLeadDistribution(UserConnection, this));
			}
		}

		private ProcessFlowElement _start;
		public  ProcessFlowElement Start {
			get {
				return _start ?? (_start = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start",
					SchemaElementUId = new Guid("7a92b7ab-7ed4-4582-8e65-9e766afb2829"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateHandoff;
		public  ProcessTerminateEvent TerminateHandoff {
			get {
				return _terminateHandoff ?? (_terminateHandoff = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateHandoff",
					SchemaElementUId = new Guid("e0fc6ab2-437d-4492-a531-191b3013d93d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayIsLeadSet;
		public  ProcessExclusiveGateway ExclusiveGatewayIsLeadSet {
			get {
				return _exclusiveGatewayIsLeadSet ?? (_exclusiveGatewayIsLeadSet = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayIsLeadSet",
					SchemaElementUId = new Guid("0788b001-b01e-467d-8078-6e3f56e8a438"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayIsLeadSet.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateLeadIsNotSet;
		public  ProcessTerminateEvent TerminateLeadIsNotSet {
			get {
				return _terminateLeadIsNotSet ?? (_terminateLeadIsNotSet = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateLeadIsNotSet",
					SchemaElementUId = new Guid("28c1efc4-e3b9-4c23-8307-4e19e53453b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private SaveLeadHandoffFlowElement _saveLeadHandoff;
		public  SaveLeadHandoffFlowElement SaveLeadHandoff {
			get {
				return _saveLeadHandoff ?? (_saveLeadHandoff = new SaveLeadHandoffFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private SaveLeadNoInterestFlowElement _saveLeadNoInterest;
		public  SaveLeadNoInterestFlowElement SaveLeadNoInterest {
			get {
				return _saveLeadNoInterest ?? (_saveLeadNoInterest = new SaveLeadNoInterestFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminateNoInterest;
		public  ProcessTerminateEvent TerminateNoInterest {
			get {
				return _terminateNoInterest ?? (_terminateNoInterest = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateNoInterest",
					SchemaElementUId = new Guid("721db265-d834-462e-bd2d-515b03c3eaf9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateContinueDistribution;
		public  ProcessTerminateEvent TerminateContinueDistribution {
			get {
				return _terminateContinueDistribution ?? (_terminateContinueDistribution = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateContinueDistribution",
					SchemaElementUId = new Guid("cb6102fb-8548-4fa4-aae5-b307af30608f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private AddReminderFlowElement _addReminder;
		public  AddReminderFlowElement AddReminder {
			get {
				return _addReminder ?? (_addReminder = new AddReminderFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadDataFlowElement _readLeadData;
		public  ReadLeadDataFlowElement ReadLeadData {
			get {
				return _readLeadData ?? (_readLeadData = new ReadLeadDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadTypeFlowElement _readLeadType;
		public  ReadLeadTypeFlowElement ReadLeadType {
			get {
				return _readLeadType ?? (_readLeadType = new ReadLeadTypeFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadLeadContactFlowElement _readLeadContact;
		public  ReadLeadContactFlowElement ReadLeadContact {
			get {
				return _readLeadContact ?? (_readLeadContact = new ReadLeadContactFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public  ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("68552fe0-b6b1-47de-9bdd-6c06dbdf6839"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private DistributionLeadPageFlowElement _distributionLeadPage;
		public  DistributionLeadPageFlowElement DistributionLeadPage {
			get {
				return _distributionLeadPage ?? (_distributionLeadPage = new DistributionLeadPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public  ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("fe8039af-a364-42b4-bf9d-dbe3a1991c15"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private SaveLeadByDefaultFlowElement _saveLeadByDefault;
		public  SaveLeadByDefaultFlowElement SaveLeadByDefault {
			get {
				return _saveLeadByDefault ?? (_saveLeadByDefault = new SaveLeadByDefaultFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalFlowLeadUndefined;
		public  ProcessConditionalFlow ConditionalFlowLeadUndefined {
			get {
				return _conditionalFlowLeadUndefined ?? (_conditionalFlowLeadUndefined = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowLeadUndefined",
					SchemaElementUId = new Guid("5805d2d7-5516-4f97-9107-0c6b5c4bbc5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowCreateReminder;
		public  ProcessConditionalFlow ConditionalFlowCreateReminder {
			get {
				return _conditionalFlowCreateReminder ?? (_conditionalFlowCreateReminder = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowCreateReminder",
					SchemaElementUId = new Guid("97e8e894-d220-43dc-9cfa-0e37f8166e2a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public  ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("f5da7633-709e-40ac-ab2f-51d79b4f1e75"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public  ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("15c1b993-b41b-4b3d-be24-96f8a835c457"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start.SchemaElementUId] = new Collection<ProcessFlowElement> { Start };
			FlowElements[TerminateHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateHandoff };
			FlowElements[ExclusiveGatewayIsLeadSet.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayIsLeadSet };
			FlowElements[TerminateLeadIsNotSet.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateLeadIsNotSet };
			FlowElements[SaveLeadHandoff.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLeadHandoff };
			FlowElements[SaveLeadNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLeadNoInterest };
			FlowElements[TerminateNoInterest.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateNoInterest };
			FlowElements[TerminateContinueDistribution.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateContinueDistribution };
			FlowElements[AddReminder.SchemaElementUId] = new Collection<ProcessFlowElement> { AddReminder };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ReadLeadType.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadType };
			FlowElements[ReadLeadContact.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadContact };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[DistributionLeadPage.SchemaElementUId] = new Collection<ProcessFlowElement> { DistributionLeadPage };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[SaveLeadByDefault.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveLeadByDefault };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayIsLeadSet", e.Context.SenderName));
						break;
					case "TerminateHandoff":
						CompleteProcess();
						break;
					case "ExclusiveGatewayIsLeadSet":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateLeadIsNotSet", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("DistributionLeadPage", e.Context.SenderName));
						break;
					case "TerminateLeadIsNotSet":
						CompleteProcess();
						break;
					case "SaveLeadHandoff":
						if (ConditionalFlowCreateReminderExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "SaveLeadNoInterest":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateNoInterest", e.Context.SenderName));
						break;
					case "TerminateNoInterest":
						CompleteProcess();
						break;
					case "TerminateContinueDistribution":
						CompleteProcess();
						break;
					case "AddReminder":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ReadLeadData":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadContact", e.Context.SenderName));
						break;
					case "ReadLeadType":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddReminder", e.Context.SenderName));
						break;
					case "ReadLeadContact":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadType", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateHandoff", e.Context.SenderName));
						break;
					case "DistributionLeadPage":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveLeadHandoff", e.Context.SenderName));
							break;
						}
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveLeadNoInterest", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SaveLeadByDefault", e.Context.SenderName));
						break;
					case "SaveLeadByDefault":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateContinueDistribution", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			return Convert.ToBoolean((LeadId) == Guid.Empty);
		}

		private bool ConditionalFlowCreateReminderExpressionExecute() {
			return Convert.ToBoolean((CreateReminder));
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean((DistributionLeadPage.Result) == "TransferToSale");
		}

		private bool ConditionalFlow3ExpressionExecute() {
			return Convert.ToBoolean((DistributionLeadPage.Result) == "NotInteresting");
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("DistributionLeadPage.LeadId")) {
				writer.WriteValue("DistributionLeadPage.LeadId", DistributionLeadPage.LeadId, Guid.Empty);
			}
			if (!HasMapping("DistributionLeadPage.Result")) {
				writer.WriteValue("DistributionLeadPage.Result", DistributionLeadPage.Result, null);
			}
			if (!HasMapping("DistributionLeadPage.RemindToOwner")) {
				writer.WriteValue("DistributionLeadPage.RemindToOwner", DistributionLeadPage.RemindToOwner, false);
			}
			if (!HasMapping("DistributionLeadPage.LeadOwnerId")) {
				writer.WriteValue("DistributionLeadPage.LeadOwnerId", DistributionLeadPage.LeadOwnerId, Guid.Empty);
			}
			if (!HasMapping("DistributionLeadPage.OpportunityDepartment")) {
				writer.WriteValue("DistributionLeadPage.OpportunityDepartment", DistributionLeadPage.OpportunityDepartment, Guid.Empty);
			}
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("ShowDistributionPage")) {
				writer.WriteValue("ShowDistributionPage", ShowDistributionPage, false);
			}
			if (!HasMapping("CreateReminder")) {
				writer.WriteValue("CreateReminder", CreateReminder, false);
			}
			if (!HasMapping("ResponsibleId")) {
				writer.WriteValue("ResponsibleId", ResponsibleId, Guid.Empty);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start", string.Empty));
		}

		protected override void CompleteApplyingFlowElementsPropertiesData() {
			base.CompleteApplyingFlowElementsPropertiesData();
			foreach (var item in FlowElements) {
				foreach (var itemValue in item.Value) {
					if (Guid.Equals(itemValue.CreatedInSchemaUId, InternalSchemaUId)) {
						itemValue.ExecutedEventHandler = OnExecuted;
					}
				}
			}
		}

		protected override void InitializeMetaPathParameterValues() {
			base.InitializeMetaPathParameterValues();
			MetaPathParameterValues.Add("30cf6943-a881-4c30-a088-ff65572e4241", () => LeadId);
			MetaPathParameterValues.Add("9cd3f863-0eda-4338-895e-97f82adfe406", () => CreateReminder);
			MetaPathParameterValues.Add("77bfc541-1a1a-4b5e-bd77-3e429c4b637f", () => ResponsibleId);
			MetaPathParameterValues.Add("51139bfa-4db4-45f7-aa2f-590d604f8469", () => ShowDistributionPage);
			MetaPathParameterValues.Add("188fdd38-de95-4c10-8ab3-34128e7e82c9", () => SaveLeadHandoff.EntitySchemaUId);
			MetaPathParameterValues.Add("9cad839f-9e67-4603-a369-f4c25fce8216", () => SaveLeadHandoff.IsMatchConditions);
			MetaPathParameterValues.Add("51b908e1-277f-4fd9-954b-c200b506502f", () => SaveLeadHandoff.DataSourceFilters);
			MetaPathParameterValues.Add("e91b04af-7a52-4f54-a02b-32ac50a9f8ad", () => SaveLeadHandoff.RecordColumnValues);
			MetaPathParameterValues.Add("a147d2f0-eb4f-4a91-bda3-6b4d5423014b", () => SaveLeadNoInterest.EntitySchemaUId);
			MetaPathParameterValues.Add("d71bf98b-10c9-4b4e-9da3-927f4c707df2", () => SaveLeadNoInterest.IsMatchConditions);
			MetaPathParameterValues.Add("8b04704d-b57f-4aed-8143-0ba2dc774953", () => SaveLeadNoInterest.DataSourceFilters);
			MetaPathParameterValues.Add("63cb5219-81b3-4e2c-8f12-bb56e164296d", () => SaveLeadNoInterest.RecordColumnValues);
			MetaPathParameterValues.Add("55dd5f60-cee9-44b6-8f68-b543a4174bf2", () => AddReminder.EntitySchemaId);
			MetaPathParameterValues.Add("7a3aa063-9af4-482e-adbf-9312dad8b0bf", () => AddReminder.DataSourceFilters);
			MetaPathParameterValues.Add("2e6f433c-09c2-46dc-89d2-80e6a8f6ebda", () => AddReminder.RecordAddMode);
			MetaPathParameterValues.Add("ddff7e72-873c-4e34-a274-b1fe98dc4dc5", () => AddReminder.FilterEntitySchemaId);
			MetaPathParameterValues.Add("95dfe792-7d3e-4db6-8add-2effff3ca7f4", () => AddReminder.RecordDefValues);
			MetaPathParameterValues.Add("2af26cad-fdd2-4138-9712-bb3c00009344", () => AddReminder.RecordId);
			MetaPathParameterValues.Add("88b815f6-9ed2-474a-a40e-f96b169054b4", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("7c774b4b-6e9a-4ef1-bd4d-4af18e1f5a68", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("4a5fff69-b63a-49e0-a7c9-da42ff12623b", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("1b730802-2250-4ca2-84c5-b50b5d4a07fb", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("be3ad5ec-1ac1-4d88-8421-74079d80259b", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("19076150-3efa-4513-be4e-b624b7233322", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("9adb2ee5-70ec-4c6c-b1ab-4cb1ddf4c59b", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("81e8d9be-76bf-41e2-a013-9bfb7a60bbf7", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("0a4b4eb8-5619-4c19-a817-49e7435ddac0", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("18ee65b6-9004-44b1-b810-660c4b69eb54", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("2ba36ea2-087d-4183-8f2e-029d86d94b6b", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("39c22bae-af9c-474a-8c12-e087a1cc5bcc", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("befd9ddf-c017-4e87-bf55-98e25f140075", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("2fd8069c-26a9-41c0-9022-20c047525340", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("b92dc5ab-c714-451b-b938-04990fc76593", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("904a1de6-b8cd-43d7-a193-0a8234806d6f", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("addb84e6-59ea-4d30-acaf-3f26b8c94365", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("ca3d3049-0f26-41a3-bca2-dd669a7d3396", () => ReadLeadType.DataSourceFilters);
			MetaPathParameterValues.Add("9bb7fdf0-23d9-4a53-9bfc-b65d5b2b58ef", () => ReadLeadType.ResultType);
			MetaPathParameterValues.Add("1fc1bf95-66f6-437e-ae96-ab0226deef9f", () => ReadLeadType.ReadSomeTopRecords);
			MetaPathParameterValues.Add("b6eaed28-95a3-4e02-bc92-584da91d9666", () => ReadLeadType.NumberOfRecords);
			MetaPathParameterValues.Add("8af81470-64e6-4c25-bc4e-996386dd37c1", () => ReadLeadType.FunctionType);
			MetaPathParameterValues.Add("876c91d3-f5fd-430b-99a7-6da066af2251", () => ReadLeadType.AggregationColumnName);
			MetaPathParameterValues.Add("a511d00e-3b57-438c-ad43-a0b965ac41ff", () => ReadLeadType.OrderInfo);
			MetaPathParameterValues.Add("d5067126-b12c-401d-83cc-53d80a232257", () => ReadLeadType.ResultEntity);
			MetaPathParameterValues.Add("c25ddf34-5ec7-43ef-9f1b-1f022d5afa06", () => ReadLeadType.ResultCount);
			MetaPathParameterValues.Add("39e87f5c-2965-45a4-8ce7-4446e1173001", () => ReadLeadType.ResultIntegerFunction);
			MetaPathParameterValues.Add("3aec9151-bb18-4f05-9f98-6ef24b8eb8fa", () => ReadLeadType.ResultFloatFunction);
			MetaPathParameterValues.Add("8319a4e6-2ecb-470d-b2fd-9af8514e9ab2", () => ReadLeadType.ResultDateTimeFunction);
			MetaPathParameterValues.Add("0e55a545-db7b-429c-8850-c3c910df6b27", () => ReadLeadType.ResultRowsCount);
			MetaPathParameterValues.Add("d246ad4e-36de-4230-bc79-a36f43b1befe", () => ReadLeadType.CanReadUncommitedData);
			MetaPathParameterValues.Add("7ad11547-1b9b-4507-b7ff-0d224aa61262", () => ReadLeadType.ResultEntityCollection);
			MetaPathParameterValues.Add("5bfef119-7795-4c1c-8d01-0d38138f2a41", () => ReadLeadType.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("3e1d582a-dce9-475f-9eed-bc65b2d11830", () => ReadLeadType.IgnoreDisplayValues);
			MetaPathParameterValues.Add("fe828bdd-0b5b-4b21-8d0d-7fe8bbb6c978", () => ReadLeadContact.DataSourceFilters);
			MetaPathParameterValues.Add("b4af7ceb-60b9-467c-a8b3-81953d377341", () => ReadLeadContact.ResultType);
			MetaPathParameterValues.Add("311fcede-bca4-4fec-9a42-0f943fe03159", () => ReadLeadContact.ReadSomeTopRecords);
			MetaPathParameterValues.Add("4f32f247-07f2-471b-ba49-b42cae200cf0", () => ReadLeadContact.NumberOfRecords);
			MetaPathParameterValues.Add("d72c0941-da6e-42f6-b7a5-0b3ffe8b2c2e", () => ReadLeadContact.FunctionType);
			MetaPathParameterValues.Add("3356dca2-6b01-46e0-9fe2-d0de44ff97b0", () => ReadLeadContact.AggregationColumnName);
			MetaPathParameterValues.Add("d550d767-aeda-4cf2-9b2a-90c7c38be81b", () => ReadLeadContact.OrderInfo);
			MetaPathParameterValues.Add("fff72291-b74e-4830-8333-56ad140e6e7c", () => ReadLeadContact.ResultEntity);
			MetaPathParameterValues.Add("05f02083-70af-4052-8ee7-2b228747244c", () => ReadLeadContact.ResultCount);
			MetaPathParameterValues.Add("123bb774-23e8-4cbe-a707-c0bf2149c012", () => ReadLeadContact.ResultIntegerFunction);
			MetaPathParameterValues.Add("a43adf8a-3d3f-4d55-bbb1-030b98ca7464", () => ReadLeadContact.ResultFloatFunction);
			MetaPathParameterValues.Add("2a298fa9-f151-46ad-b486-c3c3bcb89af4", () => ReadLeadContact.ResultDateTimeFunction);
			MetaPathParameterValues.Add("51b3ba73-2cd0-43a5-b1bb-d655502ea451", () => ReadLeadContact.ResultRowsCount);
			MetaPathParameterValues.Add("bd94e2da-67c7-4c33-985e-1f6fdecc4562", () => ReadLeadContact.CanReadUncommitedData);
			MetaPathParameterValues.Add("53665a2a-42d9-47f3-8bf4-e4ebbd2e10f3", () => ReadLeadContact.ResultEntityCollection);
			MetaPathParameterValues.Add("f382eb7c-1c7a-4c11-93b3-5b6271585801", () => ReadLeadContact.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("377fdd7e-2835-4e98-a892-93bd77cfe77f", () => ReadLeadContact.IgnoreDisplayValues);
			MetaPathParameterValues.Add("bbe769c2-34d8-4a8b-a580-a9e4311e6053", () => DistributionLeadPage.Title);
			MetaPathParameterValues.Add("5160bb63-99ee-4be0-ad4e-f804a2c25915", () => DistributionLeadPage.Recommendation);
			MetaPathParameterValues.Add("2021bd48-f45e-4cd3-b993-7b97a0c3308d", () => DistributionLeadPage.ClientUnitSchemaUId);
			MetaPathParameterValues.Add("1905b493-d577-4148-a465-5b25ff5f0ab4", () => DistributionLeadPage.EntityId);
			MetaPathParameterValues.Add("702a610c-eae3-442a-b9e5-1eae1657abca", () => DistributionLeadPage.EntryPointId);
			MetaPathParameterValues.Add("ab6017ca-8f69-4ec1-95d6-57eb04cec232", () => DistributionLeadPage.EntitySchemaUId);
			MetaPathParameterValues.Add("1babcc34-fbcc-4e3e-84fe-432c05fdbbe5", () => DistributionLeadPage.UseCardProcessModule);
			MetaPathParameterValues.Add("583c0a7d-9ed9-49b6-919b-fb6caaff12fd", () => DistributionLeadPage.OwnerId);
			MetaPathParameterValues.Add("3aeda084-6af5-44ea-8738-d38edc340131", () => DistributionLeadPage.ShowExecutionPage);
			MetaPathParameterValues.Add("63033799-a11b-4b1e-9c2b-6e17977e2c43", () => DistributionLeadPage.InformationOnStep);
			MetaPathParameterValues.Add("809907b4-6caf-4cda-8cd8-58f9c1196633", () => DistributionLeadPage.IsRunning);
			MetaPathParameterValues.Add("345b747f-6492-4686-a503-0062acd716e0", () => DistributionLeadPage.LeadId);
			MetaPathParameterValues.Add("a9e78508-ae1b-4141-abe0-24ed11eadb13", () => DistributionLeadPage.Result);
			MetaPathParameterValues.Add("cd5eefc4-6c19-4719-be10-6babbc9acc6e", () => DistributionLeadPage.RemindToOwner);
			MetaPathParameterValues.Add("0d01d7bb-ccf9-4184-a64f-953b68988ea4", () => DistributionLeadPage.LeadOwnerId);
			MetaPathParameterValues.Add("8227a76e-e673-40a1-a3f3-2102ef5efe7a", () => DistributionLeadPage.OpportunityDepartment);
			MetaPathParameterValues.Add("560bc47f-ebc5-4687-aa0c-08705e061a9a", () => SaveLeadByDefault.EntitySchemaUId);
			MetaPathParameterValues.Add("c4e20e54-2a71-4e75-a167-24858aec6fcb", () => SaveLeadByDefault.IsMatchConditions);
			MetaPathParameterValues.Add("ba1c792f-b05d-43b6-b1d4-1f6f092ae9d7", () => SaveLeadByDefault.DataSourceFilters);
			MetaPathParameterValues.Add("f3fd0d58-28e8-457f-8737-49c12cc4cc1d", () => SaveLeadByDefault.RecordColumnValues);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "DistributionLeadPage.LeadId":
					DistributionLeadPage.LeadId = reader.GetValue<System.Guid>();
				break;
				case "DistributionLeadPage.Result":
					DistributionLeadPage.Result = reader.GetValue<System.String>();
				break;
				case "DistributionLeadPage.RemindToOwner":
					DistributionLeadPage.RemindToOwner = reader.GetValue<System.Boolean>();
				break;
				case "DistributionLeadPage.LeadOwnerId":
					DistributionLeadPage.LeadOwnerId = reader.GetValue<System.Guid>();
				break;
				case "DistributionLeadPage.OpportunityDepartment":
					DistributionLeadPage.OpportunityDepartment = reader.GetValue<System.Guid>();
				break;
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "ShowDistributionPage":
					if (!hasValueToRead) break;
					ShowDistributionPage = reader.GetValue<System.Boolean>();
				break;
				case "CreateReminder":
					if (!hasValueToRead) break;
					CreateReminder = reader.GetValue<System.Boolean>();
				break;
				case "ResponsibleId":
					if (!hasValueToRead) break;
					ResponsibleId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			if (Status == Core.Process.ProcessStatus.Inactive) {
				return;
			}
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer, writeFlowElements);
			WritePropertyValues(writer, false);
			writer.WriteFinishObject();
		}

		public override object CloneShallow() {
			var cloneItem = (LeadManagementDistribution)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

