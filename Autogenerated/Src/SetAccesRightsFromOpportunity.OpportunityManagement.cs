namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SetAccesRightsFromOpportunitySchema

	/// <exclude/>
	public class SetAccesRightsFromOpportunitySchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SetAccesRightsFromOpportunitySchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SetAccesRightsFromOpportunitySchema(SetAccesRightsFromOpportunitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SetAccesRightsFromOpportunity";
			UId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8");
			CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.8.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"OpportunityManagement780";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8");
			Version = 0;
			PackageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
		}

		protected virtual ProcessSchemaParameter CreateIsOpportunityRightsUsedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c65ea67b-3e99-4cc4-8eb7-f4e8c2284d24"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"IsOpportunityRightsUsed",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsOpportunityRightsUsedParameter());
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("549ebb17-cecf-41c6-bd95-ffae2344b3bf"),
				ContainerUId = new Guid("4b903a19-32b6-4c1a-9e26-56a2ff989412"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4b903a19-32b6-4c1a-9e26-56a2ff989412"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"RecordId",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2f1a80d7-bbd4-46fe-9c6f-d58535e65e26"),
				ContainerUId = new Guid("4b903a19-32b6-4c1a-9e26-56a2ff989412"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4b903a19-32b6-4c1a-9e26-56a2ff989412"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"EntitySchemaUId",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4c8af6fd-bd7f-48bc-a01a-bb1b4c2dadaa"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,187,110,219,48,20,253,149,64,115,104,136,18,165,136,222,138,212,45,178,212,65,19,100,169,51,92,82,151,54,81,73,20,72,58,173,107,248,223,75,74,142,243,128,139,184,93,178,84,139,200,131,195,195,115,95,220,38,178,1,231,190,64,139,201,52,185,69,107,193,25,229,39,159,116,227,209,126,182,102,221,39,231,137,67,171,161,209,191,176,30,241,89,173,253,71,240,16,142,108,23,79,10,139,100,186,56,174,177,72,206,23,137,246,216,186,192,9,71,56,173,74,168,32,35,136,178,38,44,207,129,84,41,47,73,90,209,82,21,170,82,92,200,145,249,39,241,75,211,246,96,113,188,99,144,87,195,242,118,211,71,42,13,128,28,40,218,153,110,15,230,209,132,155,117,32,26,172,195,222,219,53,6,200,91,221,134,104,240,86,183,120,13,54,220,21,117,76,132,2,73,65,227,34,171,65,229,103,63,123,139,206,105,211,189,101,174,89,183,221,115,118,16,192,195,118,111,39,29,60,70,230,53,248,213,32,113,21,108,237,6,151,31,150,75,139,75,240,250,225,185,137,239,184,25,120,167,229,47,28,168,67,149,238,160,89,227,179,59,95,70,114,9,189,31,3,26,175,15,4,171,151,171,147,99,61,100,236,173,112,179,0,246,143,228,19,53,143,198,144,149,1,124,136,192,168,242,184,92,36,223,174,220,252,71,135,246,70,174,176,133,49,107,247,147,128,190,2,102,13,182,216,249,233,150,9,158,230,64,57,201,51,81,18,38,41,16,142,89,73,138,18,50,165,120,197,25,205,118,225,192,193,208,116,91,48,142,66,208,11,34,81,42,194,168,44,137,168,121,65,148,2,204,114,198,68,46,212,238,126,52,174,93,223,192,230,238,224,239,114,5,221,18,207,76,223,27,235,215,157,246,155,51,19,253,78,190,162,52,182,62,219,231,63,254,166,49,110,10,69,80,35,10,210,96,142,213,138,240,186,82,164,22,170,16,172,82,34,227,161,200,187,248,197,170,154,165,150,208,204,123,180,176,47,104,122,188,223,95,12,74,204,165,53,198,143,25,58,212,98,254,100,113,176,244,216,120,50,45,129,23,165,36,180,102,57,97,23,12,137,200,114,78,40,147,153,204,211,144,53,74,131,167,240,102,196,170,221,152,181,149,251,25,117,227,99,241,79,143,192,59,140,246,223,76,235,209,121,57,165,255,255,119,246,59,119,246,46,217,253,6,253,93,180,174,2,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("37f79cc5-72b0-4169-9601-bac57ad16d46"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("784185aa-491d-4ae1-9637-4ec1b6e33600"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("695907f5-c228-44c5-a407-2a548e51082a"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("aa895d0a-e0c4-4006-a36d-f630c1d4c9f4"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("76c3e926-235d-4333-95c1-8244bbe96d32"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("68f73716-a547-40e1-a01e-14fa3735d69f"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("b2bc1951-86fa-43e8-9538-a1c69388728e"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				Name = @"ResultEntity",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fe2f0849-2ead-4e5d-8c1b-aa1ed5b79d69"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
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
				UId = new Guid("a9ceb484-db0c-420a-9670-69705fc544c3"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
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
				UId = new Guid("fe563ae3-7e4c-415e-b9d7-d6513e08b524"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
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
				UId = new Guid("34ff8192-4a6f-4efa-8e2c-6819a886bb8b"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
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
				UId = new Guid("2e317487-334c-4d63-b8a3-c6c897f3a0e9"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
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
				UId = new Guid("b5daa445-357c-4f8a-b134-65b4d6fead46"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
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
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("405d83bb-77ad-4756-87e3-cf26a433fd44"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d9636297-ae2c-4a5d-abdc-f407e520ccd8"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("397a5c45-e5dd-4750-9d80-8d7c171d1bd4"),
				ContainerUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
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
				UseBackgroundMode = false,
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

		protected virtual void InitializeChangeAdminRightsUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("596999c7-a3ba-4426-bc51-d25ca3faa210"),
				ContainerUId = new Guid("d43b3f2e-dd0a-4c43-afc8-5c6d05699ef1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"EntitySchemaUId",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"25d7c1ab-1de0-4501-b402-02e0e5a72d6e",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("286a9ef3-728b-4e9d-a55f-e79611706c3d"),
				ContainerUId = new Guid("d43b3f2e-dd0a-4c43-afc8-5c6d05699ef1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DataSourceFilters",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,162,79,127,245,84,194,166,228,146,134,126,81,72,66,144,165,81,34,144,237,141,45,211,4,179,255,189,227,117,182,133,28,74,78,133,130,15,210,200,239,204,188,143,52,243,93,24,207,67,76,48,212,222,196,17,178,233,194,213,196,177,130,115,39,36,53,141,179,84,25,197,104,197,28,167,178,144,224,76,85,54,140,11,146,117,166,133,154,172,234,157,11,137,100,33,65,59,214,215,243,159,164,105,152,32,187,243,199,205,23,251,0,173,249,182,20,16,218,21,150,155,134,114,7,140,42,205,56,109,20,19,148,9,96,160,77,33,92,14,100,237,197,91,14,38,183,57,181,133,104,168,146,156,209,210,90,77,77,37,26,9,133,247,78,120,146,69,240,105,247,180,31,96,28,67,223,213,51,252,94,127,125,222,99,151,107,237,179,62,78,109,71,178,22,146,185,50,233,161,38,6,235,41,109,13,181,170,210,84,121,40,168,145,149,163,210,52,133,40,74,224,57,47,72,102,205,62,45,105,201,133,35,153,51,201,124,55,113,130,99,230,57,44,118,36,227,165,206,81,203,37,242,146,2,123,204,203,130,122,151,251,10,100,94,85,141,59,241,250,56,5,92,135,241,114,106,97,8,246,5,59,32,191,126,168,103,219,119,105,232,227,146,250,242,248,251,87,120,74,43,220,151,163,31,171,161,132,241,69,68,14,217,52,194,89,12,208,165,93,103,123,23,186,251,53,231,225,128,146,118,111,134,48,158,40,236,30,39,19,73,54,132,251,135,191,210,58,155,198,212,183,255,145,213,12,109,98,14,124,100,199,118,151,55,232,194,184,143,230,249,184,175,201,187,199,169,79,239,63,131,113,155,197,212,134,111,207,195,48,166,205,242,98,55,189,223,160,253,41,38,76,184,177,125,140,96,151,235,222,126,176,182,159,186,180,106,201,171,26,53,185,33,202,42,166,74,165,150,55,163,168,170,44,167,165,209,158,130,179,82,9,45,161,81,124,219,136,198,242,74,227,81,238,13,18,131,146,86,90,150,8,208,230,149,44,203,66,148,176,85,77,165,65,122,143,28,181,192,137,3,28,8,102,52,21,86,115,134,113,142,67,113,67,144,192,63,241,117,125,49,126,250,217,157,38,118,101,124,187,197,232,171,192,46,66,139,151,81,207,111,1,113,64,193,213,169,84,61,191,5,203,34,217,117,41,164,231,117,114,177,208,27,56,29,110,23,82,183,7,252,126,1,211,39,239,32,223,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8b6d0f09-9bfd-4995-ab8a-92dc9fea2e6d"),
				ContainerUId = new Guid("d43b3f2e-dd0a-4c43-afc8-5c6d05699ef1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DeleteRights",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			deleteRightsParameter.SourceValue = new ProcessSchemaParameterValue(deleteRightsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6cea097e-5930-4926-a76f-822a3f6d2fa8"),
				ContainerUId = new Guid("d43b3f2e-dd0a-4c43-afc8-5c6d05699ef1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"AddRights",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			addRightsParameter.SourceValue = new ProcessSchemaParameterValue(addRightsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"[{Id:""a8e84fa3-72de-46be-aeb7-82599aa924a6"",CanRead:true,CanEdit:true,CanDelete:false,Source:""3"",Grantee:""Employee"",Name:""[#Read data 1.First item of resulting collection.Owner#]"",Value:""[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4c404844-a394-49c1-8a5f-edc34253eb41}].[Parameter:{b2bc1951-86fa-43e8-9538-a1c69388728e}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]"",OperationRightLevel:""1""}]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var employee1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("a8e84fa3-72de-46be-aeb7-82599aa924a6"),
				ContainerUId = new Guid("d43b3f2e-dd0a-4c43-afc8-5c6d05699ef1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"Employee1",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			employee1Parameter.SourceValue = new ProcessSchemaParameterValue(employee1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4c404844-a394-49c1-8a5f-edc34253eb41}].[Parameter:{b2bc1951-86fa-43e8-9538-a1c69388728e}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(employee1Parameter);
		}

		protected virtual void InitializeChangeAdminRightsUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a7aa851b-3505-4fad-b70e-5a2a4168bf95"),
				ContainerUId = new Guid("2795ebeb-a781-42a6-95c6-eaaaa61f75d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"EntitySchemaUId",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e5545178-2b81-48e3-baa9-526aa54a5ac5"),
				ContainerUId = new Guid("2795ebeb-a781-42a6-95c6-eaaaa61f75d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DataSourceFilters",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,107,220,48,16,253,43,139,15,61,89,139,37,75,182,229,158,74,216,64,160,164,161,95,20,66,8,227,209,40,17,245,199,198,150,105,131,241,127,175,188,222,109,67,14,101,79,133,130,15,150,196,123,243,230,205,147,166,123,55,92,186,218,83,95,90,168,7,138,199,43,83,70,38,7,170,44,102,76,88,97,152,204,176,96,5,129,100,100,50,66,146,88,21,36,163,184,133,134,202,104,69,239,140,243,81,236,60,53,67,121,59,253,33,245,253,72,241,189,61,44,62,225,35,53,240,101,41,0,36,51,91,21,57,195,68,32,147,64,5,3,147,114,6,90,164,104,140,214,18,109,180,106,201,82,99,1,179,138,137,84,10,38,173,214,12,84,166,152,74,179,130,203,10,51,129,65,75,77,214,239,126,238,123,26,6,215,181,229,68,191,255,63,63,239,131,202,181,246,69,87,143,77,27,197,13,121,184,1,255,88,70,178,210,138,82,107,153,53,74,44,66,56,171,18,80,76,160,226,73,216,231,10,242,40,70,216,251,133,54,122,135,216,141,109,232,180,39,75,61,181,72,47,154,18,202,228,200,161,98,220,80,194,164,74,2,151,76,4,75,4,37,20,120,68,112,47,138,13,120,248,10,245,72,7,97,147,11,192,74,104,149,228,220,178,156,64,51,73,153,96,133,225,192,52,215,149,77,243,84,88,43,78,118,191,239,186,239,227,62,88,61,92,143,13,245,14,143,115,163,48,128,174,47,39,236,90,223,119,245,66,126,253,2,176,206,231,120,248,109,245,164,62,156,44,192,104,142,199,129,46,106,71,173,223,181,216,25,215,62,28,70,55,207,1,211,236,161,119,195,201,201,221,211,8,117,48,192,61,60,254,213,241,139,113,240,93,243,191,245,27,135,94,3,77,72,235,65,243,18,102,227,134,125,13,207,135,117,25,189,121,26,59,255,246,35,129,217,44,157,109,248,246,210,245,131,223,44,209,223,116,118,19,60,24,107,31,248,54,216,213,53,225,146,155,237,49,54,43,54,122,85,227,196,41,81,38,178,144,146,65,170,37,147,26,57,43,64,217,112,233,48,36,95,165,84,73,190,173,68,133,92,171,112,148,89,96,50,13,23,71,171,52,220,30,142,153,78,139,34,23,5,109,207,9,245,81,203,28,255,179,254,110,175,134,15,63,218,211,51,176,142,241,110,27,118,95,109,236,106,106,194,92,202,233,28,67,230,0,184,57,149,43,167,115,236,89,32,187,214,59,255,188,62,7,161,208,25,126,205,119,39,199,238,230,240,253,2,39,42,121,65,56,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ec31ba67-2908-4c33-ab00-c793af3942fe"),
				ContainerUId = new Guid("2795ebeb-a781-42a6-95c6-eaaaa61f75d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DeleteRights",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			deleteRightsParameter.SourceValue = new ProcessSchemaParameterValue(deleteRightsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1de5dc9d-6574-46df-b053-9b96038ceb26"),
				ContainerUId = new Guid("2795ebeb-a781-42a6-95c6-eaaaa61f75d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"AddRights",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			addRightsParameter.SourceValue = new ProcessSchemaParameterValue(addRightsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"[{Id:""a221e15a-9508-4329-949a-d26071d2b5e1"",CanRead:true,CanEdit:false,CanDelete:false,Source:""3"",Grantee:""Employee"",Name:""[#Read data 1.First item of resulting collection.Owner#]"",Value:""[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4c404844-a394-49c1-8a5f-edc34253eb41}].[Parameter:{b2bc1951-86fa-43e8-9538-a1c69388728e}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]"",OperationRightLevel:""1""}]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var employee1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("a221e15a-9508-4329-949a-d26071d2b5e1"),
				ContainerUId = new Guid("2795ebeb-a781-42a6-95c6-eaaaa61f75d3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"Employee1",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			employee1Parameter.SourceValue = new ProcessSchemaParameterValue(employee1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4c404844-a394-49c1-8a5f-edc34253eb41}].[Parameter:{b2bc1951-86fa-43e8-9538-a1c69388728e}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(employee1Parameter);
		}

		protected virtual void InitializeChangeAdminRightsUserTask3Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a553959d-5ef5-473a-9120-ffcf83f232f3"),
				ContainerUId = new Guid("ab77c13b-ff98-4349-afa7-bab3cb27817c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"EntitySchemaUId",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"16be3651-8fe2-4159-8dd0-a803d4683dd3",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2cfeb2b1-8654-4872-9793-d6e4dbffdf80"),
				ContainerUId = new Guid("ab77c13b-ff98-4349-afa7-bab3cb27817c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DataSourceFilters",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,93,111,211,48,20,253,43,85,158,241,148,15,39,141,251,134,70,65,123,97,19,155,246,66,121,184,113,174,59,139,36,142,108,103,80,170,254,119,174,147,174,116,168,104,133,23,36,68,158,156,163,115,143,207,253,242,54,146,13,56,247,30,90,140,22,209,29,90,11,206,40,127,241,86,55,30,237,59,107,134,62,122,21,57,180,26,26,253,13,235,9,95,214,218,191,1,15,20,178,93,253,80,88,69,139,213,105,141,85,244,106,21,105,143,173,35,14,133,96,50,135,90,42,201,82,53,207,25,7,149,49,145,171,138,169,4,176,46,16,121,81,195,196,252,149,248,165,105,123,176,56,221,49,202,171,241,120,183,233,3,53,33,64,142,20,237,76,183,7,179,96,194,45,59,168,26,172,233,223,219,1,9,242,86,183,148,13,222,233,22,111,192,210,93,65,199,4,136,72,10,26,23,88,13,42,191,252,218,91,116,78,155,238,37,115,205,208,118,199,108,18,192,195,239,222,78,60,122,12,204,27,240,15,163,196,21,217,218,141,46,95,175,215,22,215,224,245,227,177,137,207,184,25,121,231,213,143,2,106,234,210,61,52,3,30,221,249,60,147,75,232,253,148,208,116,61,17,172,94,63,156,157,235,161,98,47,165,155,18,216,63,145,207,212,60,153,67,90,16,248,24,128,73,229,233,184,138,62,94,185,235,47,29,218,91,249,128,45,76,85,251,116,65,232,79,192,178,193,22,59,191,216,114,201,99,94,114,206,32,19,156,113,33,19,86,66,174,24,214,50,227,105,158,97,197,147,29,5,28,12,45,182,85,90,201,68,228,68,44,20,48,158,97,73,165,207,74,6,137,44,68,86,150,243,180,196,16,178,236,188,246,155,105,18,22,219,130,67,156,87,20,144,229,113,205,120,93,41,86,169,186,100,170,202,231,2,230,92,101,130,162,166,116,181,235,27,216,220,31,178,250,128,80,207,76,223,27,235,135,142,52,103,38,228,72,235,101,157,159,133,165,154,25,53,163,90,15,141,215,221,122,70,35,213,160,12,61,165,57,236,60,72,63,202,134,222,146,88,157,199,28,178,178,96,32,69,201,184,74,11,38,48,77,88,82,226,188,152,39,185,136,179,146,102,48,124,97,84,204,90,75,104,174,123,180,176,159,146,248,244,18,61,219,190,208,32,107,140,159,202,126,104,240,177,157,167,73,22,92,0,38,64,229,44,49,102,188,162,147,200,43,206,100,90,84,2,185,146,32,56,249,161,71,40,140,193,173,25,172,220,47,189,155,94,159,63,122,85,254,194,91,241,59,235,127,114,1,207,89,168,255,171,242,175,173,202,46,218,125,7,195,117,222,7,164,7,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8fd7c9c4-dc77-4db1-b325-8aa7fa8ac061"),
				ContainerUId = new Guid("ab77c13b-ff98-4349-afa7-bab3cb27817c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DeleteRights",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			deleteRightsParameter.SourceValue = new ProcessSchemaParameterValue(deleteRightsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"[]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41cc529a-994c-4fcf-a254-c04b8cf9af68"),
				ContainerUId = new Guid("ab77c13b-ff98-4349-afa7-bab3cb27817c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"AddRights",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			addRightsParameter.SourceValue = new ProcessSchemaParameterValue(addRightsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"[{Id:""2f10d9d4-03c1-4389-a20e-0bda35dd2bd5"",Name:""[#Read data 1.First item of resulting collection.Owner#]"",CanRead:true,CanEdit:true,CanDelete:false,Source:""3"",Grantee:""Employee"",Value:""[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4c404844-a394-49c1-8a5f-edc34253eb41}].[Parameter:{b2bc1951-86fa-43e8-9538-a1c69388728e}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]"",OperationRightLevel:""1""}]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var employee1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("2f10d9d4-03c1-4389-a20e-0bda35dd2bd5"),
				ContainerUId = new Guid("ab77c13b-ff98-4349-afa7-bab3cb27817c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"Employee1",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			employee1Parameter.SourceValue = new ProcessSchemaParameterValue(employee1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4c404844-a394-49c1-8a5f-edc34253eb41}].[Parameter:{b2bc1951-86fa-43e8-9538-a1c69388728e}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(employee1Parameter);
		}

		protected virtual void InitializeChangeAdminRightsUserTask4Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("26e16ba2-8447-481b-adc0-bfcd99cdac94"),
				ContainerUId = new Guid("ec236e22-0787-4ec6-903b-3a9bb2169133"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"EntitySchemaUId",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"ae46fb87-c02c-4ae8-ad31-a923cdd994cf",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c5af4518-f121-495d-8cd6-8955646d1e47"),
				ContainerUId = new Guid("ec236e22-0787-4ec6-903b-3a9bb2169133"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DataSourceFilters",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,107,220,48,16,253,43,139,15,61,89,139,101,201,182,228,30,151,13,4,74,26,250,69,33,132,48,146,70,137,168,108,111,108,153,54,24,255,247,202,235,221,54,244,80,246,84,40,248,32,105,252,102,222,188,121,210,244,224,134,43,231,3,246,181,5,63,96,58,94,155,58,17,89,149,85,32,4,193,156,23,132,171,138,17,9,128,4,172,98,74,138,140,83,43,147,180,133,6,235,100,69,239,141,11,73,234,2,54,67,125,55,253,78,26,250,17,211,7,123,220,124,212,79,216,192,231,165,0,32,47,173,18,21,209,89,174,9,7,20,4,12,163,4,100,206,180,49,82,114,109,147,149,139,161,66,230,50,139,49,173,74,194,43,46,136,202,52,39,5,207,35,75,171,12,240,248,171,71,27,246,63,14,61,14,131,235,218,122,194,95,235,79,47,135,200,114,173,189,235,252,216,180,73,218,96,128,91,8,79,117,82,114,200,10,101,129,176,34,51,132,27,101,137,178,70,16,171,138,74,66,197,45,147,152,164,26,14,97,73,155,236,186,54,128,142,157,246,104,177,199,86,227,171,166,104,169,144,149,5,37,194,98,78,56,45,36,17,198,100,4,68,198,12,47,5,51,134,37,169,129,0,95,192,143,120,36,54,185,8,84,185,44,178,138,90,82,33,72,194,177,204,35,144,2,145,84,42,203,42,150,91,155,159,229,126,215,117,223,198,67,148,122,184,25,27,236,157,62,205,13,227,0,186,190,158,116,100,216,119,126,73,126,243,10,176,206,231,20,252,186,106,226,143,145,5,152,204,233,56,224,206,59,108,195,190,213,157,113,237,227,113,116,243,28,49,205,1,122,55,156,149,220,63,143,224,163,0,238,241,233,175,138,239,198,33,116,205,255,214,111,26,123,141,105,162,91,143,156,23,51,27,55,28,60,188,28,247,117,242,230,121,236,194,219,15,8,102,179,116,182,161,219,43,215,15,97,179,88,127,211,217,77,212,96,244,33,230,219,232,206,123,212,139,111,182,39,219,172,216,228,143,26,231,156,92,243,140,11,206,9,48,201,9,151,58,26,9,10,75,208,104,198,243,130,161,226,116,171,114,165,169,92,60,86,70,211,114,22,47,142,44,88,188,61,84,151,146,9,81,229,2,183,151,152,250,196,101,78,255,89,127,119,215,195,251,239,237,249,25,88,199,120,191,141,167,127,28,236,61,54,113,46,245,116,137,32,115,4,220,158,203,213,211,37,242,44,144,125,27,92,120,89,159,131,122,186,68,175,249,254,172,216,253,28,191,159,116,81,191,128,56,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var deleteRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e9da6cc3-1f06-4cef-a5d8-afab6dfa868a"),
				ContainerUId = new Guid("ec236e22-0787-4ec6-903b-3a9bb2169133"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"DeleteRights",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			deleteRightsParameter.SourceValue = new ProcessSchemaParameterValue(deleteRightsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(deleteRightsParameter);
			var addRightsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("158d3500-d2d7-45d8-a16e-8a35ba4be6a7"),
				ContainerUId = new Guid("ec236e22-0787-4ec6-903b-3a9bb2169133"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				Name = @"AddRights",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			addRightsParameter.SourceValue = new ProcessSchemaParameterValue(addRightsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"[{Id:""18133e4d-cf10-4802-a56b-948600113b9a"",CanRead:true,CanEdit:false,CanDelete:false,Source:""3"",Grantee:""Employee"",Name:""[#Read data 1.First item of resulting collection.Owner#]"",Value:""[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4c404844-a394-49c1-8a5f-edc34253eb41}].[Parameter:{b2bc1951-86fa-43e8-9538-a1c69388728e}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]"",OperationRightLevel:""1""}]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(addRightsParameter);
			var employee1Parameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("18133e4d-cf10-4802-a56b-948600113b9a"),
				ContainerUId = new Guid("ec236e22-0787-4ec6-903b-3a9bb2169133"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"Employee1",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			employee1Parameter.SourceValue = new ProcessSchemaParameterValue(employee1Parameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4c404844-a394-49c1-8a5f-edc34253eb41}].[Parameter:{b2bc1951-86fa-43e8-9538-a1c69388728e}].[EntityColumn:{684553a7-a59d-46fa-af4b-fc76e9fe3694}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8")
			};
			parametrizedElement.Parameters.Add(employee1Parameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask changeadminrightsusertask1 = CreateChangeAdminRightsUserTask1UserTask();
			FlowElements.Add(changeadminrightsusertask1);
			ProcessSchemaUserTask changeadminrightsusertask2 = CreateChangeAdminRightsUserTask2UserTask();
			FlowElements.Add(changeadminrightsusertask2);
			ProcessSchemaUserTask changeadminrightsusertask3 = CreateChangeAdminRightsUserTask3UserTask();
			FlowElements.Add(changeadminrightsusertask3);
			ProcessSchemaUserTask changeadminrightsusertask4 = CreateChangeAdminRightsUserTask4UserTask();
			FlowElements.Add(changeadminrightsusertask4);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaTerminateEvent terminateevent1 = CreateTerminateEvent1TerminateEvent();
			FlowElements.Add(terminateevent1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("403e201d-2cfa-4f2c-b3a4-4a410675ec02"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4b903a19-32b6-4c1a-9e26-56a2ff989412"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c223dfa-4f07-4f18-a477-f685140e06fb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8adad753-a3f4-4883-83a0-37f99e7ea166"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("46f915a2-4072-4192-9b7f-815a12c6e44e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("59b5b5b4-9b85-44d2-aa30-bdfbd0231331"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{4c404844-a394-49c1-8a5f-edc34253eb41}].[Parameter:{b2bc1951-86fa-43e8-9538-a1c69388728e}].[EntityColumn:{64a05bfa-350d-4dbf-bfd8-fb579a74f39e}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("46f915a2-4072-4192-9b7f-815a12c6e44e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab77c13b-ff98-4349-afa7-bab3cb27817c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(472, 295));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("71fd7273-03b0-43a4-8c2d-30a97219955a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d43b3f2e-dd0a-4c43-afc8-5c6d05699ef1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2795ebeb-a781-42a6-95c6-eaaaa61f75d3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("7991c25e-e358-4d2c-a880-4fac9fa893ad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2795ebeb-a781-42a6-95c6-eaaaa61f75d3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88bdaa7f-6a51-4a71-a5ea-83b732433ef1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(887, 97));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("5f9061c7-a981-4d5b-9acc-2c55d89e8e23"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("46f915a2-4072-4192-9b7f-815a12c6e44e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d43b3f2e-dd0a-4c43-afc8-5c6d05699ef1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(472, 96));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("07f70f79-c79b-47bf-a69a-adc84172d32e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ab77c13b-ff98-4349-afa7-bab3cb27817c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ec236e22-0787-4ec6-903b-3a9bb2169133"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("3ceb31db-15f9-4e38-8778-9ef5ce4c92b1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec236e22-0787-4ec6-903b-3a9bb2169133"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88bdaa7f-6a51-4a71-a5ea-83b732433ef1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(887, 296));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("edb3ddc2-9b25-4503-aed6-ae554d8bd328"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{c65ea67b-3e99-4cc4-8eb7-f4e8c2284d24}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c223dfa-4f07-4f18-a477-f685140e06fb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("c09dd96f-ab4d-46f7-9267-b883552f4d2d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c223dfa-4f07-4f18-a477-f685140e06fb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3660ec7a-0f81-46ef-8bdd-4b8f6683445f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8335dd98-a2df-4f6b-ae59-38d4023bddce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("b2bf72e6-f57a-4af4-aa4b-7b45dd7dfaa2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8335dd98-a2df-4f6b-ae59-38d4023bddce"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("88bdaa7f-6a51-4a71-a5ea-83b732433ef1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2bf72e6-f57a-4af4-aa4b-7b45dd7dfaa2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"Terminate1",
				Position = new Point(874, 178),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("4b903a19-32b6-4c1a-9e26-56a2ff989412"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2bf72e6-f57a-4af4-aa4b-7b45dd7dfaa2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(60, 180),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("684553a7-a59d-46fa-af4b-fc76e9fe3694");
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("46f915a2-4072-4192-9b7f-815a12c6e44e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2bf72e6-f57a-4af4-aa4b-7b45dd7dfaa2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"ExclusiveGateway1",
				Position = new Point(445, 166),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2bf72e6-f57a-4af4-aa4b-7b45dd7dfaa2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"ReadDataUserTask1",
				Position = new Point(331, 166),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false,
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeAdminRightsUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d43b3f2e-dd0a-4c43-afc8-5c6d05699ef1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2bf72e6-f57a-4af4-aa4b-7b45dd7dfaa2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"ChangeAdminRightsUserTask1",
				Position = new Point(541, 69),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false,
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeAdminRightsUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeAdminRightsUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2795ebeb-a781-42a6-95c6-eaaaa61f75d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2bf72e6-f57a-4af4-aa4b-7b45dd7dfaa2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"ChangeAdminRightsUserTask2",
				Position = new Point(712, 69),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false,
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeAdminRightsUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeAdminRightsUserTask3UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ab77c13b-ff98-4349-afa7-bab3cb27817c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2bf72e6-f57a-4af4-aa4b-7b45dd7dfaa2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"ChangeAdminRightsUserTask3",
				Position = new Point(535, 268),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false,
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeAdminRightsUserTask3Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeAdminRightsUserTask4UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ec236e22-0787-4ec6-903b-3a9bb2169133"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2bf72e6-f57a-4af4-aa4b-7b45dd7dfaa2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"ChangeAdminRightsUserTask4",
				Position = new Point(712, 268),
				SchemaUId = new Guid("0ebbb23c-f6db-45eb-ad13-a1445b7ef081"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false,
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeAdminRightsUserTask4Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("5c223dfa-4f07-4f18-a477-f685140e06fb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2bf72e6-f57a-4af4-aa4b-7b45dd7dfaa2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"FormulaTask1",
				Position = new Point(151, 166),
				ResultParameterMetaPath = @"c65ea67b-3e99-4cc4-8eb7-f4e8c2284d24",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,141,65,10,2,49,12,0,191,34,61,41,72,255,80,61,136,7,17,212,125,64,72,179,107,192,38,75,147,30,250,123,171,39,15,222,134,57,204,60,168,86,48,157,61,30,85,102,94,90,5,103,149,120,93,87,173,222,132,189,95,64,96,161,66,226,255,237,228,252,178,120,34,63,91,146,126,199,39,21,72,185,176,176,249,168,81,62,244,27,161,214,108,219,201,168,142,143,16,126,38,251,77,72,136,218,196,195,192,225,29,240,139,63,155,176,123,3,55,237,102,189,162,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("3660ec7a-0f81-46ef-8bdd-4b8f6683445f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b2bf72e6-f57a-4af4-aa4b-7b45dd7dfaa2"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd"),
				CreatedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"),
				Name = @"TerminateEvent1",
				Position = new Point(172, 332),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ce1a1d90-2050-42cf-b250-bde306300cd1"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("f63c5734-65ff-4c73-a934-bd5129ad81dd")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SetAccesRightsFromOpportunity(userConnection);
		}

		public override object Clone() {
			return new SetAccesRightsFromOpportunitySchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8"));
		}

		#endregion

	}

	#endregion

	#region Class: SetAccesRightsFromOpportunity

	/// <exclude/>
	public class SetAccesRightsFromOpportunity : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SetAccesRightsFromOpportunity process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, SetAccesRightsFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("4c404844-a394-49c1-8a5f-edc34253eb41");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,187,110,219,48,20,253,149,64,115,104,136,18,165,136,222,138,212,45,178,212,65,19,100,169,51,92,82,151,54,81,73,20,72,58,173,107,248,223,75,74,142,243,128,139,184,93,178,84,139,200,131,195,195,115,95,220,38,178,1,231,190,64,139,201,52,185,69,107,193,25,229,39,159,116,227,209,126,182,102,221,39,231,137,67,171,161,209,191,176,30,241,89,173,253,71,240,16,142,108,23,79,10,139,100,186,56,174,177,72,206,23,137,246,216,186,192,9,71,56,173,74,168,32,35,136,178,38,44,207,129,84,41,47,73,90,209,82,21,170,82,92,200,145,249,39,241,75,211,246,96,113,188,99,144,87,195,242,118,211,71,42,13,128,28,40,218,153,110,15,230,209,132,155,117,32,26,172,195,222,219,53,6,200,91,221,134,104,240,86,183,120,13,54,220,21,117,76,132,2,73,65,227,34,171,65,229,103,63,123,139,206,105,211,189,101,174,89,183,221,115,118,16,192,195,118,111,39,29,60,70,230,53,248,213,32,113,21,108,237,6,151,31,150,75,139,75,240,250,225,185,137,239,184,25,120,167,229,47,28,168,67,149,238,160,89,227,179,59,95,70,114,9,189,31,3,26,175,15,4,171,151,171,147,99,61,100,236,173,112,179,0,246,143,228,19,53,143,198,144,149,1,124,136,192,168,242,184,92,36,223,174,220,252,71,135,246,70,174,176,133,49,107,247,147,128,190,2,102,13,182,216,249,233,150,9,158,230,64,57,201,51,81,18,38,41,16,142,89,73,138,18,50,165,120,197,25,205,118,225,192,193,208,116,91,48,142,66,208,11,34,81,42,194,168,44,137,168,121,65,148,2,204,114,198,68,46,212,238,126,52,174,93,223,192,230,238,224,239,114,5,221,18,207,76,223,27,235,215,157,246,155,51,19,253,78,190,162,52,182,62,219,231,63,254,166,49,110,10,69,80,35,10,210,96,142,213,138,240,186,82,164,22,170,16,172,82,34,227,161,200,187,248,197,170,154,165,150,208,204,123,180,176,47,104,122,188,223,95,12,74,204,165,53,198,143,25,58,212,98,254,100,113,176,244,216,120,50,45,129,23,165,36,180,102,57,97,23,12,137,200,114,78,40,147,153,204,211,144,53,74,131,167,240,102,196,170,221,152,181,149,251,25,117,227,99,241,79,143,192,59,140,246,223,76,235,209,121,57,165,255,255,119,246,59,119,246,46,217,253,6,253,93,180,174,2,7,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })));
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
								new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
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

		#region Class: ChangeAdminRightsUserTask1FlowElement

		/// <exclude/>
		public class ChangeAdminRightsUserTask1FlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public ChangeAdminRightsUserTask1FlowElement(UserConnection userConnection, SetAccesRightsFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeAdminRightsUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("d43b3f2e-dd0a-4c43-afc8-5c6d05699ef1");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_employee1 = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,162,79,127,245,84,194,166,228,146,134,126,81,72,66,144,165,81,34,144,237,141,45,211,4,179,255,189,227,117,182,133,28,74,78,133,130,15,210,200,239,204,188,143,52,243,93,24,207,67,76,48,212,222,196,17,178,233,194,213,196,177,130,115,39,36,53,141,179,84,25,197,104,197,28,167,178,144,224,76,85,54,140,11,146,117,166,133,154,172,234,157,11,137,100,33,65,59,214,215,243,159,164,105,152,32,187,243,199,205,23,251,0,173,249,182,20,16,218,21,150,155,134,114,7,140,42,205,56,109,20,19,148,9,96,160,77,33,92,14,100,237,197,91,14,38,183,57,181,133,104,168,146,156,209,210,90,77,77,37,26,9,133,247,78,120,146,69,240,105,247,180,31,96,28,67,223,213,51,252,94,127,125,222,99,151,107,237,179,62,78,109,71,178,22,146,185,50,233,161,38,6,235,41,109,13,181,170,210,84,121,40,168,145,149,163,210,52,133,40,74,224,57,47,72,102,205,62,45,105,201,133,35,153,51,201,124,55,113,130,99,230,57,44,118,36,227,165,206,81,203,37,242,146,2,123,204,203,130,122,151,251,10,100,94,85,141,59,241,250,56,5,92,135,241,114,106,97,8,246,5,59,32,191,126,168,103,219,119,105,232,227,146,250,242,248,251,87,120,74,43,220,151,163,31,171,161,132,241,69,68,14,217,52,194,89,12,208,165,93,103,123,23,186,251,53,231,225,128,146,118,111,134,48,158,40,236,30,39,19,73,54,132,251,135,191,210,58,155,198,212,183,255,145,213,12,109,98,14,124,100,199,118,151,55,232,194,184,143,230,249,184,175,201,187,199,169,79,239,63,131,113,155,197,212,134,111,207,195,48,166,205,242,98,55,189,223,160,253,41,38,76,184,177,125,140,96,151,235,222,126,176,182,159,186,180,106,201,171,26,53,185,33,202,42,166,74,165,150,55,163,168,170,44,167,165,209,158,130,179,82,9,45,161,81,124,219,136,198,242,74,227,81,238,13,18,131,146,86,90,150,8,208,230,149,44,203,66,148,176,85,77,165,65,122,143,28,181,192,137,3,28,8,102,52,21,86,115,134,113,142,67,113,67,144,192,63,241,117,125,49,126,250,217,157,38,118,101,124,187,197,232,171,192,46,66,139,151,81,207,111,1,113,64,193,213,169,84,61,191,5,203,34,217,117,41,164,231,117,114,177,208,27,56,29,110,23,82,183,7,252,126,1,211,39,239,32,223,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = GetLocalizableString("d57a4e67a83b46589e7af878244d48d8",
						 "BaseElements.ChangeAdminRightsUserTask1.Parameters.AddRights.Value"));
				}
				set {
					_addRights = value;
				}
			}

			internal Func<Guid> _employee1;
			public  virtual Guid Employee1 {
				get {
					return (_employee1 ?? (_employee1 = () => Guid.Empty)).Invoke();
				}
				set {
					_employee1 = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeAdminRightsUserTask2FlowElement

		/// <exclude/>
		public class ChangeAdminRightsUserTask2FlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public ChangeAdminRightsUserTask2FlowElement(UserConnection userConnection, SetAccesRightsFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeAdminRightsUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("2795ebeb-a781-42a6-95c6-eaaaa61f75d3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_employee1 = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,107,220,48,16,253,43,139,15,61,89,139,37,75,182,229,158,74,216,64,160,164,161,95,20,66,8,227,209,40,17,245,199,198,150,105,131,241,127,175,188,222,109,67,14,101,79,133,130,15,150,196,123,243,230,205,147,166,123,55,92,186,218,83,95,90,168,7,138,199,43,83,70,38,7,170,44,102,76,88,97,152,204,176,96,5,129,100,100,50,66,146,88,21,36,163,184,133,134,202,104,69,239,140,243,81,236,60,53,67,121,59,253,33,245,253,72,241,189,61,44,62,225,35,53,240,101,41,0,36,51,91,21,57,195,68,32,147,64,5,3,147,114,6,90,164,104,140,214,18,109,180,106,201,82,99,1,179,138,137,84,10,38,173,214,12,84,166,152,74,179,130,203,10,51,129,65,75,77,214,239,126,238,123,26,6,215,181,229,68,191,255,63,63,239,131,202,181,246,69,87,143,77,27,197,13,121,184,1,255,88,70,178,210,138,82,107,153,53,74,44,66,56,171,18,80,76,160,226,73,216,231,10,242,40,70,216,251,133,54,122,135,216,141,109,232,180,39,75,61,181,72,47,154,18,202,228,200,161,98,220,80,194,164,74,2,151,76,4,75,4,37,20,120,68,112,47,138,13,120,248,10,245,72,7,97,147,11,192,74,104,149,228,220,178,156,64,51,73,153,96,133,225,192,52,215,149,77,243,84,88,43,78,118,191,239,186,239,227,62,88,61,92,143,13,245,14,143,115,163,48,128,174,47,39,236,90,223,119,245,66,126,253,2,176,206,231,120,248,109,245,164,62,156,44,192,104,142,199,129,46,106,71,173,223,181,216,25,215,62,28,70,55,207,1,211,236,161,119,195,201,201,221,211,8,117,48,192,61,60,254,213,241,139,113,240,93,243,191,245,27,135,94,3,77,72,235,65,243,18,102,227,134,125,13,207,135,117,25,189,121,26,59,255,246,35,129,217,44,157,109,248,246,210,245,131,223,44,209,223,116,118,19,60,24,107,31,248,54,216,213,53,225,146,155,237,49,54,43,54,122,85,227,196,41,81,38,178,144,146,65,170,37,147,26,57,43,64,217,112,233,48,36,95,165,84,73,190,173,68,133,92,171,112,148,89,96,50,13,23,71,171,52,220,30,142,153,78,139,34,23,5,109,207,9,245,81,203,28,255,179,254,110,175,134,15,63,218,211,51,176,142,241,110,27,118,95,109,236,106,106,194,92,202,233,28,67,230,0,184,57,149,43,167,115,236,89,32,187,214,59,255,188,62,7,161,208,25,126,205,119,39,199,238,230,240,253,2,39,42,121,65,56,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = GetLocalizableString("d57a4e67a83b46589e7af878244d48d8",
						 "BaseElements.ChangeAdminRightsUserTask2.Parameters.AddRights.Value"));
				}
				set {
					_addRights = value;
				}
			}

			internal Func<Guid> _employee1;
			public  virtual Guid Employee1 {
				get {
					return (_employee1 ?? (_employee1 = () => Guid.Empty)).Invoke();
				}
				set {
					_employee1 = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeAdminRightsUserTask3FlowElement

		/// <exclude/>
		public class ChangeAdminRightsUserTask3FlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public ChangeAdminRightsUserTask3FlowElement(UserConnection userConnection, SetAccesRightsFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeAdminRightsUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("ab77c13b-ff98-4349-afa7-bab3cb27817c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_employee1 = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,93,111,211,48,20,253,43,85,158,241,148,15,39,141,251,134,70,65,123,97,19,155,246,66,121,184,113,174,59,139,36,142,108,103,80,170,254,119,174,147,174,116,168,104,133,23,36,68,158,156,163,115,143,207,253,242,54,146,13,56,247,30,90,140,22,209,29,90,11,206,40,127,241,86,55,30,237,59,107,134,62,122,21,57,180,26,26,253,13,235,9,95,214,218,191,1,15,20,178,93,253,80,88,69,139,213,105,141,85,244,106,21,105,143,173,35,14,133,96,50,135,90,42,201,82,53,207,25,7,149,49,145,171,138,169,4,176,46,16,121,81,195,196,252,149,248,165,105,123,176,56,221,49,202,171,241,120,183,233,3,53,33,64,142,20,237,76,183,7,179,96,194,45,59,168,26,172,233,223,219,1,9,242,86,183,148,13,222,233,22,111,192,210,93,65,199,4,136,72,10,26,23,88,13,42,191,252,218,91,116,78,155,238,37,115,205,208,118,199,108,18,192,195,239,222,78,60,122,12,204,27,240,15,163,196,21,217,218,141,46,95,175,215,22,215,224,245,227,177,137,207,184,25,121,231,213,143,2,106,234,210,61,52,3,30,221,249,60,147,75,232,253,148,208,116,61,17,172,94,63,156,157,235,161,98,47,165,155,18,216,63,145,207,212,60,153,67,90,16,248,24,128,73,229,233,184,138,62,94,185,235,47,29,218,91,249,128,45,76,85,251,116,65,232,79,192,178,193,22,59,191,216,114,201,99,94,114,206,32,19,156,113,33,19,86,66,174,24,214,50,227,105,158,97,197,147,29,5,28,12,45,182,85,90,201,68,228,68,44,20,48,158,97,73,165,207,74,6,137,44,68,86,150,243,180,196,16,178,236,188,246,155,105,18,22,219,130,67,156,87,20,144,229,113,205,120,93,41,86,169,186,100,170,202,231,2,230,92,101,130,162,166,116,181,235,27,216,220,31,178,250,128,80,207,76,223,27,235,135,142,52,103,38,228,72,235,101,157,159,133,165,154,25,53,163,90,15,141,215,221,122,70,35,213,160,12,61,165,57,236,60,72,63,202,134,222,146,88,157,199,28,178,178,96,32,69,201,184,74,11,38,48,77,88,82,226,188,152,39,185,136,179,146,102,48,124,97,84,204,90,75,104,174,123,180,176,159,146,248,244,18,61,219,190,208,32,107,140,159,202,126,104,240,177,157,167,73,22,92,0,38,64,229,44,49,102,188,162,147,200,43,206,100,90,84,2,185,146,32,56,249,161,71,40,140,193,173,25,172,220,47,189,155,94,159,63,122,85,254,194,91,241,59,235,127,114,1,207,89,168,255,171,242,175,173,202,46,218,125,7,195,117,222,7,164,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _deleteRights;
			public override string DeleteRights {
				get {
					return _deleteRights ?? (_deleteRights = GetLocalizableString("d57a4e67a83b46589e7af878244d48d8",
						 "BaseElements.ChangeAdminRightsUserTask3.Parameters.DeleteRights.Value"));
				}
				set {
					_deleteRights = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = GetLocalizableString("d57a4e67a83b46589e7af878244d48d8",
						 "BaseElements.ChangeAdminRightsUserTask3.Parameters.AddRights.Value"));
				}
				set {
					_addRights = value;
				}
			}

			internal Func<Guid> _employee1;
			public  virtual Guid Employee1 {
				get {
					return (_employee1 ?? (_employee1 = () => Guid.Empty)).Invoke();
				}
				set {
					_employee1 = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeAdminRightsUserTask4FlowElement

		/// <exclude/>
		public class ChangeAdminRightsUserTask4FlowElement : ChangeAdminRightsUserTask
		{

			#region Constructors: Public

			public ChangeAdminRightsUserTask4FlowElement(UserConnection userConnection, SetAccesRightsFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeAdminRightsUserTask4";
				IsLogging = true;
				SchemaElementUId = new Guid("ec236e22-0787-4ec6-903b-3a9bb2169133");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_employee1 = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,107,220,48,16,253,43,139,15,61,89,139,101,201,182,228,30,151,13,4,74,26,250,69,33,132,48,146,70,137,168,108,111,108,153,54,24,255,247,202,235,221,54,244,80,246,84,40,248,32,105,252,102,222,188,121,210,244,224,134,43,231,3,246,181,5,63,96,58,94,155,58,17,89,149,85,32,4,193,156,23,132,171,138,17,9,128,4,172,98,74,138,140,83,43,147,180,133,6,235,100,69,239,141,11,73,234,2,54,67,125,55,253,78,26,250,17,211,7,123,220,124,212,79,216,192,231,165,0,32,47,173,18,21,209,89,174,9,7,20,4,12,163,4,100,206,180,49,82,114,109,147,149,139,161,66,230,50,139,49,173,74,194,43,46,136,202,52,39,5,207,35,75,171,12,240,248,171,71,27,246,63,14,61,14,131,235,218,122,194,95,235,79,47,135,200,114,173,189,235,252,216,180,73,218,96,128,91,8,79,117,82,114,200,10,101,129,176,34,51,132,27,101,137,178,70,16,171,138,74,66,197,45,147,152,164,26,14,97,73,155,236,186,54,128,142,157,246,104,177,199,86,227,171,166,104,169,144,149,5,37,194,98,78,56,45,36,17,198,100,4,68,198,12,47,5,51,134,37,169,129,0,95,192,143,120,36,54,185,8,84,185,44,178,138,90,82,33,72,194,177,204,35,144,2,145,84,42,203,42,150,91,155,159,229,126,215,117,223,198,67,148,122,184,25,27,236,157,62,205,13,227,0,186,190,158,116,100,216,119,126,73,126,243,10,176,206,231,20,252,186,106,226,143,145,5,152,204,233,56,224,206,59,108,195,190,213,157,113,237,227,113,116,243,28,49,205,1,122,55,156,149,220,63,143,224,163,0,238,241,233,175,138,239,198,33,116,205,255,214,111,26,123,141,105,162,91,143,156,23,51,27,55,28,60,188,28,247,117,242,230,121,236,194,219,15,8,102,179,116,182,161,219,43,215,15,97,179,88,127,211,217,77,212,96,244,33,230,219,232,206,123,212,139,111,182,39,219,172,216,228,143,26,231,156,92,243,140,11,206,9,48,201,9,151,58,26,9,10,75,208,104,198,243,130,161,226,116,171,114,165,169,92,60,86,70,211,114,22,47,142,44,88,188,61,84,151,146,9,81,229,2,183,151,152,250,196,101,78,255,89,127,119,215,195,251,239,237,249,25,88,199,120,191,141,167,127,28,236,61,54,113,46,245,116,137,32,115,4,220,158,203,213,211,37,242,44,144,125,27,92,120,89,159,131,122,186,68,175,249,254,172,216,253,28,191,159,116,81,191,128,56,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private string _addRights;
			public override string AddRights {
				get {
					return _addRights ?? (_addRights = GetLocalizableString("d57a4e67a83b46589e7af878244d48d8",
						 "BaseElements.ChangeAdminRightsUserTask4.Parameters.AddRights.Value"));
				}
				set {
					_addRights = value;
				}
			}

			internal Func<Guid> _employee1;
			public  virtual Guid Employee1 {
				get {
					return (_employee1 ?? (_employee1 = () => Guid.Empty)).Invoke();
				}
				set {
					_employee1 = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		public SetAccesRightsFromOpportunity(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SetAccesRightsFromOpportunity";
			SchemaUId = new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_isOpportunityRightsUsed = () => { return (bool)(false); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("d57a4e67-a83b-4658-9e7a-f878244d48d8");
			}
		}

		#endregion

		#region Properties: Public

		private Func<bool> _isOpportunityRightsUsed;
		public  virtual bool IsOpportunityRightsUsed {
			get {
				return (_isOpportunityRightsUsed ?? (_isOpportunityRightsUsed = () => false)).Invoke();
			}
			set {
				_isOpportunityRightsUsed = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public  ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessTerminateEvent _terminate1;
		public  ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("88bdaa7f-6a51-4a71-a5ea-83b732433ef1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal1;
		public  ProcessStartSignalEvent StartSignal1 {
			get {
				return _startSignal1 ?? (_startSignal1 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal1",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("4b903a19-32b6-4c1a-9e26-56a2ff989412"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
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
					SchemaElementUId = new Guid("46f915a2-4072-4192-9b7f-815a12c6e44e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public  ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeAdminRightsUserTask1FlowElement _changeAdminRightsUserTask1;
		public  ChangeAdminRightsUserTask1FlowElement ChangeAdminRightsUserTask1 {
			get {
				return _changeAdminRightsUserTask1 ?? (_changeAdminRightsUserTask1 = new ChangeAdminRightsUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeAdminRightsUserTask2FlowElement _changeAdminRightsUserTask2;
		public  ChangeAdminRightsUserTask2FlowElement ChangeAdminRightsUserTask2 {
			get {
				return _changeAdminRightsUserTask2 ?? (_changeAdminRightsUserTask2 = new ChangeAdminRightsUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeAdminRightsUserTask3FlowElement _changeAdminRightsUserTask3;
		public  ChangeAdminRightsUserTask3FlowElement ChangeAdminRightsUserTask3 {
			get {
				return _changeAdminRightsUserTask3 ?? (_changeAdminRightsUserTask3 = new ChangeAdminRightsUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeAdminRightsUserTask4FlowElement _changeAdminRightsUserTask4;
		public  ChangeAdminRightsUserTask4FlowElement ChangeAdminRightsUserTask4 {
			get {
				return _changeAdminRightsUserTask4 ?? (_changeAdminRightsUserTask4 = new ChangeAdminRightsUserTask4FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask1;
		public  ProcessScriptTask FormulaTask1 {
			get {
				return _formulaTask1 ?? (_formulaTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask1",
					SchemaElementUId = new Guid("5c223dfa-4f07-4f18-a477-f685140e06fb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent1;
		public  ProcessTerminateEvent TerminateEvent1 {
			get {
				return _terminateEvent1 ?? (_terminateEvent1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1",
					SchemaElementUId = new Guid("3660ec7a-0f81-46ef-8bdd-4b8f6683445f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow1;
		public  ProcessConditionalFlow ConditionalSequenceFlow1 {
			get {
				return _conditionalSequenceFlow1 ?? (_conditionalSequenceFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1",
					SchemaElementUId = new Guid("59b5b5b4-9b85-44d2-aa30-bdfbd0231331"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow2;
		public  ProcessConditionalFlow ConditionalSequenceFlow2 {
			get {
				return _conditionalSequenceFlow2 ?? (_conditionalSequenceFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow2",
					SchemaElementUId = new Guid("edb3ddc2-9b25-4503-aed6-ae554d8bd328"),
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
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ChangeAdminRightsUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAdminRightsUserTask1 };
			FlowElements[ChangeAdminRightsUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAdminRightsUserTask2 };
			FlowElements[ChangeAdminRightsUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAdminRightsUserTask3 };
			FlowElements[ChangeAdminRightsUserTask4.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeAdminRightsUserTask4 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAdminRightsUserTask3", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAdminRightsUserTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ChangeAdminRightsUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAdminRightsUserTask2", e.Context.SenderName));
						break;
					case "ChangeAdminRightsUserTask2":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ChangeAdminRightsUserTask3":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeAdminRightsUserTask4", e.Context.SenderName));
						break;
					case "ChangeAdminRightsUserTask4":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			return Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)) != Guid.Empty);
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			return Convert.ToBoolean((IsOpportunityRightsUsed));
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("ChangeAdminRightsUserTask1.Employee1")) {
				writer.WriteValue("ChangeAdminRightsUserTask1.Employee1", ChangeAdminRightsUserTask1.Employee1, Guid.Empty);
			}
			if (!HasMapping("ChangeAdminRightsUserTask2.Employee1")) {
				writer.WriteValue("ChangeAdminRightsUserTask2.Employee1", ChangeAdminRightsUserTask2.Employee1, Guid.Empty);
			}
			if (!HasMapping("ChangeAdminRightsUserTask3.Employee1")) {
				writer.WriteValue("ChangeAdminRightsUserTask3.Employee1", ChangeAdminRightsUserTask3.Employee1, Guid.Empty);
			}
			if (!HasMapping("ChangeAdminRightsUserTask4.Employee1")) {
				writer.WriteValue("ChangeAdminRightsUserTask4.Employee1", ChangeAdminRightsUserTask4.Employee1, Guid.Empty);
			}
			if (!HasMapping("IsOpportunityRightsUsed")) {
				writer.WriteValue("IsOpportunityRightsUsed", IsOpportunityRightsUsed, false);
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
			MetaPathParameterValues.Add("c65ea67b-3e99-4cc4-8eb7-f4e8c2284d24", () => IsOpportunityRightsUsed);
			MetaPathParameterValues.Add("549ebb17-cecf-41c6-bd95-ffae2344b3bf", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("2f1a80d7-bbd4-46fe-9c6f-d58535e65e26", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("4c8af6fd-bd7f-48bc-a01a-bb1b4c2dadaa", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("37f79cc5-72b0-4169-9601-bac57ad16d46", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("784185aa-491d-4ae1-9637-4ec1b6e33600", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("695907f5-c228-44c5-a407-2a548e51082a", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("aa895d0a-e0c4-4006-a36d-f630c1d4c9f4", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("76c3e926-235d-4333-95c1-8244bbe96d32", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("68f73716-a547-40e1-a01e-14fa3735d69f", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("b2bc1951-86fa-43e8-9538-a1c69388728e", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("fe2f0849-2ead-4e5d-8c1b-aa1ed5b79d69", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("a9ceb484-db0c-420a-9670-69705fc544c3", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("fe563ae3-7e4c-415e-b9d7-d6513e08b524", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("34ff8192-4a6f-4efa-8e2c-6819a886bb8b", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("2e317487-334c-4d63-b8a3-c6c897f3a0e9", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("b5daa445-357c-4f8a-b134-65b4d6fead46", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("405d83bb-77ad-4756-87e3-cf26a433fd44", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("d9636297-ae2c-4a5d-abdc-f407e520ccd8", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("397a5c45-e5dd-4750-9d80-8d7c171d1bd4", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("596999c7-a3ba-4426-bc51-d25ca3faa210", () => ChangeAdminRightsUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("286a9ef3-728b-4e9d-a55f-e79611706c3d", () => ChangeAdminRightsUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("8b6d0f09-9bfd-4995-ab8a-92dc9fea2e6d", () => ChangeAdminRightsUserTask1.DeleteRights);
			MetaPathParameterValues.Add("6cea097e-5930-4926-a76f-822a3f6d2fa8", () => ChangeAdminRightsUserTask1.AddRights);
			MetaPathParameterValues.Add("a8e84fa3-72de-46be-aeb7-82599aa924a6", () => ChangeAdminRightsUserTask1.Employee1);
			MetaPathParameterValues.Add("a7aa851b-3505-4fad-b70e-5a2a4168bf95", () => ChangeAdminRightsUserTask2.EntitySchemaUId);
			MetaPathParameterValues.Add("e5545178-2b81-48e3-baa9-526aa54a5ac5", () => ChangeAdminRightsUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("ec31ba67-2908-4c33-ab00-c793af3942fe", () => ChangeAdminRightsUserTask2.DeleteRights);
			MetaPathParameterValues.Add("1de5dc9d-6574-46df-b053-9b96038ceb26", () => ChangeAdminRightsUserTask2.AddRights);
			MetaPathParameterValues.Add("a221e15a-9508-4329-949a-d26071d2b5e1", () => ChangeAdminRightsUserTask2.Employee1);
			MetaPathParameterValues.Add("a553959d-5ef5-473a-9120-ffcf83f232f3", () => ChangeAdminRightsUserTask3.EntitySchemaUId);
			MetaPathParameterValues.Add("2cfeb2b1-8654-4872-9793-d6e4dbffdf80", () => ChangeAdminRightsUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("8fd7c9c4-dc77-4db1-b325-8aa7fa8ac061", () => ChangeAdminRightsUserTask3.DeleteRights);
			MetaPathParameterValues.Add("41cc529a-994c-4fcf-a254-c04b8cf9af68", () => ChangeAdminRightsUserTask3.AddRights);
			MetaPathParameterValues.Add("2f10d9d4-03c1-4389-a20e-0bda35dd2bd5", () => ChangeAdminRightsUserTask3.Employee1);
			MetaPathParameterValues.Add("26e16ba2-8447-481b-adc0-bfcd99cdac94", () => ChangeAdminRightsUserTask4.EntitySchemaUId);
			MetaPathParameterValues.Add("c5af4518-f121-495d-8cd6-8955646d1e47", () => ChangeAdminRightsUserTask4.DataSourceFilters);
			MetaPathParameterValues.Add("e9da6cc3-1f06-4cef-a5d8-afab6dfa868a", () => ChangeAdminRightsUserTask4.DeleteRights);
			MetaPathParameterValues.Add("158d3500-d2d7-45d8-a16e-8a35ba4be6a7", () => ChangeAdminRightsUserTask4.AddRights);
			MetaPathParameterValues.Add("18133e4d-cf10-4802-a56b-948600113b9a", () => ChangeAdminRightsUserTask4.Employee1);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "ChangeAdminRightsUserTask1.Employee1":
					ChangeAdminRightsUserTask1.Employee1 = reader.GetValue<System.Guid>();
				break;
				case "ChangeAdminRightsUserTask2.Employee1":
					ChangeAdminRightsUserTask2.Employee1 = reader.GetValue<System.Guid>();
				break;
				case "ChangeAdminRightsUserTask3.Employee1":
					ChangeAdminRightsUserTask3.Employee1 = reader.GetValue<System.Guid>();
				break;
				case "ChangeAdminRightsUserTask4.Employee1":
					ChangeAdminRightsUserTask4.Employee1 = reader.GetValue<System.Guid>();
				break;
				case "IsOpportunityRightsUsed":
					if (!hasValueToRead) break;
					IsOpportunityRightsUsed = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localIsOpportunityRightsUsed = Terrasoft.Configuration.OpportunityManagement.OpportunityManagementUtils.GetIsAnySchemaAdministratedByRecords(UserConnection, "Account", "Contact", "Opportunity");
			IsOpportunityRightsUsed = (System.Boolean)localIsOpportunityRightsUsed;
			return true;
		}

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
			var cloneItem = (SetAccesRightsFromOpportunity)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

