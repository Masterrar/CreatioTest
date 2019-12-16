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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: LeadManagementProceedToOrderSchema

	/// <exclude/>
	public class LeadManagementProceedToOrderSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementProceedToOrderSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementProceedToOrderSchema(LeadManagementProceedToOrderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementProceedToOrder";
			UId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d");
			CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d");
			Version = 0;
			PackageUId = new Guid("23109609-1650-4a4b-aecb-d0974c538074");
		}

		protected virtual ProcessSchemaParameter CreateNewOrderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2a65c94d-ad96-4e1a-8678-3223fff78f0d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"NewOrder",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3dad7563-c615-43f4-ad63-595693663fd7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{233e216d-e42b-4488-bb80-ae2955e15772}].[Parameter:{39c2ee29-de07-42d7-9978-27bbe105b922}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateActivityOwnerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("56720a3e-4608-4bb3-8953-ed86f7f2fb7b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ActivityOwner",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{ab568057-901b-4628-947b-e71e93061aed}].[Parameter:{b63e014f-03e2-411a-b56e-cd11fcd2dedf}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNewOrderParameter());
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateActivityOwnerParameter());
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("39c2ee29-de07-42d7-9978-27bbe105b922"),
				ContainerUId = new Guid("233e216d-e42b-4488-bb80-ae2955e15772"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("233e216d-e42b-4488-bb80-ae2955e15772"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
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

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("51e58f82-c660-4f51-a482-2e47790531e4"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,138,209,161,39,43,216,146,108,73,238,169,44,219,178,80,146,208,166,165,144,13,65,31,163,68,224,143,141,37,147,4,179,255,189,218,117,54,133,28,74,142,45,248,160,25,249,125,103,230,241,120,190,245,225,179,111,35,140,141,83,109,128,124,218,216,6,149,140,19,66,133,195,26,140,193,172,100,53,86,68,83,76,107,34,104,225,170,146,17,133,242,94,117,208,160,69,189,182,62,162,220,71,232,66,115,61,255,49,141,227,4,249,173,59,6,223,205,61,116,234,199,161,0,43,149,19,18,36,230,85,161,49,3,173,177,48,202,96,231,168,212,53,19,172,4,131,150,94,88,45,57,231,154,97,86,83,142,153,229,37,86,149,149,152,72,85,56,161,57,24,233,80,222,130,139,235,167,221,8,33,248,161,111,102,120,61,95,61,239,82,151,75,237,213,208,78,93,143,242,14,162,186,84,241,190,65,10,10,96,149,81,216,48,89,97,230,128,99,69,165,197,84,105,78,184,128,178,46,57,202,141,218,197,131,45,218,88,148,91,21,213,79,213,78,112,116,158,125,234,145,208,162,20,85,157,180,37,77,188,40,41,176,168,5,199,206,214,78,2,173,165,212,246,196,235,203,228,211,217,135,243,169,131,209,155,23,236,144,248,13,99,51,155,161,143,227,208,30,172,207,143,175,95,193,83,92,224,190,92,253,90,6,138,41,127,16,161,125,62,5,88,181,30,250,184,238,205,96,125,127,183,120,238,247,73,210,237,212,232,195,137,194,250,97,82,45,202,71,127,119,255,87,90,171,41,196,161,251,143,70,205,211,152,201,35,45,217,177,221,195,14,90,31,118,173,122,62,198,13,250,240,48,13,241,227,87,80,54,243,125,182,221,46,241,167,71,229,99,114,201,130,106,225,148,204,66,84,119,144,169,222,102,49,213,207,6,119,188,206,124,120,213,93,140,22,198,83,112,246,13,204,48,218,108,99,151,24,189,105,166,65,219,68,141,2,41,107,139,129,145,180,239,76,8,172,181,40,176,2,34,171,10,202,138,115,114,70,165,33,144,18,216,66,145,54,157,88,142,165,228,2,19,174,53,148,69,165,37,33,91,148,40,252,91,179,93,111,194,197,99,127,250,189,151,15,114,115,150,178,111,18,235,22,186,244,229,154,249,61,48,246,73,112,121,42,213,204,239,65,179,191,57,192,185,217,167,231,55,216,101,143,194,214,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("72785b41-22fc-440b-9e25-09541a823da1"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ba95284a-479c-4695-b20e-f63e9d809aef"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9cfa6a66-c948-435e-a77c-ce3c093762b0"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38ad1df5-1e23-417a-b816-604ee5ebd463"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("43a2921d-cbf9-4ccf-9e18-3b7e690771cf"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
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
				UId = new Guid("b56a9823-aa72-425f-bd71-e269cc7c6b9e"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("b63e014f-03e2-411a-b56e-cd11fcd2dedf"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c5ddbc71-2bb8-4428-9200-8670e0c41529"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				UId = new Guid("39c0f849-1bbe-41f7-a8ec-60baac586e9d"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				UId = new Guid("362c2b06-2632-4385-811f-5d44097aba94"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				UId = new Guid("f78dac62-b855-47c2-98b1-8d7452f88518"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				UId = new Guid("dbb1f233-5174-43e1-b1c7-d09d994ca216"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				UId = new Guid("1156c6f8-f42f-40e6-aabd-037e9316c30f"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("f91976d0-6fa2-4bfa-aa99-75e535e05b15"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f0036525-a88d-4f8f-9e33-96275cc4add9"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("21c581af-6689-4593-83b0-ade1bc6ace04"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1c841b42-21d7-449c-9c25-e5d9006c569c"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a849651b-3c94-415e-8f28-495c77cb69c2"),
				ContainerUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
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
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeReadDataUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("233422b6-ee14-4a8a-ba4e-5872f8b8c777"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,107,220,48,16,253,43,70,135,158,172,197,146,101,125,184,167,18,182,101,161,36,161,77,75,33,27,130,100,141,18,129,63,54,150,76,18,150,253,239,149,215,217,20,114,40,57,182,224,131,102,228,121,243,230,205,140,246,183,62,124,246,109,132,177,118,186,13,144,79,27,91,35,105,11,161,140,21,88,85,198,97,86,52,18,27,11,5,38,132,58,162,181,17,210,40,148,247,186,131,26,45,209,107,235,35,202,125,132,46,212,215,251,63,160,113,156,32,191,117,71,227,123,115,15,157,254,49,39,32,142,115,82,81,192,140,20,18,51,101,37,86,170,42,49,87,5,171,92,193,173,147,18,45,92,132,225,165,227,37,195,178,34,137,11,48,192,186,224,28,115,46,12,8,224,172,4,64,121,11,46,174,159,118,35,132,224,135,190,222,195,235,249,234,121,151,88,46,185,207,134,118,234,122,148,119,16,245,165,142,247,53,162,13,51,96,88,133,173,170,20,102,101,81,96,99,12,96,7,172,81,78,27,238,136,92,105,40,128,85,141,198,13,83,21,102,14,4,214,165,178,184,76,74,80,33,129,112,34,80,222,232,93,156,115,163,175,160,237,106,99,81,110,117,212,63,117,59,193,145,195,222,167,106,104,89,16,89,241,4,64,202,38,229,163,5,150,92,10,236,44,119,10,74,174,146,236,39,101,191,76,62,157,125,56,159,58,24,125,243,210,32,72,74,15,99,189,111,134,62,142,67,59,67,159,31,127,191,130,167,184,180,225,229,234,215,82,122,76,254,57,8,29,242,41,192,89,235,161,143,235,190,25,172,239,239,22,204,195,33,133,116,59,61,250,112,210,107,253,48,233,22,229,163,191,187,255,171,174,103,83,136,67,247,31,149,154,167,50,19,70,26,199,35,221,121,90,173,15,187,86,63,31,237,26,125,120,152,134,248,113,238,97,230,251,108,187,93,236,79,143,218,199,132,146,5,221,194,201,153,133,168,239,32,211,189,205,98,202,159,13,238,120,157,249,240,26,119,49,90,24,79,198,234,27,52,195,104,179,141,93,108,244,134,76,141,182,73,181,18,40,225,22,3,163,6,51,38,211,234,25,89,96,13,84,85,21,144,74,8,186,42,85,67,33,57,112,90,74,129,25,157,55,85,9,137,169,72,179,75,138,202,40,74,183,40,169,240,111,213,118,189,9,23,143,253,233,33,88,26,114,179,74,222,55,142,117,11,93,234,92,189,127,143,24,135,20,112,121,74,85,239,223,35,205,225,102,22,231,230,144,190,223,106,53,37,99,0,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0e73147b-3fca-4520-ae87-958d8a954ecb"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4741dc21-15cb-41c2-8680-9e717f617814"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1830ecce-1fbf-4a1d-927b-835b4390eef4"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("be29adc6-c305-4fb0-b446-ae26278a5cf6"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4fd6ce9f-f292-41a0-a8ba-d343dfc9cb25"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			aggregationColumnNameParameter.SourceValue = new ProcessSchemaParameterValue(aggregationColumnNameParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,1,0,242,67,189,42,2,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f5c8e8e8-ec65-413b-b1ef-1e44cb614020"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,73,77,76,177,50,180,50,4,0,110,194,57,215,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				UId = new Guid("83189d35-e077-4319-b18e-c6f2b2393707"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				Name = @"ResultEntity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17afe864-aaad-4c4e-ad01-768cbd0e842d"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				UId = new Guid("53363eca-d6fd-4903-a89f-afc707231e89"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				UId = new Guid("2d30b140-c803-410d-99de-46fefa3903f9"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				UId = new Guid("e8a3eb91-0b0d-419f-8a07-a279783a4aed"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				UId = new Guid("9e8fe1c5-61e9-4c8c-93e5-05ed37a5a23b"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				UId = new Guid("de74e707-3683-47dc-acb1-0620c233b644"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
				ReferenceSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				UId = new Guid("6afe29bc-36f3-4e7b-a2a6-ed65c01eaae2"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77c33b50-7f50-4a1e-846b-d24d080ce656"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("abe22acf-b177-4dbf-a6d4-52b190f66261"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
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
			var resultCompositeObjectListParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a36f8fca-865d-4aa4-8cc3-db83862aa504"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				Name = @"ResultCompositeObjectList",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("CompositeObjectList")
			};
			resultCompositeObjectListParameter.SourceValue = new ProcessSchemaParameterValue(resultCompositeObjectListParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultCompositeObjectListParameter);
			var considerTimeInFilterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d1cd5032-a015-49e6-8905-762ec1677544"),
				ContainerUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
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
				Name = @"ConsiderTimeInFilter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			considerTimeInFilterParameter.SourceValue = new ProcessSchemaParameterValue(considerTimeInFilterParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f")
			};
			parametrizedElement.Parameters.Add(considerTimeInFilterParameter);
		}

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("28914bf3-2c8b-4583-b644-625e18978559"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"80294582-06b5-4faa-a85f-3323e5536b71",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c1ffede0-fe00-42d9-a867-6030c7ce74a0"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("86435d98-74c1-4ada-b6e5-22961dde1a37"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
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
				UId = new Guid("1f919ca3-5929-45db-98dd-c0fa939af046"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9b610c3e-7085-4d3f-963b-b33fd03a0d68"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,153,91,79,27,87,16,199,191,138,229,228,145,177,206,253,226,183,10,82,9,41,23,148,164,121,9,60,204,57,51,39,177,106,108,180,94,167,162,136,239,222,89,3,5,210,214,113,34,33,149,22,63,24,123,215,51,231,50,243,155,249,159,229,98,252,188,63,63,227,241,116,252,158,187,14,87,203,214,79,246,151,29,79,142,186,101,229,213,106,242,114,89,113,62,251,29,203,156,143,176,195,83,238,185,251,128,243,53,175,94,206,86,253,222,232,190,217,120,111,252,252,203,230,238,120,250,241,98,124,216,243,233,47,135,36,222,141,214,62,115,80,144,83,102,112,158,52,96,214,12,196,45,25,108,153,188,70,49,174,203,249,250,116,241,138,123,60,194,254,243,120,122,49,222,120,19,7,53,42,165,168,90,113,128,226,160,69,7,232,44,67,76,156,125,14,202,85,147,199,151,123,227,85,253,204,167,184,25,244,214,56,41,147,157,79,6,84,40,94,140,17,1,147,111,96,173,177,236,189,13,37,234,193,248,250,247,183,134,31,159,125,60,92,189,249,109,193,221,187,141,223,105,195,249,138,79,38,114,245,171,11,47,230,124,202,139,126,122,129,197,135,164,124,132,172,116,1,23,76,130,236,98,1,142,154,179,85,65,35,211,165,24,252,185,155,211,139,18,44,43,237,26,40,203,6,156,214,8,226,132,161,146,214,173,146,33,166,54,152,188,88,244,179,254,124,127,179,71,211,11,43,107,202,200,14,90,211,22,92,106,30,114,243,36,155,139,209,121,159,24,189,191,60,121,118,50,44,140,102,171,179,57,158,127,248,235,250,222,50,210,136,176,199,209,92,62,77,126,158,117,171,126,52,147,184,141,150,109,212,241,106,61,239,103,139,79,35,9,204,156,107,63,91,46,38,63,213,186,92,47,250,43,199,103,247,114,226,174,235,139,227,171,212,58,30,79,143,255,41,185,174,255,94,109,229,253,244,250,58,179,142,199,123,199,227,119,203,117,87,7,143,118,248,114,19,233,205,8,234,250,5,127,243,118,243,186,242,177,49,123,133,11,252,196,221,107,25,113,99,190,185,117,32,219,176,25,252,189,204,251,198,113,49,217,171,168,27,68,198,12,142,131,129,68,18,161,172,115,105,54,90,211,154,217,88,191,229,198,29,47,42,223,159,152,241,20,171,198,2,154,88,73,112,148,134,226,148,164,162,97,197,18,42,67,225,106,113,155,145,111,39,115,3,129,92,89,172,231,243,205,0,171,205,250,7,170,174,39,126,125,231,224,78,120,239,120,88,210,172,205,152,14,23,63,178,85,151,227,203,203,189,187,8,59,213,162,198,170,0,117,150,44,77,58,66,209,9,37,177,67,81,86,153,18,66,222,138,112,226,148,147,175,40,251,39,224,186,42,174,114,45,8,198,133,96,109,86,70,135,255,25,194,72,46,43,242,9,148,119,8,142,146,32,44,187,1,68,73,246,132,139,205,201,62,4,194,251,203,69,143,245,9,225,29,17,214,161,176,13,94,67,106,155,224,250,44,246,36,32,36,101,201,133,100,137,236,163,64,24,91,200,190,90,3,198,87,33,208,144,151,133,8,129,193,162,83,182,154,170,40,109,69,184,216,86,131,113,82,199,10,6,73,216,44,59,161,82,133,170,36,143,181,77,193,180,248,16,8,191,92,46,127,93,159,77,156,54,74,43,175,64,59,97,203,69,148,249,103,111,160,90,82,198,73,65,141,41,78,116,179,72,214,4,224,214,164,27,162,104,6,28,160,204,62,114,20,189,97,67,114,223,66,234,122,188,55,29,113,55,90,245,216,175,87,19,61,25,29,116,216,158,168,217,145,154,93,130,245,40,168,169,45,34,42,201,119,226,32,85,90,100,39,100,38,7,150,52,151,64,90,53,106,91,169,105,74,84,175,51,17,180,231,42,18,64,218,132,92,240,96,185,146,179,154,148,40,216,7,164,166,106,81,223,81,90,110,86,214,129,83,33,128,52,48,134,32,202,219,85,78,13,83,154,148,198,86,250,50,65,33,105,124,46,81,4,52,242,150,140,179,94,26,88,116,21,191,139,154,51,60,31,186,233,13,61,71,115,92,44,152,158,224,217,13,158,93,98,246,56,224,113,186,144,148,94,240,86,180,162,171,205,65,74,142,192,166,146,131,86,165,105,19,182,194,19,66,105,69,178,28,172,82,82,70,168,74,27,14,217,2,9,85,66,30,27,178,234,33,91,142,192,233,75,148,249,179,76,221,37,85,165,145,52,81,133,153,154,160,162,164,103,230,73,10,177,162,246,30,74,147,42,231,16,135,64,71,35,135,83,45,218,192,177,12,233,191,11,30,226,249,236,11,119,231,79,244,252,88,235,217,33,104,143,130,30,46,165,184,210,42,164,50,180,158,44,90,77,78,81,82,164,171,247,142,130,141,41,108,127,108,98,209,59,233,53,101,168,227,146,153,214,104,64,31,52,176,168,214,230,172,75,133,30,146,30,170,198,199,226,180,120,96,9,100,144,18,144,185,26,176,153,92,171,53,27,133,56,241,138,90,140,162,167,99,145,144,59,42,21,80,25,146,175,114,4,42,217,83,35,181,35,61,7,55,220,12,20,72,14,175,187,25,119,79,212,236,70,205,46,193,122,20,212,84,202,169,104,73,89,108,40,9,37,141,3,114,137,94,142,57,150,152,165,175,214,16,183,63,108,244,190,57,146,77,64,231,134,7,0,65,42,123,113,34,93,165,237,182,16,6,5,103,31,144,154,76,65,69,137,150,80,63,60,207,107,37,129,156,49,27,52,37,225,25,30,181,36,142,147,106,40,13,226,76,36,193,240,35,78,69,200,182,22,162,112,93,139,84,137,144,203,142,212,28,93,75,181,13,52,175,151,11,168,184,250,124,35,224,158,232,217,141,158,93,130,246,40,232,9,53,164,150,69,162,161,170,67,207,209,21,138,215,17,8,165,21,5,162,42,13,116,43,61,162,202,66,74,133,65,78,70,86,36,159,116,31,204,149,229,184,35,30,208,49,98,243,15,65,207,187,243,213,7,236,102,195,191,42,38,251,235,78,98,212,75,164,249,91,16,136,217,240,172,236,203,87,166,163,91,219,255,126,242,147,209,156,7,173,84,85,24,142,27,218,64,49,41,64,67,141,73,71,77,82,8,183,37,255,206,19,251,23,38,255,201,229,31,227,180,39,72,5,27,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7c960984-040e-414d-913e-c8e671a175c3"),
				ContainerUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
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

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("3a8fb70e-eb46-4374-ad70-c1d1df862c33"),
				ContainerUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ed01677f-c36f-4d12-bdce-2d077bf60563"),
				ContainerUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a6c6ca26-ca85-48d8-aa3f-ea21bffa2172"),
				ContainerUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,43,70,135,158,172,32,203,31,146,220,83,9,219,178,80,146,208,166,165,144,13,97,36,141,19,129,63,54,150,76,18,204,254,247,106,215,187,41,228,80,114,108,65,7,205,72,239,205,155,167,209,124,231,252,103,215,6,28,235,6,90,143,233,180,182,53,201,121,150,161,69,67,37,138,146,22,2,4,213,76,74,218,40,222,148,141,133,66,103,134,164,61,116,88,147,5,189,178,46,144,212,5,236,124,125,51,255,33,13,227,132,233,93,115,8,190,155,7,236,224,199,190,64,145,65,35,21,42,42,74,166,105,129,90,83,105,192,208,166,201,149,174,10,89,100,24,11,28,181,88,35,121,206,40,203,5,163,5,99,81,85,30,239,43,168,44,203,42,205,25,114,146,182,216,132,213,243,118,68,239,221,208,215,51,190,238,175,95,182,81,229,82,251,124,104,167,174,39,105,135,1,174,32,60,212,4,144,97,81,26,160,166,80,177,211,6,5,133,92,89,154,131,22,92,72,204,170,76,144,212,192,54,236,105,201,218,146,212,66,128,159,208,78,120,96,158,93,212,24,229,101,178,172,34,54,203,13,45,114,206,168,172,164,160,141,173,26,133,121,165,148,182,39,191,190,76,46,238,157,191,152,58,28,157,57,218,142,209,191,97,172,103,51,244,97,28,218,61,245,197,225,250,53,62,135,197,220,227,209,175,165,161,16,243,123,16,217,165,147,199,243,214,97,31,86,189,25,172,235,239,23,206,221,46,66,186,45,140,206,159,92,88,61,78,208,146,116,116,247,15,127,117,235,124,242,97,232,254,163,86,211,216,102,228,136,67,118,144,187,159,65,235,252,182,133,151,67,92,147,15,143,211,16,62,126,69,176,137,235,147,205,102,137,63,61,129,11,145,37,241,208,226,41,153,248,0,247,152,64,111,147,16,235,39,67,115,56,78,156,127,197,93,142,22,199,83,112,246,13,205,48,218,100,109,151,152,188,17,83,147,77,116,45,71,158,85,150,98,193,227,188,23,241,47,105,45,25,5,228,170,44,49,43,133,224,103,185,50,28,99,130,90,100,130,22,220,10,170,148,144,148,11,173,49,99,165,86,156,111,72,116,225,223,234,237,102,237,47,159,250,211,247,94,30,228,246,44,102,223,36,86,45,118,241,229,234,249,61,102,236,34,224,234,84,170,158,223,99,205,238,118,111,206,237,46,174,223,77,163,124,157,214,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b2c3e896-818e-48fd-bd84-3c8320d25e1a"),
				ContainerUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,193,114,218,48,16,253,21,70,201,17,49,146,37,217,146,175,73,15,204,36,45,211,164,185,0,135,181,180,106,152,49,54,35,155,118,82,198,255,94,33,32,64,218,94,170,131,109,237,234,189,183,218,125,222,145,219,254,109,131,164,36,207,24,2,116,173,239,39,119,109,192,201,44,180,22,187,110,242,208,90,168,87,191,160,170,113,6,1,214,216,99,120,129,122,139,221,195,170,235,199,163,107,24,25,147,219,31,41,75,202,249,142,76,123,92,127,155,186,200,174,145,105,148,85,65,149,119,156,202,138,123,10,204,231,148,161,183,76,10,134,50,147,17,108,219,122,187,110,30,177,135,25,244,175,164,220,145,196,22,9,114,103,29,19,76,82,172,92,78,37,50,78,181,99,134,22,104,16,157,81,86,59,36,195,152,116,246,21,215,144,68,207,96,201,193,107,131,241,180,98,85,4,87,21,213,22,44,245,94,152,42,151,90,114,180,123,240,241,252,25,56,191,153,79,187,47,63,27,12,79,137,183,244,80,119,184,156,196,232,135,192,167,26,215,216,244,229,14,184,6,38,77,70,65,114,70,165,4,136,95,42,10,22,78,113,229,188,19,153,29,34,224,189,155,229,174,176,38,103,70,75,202,36,67,42,185,116,212,112,129,212,106,204,11,14,188,80,86,12,203,155,229,190,68,183,234,54,53,188,189,252,89,233,93,64,232,113,212,6,135,97,114,216,184,81,64,27,3,163,169,59,160,55,87,35,188,196,239,22,7,39,44,72,185,248,151,23,142,239,195,205,175,221,240,209,8,11,50,94,144,167,118,27,236,158,81,236,55,167,193,36,5,118,92,244,47,143,211,58,112,36,216,35,52,240,29,195,231,168,152,224,41,117,15,61,36,241,231,88,247,137,184,202,140,98,69,180,87,129,96,226,168,243,44,250,132,67,108,168,169,188,40,68,230,125,150,208,95,209,99,192,198,226,117,97,154,101,70,42,157,81,150,87,138,74,191,31,159,86,158,10,145,9,84,74,228,85,193,19,62,41,159,139,57,121,54,70,154,109,93,39,129,46,221,127,255,19,28,11,63,102,238,47,102,120,193,208,186,149,95,161,155,54,255,211,170,129,12,195,114,248,13,122,227,156,213,207,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeOpenEditPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var objectSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("ae68593e-fa7c-4048-b895-2278f193bf56"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ObjectSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			objectSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(objectSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"80294582-06b5-4faa-a85f-3323e5536b71",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(objectSchemaIdParameter);
			var pageSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("660ef167-9f42-438e-8e32-a0abcc62314c"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageSchemaId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			pageSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(pageSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"23d86ac4-1d23-4314-a5e3-5da5e61b495a",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(pageSchemaIdParameter);
			var editModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7df2eca1-dc6c-4087-9840-bee0cc1e644b"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"EditMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			editModeParameter.SourceValue = new ProcessSchemaParameterValue(editModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(editModeParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f101f976-de4b-4470-b288-dc04974ea7d9"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordColumnValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,171,86,82,41,169,44,72,85,178,82,10,73,45,42,74,44,206,79,43,209,115,206,47,74,213,11,40,202,79,78,45,46,214,243,201,79,78,204,201,172,74,76,202,73,13,72,44,74,204,77,45,73,45,10,75,204,41,77,45,246,201,44,46,209,81,64,213,166,164,163,164,82,6,150,85,178,138,142,173,5,0,199,127,71,237,94,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("6cff8c4f-e5db-4f8a-aa7a-f5ac4428b6ea"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a18a0492-a410-44aa-a45b-87d515dfd32c}].[Parameter:{7c960984-040e-414d-913e-c8e671a175c3}]#]",
				MetaPath = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a18a0492-a410-44aa-a45b-87d515dfd32c}].[Parameter:{7c960984-040e-414d-913e-c8e671a175c3}]#]",
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var executedModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e5ec6ce6-b474-4ec1-956c-dfb129b1a5ce"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ExecutedMode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			executedModeParameter.SourceValue = new ProcessSchemaParameterValue(executedModeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executedModeParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b956b76e-964d-46ce-823f-beb59ae28699"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsMatchConditions",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("00eecca3-2d14-485a-8a8d-eb397d8ffbe8"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DataSourceFilters",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var generateDecisionsFromColumnParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bdac390a-ff58-46a2-907b-14a0c0565f2d"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"GenerateDecisionsFromColumn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			generateDecisionsFromColumnParameter.SourceValue = new ProcessSchemaParameterValue(generateDecisionsFromColumnParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(generateDecisionsFromColumnParameter);
			var decisionalColumnMetaPathParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f6bbd23d-5104-4c79-9ac8-67b6d9a5d3bd"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DecisionalColumnMetaPath",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			decisionalColumnMetaPathParameter.SourceValue = new ProcessSchemaParameterValue(decisionalColumnMetaPathParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(decisionalColumnMetaPathParameter);
			var resultParameterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a7ec73e2-62cc-4a89-a496-e288aec50bdd"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ResultParameter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			resultParameterParameter.SourceValue = new ProcessSchemaParameterValue(resultParameterParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(resultParameterParameter);
			var isReexecutionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("07ade664-1878-4494-93a7-397c9d9a6ba7"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsReexecution",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isReexecutionParameter.SourceValue = new ProcessSchemaParameterValue(isReexecutionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isReexecutionParameter);
			var recommendationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a25f8f25-a5bc-45f5-a3af-e84d2a250555"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Recommendation",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Fill in the needed fields and save the order",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("c5bf469a-ca79-4c27-93c4-428493383a2b"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivityCategory",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			activityCategoryParameter.SourceValue = new ProcessSchemaParameterValue(activityCategoryParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"f51c4643-58e6-df11-971b-001d60e938c6",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(activityCategoryParameter);
			var ownerIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("109924be-1b7d-46bd-8855-110f7046c49a"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = true,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"OwnerId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{56720a3e-4608-4bb3-8953-ed86f7f2fb7b}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("44c80af5-265f-4ca1-8c98-78e4479635ae"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Duration",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationParameter.SourceValue = new ProcessSchemaParameterValue(durationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c2f936e7-236a-4f61-9aa8-1cadbac9d2fd"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"DurationPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationPeriodParameter.SourceValue = new ProcessSchemaParameterValue(durationPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2983e005-8470-45c9-be2e-d84d93a53203"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"StartIn",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInParameter.SourceValue = new ProcessSchemaParameterValue(startInParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInParameter);
			var startInPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("61ea02d3-de9d-4459-b975-072fcd9eff4e"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"StartInPeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInPeriodParameter.SourceValue = new ProcessSchemaParameterValue(startInPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c610af2b-9150-43b8-aa79-239e85143fb7"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RemindBefore",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41ec49be-7cd4-437d-910a-78a49a359978"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"RemindBeforePeriod",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforePeriodParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforePeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("16cb3b84-997b-460f-931d-69d58bf053af"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ShowInScheduler",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9060fb85-9faf-4a13-809f-40fd6d37daa4"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ShowExecutionPage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("3ca71ac5-ea92-4f42-a671-9da656bf2653"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Lead",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{3dad7563-c615-43f4-ad63-595693663fd7}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("1e40cbb6-dc33-43c4-907a-c06736c03f8c"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Account",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{ab568057-901b-4628-947b-e71e93061aed}].[Parameter:{b63e014f-03e2-411a-b56e-cd11fcd2dedf}].[EntityColumn:{32949ae4-ff13-48f5-9f5d-45a74558ea55}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("42b3fc94-7228-4d8e-a9a0-44a7c7f1a17f"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Contact",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{ab568057-901b-4628-947b-e71e93061aed}].[Parameter:{b63e014f-03e2-411a-b56e-cd11fcd2dedf}].[EntityColumn:{ad490d58-054a-4d85-9246-dd8466eb3983}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("68804ba6-68d6-4d9a-8543-e1311e13aa63"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Opportunity",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			opportunityParameter.SourceValue = new ProcessSchemaParameterValue(opportunityParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(opportunityParameter);
			var invoiceParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				UId = new Guid("dba832e4-be08-4c39-a60b-c029abee42d9"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Invoice",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			invoiceParameter.SourceValue = new ProcessSchemaParameterValue(invoiceParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(invoiceParameter);
			var documentParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				UId = new Guid("24b1894d-cb19-4761-95a7-21945965fd96"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Document",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			documentParameter.SourceValue = new ProcessSchemaParameterValue(documentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(documentParameter);
			var incidentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("79b75417-25b2-4638-9fc0-4ba8602c8164"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Incident",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			incidentParameter.SourceValue = new ProcessSchemaParameterValue(incidentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(incidentParameter);
			var caseParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				UId = new Guid("493d3b26-b741-456e-a4a9-1660de4605f1"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Case",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			caseParameter.SourceValue = new ProcessSchemaParameterValue(caseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(caseParameter);
			var activityResultParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b88a7ef-d511-4681-afe2-7e7af45479bb"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivityResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activityResultParameter.SourceValue = new ProcessSchemaParameterValue(activityResultParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activityResultParameter);
			var currentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b8c8487c-7ec9-4fd7-8382-45adcafaa80a"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"CurrentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			currentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(currentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(currentActivityIdParameter);
			var isActivityCompletedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9bba3ff9-9d5d-49eb-9944-5a24a927c8ee"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"IsActivityCompleted",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isActivityCompletedParameter.SourceValue = new ProcessSchemaParameterValue(isActivityCompletedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(isActivityCompletedParameter);
			var executionContextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("02d10657-558f-4de5-bc41-185610ee3c4e"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ExecutionContext",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			executionContextParameter.SourceValue = new ProcessSchemaParameterValue(executionContextParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(executionContextParameter);
			var pageTypeUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9ddc804c-6acd-4c8d-abf1-0a89835fc9f5"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"PageTypeUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			pageTypeUIdParameter.SourceValue = new ProcessSchemaParameterValue(pageTypeUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(pageTypeUIdParameter);
			var activitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0f985d04-5e4c-4f3f-8bb9-7b29315ceede"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = false,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"ActivitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			activitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(activitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(activitySchemaUIdParameter);
			var informationOnStepParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17fa3835-9993-4c3b-910d-6fb4b4eb8ab5"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"InformationOnStep",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			informationOnStepParameter.SourceValue = new ProcessSchemaParameterValue(informationOnStepParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(informationOnStepParameter);
			var orderParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("1ea2f7f3-5e09-433d-a01f-16a9ece5d11f"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Order",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			orderParameter.SourceValue = new ProcessSchemaParameterValue(orderParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{2a65c94d-ad96-4e1a-8678-3223fff78f0d}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d")
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2e83dfcb-d1d1-445a-9f96-e47984017cff"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Requests",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			requestsParameter.SourceValue = new ProcessSchemaParameterValue(requestsParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(requestsParameter);
			var listingParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fae4b282-9884-4e09-9382-4e83f9cec633"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Listing",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			listingParameter.SourceValue = new ProcessSchemaParameterValue(listingParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(listingParameter);
			var propertyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("985510b3-2488-477a-a863-3ebb94e621e1"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Property",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			propertyParameter.SourceValue = new ProcessSchemaParameterValue(propertyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(propertyParameter);
			var contractParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				UId = new Guid("38999ad9-2ac8-48c0-8d33-55e204924212"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Contract",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contractParameter.SourceValue = new ProcessSchemaParameterValue(contractParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contractParameter);
			var problemParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230"),
				UId = new Guid("fa4a8316-c6cc-40b6-8c02-edb5ba71cba1"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Problem",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			problemParameter.SourceValue = new ProcessSchemaParameterValue(problemParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(problemParameter);
			var changeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("de5c8d59-d372-407d-8c09-f0523e057e40"),
				UId = new Guid("26e8d57d-215d-4749-8846-746c59eb9b24"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Change",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			changeParameter.SourceValue = new ProcessSchemaParameterValue(changeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(changeParameter);
			var releaseParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				UId = new Guid("cbc1205a-31ec-4838-8fc9-aef608dfbee4"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Release",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			releaseParameter.SourceValue = new ProcessSchemaParameterValue(releaseParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(releaseParameter);
			var projectParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				UId = new Guid("f54e7ee6-df35-43bf-a417-1b4b63aa77d4"),
				ContainerUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				Name = @"Project",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			projectParameter.SourceValue = new ProcessSchemaParameterValue(projectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(projectParameter);
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
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaUserTask readdatausertask2 = CreateReadDataUserTask2UserTask();
			FlowElements.Add(readdatausertask2);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaTerminateEvent terminateevent1 = CreateTerminateEvent1TerminateEvent();
			FlowElements.Add(terminateevent1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			ProcessSchemaUserTask openeditpageusertask1 = CreateOpenEditPageUserTask1UserTask();
			FlowElements.Add(openeditpageusertask1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaExclusiveGateway exclusivegatewayuseproduct = CreateExclusiveGatewayUseProductExclusiveGateway();
			FlowElements.Add(exclusivegatewayuseproduct);
			ProcessSchemaExclusiveGateway exclusivegatewaycontainsowner = CreateExclusiveGatewayContainsOwnerExclusiveGateway();
			FlowElements.Add(exclusivegatewaycontainsowner);
			ProcessSchemaFormulaTask formulatask2 = CreateFormulaTask2FormulaTask();
			FlowElements.Add(formulatask2);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow2ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow4ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("ce9777c8-0300-4372-ad96-9248f5e91a0c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("81b3a4f0-4c35-4ef8-9bd7-f217b5163dfd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("2939990e-abae-4748-8572-9190deffcb21"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e51e6ffc-424c-4ce3-a4f5-8ee830d2b8ca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("233e216d-e42b-4488-bb80-ae2955e15772"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("69c15883-6503-4463-a254-378cf5b5f503"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("10679508-f2c3-44a1-b1e6-4833590364ed"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69c15883-6503-4463-a254-378cf5b5f503"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6b2d1b2d-8ccf-4962-9073-d5cecdf6c2dd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(83, 231));
			schemaFlow.PolylinePointPositions.Add(new Point(84, 231));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow1",
				UId = new Guid("a7178c4c-176e-442c-bd14-a31bac9eaac7"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{233e216d-e42b-4488-bb80-ae2955e15772}].[Parameter:{39c2ee29-de07-42d7-9978-27bbe105b922}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69c15883-6503-4463-a254-378cf5b5f503"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("391c3d74-5ca7-44c2-accb-5eeba7b07f80"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("17207bea-f7f4-4e1c-85ee-b5f4af812e1c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1074, 317));
			schemaFlow.PolylinePointPositions.Add(new Point(1074, 188));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("4c6443fd-d84a-42e5-b51a-0c57c0acdc37"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("36a74fd9-906b-4e48-b36f-eeba6b29c35b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("f496c1c2-9114-4581-a08e-d8cfb472041e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("42c40f4d-fcc3-47cb-a47f-beee84ae882d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("17207bea-f7f4-4e1c-85ee-b5f4af812e1c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("5e01239b-825b-4e46-9b8c-d2bd7e7a7502"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("98e1d81a-4d06-4707-96b1-d201519c7ee1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow2",
				UId = new Guid("2464e066-7e89-42fe-a792-c0681c0223a7"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{6c6198b1-4959-4529-90ea-d61784ab5100}].[Parameter:{17afe864-aaad-4c4e-ad01-768cbd0e842d}]#] > 0",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("951af993-3900-4618-9898-be413728166b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("42c40f4d-fcc3-47cb-a47f-beee84ae882d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(792, 317));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("fbe102fe-3947-4c2d-bbe1-07cf19332670"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("951af993-3900-4618-9898-be413728166b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow4",
				UId = new Guid("d1345e84-0430-446e-bd62-9a9b023143e4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("98e1d81a-4d06-4707-96b1-d201519c7ee1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("951af993-3900-4618-9898-be413728166b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow4",
				UId = new Guid("b57d3370-16d1-44e5-8e6f-851093a1cab2"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{ab568057-901b-4628-947b-e71e93061aed}].[Parameter:{b63e014f-03e2-411a-b56e-cd11fcd2dedf}].[EntityColumn:{52817348-4c01-4015-a766-cb10c7b554c8}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("98e1d81a-4d06-4707-96b1-d201519c7ee1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("640f47a7-f8d1-43b2-a576-7e45f8aa3dd8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(644, 316));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("744348fe-7225-44dc-a649-19685cf5b691"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("640f47a7-f8d1-43b2-a576-7e45f8aa3dd8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("951af993-3900-4618-9898-be413728166b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(705, 188));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("cab6cd99-d30a-49a7-b146-48197ae12bf5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cab6cd99-d30a-49a7-b146-48197ae12bf5"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("36a74fd9-906b-4e48-b36f-eeba6b29c35b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"Terminate1",
				Position = new Point(1220, 175),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("233e216d-e42b-4488-bb80-ae2955e15772"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(70, 63),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("bc0c2d60-5a3d-4840-aa4e-c60ea776e206");
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("ab568057-901b-4628-947b-e71e93061aed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ReadDataUserTask1",
				Position = new Point(183, 161),
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

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ReadDataUserTask2",
				Position = new Point(287, 161),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false,
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadDataUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"AddDataUserTask1",
				Position = new Point(393, 161),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false,
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(504, 161),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false,
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("69c15883-6503-4463-a254-378cf5b5f503"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ExclusiveGateway1",
				Position = new Point(56, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("6b2d1b2d-8ccf-4962-9073-d5cecdf6c2dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"TerminateEvent1",
				Position = new Point(71, 287),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("17207bea-f7f4-4e1c-85ee-b5f4af812e1c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ScriptTask1",
				Position = new Point(980, 290),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,87,75,111,219,56,16,62,107,129,254,7,174,78,114,107,104,211,235,166,13,144,58,105,97,96,155,164,181,219,30,22,139,128,149,198,137,0,61,92,146,74,42,20,249,239,59,67,82,22,245,136,108,185,7,91,18,57,143,111,134,223,12,73,239,123,81,164,108,43,146,8,190,37,234,126,205,127,130,100,111,217,26,132,224,178,216,168,112,81,8,192,191,124,147,220,149,130,171,164,200,195,85,37,87,160,84,146,223,201,240,3,168,175,60,45,225,13,217,57,11,190,72,16,40,156,67,68,146,115,230,223,180,44,251,243,23,127,120,222,134,167,18,102,167,248,26,67,148,100,60,101,138,255,188,1,17,65,174,58,163,231,89,81,118,6,11,197,211,102,248,129,11,6,242,7,66,206,225,145,93,230,42,81,213,42,186,135,140,127,42,65,84,29,64,161,43,240,145,231,252,14,4,133,176,204,165,226,121,4,239,170,43,158,65,224,255,3,60,190,17,69,92,70,202,159,105,164,232,35,60,143,227,69,145,150,89,30,248,118,50,36,113,127,76,224,75,158,168,81,1,204,203,190,249,208,230,102,84,78,39,122,84,98,25,143,78,47,74,33,32,143,170,49,161,193,185,127,237,36,133,250,183,125,175,159,255,133,87,101,246,29,196,245,230,29,151,64,18,242,8,27,237,36,190,79,82,5,66,146,122,64,223,11,1,92,129,25,37,166,221,112,129,171,66,34,1,177,205,76,44,138,108,203,69,34,139,124,93,109,33,188,252,81,242,20,233,73,11,237,207,25,61,150,177,89,105,98,212,214,120,166,74,32,15,200,16,67,28,132,155,26,38,117,136,165,53,147,13,11,106,77,44,25,100,40,59,99,39,51,246,139,96,104,162,246,217,135,30,246,83,244,180,54,128,117,154,113,81,213,75,181,140,143,42,213,15,101,18,247,75,149,124,120,84,175,174,7,204,13,73,135,151,217,86,85,179,29,142,200,78,127,198,196,175,84,33,16,36,34,89,164,92,202,247,60,194,129,138,188,189,89,244,197,206,2,170,83,244,43,149,40,73,242,92,220,149,25,38,38,240,203,22,32,223,34,234,228,121,24,3,10,60,128,80,58,157,207,162,216,9,141,96,176,70,19,144,14,230,26,202,64,212,14,158,66,196,32,44,101,205,234,17,123,14,235,55,215,142,174,223,13,81,81,10,46,208,231,58,201,160,207,151,69,35,68,166,237,103,45,31,24,107,27,164,6,143,238,89,224,176,155,37,249,142,232,150,164,30,45,118,61,216,98,153,29,35,15,84,64,182,112,93,62,213,61,226,182,209,179,161,236,122,183,222,102,246,24,179,178,142,61,167,179,121,186,198,254,236,1,52,245,44,131,94,125,204,234,192,188,218,247,32,109,116,226,236,71,108,54,151,117,81,91,9,122,238,44,31,180,209,182,191,185,137,113,62,180,116,54,130,39,253,223,236,120,136,41,176,65,207,156,196,56,57,105,82,129,155,193,109,107,51,232,83,207,180,15,52,218,231,163,237,148,70,98,168,129,121,94,223,82,184,234,96,209,91,222,124,116,13,177,174,176,227,56,75,104,182,201,195,125,216,217,101,188,199,81,135,121,196,184,195,157,208,174,50,209,3,169,220,54,188,52,79,107,103,130,103,218,11,63,149,92,79,238,241,223,43,135,65,8,3,155,236,225,104,144,84,83,19,109,84,38,248,208,13,78,123,185,130,71,253,113,184,174,147,169,11,147,141,240,58,135,41,100,210,69,106,218,136,45,208,73,218,199,168,153,38,114,148,59,2,123,172,250,69,34,35,210,220,233,159,28,174,235,244,237,121,255,164,49,221,14,117,88,180,244,122,58,122,58,19,207,157,75,129,211,251,219,55,149,93,119,63,60,179,235,230,254,208,73,239,65,181,242,188,246,238,182,66,13,221,105,239,47,173,24,251,139,5,175,79,78,216,171,126,96,79,12,240,70,84,199,210,50,100,182,173,151,174,14,26,66,59,181,215,6,144,222,88,73,250,85,251,230,244,27,233,113,172,31,157,164,190,141,167,9,157,169,49,83,191,255,238,65,192,57,140,232,128,157,108,31,113,54,24,59,8,244,78,13,187,24,198,206,7,83,22,203,201,79,55,156,65,106,29,103,186,155,250,231,215,143,63,64,208,220,238,181,32,254,4,168,82,228,12,15,219,112,250,63,27,241,9,94,112,16,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"OpenEditPageUserTask1",
				Position = new Point(1100, 161),
				SchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false,
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeOpenEditPageUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("42c40f4d-fcc3-47cb-a47f-beee84ae882d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"FormulaTask1",
				Position = new Point(851, 290),
				ResultParameterMetaPath = @"2a65c94d-ad96-4e1a-8678-3223fff78f0d",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,187,14,131,48,12,64,209,143,97,118,21,19,135,60,246,14,76,69,234,136,50,184,137,81,7,194,16,144,58,32,254,157,204,221,174,142,116,231,110,30,247,215,111,147,250,78,95,41,28,22,94,119,137,143,166,127,240,92,165,200,118,132,147,209,177,34,223,3,19,42,32,98,110,101,62,224,108,54,104,242,146,117,159,174,54,76,92,185,200,33,53,156,54,249,65,121,71,160,72,9,16,82,6,143,90,32,57,25,44,50,90,147,244,21,187,120,3,152,79,215,44,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayUseProductExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("951af993-3900-4618-9898-be413728166b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ExclusiveGatewayUseProduct",
				Position = new Point(765, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayContainsOwnerExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("98e1d81a-4d06-4707-96b1-d201519c7ee1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"ExclusiveGatewayContainsOwner",
				Position = new Point(617, 161),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask2FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("640f47a7-f8d1-43b2-a576-7e45f8aa3dd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("915a628e-c19f-4a9f-a44c-a4e524cf5816"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a"),
				CreatedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"),
				Name = @"FormulaTask2",
				Position = new Point(671, 288),
				ResultParameterMetaPath = @"56720a3e-4608-4bb3-8953-ed86f7f2fb7b",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,204,187,10,194,48,20,128,225,135,113,62,146,147,123,179,74,7,39,5,199,210,33,151,19,20,154,8,109,68,164,244,221,173,171,235,15,223,63,28,134,243,114,121,87,154,111,241,78,197,187,236,167,133,198,227,94,255,66,63,81,161,218,220,234,131,210,150,41,3,29,195,0,82,115,11,157,52,1,200,32,117,130,105,244,148,182,29,92,253,236,11,53,154,221,26,180,32,134,50,3,19,196,65,34,122,216,39,4,49,33,230,152,120,162,148,127,164,175,237,209,62,167,231,244,42,213,173,138,91,52,66,90,144,145,33,72,134,10,188,209,26,98,64,22,77,80,74,70,187,141,135,241,11,154,157,117,132,196,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("32e89cc2-c170-4148-993c-07ae3aa76178"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b0ad8bea-22e0-4780-944c-36847851410d"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("8beebd12-d17f-4e9e-805f-0ffb7364705a")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementProceedToOrder(userConnection);
		}

		public override object Clone() {
			return new LeadManagementProceedToOrderSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementProceedToOrder

	/// <exclude/>
	public class LeadManagementProceedToOrder : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, LeadManagementProceedToOrder process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, LeadManagementProceedToOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("ab568057-901b-4628-947b-e71e93061aed");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,138,209,161,39,43,216,146,108,73,238,169,44,219,178,80,146,208,166,165,144,13,65,31,163,68,224,143,141,37,147,4,179,255,189,218,117,54,133,28,74,142,45,248,160,25,249,125,103,230,241,120,190,245,225,179,111,35,140,141,83,109,128,124,218,216,6,149,140,19,66,133,195,26,140,193,172,100,53,86,68,83,76,107,34,104,225,170,146,17,133,242,94,117,208,160,69,189,182,62,162,220,71,232,66,115,61,255,49,141,227,4,249,173,59,6,223,205,61,116,234,199,161,0,43,149,19,18,36,230,85,161,49,3,173,177,48,202,96,231,168,212,53,19,172,4,131,150,94,88,45,57,231,154,97,86,83,142,153,229,37,86,149,149,152,72,85,56,161,57,24,233,80,222,130,139,235,167,221,8,33,248,161,111,102,120,61,95,61,239,82,151,75,237,213,208,78,93,143,242,14,162,186,84,241,190,65,10,10,96,149,81,216,48,89,97,230,128,99,69,165,197,84,105,78,184,128,178,46,57,202,141,218,197,131,45,218,88,148,91,21,213,79,213,78,112,116,158,125,234,145,208,162,20,85,157,180,37,77,188,40,41,176,168,5,199,206,214,78,2,173,165,212,246,196,235,203,228,211,217,135,243,169,131,209,155,23,236,144,248,13,99,51,155,161,143,227,208,30,172,207,143,175,95,193,83,92,224,190,92,253,90,6,138,41,127,16,161,125,62,5,88,181,30,250,184,238,205,96,125,127,183,120,238,247,73,210,237,212,232,195,137,194,250,97,82,45,202,71,127,119,255,87,90,171,41,196,161,251,143,70,205,211,152,201,35,45,217,177,221,195,14,90,31,118,173,122,62,198,13,250,240,48,13,241,227,87,80,54,243,125,182,221,46,241,167,71,229,99,114,201,130,106,225,148,204,66,84,119,144,169,222,102,49,213,207,6,119,188,206,124,120,213,93,140,22,198,83,112,246,13,204,48,218,108,99,151,24,189,105,166,65,219,68,141,2,41,107,139,129,145,180,239,76,8,172,181,40,176,2,34,171,10,202,138,115,114,70,165,33,144,18,216,66,145,54,157,88,142,165,228,2,19,174,53,148,69,165,37,33,91,148,40,252,91,179,93,111,194,197,99,127,250,189,151,15,114,115,150,178,111,18,235,22,186,244,229,154,249,61,48,246,73,112,121,42,213,204,239,65,179,191,57,192,185,217,167,231,55,216,101,143,194,214,4,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })));
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

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, LeadManagementProceedToOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("6c6198b1-4959-4529-90ea-d61784ab5100");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,77,107,220,48,16,253,43,70,135,158,172,197,146,101,125,184,167,18,182,101,161,36,161,77,75,33,27,130,100,141,18,129,63,54,150,76,18,150,253,239,149,215,217,20,114,40,57,182,224,131,102,228,121,243,230,205,140,246,183,62,124,246,109,132,177,118,186,13,144,79,27,91,35,105,11,161,140,21,88,85,198,97,86,52,18,27,11,5,38,132,58,162,181,17,210,40,148,247,186,131,26,45,209,107,235,35,202,125,132,46,212,215,251,63,160,113,156,32,191,117,71,227,123,115,15,157,254,49,39,32,142,115,82,81,192,140,20,18,51,101,37,86,170,42,49,87,5,171,92,193,173,147,18,45,92,132,225,165,227,37,195,178,34,137,11,48,192,186,224,28,115,46,12,8,224,172,4,64,121,11,46,174,159,118,35,132,224,135,190,222,195,235,249,234,121,151,88,46,185,207,134,118,234,122,148,119,16,245,165,142,247,53,162,13,51,96,88,133,173,170,20,102,101,81,96,99,12,96,7,172,81,78,27,238,136,92,105,40,128,85,141,198,13,83,21,102,14,4,214,165,178,184,76,74,80,33,129,112,34,80,222,232,93,156,115,163,175,160,237,106,99,81,110,117,212,63,117,59,193,145,195,222,167,106,104,89,16,89,241,4,64,202,38,229,163,5,150,92,10,236,44,119,10,74,174,146,236,39,101,191,76,62,157,125,56,159,58,24,125,243,210,32,72,74,15,99,189,111,134,62,142,67,59,67,159,31,127,191,130,167,184,180,225,229,234,215,82,122,76,254,57,8,29,242,41,192,89,235,161,143,235,190,25,172,239,239,22,204,195,33,133,116,59,61,250,112,210,107,253,48,233,22,229,163,191,187,255,171,174,103,83,136,67,247,31,149,154,167,50,19,70,26,199,35,221,121,90,173,15,187,86,63,31,237,26,125,120,152,134,248,113,238,97,230,251,108,187,93,236,79,143,218,199,132,146,5,221,194,201,153,133,168,239,32,211,189,205,98,202,159,13,238,120,157,249,240,26,119,49,90,24,79,198,234,27,52,195,104,179,141,93,108,244,134,76,141,182,73,181,18,40,225,22,3,163,6,51,38,211,234,25,89,96,13,84,85,21,144,74,8,186,42,85,67,33,57,112,90,74,129,25,157,55,85,9,137,169,72,179,75,138,202,40,74,183,40,169,240,111,213,118,189,9,23,143,253,233,33,88,26,114,179,74,222,55,142,117,11,93,234,92,189,127,143,24,135,20,112,121,74,85,239,223,35,205,225,102,22,231,230,144,190,223,106,53,37,99,0,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 1;
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

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,1,0,242,67,189,42,2,0,0,0 })));
				}
				set {
					_aggregationColumnName = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,73,77,76,177,50,180,50,4,0,110,194,57,215,15,0,0,0 })));
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
								new Guid("1f66152e-4108-49d8-9953-69045f06df88")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("1f66152e-4108-49d8-9953-69045f06df88"));
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

		#region Class: AddDataUserTask1FlowElement

		/// <exclude/>
		public class AddDataUserTask1FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask1FlowElement(UserConnection userConnection, LeadManagementProceedToOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("a18a0492-a410-44aa-a45b-87d515dfd32c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)));
				_recordDefValues_Contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
				_recordDefValues_Status = () => (Guid)(new Guid("1f3ad326-effd-4ac3-a3e2-957e7def3684"));
				_recordDefValues_PaymentStatus = () => (Guid)(new Guid("bfe38d3d-bd57-48d7-a2d7-82435cd274ca"));
				_recordDefValues_DeliveryStatus = () => (Guid)(new Guid("867ca155-bfa5-4aaa-9172-7813dd4e85f5"));
				_recordDefValues_DeliveryType = () => (Guid)(new Guid("50df77d0-7b1f-4dbc-a02d-7b6ebb95dfd0"));
				_recordDefValues_PaymentType = () => (Guid)(new Guid("c2d88243-685d-4e8b-a533-73f4cb8e869b"));
				_recordDefValues_Date = () => (DateTime)(((DateTime)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentDate")));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Status", () => _recordDefValues_Status.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_PaymentStatus", () => _recordDefValues_PaymentStatus.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DeliveryStatus", () => _recordDefValues_DeliveryStatus.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DeliveryType", () => _recordDefValues_DeliveryType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_PaymentType", () => _recordDefValues_PaymentType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Date", () => _recordDefValues_Date.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Account;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_Status;
			internal Func<Guid> _recordDefValues_PaymentStatus;
			internal Func<Guid> _recordDefValues_DeliveryStatus;
			internal Func<Guid> _recordDefValues_DeliveryType;
			internal Func<Guid> _recordDefValues_PaymentType;
			internal Func<DateTime> _recordDefValues_Date;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,153,91,79,27,87,16,199,191,138,229,228,145,177,206,253,226,183,10,82,9,41,23,148,164,121,9,60,204,57,51,39,177,106,108,180,94,167,162,136,239,222,89,3,5,210,214,113,34,33,149,22,63,24,123,215,51,231,50,243,155,249,159,229,98,252,188,63,63,227,241,116,252,158,187,14,87,203,214,79,246,151,29,79,142,186,101,229,213,106,242,114,89,113,62,251,29,203,156,143,176,195,83,238,185,251,128,243,53,175,94,206,86,253,222,232,190,217,120,111,252,252,203,230,238,120,250,241,98,124,216,243,233,47,135,36,222,141,214,62,115,80,144,83,102,112,158,52,96,214,12,196,45,25,108,153,188,70,49,174,203,249,250,116,241,138,123,60,194,254,243,120,122,49,222,120,19,7,53,42,165,168,90,113,128,226,160,69,7,232,44,67,76,156,125,14,202,85,147,199,151,123,227,85,253,204,167,184,25,244,214,56,41,147,157,79,6,84,40,94,140,17,1,147,111,96,173,177,236,189,13,37,234,193,248,250,247,183,134,31,159,125,60,92,189,249,109,193,221,187,141,223,105,195,249,138,79,38,114,245,171,11,47,230,124,202,139,126,122,129,197,135,164,124,132,172,116,1,23,76,130,236,98,1,142,154,179,85,65,35,211,165,24,252,185,155,211,139,18,44,43,237,26,40,203,6,156,214,8,226,132,161,146,214,173,146,33,166,54,152,188,88,244,179,254,124,127,179,71,211,11,43,107,202,200,14,90,211,22,92,106,30,114,243,36,155,139,209,121,159,24,189,191,60,121,118,50,44,140,102,171,179,57,158,127,248,235,250,222,50,210,136,176,199,209,92,62,77,126,158,117,171,126,52,147,184,141,150,109,212,241,106,61,239,103,139,79,35,9,204,156,107,63,91,46,38,63,213,186,92,47,250,43,199,103,247,114,226,174,235,139,227,171,212,58,30,79,143,255,41,185,174,255,94,109,229,253,244,250,58,179,142,199,123,199,227,119,203,117,87,7,143,118,248,114,19,233,205,8,234,250,5,127,243,118,243,186,242,177,49,123,133,11,252,196,221,107,25,113,99,190,185,117,32,219,176,25,252,189,204,251,198,113,49,217,171,168,27,68,198,12,142,131,129,68,18,161,172,115,105,54,90,211,154,217,88,191,229,198,29,47,42,223,159,152,241,20,171,198,2,154,88,73,112,148,134,226,148,164,162,97,197,18,42,67,225,106,113,155,145,111,39,115,3,129,92,89,172,231,243,205,0,171,205,250,7,170,174,39,126,125,231,224,78,120,239,120,88,210,172,205,152,14,23,63,178,85,151,227,203,203,189,187,8,59,213,162,198,170,0,117,150,44,77,58,66,209,9,37,177,67,81,86,153,18,66,222,138,112,226,148,147,175,40,251,39,224,186,42,174,114,45,8,198,133,96,109,86,70,135,255,25,194,72,46,43,242,9,148,119,8,142,146,32,44,187,1,68,73,246,132,139,205,201,62,4,194,251,203,69,143,245,9,225,29,17,214,161,176,13,94,67,106,155,224,250,44,246,36,32,36,101,201,133,100,137,236,163,64,24,91,200,190,90,3,198,87,33,208,144,151,133,8,129,193,162,83,182,154,170,40,109,69,184,216,86,131,113,82,199,10,6,73,216,44,59,161,82,133,170,36,143,181,77,193,180,248,16,8,191,92,46,127,93,159,77,156,54,74,43,175,64,59,97,203,69,148,249,103,111,160,90,82,198,73,65,141,41,78,116,179,72,214,4,224,214,164,27,162,104,6,28,160,204,62,114,20,189,97,67,114,223,66,234,122,188,55,29,113,55,90,245,216,175,87,19,61,25,29,116,216,158,168,217,145,154,93,130,245,40,168,169,45,34,42,201,119,226,32,85,90,100,39,100,38,7,150,52,151,64,90,53,106,91,169,105,74,84,175,51,17,180,231,42,18,64,218,132,92,240,96,185,146,179,154,148,40,216,7,164,166,106,81,223,81,90,110,86,214,129,83,33,128,52,48,134,32,202,219,85,78,13,83,154,148,198,86,250,50,65,33,105,124,46,81,4,52,242,150,140,179,94,26,88,116,21,191,139,154,51,60,31,186,233,13,61,71,115,92,44,152,158,224,217,13,158,93,98,246,56,224,113,186,144,148,94,240,86,180,162,171,205,65,74,142,192,166,146,131,86,165,105,19,182,194,19,66,105,69,178,28,172,82,82,70,168,74,27,14,217,2,9,85,66,30,27,178,234,33,91,142,192,233,75,148,249,179,76,221,37,85,165,145,52,81,133,153,154,160,162,164,103,230,73,10,177,162,246,30,74,147,42,231,16,135,64,71,35,135,83,45,218,192,177,12,233,191,11,30,226,249,236,11,119,231,79,244,252,88,235,217,33,104,143,130,30,46,165,184,210,42,164,50,180,158,44,90,77,78,81,82,164,171,247,142,130,141,41,108,127,108,98,209,59,233,53,101,168,227,146,153,214,104,64,31,52,176,168,214,230,172,75,133,30,146,30,170,198,199,226,180,120,96,9,100,144,18,144,185,26,176,153,92,171,53,27,133,56,241,138,90,140,162,167,99,145,144,59,42,21,80,25,146,175,114,4,42,217,83,35,181,35,61,7,55,220,12,20,72,14,175,187,25,119,79,212,236,70,205,46,193,122,20,212,84,202,169,104,73,89,108,40,9,37,141,3,114,137,94,142,57,150,152,165,175,214,16,183,63,108,244,190,57,146,77,64,231,134,7,0,65,42,123,113,34,93,165,237,182,16,6,5,103,31,144,154,76,65,69,137,150,80,63,60,207,107,37,129,156,49,27,52,37,225,25,30,181,36,142,147,106,40,13,226,76,36,193,240,35,78,69,200,182,22,162,112,93,139,84,137,144,203,142,212,28,93,75,181,13,52,175,151,11,168,184,250,124,35,224,158,232,217,141,158,93,130,246,40,232,9,53,164,150,69,162,161,170,67,207,209,21,138,215,17,8,165,21,5,162,42,13,116,43,61,162,202,66,74,133,65,78,70,86,36,159,116,31,204,149,229,184,35,30,208,49,98,243,15,65,207,187,243,213,7,236,102,195,191,42,38,251,235,78,98,212,75,164,249,91,16,136,217,240,172,236,203,87,166,163,91,219,255,126,242,147,209,156,7,173,84,85,24,142,27,218,64,49,41,64,67,141,73,71,77,82,8,183,37,255,206,19,251,23,38,255,201,229,31,227,180,39,72,5,27,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "83ce9b125c1b43478e8d24010d4b812d",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("23109609-1650-4a4b-aecb-d0974c538074");
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, LeadManagementProceedToOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("bc3a0978-1caa-4f50-93e6-cbdbf05d9935");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Order = () => (Guid)((process.AddDataUserTask1.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Order", () => _recordColumnValues_Order.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Order;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,43,70,135,158,172,32,203,31,146,220,83,9,219,178,80,146,208,166,165,144,13,97,36,141,19,129,63,54,150,76,18,204,254,247,106,215,187,41,228,80,114,108,65,7,205,72,239,205,155,167,209,124,231,252,103,215,6,28,235,6,90,143,233,180,182,53,201,121,150,161,69,67,37,138,146,22,2,4,213,76,74,218,40,222,148,141,133,66,103,134,164,61,116,88,147,5,189,178,46,144,212,5,236,124,125,51,255,33,13,227,132,233,93,115,8,190,155,7,236,224,199,190,64,145,65,35,21,42,42,74,166,105,129,90,83,105,192,208,166,201,149,174,10,89,100,24,11,28,181,88,35,121,206,40,203,5,163,5,99,81,85,30,239,43,168,44,203,42,205,25,114,146,182,216,132,213,243,118,68,239,221,208,215,51,190,238,175,95,182,81,229,82,251,124,104,167,174,39,105,135,1,174,32,60,212,4,144,97,81,26,160,166,80,177,211,6,5,133,92,89,154,131,22,92,72,204,170,76,144,212,192,54,236,105,201,218,146,212,66,128,159,208,78,120,96,158,93,212,24,229,101,178,172,34,54,203,13,45,114,206,168,172,164,160,141,173,26,133,121,165,148,182,39,191,190,76,46,238,157,191,152,58,28,157,57,218,142,209,191,97,172,103,51,244,97,28,218,61,245,197,225,250,53,62,135,197,220,227,209,175,165,161,16,243,123,16,217,165,147,199,243,214,97,31,86,189,25,172,235,239,23,206,221,46,66,186,45,140,206,159,92,88,61,78,208,146,116,116,247,15,127,117,235,124,242,97,232,254,163,86,211,216,102,228,136,67,118,144,187,159,65,235,252,182,133,151,67,92,147,15,143,211,16,62,126,69,176,137,235,147,205,102,137,63,61,129,11,145,37,241,208,226,41,153,248,0,247,152,64,111,147,16,235,39,67,115,56,78,156,127,197,93,142,22,199,83,112,246,13,205,48,218,100,109,151,152,188,17,83,147,77,116,45,71,158,85,150,98,193,227,188,23,241,47,105,45,25,5,228,170,44,49,43,133,224,103,185,50,28,99,130,90,100,130,22,220,10,170,148,144,148,11,173,49,99,165,86,156,111,72,116,225,223,234,237,102,237,47,159,250,211,247,94,30,228,246,44,102,223,36,86,45,118,241,229,234,249,61,102,236,34,224,234,84,170,158,223,99,205,238,118,111,206,237,46,174,223,77,163,124,157,214,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,193,114,218,48,16,253,21,70,201,17,49,146,37,217,146,175,73,15,204,36,45,211,164,185,0,135,181,180,106,152,49,54,35,155,118,82,198,255,94,33,32,64,218,94,170,131,109,237,234,189,183,218,125,222,145,219,254,109,131,164,36,207,24,2,116,173,239,39,119,109,192,201,44,180,22,187,110,242,208,90,168,87,191,160,170,113,6,1,214,216,99,120,129,122,139,221,195,170,235,199,163,107,24,25,147,219,31,41,75,202,249,142,76,123,92,127,155,186,200,174,145,105,148,85,65,149,119,156,202,138,123,10,204,231,148,161,183,76,10,134,50,147,17,108,219,122,187,110,30,177,135,25,244,175,164,220,145,196,22,9,114,103,29,19,76,82,172,92,78,37,50,78,181,99,134,22,104,16,157,81,86,59,36,195,152,116,246,21,215,144,68,207,96,201,193,107,131,241,180,98,85,4,87,21,213,22,44,245,94,152,42,151,90,114,180,123,240,241,252,25,56,191,153,79,187,47,63,27,12,79,137,183,244,80,119,184,156,196,232,135,192,167,26,215,216,244,229,14,184,6,38,77,70,65,114,70,165,4,136,95,42,10,22,78,113,229,188,19,153,29,34,224,189,155,229,174,176,38,103,70,75,202,36,67,42,185,116,212,112,129,212,106,204,11,14,188,80,86,12,203,155,229,190,68,183,234,54,53,188,189,252,89,233,93,64,232,113,212,6,135,97,114,216,184,81,64,27,3,163,169,59,160,55,87,35,188,196,239,22,7,39,44,72,185,248,151,23,142,239,195,205,175,221,240,209,8,11,50,94,144,167,118,27,236,158,81,236,55,167,193,36,5,118,92,244,47,143,211,58,112,36,216,35,52,240,29,195,231,168,152,224,41,117,15,61,36,241,231,88,247,137,184,202,140,98,69,180,87,129,96,226,168,243,44,250,132,67,108,168,169,188,40,68,230,125,150,208,95,209,99,192,198,226,117,97,154,101,70,42,157,81,150,87,138,74,191,31,159,86,158,10,145,9,84,74,228,85,193,19,62,41,159,139,57,121,54,70,154,109,93,39,129,46,221,127,255,19,28,11,63,102,238,47,102,120,193,208,186,149,95,161,155,54,255,211,170,129,12,195,114,248,13,122,227,156,213,207,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "83ce9b125c1b43478e8d24010d4b812d",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("23109609-1650-4a4b-aecb-d0974c538074");
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

		#region Class: OpenEditPageUserTask1FlowElement

		/// <exclude/>
		public class OpenEditPageUserTask1FlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, LeadManagementProceedToOrder process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("d782fcdc-1a7b-4377-afb4-3feb6efac43d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_recordId = () => (Guid)((process.AddDataUserTask1.RecordId));
				_ownerId = () => (Guid)((process.ActivityOwner));
				_lead = () => (Guid)((process.LeadId));
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("QualifiedAccount").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("QualifiedAccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("QualifiedContact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("QualifiedContactId") : Guid.Empty)));
				_order = () => (Guid)((process.NewOrder));
			}

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("23d86ac4-1d23-4314-a5e3-5da5e61b495a");
			public override Guid PageSchemaId {
				get {
					return _pageSchemaId;
				}
				set {
					_pageSchemaId = value;
				}
			}

			private int _editMode = 1;
			public override int EditMode {
				get {
					return _editMode;
				}
				set {
					_editMode = value;
				}
			}

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			private bool _isMatchConditions = false;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private bool _generateDecisionsFromColumn = false;
			public override bool GenerateDecisionsFromColumn {
				get {
					return _generateDecisionsFromColumn;
				}
				set {
					_generateDecisionsFromColumn = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("83ce9b125c1b43478e8d24010d4b812d",
						 "BaseElements.OpenEditPageUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
				}
			}

			private int _duration = 5;
			public override int Duration {
				get {
					return _duration;
				}
				set {
					_duration = value;
				}
			}

			private int _durationPeriod = 0;
			public override int DurationPeriod {
				get {
					return _durationPeriod;
				}
				set {
					_durationPeriod = value;
				}
			}

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
				}
			}

			private int _remindBefore = 1;
			public override int RemindBefore {
				get {
					return _remindBefore;
				}
				set {
					_remindBefore = value;
				}
			}

			private int _remindBeforePeriod = 0;
			public override int RemindBeforePeriod {
				get {
					return _remindBeforePeriod;
				}
				set {
					_remindBeforePeriod = value;
				}
			}

			private bool _showInScheduler = true;
			public override bool ShowInScheduler {
				get {
					return _showInScheduler;
				}
				set {
					_showInScheduler = value;
				}
			}

			private bool _showExecutionPage = true;
			public override bool ShowExecutionPage {
				get {
					return _showExecutionPage;
				}
				set {
					_showExecutionPage = value;
				}
			}

			internal Func<Guid> _lead;
			public override Guid Lead {
				get {
					return (_lead ?? (_lead = () => Guid.Empty)).Invoke();
				}
				set {
					_lead = () => { return value; };
				}
			}

			internal Func<Guid> _account;
			public override Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<Guid> _contact;
			public override Guid Contact {
				get {
					return (_contact ?? (_contact = () => Guid.Empty)).Invoke();
				}
				set {
					_contact = () => { return value; };
				}
			}

			internal Func<Guid> _order;
			public override Guid Order {
				get {
					return (_order ?? (_order = () => Guid.Empty)).Invoke();
				}
				set {
					_order = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		public LeadManagementProceedToOrder(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementProceedToOrder";
			SchemaUId = new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_leadId = () => { return (Guid)((StartSignal1.RecordId)); };
			_activityOwner = () => { return (Guid)(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty))); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("83ce9b12-5c1b-4347-8e8d-24010d4b812d");
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		public virtual Guid NewOrder {
			get;
			set;
		}

		private Func<Guid> _leadId;
		public virtual Guid LeadId {
			get {
				return (_leadId ?? (_leadId = () => Guid.Empty)).Invoke();
			}
			set {
				_leadId = () => { return value; };
			}
		}

		private Func<Guid> _activityOwner;
		public virtual Guid ActivityOwner {
			get {
				return (_activityOwner ?? (_activityOwner = () => Guid.Empty)).Invoke();
			}
			set {
				_activityOwner = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("36a74fd9-906b-4e48-b36f-eeba6b29c35b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal1;
		public ProcessStartSignalEvent StartSignal1 {
			get {
				return _startSignal1 ?? (_startSignal1 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal1",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("233e216d-e42b-4488-bb80-ae2955e15772"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("69c15883-6503-4463-a254-378cf5b5f503"),
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

		private ProcessTerminateEvent _terminateEvent1;
		public ProcessTerminateEvent TerminateEvent1 {
			get {
				return _terminateEvent1 ?? (_terminateEvent1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1",
					SchemaElementUId = new Guid("6b2d1b2d-8ccf-4962-9073-d5cecdf6c2dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("17207bea-f7f4-4e1c-85ee-b5f4af812e1c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
				});
			}
		}

		private OpenEditPageUserTask1FlowElement _openEditPageUserTask1;
		public OpenEditPageUserTask1FlowElement OpenEditPageUserTask1 {
			get {
				return _openEditPageUserTask1 ?? (_openEditPageUserTask1 = new OpenEditPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask1;
		public ProcessScriptTask FormulaTask1 {
			get {
				return _formulaTask1 ?? (_formulaTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask1",
					SchemaElementUId = new Guid("42c40f4d-fcc3-47cb-a47f-beee84ae882d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayUseProduct;
		public ProcessExclusiveGateway ExclusiveGatewayUseProduct {
			get {
				return _exclusiveGatewayUseProduct ?? (_exclusiveGatewayUseProduct = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayUseProduct",
					SchemaElementUId = new Guid("951af993-3900-4618-9898-be413728166b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayUseProduct.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayContainsOwner;
		public ProcessExclusiveGateway ExclusiveGatewayContainsOwner {
			get {
				return _exclusiveGatewayContainsOwner ?? (_exclusiveGatewayContainsOwner = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayContainsOwner",
					SchemaElementUId = new Guid("98e1d81a-4d06-4707-96b1-d201519c7ee1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayContainsOwner.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _formulaTask2;
		public ProcessScriptTask FormulaTask2 {
			get {
				return _formulaTask2 ?? (_formulaTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask2",
					SchemaElementUId = new Guid("640f47a7-f8d1-43b2-a576-7e45f8aa3dd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask2Execute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow1;
		public ProcessConditionalFlow ConditionalSequenceFlow1 {
			get {
				return _conditionalSequenceFlow1 ?? (_conditionalSequenceFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1",
					SchemaElementUId = new Guid("a7178c4c-176e-442c-bd14-a31bac9eaac7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow2;
		public ProcessConditionalFlow ConditionalSequenceFlow2 {
			get {
				return _conditionalSequenceFlow2 ?? (_conditionalSequenceFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow2",
					SchemaElementUId = new Guid("2464e066-7e89-42fe-a792-c0681c0223a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow4;
		public ProcessConditionalFlow ConditionalSequenceFlow4 {
			get {
				return _conditionalSequenceFlow4 ?? (_conditionalSequenceFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow4",
					SchemaElementUId = new Guid("b57d3370-16d1-44e5-8e6f-851093a1cab2"),
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
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[ExclusiveGatewayUseProduct.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayUseProduct };
			FlowElements[ExclusiveGatewayContainsOwner.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayContainsOwner };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayContainsOwner", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
					case "OpenEditPageUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "ExclusiveGatewayUseProduct":
						if (ConditionalSequenceFlow2ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
					case "ExclusiveGatewayContainsOwner":
						if (ConditionalSequenceFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayUseProduct", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayUseProduct", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			return Convert.ToBoolean((StartSignal1.RecordId) != Guid.Empty);
		}

		private bool ConditionalSequenceFlow2ExpressionExecute() {
			return Convert.ToBoolean((ReadDataUserTask2.ResultCount) > 0);
		}

		private bool ConditionalSequenceFlow4ExpressionExecute() {
			return Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)) != Guid.Empty);
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("NewOrder")) {
				writer.WriteValue("NewOrder", NewOrder, Guid.Empty);
			}
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("ActivityOwner")) {
				writer.WriteValue("ActivityOwner", ActivityOwner, Guid.Empty);
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
			MetaPathParameterValues.Add("2a65c94d-ad96-4e1a-8678-3223fff78f0d", () => NewOrder);
			MetaPathParameterValues.Add("3dad7563-c615-43f4-ad63-595693663fd7", () => LeadId);
			MetaPathParameterValues.Add("56720a3e-4608-4bb3-8953-ed86f7f2fb7b", () => ActivityOwner);
			MetaPathParameterValues.Add("39c2ee29-de07-42d7-9978-27bbe105b922", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("51e58f82-c660-4f51-a482-2e47790531e4", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("72785b41-22fc-440b-9e25-09541a823da1", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("ba95284a-479c-4695-b20e-f63e9d809aef", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("9cfa6a66-c948-435e-a77c-ce3c093762b0", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("38ad1df5-1e23-417a-b816-604ee5ebd463", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("43a2921d-cbf9-4ccf-9e18-3b7e690771cf", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("b56a9823-aa72-425f-bd71-e269cc7c6b9e", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("b63e014f-03e2-411a-b56e-cd11fcd2dedf", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("c5ddbc71-2bb8-4428-9200-8670e0c41529", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("39c0f849-1bbe-41f7-a8ec-60baac586e9d", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("362c2b06-2632-4385-811f-5d44097aba94", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("f78dac62-b855-47c2-98b1-8d7452f88518", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("dbb1f233-5174-43e1-b1c7-d09d994ca216", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("1156c6f8-f42f-40e6-aabd-037e9316c30f", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("f91976d0-6fa2-4bfa-aa99-75e535e05b15", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("f0036525-a88d-4f8f-9e33-96275cc4add9", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("21c581af-6689-4593-83b0-ade1bc6ace04", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("1c841b42-21d7-449c-9c25-e5d9006c569c", () => ReadDataUserTask1.ResultCompositeObjectList);
			MetaPathParameterValues.Add("a849651b-3c94-415e-8f28-495c77cb69c2", () => ReadDataUserTask1.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("233422b6-ee14-4a8a-ba4e-5872f8b8c777", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("0e73147b-3fca-4520-ae87-958d8a954ecb", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("4741dc21-15cb-41c2-8680-9e717f617814", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("1830ecce-1fbf-4a1d-927b-835b4390eef4", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("be29adc6-c305-4fb0-b446-ae26278a5cf6", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("4fd6ce9f-f292-41a0-a8ba-d343dfc9cb25", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("f5c8e8e8-ec65-413b-b1ef-1e44cb614020", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("83189d35-e077-4319-b18e-c6f2b2393707", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("17afe864-aaad-4c4e-ad01-768cbd0e842d", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("53363eca-d6fd-4903-a89f-afc707231e89", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("2d30b140-c803-410d-99de-46fefa3903f9", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("e8a3eb91-0b0d-419f-8a07-a279783a4aed", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("9e8fe1c5-61e9-4c8c-93e5-05ed37a5a23b", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("de74e707-3683-47dc-acb1-0620c233b644", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("6afe29bc-36f3-4e7b-a2a6-ed65c01eaae2", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("77c33b50-7f50-4a1e-846b-d24d080ce656", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("abe22acf-b177-4dbf-a6d4-52b190f66261", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("a36f8fca-865d-4aa4-8cc3-db83862aa504", () => ReadDataUserTask2.ResultCompositeObjectList);
			MetaPathParameterValues.Add("d1cd5032-a015-49e6-8905-762ec1677544", () => ReadDataUserTask2.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("28914bf3-2c8b-4583-b644-625e18978559", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("c1ffede0-fe00-42d9-a867-6030c7ce74a0", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("86435d98-74c1-4ada-b6e5-22961dde1a37", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("1f919ca3-5929-45db-98dd-c0fa939af046", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("9b610c3e-7085-4d3f-963b-b33fd03a0d68", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("7c960984-040e-414d-913e-c8e671a175c3", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("3a8fb70e-eb46-4374-ad70-c1d1df862c33", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("ed01677f-c36f-4d12-bdce-2d077bf60563", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("a6c6ca26-ca85-48d8-aa3f-ea21bffa2172", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("b2c3e896-818e-48fd-bd84-3c8320d25e1a", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("ae68593e-fa7c-4048-b895-2278f193bf56", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("660ef167-9f42-438e-8e32-a0abcc62314c", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("7df2eca1-dc6c-4087-9840-bee0cc1e644b", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("f101f976-de4b-4470-b288-dc04974ea7d9", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("6cff8c4f-e5db-4f8a-aa7a-f5ac4428b6ea", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("e5ec6ce6-b474-4ec1-956c-dfb129b1a5ce", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("b956b76e-964d-46ce-823f-beb59ae28699", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("00eecca3-2d14-485a-8a8d-eb397d8ffbe8", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("bdac390a-ff58-46a2-907b-14a0c0565f2d", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("f6bbd23d-5104-4c79-9ac8-67b6d9a5d3bd", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("a7ec73e2-62cc-4a89-a496-e288aec50bdd", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("07ade664-1878-4494-93a7-397c9d9a6ba7", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("a25f8f25-a5bc-45f5-a3af-e84d2a250555", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("c5bf469a-ca79-4c27-93c4-428493383a2b", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("109924be-1b7d-46bd-8855-110f7046c49a", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("44c80af5-265f-4ca1-8c98-78e4479635ae", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("c2f936e7-236a-4f61-9aa8-1cadbac9d2fd", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("2983e005-8470-45c9-be2e-d84d93a53203", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("61ea02d3-de9d-4459-b975-072fcd9eff4e", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("c610af2b-9150-43b8-aa79-239e85143fb7", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("41ec49be-7cd4-437d-910a-78a49a359978", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("16cb3b84-997b-460f-931d-69d58bf053af", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("9060fb85-9faf-4a13-809f-40fd6d37daa4", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("3ca71ac5-ea92-4f42-a671-9da656bf2653", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("1e40cbb6-dc33-43c4-907a-c06736c03f8c", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("42b3fc94-7228-4d8e-a9a0-44a7c7f1a17f", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("68804ba6-68d6-4d9a-8543-e1311e13aa63", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("dba832e4-be08-4c39-a60b-c029abee42d9", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("24b1894d-cb19-4761-95a7-21945965fd96", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("79b75417-25b2-4638-9fc0-4ba8602c8164", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("493d3b26-b741-456e-a4a9-1660de4605f1", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("1b88a7ef-d511-4681-afe2-7e7af45479bb", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("b8c8487c-7ec9-4fd7-8382-45adcafaa80a", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("9bba3ff9-9d5d-49eb-9944-5a24a927c8ee", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("02d10657-558f-4de5-bc41-185610ee3c4e", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("9ddc804c-6acd-4c8d-abf1-0a89835fc9f5", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("0f985d04-5e4c-4f3f-8bb9-7b29315ceede", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("17fa3835-9993-4c3b-910d-6fb4b4eb8ab5", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("1ea2f7f3-5e09-433d-a01f-16a9ece5d11f", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("2e83dfcb-d1d1-445a-9f96-e47984017cff", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("fae4b282-9884-4e09-9382-4e83f9cec633", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("985510b3-2488-477a-a863-3ebb94e621e1", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("38999ad9-2ac8-48c0-8d33-55e204924212", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("fa4a8316-c6cc-40b6-8c02-edb5ba71cba1", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("26e8d57d-215d-4749-8846-746c59eb9b24", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("cbc1205a-31ec-4838-8fc9-aef608dfbee4", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("f54e7ee6-df35-43bf-a417-1b4b63aa77d4", () => OpenEditPageUserTask1.Project);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "NewOrder":
					if (!hasValueToRead) break;
					NewOrder = reader.GetValue<System.Guid>();
				break;
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "ActivityOwner":
					if (!hasValueToRead) break;
					ActivityOwner = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
				bool priceWithTaxes = Terrasoft.Core.Configuration.SysSettings.GetValue<bool>(UserConnection, "PriceWithTaxes",
					false);
				decimal taxPercent;
				decimal taxAmount;
				decimal totalAmount;
				var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager.GetInstanceByName("LeadProduct"));
				esq.AddColumn("Product.Name");
				esq.AddColumn("Product.Unit");
				esq.AddColumn("Product.Tax");
				esq.AddColumn("Product.Tax.Percent");
				esq.AddColumn("Product.Price");
				esq.AddColumn("Product.Id");
				esq.AddColumn("Product.Currency");
				esq.AddColumn("Product");
				esq.AddColumn("[ProductUnit:Product:Product].NumberOfBaseUnits");
				esq.AddColumn("[ProductUnit:Product:Product].Unit");
				esq.Filters.Add(esq.CreateFilterWithParameters(
					FilterComparisonType.Equal, "Lead", LeadId));
				var products = esq.GetEntityCollection(UserConnection);
				if (products.Count > 0) {
					var entitySchemaManager = UserConnection.EntitySchemaManager;
					var primaryCurrencyId = Terrasoft.Core.Configuration.SysSettings.GetValue<Guid>(UserConnection, 
						"PrimaryCurrency", Guid.Empty);
					var currencyRateStorage = ClassFactory.Get<CurrencyRateStorage>(new ConstructorArgument("userConnection", 
						UserConnection));
					var currencyRateConverter = ClassFactory.Get<CurrencyConverter>(new ConstructorArgument("currenciesRateStorage", 
						currencyRateStorage));
					var orderProductSchema = entitySchemaManager.GetInstanceByName("OrderProduct");
					var currentUserDateTime = UserConnection.CurrentUser.GetCurrentDateTime();
					foreach (var product in products) {
						Guid productCurrencyId = product.GetTypedColumnValue<Guid>("Product_CurrencyId");
						decimal price = product.GetTypedColumnValue<decimal>("Product_Price");
						if (!productCurrencyId.Equals(primaryCurrencyId)) {
							price = currencyRateConverter.GetConvertedAmountToCurrency(productCurrencyId, 
								primaryCurrencyId, price, currentUserDateTime);
						}
						taxPercent = (decimal)product.GetColumnValue("Product_Tax_Percent");
						var orderProductEntity = orderProductSchema.CreateEntity(UserConnection);
						orderProductEntity.SetColumnValue("Name", product.GetTypedColumnValue<string>("Product_Name"));
						orderProductEntity.SetColumnValue("ProductId", product.GetTypedColumnValue<Guid>("Product_Id"));
						orderProductEntity.SetColumnValue("UnitId", product.GetTypedColumnValue<Guid>("ProductUnit_Product_Product_UnitId"));
						orderProductEntity.SetColumnValue("BaseQuantity", product.GetTypedColumnValue<decimal>("ProductUnit_Product_Product_NumberOfBaseUnits"));
						orderProductEntity.SetColumnValue("TaxId", product.GetTypedColumnValue<Guid>("Product_TaxId"));
						orderProductEntity.SetColumnValue("OrderId", NewOrder);
						orderProductEntity.SetColumnValue("Quantity", Decimal.One);
						orderProductEntity.SetColumnValue("PrimaryPrice", price);
						orderProductEntity.SetColumnValue("Price", price);
						orderProductEntity.SetColumnValue("Amount", price);
						orderProductEntity.SetColumnValue("PrimaryAmount", price);
						orderProductEntity.SetColumnValue("DiscountAmount", 0);
						orderProductEntity.SetColumnValue("CurrencyId", primaryCurrencyId);
						orderProductEntity.SetColumnValue("CurrencyRate", 1);
						orderProductEntity.SetColumnValue("DiscountTax", taxPercent);
						if (priceWithTaxes) {
							orderProductEntity.SetColumnValue("PrimaryTotalAmount", price);
							orderProductEntity.SetColumnValue("TotalAmount", price);
							taxAmount = (taxPercent * price) / (100 + taxPercent);
						} else {
							taxAmount = (price * taxPercent) / 100;
							totalAmount = price + taxAmount;
							orderProductEntity.SetColumnValue("PrimaryTotalAmount", totalAmount);
							orderProductEntity.SetColumnValue("TotalAmount", totalAmount);
						}
						orderProductEntity.SetColumnValue("TaxAmount", taxAmount);
						if (!productCurrencyId.Equals(primaryCurrencyId)) {
							decimal primaryTaxAmount = currencyRateConverter.GetConvertedAmountToCurrency(
								primaryCurrencyId, productCurrencyId, taxAmount, currentUserDateTime);
							orderProductEntity.SetColumnValue("PrimaryTaxAmount", primaryTaxAmount);
						} else {
							orderProductEntity.SetColumnValue("PrimaryTaxAmount", taxAmount);
						}
						orderProductEntity.Save(false);
					}
				}
			return true;
		}

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localNewOrder = (AddDataUserTask1.RecordId);
			NewOrder = (System.Guid)localNewOrder;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localActivityOwner = ((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty));
			ActivityOwner = (System.Guid)localActivityOwner;
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
			var cloneItem = (LeadManagementProceedToOrder)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

