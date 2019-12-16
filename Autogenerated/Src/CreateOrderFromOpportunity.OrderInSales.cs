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

	#region Class: CreateOrderFromOpportunitySchema

	/// <exclude/>
	public class CreateOrderFromOpportunitySchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public CreateOrderFromOpportunitySchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public CreateOrderFromOpportunitySchema(CreateOrderFromOpportunitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CreateOrderFromOpportunity";
			UId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5");
			CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"CreateOrderFromOpportunity";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5");
			Version = 0;
			PackageUId = new Guid("b8e3670d-40ce-4674-8aa5-3d4805a5932d");
		}

		protected virtual ProcessSchemaParameter CreateCurrentOpportunityParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("515496b8-401a-4a70-b54d-64bfd7124238"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"CurrentOpportunity",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewOrderParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d828a3fe-e2a4-4160-a91c-92ab92b04cfc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"NewOrder",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateProductItemsParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("6c324739-8a48-4082-998b-fa670868c7ce"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"ProductItems",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCopyAllProductParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d7f0950e-8bc1-4a4d-b695-906d525716a4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"IsCopyAllProduct",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCurrentOpportunityParameter());
			Parameters.Add(CreateNewOrderParameter());
			Parameters.Add(CreateProductItemsParameter());
			Parameters.Add(CreateIsCopyAllProductParameter());
		}

		protected virtual void InitializeReadDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e1d83148-df86-4cc1-810a-5310eb1688e8"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,89,178,108,185,199,101,91,246,146,6,154,150,66,178,132,103,233,41,43,240,87,108,137,102,49,251,223,43,175,119,83,200,161,20,122,42,232,32,61,105,230,205,12,79,243,163,155,62,185,198,227,88,89,104,38,76,194,206,84,164,214,89,137,194,112,202,132,224,84,40,166,169,82,25,82,0,37,121,97,101,46,5,35,73,7,45,86,100,69,111,141,243,36,113,30,219,169,186,159,127,147,250,49,96,242,104,207,135,175,250,128,45,124,91,26,0,10,105,235,178,160,58,205,52,21,128,37,5,195,25,5,149,113,109,140,82,66,91,114,209,2,10,148,85,64,85,142,150,10,107,51,10,34,151,148,165,42,23,58,205,69,42,12,73,26,180,126,251,50,140,56,77,174,239,170,25,95,247,119,199,33,170,92,123,111,250,38,180,29,73,90,244,112,11,254,176,8,73,81,228,26,168,22,42,143,236,88,80,224,202,80,14,117,145,21,37,50,201,10,146,104,24,252,66,75,118,177,149,1,15,223,161,9,120,102,158,93,212,152,241,148,149,185,140,88,198,163,29,158,165,180,148,209,157,53,210,42,228,82,169,218,92,243,250,28,92,220,187,233,38,180,56,58,125,137,29,99,126,253,88,205,186,239,252,216,55,11,245,205,249,249,29,190,248,53,220,203,213,143,213,144,143,245,5,68,78,73,152,112,211,56,236,252,182,211,189,113,221,211,202,121,58,69,72,59,192,232,166,107,10,219,231,0,13,73,70,247,116,248,99,90,155,48,249,190,253,143,172,38,209,102,228,136,67,118,150,187,204,160,113,211,208,192,241,124,174,200,251,231,208,251,143,155,48,142,17,252,174,31,134,126,244,161,115,254,184,94,144,55,4,21,121,32,57,203,133,146,117,73,69,202,32,206,104,145,210,58,23,134,74,81,91,83,176,76,100,188,124,32,81,212,191,183,186,223,77,95,126,118,215,31,178,122,218,127,136,213,55,133,219,43,178,154,255,70,221,105,191,232,219,159,226,250,5,148,137,196,6,232,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3898f5c3-ee0f-45d0-95ac-9cd9a0d94564"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			resultTypeParameter.SourceValue = new ProcessSchemaParameterValue(resultTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cea4bbf0-8f34-4f22-ab35-9a44c8f81e1e"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			readSomeTopRecordsParameter.SourceValue = new ProcessSchemaParameterValue(readSomeTopRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f5a484b3-8778-45a8-abde-f587d34577ef"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			numberOfRecordsParameter.SourceValue = new ProcessSchemaParameterValue(numberOfRecordsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ebe4df04-3e0e-419e-833f-8e94cd7d6497"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			functionTypeParameter.SourceValue = new ProcessSchemaParameterValue(functionTypeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c2db847b-3042-4668-bddd-dc4935ba4078"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				UId = new Guid("f824e334-f632-4f09-a820-7cf5de24447a"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			orderInfoParameter.SourceValue = new ProcessSchemaParameterValue(orderInfoParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,180,50,212,241,76,177,50,176,50,0,0,169,240,29,88,16,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("9809e6b3-5ddb-4caf-aa53-a91b85840985"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2d44e8b3-9be9-44d9-989e-801007f332a2"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				UId = new Guid("af44f78e-77ce-4e84-89aa-a4a8589acaca"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				UId = new Guid("a3bbda1d-938c-4804-bae7-3e6727495500"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				UId = new Guid("d90e7819-b5bb-4322-b1a1-688430cac361"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				UId = new Guid("adbeddd4-1b47-439f-b56f-eaf1ce7c22bd"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				UId = new Guid("1f3ec804-485b-4fb7-ba6c-b97ab3bcb1a8"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("44077e26-c243-4885-bf41-802b99ca00f2"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityCollectionDataValueType")
			};
			resultEntityCollectionParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityCollectionParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("87d3453d-f7b9-41d7-953c-1ce1e1ade596"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			entityColumnMetaPathesParameter.SourceValue = new ProcessSchemaParameterValue(entityColumnMetaPathesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8e68ae20-c6e7-4bff-bc6f-c7c1e2476fe2"),
				ContainerUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
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
		}

		protected virtual void InitializeOpenEditPageUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var objectSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("4fb1e2ff-2cc4-4788-bae0-e74102fa14e8"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			objectSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(objectSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"80294582-06b5-4faa-a85f-3323e5536b71",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(objectSchemaIdParameter);
			var pageSchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("30aa1c24-3e58-45a3-a546-cdf3bedb9b62"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			pageSchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(pageSchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"23d86ac4-1d23-4314-a5e3-5da5e61b495a",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(pageSchemaIdParameter);
			var editModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c831eecc-a5e6-4e9b-8f0a-6d639e5e35fb"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			editModeParameter.SourceValue = new ProcessSchemaParameterValue(editModeParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"1",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(editModeParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("874c268f-6319-4d17-ad59-f40c4f774b05"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,171,86,82,41,169,44,72,85,178,82,10,73,45,42,74,44,206,79,43,209,115,206,47,74,213,11,40,202,79,78,45,46,214,243,201,79,78,204,201,172,74,76,202,73,13,72,44,74,204,77,45,73,45,10,75,204,41,77,45,246,201,44,46,209,81,64,213,166,164,163,164,82,6,150,85,178,138,142,173,5,0,199,127,71,237,94,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				UId = new Guid("01172481-a565-47df-a5be-cb9da2fc12a3"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d828a3fe-e2a4-4160-a91c-92ab92b04cfc}]#]",
				MetaPath = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d828a3fe-e2a4-4160-a91c-92ab92b04cfc}]#]",
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var executedModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("30f2bca3-c96e-4e5c-88c8-085b0ae8cf0d"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("1408b6b8-cf8c-4425-b12e-fbad9c403b3d"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"false",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c7f158e2-218b-4b9f-8725-909927e9b8b5"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var generateDecisionsFromColumnParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3d20f3f7-5984-43c4-9f1d-394a5d9dc018"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			generateDecisionsFromColumnParameter.SourceValue = new ProcessSchemaParameterValue(generateDecisionsFromColumnParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(generateDecisionsFromColumnParameter);
			var decisionalColumnMetaPathParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e46b1b8b-1819-4789-a14f-65ddf3741c3b"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			decisionalColumnMetaPathParameter.SourceValue = new ProcessSchemaParameterValue(decisionalColumnMetaPathParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(decisionalColumnMetaPathParameter);
			var resultParameterParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ab96af1a-57c8-4824-96f8-6ba447e62e14"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("2450b4ac-bc00-4be2-9f76-e7e372ca7f07"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("67908e65-2f58-45f9-983b-2c1da6379cd5"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType")
			};
			recommendationParameter.SourceValue = new ProcessSchemaParameterValue(recommendationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(recommendationParameter);
			var activityCategoryParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("961e2086-a12b-4d27-b095-40b1e64d6cc0"),
				UId = new Guid("4dea05bc-b597-4eb2-8f8e-707838c63a9e"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("08b712e2-4919-4423-b244-28f0ab6e324e"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			ownerIdParameter.SourceValue = new ProcessSchemaParameterValue(ownerIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(ownerIdParameter);
			var durationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a4574b01-f7d9-4d5b-b3e8-504a67746654"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationParameter.SourceValue = new ProcessSchemaParameterValue(durationParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"5",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(durationParameter);
			var durationPeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("69a2aa31-7c0d-4a87-9dba-2547b60626e5"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			durationPeriodParameter.SourceValue = new ProcessSchemaParameterValue(durationPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(durationPeriodParameter);
			var startInParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f9f8a922-41df-4718-9bb2-5709eef02ce4"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("d01eb000-e5aa-49b1-a95c-82a0dbd4a4a8"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startInPeriodParameter.SourceValue = new ProcessSchemaParameterValue(startInPeriodParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(startInPeriodParameter);
			var remindBeforeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("540dcd0c-778c-4a17-ac36-7def92eab44c"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforeParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforeParameter);
			var remindBeforePeriodParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6ba4e133-0564-4f7f-91ad-971ae82a9e2d"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			remindBeforePeriodParameter.SourceValue = new ProcessSchemaParameterValue(remindBeforePeriodParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(remindBeforePeriodParameter);
			var showInSchedulerParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3e4d0ff6-c547-4b65-ad49-292460443cd8"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showInSchedulerParameter.SourceValue = new ProcessSchemaParameterValue(showInSchedulerParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"False",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(showInSchedulerParameter);
			var showExecutionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("73d80e1b-1dc6-4b92-92e4-c0ff21953dad"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showExecutionPageParameter.SourceValue = new ProcessSchemaParameterValue(showExecutionPageParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae")
			};
			parametrizedElement.Parameters.Add(showExecutionPageParameter);
			var leadParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("5d24cbb8-ba27-4390-9faf-4ac736c965fe"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadParameter.SourceValue = new ProcessSchemaParameterValue(leadParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(leadParameter);
			var accountParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("f6a640ee-aeff-4e52-a0ef-83b05ca53c8c"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountParameter.SourceValue = new ProcessSchemaParameterValue(accountParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(accountParameter);
			var contactParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("71ebff1e-d62b-43b6-9539-02c2dffd16a2"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactParameter.SourceValue = new ProcessSchemaParameterValue(contactParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(contactParameter);
			var opportunityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				UId = new Guid("c29a5757-0505-47ee-b548-5293e3acbd89"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("d6fc85c9-a2f4-455e-b336-fa9b65be5720"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("13610d95-0021-419e-88ad-79b772cbba42"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("e4606663-de9c-46d9-8891-543f07160143"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("89f85502-0eb1-4d21-9eaa-96ebe6cf07ff"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("b9d6544d-94ae-49b4-af5c-ec4c5ed0dc76"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("30207a75-7e4e-4522-904b-474a8b804296"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("1c1730bc-905c-42f3-add5-b5767a8cc78c"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("251964b1-f33f-4a0d-bf37-4b2a62a2a899"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("29a2680c-fd32-4012-916a-2548fffff631"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			pageTypeUIdParameter.SourceValue = new ProcessSchemaParameterValue(pageTypeUIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(pageTypeUIdParameter);
			var activitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b9101517-77b1-4251-8334-6c0beefd8041"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("88dfbdf6-104a-448e-8a68-5256a4d8de7d"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("bcaeafa8-ef4e-4977-81f8-d000782ce97f"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			orderParameter.SourceValue = new ProcessSchemaParameterValue(orderParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(orderParameter);
			var requestsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5da83713-07c4-4e79-9df3-1e7de802bcee"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("fa6dc17d-dd86-43d4-b71a-1d6b901489b5"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("eb233771-7ac3-4db6-aa21-e29355f9b0f1"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("975dc8f2-6321-4417-9c7b-bd02cf1f0781"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("b3793aa7-c2bf-4f7e-ba51-134097f27019"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("2d39a734-7bc1-4c2e-b145-d00733f01f98"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("e4f8491d-13aa-43d4-b1a6-366538d33a50"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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
				UId = new Guid("99c0a079-b569-486d-8118-2ff619216465"),
				ContainerUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
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

		protected virtual void InitializeAddDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("c29c1ea2-c50d-4de5-ac66-516920f18b79"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"80294582-06b5-4faa-a85f-3323e5536b71",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2a9808a0-acf6-420e-bba5-93f802478e80"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] {  })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("627ad3cd-7998-4ecb-b7bc-4e7f08515ed5"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				UId = new Guid("87fa38ed-1e46-464b-bfb2-1adf9fb90a14"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			filterEntitySchemaIdParameter.SourceValue = new ProcessSchemaParameterValue(filterEntitySchemaIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1644d055-35f1-46be-b85d-cbd5030192cb"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordDefValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordDefValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,219,110,27,71,12,253,21,97,147,71,83,152,251,69,111,133,147,2,6,156,218,72,210,188,216,126,224,204,112,98,161,235,93,97,181,106,145,10,250,247,82,107,187,182,211,214,53,10,24,104,16,239,131,46,51,203,115,102,72,30,146,219,230,245,248,101,69,205,162,249,72,195,128,235,190,142,243,195,126,160,249,233,208,103,90,175,231,199,125,198,118,249,59,166,150,78,113,192,43,26,105,248,132,237,134,214,199,203,245,120,48,123,104,214,28,52,175,127,157,118,155,197,217,182,57,26,233,234,231,163,194,232,78,8,25,181,49,16,101,12,96,164,140,144,130,246,224,138,211,197,123,37,165,138,108,156,251,118,115,213,189,163,17,79,113,188,108,22,219,102,66,99,128,236,133,16,37,107,136,1,9,76,245,6,208,104,2,31,40,218,232,132,201,12,176,59,104,214,249,146,174,112,34,189,51,14,66,69,99,131,2,225,146,101,99,68,192,96,43,104,173,52,89,171,93,242,114,111,124,243,254,157,225,217,171,179,163,245,201,111,29,13,31,38,220,69,197,118,77,23,115,94,253,106,225,109,75,87,212,141,139,109,118,228,141,205,17,200,5,230,162,156,33,20,254,21,164,10,74,87,103,84,144,59,54,248,211,155,139,109,12,34,146,75,26,108,41,9,76,198,10,136,86,3,70,153,130,13,70,196,96,247,38,111,187,113,57,126,57,156,124,180,216,154,20,45,233,90,161,22,171,192,32,73,72,2,45,168,108,165,224,117,105,209,239,46,94,93,236,47,86,150,235,85,139,95,62,253,245,126,239,9,203,172,95,173,250,97,220,116,140,62,43,56,226,252,199,229,176,30,103,75,14,223,172,175,179,129,214,155,118,92,118,159,103,28,159,150,242,184,236,187,249,15,57,247,155,110,188,198,95,61,72,141,251,12,219,243,235,12,59,111,22,231,255,148,99,55,223,215,30,125,152,101,95,39,216,121,115,112,222,124,232,55,67,222,35,234,253,159,219,128,79,12,226,230,129,191,249,184,125,174,49,38,179,119,216,225,103,26,126,98,198,201,124,218,122,195,30,152,200,63,242,185,111,129,147,138,86,120,89,193,19,70,14,171,83,28,86,137,251,124,78,85,123,173,106,85,147,245,123,170,52,80,151,233,225,193,148,45,62,75,76,32,11,9,48,86,112,180,140,224,140,84,36,136,35,165,138,187,190,220,196,124,119,152,91,45,240,74,183,105,219,137,96,61,221,127,47,174,155,131,223,236,188,185,23,229,123,8,125,89,214,37,149,163,238,191,184,106,215,236,118,7,247,149,92,162,43,88,170,4,19,89,191,38,145,130,24,67,130,172,170,34,43,85,242,40,30,85,178,175,36,12,86,7,213,231,61,64,98,79,26,169,33,57,91,48,146,169,90,231,239,75,201,200,41,192,68,8,217,196,253,165,200,3,234,88,64,99,242,138,11,156,116,242,57,149,124,84,94,68,252,52,17,35,25,87,83,240,144,133,202,251,146,27,0,139,150,28,94,165,115,41,49,154,92,191,9,17,59,85,29,161,51,32,42,55,16,227,81,67,224,30,12,46,22,172,49,84,235,180,122,84,196,181,104,193,77,55,128,212,133,251,57,22,110,199,206,8,238,69,168,125,64,111,92,212,207,33,226,227,190,255,101,179,154,231,92,81,144,36,200,190,178,206,148,149,16,106,202,144,108,36,17,164,175,158,202,28,173,183,145,35,3,78,81,97,26,29,33,88,235,161,100,229,156,15,54,91,79,255,38,170,27,190,147,161,208,48,203,151,216,117,212,206,79,238,68,246,162,156,167,41,231,41,1,251,54,148,67,54,74,47,57,211,201,243,212,229,120,164,13,138,93,34,162,139,40,43,186,44,31,31,100,3,5,110,2,92,236,67,225,241,213,228,44,32,230,132,160,140,115,90,71,161,164,251,206,6,89,103,80,216,84,17,180,21,172,211,146,42,164,202,85,165,38,235,35,151,18,22,46,61,99,251,59,236,187,17,243,203,32,251,68,37,75,151,72,187,73,191,60,250,25,105,185,170,150,34,56,15,133,46,198,5,93,138,254,191,42,249,98,247,7,240,137,165,9,240,14,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e61c73fa-a1cd-4ced-8c2f-a8a753e62a94"),
				ContainerUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
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
				UId = new Guid("ad435e49-6d29-49c1-b37f-07b4169035df"),
				ContainerUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f8ee27e9-0fe2-4341-8e23-4267f53b9416"),
				ContainerUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a050532e-2c9a-4f51-81bb-cf840e62ef62"),
				ContainerUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,203,106,220,48,20,253,149,65,139,174,172,193,79,61,220,101,58,129,64,73,66,155,150,66,8,225,90,186,74,68,253,138,45,211,6,51,255,222,235,113,38,9,89,148,172,10,5,47,244,240,57,58,247,156,43,205,183,126,60,245,117,192,161,116,80,143,24,77,103,182,100,133,182,133,115,50,230,86,26,195,115,76,43,14,2,98,158,139,88,25,153,102,90,10,197,162,22,26,44,217,138,222,89,31,88,228,3,54,99,121,61,191,144,134,97,194,232,214,29,38,95,205,61,54,240,109,57,32,79,192,41,141,154,203,34,174,232,128,170,226,202,128,225,206,101,186,18,185,202,19,52,108,213,162,83,85,36,42,65,30,75,65,191,58,169,120,37,33,227,70,196,166,202,210,56,174,84,194,162,48,248,230,19,4,188,242,13,94,194,64,202,232,192,171,110,89,90,53,212,232,194,238,119,63,224,56,250,174,45,103,124,30,95,61,246,84,198,42,238,164,171,167,166,101,17,193,225,18,194,125,201,164,113,206,229,153,226,26,81,241,60,149,41,87,137,176,188,176,88,73,27,27,109,51,193,34,3,125,88,104,217,69,223,119,67,152,90,31,30,89,52,160,195,1,91,131,175,42,7,204,133,171,148,228,38,78,201,90,32,82,176,89,194,65,167,153,177,86,235,220,56,22,89,8,240,29,234,9,15,226,102,79,192,42,213,69,44,19,199,37,130,38,203,4,9,177,9,112,157,232,202,101,50,75,157,75,143,153,124,238,186,159,83,79,121,140,231,83,131,131,55,79,225,34,165,212,13,229,108,186,54,12,93,189,144,159,191,2,172,33,62,109,254,88,125,169,15,59,11,144,237,163,105,196,147,218,99,27,118,173,233,172,111,239,14,222,238,247,132,105,122,24,252,120,116,115,247,48,65,77,6,248,187,251,191,186,126,50,141,161,107,254,183,122,163,254,216,97,7,205,75,199,91,63,246,53,60,30,230,37,251,240,48,117,225,227,23,4,187,233,94,26,98,179,84,185,61,245,195,24,54,203,77,217,116,110,67,110,76,117,32,230,141,233,234,26,205,210,69,219,51,187,18,176,55,7,29,137,141,64,153,23,70,115,20,170,32,107,232,142,42,75,35,149,164,42,205,156,200,83,149,108,181,138,53,138,42,163,78,181,116,111,12,56,14,80,100,212,104,73,165,10,149,199,90,21,91,192,24,137,9,184,201,53,49,57,148,28,50,109,121,6,149,76,165,194,68,36,242,73,203,62,250,183,69,94,159,141,23,191,218,227,171,177,6,122,179,165,213,55,11,187,26,27,74,136,66,126,135,43,123,2,60,63,15,229,252,30,143,22,200,174,13,84,218,250,56,148,243,123,76,219,223,28,109,187,217,211,247,7,203,139,1,222,103,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a9bdd0c6-ef02-470d-918b-9984c37e8456"),
				ContainerUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
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
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,207,111,219,32,20,254,87,34,218,99,136,140,193,6,124,109,119,136,212,110,209,218,245,146,228,240,128,199,26,201,177,35,236,108,234,34,255,239,35,36,105,146,110,187,140,131,45,30,124,63,224,123,236,200,109,255,182,65,82,145,103,12,1,186,214,247,147,187,54,224,100,22,90,139,93,55,121,104,45,212,171,95,96,106,156,65,128,53,246,24,94,160,222,98,247,176,234,250,241,232,26,70,198,228,246,71,90,37,213,124,71,166,61,174,191,77,93,100,151,57,215,66,0,167,133,84,146,10,86,8,106,88,102,40,83,32,65,176,12,188,118,17,108,219,122,187,110,30,177,135,25,244,175,164,218,145,196,22,9,74,103,93,198,51,65,209,184,146,10,204,24,85,46,211,84,162,70,116,186,176,202,33,25,198,164,179,175,184,134,36,122,6,11,6,94,105,140,187,139,168,41,208,24,170,44,88,234,61,215,166,20,74,48,180,123,240,113,255,25,56,191,153,79,187,47,63,27,12,79,137,183,242,80,119,184,156,196,234,135,194,167,26,215,216,244,213,206,105,149,41,229,11,42,114,157,81,17,37,40,40,171,40,72,83,230,218,23,188,180,114,136,128,247,219,172,118,88,50,43,185,7,10,204,58,42,44,186,104,47,247,17,7,178,224,88,230,160,197,176,188,89,238,45,186,85,183,169,225,237,229,79,167,119,1,161,199,81,27,28,134,201,97,226,70,1,109,44,140,166,238,128,222,92,69,120,137,223,45,14,157,176,32,213,226,95,189,112,252,31,78,126,221,13,31,27,97,65,198,11,242,212,110,131,221,51,242,253,228,20,76,82,200,142,131,254,229,115,26,7,142,4,123,132,6,190,99,248,28,21,19,60,45,221,67,15,73,252,57,250,62,17,155,92,23,153,100,62,54,6,232,24,117,153,199,62,97,64,53,211,198,115,201,115,239,243,132,254,138,30,3,54,22,175,141,169,44,215,162,80,57,205,74,19,51,244,16,83,81,133,167,156,231,28,139,152,158,145,44,225,147,242,217,204,169,103,99,165,217,214,117,18,232,210,249,247,143,224,104,252,184,114,127,145,225,5,67,235,86,126,133,110,218,252,207,85,13,100,24,150,195,111,78,132,191,228,207,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent startbusinessprocess = CreateStartBusinessProcessStartEvent();
			FlowElements.Add(startbusinessprocess);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readdatausertask1 = CreateReadDataUserTask1UserTask();
			FlowElements.Add(readdatausertask1);
			ProcessSchemaFormulaTask formulatask1 = CreateFormulaTask1FormulaTask();
			FlowElements.Add(formulatask1);
			ProcessSchemaScriptTask copyproductscripttask = CreateCopyProductScriptTaskScriptTask();
			FlowElements.Add(copyproductscripttask);
			ProcessSchemaTerminateEvent terminate2 = CreateTerminate2TerminateEvent();
			FlowElements.Add(terminate2);
			ProcessSchemaUserTask openeditpageusertask1 = CreateOpenEditPageUserTask1UserTask();
			FlowElements.Add(openeditpageusertask1);
			ProcessSchemaUserTask adddatausertask1 = CreateAddDataUserTask1UserTask();
			FlowElements.Add(adddatausertask1);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("e547bf8f-5a9b-4973-836c-fa05e0c51a0f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5afbdb3d-b891-4182-a1de-b0b6cd7afbb5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6d5433e0-f6f4-4777-b1a7-0a61b5f39bca"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("e47d7853-ced5-43da-a7db-fd3385011ab1"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{515496b8-401a-4a70-b54d-64bfd7124238}]#]== Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(202, 122),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d5433e0-f6f4-4777-b1a7-0a61b5f39bca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a7eafc6e-049d-4a84-90b6-6ed571fef54e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("55f5bf80-a21a-4643-9564-9d88b48ef8a5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(438, 300),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("589ffe59-36f0-4ca1-a22c-97cb3e65f133"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(282, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6d5433e0-f6f4-4777-b1a7-0a61b5f39bca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("1ec6908e-e69c-424f-9c8c-d14758de5c50"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(708, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0fba4b88-d25b-42b4-9c15-bd0a670ee85a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("87083a40-d9d4-4976-aa29-e3be8bc53d5e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("4cb57c2d-2023-4f58-87a5-9a9bfc3c9e3c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(846, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("87083a40-d9d4-4976-aa29-e3be8bc53d5e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("a865471d-c404-4675-9fa5-733f6f1e378a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(846, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2e20440b-bd9c-4844-8378-0cd290e3bd3b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("bfd2a0e9-ab44-4ff1-92dd-dacb801c9d9d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(438, 300),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0fba4b88-d25b-42b4-9c15-bd0a670ee85a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("f2263e84-a07c-46fe-9fcb-c50b6a8f03d1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("b6fb0ad3-6ee4-4e3f-a948-15ac8ee3c7f4"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				CurveCenterPosition = new Point(846, 204),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9572b96f-ef1d-462d-8516-9a36c0b9a189"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9572b96f-ef1d-462d-8516-9a36c0b9a189"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStartBusinessProcessStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("5afbdb3d-b891-4182-a1de-b0b6cd7afbb5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"StartBusinessProcess",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("a7eafc6e-049d-4a84-90b6-6ed571fef54e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"Terminate1",
				Position = new Point(155, 37),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("6d5433e0-f6f4-4777-b1a7-0a61b5f39bca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"ExclusiveGateway1",
				Position = new Point(141, 170),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"ReadDataUserTask1",
				Position = new Point(295, 170),
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

		protected virtual ProcessSchemaFormulaTask CreateFormulaTask1FormulaTask() {
			ProcessSchemaFormulaTask FormulaTask = new ProcessSchemaFormulaTask(this) {
				UId = new Guid("0fba4b88-d25b-42b4-9c15-bd0a670ee85a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d334d28f-b11a-477e-9ff0-0a95fa73d53b"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"FormulaTask1",
				Position = new Point(568, 170),
				ResultParameterMetaPath = @"d828a3fe-e2a4-4160-a91c-92ab92b04cfc",
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,203,173,14,131,48,16,0,224,135,65,223,2,253,111,253,4,106,75,38,73,197,237,122,151,9,138,40,36,19,132,119,95,245,236,151,124,203,176,204,251,227,187,113,123,209,135,43,38,193,117,231,124,235,250,7,247,149,43,111,71,58,75,12,99,8,98,193,168,56,130,17,209,128,129,2,160,127,59,21,197,106,71,254,234,225,137,13,43,31,220,210,201,110,34,175,5,1,39,42,96,136,11,4,82,210,31,122,171,217,41,140,230,202,67,254,1,206,164,124,32,142,0,0,0 }
			};
			
			return FormulaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCopyProductScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("87083a40-d9d4-4976-aa29-e3be8bc53d5e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"CopyProductScriptTask",
				Position = new Point(701, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,65,106,195,64,12,60,59,144,63,168,62,217,16,246,3,105,10,193,52,197,151,186,208,244,1,198,145,205,130,189,107,36,109,83,211,228,239,221,181,211,226,134,20,122,212,104,70,26,141,116,13,201,11,217,131,171,36,23,236,88,237,237,171,144,54,77,146,194,221,6,226,24,78,39,200,57,179,253,176,109,219,11,51,133,207,229,34,122,47,9,42,143,95,64,46,122,164,82,180,53,176,129,93,89,137,37,141,172,178,182,100,158,202,65,61,161,220,123,101,180,71,162,146,109,45,42,179,166,214,141,155,132,42,172,41,232,128,244,61,115,71,182,43,250,222,146,56,163,101,248,89,241,144,132,49,6,143,243,77,214,176,144,11,229,150,26,215,161,145,36,118,140,228,27,6,171,32,139,87,240,246,11,72,211,181,31,116,243,10,245,248,129,149,19,76,194,150,63,12,7,19,255,55,125,155,237,189,242,152,103,20,205,68,249,193,167,152,57,34,127,197,12,94,77,188,160,31,25,207,120,28,139,9,191,254,19,123,198,53,54,49,231,47,247,164,121,233,251,231,144,202,121,185,32,20,71,6,124,168,184,254,2,137,107,141,169,41,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate2TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("2e20440b-bd9c-4844-8378-0cd290e3bd3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"Terminate2",
				Position = new Point(1044, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateOpenEditPageUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("6085de11-ad02-4192-ac1e-8e1e01838e27"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("b0d3ad9f-7a27-46a3-9483-ed70c26872ae"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"OpenEditPageUserTask1",
				Position = new Point(939, 170),
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

		protected virtual ProcessSchemaUserTask CreateAddDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"AddDataUserTask1",
				Position = new Point(428, 170),
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
				UId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11dc7f42-4bda-4a8f-96ab-9846636adc43"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("b6fb0ad3-6ee4-4e3f-a948-15ac8ee3c7f4"),
				CreatedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"),
				Name = @"ChangeDataUserTask1",
				Position = new Point(820, 170),
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new CreateOrderFromOpportunity(userConnection);
		}

		public override object Clone() {
			return new CreateOrderFromOpportunitySchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5"));
		}

		#endregion

	}

	#endregion

	#region Class: CreateOrderFromOpportunity

	/// <exclude/>
	public class CreateOrderFromOpportunity : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, CreateOrderFromOpportunity process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, CreateOrderFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("c6e745c9-e685-4ecc-8d85-812823f64281");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,89,178,108,185,199,101,91,246,146,6,154,150,66,178,132,103,233,41,43,240,87,108,137,102,49,251,223,43,175,119,83,200,161,20,122,42,232,32,61,105,230,205,12,79,243,163,155,62,185,198,227,88,89,104,38,76,194,206,84,164,214,89,137,194,112,202,132,224,84,40,166,169,82,25,82,0,37,121,97,101,46,5,35,73,7,45,86,100,69,111,141,243,36,113,30,219,169,186,159,127,147,250,49,96,242,104,207,135,175,250,128,45,124,91,26,0,10,105,235,178,160,58,205,52,21,128,37,5,195,25,5,149,113,109,140,82,66,91,114,209,2,10,148,85,64,85,142,150,10,107,51,10,34,151,148,165,42,23,58,205,69,42,12,73,26,180,126,251,50,140,56,77,174,239,170,25,95,247,119,199,33,170,92,123,111,250,38,180,29,73,90,244,112,11,254,176,8,73,81,228,26,168,22,42,143,236,88,80,224,202,80,14,117,145,21,37,50,201,10,146,104,24,252,66,75,118,177,149,1,15,223,161,9,120,102,158,93,212,152,241,148,149,185,140,88,198,163,29,158,165,180,148,209,157,53,210,42,228,82,169,218,92,243,250,28,92,220,187,233,38,180,56,58,125,137,29,99,126,253,88,205,186,239,252,216,55,11,245,205,249,249,29,190,248,53,220,203,213,143,213,144,143,245,5,68,78,73,152,112,211,56,236,252,182,211,189,113,221,211,202,121,58,69,72,59,192,232,166,107,10,219,231,0,13,73,70,247,116,248,99,90,155,48,249,190,253,143,172,38,209,102,228,136,67,118,150,187,204,160,113,211,208,192,241,124,174,200,251,231,208,251,143,155,48,142,17,252,174,31,134,126,244,161,115,254,184,94,144,55,4,21,121,32,57,203,133,146,117,73,69,202,32,206,104,145,210,58,23,134,74,81,91,83,176,76,100,188,124,32,81,212,191,183,186,223,77,95,126,118,215,31,178,122,218,127,136,213,55,133,219,43,178,154,255,70,221,105,191,232,219,159,226,250,5,148,137,196,6,232,3,0,0 })));
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

		#region Class: OpenEditPageUserTask1FlowElement

		/// <exclude/>
		public class OpenEditPageUserTask1FlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, CreateOrderFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("1512504c-d402-4646-a61b-a0c1ce3cdef6");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_recordId = () => (Guid)((process.NewOrder));
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

			#endregion

		}

		#endregion

		#region Class: AddDataUserTask1FlowElement

		/// <exclude/>
		public class AddDataUserTask1FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask1FlowElement(UserConnection userConnection, CreateOrderFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("d98088f5-4290-4ff3-a8c8-a7b629f536c7");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_Account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_recordDefValues_Opportunity = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_recordDefValues_SourceOrder = () => (Guid)(new Guid("a5759923-62ed-4f39-8557-dc266785c57e"));
				_recordDefValues_Contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private  Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Account", () => _recordDefValues_Account.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Opportunity", () => _recordDefValues_Opportunity.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SourceOrder", () => _recordDefValues_SourceOrder.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Account;
			internal Func<Guid> _recordDefValues_Opportunity;
			internal Func<Guid> _recordDefValues_SourceOrder;
			internal Func<Guid> _recordDefValues_Contact;

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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,219,110,27,71,12,253,21,97,147,71,83,152,251,69,111,133,147,2,6,156,218,72,210,188,216,126,224,204,112,98,161,235,93,97,181,106,145,10,250,247,82,107,187,182,211,214,53,10,24,104,16,239,131,46,51,203,115,102,72,30,146,219,230,245,248,101,69,205,162,249,72,195,128,235,190,142,243,195,126,160,249,233,208,103,90,175,231,199,125,198,118,249,59,166,150,78,113,192,43,26,105,248,132,237,134,214,199,203,245,120,48,123,104,214,28,52,175,127,157,118,155,197,217,182,57,26,233,234,231,163,194,232,78,8,25,181,49,16,101,12,96,164,140,144,130,246,224,138,211,197,123,37,165,138,108,156,251,118,115,213,189,163,17,79,113,188,108,22,219,102,66,99,128,236,133,16,37,107,136,1,9,76,245,6,208,104,2,31,40,218,232,132,201,12,176,59,104,214,249,146,174,112,34,189,51,14,66,69,99,131,2,225,146,101,99,68,192,96,43,104,173,52,89,171,93,242,114,111,124,243,254,157,225,217,171,179,163,245,201,111,29,13,31,38,220,69,197,118,77,23,115,94,253,106,225,109,75,87,212,141,139,109,118,228,141,205,17,200,5,230,162,156,33,20,254,21,164,10,74,87,103,84,144,59,54,248,211,155,139,109,12,34,146,75,26,108,41,9,76,198,10,136,86,3,70,153,130,13,70,196,96,247,38,111,187,113,57,126,57,156,124,180,216,154,20,45,233,90,161,22,171,192,32,73,72,2,45,168,108,165,224,117,105,209,239,46,94,93,236,47,86,150,235,85,139,95,62,253,245,126,239,9,203,172,95,173,250,97,220,116,140,62,43,56,226,252,199,229,176,30,103,75,14,223,172,175,179,129,214,155,118,92,118,159,103,28,159,150,242,184,236,187,249,15,57,247,155,110,188,198,95,61,72,141,251,12,219,243,235,12,59,111,22,231,255,148,99,55,223,215,30,125,152,101,95,39,216,121,115,112,222,124,232,55,67,222,35,234,253,159,219,128,79,12,226,230,129,191,249,184,125,174,49,38,179,119,216,225,103,26,126,98,198,201,124,218,122,195,30,152,200,63,242,185,111,129,147,138,86,120,89,193,19,70,14,171,83,28,86,137,251,124,78,85,123,173,106,85,147,245,123,170,52,80,151,233,225,193,148,45,62,75,76,32,11,9,48,86,112,180,140,224,140,84,36,136,35,165,138,187,190,220,196,124,119,152,91,45,240,74,183,105,219,137,96,61,221,127,47,174,155,131,223,236,188,185,23,229,123,8,125,89,214,37,149,163,238,191,184,106,215,236,118,7,247,149,92,162,43,88,170,4,19,89,191,38,145,130,24,67,130,172,170,34,43,85,242,40,30,85,178,175,36,12,86,7,213,231,61,64,98,79,26,169,33,57,91,48,146,169,90,231,239,75,201,200,41,192,68,8,217,196,253,165,200,3,234,88,64,99,242,138,11,156,116,242,57,149,124,84,94,68,252,52,17,35,25,87,83,240,144,133,202,251,146,27,0,139,150,28,94,165,115,41,49,154,92,191,9,17,59,85,29,161,51,32,42,55,16,227,81,67,224,30,12,46,22,172,49,84,235,180,122,84,196,181,104,193,77,55,128,212,133,251,57,22,110,199,206,8,238,69,168,125,64,111,92,212,207,33,226,227,190,255,101,179,154,231,92,81,144,36,200,190,178,206,148,149,16,106,202,144,108,36,17,164,175,158,202,28,173,183,145,35,3,78,81,97,26,29,33,88,235,161,100,229,156,15,54,91,79,255,38,170,27,190,147,161,208,48,203,151,216,117,212,206,79,238,68,246,162,156,167,41,231,41,1,251,54,148,67,54,74,47,57,211,201,243,212,229,120,164,13,138,93,34,162,139,40,43,186,44,31,31,100,3,5,110,2,92,236,67,225,241,213,228,44,32,230,132,160,140,115,90,71,161,164,251,206,6,89,103,80,216,84,17,180,21,172,211,146,42,164,202,85,165,38,235,35,151,18,22,46,61,99,251,59,236,187,17,243,203,32,251,68,37,75,151,72,187,73,191,60,250,25,105,185,170,150,34,56,15,133,46,198,5,93,138,254,191,42,249,98,247,7,240,137,165,9,240,14,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "be82d4e046384058975d050a3dcff8b5",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("b8e3670d-40ce-4674-8aa5-3d4805a5932d");
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

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, CreateOrderFromOpportunity process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("4c37bea9-eca9-46f6-a1ba-ae64d00de7d7");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Order = () => (Guid)((process.AddDataUserTask1.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private  Dictionary<string, Func<object>> GetColumnValueFunctions {
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,203,106,220,48,20,253,149,65,139,174,172,193,79,61,220,101,58,129,64,73,66,155,150,66,8,225,90,186,74,68,253,138,45,211,6,51,255,222,235,113,38,9,89,148,172,10,5,47,244,240,57,58,247,156,43,205,183,126,60,245,117,192,161,116,80,143,24,77,103,182,100,133,182,133,115,50,230,86,26,195,115,76,43,14,2,98,158,139,88,25,153,102,90,10,197,162,22,26,44,217,138,222,89,31,88,228,3,54,99,121,61,191,144,134,97,194,232,214,29,38,95,205,61,54,240,109,57,32,79,192,41,141,154,203,34,174,232,128,170,226,202,128,225,206,101,186,18,185,202,19,52,108,213,162,83,85,36,42,65,30,75,65,191,58,169,120,37,33,227,70,196,166,202,210,56,174,84,194,162,48,248,230,19,4,188,242,13,94,194,64,202,232,192,171,110,89,90,53,212,232,194,238,119,63,224,56,250,174,45,103,124,30,95,61,246,84,198,42,238,164,171,167,166,101,17,193,225,18,194,125,201,164,113,206,229,153,226,26,81,241,60,149,41,87,137,176,188,176,88,73,27,27,109,51,193,34,3,125,88,104,217,69,223,119,67,152,90,31,30,89,52,160,195,1,91,131,175,42,7,204,133,171,148,228,38,78,201,90,32,82,176,89,194,65,167,153,177,86,235,220,56,22,89,8,240,29,234,9,15,226,102,79,192,42,213,69,44,19,199,37,130,38,203,4,9,177,9,112,157,232,202,101,50,75,157,75,143,153,124,238,186,159,83,79,121,140,231,83,131,131,55,79,225,34,165,212,13,229,108,186,54,12,93,189,144,159,191,2,172,33,62,109,254,88,125,169,15,59,11,144,237,163,105,196,147,218,99,27,118,173,233,172,111,239,14,222,238,247,132,105,122,24,252,120,116,115,247,48,65,77,6,248,187,251,191,186,126,50,141,161,107,254,183,122,163,254,216,97,7,205,75,199,91,63,246,53,60,30,230,37,251,240,48,117,225,227,23,4,187,233,94,26,98,179,84,185,61,245,195,24,54,203,77,217,116,110,67,110,76,117,32,230,141,233,234,26,205,210,69,219,51,187,18,176,55,7,29,137,141,64,153,23,70,115,20,170,32,107,232,142,42,75,35,149,164,42,205,156,200,83,149,108,181,138,53,138,42,163,78,181,116,111,12,56,14,80,100,212,104,73,165,10,149,199,90,21,91,192,24,137,9,184,201,53,49,57,148,28,50,109,121,6,149,76,165,194,68,36,242,73,203,62,250,183,69,94,159,141,23,191,218,227,171,177,6,122,179,165,213,55,11,187,26,27,74,136,66,126,135,43,123,2,60,63,15,229,252,30,143,22,200,174,13,84,218,250,56,148,243,123,76,219,223,28,109,187,217,211,247,7,203,139,1,222,103,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,207,111,219,32,20,254,87,34,218,99,136,140,193,6,124,109,119,136,212,110,209,218,245,146,228,240,128,199,26,201,177,35,236,108,234,34,255,239,35,36,105,146,110,187,140,131,45,30,124,63,224,123,236,200,109,255,182,65,82,145,103,12,1,186,214,247,147,187,54,224,100,22,90,139,93,55,121,104,45,212,171,95,96,106,156,65,128,53,246,24,94,160,222,98,247,176,234,250,241,232,26,70,198,228,246,71,90,37,213,124,71,166,61,174,191,77,93,100,151,57,215,66,0,167,133,84,146,10,86,8,106,88,102,40,83,32,65,176,12,188,118,17,108,219,122,187,110,30,177,135,25,244,175,164,218,145,196,22,9,74,103,93,198,51,65,209,184,146,10,204,24,85,46,211,84,162,70,116,186,176,202,33,25,198,164,179,175,184,134,36,122,6,11,6,94,105,140,187,139,168,41,208,24,170,44,88,234,61,215,166,20,74,48,180,123,240,113,255,25,56,191,153,79,187,47,63,27,12,79,137,183,242,80,119,184,156,196,234,135,194,167,26,215,216,244,213,206,105,149,41,229,11,42,114,157,81,17,37,40,40,171,40,72,83,230,218,23,188,180,114,136,128,247,219,172,118,88,50,43,185,7,10,204,58,42,44,186,104,47,247,17,7,178,224,88,230,160,197,176,188,89,238,45,186,85,183,169,225,237,229,79,167,119,1,161,199,81,27,28,134,201,97,226,70,1,109,44,140,166,238,128,222,92,69,120,137,223,45,14,157,176,32,213,226,95,189,112,252,31,78,126,221,13,31,27,97,65,198,11,242,212,110,131,221,51,242,253,228,20,76,82,200,142,131,254,229,115,26,7,142,4,123,132,6,190,99,248,28,21,19,60,45,221,67,15,73,252,57,250,62,17,155,92,23,153,100,62,54,6,232,24,117,153,199,62,97,64,53,211,198,115,201,115,239,243,132,254,138,30,3,54,22,175,141,169,44,215,162,80,57,205,74,19,51,244,16,83,81,133,167,156,231,28,139,152,158,145,44,225,147,242,217,204,169,103,99,165,217,214,117,18,232,210,249,247,143,224,104,252,184,114,127,145,225,5,67,235,86,126,133,110,218,252,207,85,13,100,24,150,195,111,78,132,191,228,207,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "be82d4e046384058975d050a3dcff8b5",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("b8e3670d-40ce-4674-8aa5-3d4805a5932d");
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

		public CreateOrderFromOpportunity(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CreateOrderFromOpportunity";
			SchemaUId = new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("be82d4e0-4638-4058-975d-050a3dcff8b5");
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public  virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		public  virtual Guid CurrentOpportunity {
			get;
			set;
		}

		public  virtual Guid NewOrder {
			get;
			set;
		}

		public  virtual string ProductItems {
			get;
			set;
		}

		public  virtual bool IsCopyAllProduct {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public  ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _startBusinessProcess;
		public  ProcessFlowElement StartBusinessProcess {
			get {
				return _startBusinessProcess ?? (_startBusinessProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartBusinessProcess",
					SchemaElementUId = new Guid("5afbdb3d-b891-4182-a1de-b0b6cd7afbb5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
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
					SchemaElementUId = new Guid("a7eafc6e-049d-4a84-90b6-6ed571fef54e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("6d5433e0-f6f4-4777-b1a7-0a61b5f39bca"),
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

		private ProcessScriptTask _formulaTask1;
		public  ProcessScriptTask FormulaTask1 {
			get {
				return _formulaTask1 ?? (_formulaTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask1",
					SchemaElementUId = new Guid("0fba4b88-d25b-42b4-9c15-bd0a670ee85a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessScriptTask _copyProductScriptTask;
		public  ProcessScriptTask CopyProductScriptTask {
			get {
				return _copyProductScriptTask ?? (_copyProductScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CopyProductScriptTask",
					SchemaElementUId = new Guid("87083a40-d9d4-4976-aa29-e3be8bc53d5e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CopyProductScriptTaskExecute,
				});
			}
		}

		private ProcessTerminateEvent _terminate2;
		public  ProcessTerminateEvent Terminate2 {
			get {
				return _terminate2 ?? (_terminate2 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate2",
					SchemaElementUId = new Guid("2e20440b-bd9c-4844-8378-0cd290e3bd3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private OpenEditPageUserTask1FlowElement _openEditPageUserTask1;
		public  OpenEditPageUserTask1FlowElement OpenEditPageUserTask1 {
			get {
				return _openEditPageUserTask1 ?? (_openEditPageUserTask1 = new OpenEditPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public  AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public  ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public  ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("e47d7853-ced5-43da-a7db-fd3385011ab1"),
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
			FlowElements[StartBusinessProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { StartBusinessProcess };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[CopyProductScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CopyProductScriptTask };
			FlowElements[Terminate2.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate2 };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartBusinessProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CopyProductScriptTask", e.Context.SenderName));
						break;
					case "CopyProductScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						break;
					case "Terminate2":
						CompleteProcess();
						break;
					case "OpenEditPageUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate2", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean((CurrentOpportunity)== Guid.Empty);
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CurrentOpportunity")) {
				writer.WriteValue("CurrentOpportunity", CurrentOpportunity, Guid.Empty);
			}
			if (!HasMapping("NewOrder")) {
				writer.WriteValue("NewOrder", NewOrder, Guid.Empty);
			}
			if (!HasMapping("ProductItems")) {
				writer.WriteValue("ProductItems", ProductItems, null);
			}
			if (!HasMapping("IsCopyAllProduct")) {
				writer.WriteValue("IsCopyAllProduct", IsCopyAllProduct, false);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartBusinessProcess", string.Empty));
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
			MetaPathParameterValues.Add("515496b8-401a-4a70-b54d-64bfd7124238", () => CurrentOpportunity);
			MetaPathParameterValues.Add("d828a3fe-e2a4-4160-a91c-92ab92b04cfc", () => NewOrder);
			MetaPathParameterValues.Add("6c324739-8a48-4082-998b-fa670868c7ce", () => ProductItems);
			MetaPathParameterValues.Add("d7f0950e-8bc1-4a4d-b695-906d525716a4", () => IsCopyAllProduct);
			MetaPathParameterValues.Add("e1d83148-df86-4cc1-810a-5310eb1688e8", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("3898f5c3-ee0f-45d0-95ac-9cd9a0d94564", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("cea4bbf0-8f34-4f22-ab35-9a44c8f81e1e", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("f5a484b3-8778-45a8-abde-f587d34577ef", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("ebe4df04-3e0e-419e-833f-8e94cd7d6497", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("c2db847b-3042-4668-bddd-dc4935ba4078", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("f824e334-f632-4f09-a820-7cf5de24447a", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("9809e6b3-5ddb-4caf-aa53-a91b85840985", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("2d44e8b3-9be9-44d9-989e-801007f332a2", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("af44f78e-77ce-4e84-89aa-a4a8589acaca", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("a3bbda1d-938c-4804-bae7-3e6727495500", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("d90e7819-b5bb-4322-b1a1-688430cac361", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("adbeddd4-1b47-439f-b56f-eaf1ce7c22bd", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("1f3ec804-485b-4fb7-ba6c-b97ab3bcb1a8", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("44077e26-c243-4885-bf41-802b99ca00f2", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("87d3453d-f7b9-41d7-953c-1ce1e1ade596", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("8e68ae20-c6e7-4bff-bc6f-c7c1e2476fe2", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("4fb1e2ff-2cc4-4788-bae0-e74102fa14e8", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("30aa1c24-3e58-45a3-a546-cdf3bedb9b62", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("c831eecc-a5e6-4e9b-8f0a-6d639e5e35fb", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("874c268f-6319-4d17-ad59-f40c4f774b05", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("01172481-a565-47df-a5be-cb9da2fc12a3", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("30f2bca3-c96e-4e5c-88c8-085b0ae8cf0d", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("1408b6b8-cf8c-4425-b12e-fbad9c403b3d", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("c7f158e2-218b-4b9f-8725-909927e9b8b5", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("3d20f3f7-5984-43c4-9f1d-394a5d9dc018", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("e46b1b8b-1819-4789-a14f-65ddf3741c3b", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("ab96af1a-57c8-4824-96f8-6ba447e62e14", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("2450b4ac-bc00-4be2-9f76-e7e372ca7f07", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("67908e65-2f58-45f9-983b-2c1da6379cd5", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("4dea05bc-b597-4eb2-8f8e-707838c63a9e", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("08b712e2-4919-4423-b244-28f0ab6e324e", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("a4574b01-f7d9-4d5b-b3e8-504a67746654", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("69a2aa31-7c0d-4a87-9dba-2547b60626e5", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("f9f8a922-41df-4718-9bb2-5709eef02ce4", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("d01eb000-e5aa-49b1-a95c-82a0dbd4a4a8", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("540dcd0c-778c-4a17-ac36-7def92eab44c", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("6ba4e133-0564-4f7f-91ad-971ae82a9e2d", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("3e4d0ff6-c547-4b65-ad49-292460443cd8", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("73d80e1b-1dc6-4b92-92e4-c0ff21953dad", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("5d24cbb8-ba27-4390-9faf-4ac736c965fe", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("f6a640ee-aeff-4e52-a0ef-83b05ca53c8c", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("71ebff1e-d62b-43b6-9539-02c2dffd16a2", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("c29a5757-0505-47ee-b548-5293e3acbd89", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("d6fc85c9-a2f4-455e-b336-fa9b65be5720", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("13610d95-0021-419e-88ad-79b772cbba42", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("e4606663-de9c-46d9-8891-543f07160143", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("89f85502-0eb1-4d21-9eaa-96ebe6cf07ff", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("b9d6544d-94ae-49b4-af5c-ec4c5ed0dc76", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("30207a75-7e4e-4522-904b-474a8b804296", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("1c1730bc-905c-42f3-add5-b5767a8cc78c", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("251964b1-f33f-4a0d-bf37-4b2a62a2a899", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("29a2680c-fd32-4012-916a-2548fffff631", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("b9101517-77b1-4251-8334-6c0beefd8041", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("88dfbdf6-104a-448e-8a68-5256a4d8de7d", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("bcaeafa8-ef4e-4977-81f8-d000782ce97f", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("5da83713-07c4-4e79-9df3-1e7de802bcee", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("fa6dc17d-dd86-43d4-b71a-1d6b901489b5", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("eb233771-7ac3-4db6-aa21-e29355f9b0f1", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("975dc8f2-6321-4417-9c7b-bd02cf1f0781", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("b3793aa7-c2bf-4f7e-ba51-134097f27019", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("2d39a734-7bc1-4c2e-b145-d00733f01f98", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("e4f8491d-13aa-43d4-b1a6-366538d33a50", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("99c0a079-b569-486d-8118-2ff619216465", () => OpenEditPageUserTask1.Project);
			MetaPathParameterValues.Add("c29c1ea2-c50d-4de5-ac66-516920f18b79", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("2a9808a0-acf6-420e-bba5-93f802478e80", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("627ad3cd-7998-4ecb-b7bc-4e7f08515ed5", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("87fa38ed-1e46-464b-bfb2-1adf9fb90a14", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("1644d055-35f1-46be-b85d-cbd5030192cb", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("e61c73fa-a1cd-4ced-8c2f-a8a753e62a94", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("ad435e49-6d29-49c1-b37f-07b4169035df", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("f8ee27e9-0fe2-4341-8e23-4267f53b9416", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("a050532e-2c9a-4f51-81bb-cf840e62ef62", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("a9bdd0c6-ef02-470d-918b-9984c37e8456", () => ChangeDataUserTask1.RecordColumnValues);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CurrentOpportunity":
					if (!hasValueToRead) break;
					CurrentOpportunity = reader.GetValue<System.Guid>();
				break;
				case "NewOrder":
					if (!hasValueToRead) break;
					NewOrder = reader.GetValue<System.Guid>();
				break;
				case "ProductItems":
					if (!hasValueToRead) break;
					ProductItems = reader.GetValue<System.String>();
				break;
				case "IsCopyAllProduct":
					if (!hasValueToRead) break;
					IsCopyAllProduct = reader.GetValue<System.Boolean>();
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
			var localNewOrder = (AddDataUserTask1.RecordId);
			NewOrder = (System.Guid)localNewOrder;
			return true;
		}

		public virtual bool CopyProductScriptTaskExecute(ProcessExecutingContext context) {
			if (ProductItems.ToString() != "" || IsCopyAllProduct) {
				var copyProductsOperation = Factories.ClassFactory.Get<
					Terrasoft.Configuration.CopyOrderProductsFromOpportunityOperation>(
					new Factories.ConstructorArgument("userConnection", UserConnection));
				copyProductsOperation.Execute(new Terrasoft.Configuration
					.CopyOrderProductsFromOpportunityOperation
					.CopyOrderProductsArgs {
						OpportunityId = CurrentOpportunity,
						OrderId = NewOrder,
						IsCopyAllProducts = IsCopyAllProduct,
						ProductItems = ProductItems
				});
			}
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
			var cloneItem = (CreateOrderFromOpportunity)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

