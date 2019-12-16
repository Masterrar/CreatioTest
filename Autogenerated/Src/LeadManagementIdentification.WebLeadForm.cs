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

	#region Class: LeadManagementIdentificationSchema

	/// <exclude/>
	public class LeadManagementIdentificationSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagementIdentificationSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagementIdentificationSchema(LeadManagementIdentificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagementIdentification";
			UId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.15.0.555";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = false;
			Tag = @"LeadManagementIdentification";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			Version = 0;
			PackageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1300b53e-296c-4858-8368-493adc25a74c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIdentificationPassedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("27623c14-f1c7-4872-8f1c-45103cd82954"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"IdentificationPassed",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateIdentificationPassedParameter());
		}

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f7cf3a22-2a33-428e-9e2b-5f3622d92f72"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,203,146,45,201,61,46,219,178,80,210,64,211,82,72,150,48,146,198,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,235,6,218,128,217,180,115,53,41,144,25,43,75,77,65,202,156,10,85,48,106,160,40,40,183,37,19,198,9,157,131,33,89,15,29,214,100,69,111,157,143,36,243,17,187,80,223,206,191,73,227,56,97,118,223,156,147,175,246,128,29,124,91,26,8,6,141,210,168,169,44,115,67,5,26,67,149,5,75,155,134,107,83,9,37,24,90,178,106,17,220,160,80,57,80,100,54,105,177,82,80,229,36,208,92,50,167,89,81,228,202,114,146,181,216,196,237,211,113,196,16,252,208,215,51,190,198,55,207,199,164,114,237,189,25,218,169,235,73,214,97,132,107,136,135,154,0,230,40,74,11,212,10,93,82,209,160,164,192,181,163,28,140,44,164,66,86,49,73,50,11,199,184,208,146,157,35,153,131,8,223,161,157,240,204,60,251,197,47,158,51,85,86,9,203,184,165,130,23,57,85,149,146,180,113,85,163,145,87,90,27,119,241,235,211,228,83,236,195,213,212,225,232,237,139,237,152,252,27,198,122,182,67,31,199,161,93,168,175,206,207,111,240,41,174,230,190,92,253,88,7,138,169,190,128,200,41,155,2,110,90,143,125,220,246,118,112,190,127,88,57,79,167,4,233,142,48,250,112,113,97,251,56,65,75,178,209,63,28,254,232,214,102,10,113,232,254,163,81,179,52,102,226,72,75,118,150,187,236,160,243,225,216,194,243,57,175,201,187,199,105,136,31,62,35,184,157,91,99,242,6,83,147,59,194,120,158,155,146,35,45,116,149,134,83,165,162,138,87,138,10,205,193,217,162,4,41,236,29,73,58,254,137,253,118,23,190,252,236,47,255,96,85,190,127,159,170,111,10,215,23,100,61,255,141,160,211,126,145,180,63,165,243,11,182,69,111,55,206,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a01e5fd1-7cbb-4e06-9188-a9656c381385"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4db6d4f9-57aa-44ef-8934-56b12a060e0e"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dc3c82bb-8c59-485f-9376-5880ae2ce035"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bcf6ac2d-9970-48a9-80e2-c7d41b6c0c2e"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("76636537-e5df-47a7-9eb6-124881330bf3"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("232523cc-cb63-410d-8f7c-58cdcf2ef818"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("6c984967-8a07-4d65-aefc-418e5a11cdcd"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e3cd6198-af4e-409b-8ba3-0851372ea038"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("7e4ceefa-cd15-47a3-8a3b-c8ad4ed1ef7f"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("0a326237-a485-4b38-9337-3aa27272cdd9"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("f7b52dbf-c358-489e-bf2c-3c4ff7924a2c"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("dd6ab013-fc1e-4bc5-a25b-6855ace31f97"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("c6cfc815-55cb-4def-b83c-14b182d467ce"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("72ded882-b97d-4f56-91cb-1e6e212f4218"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0a075eb5-bcac-445c-993d-bd329be8d6dc"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("17573208-3be8-4476-9823-f565b0714f28"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("80b5175b-4a70-4c52-aecd-45f0a21a0a46"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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
				UId = new Guid("226bbc3c-5b09-4281-89ec-c12e6f10bb67"),
				ContainerUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
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

		protected virtual void InitializeReadContactsByLeadCommunicationsParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b62c39d0-3349-4a21-9582-0f3e9fab1b13"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,107,107,27,71,20,253,43,98,63,148,22,52,102,222,15,245,91,141,82,2,205,131,54,45,133,96,194,157,153,59,241,210,149,86,209,238,210,24,161,255,222,187,146,21,187,193,4,185,216,38,161,250,178,72,59,59,247,206,61,115,207,153,51,155,119,117,247,172,110,122,92,207,10,52,29,78,135,231,121,86,37,110,109,112,82,177,236,140,100,58,38,206,32,138,200,2,74,192,92,156,150,201,85,211,37,44,112,86,237,103,207,115,221,87,211,186,199,69,55,123,187,185,9,218,175,7,156,190,43,187,63,191,165,75,92,192,239,99,2,97,35,42,107,4,243,5,41,129,48,129,249,156,41,139,231,42,107,235,85,206,170,218,175,197,114,14,28,45,50,131,54,48,157,139,97,81,101,195,68,246,46,230,226,149,143,165,154,118,67,220,103,236,102,155,59,75,226,217,75,147,120,96,25,56,101,212,202,177,160,189,101,34,32,40,35,178,52,58,31,74,186,71,33,156,107,8,66,10,38,69,241,76,131,64,230,131,160,95,148,171,56,99,17,180,184,46,132,235,162,45,36,199,162,22,180,2,59,22,34,45,173,32,73,33,61,162,129,72,53,55,88,250,249,199,213,26,187,174,110,151,179,13,126,250,253,230,106,69,107,219,231,62,111,155,97,177,172,166,11,236,225,53,244,151,20,93,150,4,104,28,43,80,128,105,212,133,5,101,41,153,241,74,56,176,40,49,85,211,4,171,126,12,91,189,28,22,17,215,213,52,67,15,127,64,51,224,46,250,166,166,117,230,28,21,213,129,140,59,164,66,178,149,44,58,32,224,104,23,132,143,156,151,248,9,169,23,152,235,97,241,6,63,142,155,223,81,80,92,215,233,26,118,26,234,219,245,108,147,218,101,191,110,155,49,193,203,221,164,241,243,125,191,92,15,253,185,47,173,167,247,227,164,106,59,29,58,60,111,106,92,246,243,101,106,115,189,124,191,195,127,187,165,25,139,21,172,235,238,0,199,252,195,0,77,53,93,215,239,47,191,8,219,249,208,245,237,226,91,171,119,74,181,82,8,106,185,221,154,199,142,204,117,183,106,224,106,247,127,86,125,247,97,104,251,31,127,69,200,147,134,30,103,207,234,117,215,79,198,238,157,180,101,66,8,12,77,79,209,38,169,109,26,76,227,214,159,205,23,80,55,251,121,213,103,241,15,241,64,131,45,133,39,38,68,40,212,169,74,16,49,165,100,214,107,205,157,245,24,208,156,217,20,188,14,212,97,30,184,27,97,51,12,176,36,34,179,167,86,22,34,229,148,207,10,162,146,217,11,230,80,106,162,135,210,44,8,162,128,226,94,161,206,58,40,95,174,215,178,157,62,73,109,111,159,119,175,254,94,30,56,188,223,186,139,51,122,251,217,139,121,131,11,218,143,217,230,24,48,182,52,225,245,33,221,108,115,12,52,227,148,249,178,175,251,171,61,151,103,155,99,176,218,94,28,208,186,32,50,60,168,60,9,27,164,11,164,136,24,45,213,25,117,98,16,80,48,206,105,57,81,10,81,208,253,119,121,18,178,136,236,20,41,147,74,134,22,66,199,74,136,217,50,133,28,19,148,172,74,212,183,228,105,12,70,172,198,130,107,92,38,188,85,81,246,218,166,72,234,86,132,207,180,29,129,42,82,165,48,12,86,20,138,2,222,169,59,105,30,101,48,220,137,66,240,18,185,53,18,205,125,22,64,24,135,88,148,83,178,20,121,160,249,47,109,251,215,176,186,7,197,247,19,238,34,121,179,27,121,44,89,251,212,116,223,90,201,71,42,219,17,132,70,20,201,155,164,88,42,41,178,92,132,160,206,146,64,125,43,178,229,72,172,73,246,22,105,46,238,0,251,99,221,245,221,17,104,31,62,188,105,235,183,199,16,108,150,138,148,86,27,207,146,32,39,165,51,137,9,20,36,26,8,107,117,145,217,56,78,146,3,68,5,154,6,44,233,64,99,68,55,6,42,100,166,32,58,233,60,10,43,220,45,138,156,19,230,144,122,146,191,197,98,88,214,9,198,215,147,118,55,58,249,62,94,141,186,72,36,156,92,127,247,195,157,29,34,21,23,222,144,82,129,80,164,79,74,114,230,173,39,19,145,109,9,228,208,66,184,57,251,126,30,234,252,216,167,222,46,230,246,40,105,187,135,133,204,73,137,164,84,102,209,27,66,150,7,201,128,43,58,240,163,76,198,11,136,0,250,8,11,89,116,241,228,209,12,115,193,145,244,184,68,219,232,53,103,210,147,137,180,89,4,97,202,151,44,228,237,80,73,209,17,129,129,89,176,124,244,130,133,69,161,3,201,161,7,83,200,97,199,156,110,66,53,237,123,218,223,230,213,10,215,176,223,252,87,235,199,241,168,69,69,229,124,118,204,21,19,71,151,172,24,157,6,212,184,22,131,70,149,178,183,120,242,168,39,143,250,200,30,245,69,27,235,6,39,171,203,118,137,79,101,85,53,47,72,30,37,176,18,232,161,165,182,228,127,120,97,202,211,173,215,88,128,148,245,3,90,213,227,75,252,122,29,235,49,144,61,162,99,141,188,8,227,73,73,140,141,148,222,96,100,49,147,117,38,35,0,138,23,75,106,149,79,98,117,18,171,71,22,171,159,134,174,94,18,52,79,43,87,129,46,136,224,141,98,220,147,237,213,222,20,226,73,209,76,120,233,29,153,8,0,140,15,40,87,247,41,242,235,21,172,99,64,251,151,96,93,60,176,100,233,64,230,51,70,96,74,139,241,70,70,215,1,63,62,18,41,152,207,0,96,131,57,93,178,159,232,146,253,178,237,79,247,236,211,61,251,255,124,207,190,216,254,3,182,225,113,125,1,26,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15307ea3-405b-4286-937e-bbd0152634bb"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b0de7902-f6c1-44eb-87ff-109bad0eb346"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d29cd82a-8e0d-4086-8795-48b2899e16af"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("daf2cf98-3c7e-4055-b671-143255e4ffb9"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("34ed4a32-1e5a-4623-ae6a-18a622bf6230"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(aggregationColumnNameParameter);
			var orderInfoParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("97666c94-b7fa-4cf1-858f-96a7f5e41511"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("10568b26-1c18-4f39-9578-4a72a1c5fb66"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("935c4f95-44b6-44e3-920e-5b06a85a9a77"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("567adf56-c83c-4371-b0d7-e3c15c4a747e"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("7ad0d0ed-5315-4834-9632-bc717ea4b547"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("06ba8c97-f038-45da-8d5c-e5fa72c64ac0"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("085f20cb-53af-486b-a15f-5bc389f586df"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("7b7d4ca0-20b2-450c-a302-c217ce695e2c"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("316aa43c-1aa6-47f1-aaf7-572b6f838fcf"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2cc24615-28c1-4668-8f49-c93ae2c5896a"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b4d0581e-c249-4b18-a38c-f40592d4085d"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("daccd47e-87cf-45b8-baec-078cbbd8224d"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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
				UId = new Guid("04be8462-47b6-44e4-b31b-f6d0c69cfc7c"),
				ContainerUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
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

		protected virtual void InitializeChangeLeadContactAllParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("9a626ad2-321e-427a-9f24-760d9280a022"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("564a7988-620b-401f-9bfc-8041ac06be95"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b7b1963b-962d-4921-a62e-3119d14d8a66"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,47,58,244,100,21,219,146,44,201,61,46,219,178,80,210,64,211,82,72,150,240,36,61,103,5,254,216,88,50,77,48,251,223,43,175,179,41,228,80,74,111,5,33,158,158,52,163,153,65,154,239,125,248,232,219,136,99,221,64,27,48,155,118,174,38,96,100,201,76,33,168,212,144,83,46,28,167,32,211,164,43,172,74,99,140,2,231,72,214,67,135,53,89,209,91,231,35,201,124,196,46,212,183,243,111,210,56,78,152,221,55,231,197,87,123,192,14,190,45,23,240,2,26,165,81,83,41,114,67,57,26,67,149,5,75,155,134,105,83,113,197,11,180,100,213,98,12,22,86,54,142,90,203,52,229,54,87,84,75,97,40,2,128,49,78,48,11,140,100,45,54,113,251,116,28,49,4,63,244,245,140,175,245,205,243,49,169,92,239,222,12,237,212,245,36,235,48,194,53,196,67,114,138,57,114,97,129,90,174,5,229,13,74,10,76,59,202,150,8,164,194,162,42,36,201,44,28,227,66,75,118,201,182,131,8,223,161,157,240,204,60,251,164,177,100,121,161,68,149,176,5,179,148,179,50,167,170,82,146,54,174,106,52,178,74,107,243,154,215,167,201,167,218,135,171,169,195,209,219,151,216,49,229,55,140,245,108,135,62,142,67,187,80,95,157,143,223,224,83,92,195,125,217,250,177,26,138,169,191,128,200,41,155,2,110,90,143,125,220,246,118,112,190,127,88,57,79,167,4,233,142,48,250,112,73,97,251,56,65,75,178,209,63,28,254,152,214,102,10,113,232,254,35,171,89,178,153,56,210,35,59,203,93,222,160,243,225,216,194,243,121,93,147,119,143,211,16,63,124,70,112,59,183,214,228,13,166,38,119,164,96,121,110,4,67,90,234,42,153,83,66,81,197,42,69,185,102,224,108,41,64,114,123,71,146,142,127,98,191,221,133,47,63,251,203,63,88,149,239,223,167,238,155,198,245,5,89,207,127,35,232,180,95,36,237,79,105,252,2,165,40,182,209,206,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5d16c9f4-5c23-4097-8d07-fac1cb716e39"),
				ContainerUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,193,110,219,48,12,253,21,195,237,49,10,44,75,178,36,95,219,14,8,208,110,69,187,245,210,228,64,73,84,107,192,177,3,91,217,144,5,249,247,41,74,178,54,221,118,153,14,182,76,234,189,71,210,79,219,252,50,108,86,152,215,249,87,28,6,24,123,31,166,87,253,128,211,251,161,183,56,142,211,219,222,66,219,252,4,211,226,61,12,176,196,128,195,19,180,107,28,111,155,49,76,178,115,88,62,201,47,191,167,108,94,63,111,243,89,192,229,183,153,139,236,5,50,207,41,148,68,178,210,16,110,85,65,192,42,73,76,5,146,90,38,29,181,16,193,182,111,215,203,238,14,3,220,67,120,205,235,109,158,216,34,1,56,174,11,39,20,41,4,7,194,157,18,68,151,188,34,206,41,94,85,104,152,86,44,223,77,242,209,190,226,18,146,232,27,56,42,123,165,81,19,41,138,168,142,198,16,101,193,18,239,153,54,21,87,156,162,221,131,143,231,223,128,207,23,207,179,241,203,143,14,135,199,196,91,123,104,71,92,76,99,244,67,224,166,197,37,118,161,222,10,161,74,9,204,18,97,208,18,238,5,16,227,181,34,82,51,89,41,94,82,195,216,46,2,126,79,179,222,210,66,84,202,148,21,161,150,170,8,97,154,104,33,227,14,100,9,212,10,111,170,106,15,185,233,66,19,54,87,105,70,245,22,176,64,46,44,16,203,181,136,40,148,4,152,118,132,129,145,165,84,72,43,42,119,139,139,197,190,49,215,140,171,22,54,79,127,246,247,128,224,50,219,119,190,25,150,152,118,1,108,24,51,179,201,218,125,42,246,216,180,25,116,46,91,189,246,29,102,221,122,105,112,24,167,159,154,97,12,89,19,127,112,214,251,108,192,113,221,134,166,123,137,4,109,139,54,52,125,55,157,185,131,248,234,204,55,239,229,183,243,131,253,230,121,61,255,151,1,143,239,195,184,207,45,248,209,125,243,124,50,207,31,251,245,96,247,140,108,255,113,114,67,82,40,142,139,252,229,113,90,7,142,4,187,131,14,94,112,248,28,21,19,60,165,174,33,64,18,255,26,235,62,17,155,82,139,66,82,79,36,130,142,254,170,74,162,28,5,162,169,54,158,69,203,123,95,38,244,3,122,28,176,179,120,94,24,173,12,178,74,80,162,60,150,132,83,161,35,222,197,43,162,10,230,120,165,152,115,44,225,147,242,91,49,167,139,18,35,221,186,109,147,192,152,250,223,223,188,99,225,199,204,245,59,11,188,99,232,93,227,27,116,179,238,127,70,181,203,119,187,197,238,23,124,126,17,162,68,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeAddContactByLeadParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("c43dec79-6b59-4fc6-94f0-bcc6a7f8c091"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
				Value = @"16be3651-8fe2-4159-8dd0-a803d4683dd3",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("61b7d5bc-8334-4d0a-8ec3-aac02f0f6b0d"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ec4e60e4-4bd2-476d-bfa5-f3879991dce5"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
				UId = new Guid("fc9a7fd7-6ae6-4198-801f-ed65a0714560"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("0698fbce-2359-4022-88df-2b5fa4260af7"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,155,93,143,91,183,17,134,255,138,170,228,162,1,60,6,63,134,31,179,64,81,160,177,83,184,136,91,195,78,115,99,251,98,72,14,99,21,90,201,144,180,105,221,197,254,247,14,181,222,248,35,141,178,118,100,192,155,179,186,56,171,149,68,30,146,103,30,190,239,240,240,156,207,191,220,189,122,41,243,147,249,119,178,217,240,118,221,119,119,191,94,111,228,238,163,205,186,202,118,123,247,219,117,229,229,226,191,92,150,242,136,55,124,42,59,217,124,207,203,51,217,126,187,216,238,238,204,222,45,54,191,51,255,242,199,253,183,243,147,167,231,243,7,59,57,253,231,131,166,181,179,53,156,163,75,16,51,22,192,202,30,72,56,2,102,139,41,83,43,181,56,45,92,215,203,179,211,213,67,217,241,35,222,189,152,159,156,207,247,181,141,10,66,173,156,200,1,166,214,0,93,102,200,190,23,8,149,92,105,141,82,239,121,126,113,103,190,173,47,228,148,247,39,125,83,216,198,34,62,6,11,185,139,214,96,3,65,110,205,0,103,227,27,198,236,91,243,163,240,235,223,191,41,248,244,139,167,15,182,255,248,247,74,54,79,246,245,158,116,94,110,229,249,93,253,244,189,15,238,47,229,84,86,187,147,115,70,142,189,155,10,214,82,7,140,222,234,105,156,27,29,71,147,98,22,146,112,161,5,126,26,205,147,243,88,41,35,197,4,153,77,2,108,49,0,75,175,218,208,44,129,173,173,173,182,81,228,254,106,183,216,189,250,122,63,70,39,231,57,6,41,46,116,240,132,86,71,196,119,96,172,6,106,202,30,125,204,156,184,95,60,255,226,249,236,15,127,154,61,217,109,22,171,31,238,222,63,125,185,123,53,251,243,236,119,209,173,147,217,31,63,231,126,116,17,239,90,182,144,196,33,32,123,4,178,53,129,55,217,11,54,36,159,111,226,229,185,118,183,62,243,203,67,218,116,206,193,131,201,85,39,164,172,1,151,169,35,216,236,114,202,28,152,165,220,192,203,115,237,110,157,124,214,221,64,211,165,219,70,208,73,15,232,48,2,147,209,57,33,147,184,16,153,107,195,209,141,175,190,26,211,118,91,108,95,46,249,213,247,63,159,189,31,11,183,217,82,15,119,191,89,108,182,187,217,66,5,105,182,238,179,141,108,207,150,59,189,168,51,85,156,165,212,221,98,189,82,1,91,237,184,238,126,225,154,127,100,85,123,12,62,168,236,253,83,94,44,143,209,136,171,138,62,188,9,127,57,219,46,86,170,254,179,151,47,214,43,57,70,91,126,86,227,201,135,214,240,112,93,22,75,185,42,127,121,225,95,190,227,72,222,190,244,231,207,46,141,205,179,249,201,179,95,178,54,175,255,94,6,251,187,230,230,125,95,243,108,126,231,217,252,201,250,108,83,71,141,126,252,115,229,51,246,103,48,175,95,240,127,14,87,175,203,58,246,197,30,242,138,127,144,205,223,245,140,251,226,251,175,238,241,142,247,39,255,78,219,125,85,113,107,197,179,21,1,147,36,15,124,28,148,196,4,205,72,180,185,24,211,75,219,151,126,44,93,54,178,170,242,145,13,219,159,249,77,99,174,44,152,126,178,58,91,46,247,39,216,238,251,63,60,221,235,134,191,254,230,222,91,248,189,85,195,186,45,250,66,218,131,213,199,180,232,98,126,113,113,231,109,3,233,171,113,150,88,29,129,167,0,24,98,6,106,40,96,49,80,105,92,145,82,61,104,32,115,137,217,176,42,149,96,212,233,39,234,161,68,111,64,66,45,216,216,122,14,97,90,6,18,155,169,213,107,87,188,168,76,168,19,215,17,201,204,122,222,84,57,22,167,174,43,142,73,246,136,83,236,55,26,49,179,127,173,203,76,219,177,148,203,170,111,33,158,12,196,100,140,45,94,161,51,20,85,214,187,87,136,59,27,80,103,34,138,181,11,149,233,32,196,53,180,84,177,121,232,234,55,1,141,190,203,168,85,69,86,186,179,38,130,201,240,180,32,22,73,46,187,22,193,121,167,134,15,245,108,165,167,2,182,52,39,182,251,200,33,31,25,226,39,90,108,199,227,237,45,192,19,3,152,61,81,46,174,131,113,137,149,191,20,64,225,65,245,229,108,139,152,84,157,28,86,97,194,90,114,10,10,93,139,202,133,100,3,37,104,186,146,26,137,213,228,37,135,40,211,2,184,166,94,44,25,129,96,155,198,86,29,165,66,43,80,125,178,58,211,21,195,61,29,25,224,123,162,200,238,70,63,167,2,112,113,20,76,178,29,146,40,182,40,10,112,110,150,129,44,149,238,147,119,189,187,67,0,39,118,145,156,211,80,139,65,47,109,9,99,150,45,8,82,36,80,20,180,212,242,205,0,88,37,146,50,53,29,3,231,85,129,107,3,50,122,232,222,26,83,154,170,171,224,65,128,61,34,122,237,177,186,239,88,198,250,143,1,242,138,114,207,194,24,186,227,86,112,90,0,51,231,170,97,132,90,125,47,99,101,26,161,12,123,147,187,13,154,96,176,11,82,143,12,240,223,166,230,160,127,43,191,53,59,117,136,93,91,162,241,167,41,100,138,64,92,60,212,160,49,167,243,108,73,37,222,8,126,99,48,212,189,203,80,204,32,168,96,129,236,162,230,108,170,204,170,26,70,29,95,62,200,175,45,42,51,221,43,251,205,141,145,80,237,85,103,211,134,179,177,182,235,56,89,235,166,197,111,38,54,166,117,11,190,249,177,162,29,61,20,143,21,28,165,220,106,79,98,88,142,45,192,235,217,106,189,155,157,109,101,38,151,139,116,211,192,152,76,137,161,244,12,166,239,47,11,106,36,165,68,224,208,25,125,195,157,76,154,132,143,118,197,75,194,177,224,226,171,14,4,113,6,246,58,36,201,57,50,62,208,24,159,131,24,39,209,25,17,163,198,107,211,180,68,53,57,67,246,174,2,37,244,88,108,119,132,126,90,24,163,254,186,98,180,80,220,184,49,213,185,67,150,38,80,181,171,45,120,238,232,63,33,198,79,30,62,185,133,120,98,16,107,34,91,180,207,30,26,177,14,132,134,178,166,7,82,160,167,104,49,196,38,33,132,131,16,59,159,53,237,77,8,189,91,229,80,208,140,213,172,4,62,168,21,167,166,105,70,110,211,130,56,160,137,169,118,15,214,247,160,94,186,105,247,52,160,70,142,18,53,59,169,41,37,255,233,32,190,149,226,9,82,172,180,148,130,202,174,102,106,154,22,23,21,143,92,208,131,230,245,106,180,109,112,78,57,58,184,51,41,150,218,99,23,96,19,199,206,36,53,211,236,212,68,246,236,72,170,152,208,27,77,139,226,177,12,152,37,235,116,88,198,13,187,88,84,148,125,142,234,80,48,27,114,169,181,116,236,53,233,183,40,126,125,135,248,22,227,73,97,108,91,107,97,244,156,162,122,97,76,168,25,190,11,5,92,163,220,92,67,27,235,225,133,45,21,92,97,105,65,93,35,42,137,166,26,160,162,145,171,120,119,137,73,203,243,196,22,182,172,66,108,154,14,129,9,163,84,82,107,67,169,38,117,212,37,101,66,227,153,219,167,195,184,243,127,110,33,158,26,196,85,77,243,200,220,92,29,161,157,56,142,101,102,4,10,138,166,83,61,165,96,14,223,31,150,230,178,209,148,58,225,88,222,182,41,0,101,138,32,28,200,49,73,182,28,143,15,241,30,209,67,20,252,244,131,219,88,158,76,44,123,155,13,178,6,96,103,209,84,134,156,74,83,214,129,16,54,45,177,113,216,126,69,144,186,74,78,105,154,94,114,102,85,52,77,127,128,40,105,56,154,154,40,235,180,77,244,9,98,249,115,22,36,238,141,43,91,4,59,212,25,147,150,47,182,35,72,51,145,48,54,159,46,55,183,30,115,79,40,111,39,227,37,127,235,77,22,241,149,220,184,253,101,145,212,246,227,216,221,147,199,93,254,210,67,43,130,37,99,186,17,232,70,106,228,132,80,243,56,210,56,195,50,20,40,210,184,91,52,108,96,112,28,15,47,236,120,246,222,166,58,246,57,245,8,168,233,32,140,125,19,96,172,14,104,101,118,213,79,12,93,23,18,91,77,167,161,99,208,36,57,199,12,165,163,162,75,221,57,74,49,218,118,236,133,157,191,202,170,201,230,22,222,235,193,107,74,13,45,107,160,106,226,62,54,131,214,6,69,5,27,188,41,222,55,171,241,236,110,134,238,154,166,49,165,144,170,52,52,28,89,11,66,182,53,128,134,101,79,57,69,70,228,195,186,155,84,96,163,99,85,25,157,193,144,56,1,123,201,208,29,246,146,107,111,34,125,90,240,34,107,102,61,104,141,181,167,177,235,210,12,221,205,99,92,93,237,49,120,106,246,200,240,62,94,223,110,110,184,46,186,1,153,211,40,223,203,120,162,178,141,205,13,206,147,78,176,221,119,99,68,188,132,27,129,46,165,228,56,116,15,198,89,37,207,91,171,186,219,29,104,210,22,162,52,149,206,240,43,107,56,165,59,227,164,66,69,28,236,83,129,82,213,32,54,141,238,98,115,244,206,216,105,161,123,221,199,245,142,136,238,253,41,221,70,185,221,25,124,229,153,185,54,217,219,58,23,116,18,74,97,108,76,234,29,10,161,26,63,91,77,179,246,240,206,224,44,38,7,13,77,110,168,14,145,171,90,145,106,171,90,232,34,70,51,231,216,112,98,235,175,215,125,8,242,136,236,190,251,144,221,45,194,147,66,216,8,42,100,190,107,158,27,5,198,158,72,200,68,13,76,238,29,107,236,182,199,120,248,17,59,212,12,217,100,134,148,21,64,180,164,179,1,71,6,135,190,82,208,156,216,152,50,45,132,175,251,56,246,17,17,126,255,73,219,91,136,127,239,16,63,191,248,31,53,148,11,47,198,69,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("77a80f56-4b60-48bc-be27-e96ffd4cc59b"),
				ContainerUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
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

		protected virtual void InitializeAddContactAdressParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("5a0a517a-3cd6-4838-89ed-dd198ad96f83"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
				Value = @"d54d2218-61c8-413a-a1b7-5748c7e25f56",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("dcf0939b-5ae1-4506-a7a2-453c0eb2f2d8"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,89,111,27,55,16,254,43,193,62,244,73,211,240,62,212,167,214,117,91,3,185,0,167,69,209,196,8,134,228,48,94,116,165,85,164,85,26,215,240,127,239,172,21,37,66,42,7,137,93,167,8,96,8,16,86,212,114,150,156,239,224,204,158,191,104,87,63,181,221,64,203,105,197,110,69,147,245,81,153,54,74,197,26,141,11,32,146,114,96,82,12,16,188,170,16,172,66,237,139,183,57,234,102,50,199,25,77,155,205,236,195,210,14,205,164,29,104,182,154,62,59,127,31,116,88,174,105,242,162,94,254,56,206,167,52,195,95,199,7,24,137,53,68,138,224,173,72,96,40,37,8,25,51,212,170,99,114,38,24,73,185,217,172,37,186,160,40,151,10,214,103,5,38,186,8,65,103,3,154,168,104,229,100,205,54,52,147,142,234,112,248,102,177,164,213,170,237,231,211,115,122,119,253,244,108,193,171,220,60,251,160,239,214,179,121,51,153,209,128,79,112,56,157,54,72,130,140,205,8,217,68,11,166,146,7,212,177,128,198,228,149,15,36,157,244,205,36,227,98,24,195,54,71,165,153,20,28,240,55,236,214,116,25,249,188,29,243,165,133,12,214,241,92,169,51,24,173,4,4,23,60,212,226,106,36,237,98,76,101,155,175,159,215,45,95,183,171,71,235,25,45,219,252,54,237,196,249,235,151,211,243,220,207,135,101,223,141,161,31,93,222,254,148,222,12,155,228,190,253,235,247,205,134,6,30,31,39,53,23,147,245,138,14,186,150,230,195,225,60,247,165,157,191,220,196,188,184,224,41,179,5,46,219,213,54,11,135,175,214,216,53,147,101,251,242,244,163,217,58,88,175,134,126,246,21,109,117,194,219,228,24,76,178,203,229,142,28,44,237,106,209,225,217,229,239,105,243,205,171,117,63,124,247,128,176,28,149,205,117,243,193,156,105,243,188,145,90,136,100,53,129,138,142,55,23,44,243,94,179,12,76,212,88,178,178,232,77,126,222,240,58,174,21,253,217,209,234,241,95,243,173,14,54,43,63,249,150,71,63,24,120,178,157,57,61,255,148,5,93,156,140,75,58,97,184,207,247,138,57,200,40,48,214,12,49,20,214,154,172,30,2,25,1,34,147,172,38,71,89,45,109,17,99,33,245,47,219,140,221,227,5,45,113,195,249,199,203,219,17,54,57,169,68,173,8,197,167,2,166,88,13,72,54,66,210,210,228,196,83,85,114,215,23,182,115,163,89,121,11,73,41,98,158,70,1,24,216,69,76,12,28,190,36,33,181,220,17,246,247,165,140,97,239,13,28,148,5,66,149,150,52,207,180,179,51,43,130,246,169,142,156,175,28,198,185,4,209,240,246,10,137,96,60,177,69,201,180,87,49,73,69,43,188,172,224,9,35,167,196,41,8,69,34,68,25,83,213,94,171,90,213,54,255,15,250,254,207,245,226,51,52,179,153,176,79,53,221,229,63,87,234,102,196,239,6,14,241,142,163,95,219,150,63,209,41,126,233,103,116,149,146,55,227,166,134,164,10,27,161,151,69,128,177,149,153,30,61,65,46,6,181,8,24,125,22,111,35,124,40,206,155,107,135,175,179,175,20,160,122,195,236,14,85,142,154,142,124,94,135,164,139,87,50,11,113,167,157,47,172,157,35,126,112,215,53,255,49,212,198,235,202,110,47,57,119,35,207,170,151,16,133,102,168,117,180,73,5,233,83,184,65,253,115,7,245,157,77,222,192,38,127,88,175,218,57,111,248,227,86,89,147,71,93,29,66,213,76,7,105,164,0,87,131,4,153,93,117,150,172,208,70,223,154,85,114,65,106,148,244,154,219,24,100,134,91,207,165,171,48,92,225,179,91,87,85,178,192,108,238,244,115,167,159,255,69,63,63,82,215,190,166,229,217,199,245,227,157,72,213,5,230,68,114,4,165,74,9,220,146,115,119,46,100,113,130,162,14,217,237,232,231,228,170,78,64,115,105,45,85,141,64,154,85,96,108,68,238,232,249,75,22,27,144,28,119,192,239,123,183,47,217,9,56,118,0,238,102,60,168,156,184,197,199,177,167,68,158,169,121,148,124,64,95,71,206,95,87,162,197,179,3,20,193,4,241,145,79,209,24,53,68,171,18,144,136,94,132,144,172,205,110,71,162,7,253,154,193,62,219,175,78,193,125,20,119,77,1,172,180,12,7,119,101,28,43,23,222,89,137,186,250,136,46,215,175,141,170,123,11,153,126,184,141,90,134,135,148,15,182,130,69,238,246,184,134,229,110,47,160,130,108,21,83,57,80,22,49,223,0,232,76,90,144,14,192,60,103,122,139,164,89,38,213,130,8,201,71,193,0,25,37,118,128,62,30,112,160,251,139,101,255,186,101,144,247,227,93,145,247,99,162,7,114,200,11,174,172,193,96,185,255,182,165,154,84,20,134,20,229,29,222,87,226,141,46,5,138,206,65,53,227,173,106,172,93,37,159,109,202,42,147,101,50,137,197,115,125,188,89,136,218,102,198,219,241,65,14,166,48,66,99,153,1,133,117,105,16,11,42,179,43,236,63,142,158,220,95,244,171,1,187,123,156,14,218,11,155,30,95,169,232,196,214,90,13,83,200,32,59,145,145,10,216,129,93,245,65,8,141,121,11,219,241,105,191,28,198,119,86,183,253,138,235,75,163,102,92,201,168,148,132,18,88,61,134,133,3,152,98,134,108,180,145,49,160,100,11,188,62,106,70,217,144,28,215,73,149,152,14,134,75,67,8,108,10,80,5,250,20,75,49,156,230,93,59,110,135,43,188,216,102,140,34,113,85,25,53,141,88,153,0,137,111,227,181,90,233,28,101,149,235,126,144,239,180,121,116,153,5,235,56,93,18,116,181,134,143,69,82,144,76,149,128,18,45,247,156,217,36,77,215,71,217,179,242,141,203,14,28,142,28,18,89,241,65,233,29,216,108,75,202,162,56,37,196,191,235,226,189,112,101,81,133,113,92,29,240,23,55,192,60,155,53,73,150,203,98,25,75,14,12,118,146,91,184,30,226,155,227,246,111,250,76,85,62,164,89,191,15,177,25,143,223,0,175,19,254,252,3,145,229,15,109,96,25,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55cf3377-2bf5-4a73-8eb5-34e7b911258b"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
				UId = new Guid("6d55db5f-8e6c-420b-9a07-be564e8b90da"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6aa29df7-9dcf-4eea-b7dd-70cbb55c6070"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,93,111,91,69,16,253,43,198,229,1,164,140,217,239,15,75,8,65,41,40,82,11,21,5,30,104,250,48,187,51,91,44,156,123,163,235,235,162,18,229,191,51,215,73,104,90,192,84,109,30,90,92,63,56,241,93,207,236,238,236,156,57,103,214,231,243,143,199,231,103,60,95,206,127,228,97,192,77,223,198,197,221,126,224,197,195,161,175,188,217,44,238,247,21,215,171,63,176,172,249,33,14,120,202,35,15,63,227,122,203,155,251,171,205,120,52,123,217,108,126,52,255,248,217,110,116,190,124,124,62,63,30,249,244,167,99,18,239,186,218,128,214,50,40,27,3,56,12,22,176,228,4,181,54,111,75,13,170,150,38,198,181,95,111,79,187,7,60,226,67,28,127,157,47,207,231,59,111,226,32,176,78,62,151,4,30,189,5,231,109,132,162,27,67,139,200,169,22,167,125,112,243,139,163,249,166,254,202,167,184,155,244,133,49,121,71,198,232,4,65,215,4,78,91,4,212,37,130,143,46,213,200,198,55,31,38,227,171,239,191,48,124,124,231,241,241,230,251,223,59,30,30,237,252,46,27,174,55,252,100,33,79,95,121,112,111,205,167,220,141,203,115,148,205,181,166,42,104,157,27,184,96,53,96,50,6,66,114,78,197,144,56,179,191,16,131,191,162,185,60,15,53,39,151,67,132,132,42,130,163,224,1,185,85,89,104,98,143,90,87,170,52,153,220,235,198,213,248,252,238,46,70,203,243,24,74,114,161,6,8,216,60,56,85,13,100,47,193,245,213,83,169,138,130,81,234,226,201,157,39,211,198,104,181,57,91,227,243,159,255,190,191,31,24,105,182,150,183,197,55,171,97,51,206,86,114,100,179,190,205,6,222,108,215,227,170,123,58,147,51,89,115,29,87,125,183,248,146,72,158,111,46,125,158,189,148,14,55,189,158,159,92,102,213,201,124,121,242,111,121,117,245,247,50,138,47,103,214,171,73,117,50,63,58,153,63,234,183,67,157,60,218,233,195,245,33,239,102,80,87,47,248,135,183,235,215,165,143,157,217,3,236,240,41,15,223,201,140,59,243,221,208,215,56,226,110,242,31,101,221,215,142,171,106,202,5,35,71,34,177,4,39,65,133,228,216,67,118,58,83,77,94,135,162,119,214,63,112,227,129,187,202,111,184,176,221,204,47,22,115,157,255,242,164,219,174,215,187,9,54,187,253,79,128,186,90,248,213,200,215,55,78,246,134,135,158,86,109,197,116,220,189,201,138,46,230,23,23,71,55,209,171,40,146,73,174,1,133,74,83,130,70,137,65,44,146,175,214,197,216,42,165,168,247,162,87,59,235,43,181,34,41,173,13,56,46,14,138,10,25,146,202,134,88,233,24,66,60,44,244,58,227,83,9,89,65,227,168,37,183,34,66,50,49,65,83,24,75,38,114,49,221,54,122,239,202,244,135,2,221,98,178,87,81,55,136,140,89,18,46,24,72,164,17,178,206,165,217,104,77,107,102,31,116,125,197,172,74,16,3,203,114,168,206,37,40,242,77,33,45,65,125,224,106,106,227,247,2,186,178,206,166,115,46,128,213,73,158,81,98,40,41,17,84,54,169,209,148,219,41,236,133,110,172,65,171,104,42,20,52,78,152,187,88,72,218,32,4,27,157,70,203,69,74,228,97,65,151,117,147,106,102,101,83,177,73,49,35,20,45,99,91,0,114,38,59,68,146,56,133,91,134,238,47,199,15,63,59,235,55,35,174,229,41,241,161,160,216,26,143,209,138,232,83,205,77,40,196,137,128,133,64,98,80,161,73,129,84,22,235,65,16,176,39,217,109,20,122,32,41,101,146,158,92,132,63,89,131,85,36,162,58,250,170,242,127,16,112,80,217,38,159,0,91,145,50,96,109,144,50,80,42,120,163,125,22,212,36,209,144,239,4,138,53,182,164,12,101,200,205,136,206,55,74,22,154,171,20,94,86,69,41,175,8,51,191,130,226,24,49,41,89,130,176,104,16,153,54,109,171,176,168,54,206,82,15,200,213,42,125,195,127,227,81,180,237,108,219,213,190,107,171,225,148,73,112,214,141,88,199,89,193,141,124,234,187,29,86,103,171,174,245,195,41,94,242,233,192,56,202,216,192,181,31,104,118,76,135,2,203,183,37,87,209,205,108,131,215,144,26,75,1,149,12,20,123,82,82,174,149,37,23,146,37,178,239,5,44,139,161,168,178,80,78,179,78,116,177,166,0,25,171,6,66,71,210,161,22,227,13,238,133,101,149,114,150,155,108,189,185,148,39,118,118,144,114,8,80,109,139,142,156,162,236,15,172,171,165,202,86,177,144,171,45,210,226,59,37,114,163,100,233,111,85,42,49,75,60,172,148,132,91,38,215,71,163,192,248,179,179,161,127,182,146,84,253,0,226,215,3,113,195,169,141,203,82,102,131,8,32,215,82,133,228,67,2,79,205,21,50,152,74,214,239,5,136,107,66,98,199,8,154,138,4,162,146,196,32,86,15,194,35,58,165,154,168,101,181,23,196,164,53,97,197,137,146,173,84,1,20,234,145,206,161,64,86,78,82,92,210,182,82,190,125,16,143,131,252,217,3,130,235,241,255,127,38,79,141,154,47,109,82,137,187,242,34,125,78,138,49,131,145,82,33,255,160,156,95,60,8,149,40,73,108,116,112,74,248,199,136,200,195,42,173,26,139,112,22,42,145,182,45,182,210,244,254,75,86,21,36,113,177,26,144,104,182,75,98,206,117,42,245,44,18,139,68,71,81,196,3,163,163,152,139,35,37,117,33,102,9,105,206,22,178,55,5,88,229,168,82,42,222,215,219,238,245,238,246,219,110,28,62,220,212,188,38,15,169,220,170,116,228,66,60,218,203,105,154,44,26,204,87,130,36,85,87,84,84,198,80,219,123,129,94,182,53,59,111,2,88,163,157,244,50,98,145,165,197,5,1,46,113,148,172,181,62,237,231,161,146,149,151,144,9,5,79,183,180,211,197,149,232,208,0,34,69,69,83,215,98,20,149,219,71,239,39,239,50,124,67,72,34,193,163,135,98,12,75,72,242,212,100,144,76,153,147,22,166,47,74,91,61,193,119,246,209,231,179,111,183,43,90,220,59,61,27,159,127,58,251,98,246,191,216,213,82,182,113,191,239,127,219,158,45,188,74,210,144,76,174,109,155,22,23,68,159,184,82,128,88,37,23,153,43,233,178,104,37,78,55,89,40,253,140,140,11,145,42,8,45,105,208,53,180,224,217,43,235,236,254,90,247,201,155,253,162,52,155,42,217,63,31,195,219,184,187,177,255,155,35,139,175,182,155,85,119,64,63,100,189,245,109,248,107,36,207,187,90,99,159,92,252,9,127,53,51,13,228,30,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b9f11eba-9282-49e7-842b-28c1d0f2190f"),
				ContainerUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
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

		protected virtual void InitializeAddContactWebParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("2e155463-3ff1-4ccf-8584-4ec8d7233111"),
				UId = new Guid("97a7e2ca-58ad-4a27-8a87-3f50772b77be"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
				Value = @"004a9121-21f8-4a1e-8918-45c0f756ea41",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaIdParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2f713b4e-bdb9-470a-b959-23af1cb99aaa"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,203,106,220,48,20,253,23,45,186,242,45,214,195,150,228,46,195,180,12,180,211,64,211,7,36,33,232,113,149,24,252,152,216,50,77,24,230,223,43,143,51,77,9,161,148,208,46,186,187,146,124,142,206,61,58,215,187,171,122,124,91,55,17,135,42,152,102,196,108,90,251,138,104,153,115,227,114,1,38,20,26,4,211,6,84,201,13,104,169,156,247,69,94,50,199,73,214,153,22,43,178,160,87,190,142,36,171,35,182,99,117,190,123,36,141,195,132,217,85,56,44,62,185,27,108,205,231,249,2,65,77,80,26,53,200,34,183,32,208,90,80,206,56,8,129,107,91,10,37,40,58,178,104,9,190,228,46,4,10,142,210,0,66,249,36,131,5,1,165,181,78,107,157,11,198,144,100,13,134,184,186,219,14,56,142,117,223,85,59,252,89,159,221,111,147,202,229,238,147,190,153,218,142,100,45,70,115,106,226,77,69,12,230,40,10,103,192,9,93,128,8,40,193,112,237,129,27,43,153,84,72,75,42,73,230,204,54,206,180,100,237,73,230,77,52,95,76,51,225,129,121,87,39,141,140,231,84,21,101,194,82,238,64,112,150,39,191,148,132,164,61,104,228,165,214,214,31,253,122,55,213,169,174,199,205,212,226,80,187,7,219,49,249,215,15,213,206,245,93,28,250,102,166,222,28,62,63,195,187,184,152,251,112,244,109,105,40,166,253,25,68,246,217,52,226,73,83,99,23,87,157,235,125,221,93,47,156,251,125,130,180,91,51,212,227,209,133,213,237,100,26,146,13,245,245,205,111,221,58,153,198,216,183,255,81,171,89,106,51,113,164,144,29,228,206,25,244,245,184,109,204,253,97,93,145,87,183,83,31,223,188,71,227,215,126,169,201,19,76,69,46,8,229,121,110,11,142,192,116,153,154,83,133,2,197,75,5,66,115,227,29,43,140,20,238,130,36,29,47,98,63,95,143,31,191,119,199,57,88,148,95,190,78,187,79,54,78,143,200,106,247,39,130,246,151,179,164,203,244,220,127,117,238,184,66,230,149,16,192,12,19,32,156,83,160,189,161,192,37,99,60,8,233,184,167,47,159,59,148,5,215,52,245,68,133,167,233,15,67,57,88,43,37,104,206,133,47,176,180,65,134,95,230,238,43,218,103,211,232,189,229,134,34,66,46,49,185,226,75,6,86,26,13,62,199,146,42,155,231,225,49,141,31,82,134,166,118,14,217,191,206,228,108,254,51,211,183,30,55,125,220,76,77,51,191,214,15,192,153,222,106,121,5,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordAddModeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9021827f-1e50-40f2-8b7f-ec1b0e056ccb"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
				UId = new Guid("aa2e3f7d-4042-4910-b0eb-0f5b57896d58"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(filterEntitySchemaIdParameter);
			var recordDefValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7a98d7a0-39d9-4231-b19a-9c603fa6baf0"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,229,150,75,111,219,70,16,199,191,138,192,228,232,21,246,253,208,173,112,82,64,128,147,26,73,154,30,108,31,102,119,103,19,34,20,41,144,84,11,87,208,119,239,144,150,235,71,91,39,104,81,192,64,120,144,72,174,254,51,179,59,243,155,209,190,122,57,94,111,177,90,85,31,176,239,97,232,202,184,60,237,122,92,158,247,93,194,97,88,158,117,9,154,250,119,136,13,158,67,15,27,28,177,255,8,205,14,135,179,122,24,79,22,15,101,213,73,245,242,215,121,181,90,93,236,171,245,136,155,159,215,153,172,67,202,193,139,28,88,206,41,51,173,81,48,143,192,153,149,144,115,182,129,187,172,72,156,186,102,183,105,223,224,8,231,48,126,174,86,251,106,182,70,6,82,145,210,106,227,89,18,137,51,157,121,98,80,208,48,45,172,213,69,102,227,56,86,135,147,106,72,159,113,3,179,211,59,49,231,26,130,144,130,73,81,60,211,32,144,249,32,232,206,36,94,156,177,8,90,76,226,227,239,239,132,23,47,46,214,195,79,191,181,216,191,159,237,174,10,52,3,94,45,233,237,163,23,175,27,220,96,59,174,246,2,138,231,146,118,26,138,84,76,75,110,89,12,9,25,32,143,156,27,158,33,224,129,4,127,158,230,106,239,28,120,94,140,101,58,90,218,155,143,137,69,148,142,97,176,165,100,157,146,9,241,112,245,226,106,10,49,215,195,182,129,235,143,127,141,244,135,156,23,187,54,117,109,169,251,13,230,5,221,141,144,198,69,132,129,158,186,118,209,32,228,69,221,150,174,223,192,88,119,237,242,180,71,24,105,173,199,212,245,121,177,206,55,46,182,15,242,124,223,201,254,242,166,92,46,171,213,229,63,21,204,241,251,230,120,30,150,204,227,106,185,172,78,46,171,247,221,174,79,147,69,53,61,220,102,111,246,192,143,23,251,155,143,219,235,198,198,44,123,3,45,124,194,254,45,121,156,229,243,210,43,24,97,118,254,129,226,190,53,28,101,48,220,137,194,28,66,96,26,173,100,62,11,96,65,132,88,148,83,178,20,57,171,223,97,193,30,219,132,15,3,19,54,162,178,134,106,184,160,164,18,52,129,244,153,51,74,163,202,218,122,149,179,154,245,179,231,187,96,110,11,155,222,180,187,166,153,29,12,243,254,39,82,142,129,31,87,94,221,75,244,61,11,93,174,75,141,121,221,254,155,163,58,84,135,195,201,125,44,165,231,134,2,6,198,5,70,166,3,16,85,134,216,148,222,27,239,163,177,90,241,39,177,228,178,36,64,227,88,129,2,116,146,186,176,160,172,99,209,120,37,28,88,148,152,158,5,150,160,129,96,162,174,33,68,40,76,91,37,40,91,82,50,235,181,230,206,122,12,104,30,97,105,83,240,58,208,102,60,112,71,45,199,26,130,184,36,202,183,71,3,66,36,106,101,147,228,117,59,214,227,245,233,124,70,171,61,58,163,130,176,228,72,103,65,252,11,197,98,116,142,142,69,233,108,208,198,226,202,215,97,126,55,177,58,1,187,252,177,238,135,113,81,83,202,22,93,33,84,135,93,51,214,237,39,194,187,105,48,205,28,255,130,241,123,33,55,231,168,168,78,144,113,135,126,202,137,100,209,17,195,153,163,21,158,26,108,137,249,41,114,191,57,176,231,78,110,12,62,4,71,228,202,68,141,107,30,51,94,144,76,10,155,121,142,134,102,7,60,73,174,144,69,100,167,72,171,18,141,81,48,146,133,152,45,83,200,49,65,201,170,68,253,127,144,123,214,117,95,118,219,101,246,218,166,72,237,162,8,79,127,8,108,32,11,170,148,105,230,137,66,190,193,59,181,180,224,35,4,154,132,214,165,196,114,17,130,98,148,212,173,184,200,150,99,80,62,217,175,145,116,244,119,218,109,54,187,182,78,243,228,91,116,219,249,107,34,226,123,162,231,191,206,189,111,73,218,115,165,231,234,240,7,216,177,74,219,236,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordDefValuesParameter);
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("89ff5387-057a-41f9-a2cd-98c33da073a9"),
				ContainerUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
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

		protected virtual void InitializeReadContactsByLeadEmailParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d6514abc-f96a-4d19-b5f8-f55b1ac00b83"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,86,219,138,220,70,16,253,149,65,15,33,1,245,210,247,139,242,184,140,131,33,113,76,226,132,192,178,152,234,238,106,175,136,52,90,143,36,178,203,48,255,158,210,92,236,197,44,97,28,226,128,95,134,81,183,234,114,78,215,57,173,221,219,118,124,209,118,19,110,155,2,221,136,245,252,50,55,21,40,84,70,9,205,156,23,158,105,41,20,139,156,23,166,162,137,30,117,241,17,75,85,111,160,199,166,58,70,175,115,59,85,117,59,97,63,54,55,187,143,73,167,237,140,245,219,114,120,248,53,221,97,15,191,45,5,132,141,168,172,17,204,23,148,76,11,19,152,207,153,51,240,92,101,109,189,202,89,85,167,94,120,200,8,50,51,99,32,51,29,149,101,16,108,98,54,131,214,70,89,107,133,175,234,113,142,199,138,99,179,123,22,82,180,57,1,181,206,114,208,129,32,21,130,36,108,33,132,198,41,167,99,144,138,159,33,125,6,16,206,53,4,33,5,147,162,16,83,32,144,249,176,112,102,18,47,206,88,4,45,78,64,76,40,84,40,71,230,164,7,166,185,10,44,42,138,132,146,61,15,54,23,153,114,85,119,88,166,245,195,253,22,199,177,29,54,205,14,63,252,127,243,120,79,189,29,107,95,15,221,220,111,170,186,199,9,94,195,116,71,141,200,66,248,140,99,5,10,101,95,144,6,101,29,139,198,43,225,192,162,196,84,213,9,238,167,37,109,245,106,238,35,110,171,58,195,4,191,67,55,227,33,251,174,165,62,115,142,138,112,32,227,14,9,72,182,146,69,7,129,101,142,68,245,50,7,49,159,153,250,9,115,59,247,111,240,97,57,252,145,146,226,182,77,39,218,105,107,26,182,205,46,13,155,105,59,116,75,129,87,135,160,229,245,227,188,156,182,254,56,66,155,104,125,9,170,246,245,60,226,117,215,226,102,90,111,210,144,219,205,187,3,255,251,61,69,244,247,176,109,199,51,29,235,247,51,116,85,189,109,223,221,253,35,109,215,243,56,13,253,215,134,183,38,172,148,130,70,238,208,243,50,145,185,29,239,59,120,60,60,55,213,55,239,231,97,250,254,23,132,188,234,232,231,234,69,187,29,167,213,50,189,171,161,172,136,129,185,155,40,219,42,13,93,135,105,57,250,171,117,15,109,119,140,171,62,201,127,206,7,26,108,41,60,49,33,66,97,218,42,26,82,47,37,179,94,107,238,172,199,128,230,202,166,224,117,160,9,243,192,221,66,155,97,128,37,145,152,61,26,16,34,229,148,175,10,162,146,217,11,230,80,106,146,135,210,44,136,228,152,226,94,161,206,58,40,95,78,189,236,235,255,5,219,205,203,241,231,191,54,103,13,31,143,238,246,138,86,63,89,88,119,216,211,121,52,187,75,200,216,83,192,235,115,185,102,119,9,53,75,200,122,51,181,211,227,81,203,205,238,18,174,246,183,103,182,110,73,12,255,169,61,41,17,16,181,114,84,148,122,208,177,32,131,44,3,227,116,19,112,75,155,50,194,191,183,39,33,139,200,78,145,51,169,100,168,17,35,89,136,217,50,133,28,19,57,160,42,81,63,177,167,37,25,169,26,11,110,113,147,240,9,162,236,181,77,145,220,173,8,79,215,129,13,132,72,149,194,48,88,81,40,11,120,167,158,149,121,148,193,112,39,200,241,145,196,173,145,100,238,179,0,130,27,34,25,179,146,165,200,179,204,127,28,134,63,231,251,207,144,248,49,224,57,145,119,135,157,47,101,107,31,134,238,107,131,124,161,179,93,32,104,68,145,188,73,138,165,146,34,203,69,8,154,44,9,140,115,145,45,71,82,77,178,79,68,115,251,12,217,15,237,56,141,23,176,125,126,241,227,88,223,92,34,176,38,21,41,173,54,158,37,145,56,249,1,153,9,20,36,25,8,107,117,145,217,56,78,150,3,36,5,10,3,150,116,160,189,130,142,129,10,153,41,136,78,58,143,194,10,247,68,34,215,196,57,164,137,236,175,239,231,77,155,96,89,94,13,135,221,213,183,241,113,241,69,18,225,234,244,222,119,207,78,8,125,244,8,111,200,169,64,40,242,39,37,57,243,214,211,71,68,182,37,208,23,90,8,31,239,190,31,230,54,127,233,91,239,144,115,191,156,210,223,79,53,226,96,153,10,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("881a211c-0037-4de8-9966-fd5b76082530"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b0558b6-d02e-43db-a632-da912ff74169"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("38ac0d8a-57fb-4d3c-a724-83243171725c"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2306c9f4-91b3-4ae6-9d0d-b85b15f043a5"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("91e3ad56-02d2-495e-8f8d-6839c1e13901"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("09b2ffa0-b537-4970-bb51-a8da7fb89215"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,176,50,208,241,76,1,81,0,240,89,28,178,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("4e1e0793-a5ec-42a4-b7b6-dcf4eb1670ee"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f289649e-c0c3-403b-8124-ffe171aafe33"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("e7d2a1ae-2033-4d71-9990-c4c12f4faa89"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("681c5445-3ca2-45de-bf7c-0f37318944d1"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("95b392b6-a727-407b-a3ec-157c1314469b"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("0eadc500-3c91-49a1-8071-9d0668f51d38"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("849f1602-4ec0-45ef-a640-370b4ec656e7"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("847ce0c0-4e8f-4238-a637-16f20d906278"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1cfe3a33-faaf-4cb5-b49e-d1eadaa81bec"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f61ce3ad-7460-43d4-b04a-9a8735ba629d"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("df66e2ab-a26c-4a4a-b713-f5ddc931a4ae"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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
				UId = new Guid("b3be71cf-1a55-46fd-a923-94a785cee174"),
				ContainerUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
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

		protected virtual void InitializeChangeLeadContactEmailParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("788c3395-e8dc-443e-9c81-e57decd44c14"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("40c79c51-5e3e-4a77-881f-bfb3b5148e9c"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3da883c3-07af-4baf-9a48-e1f261dbd978"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,139,14,61,89,197,178,100,75,114,143,203,182,44,148,52,208,180,20,146,37,140,164,81,86,224,143,141,45,211,4,179,255,189,242,58,155,66,14,165,244,86,208,97,52,210,188,122,230,101,52,223,135,241,99,104,34,14,181,135,102,196,108,218,185,154,104,230,64,42,103,40,176,74,82,193,152,166,70,231,37,245,66,90,41,56,55,165,246,36,235,160,197,154,172,213,91,23,34,201,66,196,118,172,111,231,223,162,113,152,48,187,247,231,205,87,123,192,22,190,45,15,8,6,94,105,212,84,150,185,161,2,141,161,202,130,165,222,115,109,42,161,4,67,75,86,22,233,153,1,43,19,139,230,152,174,74,75,21,216,130,122,135,186,0,7,92,139,196,210,160,143,219,167,227,128,227,24,250,174,158,241,53,190,121,62,38,202,245,237,77,223,76,109,71,178,22,35,92,67,60,212,4,48,71,81,90,160,86,232,146,10,143,146,38,69,71,57,24,89,72,133,172,98,146,100,22,142,113,145,37,59,71,50,7,17,190,67,51,225,89,121,14,137,177,224,57,83,101,178,10,24,183,84,240,34,167,170,82,50,49,86,94,35,175,180,54,238,226,215,167,41,164,56,140,87,83,139,67,176,47,182,99,242,175,31,234,217,246,93,28,250,102,145,190,58,95,191,193,167,184,154,251,114,244,99,109,40,166,252,82,68,78,217,52,226,166,9,216,197,109,103,123,23,186,135,85,243,116,74,37,237,17,134,48,94,92,216,62,78,208,144,108,8,15,135,63,186,181,153,198,216,183,255,81,171,89,106,51,105,164,33,59,227,46,51,232,194,120,108,224,249,188,175,201,187,199,169,143,31,62,35,184,157,91,99,242,166,166,38,119,132,241,60,55,101,26,179,66,87,169,57,85,42,170,120,165,168,208,28,156,45,74,144,194,222,145,196,241,79,234,183,187,241,203,207,238,242,15,86,242,253,251,148,125,147,184,190,84,214,243,223,0,157,246,11,210,254,148,214,47,188,22,204,149,206,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bec4aa50-4e70-47b5-99c8-d0f15b4b12f8"),
				ContainerUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,93,111,219,32,20,253,43,17,237,99,136,192,198,6,252,218,118,82,164,118,171,250,245,210,228,225,2,151,214,146,99,87,54,217,148,69,249,239,195,36,89,155,110,123,25,15,54,112,57,231,220,207,45,57,15,155,55,36,21,121,192,190,135,161,243,97,118,209,245,56,187,237,59,139,195,48,187,238,44,52,245,79,48,13,222,66,15,43,12,216,63,65,179,198,225,186,30,194,116,114,10,35,83,114,254,61,89,73,245,188,37,243,128,171,199,185,139,236,144,123,39,148,207,40,47,172,167,130,59,67,33,131,50,238,44,3,43,10,134,37,68,176,237,154,245,170,189,193,0,183,16,94,73,181,37,137,109,36,112,66,51,87,40,202,10,1,84,56,85,80,157,137,146,58,167,68,89,162,201,181,202,201,110,74,6,251,138,43,72,162,239,96,193,193,43,141,154,202,130,25,42,208,24,170,44,88,234,125,174,77,41,148,224,104,71,240,225,253,59,240,249,236,121,62,124,251,209,98,127,159,120,43,15,205,128,203,89,188,253,116,113,213,224,10,219,80,109,145,101,40,21,83,84,201,76,83,97,181,164,70,51,73,185,80,210,103,200,101,38,213,46,2,126,103,179,218,10,228,200,164,206,41,20,104,169,200,64,80,35,77,140,205,250,232,43,47,37,67,28,33,87,109,168,195,230,34,229,168,218,2,50,20,133,5,106,133,46,168,240,40,41,228,218,209,28,204,168,129,188,228,114,183,60,91,142,129,185,122,120,107,96,243,244,103,124,119,8,110,98,187,214,215,253,10,211,46,128,13,195,196,108,38,205,104,138,49,214,205,236,75,221,15,97,82,199,114,78,58,63,233,113,88,55,161,110,95,226,243,166,65,27,234,174,157,205,221,94,234,237,164,75,62,138,109,23,251,102,91,144,106,241,175,118,59,252,247,201,61,109,184,207,189,182,32,211,5,185,239,214,189,29,25,243,241,112,172,125,82,96,135,69,255,242,57,174,61,71,130,221,64,11,47,216,127,141,138,9,158,76,151,16,32,137,63,68,191,143,196,38,211,5,147,220,83,137,16,43,140,101,70,149,227,64,53,215,198,231,50,207,188,207,18,250,14,61,246,216,90,60,117,140,151,6,243,178,224,84,121,204,226,4,20,58,226,29,163,160,88,238,68,169,114,231,242,132,79,202,239,206,28,199,34,222,180,235,166,73,2,67,138,127,156,179,131,227,7,203,229,135,130,127,96,232,92,237,107,116,243,246,127,82,181,35,187,221,114,247,11,224,138,247,140,50,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeReadContactsByLeadPhoneParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("55598db2-619f-4f92-a9b5-d03ddb173ed0"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,107,107,27,71,20,253,43,98,63,148,22,52,102,222,15,245,91,141,82,2,141,29,218,180,20,140,9,119,103,238,216,75,247,161,104,119,169,141,208,127,239,93,201,138,157,212,4,185,56,161,129,124,17,171,157,153,123,239,57,115,207,217,153,205,219,170,127,81,213,3,174,23,25,234,30,231,227,203,180,40,114,212,54,217,192,153,11,66,49,45,162,103,33,107,203,124,20,38,241,20,108,8,174,152,183,208,224,162,216,175,94,166,106,40,230,213,128,77,191,184,216,220,7,29,214,35,206,223,230,221,159,223,226,53,54,240,251,148,64,216,18,149,53,130,249,140,146,18,152,192,124,74,156,129,231,42,105,235,85,74,170,216,215,226,53,112,235,172,103,38,154,146,166,58,100,128,217,176,24,124,169,50,7,90,150,139,121,63,150,251,140,253,98,243,40,164,164,104,158,51,138,113,43,41,163,23,146,149,220,151,204,107,101,114,64,33,178,206,7,72,143,1,121,16,74,41,11,232,74,195,188,228,153,105,41,57,243,37,143,12,184,80,218,40,163,121,180,247,161,234,238,170,138,80,159,175,112,13,67,213,181,139,226,124,253,4,166,56,215,16,132,20,76,138,236,153,6,129,204,7,65,79,38,78,120,44,130,22,119,76,201,82,72,140,57,50,225,128,51,157,21,145,26,52,129,37,104,62,39,212,14,136,212,26,243,176,188,89,173,177,239,167,106,54,248,254,249,205,237,138,42,222,231,62,237,234,177,105,139,121,131,3,188,134,225,154,10,145,57,2,26,199,50,100,96,26,117,102,65,89,199,74,227,21,37,180,72,185,139,121,132,213,30,228,217,216,148,72,64,19,12,240,7,212,35,238,162,111,170,105,43,82,169,8,7,50,238,144,128,36,75,91,225,32,176,196,209,10,98,146,231,50,29,248,123,133,169,26,155,55,120,51,117,87,79,65,113,93,197,187,205,160,161,161,91,47,54,177,107,135,117,87,79,9,206,118,139,166,233,251,134,188,27,250,115,15,109,160,247,211,162,98,59,31,123,60,173,43,108,135,101,27,187,84,181,87,59,254,183,91,90,209,172,96,93,245,7,58,150,239,70,168,139,249,186,186,186,254,36,109,167,99,63,116,205,215,134,119,78,88,41,4,181,220,174,230,169,35,83,213,175,106,184,221,253,95,20,223,189,27,187,225,199,95,17,210,172,166,159,147,23,213,186,31,102,83,247,206,186,60,35,6,198,122,160,104,179,216,213,53,198,105,235,79,126,26,251,170,37,106,102,171,235,174,197,125,128,226,163,68,135,192,160,193,230,76,218,17,34,144,148,172,18,100,1,164,79,235,181,230,36,122,12,104,78,44,73,93,7,106,53,15,220,77,252,153,201,1,34,121,129,71,3,66,196,20,211,73,208,160,192,79,250,246,145,108,194,155,76,205,159,53,19,94,122,231,193,0,96,121,87,203,118,254,101,65,94,188,236,207,255,110,15,170,222,111,230,229,9,189,253,232,197,178,198,134,118,104,177,57,134,149,45,45,120,125,72,183,216,28,195,209,180,100,217,14,213,112,187,87,247,98,115,12,105,219,203,3,109,151,36,143,103,53,172,50,197,144,50,229,203,92,77,134,21,128,121,167,44,131,24,169,234,28,4,230,244,205,176,190,25,214,103,54,172,87,93,89,213,248,101,237,74,243,140,89,164,192,114,160,31,45,233,112,5,129,78,19,202,7,148,198,2,196,164,159,209,174,142,135,248,255,53,171,99,40,251,192,172,46,159,217,174,156,148,46,88,97,152,75,64,167,226,114,58,95,121,64,70,101,105,114,154,16,168,128,255,110,87,66,18,56,167,200,169,84,52,84,136,145,44,148,201,50,133,28,35,228,164,114,169,31,216,213,20,140,84,142,25,215,216,70,124,128,40,121,109,99,73,110,151,133,79,180,33,129,16,169,156,25,82,237,153,162,0,121,236,163,178,47,101,48,220,137,204,28,146,216,53,146,236,125,18,192,130,8,101,86,78,201,156,229,65,246,191,116,221,95,227,234,9,146,223,47,120,76,244,245,110,228,169,54,119,214,13,199,58,221,251,206,251,218,80,31,105,118,203,6,170,250,211,170,70,164,59,156,137,138,209,245,160,100,41,11,65,205,37,129,113,46,146,229,24,148,143,246,67,229,252,235,179,114,83,245,67,127,4,219,135,137,247,157,125,113,140,198,22,49,75,105,181,241,44,138,72,135,129,52,93,168,50,146,18,132,181,58,203,100,28,39,223,1,82,3,45,3,22,117,160,177,140,142,129,10,137,41,40,157,116,30,133,21,238,129,74,78,137,115,136,3,89,97,211,140,45,221,195,166,215,179,110,55,58,251,190,188,157,60,146,116,56,187,155,247,195,163,29,34,21,23,222,144,93,129,80,100,82,106,186,239,89,79,231,138,100,233,230,168,232,50,124,255,57,252,121,172,210,231,254,16,238,98,110,167,93,250,7,30,160,157,116,190,15,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("519549f0-c248-40b5-be93-602f4ff55bac"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c1675f40-4a8b-469f-807f-482b441e6236"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("8aacc82f-451e-44f0-a1ea-c48fac82b9aa"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1a7cefdb-8943-464e-9818-f056350796f1"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a45be9e6-9a59-46ac-b1b7-9def07669d0c"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("6b161822-7e93-4124-b2d6-c1605b5f5657"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("97881864-f21d-4f49-b39f-662c780efdc9"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityDataValueType")
			};
			resultEntityParameter.SourceValue = new ProcessSchemaParameterValue(resultEntityParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("83016a9c-a67e-4328-a96e-bfacfc2c77c6"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("a0d9ba4a-555e-4324-ae31-f59d0233fbc6"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("5b48e127-d50b-49a3-8459-4a9a52bf6988"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("6ef7572f-4836-4cfe-ad97-3868281a4281"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("ce2e72d3-d7a5-4f50-9ecf-44b4bf27b6ea"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("98faeefc-cf3f-4be3-a9b9-40bd344629d3"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("e75f4ff2-ebaa-43f4-aff7-36f8fa2f00cd"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1a5f9685-0340-43a4-85bd-917ac7f8b75a"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4a757dc8-11a2-46d0-962c-01dc9f7cf05c"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("aaf1a71e-6beb-4e10-9fbd-54d5a3ea0564"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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
				UId = new Guid("1ad992f2-bdf7-41a1-819c-2ba446fc91ed"),
				ContainerUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
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

		protected virtual void InitializeChangeLeadContactPhoneParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("cfc1a8ae-2a77-49bb-a728-a1637ee8c94a"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5feb2bce-5433-4c25-a83d-3f8d28ccc8ab"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9acd36f8-ce89-4f92-bdb8-e4eea778daf4"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,203,250,176,228,30,151,109,89,40,105,160,105,41,36,75,24,73,227,172,192,31,27,91,166,9,102,255,123,229,117,54,133,28,74,233,173,224,195,204,72,239,233,189,199,120,190,15,227,199,208,68,28,170,26,154,17,179,105,231,43,194,157,181,57,151,146,66,89,148,84,120,87,82,43,185,162,82,74,200,153,242,136,222,147,172,131,22,43,178,162,183,62,68,146,133,136,237,88,221,206,191,73,227,48,97,118,95,159,155,175,238,128,45,124,91,30,16,12,106,109,208,208,82,230,150,10,180,150,106,7,142,214,53,55,86,9,45,24,58,178,106,113,74,178,156,21,64,53,243,140,10,235,11,154,128,169,45,75,238,133,87,198,66,186,218,96,29,183,79,199,1,199,49,244,93,53,227,107,125,243,124,76,42,215,183,55,125,51,181,29,201,90,140,112,13,241,80,17,192,28,133,116,64,157,48,146,138,26,75,10,220,120,202,193,38,235,26,153,98,37,201,28,28,227,66,75,118,201,182,135,8,223,161,153,240,204,60,135,164,177,224,57,211,82,37,44,227,142,10,94,228,84,43,93,210,218,171,218,32,87,198,216,215,188,62,77,33,213,97,188,154,90,28,130,123,137,29,83,126,253,80,205,174,239,226,208,55,11,245,213,249,250,13,62,197,53,220,151,163,31,171,161,152,230,11,136,156,178,105,196,77,19,176,139,219,206,245,62,116,15,43,231,233,148,32,237,17,134,48,94,82,216,62,78,208,144,108,8,15,135,63,166,181,153,198,216,183,255,145,213,44,217,76,28,105,201,206,114,151,29,244,97,60,54,240,124,238,43,242,238,113,234,227,135,207,8,126,231,215,154,188,193,84,228,142,48,158,231,105,209,145,22,70,37,115,90,106,170,185,210,84,24,14,222,21,18,74,225,238,72,210,241,79,236,183,187,241,203,207,238,242,31,172,202,247,239,211,244,205,224,250,130,172,230,191,17,116,218,47,146,246,167,244,253,2,190,113,24,67,206,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("15555f52-d536-4815-a506-977a98d2f0f3"),
				ContainerUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,203,110,219,48,16,252,21,129,201,209,52,36,145,146,72,93,147,20,48,144,180,65,210,230,18,251,176,36,151,137,0,61,12,137,110,225,10,250,247,82,180,221,196,105,123,41,15,122,236,114,102,118,151,195,145,92,186,253,22,73,73,190,98,223,195,208,89,183,188,234,122,92,222,247,157,198,97,88,222,118,26,234,234,39,168,26,239,161,135,6,29,246,79,80,239,112,184,173,6,183,136,206,97,100,65,46,191,135,44,41,159,71,178,114,216,124,91,25,207,46,81,198,185,98,138,50,105,20,229,8,49,21,214,10,90,72,38,82,148,144,51,150,120,176,238,234,93,211,222,161,131,123,112,175,164,28,73,96,243,4,96,184,140,77,38,104,156,113,160,220,136,140,202,148,231,212,24,193,243,28,21,147,130,145,105,65,6,253,138,13,4,209,55,48,79,192,10,95,2,45,178,120,86,87,138,10,13,154,90,203,164,202,185,224,9,234,25,124,220,255,6,124,190,120,94,13,95,126,180,216,63,6,222,210,66,61,224,102,233,163,31,2,55,53,54,216,186,114,76,24,170,184,224,140,166,54,75,40,23,57,167,210,102,232,11,77,121,12,74,24,84,233,228,1,191,167,89,142,178,16,34,153,55,218,52,49,148,91,46,169,239,199,210,60,79,117,33,98,180,70,203,25,114,211,186,202,237,175,194,140,202,17,48,70,158,105,160,154,203,204,163,176,160,224,167,75,25,168,34,45,4,38,121,82,76,155,139,205,220,152,169,134,109,13,251,167,63,251,123,64,48,145,238,90,91,245,13,134,47,7,218,13,145,218,71,245,156,218,190,118,45,70,237,174,81,216,15,203,79,85,63,184,168,242,199,26,117,54,234,113,216,213,174,106,95,60,172,174,81,187,170,107,151,43,115,144,220,158,185,229,189,232,184,62,152,110,77,202,245,191,108,119,124,31,134,124,110,188,143,158,91,147,197,154,60,118,187,94,207,140,108,254,57,121,32,40,196,199,69,255,242,56,173,3,71,128,221,65,11,47,216,127,246,138,1,30,82,215,224,32,136,127,245,117,159,136,85,42,179,184,72,44,45,16,164,119,85,158,82,97,18,160,50,145,202,178,130,165,214,166,1,253,128,22,123,108,53,158,23,150,228,10,89,238,77,34,44,166,148,39,153,244,120,19,83,16,49,51,60,23,204,24,22,240,65,249,173,152,211,245,240,145,118,87,215,65,96,8,253,207,247,237,88,248,49,115,253,238,224,223,49,116,166,178,21,154,85,251,63,163,154,200,52,109,166,95,121,0,34,107,58,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeChangeDataUserTask1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				UId = new Guid("3719e46d-8e08-48ad-8083-1ccf953996c6"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"41af89e9-750b-4ebb-8cac-ff39b64841ec",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
			var isMatchConditionsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("08550f59-4992-48fb-b252-df02ec268766"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMatchConditionsParameter.SourceValue = new ProcessSchemaParameterValue(isMatchConditionsParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"true",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(isMatchConditionsParameter);
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("44584732-acad-4754-bde4-a1b1cfd19199"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MetaDataTextDataValueType")
			};
			dataSourceFiltersParameter.SourceValue = new ProcessSchemaParameterValue(dataSourceFiltersParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,47,58,244,100,21,91,95,150,220,227,178,45,11,37,13,52,45,133,100,9,207,210,83,86,224,143,141,45,211,4,179,255,189,242,58,155,66,14,165,244,86,208,225,233,73,51,111,102,144,230,251,48,126,12,77,196,161,242,208,140,152,77,59,87,17,39,106,151,151,140,83,233,165,163,2,65,82,96,134,83,230,56,122,167,141,20,194,145,172,131,22,43,178,162,183,46,68,146,133,136,237,88,221,206,191,73,227,48,97,118,239,207,155,175,246,128,45,124,91,6,136,2,188,54,104,104,41,243,58,13,168,107,170,45,88,234,61,55,181,18,90,20,104,201,170,197,151,80,115,199,146,2,165,88,186,170,74,10,22,129,22,42,103,82,176,82,112,168,73,214,160,143,219,167,227,128,227,24,250,174,154,241,181,190,121,62,38,149,235,236,77,223,76,109,71,178,22,35,92,67,60,84,4,48,71,33,45,80,43,140,164,194,99,98,231,198,209,68,90,178,82,99,161,138,146,100,22,142,113,161,37,187,100,219,65,132,239,208,76,120,102,158,67,210,200,120,94,104,185,40,43,184,165,130,179,156,106,165,75,234,157,242,6,185,50,166,126,205,235,211,20,82,29,198,171,169,197,33,216,151,216,49,229,215,15,213,108,251,46,14,125,179,80,95,157,175,223,224,83,92,195,125,57,250,177,26,138,169,191,128,200,41,155,70,220,52,1,187,184,237,108,239,66,247,176,114,158,78,9,210,30,97,8,227,37,133,237,227,4,13,201,134,240,112,248,99,90,155,105,140,125,251,31,89,205,146,205,196,145,30,217,89,238,242,6,93,24,143,13,60,159,247,21,121,247,56,245,241,195,103,4,183,115,107,77,222,96,42,114,71,10,158,231,181,228,72,153,81,201,156,150,154,106,174,52,21,134,131,179,76,66,41,236,29,73,58,254,137,253,118,55,126,249,217,93,254,193,170,124,255,62,117,223,52,174,47,200,106,254,27,65,167,253,34,105,127,74,235,23,164,167,252,123,206,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var recordColumnValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("33aca163-6ecf-4e71-9484-09432fbc4746"),
				ContainerUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
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
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("EntityColumnMappingCollectionDataValueType")
			};
			recordColumnValuesParameter.SourceValue = new ProcessSchemaParameterValue(recordColumnValuesParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,59,111,219,48,16,254,43,2,147,209,52,40,138,146,72,109,69,210,193,64,210,6,77,154,37,246,112,36,143,141,0,61,12,74,110,145,26,250,239,165,105,187,182,211,118,41,7,73,188,211,247,16,239,211,150,92,143,111,107,36,21,121,66,239,97,232,221,56,191,233,61,206,31,124,111,112,24,230,119,189,129,166,254,9,186,193,7,240,208,226,136,254,25,154,13,14,119,245,48,206,146,75,24,153,145,235,239,177,75,170,151,45,89,140,216,126,93,216,192,206,37,7,163,48,165,172,224,156,138,82,103,84,90,174,169,41,101,153,27,208,138,153,60,128,77,223,108,218,238,30,71,120,128,241,149,84,91,18,217,2,1,88,161,152,205,37,101,185,0,42,172,204,169,226,162,160,214,74,81,20,168,51,37,51,50,205,200,96,94,177,133,40,122,2,139,20,156,84,168,104,153,51,77,5,106,77,165,1,67,157,203,148,46,132,20,41,154,29,248,240,254,9,248,114,245,178,24,62,255,232,208,63,70,222,202,65,51,224,106,30,170,239,10,31,27,108,177,27,171,237,78,138,113,171,168,114,60,163,130,179,130,106,101,144,2,50,205,88,206,44,40,156,2,224,247,105,86,219,178,4,201,92,94,80,161,11,70,133,212,134,106,228,37,69,85,56,103,133,49,185,210,211,234,106,181,179,104,235,97,221,192,219,243,159,78,63,88,155,108,58,211,119,174,246,45,218,36,60,141,96,198,68,195,16,118,125,151,52,8,54,169,59,215,251,22,198,186,239,230,55,30,97,12,61,143,166,247,54,89,216,189,196,250,98,206,231,34,219,229,62,46,75,82,45,255,21,152,195,125,127,60,151,145,121,159,150,37,153,45,201,99,191,241,102,199,152,237,54,199,233,69,5,118,88,244,47,151,227,218,115,68,216,61,116,240,13,253,167,160,24,225,177,117,11,35,68,241,167,224,251,72,172,185,202,89,153,58,90,34,168,144,135,130,135,52,166,64,85,170,180,203,202,140,59,199,35,250,11,58,244,216,25,188,52,150,22,26,179,34,79,169,116,24,210,156,230,42,224,45,163,97,140,153,21,133,204,172,205,34,62,42,159,204,28,131,29,42,221,166,105,162,192,16,191,127,247,167,28,140,31,58,183,103,131,62,99,232,109,237,106,180,139,238,127,142,106,34,211,180,154,126,1,110,132,59,154,244,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(recordColumnValuesParameter);
		}

		protected virtual void InitializeReadLandingPageParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cd3fabe0-1945-4d5e-9fb8-9e85ee54cc3b"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,89,182,44,187,199,176,41,129,146,134,126,81,72,66,24,75,163,68,224,143,141,45,211,4,179,255,189,227,117,182,133,28,74,78,133,130,49,150,228,247,157,153,71,51,243,93,24,207,67,19,113,168,60,52,35,38,211,133,171,152,75,13,104,229,115,142,90,8,158,25,43,56,216,210,115,35,50,52,62,151,22,117,206,146,14,90,172,216,170,222,185,16,89,18,34,182,99,117,61,255,49,141,195,132,201,157,63,46,190,216,7,108,225,219,18,32,147,128,133,51,142,215,104,21,207,164,243,28,180,23,60,133,90,56,97,106,85,234,130,173,185,128,183,121,109,13,242,212,229,142,103,174,72,57,212,69,201,115,91,35,162,16,190,150,200,146,6,125,220,61,237,7,28,199,208,119,213,140,191,191,191,62,239,41,203,53,246,89,223,76,109,199,146,22,35,92,65,124,32,119,20,152,229,22,184,205,202,156,103,30,11,14,170,116,92,81,140,180,48,40,181,164,68,44,236,227,98,203,46,28,75,28,68,248,14,205,132,71,231,57,80,142,169,18,210,228,154,180,82,89,158,169,84,112,163,77,193,189,211,190,68,165,203,178,118,39,94,31,166,64,223,97,188,156,90,28,130,125,193,142,196,175,31,170,217,246,93,28,250,102,177,190,60,254,254,21,159,226,10,247,229,232,199,90,80,164,253,69,196,14,201,52,226,89,19,176,139,187,206,246,46,116,247,171,231,225,64,146,118,15,67,24,79,20,118,143,19,52,44,25,194,253,195,95,105,157,77,99,236,219,255,168,212,132,202,36,15,106,178,99,186,75,15,186,48,238,27,120,62,174,43,246,238,113,234,227,251,207,8,110,211,208,107,123,30,134,49,110,150,126,221,244,126,67,197,79,77,36,187,141,237,155,6,237,114,217,219,143,208,45,17,54,123,184,199,85,206,94,133,169,216,13,131,140,26,215,11,203,165,164,1,201,180,146,28,76,154,114,109,178,76,20,218,96,137,249,86,219,210,100,212,210,220,128,40,168,135,117,206,1,61,225,147,6,115,144,210,58,235,182,165,50,37,13,94,201,181,50,154,134,142,206,137,101,206,83,155,155,34,85,42,213,58,189,97,4,225,95,149,118,125,49,126,250,217,157,230,118,37,125,187,165,221,87,27,187,6,91,186,146,106,126,11,139,3,9,174,78,161,170,249,45,100,22,201,174,139,33,62,175,243,91,205,111,65,117,184,93,96,221,30,232,249,5,240,94,150,228,229,4,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c84ed90e-913c-4d79-be6e-0aeb6dbde695"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("528b68b1-c488-499b-b6a9-98d627973317"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7db9bc2b-3431-4feb-8af1-b2fcbc5cf552"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("50c50a69-929a-4ae1-8501-1657483ac91c"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5a09f02d-d645-448c-a427-3dc0ad363ad0"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("2793b917-606e-429f-8d6b-56caf9a5d36b"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,75,204,77,181,50,180,50,4,0,203,8,241,43,15,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"),
				UId = new Guid("a435ea7f-ecdc-4500-acc1-f4ab6e8b2a76"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e0010511-9818-4608-8cc6-966c057c7fb7"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("5ce1ad73-33d5-4d54-99dc-103fe2185918"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("f1d51e05-81e8-439e-be55-ef17ce69d451"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("5400d0e0-9171-4da4-9833-ee4bc440d882"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("fe6f5c9f-37df-4b0d-b855-65847152e915"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("ec12f3b9-746c-4f92-ba49-ce658079412a"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ReferenceSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"),
				UId = new Guid("6dc416c9-504c-4429-b04e-93f543f173c4"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b66e4485-d571-44cb-9e32-b832c83541ca"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1c52f53d-1e03-445c-bcbe-0982a59c336a"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("53165197-1fec-4a54-8554-f92812f26388"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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
				UId = new Guid("a481ce48-85ca-457f-98da-430695e26372"),
				ContainerUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLeadIdentificationProcess = CreateLeadIdentificationProcessLaneSet();
			LaneSets.Add(schemaLeadIdentificationProcess);
			ProcessSchemaLane schemaLeadIdentification = CreateLeadIdentificationLane();
			schemaLeadIdentificationProcess.Lanes.Add(schemaLeadIdentification);
			ProcessSchemaStartEvent start = CreateStartStartEvent();
			FlowElements.Add(start);
			ProcessSchemaTerminateEvent leadisidentified = CreateLeadIsIdentifiedTerminateEvent();
			FlowElements.Add(leadisidentified);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaExclusiveGateway exclusiveleadhascommunication = CreateExclusiveLeadHasCommunicationExclusiveGateway();
			FlowElements.Add(exclusiveleadhascommunication);
			ProcessSchemaTerminateEvent leaddisqualified = CreateLeadDisqualifiedTerminateEvent();
			FlowElements.Add(leaddisqualified);
			ProcessSchemaUserTask readcontactsbyleadcommunications = CreateReadContactsByLeadCommunicationsUserTask();
			FlowElements.Add(readcontactsbyleadcommunications);
			ProcessSchemaUserTask changeleadcontactall = CreateChangeLeadContactAllUserTask();
			FlowElements.Add(changeleadcontactall);
			ProcessSchemaUserTask addcontactbylead = CreateAddContactByLeadUserTask();
			FlowElements.Add(addcontactbylead);
			ProcessSchemaUserTask addcontactadress = CreateAddContactAdressUserTask();
			FlowElements.Add(addcontactadress);
			ProcessSchemaUserTask addcontactweb = CreateAddContactWebUserTask();
			FlowElements.Add(addcontactweb);
			ProcessSchemaParallelGateway parallelgatewayaddcontactcommunication = CreateParallelGatewayAddContactCommunicationParallelGateway();
			FlowElements.Add(parallelgatewayaddcontactcommunication);
			ProcessSchemaParallelGateway parallelgateway1 = CreateParallelGateway1ParallelGateway();
			FlowElements.Add(parallelgateway1);
			ProcessSchemaUserTask readcontactsbyleademail = CreateReadContactsByLeadEmailUserTask();
			FlowElements.Add(readcontactsbyleademail);
			ProcessSchemaUserTask changeleadcontactemail = CreateChangeLeadContactEmailUserTask();
			FlowElements.Add(changeleadcontactemail);
			ProcessSchemaExclusiveGateway exclusiveinleadcommunication = CreateExclusiveInLeadCommunicationExclusiveGateway();
			FlowElements.Add(exclusiveinleadcommunication);
			ProcessSchemaUserTask readcontactsbyleadphone = CreateReadContactsByLeadPhoneUserTask();
			FlowElements.Add(readcontactsbyleadphone);
			ProcessSchemaUserTask changeleadcontactphone = CreateChangeLeadContactPhoneUserTask();
			FlowElements.Add(changeleadcontactphone);
			ProcessSchemaUserTask changedatausertask1 = CreateChangeDataUserTask1UserTask();
			FlowElements.Add(changedatausertask1);
			ProcessSchemaExclusiveGateway exclusivegatewayisleadset = CreateExclusiveGatewayIsLeadSetExclusiveGateway();
			FlowElements.Add(exclusivegatewayisleadset);
			ProcessSchemaScriptTask actionafteridentificationscripttask = CreateActionAfterIdentificationScriptTaskScriptTask();
			FlowElements.Add(actionafteridentificationscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaUserTask readlandingpage = CreateReadLandingPageUserTask();
			FlowElements.Add(readlandingpage);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			FlowElements.Add(exclusivegateway2);
			FlowElements.Add(CreateContactFoundAllConditionalFlow());
			FlowElements.Add(CreateContactNotFoundAllSequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateConditionalFlowCommunicationAllConditionalFlow());
			FlowElements.Add(CreateConditionalFlowEmailOnlyConditionalFlow());
			FlowElements.Add(CreateContactFoundEmailConditionalFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateConditionalFlowPhonesOnlyConditionalFlow());
			FlowElements.Add(CreateCntactFoundPhoneConditionalFlow());
			FlowElements.Add(CreateContactNotFoundEmailSequenceFlow());
			FlowElements.Add(CreateContactNotFoundPhoneSequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlowLeadDefinedSequenceFlow());
			FlowElements.Add(CreateSequenceFlowLeadReadSequenceFlow());
			FlowElements.Add(CreateConditionalFlowLeadUndefinedConditionalFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateIsNotFromLandingFlowConditionalFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateDontContactFlowConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaConditionalFlow CreateContactFoundAllConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ContactFoundAll",
				UId = new Guid("e86cf8b0-28a2-4a9b-b145-adf2cced025e"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{55827a3c-5bec-4f5a-bf98-793768421b33}].[Parameter:{10568b26-1c18-4f39-9578-4a72a1c5fb66}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(743, 206),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateContactNotFoundAllSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "ContactNotFoundAll",
				UId = new Guid("de6d680f-d07c-44e0-bad0-0e782cd4ab9d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(663, 272),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("685ffe7e-d19d-424d-af66-eab647e50e57"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(827, 406),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("ac04a55d-ac74-402d-bd4c-e1838bf4708c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(942, 299),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("520f849c-7cf5-482e-8278-85ac18ec9297"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(952, 407),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(977, 504));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("18317a84-4d39-4605-b176-feb243f51a99"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1086, 544),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("f6a451c0-89fd-4ccc-ab61-d3c20b1a0644"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1086, 594),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1222, 504));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("09a82fde-8ba3-4a5d-9cc0-6aecd8a4bd9b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1165, 236),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("7441390e-adc4-42b8-a095-363e9352da36"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1012, 302),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1375, 70));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowCommunicationAllConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowCommunicationAll",
				UId = new Guid("146a48af-ec3c-47df-b53d-49db5dfca733"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{fee32d81-7e24-4a34-91c7-3083e4d4938f}]#] != String.Empty &&
([#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{40fef1d9-f9d9-4246-a90f-389e256aacd4}]#] != String.Empty ||
[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{94a3a853-08cb-485f-89f4-182878a5aaeb}]#] != String.Empty)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(564, 112),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(559, 70));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowEmailOnlyConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowEmailOnly",
				UId = new Guid("94e08796-33d0-450f-a94d-43d4d8c7e5b4"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{fee32d81-7e24-4a34-91c7-3083e4d4938f}]#] != String.Empty &&
[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{40fef1d9-f9d9-4246-a90f-389e256aacd4}]#] == String.Empty &&
[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{94a3a853-08cb-485f-89f4-182878a5aaeb}]#] == String.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(568, 220),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateContactFoundEmailConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ContactFoundEmail",
				UId = new Guid("8ad3bb27-05b3-4197-85fe-9fca6ddb677c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{e02e7808-8729-4c97-b907-1487f2e17278}].[Parameter:{4e1e0793-a5ec-42a4-b7b6-dcf4eb1670ee}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(672, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("d616bcad-397a-4fb0-9ad7-a6b4eecacb7a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1082, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1120, 188));
			schemaFlow.PolylinePointPositions.Add(new Point(1120, 189));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("04aca506-6521-4495-8b71-07a6e4990984"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1288, 196),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowPhonesOnlyConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowPhonesOnly",
				UId = new Guid("421b74c1-62c2-430b-965d-8d776c88a27f"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{fee32d81-7e24-4a34-91c7-3083e4d4938f}]#] == String.Empty &&
([#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{40fef1d9-f9d9-4246-a90f-389e256aacd4}]#] != String.Empty ||
[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{94a3a853-08cb-485f-89f4-182878a5aaeb}]#] != String.Empty)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(465, 286),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(626, 188));
			schemaFlow.PolylinePointPositions.Add(new Point(626, 301));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateCntactFoundPhoneConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "CntactFoundPhone",
				UId = new Guid("9bfd01fc-78f4-4b49-a5a3-0359fc93fab2"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{13eb0743-2f51-4864-9f5e-dd240ab8deb2}].[Parameter:{97881864-f21d-4f49-b39f-662c780efdc9}].[EntityColumn:{ae0e45ca-c495-4fe7-a39d-3ab7278e1617}]#] != Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(668, 412),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateContactNotFoundEmailSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "ContactNotFoundEmail",
				UId = new Guid("42aea126-6049-4745-ad69-161540c3e406"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(670, 378),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				SourceSequenceFlowPointLocalPosition = new Point(1, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(734, 413));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateContactNotFoundPhoneSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "ContactNotFoundPhone",
				UId = new Guid("df707572-c541-4e4e-862e-378909dd23f7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(670, 438),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(699, 413));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("4d08fda8-cd6a-41a3-93c1-ea29843a1dd8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1004, 269),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1376, 301));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("730e6ac4-b34e-4059-a3b7-fdb00cfe6b88"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(130, 176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e4f191bb-2078-469f-a22b-36763fc3b878"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("d51e9369-1e01-464b-b9e0-a5a76570f27f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1295, 314),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1376, 413));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowLeadDefinedSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlowLeadDefined",
				UId = new Guid("809c0113-c2cd-4fc6-81a2-709589e406ae"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(322, 190),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowLeadReadSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowLeadRead",
				UId = new Guid("39aa9aa5-0e89-45d2-ab91-45a36ea7120a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(393, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(241, 189));
			schemaFlow.PolylinePointPositions.Add(new Point(241, 188));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowLeadUndefinedConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowLeadUndefined",
				UId = new Guid("86bf0460-da87-44e8-9e19-16d6bb74396c"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{1300b53e-296c-4858-8368-493adc25a74c}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(468, 408),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(99, 589));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("820777f0-a887-4f88-bf50-9a94194c500e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(1423, 214),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c634d34a-9984-4a62-a5cf-c01049fca1c0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateIsNotFromLandingFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "IsNotFromLandingFlow",
				UId = new Guid("b15dccc1-cb8b-4db6-9245-c999d8b93476"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{a4a6ff0c-119f-4631-a822-68440768e9e5}].[Parameter:{6c984967-8a07-4d65-aefc-418e5a11cdcd}].[EntityColumn:{9389d289-6386-48fc-9bd5-2c5872332662}]#] == Guid.Empty",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(282, 589));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("20f61163-eea7-47a5-b9f2-2e0896ee1530"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateDontContactFlowConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "DontContactFlow",
				UId = new Guid("6e54dca1-2410-4933-8d29-b9c06c6eb9c5"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{17eaa635-03e6-4644-8e7d-7a81a8f837a6}].[Parameter:{a435ea7f-ecdc-4500-acc1-f4ab6e8b2a76}].[EntityColumn:{7e336bc1-838f-48c6-a4d7-6f5bb3930bb2}]#] == false",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(471, 589));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("d4060814-2d0d-4e64-93e2-903d9f427c42"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(559, 589));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow2",
				UId = new Guid("ba39820c-a979-4d6a-9f26-dab9940fce00"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow3",
				UId = new Guid("704f89d9-2ad0-404e-8ce3-94ce9f308188"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadIdentificationProcessLaneSet() {
			ProcessSchemaLaneSet schemaLeadIdentificationProcess = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bc24ba6a-fa71-49d5-8e0e-37de1a155822"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadIdentificationProcess",
				Position = new Point(5, 5),
				Size = new Size(1687, 920),
				UseBackgroundMode = false
			};
			return schemaLeadIdentificationProcess;
		}

		protected virtual ProcessSchemaLane CreateLeadIdentificationLane() {
			ProcessSchemaLane schemaLeadIdentification = new ProcessSchemaLane(this) {
				UId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("bc24ba6a-fa71-49d5-8e0e-37de1a155822"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadIdentification",
				Position = new Point(29, 0),
				Size = new Size(1658, 920),
				UseBackgroundMode = false
			};
			return schemaLeadIdentification;
		}

		protected virtual ProcessSchemaStartEvent CreateStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("e4f191bb-2078-469f-a22b-36763fc3b878"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"Start",
				Position = new Point(20, 176),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateLeadIsIdentifiedTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("c634d34a-9984-4a62-a5cf-c01049fca1c0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadIsIdentified",
				Position = new Point(1593, 176),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadLeadData",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(160, 162),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveLeadHasCommunicationExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveLeadHasCommunication",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(532, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaTerminateEvent CreateLeadDisqualifiedTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"LeadDisqualified",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(722, 576),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaUserTask CreateReadContactsByLeadCommunicationsUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadContactsByLeadCommunications",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(665, 43),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadContactsByLeadCommunicationsParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadContactAllUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeLeadContactAll",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(823, 43),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeLeadContactAllParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddContactByLeadUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"AddContactByLead",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(830, 386),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddContactByLeadParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddContactAdressUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"AddContactAdress",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1068, 477),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddContactAdressParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateAddContactWebUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"AddContactWeb",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1068, 386),
				SchemaUId = new Guid("db6abed1-0c5f-455b-8053-2665378cdb71"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeAddContactWebParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaParallelGateway CreateParallelGatewayAddContactCommunicationParallelGateway() {
			ProcessSchemaParallelGateway gateway = new ProcessSchemaParallelGateway(this) {
				UId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("e9e1e6de-7066-4eb1-bbb4-5b75b13d4f56"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ParallelGatewayAddContactCommunication",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(949, 386),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaParallelGateway CreateParallelGateway1ParallelGateway() {
			ProcessSchemaParallelGateway gateway = new ProcessSchemaParallelGateway(this) {
				UId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("e9e1e6de-7066-4eb1-bbb4-5b75b13d4f56"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ParallelGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1194, 386),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadContactsByLeadEmailUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadContactsByLeadEmail",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(665, 161),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadContactsByLeadEmailParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadContactEmailUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeLeadContactEmail",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(823, 161),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeLeadContactEmailParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveInLeadCommunicationExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveInLeadCommunication",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1348, 162),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadContactsByLeadPhoneUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadContactsByLeadPhone",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(665, 274),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadContactsByLeadPhoneParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeLeadContactPhoneUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeLeadContactPhone",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(823, 274),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeLeadContactPhoneParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaUserTask CreateChangeDataUserTask1UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ChangeDataUserTask1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1285, 386),
				SchemaUId = new Guid("d3021ca7-7450-4678-a117-060171eb2976"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeChangeDataUserTask1Parameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayIsLeadSetExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveGatewayIsLeadSet",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(72, 162),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateActionAfterIdentificationScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ActionAfterIdentificationScriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(1451, 162),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,46,201,204,207,115,76,43,73,45,242,76,73,205,43,201,76,203,76,78,4,9,105,104,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,0,140,232,210,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(254, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadLandingPageUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ReadLandingPage",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(340, 161),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLandingPageParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f0d97bf-6f5d-40cc-b57c-23e715671755"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("70885459-eb74-4f01-8b36-f019cf6455dd"),
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(443, 161),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateActionAfterIdentificationMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10509a8f-ce1f-49d4-9a6e-2dbe803346be"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5d1dacad-ecaf-4a19-8976-6e14d8694860"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038")
			});
		}

		protected virtual SchemaMethod CreateActionAfterIdentificationMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("65b7b9f3-d136-49d8-becb-1af845f46036"),
				Name = "ActionAfterIdentification",
				CreatedInSchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505"),
				CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,80,205,74,3,49,16,62,155,167,136,61,237,66,201,11,172,21,150,69,109,161,7,21,23,15,226,33,237,206,150,64,54,217,78,38,106,145,190,187,147,69,132,160,245,208,91,248,230,251,77,32,52,110,39,245,56,90,179,213,100,188,107,209,202,133,12,19,174,110,134,145,14,149,48,189,44,158,0,81,7,223,147,122,134,141,90,18,141,170,222,48,77,111,147,42,76,72,227,29,193,7,169,38,34,130,35,121,185,144,46,90,91,202,79,113,241,43,34,55,108,252,48,120,151,158,45,25,107,200,64,80,119,64,247,58,25,213,153,246,156,42,234,17,246,17,2,149,149,56,138,55,141,210,130,238,30,162,182,166,255,54,94,130,29,1,185,87,99,117,8,183,236,229,241,144,42,92,173,255,166,94,23,14,222,37,231,112,114,76,236,26,119,113,224,172,151,87,158,123,226,86,204,98,0,228,131,131,169,236,108,46,219,12,40,231,255,104,243,63,100,109,14,148,226,200,251,78,44,83,245,228,95,247,4,184,234,216,238,231,94,164,129,171,174,172,190,0,114,117,5,134,13,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagementIdentification(userConnection);
		}

		public override object Clone() {
			return new LeadManagementIdentificationSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("50c67976-474a-4cfb-b066-5ca727be0505"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagementIdentification

	/// <exclude/>
	public class LeadManagementIdentification : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadIdentification

		/// <exclude/>
		public class ProcessLeadIdentification : ProcessLane
		{

			public ProcessLeadIdentification(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadLeadDataFlowElement

		/// <exclude/>
		public class ReadLeadDataFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("a4a6ff0c-119f-4631-a822-68440768e9e5");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,203,146,45,201,61,46,219,178,80,210,64,211,82,72,150,48,146,198,89,129,63,54,150,76,19,204,254,247,202,235,108,10,57,148,210,91,65,135,153,145,222,155,55,143,209,124,239,195,71,223,70,28,235,6,218,128,217,180,115,53,41,144,25,43,75,77,65,202,156,10,85,48,106,160,40,40,183,37,19,198,9,157,131,33,89,15,29,214,100,69,111,157,143,36,243,17,187,80,223,206,191,73,227,56,97,118,223,156,147,175,246,128,29,124,91,26,8,6,141,210,168,169,44,115,67,5,26,67,149,5,75,155,134,107,83,9,37,24,90,178,106,17,220,160,80,57,80,100,54,105,177,82,80,229,36,208,92,50,167,89,81,228,202,114,146,181,216,196,237,211,113,196,16,252,208,215,51,190,198,55,207,199,164,114,237,189,25,218,169,235,73,214,97,132,107,136,135,154,0,230,40,74,11,212,10,93,82,209,160,164,192,181,163,28,140,44,164,66,86,49,73,50,11,199,184,208,146,157,35,153,131,8,223,161,157,240,204,60,251,197,47,158,51,85,86,9,203,184,165,130,23,57,85,149,146,180,113,85,163,145,87,90,27,119,241,235,211,228,83,236,195,213,212,225,232,237,139,237,152,252,27,198,122,182,67,31,199,161,93,168,175,206,207,111,240,41,174,230,190,92,253,88,7,138,169,190,128,200,41,155,2,110,90,143,125,220,246,118,112,190,127,88,57,79,167,4,233,142,48,250,112,113,97,251,56,65,75,178,209,63,28,254,232,214,102,10,113,232,254,163,81,179,52,102,226,72,75,118,150,187,236,160,243,225,216,194,243,57,175,201,187,199,105,136,31,62,35,184,157,91,99,242,6,83,147,59,194,120,158,155,146,35,45,116,149,134,83,165,162,138,87,138,10,205,193,217,162,4,41,236,29,73,58,254,137,253,118,23,190,252,236,47,255,96,85,190,127,159,170,111,10,215,23,100,61,255,141,160,211,126,145,180,63,165,243,11,182,69,111,55,206,3,0,0 })));
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

		#region Class: ReadContactsByLeadCommunicationsFlowElement

		/// <exclude/>
		public class ReadContactsByLeadCommunicationsFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadContactsByLeadCommunicationsFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadContactsByLeadCommunications";
				IsLogging = true;
				SchemaElementUId = new Guid("55827a3c-5bec-4f5a-bf98-793768421b33");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,107,107,27,71,20,253,43,98,63,148,22,52,102,222,15,245,91,141,82,2,205,131,54,45,133,96,194,157,153,59,241,210,149,86,209,238,210,24,161,255,222,187,146,21,187,193,4,185,216,38,161,250,178,72,59,59,247,206,61,115,207,153,51,155,119,117,247,172,110,122,92,207,10,52,29,78,135,231,121,86,37,110,109,112,82,177,236,140,100,58,38,206,32,138,200,2,74,192,92,156,150,201,85,211,37,44,112,86,237,103,207,115,221,87,211,186,199,69,55,123,187,185,9,218,175,7,156,190,43,187,63,191,165,75,92,192,239,99,2,97,35,42,107,4,243,5,41,129,48,129,249,156,41,139,231,42,107,235,85,206,170,218,175,197,114,14,28,45,50,131,54,48,157,139,97,81,101,195,68,246,46,230,226,149,143,165,154,118,67,220,103,236,102,155,59,75,226,217,75,147,120,96,25,56,101,212,202,177,160,189,101,34,32,40,35,178,52,58,31,74,186,71,33,156,107,8,66,10,38,69,241,76,131,64,230,131,160,95,148,171,56,99,17,180,184,46,132,235,162,45,36,199,162,22,180,2,59,22,34,45,173,32,73,33,61,162,129,72,53,55,88,250,249,199,213,26,187,174,110,151,179,13,126,250,253,230,106,69,107,219,231,62,111,155,97,177,172,166,11,236,225,53,244,151,20,93,150,4,104,28,43,80,128,105,212,133,5,101,41,153,241,74,56,176,40,49,85,211,4,171,126,12,91,189,28,22,17,215,213,52,67,15,127,64,51,224,46,250,166,166,117,230,28,21,213,129,140,59,164,66,178,149,44,58,32,224,104,23,132,143,156,151,248,9,169,23,152,235,97,241,6,63,142,155,223,81,80,92,215,233,26,118,26,234,219,245,108,147,218,101,191,110,155,49,193,203,221,164,241,243,125,191,92,15,253,185,47,173,167,247,227,164,106,59,29,58,60,111,106,92,246,243,101,106,115,189,124,191,195,127,187,165,25,139,21,172,235,238,0,199,252,195,0,77,53,93,215,239,47,191,8,219,249,208,245,237,226,91,171,119,74,181,82,8,106,185,221,154,199,142,204,117,183,106,224,106,247,127,86,125,247,97,104,251,31,127,69,200,147,134,30,103,207,234,117,215,79,198,238,157,180,101,66,8,12,77,79,209,38,169,109,26,76,227,214,159,205,23,80,55,251,121,213,103,241,15,241,64,131,45,133,39,38,68,40,212,169,74,16,49,165,100,214,107,205,157,245,24,208,156,217,20,188,14,212,97,30,184,27,97,51,12,176,36,34,179,167,86,22,34,229,148,207,10,162,146,217,11,230,80,106,162,135,210,44,8,162,128,226,94,161,206,58,40,95,174,215,178,157,62,73,109,111,159,119,175,254,94,30,56,188,223,186,139,51,122,251,217,139,121,131,11,218,143,217,230,24,48,182,52,225,245,33,221,108,115,12,52,227,148,249,178,175,251,171,61,151,103,155,99,176,218,94,28,208,186,32,50,60,168,60,9,27,164,11,164,136,24,45,213,25,117,98,16,80,48,206,105,57,81,10,81,208,253,119,121,18,178,136,236,20,41,147,74,134,22,66,199,74,136,217,50,133,28,19,148,172,74,212,183,228,105,12,70,172,198,130,107,92,38,188,85,81,246,218,166,72,234,86,132,207,180,29,129,42,82,165,48,12,86,20,138,2,222,169,59,105,30,101,48,220,137,66,240,18,185,53,18,205,125,22,64,24,135,88,148,83,178,20,121,160,249,47,109,251,215,176,186,7,197,247,19,238,34,121,179,27,121,44,89,251,212,116,223,90,201,71,42,219,17,132,70,20,201,155,164,88,42,41,178,92,132,160,206,146,64,125,43,178,229,72,172,73,246,22,105,46,238,0,251,99,221,245,221,17,104,31,62,188,105,235,183,199,16,108,150,138,148,86,27,207,146,32,39,165,51,137,9,20,36,26,8,107,117,145,217,56,78,146,3,68,5,154,6,44,233,64,99,68,55,6,42,100,166,32,58,233,60,10,43,220,45,138,156,19,230,144,122,146,191,197,98,88,214,9,198,215,147,118,55,58,249,62,94,141,186,72,36,156,92,127,247,195,157,29,34,21,23,222,144,82,129,80,164,79,74,114,230,173,39,19,145,109,9,228,208,66,184,57,251,126,30,234,252,216,167,222,46,230,246,40,105,187,135,133,204,73,137,164,84,102,209,27,66,150,7,201,128,43,58,240,163,76,198,11,136,0,250,8,11,89,116,241,228,209,12,115,193,145,244,184,68,219,232,53,103,210,147,137,180,89,4,97,202,151,44,228,237,80,73,209,17,129,129,89,176,124,244,130,133,69,161,3,201,161,7,83,200,97,199,156,110,66,53,237,123,218,223,230,213,10,215,176,223,252,87,235,199,241,168,69,69,229,124,118,204,21,19,71,151,172,24,157,6,212,184,22,131,70,149,178,183,120,242,168,39,143,250,200,30,245,69,27,235,6,39,171,203,118,137,79,101,85,53,47,72,30,37,176,18,232,161,165,182,228,127,120,97,202,211,173,215,88,128,148,245,3,90,213,227,75,252,122,29,235,49,144,61,162,99,141,188,8,227,73,73,140,141,148,222,96,100,49,147,117,38,35,0,138,23,75,106,149,79,98,117,18,171,71,22,171,159,134,174,94,18,52,79,43,87,129,46,136,224,141,98,220,147,237,213,222,20,226,73,209,76,120,233,29,153,8,0,140,15,40,87,247,41,242,235,21,172,99,64,251,151,96,93,60,176,100,233,64,230,51,70,96,74,139,241,70,70,215,1,63,62,18,41,152,207,0,96,131,57,93,178,159,232,146,253,178,237,79,247,236,211,61,251,255,124,207,190,216,254,3,182,225,113,125,1,26,0,0 })));
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

			private bool _readSomeTopRecords = true;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })));
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

		#region Class: ChangeLeadContactAllFlowElement

		/// <exclude/>
		public class ChangeLeadContactAllFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadContactAllFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadContactAll";
				IsLogging = true;
				SchemaElementUId = new Guid("d21d53d2-a563-4394-aad1-8db8c7558606");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)(((process.ReadContactsByLeadCommunications.ResultEntity.IsColumnValueLoaded(process.ReadContactsByLeadCommunications.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadContactsByLeadCommunications.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,47,58,244,100,21,219,146,44,201,61,46,219,178,80,210,64,211,82,72,150,240,36,61,103,5,254,216,88,50,77,48,251,223,43,175,179,41,228,80,74,111,5,33,158,158,52,163,153,65,154,239,125,248,232,219,136,99,221,64,27,48,155,118,174,38,96,100,201,76,33,168,212,144,83,46,28,167,32,211,164,43,172,74,99,140,2,231,72,214,67,135,53,89,209,91,231,35,201,124,196,46,212,183,243,111,210,56,78,152,221,55,231,197,87,123,192,14,190,45,23,240,2,26,165,81,83,41,114,67,57,26,67,149,5,75,155,134,105,83,113,197,11,180,100,213,98,12,22,86,54,142,90,203,52,229,54,87,84,75,97,40,2,128,49,78,48,11,140,100,45,54,113,251,116,28,49,4,63,244,245,140,175,245,205,243,49,169,92,239,222,12,237,212,245,36,235,48,194,53,196,67,114,138,57,114,97,129,90,174,5,229,13,74,10,76,59,202,150,8,164,194,162,42,36,201,44,28,227,66,75,118,201,182,131,8,223,161,157,240,204,60,251,164,177,100,121,161,68,149,176,5,179,148,179,50,167,170,82,146,54,174,106,52,178,74,107,243,154,215,167,201,167,218,135,171,169,195,209,219,151,216,49,229,55,140,245,108,135,62,142,67,187,80,95,157,143,223,224,83,92,195,125,217,250,177,26,138,169,191,128,200,41,155,2,110,90,143,125,220,246,118,112,190,127,88,57,79,167,4,233,142,48,250,112,73,97,251,56,65,75,178,209,63,28,254,152,214,102,10,113,232,254,35,171,89,178,153,56,210,35,59,203,93,222,160,243,225,216,194,243,121,93,147,119,143,211,16,63,124,70,112,59,183,214,228,13,166,38,119,164,96,121,110,4,67,90,234,42,153,83,66,81,197,42,69,185,102,224,108,41,64,114,123,71,146,142,127,98,191,221,133,47,63,251,203,63,88,149,239,223,167,238,155,198,245,5,89,207,127,35,232,180,95,36,237,79,105,252,2,165,40,182,209,206,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,193,110,219,48,12,253,21,195,237,49,10,44,75,178,36,95,219,14,8,208,110,69,187,245,210,228,64,73,84,107,192,177,3,91,217,144,5,249,247,41,74,178,54,221,118,153,14,182,76,234,189,71,210,79,219,252,50,108,86,152,215,249,87,28,6,24,123,31,166,87,253,128,211,251,161,183,56,142,211,219,222,66,219,252,4,211,226,61,12,176,196,128,195,19,180,107,28,111,155,49,76,178,115,88,62,201,47,191,167,108,94,63,111,243,89,192,229,183,153,139,236,5,50,207,41,148,68,178,210,16,110,85,65,192,42,73,76,5,146,90,38,29,181,16,193,182,111,215,203,238,14,3,220,67,120,205,235,109,158,216,34,1,56,174,11,39,20,41,4,7,194,157,18,68,151,188,34,206,41,94,85,104,152,86,44,223,77,242,209,190,226,18,146,232,27,56,42,123,165,81,19,41,138,168,142,198,16,101,193,18,239,153,54,21,87,156,162,221,131,143,231,223,128,207,23,207,179,241,203,143,14,135,199,196,91,123,104,71,92,76,99,244,67,224,166,197,37,118,161,222,10,161,74,9,204,18,97,208,18,238,5,16,227,181,34,82,51,89,41,94,82,195,216,46,2,126,79,179,222,210,66,84,202,148,21,161,150,170,8,97,154,104,33,227,14,100,9,212,10,111,170,106,15,185,233,66,19,54,87,105,70,245,22,176,64,46,44,16,203,181,136,40,148,4,152,118,132,129,145,165,84,72,43,42,119,139,139,197,190,49,215,140,171,22,54,79,127,246,247,128,224,50,219,119,190,25,150,152,118,1,108,24,51,179,201,218,125,42,246,216,180,25,116,46,91,189,246,29,102,221,122,105,112,24,167,159,154,97,12,89,19,127,112,214,251,108,192,113,221,134,166,123,137,4,109,139,54,52,125,55,157,185,131,248,234,204,55,239,229,183,243,131,253,230,121,61,255,151,1,143,239,195,184,207,45,248,209,125,243,124,50,207,31,251,245,96,247,140,108,255,113,114,67,82,40,142,139,252,229,113,90,7,142,4,187,131,14,94,112,248,28,21,19,60,165,174,33,64,18,255,26,235,62,17,155,82,139,66,82,79,36,130,142,254,170,74,162,28,5,162,169,54,158,69,203,123,95,38,244,3,122,28,176,179,120,94,24,173,12,178,74,80,162,60,150,132,83,161,35,222,197,43,162,10,230,120,165,152,115,44,225,147,242,91,49,167,139,18,35,221,186,109,147,192,152,250,223,223,188,99,225,199,204,245,59,11,188,99,232,93,227,27,116,179,238,127,70,181,203,119,187,197,238,23,124,126,17,162,68,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeLeadContactAll.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: AddContactByLeadFlowElement

		/// <exclude/>
		public class AddContactByLeadFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddContactByLeadFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddContactByLead";
				IsLogging = true;
				SchemaElementUId = new Guid("1af802d9-9f23-4206-b9ce-ae0b0050da9e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordDefValues_Name = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Contact") : null)) != String.Empty ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Contact") : null)) : (((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != String.Empty ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) : (((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) != String.Empty ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) : ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)))));
				_recordDefValues_JobTitle = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("FullJobTitle").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("FullJobTitle") : null)));
				_recordDefValues_Dear = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Dear").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Dear") : null)));
				_recordDefValues_Department = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Department").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("DepartmentId") : Guid.Empty)));
				_recordDefValues_Job = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Job").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("JobId") : Guid.Empty)));
				_recordDefValues_DoNotUseEmail = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseEmail").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseEmail") : false)));
				_recordDefValues_DoNotUseSms = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseSMS").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseSMS") : false)));
				_recordDefValues_DoNotUseMail = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseMail").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseMail") : false)));
				_recordDefValues_DoNotUseCall = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUsePhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUsePhone") : false)));
				_recordDefValues_DoNotUseFax = () => (bool)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DoNotUseFax").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<bool>("DoNotUseFax") : false)));
				_recordDefValues_Confirmed = () => (bool)(false);
				_recordDefValues_SalutationType = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Title").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("TitleId") : Guid.Empty)));
				_recordDefValues_Gender = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Gender").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("GenderId") : Guid.Empty)));
				_recordDefValues_DecisionRole = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("DecisionRole").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("DecisionRoleId") : Guid.Empty)));
				_recordDefValues_Email = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)));
				_recordDefValues_MobilePhone = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)));
				_recordDefValues_Phone = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Name", () => _recordDefValues_Name.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_JobTitle", () => _recordDefValues_JobTitle.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Dear", () => _recordDefValues_Dear.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Department", () => _recordDefValues_Department.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Job", () => _recordDefValues_Job.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseEmail", () => _recordDefValues_DoNotUseEmail.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseSms", () => _recordDefValues_DoNotUseSms.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseMail", () => _recordDefValues_DoNotUseMail.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseCall", () => _recordDefValues_DoNotUseCall.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DoNotUseFax", () => _recordDefValues_DoNotUseFax.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Confirmed", () => _recordDefValues_Confirmed.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_SalutationType", () => _recordDefValues_SalutationType.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Gender", () => _recordDefValues_Gender.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_DecisionRole", () => _recordDefValues_DecisionRole.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Email", () => _recordDefValues_Email.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_MobilePhone", () => _recordDefValues_MobilePhone.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Phone", () => _recordDefValues_Phone.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Name;
			internal Func<string> _recordDefValues_JobTitle;
			internal Func<string> _recordDefValues_Dear;
			internal Func<Guid> _recordDefValues_Department;
			internal Func<Guid> _recordDefValues_Job;
			internal Func<bool> _recordDefValues_DoNotUseEmail;
			internal Func<bool> _recordDefValues_DoNotUseSms;
			internal Func<bool> _recordDefValues_DoNotUseMail;
			internal Func<bool> _recordDefValues_DoNotUseCall;
			internal Func<bool> _recordDefValues_DoNotUseFax;
			internal Func<bool> _recordDefValues_Confirmed;
			internal Func<Guid> _recordDefValues_SalutationType;
			internal Func<Guid> _recordDefValues_Gender;
			internal Func<Guid> _recordDefValues_DecisionRole;
			internal Func<string> _recordDefValues_Email;
			internal Func<string> _recordDefValues_MobilePhone;
			internal Func<string> _recordDefValues_Phone;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
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
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,155,93,143,91,183,17,134,255,138,170,228,162,1,60,6,63,134,31,179,64,81,160,177,83,184,136,91,195,78,115,99,251,98,72,14,99,21,90,201,144,180,105,221,197,254,247,14,181,222,248,35,141,178,118,100,192,155,179,186,56,171,149,68,30,146,103,30,190,239,240,240,156,207,191,220,189,122,41,243,147,249,119,178,217,240,118,221,119,119,191,94,111,228,238,163,205,186,202,118,123,247,219,117,229,229,226,191,92,150,242,136,55,124,42,59,217,124,207,203,51,217,126,187,216,238,238,204,222,45,54,191,51,255,242,199,253,183,243,147,167,231,243,7,59,57,253,231,131,166,181,179,53,156,163,75,16,51,22,192,202,30,72,56,2,102,139,41,83,43,181,56,45,92,215,203,179,211,213,67,217,241,35,222,189,152,159,156,207,247,181,141,10,66,173,156,200,1,166,214,0,93,102,200,190,23,8,149,92,105,141,82,239,121,126,113,103,190,173,47,228,148,247,39,125,83,216,198,34,62,6,11,185,139,214,96,3,65,110,205,0,103,227,27,198,236,91,243,163,240,235,223,191,41,248,244,139,167,15,182,255,248,247,74,54,79,246,245,158,116,94,110,229,249,93,253,244,189,15,238,47,229,84,86,187,147,115,70,142,189,155,10,214,82,7,140,222,234,105,156,27,29,71,147,98,22,146,112,161,5,126,26,205,147,243,88,41,35,197,4,153,77,2,108,49,0,75,175,218,208,44,129,173,173,173,182,81,228,254,106,183,216,189,250,122,63,70,39,231,57,6,41,46,116,240,132,86,71,196,119,96,172,6,106,202,30,125,204,156,184,95,60,255,226,249,236,15,127,154,61,217,109,22,171,31,238,222,63,125,185,123,53,251,243,236,119,209,173,147,217,31,63,231,126,116,17,239,90,182,144,196,33,32,123,4,178,53,129,55,217,11,54,36,159,111,226,229,185,118,183,62,243,203,67,218,116,206,193,131,201,85,39,164,172,1,151,169,35,216,236,114,202,28,152,165,220,192,203,115,237,110,157,124,214,221,64,211,165,219,70,208,73,15,232,48,2,147,209,57,33,147,184,16,153,107,195,209,141,175,190,26,211,118,91,108,95,46,249,213,247,63,159,189,31,11,183,217,82,15,119,191,89,108,182,187,217,66,5,105,182,238,179,141,108,207,150,59,189,168,51,85,156,165,212,221,98,189,82,1,91,237,184,238,126,225,154,127,100,85,123,12,62,168,236,253,83,94,44,143,209,136,171,138,62,188,9,127,57,219,46,86,170,254,179,151,47,214,43,57,70,91,126,86,227,201,135,214,240,112,93,22,75,185,42,127,121,225,95,190,227,72,222,190,244,231,207,46,141,205,179,249,201,179,95,178,54,175,255,94,6,251,187,230,230,125,95,243,108,126,231,217,252,201,250,108,83,71,141,126,252,115,229,51,246,103,48,175,95,240,127,14,87,175,203,58,246,197,30,242,138,127,144,205,223,245,140,251,226,251,175,238,241,142,247,39,255,78,219,125,85,113,107,197,179,21,1,147,36,15,124,28,148,196,4,205,72,180,185,24,211,75,219,151,126,44,93,54,178,170,242,145,13,219,159,249,77,99,174,44,152,126,178,58,91,46,247,39,216,238,251,63,60,221,235,134,191,254,230,222,91,248,189,85,195,186,45,250,66,218,131,213,199,180,232,98,126,113,113,231,109,3,233,171,113,150,88,29,129,167,0,24,98,6,106,40,96,49,80,105,92,145,82,61,104,32,115,137,217,176,42,149,96,212,233,39,234,161,68,111,64,66,45,216,216,122,14,97,90,6,18,155,169,213,107,87,188,168,76,168,19,215,17,201,204,122,222,84,57,22,167,174,43,142,73,246,136,83,236,55,26,49,179,127,173,203,76,219,177,148,203,170,111,33,158,12,196,100,140,45,94,161,51,20,85,214,187,87,136,59,27,80,103,34,138,181,11,149,233,32,196,53,180,84,177,121,232,234,55,1,141,190,203,168,85,69,86,186,179,38,130,201,240,180,32,22,73,46,187,22,193,121,167,134,15,245,108,165,167,2,182,52,39,182,251,200,33,31,25,226,39,90,108,199,227,237,45,192,19,3,152,61,81,46,174,131,113,137,149,191,20,64,225,65,245,229,108,139,152,84,157,28,86,97,194,90,114,10,10,93,139,202,133,100,3,37,104,186,146,26,137,213,228,37,135,40,211,2,184,166,94,44,25,129,96,155,198,86,29,165,66,43,80,125,178,58,211,21,195,61,29,25,224,123,162,200,238,70,63,167,2,112,113,20,76,178,29,146,40,182,40,10,112,110,150,129,44,149,238,147,119,189,187,67,0,39,118,145,156,211,80,139,65,47,109,9,99,150,45,8,82,36,80,20,180,212,242,205,0,88,37,146,50,53,29,3,231,85,129,107,3,50,122,232,222,26,83,154,170,171,224,65,128,61,34,122,237,177,186,239,88,198,250,143,1,242,138,114,207,194,24,186,227,86,112,90,0,51,231,170,97,132,90,125,47,99,101,26,161,12,123,147,187,13,154,96,176,11,82,143,12,240,223,166,230,160,127,43,191,53,59,117,136,93,91,162,241,167,41,100,138,64,92,60,212,160,49,167,243,108,73,37,222,8,126,99,48,212,189,203,80,204,32,168,96,129,236,162,230,108,170,204,170,26,70,29,95,62,200,175,45,42,51,221,43,251,205,141,145,80,237,85,103,211,134,179,177,182,235,56,89,235,166,197,111,38,54,166,117,11,190,249,177,162,29,61,20,143,21,28,165,220,106,79,98,88,142,45,192,235,217,106,189,155,157,109,101,38,151,139,116,211,192,152,76,137,161,244,12,166,239,47,11,106,36,165,68,224,208,25,125,195,157,76,154,132,143,118,197,75,194,177,224,226,171,14,4,113,6,246,58,36,201,57,50,62,208,24,159,131,24,39,209,25,17,163,198,107,211,180,68,53,57,67,246,174,2,37,244,88,108,119,132,126,90,24,163,254,186,98,180,80,220,184,49,213,185,67,150,38,80,181,171,45,120,238,232,63,33,198,79,30,62,185,133,120,98,16,107,34,91,180,207,30,26,177,14,132,134,178,166,7,82,160,167,104,49,196,38,33,132,131,16,59,159,53,237,77,8,189,91,229,80,208,140,213,172,4,62,168,21,167,166,105,70,110,211,130,56,160,137,169,118,15,214,247,160,94,186,105,247,52,160,70,142,18,53,59,169,41,37,255,233,32,190,149,226,9,82,172,180,148,130,202,174,102,106,154,22,23,21,143,92,208,131,230,245,106,180,109,112,78,57,58,184,51,41,150,218,99,23,96,19,199,206,36,53,211,236,212,68,246,236,72,170,152,208,27,77,139,226,177,12,152,37,235,116,88,198,13,187,88,84,148,125,142,234,80,48,27,114,169,181,116,236,53,233,183,40,126,125,135,248,22,227,73,97,108,91,107,97,244,156,162,122,97,76,168,25,190,11,5,92,163,220,92,67,27,235,225,133,45,21,92,97,105,65,93,35,42,137,166,26,160,162,145,171,120,119,137,73,203,243,196,22,182,172,66,108,154,14,129,9,163,84,82,107,67,169,38,117,212,37,101,66,227,153,219,167,195,184,243,127,110,33,158,26,196,85,77,243,200,220,92,29,161,157,56,142,101,102,4,10,138,166,83,61,165,96,14,223,31,150,230,178,209,148,58,225,88,222,182,41,0,101,138,32,28,200,49,73,182,28,143,15,241,30,209,67,20,252,244,131,219,88,158,76,44,123,155,13,178,6,96,103,209,84,134,156,74,83,214,129,16,54,45,177,113,216,126,69,144,186,74,78,105,154,94,114,102,85,52,77,127,128,40,105,56,154,154,40,235,180,77,244,9,98,249,115,22,36,238,141,43,91,4,59,212,25,147,150,47,182,35,72,51,145,48,54,159,46,55,183,30,115,79,40,111,39,227,37,127,235,77,22,241,149,220,184,253,101,145,212,246,227,216,221,147,199,93,254,210,67,43,130,37,99,186,17,232,70,106,228,132,80,243,56,210,56,195,50,20,40,210,184,91,52,108,96,112,28,15,47,236,120,246,222,166,58,246,57,245,8,168,233,32,140,125,19,96,172,14,104,101,118,213,79,12,93,23,18,91,77,167,161,99,208,36,57,199,12,165,163,162,75,221,57,74,49,218,118,236,133,157,191,202,170,201,230,22,222,235,193,107,74,13,45,107,160,106,226,62,54,131,214,6,69,5,27,188,41,222,55,171,241,236,110,134,238,154,166,49,165,144,170,52,52,28,89,11,66,182,53,128,134,101,79,57,69,70,228,195,186,155,84,96,163,99,85,25,157,193,144,56,1,123,201,208,29,246,146,107,111,34,125,90,240,34,107,102,61,104,141,181,167,177,235,210,12,221,205,99,92,93,237,49,120,106,246,200,240,62,94,223,110,110,184,46,186,1,153,211,40,223,203,120,162,178,141,205,13,206,147,78,176,221,119,99,68,188,132,27,129,46,165,228,56,116,15,198,89,37,207,91,171,186,219,29,104,210,22,162,52,149,206,240,43,107,56,165,59,227,164,66,69,28,236,83,129,82,213,32,54,141,238,98,115,244,206,216,105,161,123,221,199,245,142,136,238,253,41,221,70,185,221,25,124,229,153,185,54,217,219,58,23,116,18,74,97,108,76,234,29,10,161,26,63,91,77,179,246,240,206,224,44,38,7,13,77,110,168,14,145,171,90,145,106,171,90,232,34,70,51,231,216,112,98,235,175,215,125,8,242,136,236,190,251,144,221,45,194,147,66,216,8,42,100,190,107,158,27,5,198,158,72,200,68,13,76,238,29,107,236,182,199,120,248,17,59,212,12,217,100,134,148,21,64,180,164,179,1,71,6,135,190,82,208,156,216,152,50,45,132,175,251,56,246,17,17,126,255,73,219,91,136,127,239,16,63,191,248,31,53,148,11,47,198,69,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.AddContactByLead.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: AddContactAdressFlowElement

		/// <exclude/>
		public class AddContactAdressFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddContactAdressFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddContactAdress";
				IsLogging = true;
				SchemaElementUId = new Guid("1224fb70-fb27-4338-be60-708c6885b75d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordDefValues_Address = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Address").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Address") : null)));
				_recordDefValues_City = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("City").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("CityId") : Guid.Empty)));
				_recordDefValues_Zip = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Zip").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Zip") : null)));
				_recordDefValues_Contact = () => (Guid)((process.AddContactByLead.RecordId));
				_recordDefValues_Region = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Region").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("RegionId") : Guid.Empty)));
				_recordDefValues_Primary = () => (bool)(true);
				_recordDefValues_Country = () => (Guid)(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Country").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("CountryId") : Guid.Empty)));
				_recordDefValues_AddressType = () => (Guid)((((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("AddressType").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AddressTypeId") : Guid.Empty)) != Guid.Empty) ? ((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("AddressType").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("AddressTypeId") : Guid.Empty)) : new Guid("fb7a3f6a-f36b-1410-6f81-1c6f65e50343"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Address", () => _recordDefValues_Address.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_City", () => _recordDefValues_City.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Zip", () => _recordDefValues_Zip.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Region", () => _recordDefValues_Region.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Primary", () => _recordDefValues_Primary.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Country", () => _recordDefValues_Country.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_AddressType", () => _recordDefValues_AddressType.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<string> _recordDefValues_Address;
			internal Func<Guid> _recordDefValues_City;
			internal Func<string> _recordDefValues_Zip;
			internal Func<Guid> _recordDefValues_Contact;
			internal Func<Guid> _recordDefValues_Region;
			internal Func<bool> _recordDefValues_Primary;
			internal Func<Guid> _recordDefValues_Country;
			internal Func<Guid> _recordDefValues_AddressType;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,89,111,27,55,16,254,43,193,62,244,73,211,240,62,212,167,214,117,91,3,185,0,167,69,209,196,8,134,228,48,94,116,165,85,164,85,26,215,240,127,239,172,21,37,66,42,7,137,93,167,8,96,8,16,86,212,114,150,156,239,224,204,158,191,104,87,63,181,221,64,203,105,197,110,69,147,245,81,153,54,74,197,26,141,11,32,146,114,96,82,12,16,188,170,16,172,66,237,139,183,57,234,102,50,199,25,77,155,205,236,195,210,14,205,164,29,104,182,154,62,59,127,31,116,88,174,105,242,162,94,254,56,206,167,52,195,95,199,7,24,137,53,68,138,224,173,72,96,40,37,8,25,51,212,170,99,114,38,24,73,185,217,172,37,186,160,40,151,10,214,103,5,38,186,8,65,103,3,154,168,104,229,100,205,54,52,147,142,234,112,248,102,177,164,213,170,237,231,211,115,122,119,253,244,108,193,171,220,60,251,160,239,214,179,121,51,153,209,128,79,112,56,157,54,72,130,140,205,8,217,68,11,166,146,7,212,177,128,198,228,149,15,36,157,244,205,36,227,98,24,195,54,71,165,153,20,28,240,55,236,214,116,25,249,188,29,243,165,133,12,214,241,92,169,51,24,173,4,4,23,60,212,226,106,36,237,98,76,101,155,175,159,215,45,95,183,171,71,235,25,45,219,252,54,237,196,249,235,151,211,243,220,207,135,101,223,141,161,31,93,222,254,148,222,12,155,228,190,253,235,247,205,134,6,30,31,39,53,23,147,245,138,14,186,150,230,195,225,60,247,165,157,191,220,196,188,184,224,41,179,5,46,219,213,54,11,135,175,214,216,53,147,101,251,242,244,163,217,58,88,175,134,126,246,21,109,117,194,219,228,24,76,178,203,229,142,28,44,237,106,209,225,217,229,239,105,243,205,171,117,63,124,247,128,176,28,149,205,117,243,193,156,105,243,188,145,90,136,100,53,129,138,142,55,23,44,243,94,179,12,76,212,88,178,178,232,77,126,222,240,58,174,21,253,217,209,234,241,95,243,173,14,54,43,63,249,150,71,63,24,120,178,157,57,61,255,148,5,93,156,140,75,58,97,184,207,247,138,57,200,40,48,214,12,49,20,214,154,172,30,2,25,1,34,147,172,38,71,89,45,109,17,99,33,245,47,219,140,221,227,5,45,113,195,249,199,203,219,17,54,57,169,68,173,8,197,167,2,166,88,13,72,54,66,210,210,228,196,83,85,114,215,23,182,115,163,89,121,11,73,41,98,158,70,1,24,216,69,76,12,28,190,36,33,181,220,17,246,247,165,140,97,239,13,28,148,5,66,149,150,52,207,180,179,51,43,130,246,169,142,156,175,28,198,185,4,209,240,246,10,137,96,60,177,69,201,180,87,49,73,69,43,188,172,224,9,35,167,196,41,8,69,34,68,25,83,213,94,171,90,213,54,255,15,250,254,207,245,226,51,52,179,153,176,79,53,221,229,63,87,234,102,196,239,6,14,241,142,163,95,219,150,63,209,41,126,233,103,116,149,146,55,227,166,134,164,10,27,161,151,69,128,177,149,153,30,61,65,46,6,181,8,24,125,22,111,35,124,40,206,155,107,135,175,179,175,20,160,122,195,236,14,85,142,154,142,124,94,135,164,139,87,50,11,113,167,157,47,172,157,35,126,112,215,53,255,49,212,198,235,202,110,47,57,119,35,207,170,151,16,133,102,168,117,180,73,5,233,83,184,65,253,115,7,245,157,77,222,192,38,127,88,175,218,57,111,248,227,86,89,147,71,93,29,66,213,76,7,105,164,0,87,131,4,153,93,117,150,172,208,70,223,154,85,114,65,106,148,244,154,219,24,100,134,91,207,165,171,48,92,225,179,91,87,85,178,192,108,238,244,115,167,159,255,69,63,63,82,215,190,166,229,217,199,245,227,157,72,213,5,230,68,114,4,165,74,9,220,146,115,119,46,100,113,130,162,14,217,237,232,231,228,170,78,64,115,105,45,85,141,64,154,85,96,108,68,238,232,249,75,22,27,144,28,119,192,239,123,183,47,217,9,56,118,0,238,102,60,168,156,184,197,199,177,167,68,158,169,121,148,124,64,95,71,206,95,87,162,197,179,3,20,193,4,241,145,79,209,24,53,68,171,18,144,136,94,132,144,172,205,110,71,162,7,253,154,193,62,219,175,78,193,125,20,119,77,1,172,180,12,7,119,101,28,43,23,222,89,137,186,250,136,46,215,175,141,170,123,11,153,126,184,141,90,134,135,148,15,182,130,69,238,246,184,134,229,110,47,160,130,108,21,83,57,80,22,49,223,0,232,76,90,144,14,192,60,103,122,139,164,89,38,213,130,8,201,71,193,0,25,37,118,128,62,30,112,160,251,139,101,255,186,101,144,247,227,93,145,247,99,162,7,114,200,11,174,172,193,96,185,255,182,165,154,84,20,134,20,229,29,222,87,226,141,46,5,138,206,65,53,227,173,106,172,93,37,159,109,202,42,147,101,50,137,197,115,125,188,89,136,218,102,198,219,241,65,14,166,48,66,99,153,1,133,117,105,16,11,42,179,43,236,63,142,158,220,95,244,171,1,187,123,156,14,218,11,155,30,95,169,232,196,214,90,13,83,200,32,59,145,145,10,216,129,93,245,65,8,141,121,11,219,241,105,191,28,198,119,86,183,253,138,235,75,163,102,92,201,168,148,132,18,88,61,134,133,3,152,98,134,108,180,145,49,160,100,11,188,62,106,70,217,144,28,215,73,149,152,14,134,75,67,8,108,10,80,5,250,20,75,49,156,230,93,59,110,135,43,188,216,102,140,34,113,85,25,53,141,88,153,0,137,111,227,181,90,233,28,101,149,235,126,144,239,180,121,116,153,5,235,56,93,18,116,181,134,143,69,82,144,76,149,128,18,45,247,156,217,36,77,215,71,217,179,242,141,203,14,28,142,28,18,89,241,65,233,29,216,108,75,202,162,56,37,196,191,235,226,189,112,101,81,133,113,92,29,240,23,55,192,60,155,53,73,150,203,98,25,75,14,12,118,146,91,184,30,226,155,227,246,111,250,76,85,62,164,89,191,15,177,25,143,223,0,175,19,254,252,3,145,229,15,109,96,25,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private Guid _filterEntitySchemaId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid FilterEntitySchemaId {
				get {
					return _filterEntitySchemaId;
				}
				set {
					_filterEntitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,93,111,91,69,16,253,43,198,229,1,164,140,217,239,15,75,8,65,41,40,82,11,21,5,30,104,250,48,187,51,91,44,156,123,163,235,235,162,18,229,191,51,215,73,104,90,192,84,109,30,90,92,63,56,241,93,207,236,238,236,156,57,103,214,231,243,143,199,231,103,60,95,206,127,228,97,192,77,223,198,197,221,126,224,197,195,161,175,188,217,44,238,247,21,215,171,63,176,172,249,33,14,120,202,35,15,63,227,122,203,155,251,171,205,120,52,123,217,108,126,52,255,248,217,110,116,190,124,124,62,63,30,249,244,167,99,18,239,186,218,128,214,50,40,27,3,56,12,22,176,228,4,181,54,111,75,13,170,150,38,198,181,95,111,79,187,7,60,226,67,28,127,157,47,207,231,59,111,226,32,176,78,62,151,4,30,189,5,231,109,132,162,27,67,139,200,169,22,167,125,112,243,139,163,249,166,254,202,167,184,155,244,133,49,121,71,198,232,4,65,215,4,78,91,4,212,37,130,143,46,213,200,198,55,31,38,227,171,239,191,48,124,124,231,241,241,230,251,223,59,30,30,237,252,46,27,174,55,252,100,33,79,95,121,112,111,205,167,220,141,203,115,148,205,181,166,42,104,157,27,184,96,53,96,50,6,66,114,78,197,144,56,179,191,16,131,191,162,185,60,15,53,39,151,67,132,132,42,130,163,224,1,185,85,89,104,98,143,90,87,170,52,153,220,235,198,213,248,252,238,46,70,203,243,24,74,114,161,6,8,216,60,56,85,13,100,47,193,245,213,83,169,138,130,81,234,226,201,157,39,211,198,104,181,57,91,227,243,159,255,190,191,31,24,105,182,150,183,197,55,171,97,51,206,86,114,100,179,190,205,6,222,108,215,227,170,123,58,147,51,89,115,29,87,125,183,248,146,72,158,111,46,125,158,189,148,14,55,189,158,159,92,102,213,201,124,121,242,111,121,117,245,247,50,138,47,103,214,171,73,117,50,63,58,153,63,234,183,67,157,60,218,233,195,245,33,239,102,80,87,47,248,135,183,235,215,165,143,157,217,3,236,240,41,15,223,201,140,59,243,221,208,215,56,226,110,242,31,101,221,215,142,171,106,202,5,35,71,34,177,4,39,65,133,228,216,67,118,58,83,77,94,135,162,119,214,63,112,227,129,187,202,111,184,176,221,204,47,22,115,157,255,242,164,219,174,215,187,9,54,187,253,79,128,186,90,248,213,200,215,55,78,246,134,135,158,86,109,197,116,220,189,201,138,46,230,23,23,71,55,209,171,40,146,73,174,1,133,74,83,130,70,137,65,44,146,175,214,197,216,42,165,168,247,162,87,59,235,43,181,34,41,173,13,56,46,14,138,10,25,146,202,134,88,233,24,66,60,44,244,58,227,83,9,89,65,227,168,37,183,34,66,50,49,65,83,24,75,38,114,49,221,54,122,239,202,244,135,2,221,98,178,87,81,55,136,140,89,18,46,24,72,164,17,178,206,165,217,104,77,107,102,31,116,125,197,172,74,16,3,203,114,168,206,37,40,242,77,33,45,65,125,224,106,106,227,247,2,186,178,206,166,115,46,128,213,73,158,81,98,40,41,17,84,54,169,209,148,219,41,236,133,110,172,65,171,104,42,20,52,78,152,187,88,72,218,32,4,27,157,70,203,69,74,228,97,65,151,117,147,106,102,101,83,177,73,49,35,20,45,99,91,0,114,38,59,68,146,56,133,91,134,238,47,199,15,63,59,235,55,35,174,229,41,241,161,160,216,26,143,209,138,232,83,205,77,40,196,137,128,133,64,98,80,161,73,129,84,22,235,65,16,176,39,217,109,20,122,32,41,101,146,158,92,132,63,89,131,85,36,162,58,250,170,242,127,16,112,80,217,38,159,0,91,145,50,96,109,144,50,80,42,120,163,125,22,212,36,209,144,239,4,138,53,182,164,12,101,200,205,136,206,55,74,22,154,171,20,94,86,69,41,175,8,51,191,130,226,24,49,41,89,130,176,104,16,153,54,109,171,176,168,54,206,82,15,200,213,42,125,195,127,227,81,180,237,108,219,213,190,107,171,225,148,73,112,214,141,88,199,89,193,141,124,234,187,29,86,103,171,174,245,195,41,94,242,233,192,56,202,216,192,181,31,104,118,76,135,2,203,183,37,87,209,205,108,131,215,144,26,75,1,149,12,20,123,82,82,174,149,37,23,146,37,178,239,5,44,139,161,168,178,80,78,179,78,116,177,166,0,25,171,6,66,71,210,161,22,227,13,238,133,101,149,114,150,155,108,189,185,148,39,118,118,144,114,8,80,109,139,142,156,162,236,15,172,171,165,202,86,177,144,171,45,210,226,59,37,114,163,100,233,111,85,42,49,75,60,172,148,132,91,38,215,71,163,192,248,179,179,161,127,182,146,84,253,0,226,215,3,113,195,169,141,203,82,102,131,8,32,215,82,133,228,67,2,79,205,21,50,152,74,214,239,5,136,107,66,98,199,8,154,138,4,162,146,196,32,86,15,194,35,58,165,154,168,101,181,23,196,164,53,97,197,137,146,173,84,1,20,234,145,206,161,64,86,78,82,92,210,182,82,190,125,16,143,131,252,217,3,130,235,241,255,127,38,79,141,154,47,109,82,137,187,242,34,125,78,138,49,131,145,82,33,255,160,156,95,60,8,149,40,73,108,116,112,74,248,199,136,200,195,42,173,26,139,112,22,42,145,182,45,182,210,244,254,75,86,21,36,113,177,26,144,104,182,75,98,206,117,42,245,44,18,139,68,71,81,196,3,163,163,152,139,35,37,117,33,102,9,105,206,22,178,55,5,88,229,168,82,42,222,215,219,238,245,238,246,219,110,28,62,220,212,188,38,15,169,220,170,116,228,66,60,218,203,105,154,44,26,204,87,130,36,85,87,84,84,198,80,219,123,129,94,182,53,59,111,2,88,163,157,244,50,98,145,165,197,5,1,46,113,148,172,181,62,237,231,161,146,149,151,144,9,5,79,183,180,211,197,149,232,208,0,34,69,69,83,215,98,20,149,219,71,239,39,239,50,124,67,72,34,193,163,135,98,12,75,72,242,212,100,144,76,153,147,22,166,47,74,91,61,193,119,246,209,231,179,111,183,43,90,220,59,61,27,159,127,58,251,98,246,191,216,213,82,182,113,191,239,127,219,158,45,188,74,210,144,76,174,109,155,22,23,68,159,184,82,128,88,37,23,153,43,233,178,104,37,78,55,89,40,253,140,140,11,145,42,8,45,105,208,53,180,224,217,43,235,236,254,90,247,201,155,253,162,52,155,42,217,63,31,195,219,184,187,177,255,155,35,139,175,182,155,85,119,64,63,100,189,245,109,248,107,36,207,187,90,99,159,92,252,9,127,53,51,13,228,30,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.AddContactAdress.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: AddContactWebFlowElement

		/// <exclude/>
		public class AddContactWebFlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddContactWebFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddContactWeb";
				IsLogging = true;
				SchemaElementUId = new Guid("88ec16df-a2b4-4df3-9af2-11eeb925ec05");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordDefValues_Contact = () => (Guid)((process.AddContactByLead.RecordId));
				_recordDefValues_Number = () => new LocalizableString(((process.ReadLeadData.ResultEntity.IsColumnValueLoaded(process.ReadLeadData.ResultEntity.Schema.Columns.GetByName("Website").ColumnValueName) ? process.ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Website") : null)));
				_recordDefValues_CommunicationType = () => (Guid)(new Guid("6a8ba927-67cc-df11-9b2a-001d60e938c6"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_Contact", () => _recordDefValues_Contact.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Number", () => _recordDefValues_Number.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_CommunicationType", () => _recordDefValues_CommunicationType.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_Contact;
			internal Func<string> _recordDefValues_Number;
			internal Func<Guid> _recordDefValues_CommunicationType;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,84,203,106,220,48,20,253,23,45,186,242,45,214,195,150,228,46,195,180,12,180,211,64,211,7,36,33,232,113,149,24,252,152,216,50,77,24,230,223,43,143,51,77,9,161,148,208,46,186,187,146,124,142,206,61,58,215,187,171,122,124,91,55,17,135,42,152,102,196,108,90,251,138,104,153,115,227,114,1,38,20,26,4,211,6,84,201,13,104,169,156,247,69,94,50,199,73,214,153,22,43,178,160,87,190,142,36,171,35,182,99,117,190,123,36,141,195,132,217,85,56,44,62,185,27,108,205,231,249,2,65,77,80,26,53,200,34,183,32,208,90,80,206,56,8,129,107,91,10,37,40,58,178,104,9,190,228,46,4,10,142,210,0,66,249,36,131,5,1,165,181,78,107,157,11,198,144,100,13,134,184,186,219,14,56,142,117,223,85,59,252,89,159,221,111,147,202,229,238,147,190,153,218,142,100,45,70,115,106,226,77,69,12,230,40,10,103,192,9,93,128,8,40,193,112,237,129,27,43,153,84,72,75,42,73,230,204,54,206,180,100,237,73,230,77,52,95,76,51,225,129,121,87,39,141,140,231,84,21,101,194,82,238,64,112,150,39,191,148,132,164,61,104,228,165,214,214,31,253,122,55,213,169,174,199,205,212,226,80,187,7,219,49,249,215,15,213,206,245,93,28,250,102,166,222,28,62,63,195,187,184,152,251,112,244,109,105,40,166,253,25,68,246,217,52,226,73,83,99,23,87,157,235,125,221,93,47,156,251,125,130,180,91,51,212,227,209,133,213,237,100,26,146,13,245,245,205,111,221,58,153,198,216,183,255,81,171,89,106,51,113,164,144,29,228,206,25,244,245,184,109,204,253,97,93,145,87,183,83,31,223,188,71,227,215,126,169,201,19,76,69,46,8,229,121,110,11,142,192,116,153,154,83,133,2,197,75,5,66,115,227,29,43,140,20,238,130,36,29,47,98,63,95,143,31,191,119,199,57,88,148,95,190,78,187,79,54,78,143,200,106,247,39,130,246,151,179,164,203,244,220,127,117,238,184,66,230,149,16,192,12,19,32,156,83,160,189,161,192,37,99,60,8,233,184,167,47,159,59,148,5,215,52,245,68,133,167,233,15,67,57,88,43,37,104,206,133,47,176,180,65,134,95,230,238,43,218,103,211,232,189,229,134,34,66,46,49,185,226,75,6,86,26,13,62,199,146,42,155,231,225,49,141,31,82,134,166,118,14,217,191,206,228,108,254,51,211,183,30,55,125,220,76,77,51,191,214,15,192,153,222,106,121,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private Guid _filterEntitySchemaId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			public override Guid FilterEntitySchemaId {
				get {
					return _filterEntitySchemaId;
				}
				set {
					_filterEntitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,150,75,111,219,70,16,199,191,138,192,228,232,21,246,253,208,173,112,82,64,128,147,26,73,154,30,108,31,102,119,103,19,34,20,41,144,84,11,87,208,119,239,144,150,235,71,91,39,104,81,192,64,120,144,72,174,254,51,179,59,243,155,209,190,122,57,94,111,177,90,85,31,176,239,97,232,202,184,60,237,122,92,158,247,93,194,97,88,158,117,9,154,250,119,136,13,158,67,15,27,28,177,255,8,205,14,135,179,122,24,79,22,15,101,213,73,245,242,215,121,181,90,93,236,171,245,136,155,159,215,153,172,67,202,193,139,28,88,206,41,51,173,81,48,143,192,153,149,144,115,182,129,187,172,72,156,186,102,183,105,223,224,8,231,48,126,174,86,251,106,182,70,6,82,145,210,106,227,89,18,137,51,157,121,98,80,208,48,45,172,213,69,102,227,56,86,135,147,106,72,159,113,3,179,211,59,49,231,26,130,144,130,73,81,60,211,32,144,249,32,232,206,36,94,156,177,8,90,76,226,227,239,239,132,23,47,46,214,195,79,191,181,216,191,159,237,174,10,52,3,94,45,233,237,163,23,175,27,220,96,59,174,246,2,138,231,146,118,26,138,84,76,75,110,89,12,9,25,32,143,156,27,158,33,224,129,4,127,158,230,106,239,28,120,94,140,101,58,90,218,155,143,137,69,148,142,97,176,165,100,157,146,9,241,112,245,226,106,10,49,215,195,182,129,235,143,127,141,244,135,156,23,187,54,117,109,169,251,13,230,5,221,141,144,198,69,132,129,158,186,118,209,32,228,69,221,150,174,223,192,88,119,237,242,180,71,24,105,173,199,212,245,121,177,206,55,46,182,15,242,124,223,201,254,242,166,92,46,171,213,229,63,21,204,241,251,230,120,30,150,204,227,106,185,172,78,46,171,247,221,174,79,147,69,53,61,220,102,111,246,192,143,23,251,155,143,219,235,198,198,44,123,3,45,124,194,254,45,121,156,229,243,210,43,24,97,118,254,129,226,190,53,28,101,48,220,137,194,28,66,96,26,173,100,62,11,96,65,132,88,148,83,178,20,57,171,223,97,193,30,219,132,15,3,19,54,162,178,134,106,184,160,164,18,52,129,244,153,51,74,163,202,218,122,149,179,154,245,179,231,187,96,110,11,155,222,180,187,166,153,29,12,243,254,39,82,142,129,31,87,94,221,75,244,61,11,93,174,75,141,121,221,254,155,163,58,84,135,195,201,125,44,165,231,134,2,6,198,5,70,166,3,16,85,134,216,148,222,27,239,163,177,90,241,39,177,228,178,36,64,227,88,129,2,116,146,186,176,160,172,99,209,120,37,28,88,148,152,158,5,150,160,129,96,162,174,33,68,40,76,91,37,40,91,82,50,235,181,230,206,122,12,104,30,97,105,83,240,58,208,102,60,112,71,45,199,26,130,184,36,202,183,71,3,66,36,106,101,147,228,117,59,214,227,245,233,124,70,171,61,58,163,130,176,228,72,103,65,252,11,197,98,116,142,142,69,233,108,208,198,226,202,215,97,126,55,177,58,1,187,252,177,238,135,113,81,83,202,22,93,33,84,135,93,51,214,237,39,194,187,105,48,205,28,255,130,241,123,33,55,231,168,168,78,144,113,135,126,202,137,100,209,17,195,153,163,21,158,26,108,137,249,41,114,191,57,176,231,78,110,12,62,4,71,228,202,68,141,107,30,51,94,144,76,10,155,121,142,134,102,7,60,73,174,144,69,100,167,72,171,18,141,81,48,146,133,152,45,83,200,49,65,201,170,68,253,127,144,123,214,117,95,118,219,101,246,218,166,72,237,162,8,79,127,8,108,32,11,170,148,105,230,137,66,190,193,59,181,180,224,35,4,154,132,214,165,196,114,17,130,98,148,212,173,184,200,150,99,80,62,217,175,145,116,244,119,218,109,54,187,182,78,243,228,91,116,219,249,107,34,226,123,162,231,191,206,189,111,73,218,115,165,231,234,240,7,216,177,74,219,236,10,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.AddContactWeb.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: ParallelGatewayAddContactCommunicationFlowElement

		/// <exclude/>
		public class ParallelGatewayAddContactCommunicationFlowElement : ProcessParallelGateway
		{

			public ParallelGatewayAddContactCommunicationFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "ParallelGatewayAddContactCommunication";
				IsLogging = false;
				SchemaElementUId = new Guid("5d0b6b6a-1a92-4477-a8f6-7922798ad8b7");
				CreatedInSchemaUId = process.InternalSchemaUId;
				IncomingTokens = new Dictionary<string, bool> { { "AddContactByLead", false }, };
				SerializeToDB = Owner.SerializeToDB;
			}

		}

		#endregion

		#region Class: ParallelGateway1FlowElement

		/// <exclude/>
		public class ParallelGateway1FlowElement : ProcessParallelGateway
		{

			public ParallelGateway1FlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "ParallelGateway1";
				IsLogging = false;
				SchemaElementUId = new Guid("5c0463a9-9ea1-464a-b52e-096674f01418");
				CreatedInSchemaUId = process.InternalSchemaUId;
				IncomingTokens = new Dictionary<string, bool> { { "AddContactWebParallelGateway1Token", false }, { "AddContactAdressParallelGateway1Token", false }, };
				SerializeToDB = Owner.SerializeToDB;
			}

		}

		#endregion

		#region Class: ReadContactsByLeadEmailFlowElement

		/// <exclude/>
		public class ReadContactsByLeadEmailFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadContactsByLeadEmailFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadContactsByLeadEmail";
				IsLogging = true;
				SchemaElementUId = new Guid("e02e7808-8729-4c97-b907-1487f2e17278");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,86,219,138,220,70,16,253,149,65,15,33,1,245,210,247,139,242,184,140,131,33,113,76,226,132,192,178,152,234,238,106,175,136,52,90,143,36,178,203,48,255,158,210,92,236,197,44,97,28,226,128,95,134,81,183,234,114,78,215,57,173,221,219,118,124,209,118,19,110,155,2,221,136,245,252,50,55,21,40,84,70,9,205,156,23,158,105,41,20,139,156,23,166,162,137,30,117,241,17,75,85,111,160,199,166,58,70,175,115,59,85,117,59,97,63,54,55,187,143,73,167,237,140,245,219,114,120,248,53,221,97,15,191,45,5,132,141,168,172,17,204,23,148,76,11,19,152,207,153,51,240,92,101,109,189,202,89,85,167,94,120,200,8,50,51,99,32,51,29,149,101,16,108,98,54,131,214,70,89,107,133,175,234,113,142,199,138,99,179,123,22,82,180,57,1,181,206,114,208,129,32,21,130,36,108,33,132,198,41,167,99,144,138,159,33,125,6,16,206,53,4,33,5,147,162,16,83,32,144,249,176,112,102,18,47,206,88,4,45,78,64,76,40,84,40,71,230,164,7,166,185,10,44,42,138,132,146,61,15,54,23,153,114,85,119,88,166,245,195,253,22,199,177,29,54,205,14,63,252,127,243,120,79,189,29,107,95,15,221,220,111,170,186,199,9,94,195,116,71,141,200,66,248,140,99,5,10,101,95,144,6,101,29,139,198,43,225,192,162,196,84,213,9,238,167,37,109,245,106,238,35,110,171,58,195,4,191,67,55,227,33,251,174,165,62,115,142,138,112,32,227,14,9,72,182,146,69,7,129,101,142,68,245,50,7,49,159,153,250,9,115,59,247,111,240,97,57,252,145,146,226,182,77,39,218,105,107,26,182,205,46,13,155,105,59,116,75,129,87,135,160,229,245,227,188,156,182,254,56,66,155,104,125,9,170,246,245,60,226,117,215,226,102,90,111,210,144,219,205,187,3,255,251,61,69,244,247,176,109,199,51,29,235,247,51,116,85,189,109,223,221,253,35,109,215,243,56,13,253,215,134,183,38,172,148,130,70,238,208,243,50,145,185,29,239,59,120,60,60,55,213,55,239,231,97,250,254,23,132,188,234,232,231,234,69,187,29,167,213,50,189,171,161,172,136,129,185,155,40,219,42,13,93,135,105,57,250,171,117,15,109,119,140,171,62,201,127,206,7,26,108,41,60,49,33,66,97,218,42,26,82,47,37,179,94,107,238,172,199,128,230,202,166,224,117,160,9,243,192,221,66,155,97,128,37,145,152,61,26,16,34,229,148,175,10,162,146,217,11,230,80,106,146,135,210,44,136,228,152,226,94,161,206,58,40,95,78,189,236,235,255,5,219,205,203,241,231,191,54,103,13,31,143,238,246,138,86,63,89,88,119,216,211,121,52,187,75,200,216,83,192,235,115,185,102,119,9,53,75,200,122,51,181,211,227,81,203,205,238,18,174,246,183,103,182,110,73,12,255,169,61,41,17,16,181,114,84,148,122,208,177,32,131,44,3,227,116,19,112,75,155,50,194,191,183,39,33,139,200,78,145,51,169,100,168,17,35,89,136,217,50,133,28,19,57,160,42,81,63,177,167,37,25,169,26,11,110,113,147,240,9,162,236,181,77,145,220,173,8,79,215,129,13,132,72,149,194,48,88,81,40,11,120,167,158,149,121,148,193,112,39,200,241,145,196,173,145,100,238,179,0,130,27,34,25,179,146,165,200,179,204,127,28,134,63,231,251,207,144,248,49,224,57,145,119,135,157,47,101,107,31,134,238,107,131,124,161,179,93,32,104,68,145,188,73,138,165,146,34,203,69,8,154,44,9,140,115,145,45,71,82,77,178,79,68,115,251,12,217,15,237,56,141,23,176,125,126,241,227,88,223,92,34,176,38,21,41,173,54,158,37,145,56,249,1,153,9,20,36,25,8,107,117,145,217,56,78,150,3,36,5,10,3,150,116,160,189,130,142,129,10,153,41,136,78,58,143,194,10,247,68,34,215,196,57,164,137,236,175,239,231,77,155,96,89,94,13,135,221,213,183,241,113,241,69,18,225,234,244,222,119,207,78,8,125,244,8,111,200,169,64,40,242,39,37,57,243,214,211,71,68,182,37,208,23,90,8,31,239,190,31,230,54,127,233,91,239,144,115,191,156,210,223,79,53,226,96,153,10,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,176,50,208,241,76,1,81,0,240,89,28,178,20,0,0,0 })));
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

		#region Class: ChangeLeadContactEmailFlowElement

		/// <exclude/>
		public class ChangeLeadContactEmailFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadContactEmailFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadContactEmail";
				IsLogging = true;
				SchemaElementUId = new Guid("f4434864-a2bf-4f22-bf0c-27c7e0c1e19c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)(((process.ReadContactsByLeadEmail.ResultEntity.IsColumnValueLoaded(process.ReadContactsByLeadEmail.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadContactsByLeadEmail.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,139,14,61,89,197,178,100,75,114,143,203,182,44,148,52,208,180,20,146,37,140,164,81,86,224,143,141,45,211,4,179,255,189,242,58,155,66,14,165,244,86,208,97,52,210,188,122,230,101,52,223,135,241,99,104,34,14,181,135,102,196,108,218,185,154,104,230,64,42,103,40,176,74,82,193,152,166,70,231,37,245,66,90,41,56,55,165,246,36,235,160,197,154,172,213,91,23,34,201,66,196,118,172,111,231,223,162,113,152,48,187,247,231,205,87,123,192,22,190,45,15,8,6,94,105,212,84,150,185,161,2,141,161,202,130,165,222,115,109,42,161,4,67,75,86,22,233,153,1,43,19,139,230,152,174,74,75,21,216,130,122,135,186,0,7,92,139,196,210,160,143,219,167,227,128,227,24,250,174,158,241,53,190,121,62,38,202,245,237,77,223,76,109,71,178,22,35,92,67,60,212,4,48,71,81,90,160,86,232,146,10,143,146,38,69,71,57,24,89,72,133,172,98,146,100,22,142,113,145,37,59,71,50,7,17,190,67,51,225,89,121,14,137,177,224,57,83,101,178,10,24,183,84,240,34,167,170,82,50,49,86,94,35,175,180,54,238,226,215,167,41,164,56,140,87,83,139,67,176,47,182,99,242,175,31,234,217,246,93,28,250,102,145,190,58,95,191,193,167,184,154,251,114,244,99,109,40,166,252,82,68,78,217,52,226,166,9,216,197,109,103,123,23,186,135,85,243,116,74,37,237,17,134,48,94,92,216,62,78,208,144,108,8,15,135,63,186,181,153,198,216,183,255,81,171,89,106,51,105,164,33,59,227,46,51,232,194,120,108,224,249,188,175,201,187,199,169,143,31,62,35,184,157,91,99,242,166,166,38,119,132,241,60,55,101,26,179,66,87,169,57,85,42,170,120,165,168,208,28,156,45,74,144,194,222,145,196,241,79,234,183,187,241,203,207,238,242,15,86,242,253,251,148,125,147,184,190,84,214,243,223,0,157,246,11,210,254,148,214,47,188,22,204,149,206,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,93,111,219,32,20,253,43,17,237,99,136,192,198,6,252,218,118,82,164,118,171,250,245,210,228,225,2,151,214,146,99,87,54,217,148,69,249,239,195,36,89,155,110,123,25,15,54,112,57,231,220,207,45,57,15,155,55,36,21,121,192,190,135,161,243,97,118,209,245,56,187,237,59,139,195,48,187,238,44,52,245,79,48,13,222,66,15,43,12,216,63,65,179,198,225,186,30,194,116,114,10,35,83,114,254,61,89,73,245,188,37,243,128,171,199,185,139,236,144,123,39,148,207,40,47,172,167,130,59,67,33,131,50,238,44,3,43,10,134,37,68,176,237,154,245,170,189,193,0,183,16,94,73,181,37,137,109,36,112,66,51,87,40,202,10,1,84,56,85,80,157,137,146,58,167,68,89,162,201,181,202,201,110,74,6,251,138,43,72,162,239,96,193,193,43,141,154,202,130,25,42,208,24,170,44,88,234,125,174,77,41,148,224,104,71,240,225,253,59,240,249,236,121,62,124,251,209,98,127,159,120,43,15,205,128,203,89,188,253,116,113,213,224,10,219,80,109,145,101,40,21,83,84,201,76,83,97,181,164,70,51,73,185,80,210,103,200,101,38,213,46,2,126,103,179,218,10,228,200,164,206,41,20,104,169,200,64,80,35,77,140,205,250,232,43,47,37,67,28,33,87,109,168,195,230,34,229,168,218,2,50,20,133,5,106,133,46,168,240,40,41,228,218,209,28,204,168,129,188,228,114,183,60,91,142,129,185,122,120,107,96,243,244,103,124,119,8,110,98,187,214,215,253,10,211,46,128,13,195,196,108,38,205,104,138,49,214,205,236,75,221,15,97,82,199,114,78,58,63,233,113,88,55,161,110,95,226,243,166,65,27,234,174,157,205,221,94,234,237,164,75,62,138,109,23,251,102,91,144,106,241,175,118,59,252,247,201,61,109,184,207,189,182,32,211,5,185,239,214,189,29,25,243,241,112,172,125,82,96,135,69,255,242,57,174,61,71,130,221,64,11,47,216,127,141,138,9,158,76,151,16,32,137,63,68,191,143,196,38,211,5,147,220,83,137,16,43,140,101,70,149,227,64,53,215,198,231,50,207,188,207,18,250,14,61,246,216,90,60,117,140,151,6,243,178,224,84,121,204,226,4,20,58,226,29,163,160,88,238,68,169,114,231,242,132,79,202,239,206,28,199,34,222,180,235,166,73,2,67,138,127,156,179,131,227,7,203,229,135,130,127,96,232,92,237,107,116,243,246,127,82,181,35,187,221,114,247,11,224,138,247,140,50,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeLeadContactEmail.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: ReadContactsByLeadPhoneFlowElement

		/// <exclude/>
		public class ReadContactsByLeadPhoneFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadContactsByLeadPhoneFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadContactsByLeadPhone";
				IsLogging = true;
				SchemaElementUId = new Guid("13eb0743-2f51-4864-9f5e-dd240ab8deb2");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,107,107,27,71,20,253,43,98,63,148,22,52,102,222,15,245,91,141,82,2,141,29,218,180,20,140,9,119,103,238,216,75,247,161,104,119,169,141,208,127,239,93,201,138,157,212,4,185,56,161,129,124,17,171,157,153,123,239,57,115,207,217,153,205,219,170,127,81,213,3,174,23,25,234,30,231,227,203,180,40,114,212,54,217,192,153,11,66,49,45,162,103,33,107,203,124,20,38,241,20,108,8,174,152,183,208,224,162,216,175,94,166,106,40,230,213,128,77,191,184,216,220,7,29,214,35,206,223,230,221,159,223,226,53,54,240,251,148,64,216,18,149,53,130,249,140,146,18,152,192,124,74,156,129,231,42,105,235,85,74,170,216,215,226,53,112,235,172,103,38,154,146,166,58,100,128,217,176,24,124,169,50,7,90,150,139,121,63,150,251,140,253,98,243,40,164,164,104,158,51,138,113,43,41,163,23,146,149,220,151,204,107,101,114,64,33,178,206,7,72,143,1,121,16,74,41,11,232,74,195,188,228,153,105,41,57,243,37,143,12,184,80,218,40,163,121,180,247,161,234,238,170,138,80,159,175,112,13,67,213,181,139,226,124,253,4,166,56,215,16,132,20,76,138,236,153,6,129,204,7,65,79,38,78,120,44,130,22,119,76,201,82,72,140,57,50,225,128,51,157,21,145,26,52,129,37,104,62,39,212,14,136,212,26,243,176,188,89,173,177,239,167,106,54,248,254,249,205,237,138,42,222,231,62,237,234,177,105,139,121,131,3,188,134,225,154,10,145,57,2,26,199,50,100,96,26,117,102,65,89,199,74,227,21,37,180,72,185,139,121,132,213,30,228,217,216,148,72,64,19,12,240,7,212,35,238,162,111,170,105,43,82,169,8,7,50,238,144,128,36,75,91,225,32,176,196,209,10,98,146,231,50,29,248,123,133,169,26,155,55,120,51,117,87,79,65,113,93,197,187,205,160,161,161,91,47,54,177,107,135,117,87,79,9,206,118,139,166,233,251,134,188,27,250,115,15,109,160,247,211,162,98,59,31,123,60,173,43,108,135,101,27,187,84,181,87,59,254,183,91,90,209,172,96,93,245,7,58,150,239,70,168,139,249,186,186,186,254,36,109,167,99,63,116,205,215,134,119,78,88,41,4,181,220,174,230,169,35,83,213,175,106,184,221,253,95,20,223,189,27,187,225,199,95,17,210,172,166,159,147,23,213,186,31,102,83,247,206,186,60,35,6,198,122,160,104,179,216,213,53,198,105,235,79,126,26,251,170,37,106,102,171,235,174,197,125,128,226,163,68,135,192,160,193,230,76,218,17,34,144,148,172,18,100,1,164,79,235,181,230,36,122,12,104,78,44,73,93,7,106,53,15,220,77,252,153,201,1,34,121,129,71,3,66,196,20,211,73,208,160,192,79,250,246,145,108,194,155,76,205,159,53,19,94,122,231,193,0,96,121,87,203,118,254,101,65,94,188,236,207,255,110,15,170,222,111,230,229,9,189,253,232,197,178,198,134,118,104,177,57,134,149,45,45,120,125,72,183,216,28,195,209,180,100,217,14,213,112,187,87,247,98,115,12,105,219,203,3,109,151,36,143,103,53,172,50,197,144,50,229,203,92,77,134,21,128,121,167,44,131,24,169,234,28,4,230,244,205,176,190,25,214,103,54,172,87,93,89,213,248,101,237,74,243,140,89,164,192,114,160,31,45,233,112,5,129,78,19,202,7,148,198,2,196,164,159,209,174,142,135,248,255,53,171,99,40,251,192,172,46,159,217,174,156,148,46,88,97,152,75,64,167,226,114,58,95,121,64,70,101,105,114,154,16,168,128,255,110,87,66,18,56,167,200,169,84,52,84,136,145,44,148,201,50,133,28,35,228,164,114,169,31,216,213,20,140,84,142,25,215,216,70,124,128,40,121,109,99,73,110,151,133,79,180,33,129,16,169,156,25,82,237,153,162,0,121,236,163,178,47,101,48,220,137,204,28,146,216,53,146,236,125,18,192,130,8,101,86,78,201,156,229,65,246,191,116,221,95,227,234,9,146,223,47,120,76,244,245,110,228,169,54,119,214,13,199,58,221,251,206,251,218,80,31,105,118,203,6,170,250,211,170,70,164,59,156,137,138,209,245,160,100,41,11,65,205,37,129,113,46,146,229,24,148,143,246,67,229,252,235,179,114,83,245,67,127,4,219,135,137,247,157,125,113,140,198,22,49,75,105,181,241,44,138,72,135,129,52,93,168,50,146,18,132,181,58,203,100,28,39,223,1,82,3,45,3,22,117,160,177,140,142,129,10,137,41,40,157,116,30,133,21,238,129,74,78,137,115,136,3,89,97,211,140,45,221,195,166,215,179,110,55,58,251,190,188,157,60,146,116,56,187,155,247,195,163,29,34,21,23,222,144,93,129,80,100,82,106,186,239,89,79,231,138,100,233,230,168,232,50,124,255,57,252,121,172,210,231,254,16,238,98,110,167,93,250,7,30,160,157,116,190,15,0,0 })));
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

			private bool _readSomeTopRecords = true;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,115,46,74,77,44,73,77,241,207,179,50,180,50,212,241,76,177,50,176,50,0,0,80,50,116,145,20,0,0,0 })));
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

		#region Class: ChangeLeadContactPhoneFlowElement

		/// <exclude/>
		public class ChangeLeadContactPhoneFlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeLeadContactPhoneFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeLeadContactPhone";
				IsLogging = true;
				SchemaElementUId = new Guid("1fe66c39-e645-4115-bb1f-6f62f33d667f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)(((process.ReadContactsByLeadPhone.ResultEntity.IsColumnValueLoaded(process.ReadContactsByLeadPhone.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadContactsByLeadPhone.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,47,58,244,100,21,203,250,176,228,30,151,109,89,40,105,160,105,41,36,75,24,73,227,172,192,31,27,91,166,9,102,255,123,229,117,54,133,28,74,233,173,224,195,204,72,239,233,189,199,120,190,15,227,199,208,68,28,170,26,154,17,179,105,231,43,194,157,181,57,151,146,66,89,148,84,120,87,82,43,185,162,82,74,200,153,242,136,222,147,172,131,22,43,178,162,183,62,68,146,133,136,237,88,221,206,191,73,227,48,97,118,95,159,155,175,238,128,45,124,91,30,16,12,106,109,208,208,82,230,150,10,180,150,106,7,142,214,53,55,86,9,45,24,58,178,106,113,74,178,156,21,64,53,243,140,10,235,11,154,128,169,45,75,238,133,87,198,66,186,218,96,29,183,79,199,1,199,49,244,93,53,227,107,125,243,124,76,42,215,183,55,125,51,181,29,201,90,140,112,13,241,80,17,192,28,133,116,64,157,48,146,138,26,75,10,220,120,202,193,38,235,26,153,98,37,201,28,28,227,66,75,118,201,182,135,8,223,161,153,240,204,60,135,164,177,224,57,211,82,37,44,227,142,10,94,228,84,43,93,210,218,171,218,32,87,198,216,215,188,62,77,33,213,97,188,154,90,28,130,123,137,29,83,126,253,80,205,174,239,226,208,55,11,245,213,249,250,13,62,197,53,220,151,163,31,171,161,152,230,11,136,156,178,105,196,77,19,176,139,219,206,245,62,116,15,43,231,233,148,32,237,17,134,48,94,82,216,62,78,208,144,108,8,15,135,63,166,181,153,198,216,183,255,145,213,44,217,76,28,105,201,206,114,151,29,244,97,60,54,240,124,238,43,242,238,113,234,227,135,207,8,126,231,215,154,188,193,84,228,142,48,158,231,105,209,145,22,70,37,115,90,106,170,185,210,84,24,14,222,21,18,74,225,238,72,210,241,79,236,183,187,241,203,207,238,242,31,172,202,247,239,211,244,205,224,250,130,172,230,191,17,116,218,47,146,246,167,244,253,2,190,113,24,67,206,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,203,110,219,48,16,252,21,129,201,209,52,36,145,146,72,93,147,20,48,144,180,65,210,230,18,251,176,36,151,137,0,61,12,137,110,225,10,250,247,82,180,221,196,105,123,41,15,122,236,114,102,118,151,195,145,92,186,253,22,73,73,190,98,223,195,208,89,183,188,234,122,92,222,247,157,198,97,88,222,118,26,234,234,39,168,26,239,161,135,6,29,246,79,80,239,112,184,173,6,183,136,206,97,100,65,46,191,135,44,41,159,71,178,114,216,124,91,25,207,46,81,198,185,98,138,50,105,20,229,8,49,21,214,10,90,72,38,82,148,144,51,150,120,176,238,234,93,211,222,161,131,123,112,175,164,28,73,96,243,4,96,184,140,77,38,104,156,113,160,220,136,140,202,148,231,212,24,193,243,28,21,147,130,145,105,65,6,253,138,13,4,209,55,48,79,192,10,95,2,45,178,120,86,87,138,10,13,154,90,203,164,202,185,224,9,234,25,124,220,255,6,124,190,120,94,13,95,126,180,216,63,6,222,210,66,61,224,102,233,163,31,2,55,53,54,216,186,114,76,24,170,184,224,140,166,54,75,40,23,57,167,210,102,232,11,77,121,12,74,24,84,233,228,1,191,167,89,142,178,16,34,153,55,218,52,49,148,91,46,169,239,199,210,60,79,117,33,98,180,70,203,25,114,211,186,202,237,175,194,140,202,17,48,70,158,105,160,154,203,204,163,176,160,224,167,75,25,168,34,45,4,38,121,82,76,155,139,205,220,152,169,134,109,13,251,167,63,251,123,64,48,145,238,90,91,245,13,134,47,7,218,13,145,218,71,245,156,218,190,118,45,70,237,174,81,216,15,203,79,85,63,184,168,242,199,26,117,54,234,113,216,213,174,106,95,60,172,174,81,187,170,107,151,43,115,144,220,158,185,229,189,232,184,62,152,110,77,202,245,191,108,119,124,31,134,124,110,188,143,158,91,147,197,154,60,118,187,94,207,140,108,254,57,121,32,40,196,199,69,255,242,56,173,3,71,128,221,65,11,47,216,127,246,138,1,30,82,215,224,32,136,127,245,117,159,136,85,42,179,184,72,44,45,16,164,119,85,158,82,97,18,160,50,145,202,178,130,165,214,166,1,253,128,22,123,108,53,158,23,150,228,10,89,238,77,34,44,166,148,39,153,244,120,19,83,16,49,51,60,23,204,24,22,240,65,249,173,152,211,245,240,145,118,87,215,65,96,8,253,207,247,237,88,248,49,115,253,238,224,223,49,116,166,178,21,154,85,251,63,163,154,200,52,109,166,95,121,0,34,107,58,4,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeLeadContactPhone.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("01cee34b-f51b-441d-9110-09e5174d899d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_QualifiedContact = () => (Guid)((process.AddContactByLead.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_QualifiedContact", () => _recordColumnValues_QualifiedContact.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_QualifiedContact;

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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,47,58,244,100,21,91,95,150,220,227,178,45,11,37,13,52,45,133,100,9,207,210,83,86,224,143,141,45,211,4,179,255,189,242,58,155,66,14,165,244,86,208,225,233,73,51,111,102,144,230,251,48,126,12,77,196,161,242,208,140,152,77,59,87,17,39,106,151,151,140,83,233,165,163,2,65,82,96,134,83,230,56,122,167,141,20,194,145,172,131,22,43,178,162,183,46,68,146,133,136,237,88,221,206,191,73,227,48,97,118,239,207,155,175,246,128,45,124,91,6,136,2,188,54,104,104,41,243,58,13,168,107,170,45,88,234,61,55,181,18,90,20,104,201,170,197,151,80,115,199,146,2,165,88,186,170,74,10,22,129,22,42,103,82,176,82,112,168,73,214,160,143,219,167,227,128,227,24,250,174,154,241,181,190,121,62,38,149,235,236,77,223,76,109,71,178,22,35,92,67,60,84,4,48,71,33,45,80,43,140,164,194,99,98,231,198,209,68,90,178,82,99,161,138,146,100,22,142,113,161,37,187,100,219,65,132,239,208,76,120,102,158,67,210,200,120,94,104,185,40,43,184,165,130,179,156,106,165,75,234,157,242,6,185,50,166,126,205,235,211,20,82,29,198,171,169,197,33,216,151,216,49,229,215,15,213,108,251,46,14,125,179,80,95,157,175,223,224,83,92,195,125,57,250,177,26,138,169,191,128,200,41,155,70,220,52,1,187,184,237,108,239,66,247,176,114,158,78,9,210,30,97,8,227,37,133,237,227,4,13,201,134,240,112,248,99,90,155,105,140,125,251,31,89,205,146,205,196,145,30,217,89,238,242,6,93,24,143,13,60,159,247,21,121,247,56,245,241,195,103,4,183,115,107,77,222,96,42,114,71,10,158,231,181,228,72,153,81,201,156,150,154,106,174,52,21,134,131,179,76,66,41,236,29,73,58,254,137,253,118,55,126,249,217,93,254,193,170,124,255,62,117,223,52,174,47,200,106,254,27,65,167,253,34,105,127,74,235,23,164,167,252,123,206,3,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,59,111,219,48,16,254,43,2,147,209,52,40,138,146,72,109,69,210,193,64,210,6,77,154,37,246,112,36,143,141,0,61,12,74,110,145,26,250,239,165,105,187,182,211,118,41,7,73,188,211,247,16,239,211,150,92,143,111,107,36,21,121,66,239,97,232,221,56,191,233,61,206,31,124,111,112,24,230,119,189,129,166,254,9,186,193,7,240,208,226,136,254,25,154,13,14,119,245,48,206,146,75,24,153,145,235,239,177,75,170,151,45,89,140,216,126,93,216,192,206,37,7,163,48,165,172,224,156,138,82,103,84,90,174,169,41,101,153,27,208,138,153,60,128,77,223,108,218,238,30,71,120,128,241,149,84,91,18,217,2,1,88,161,152,205,37,101,185,0,42,172,204,169,226,162,160,214,74,81,20,168,51,37,51,50,205,200,96,94,177,133,40,122,2,139,20,156,84,168,104,153,51,77,5,106,77,165,1,67,157,203,148,46,132,20,41,154,29,248,240,254,9,248,114,245,178,24,62,255,232,208,63,70,222,202,65,51,224,106,30,170,239,10,31,27,108,177,27,171,237,78,138,113,171,168,114,60,163,130,179,130,106,101,144,2,50,205,88,206,44,40,156,2,224,247,105,86,219,178,4,201,92,94,80,161,11,70,133,212,134,106,228,37,69,85,56,103,133,49,185,210,211,234,106,181,179,104,235,97,221,192,219,243,159,78,63,88,155,108,58,211,119,174,246,45,218,36,60,141,96,198,68,195,16,118,125,151,52,8,54,169,59,215,251,22,198,186,239,230,55,30,97,12,61,143,166,247,54,89,216,189,196,250,98,206,231,34,219,229,62,46,75,82,45,255,21,152,195,125,127,60,151,145,121,159,150,37,153,45,201,99,191,241,102,199,152,237,54,199,233,69,5,118,88,244,47,151,227,218,115,68,216,61,116,240,13,253,167,160,24,225,177,117,11,35,68,241,167,224,251,72,172,185,202,89,153,58,90,34,168,144,135,130,135,52,166,64,85,170,180,203,202,140,59,199,35,250,11,58,244,216,25,188,52,150,22,26,179,34,79,169,116,24,210,156,230,42,224,45,163,97,140,153,21,133,204,172,205,34,62,42,159,204,28,131,29,42,221,166,105,162,192,16,191,127,247,167,28,140,31,58,183,103,131,62,99,232,109,237,106,180,139,238,127,142,106,34,211,180,154,126,1,110,132,59,154,244,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "50c67976474a4cfbb0665ca727be0505",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("68ee82f8-280b-40ce-951d-6e93d2945a8f");
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

		#region Class: ReadLandingPageFlowElement

		/// <exclude/>
		public class ReadLandingPageFlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadLandingPageFlowElement(UserConnection userConnection, LeadManagementIdentification process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLandingPage";
				IsLogging = true;
				SchemaElementUId = new Guid("17eaa635-03e6-4644-8e7d-7a81a8f837a6");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,77,107,220,48,16,134,255,202,162,67,79,214,34,89,182,44,187,199,176,41,129,146,134,126,81,72,66,24,75,163,68,224,143,141,45,211,4,179,255,189,227,117,182,133,28,74,78,133,130,49,150,228,247,157,153,71,51,243,93,24,207,67,19,113,168,60,52,35,38,211,133,171,152,75,13,104,229,115,142,90,8,158,25,43,56,216,210,115,35,50,52,62,151,22,117,206,146,14,90,172,216,170,222,185,16,89,18,34,182,99,117,61,255,49,141,195,132,201,157,63,46,190,216,7,108,225,219,18,32,147,128,133,51,142,215,104,21,207,164,243,28,180,23,60,133,90,56,97,106,85,234,130,173,185,128,183,121,109,13,242,212,229,142,103,174,72,57,212,69,201,115,91,35,162,16,190,150,200,146,6,125,220,61,237,7,28,199,208,119,213,140,191,191,191,62,239,41,203,53,246,89,223,76,109,199,146,22,35,92,65,124,32,119,20,152,229,22,184,205,202,156,103,30,11,14,170,116,92,81,140,180,48,40,181,164,68,44,236,227,98,203,46,28,75,28,68,248,14,205,132,71,231,57,80,142,169,18,210,228,154,180,82,89,158,169,84,112,163,77,193,189,211,190,68,165,203,178,118,39,94,31,166,64,223,97,188,156,90,28,130,125,193,142,196,175,31,170,217,246,93,28,250,102,177,190,60,254,254,21,159,226,10,247,229,232,199,90,80,164,253,69,196,14,201,52,226,89,19,176,139,187,206,246,46,116,247,171,231,225,64,146,118,15,67,24,79,20,118,143,19,52,44,25,194,253,195,95,105,157,77,99,236,219,255,168,212,132,202,36,15,106,178,99,186,75,15,186,48,238,27,120,62,174,43,246,238,113,234,227,251,207,8,110,211,208,107,123,30,134,49,110,150,126,221,244,126,67,197,79,77,36,187,141,237,155,6,237,114,217,219,143,208,45,17,54,123,184,199,85,206,94,133,169,216,13,131,140,26,215,11,203,165,164,1,201,180,146,28,76,154,114,109,178,76,20,218,96,137,249,86,219,210,100,212,210,220,128,40,168,135,117,206,1,61,225,147,6,115,144,210,58,235,182,165,50,37,13,94,201,181,50,154,134,142,206,137,101,206,83,155,155,34,85,42,213,58,189,97,4,225,95,149,118,125,49,126,250,217,157,230,118,37,125,187,165,221,87,27,187,6,91,186,146,106,126,11,139,3,9,174,78,161,170,249,45,100,22,201,174,139,33,62,175,243,91,205,111,65,117,184,93,96,221,30,232,249,5,240,94,150,228,229,4,0,0 })));
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
								new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"));
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

		public LeadManagementIdentification(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagementIdentification";
			SchemaUId = new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_identificationPassed = () => { return (bool)(true); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("50c67976-474a-4cfb-b066-5ca727be0505");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LeadManagementIdentification, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LeadManagementIdentification, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual Guid LeadId {
			get;
			set;
		}

		private Func<bool> _identificationPassed;
		public virtual bool IdentificationPassed {
			get {
				return (_identificationPassed ?? (_identificationPassed = () => false)).Invoke();
			}
			set {
				_identificationPassed = () => { return value; };
			}
		}

		private ProcessLeadIdentification _leadIdentification;
		public ProcessLeadIdentification LeadIdentification {
			get {
				return _leadIdentification ?? ((_leadIdentification) = new ProcessLeadIdentification(UserConnection, this));
			}
		}

		private ProcessFlowElement _start;
		public ProcessFlowElement Start {
			get {
				return _start ?? (_start = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start",
					SchemaElementUId = new Guid("e4f191bb-2078-469f-a22b-36763fc3b878"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _leadIsIdentified;
		public ProcessTerminateEvent LeadIsIdentified {
			get {
				return _leadIsIdentified ?? (_leadIsIdentified = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "LeadIsIdentified",
					SchemaElementUId = new Guid("c634d34a-9984-4a62-a5cf-c01049fca1c0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadLeadDataFlowElement _readLeadData;
		public ReadLeadDataFlowElement ReadLeadData {
			get {
				return _readLeadData ?? (_readLeadData = new ReadLeadDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveLeadHasCommunication;
		public ProcessExclusiveGateway ExclusiveLeadHasCommunication {
			get {
				return _exclusiveLeadHasCommunication ?? (_exclusiveLeadHasCommunication = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveLeadHasCommunication",
					SchemaElementUId = new Guid("63c2f821-e43f-4368-83f1-e2bda2505f5b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveLeadHasCommunication.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _leadDisqualified;
		public ProcessTerminateEvent LeadDisqualified {
			get {
				return _leadDisqualified ?? (_leadDisqualified = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "LeadDisqualified",
					SchemaElementUId = new Guid("f4df356b-d95c-43bc-a856-f9efad105482"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadContactsByLeadCommunicationsFlowElement _readContactsByLeadCommunications;
		public ReadContactsByLeadCommunicationsFlowElement ReadContactsByLeadCommunications {
			get {
				return _readContactsByLeadCommunications ?? (_readContactsByLeadCommunications = new ReadContactsByLeadCommunicationsFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadContactAllFlowElement _changeLeadContactAll;
		public ChangeLeadContactAllFlowElement ChangeLeadContactAll {
			get {
				return _changeLeadContactAll ?? (_changeLeadContactAll = new ChangeLeadContactAllFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddContactByLeadFlowElement _addContactByLead;
		public AddContactByLeadFlowElement AddContactByLead {
			get {
				return _addContactByLead ?? (_addContactByLead = new AddContactByLeadFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddContactAdressFlowElement _addContactAdress;
		public AddContactAdressFlowElement AddContactAdress {
			get {
				return _addContactAdress ?? (_addContactAdress = new AddContactAdressFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddContactWebFlowElement _addContactWeb;
		public AddContactWebFlowElement AddContactWeb {
			get {
				return _addContactWeb ?? (_addContactWeb = new AddContactWebFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ParallelGatewayAddContactCommunicationFlowElement _parallelGatewayAddContactCommunication;
		public ParallelGatewayAddContactCommunicationFlowElement ParallelGatewayAddContactCommunication {
			get {
				return _parallelGatewayAddContactCommunication ?? ((_parallelGatewayAddContactCommunication) = new ParallelGatewayAddContactCommunicationFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ParallelGateway1FlowElement _parallelGateway1;
		public ParallelGateway1FlowElement ParallelGateway1 {
			get {
				return _parallelGateway1 ?? ((_parallelGateway1) = new ParallelGateway1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadContactsByLeadEmailFlowElement _readContactsByLeadEmail;
		public ReadContactsByLeadEmailFlowElement ReadContactsByLeadEmail {
			get {
				return _readContactsByLeadEmail ?? (_readContactsByLeadEmail = new ReadContactsByLeadEmailFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadContactEmailFlowElement _changeLeadContactEmail;
		public ChangeLeadContactEmailFlowElement ChangeLeadContactEmail {
			get {
				return _changeLeadContactEmail ?? (_changeLeadContactEmail = new ChangeLeadContactEmailFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveInLeadCommunication;
		public ProcessExclusiveGateway ExclusiveInLeadCommunication {
			get {
				return _exclusiveInLeadCommunication ?? (_exclusiveInLeadCommunication = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveInLeadCommunication",
					SchemaElementUId = new Guid("a4c733cc-151e-47ad-8dde-04d288bd539f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveInLeadCommunication.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadContactsByLeadPhoneFlowElement _readContactsByLeadPhone;
		public ReadContactsByLeadPhoneFlowElement ReadContactsByLeadPhone {
			get {
				return _readContactsByLeadPhone ?? (_readContactsByLeadPhone = new ReadContactsByLeadPhoneFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeLeadContactPhoneFlowElement _changeLeadContactPhone;
		public ChangeLeadContactPhoneFlowElement ChangeLeadContactPhone {
			get {
				return _changeLeadContactPhone ?? (_changeLeadContactPhone = new ChangeLeadContactPhoneFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayIsLeadSet;
		public ProcessExclusiveGateway ExclusiveGatewayIsLeadSet {
			get {
				return _exclusiveGatewayIsLeadSet ?? (_exclusiveGatewayIsLeadSet = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayIsLeadSet",
					SchemaElementUId = new Guid("b9aa1247-b371-4815-926c-3b34166d62ce"),
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

		private ProcessScriptTask _actionAfterIdentificationScriptTask;
		public ProcessScriptTask ActionAfterIdentificationScriptTask {
			get {
				return _actionAfterIdentificationScriptTask ?? (_actionAfterIdentificationScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActionAfterIdentificationScriptTask",
					SchemaElementUId = new Guid("823adfbf-968a-44dc-be40-33f3ac4421f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = ActionAfterIdentificationScriptTaskExecute,
				});
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
					SchemaElementUId = new Guid("f5bceb61-c764-4125-8416-472d42e1cb8c"),
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

		private ReadLandingPageFlowElement _readLandingPage;
		public ReadLandingPageFlowElement ReadLandingPage {
			get {
				return _readLandingPage ?? (_readLandingPage = new ReadLandingPageFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("4003d719-b518-4975-b6e0-f769d615e6b4"),
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

		private ProcessConditionalFlow _contactFoundAll;
		public ProcessConditionalFlow ContactFoundAll {
			get {
				return _contactFoundAll ?? (_contactFoundAll = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ContactFoundAll",
					SchemaElementUId = new Guid("e86cf8b0-28a2-4a9b-b145-adf2cced025e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowCommunicationAll;
		public ProcessConditionalFlow ConditionalFlowCommunicationAll {
			get {
				return _conditionalFlowCommunicationAll ?? (_conditionalFlowCommunicationAll = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowCommunicationAll",
					SchemaElementUId = new Guid("146a48af-ec3c-47df-b53d-49db5dfca733"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowEmailOnly;
		public ProcessConditionalFlow ConditionalFlowEmailOnly {
			get {
				return _conditionalFlowEmailOnly ?? (_conditionalFlowEmailOnly = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowEmailOnly",
					SchemaElementUId = new Guid("94e08796-33d0-450f-a94d-43d4d8c7e5b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _contactFoundEmail;
		public ProcessConditionalFlow ContactFoundEmail {
			get {
				return _contactFoundEmail ?? (_contactFoundEmail = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ContactFoundEmail",
					SchemaElementUId = new Guid("8ad3bb27-05b3-4197-85fe-9fca6ddb677c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowPhonesOnly;
		public ProcessConditionalFlow ConditionalFlowPhonesOnly {
			get {
				return _conditionalFlowPhonesOnly ?? (_conditionalFlowPhonesOnly = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowPhonesOnly",
					SchemaElementUId = new Guid("421b74c1-62c2-430b-965d-8d776c88a27f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _cntactFoundPhone;
		public ProcessConditionalFlow CntactFoundPhone {
			get {
				return _cntactFoundPhone ?? (_cntactFoundPhone = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "CntactFoundPhone",
					SchemaElementUId = new Guid("9bfd01fc-78f4-4b49-a5a3-0359fc93fab2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowLeadUndefined;
		public ProcessConditionalFlow ConditionalFlowLeadUndefined {
			get {
				return _conditionalFlowLeadUndefined ?? (_conditionalFlowLeadUndefined = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowLeadUndefined",
					SchemaElementUId = new Guid("86bf0460-da87-44e8-9e19-16d6bb74396c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _isNotFromLandingFlow;
		public ProcessConditionalFlow IsNotFromLandingFlow {
			get {
				return _isNotFromLandingFlow ?? (_isNotFromLandingFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "IsNotFromLandingFlow",
					SchemaElementUId = new Guid("b15dccc1-cb8b-4db6-9245-c999d8b93476"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _dontContactFlow;
		public ProcessConditionalFlow DontContactFlow {
			get {
				return _dontContactFlow ?? (_dontContactFlow = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "DontContactFlow",
					SchemaElementUId = new Guid("6e54dca1-2410-4933-8d29-b9c06c6eb9c5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _addContactWebParallelGateway1Token;
		public ProcessToken AddContactWebParallelGateway1Token {
			get {
				return _addContactWebParallelGateway1Token ?? (_addContactWebParallelGateway1Token = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "AddContactWebParallelGateway1Token",
					SchemaElementUId = new Guid("b7866d3f-3d34-43a0-a36f-f19f423c3731"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _addContactAdressParallelGateway1Token;
		public ProcessToken AddContactAdressParallelGateway1Token {
			get {
				return _addContactAdressParallelGateway1Token ?? (_addContactAdressParallelGateway1Token = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "AddContactAdressParallelGateway1Token",
					SchemaElementUId = new Guid("ebf62eec-5785-4a05-b1b1-82765048f598"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start.SchemaElementUId] = new Collection<ProcessFlowElement> { Start };
			FlowElements[LeadIsIdentified.SchemaElementUId] = new Collection<ProcessFlowElement> { LeadIsIdentified };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[ExclusiveLeadHasCommunication.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveLeadHasCommunication };
			FlowElements[LeadDisqualified.SchemaElementUId] = new Collection<ProcessFlowElement> { LeadDisqualified };
			FlowElements[ReadContactsByLeadCommunications.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadContactsByLeadCommunications };
			FlowElements[ChangeLeadContactAll.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadContactAll };
			FlowElements[AddContactByLead.SchemaElementUId] = new Collection<ProcessFlowElement> { AddContactByLead };
			FlowElements[AddContactAdress.SchemaElementUId] = new Collection<ProcessFlowElement> { AddContactAdress };
			FlowElements[AddContactWeb.SchemaElementUId] = new Collection<ProcessFlowElement> { AddContactWeb };
			FlowElements[ParallelGatewayAddContactCommunication.SchemaElementUId] = new Collection<ProcessFlowElement> { ParallelGatewayAddContactCommunication };
			FlowElements[ParallelGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ParallelGateway1 };
			FlowElements[ReadContactsByLeadEmail.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadContactsByLeadEmail };
			FlowElements[ChangeLeadContactEmail.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadContactEmail };
			FlowElements[ExclusiveInLeadCommunication.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveInLeadCommunication };
			FlowElements[ReadContactsByLeadPhone.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadContactsByLeadPhone };
			FlowElements[ChangeLeadContactPhone.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeLeadContactPhone };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[ExclusiveGatewayIsLeadSet.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayIsLeadSet };
			FlowElements[ActionAfterIdentificationScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActionAfterIdentificationScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ReadLandingPage.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLandingPage };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[AddContactWebParallelGateway1Token.SchemaElementUId] = new Collection<ProcessFlowElement> { AddContactWebParallelGateway1Token };
			FlowElements[AddContactAdressParallelGateway1Token.SchemaElementUId] = new Collection<ProcessFlowElement> { AddContactAdressParallelGateway1Token };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayIsLeadSet", e.Context.SenderName));
						break;
					case "LeadIsIdentified":
						CompleteProcess();
						break;
					case "ReadLeadData":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveLeadHasCommunication":
						if (ConditionalFlowCommunicationAllExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadCommunications", e.Context.SenderName));
							break;
						}
						if (ConditionalFlowEmailOnlyExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadEmail", e.Context.SenderName));
							break;
						}
						if (ConditionalFlowPhonesOnlyExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadPhone", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
						break;
					case "LeadDisqualified":
						CompleteProcess();
						break;
					case "ReadContactsByLeadCommunications":
						if (ContactFoundAllExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadContactAll", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadContactsByLeadEmail", e.Context.SenderName));
						break;
					case "ChangeLeadContactAll":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "AddContactByLead":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGatewayAddContactCommunication", e.Context.SenderName));
						break;
					case "AddContactAdress":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactAdressParallelGateway1Token", e.Context.SenderName));
						break;
					case "AddContactWeb":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactWebParallelGateway1Token", e.Context.SenderName));
						break;
					case "ParallelGatewayAddContactCommunication":
						if (ParallelGatewayAddContactCommunication.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactWeb", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactAdress", e.Context.SenderName));
						}
						break;
					case "ParallelGateway1":
						if (ParallelGateway1.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
						}
						break;
					case "ReadContactsByLeadEmail":
						if (ContactFoundEmailExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadContactEmail", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactByLead", e.Context.SenderName));
						break;
					case "ChangeLeadContactEmail":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "ExclusiveInLeadCommunication":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActionAfterIdentificationScriptTask", e.Context.SenderName));
						break;
					case "ReadContactsByLeadPhone":
						if (CntactFoundPhoneExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeLeadContactPhone", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddContactByLead", e.Context.SenderName));
						break;
					case "ChangeLeadContactPhone":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveInLeadCommunication", e.Context.SenderName));
						break;
					case "ExclusiveGatewayIsLeadSet":
						if (ConditionalFlowLeadUndefinedExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "ActionAfterIdentificationScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadIsIdentified", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (IsNotFromLandingFlowExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLandingPage", e.Context.SenderName));
						break;
					case "ReadLandingPage":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (DontContactFlowExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LeadDisqualified", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveLeadHasCommunication", e.Context.SenderName));
						break;
					case "AddContactWebParallelGateway1Token":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGateway1", e.Context.SenderName));
						break;
					case "AddContactAdressParallelGateway1Token":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGateway1", e.Context.SenderName));
						break;
			}
		}

		private bool ContactFoundAllExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadContactsByLeadCommunications.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadCommunications.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadContactsByLeadCommunications.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadContactsByLeadCommunications", "ContactFoundAll", "((ReadContactsByLeadCommunications.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadCommunications.ResultEntity.Schema.Columns.GetByName(\"Id\").ColumnValueName) ? ReadContactsByLeadCommunications.ResultEntity.GetTypedColumnValue<Guid>(\"Id\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlowCommunicationAllExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != String.Empty &&
(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)) != String.Empty ||
((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) != String.Empty));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveLeadHasCommunication", "ConditionalFlowCommunicationAll", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) != String.Empty &&\n(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"MobilePhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"MobilePhone\") : null)) != String.Empty ||\n((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"BusinesPhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"BusinesPhone\") : null)) != String.Empty)", result);
			return result;
		}

		private bool ConditionalFlowEmailOnlyExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) != String.Empty &&
((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)) == String.Empty &&
((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) == String.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveLeadHasCommunication", "ConditionalFlowEmailOnly", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) != String.Empty &&\n((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"MobilePhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"MobilePhone\") : null)) == String.Empty &&\n((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"BusinesPhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"BusinesPhone\") : null)) == String.Empty", result);
			return result;
		}

		private bool ContactFoundEmailExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadContactsByLeadEmail.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadEmail.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadContactsByLeadEmail.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadContactsByLeadEmail", "ContactFoundEmail", "((ReadContactsByLeadEmail.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadEmail.ResultEntity.Schema.Columns.GetByName(\"Id\").ColumnValueName) ? ReadContactsByLeadEmail.ResultEntity.GetTypedColumnValue<Guid>(\"Id\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlowPhonesOnlyExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("Email").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("Email") : null)) == String.Empty &&
(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("MobilePhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("MobilePhone") : null)) != String.Empty ||
((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("BusinesPhone").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>("BusinesPhone") : null)) != String.Empty));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveLeadHasCommunication", "ConditionalFlowPhonesOnly", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"Email\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"Email\") : null)) == String.Empty &&\n(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"MobilePhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"MobilePhone\") : null)) != String.Empty ||\n((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"BusinesPhone\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<string>(\"BusinesPhone\") : null)) != String.Empty)", result);
			return result;
		}

		private bool CntactFoundPhoneExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadContactsByLeadPhone.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadPhone.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? ReadContactsByLeadPhone.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)) != Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ReadContactsByLeadPhone", "CntactFoundPhone", "((ReadContactsByLeadPhone.ResultEntity.IsColumnValueLoaded(ReadContactsByLeadPhone.ResultEntity.Schema.Columns.GetByName(\"Id\").ColumnValueName) ? ReadContactsByLeadPhone.ResultEntity.GetTypedColumnValue<Guid>(\"Id\") : Guid.Empty)) != Guid.Empty", result);
			return result;
		}

		private bool ConditionalFlowLeadUndefinedExpressionExecute() {
			bool result = Convert.ToBoolean((LeadId) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGatewayIsLeadSet", "ConditionalFlowLeadUndefined", "(LeadId) == Guid.Empty", result);
			return result;
		}

		private bool IsNotFromLandingFlowExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("WebForm").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("WebFormId") : Guid.Empty)) == Guid.Empty);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "IsNotFromLandingFlow", "((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName(\"WebForm\").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>(\"WebFormId\") : Guid.Empty)) == Guid.Empty", result);
			return result;
		}

		private bool DontContactFlowExpressionExecute() {
			bool result = Convert.ToBoolean(((ReadLandingPage.ResultEntity.IsColumnValueLoaded(ReadLandingPage.ResultEntity.Schema.Columns.GetByName("CreateContact").ColumnValueName) ? ReadLandingPage.ResultEntity.GetTypedColumnValue<bool>("CreateContact") : false)) == false);
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway2", "DontContactFlow", "((ReadLandingPage.ResultEntity.IsColumnValueLoaded(ReadLandingPage.ResultEntity.Schema.Columns.GetByName(\"CreateContact\").ColumnValueName) ? ReadLandingPage.ResultEntity.GetTypedColumnValue<bool>(\"CreateContact\") : false)) == false", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("IdentificationPassed")) {
				writer.WriteValue("IdentificationPassed", IdentificationPassed, false);
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
			MetaPathParameterValues.Add("1300b53e-296c-4858-8368-493adc25a74c", () => LeadId);
			MetaPathParameterValues.Add("27623c14-f1c7-4872-8f1c-45103cd82954", () => IdentificationPassed);
			MetaPathParameterValues.Add("f7cf3a22-2a33-428e-9e2b-5f3622d92f72", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("a01e5fd1-7cbb-4e06-9188-a9656c381385", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("4db6d4f9-57aa-44ef-8934-56b12a060e0e", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("dc3c82bb-8c59-485f-9376-5880ae2ce035", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("bcf6ac2d-9970-48a9-80e2-c7d41b6c0c2e", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("76636537-e5df-47a7-9eb6-124881330bf3", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("232523cc-cb63-410d-8f7c-58cdcf2ef818", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("6c984967-8a07-4d65-aefc-418e5a11cdcd", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("e3cd6198-af4e-409b-8ba3-0851372ea038", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("7e4ceefa-cd15-47a3-8a3b-c8ad4ed1ef7f", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("0a326237-a485-4b38-9337-3aa27272cdd9", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("f7b52dbf-c358-489e-bf2c-3c4ff7924a2c", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("dd6ab013-fc1e-4bc5-a25b-6855ace31f97", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("c6cfc815-55cb-4def-b83c-14b182d467ce", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("72ded882-b97d-4f56-91cb-1e6e212f4218", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("0a075eb5-bcac-445c-993d-bd329be8d6dc", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("17573208-3be8-4476-9823-f565b0714f28", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("80b5175b-4a70-4c52-aecd-45f0a21a0a46", () => ReadLeadData.ResultCompositeObjectList);
			MetaPathParameterValues.Add("226bbc3c-5b09-4281-89ec-c12e6f10bb67", () => ReadLeadData.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("b62c39d0-3349-4a21-9582-0f3e9fab1b13", () => ReadContactsByLeadCommunications.DataSourceFilters);
			MetaPathParameterValues.Add("15307ea3-405b-4286-937e-bbd0152634bb", () => ReadContactsByLeadCommunications.ResultType);
			MetaPathParameterValues.Add("b0de7902-f6c1-44eb-87ff-109bad0eb346", () => ReadContactsByLeadCommunications.ReadSomeTopRecords);
			MetaPathParameterValues.Add("d29cd82a-8e0d-4086-8795-48b2899e16af", () => ReadContactsByLeadCommunications.NumberOfRecords);
			MetaPathParameterValues.Add("daf2cf98-3c7e-4055-b671-143255e4ffb9", () => ReadContactsByLeadCommunications.FunctionType);
			MetaPathParameterValues.Add("34ed4a32-1e5a-4623-ae6a-18a622bf6230", () => ReadContactsByLeadCommunications.AggregationColumnName);
			MetaPathParameterValues.Add("97666c94-b7fa-4cf1-858f-96a7f5e41511", () => ReadContactsByLeadCommunications.OrderInfo);
			MetaPathParameterValues.Add("10568b26-1c18-4f39-9578-4a72a1c5fb66", () => ReadContactsByLeadCommunications.ResultEntity);
			MetaPathParameterValues.Add("935c4f95-44b6-44e3-920e-5b06a85a9a77", () => ReadContactsByLeadCommunications.ResultCount);
			MetaPathParameterValues.Add("567adf56-c83c-4371-b0d7-e3c15c4a747e", () => ReadContactsByLeadCommunications.ResultIntegerFunction);
			MetaPathParameterValues.Add("7ad0d0ed-5315-4834-9632-bc717ea4b547", () => ReadContactsByLeadCommunications.ResultFloatFunction);
			MetaPathParameterValues.Add("06ba8c97-f038-45da-8d5c-e5fa72c64ac0", () => ReadContactsByLeadCommunications.ResultDateTimeFunction);
			MetaPathParameterValues.Add("085f20cb-53af-486b-a15f-5bc389f586df", () => ReadContactsByLeadCommunications.ResultRowsCount);
			MetaPathParameterValues.Add("7b7d4ca0-20b2-450c-a302-c217ce695e2c", () => ReadContactsByLeadCommunications.CanReadUncommitedData);
			MetaPathParameterValues.Add("316aa43c-1aa6-47f1-aaf7-572b6f838fcf", () => ReadContactsByLeadCommunications.ResultEntityCollection);
			MetaPathParameterValues.Add("2cc24615-28c1-4668-8f49-c93ae2c5896a", () => ReadContactsByLeadCommunications.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("b4d0581e-c249-4b18-a38c-f40592d4085d", () => ReadContactsByLeadCommunications.IgnoreDisplayValues);
			MetaPathParameterValues.Add("daccd47e-87cf-45b8-baec-078cbbd8224d", () => ReadContactsByLeadCommunications.ResultCompositeObjectList);
			MetaPathParameterValues.Add("04be8462-47b6-44e4-b31b-f6d0c69cfc7c", () => ReadContactsByLeadCommunications.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("9a626ad2-321e-427a-9f24-760d9280a022", () => ChangeLeadContactAll.EntitySchemaUId);
			MetaPathParameterValues.Add("564a7988-620b-401f-9bfc-8041ac06be95", () => ChangeLeadContactAll.IsMatchConditions);
			MetaPathParameterValues.Add("b7b1963b-962d-4921-a62e-3119d14d8a66", () => ChangeLeadContactAll.DataSourceFilters);
			MetaPathParameterValues.Add("5d16c9f4-5c23-4097-8d07-fac1cb716e39", () => ChangeLeadContactAll.RecordColumnValues);
			MetaPathParameterValues.Add("c43dec79-6b59-4fc6-94f0-bcc6a7f8c091", () => AddContactByLead.EntitySchemaId);
			MetaPathParameterValues.Add("61b7d5bc-8334-4d0a-8ec3-aac02f0f6b0d", () => AddContactByLead.DataSourceFilters);
			MetaPathParameterValues.Add("ec4e60e4-4bd2-476d-bfa5-f3879991dce5", () => AddContactByLead.RecordAddMode);
			MetaPathParameterValues.Add("fc9a7fd7-6ae6-4198-801f-ed65a0714560", () => AddContactByLead.FilterEntitySchemaId);
			MetaPathParameterValues.Add("0698fbce-2359-4022-88df-2b5fa4260af7", () => AddContactByLead.RecordDefValues);
			MetaPathParameterValues.Add("77a80f56-4b60-48bc-be27-e96ffd4cc59b", () => AddContactByLead.RecordId);
			MetaPathParameterValues.Add("5a0a517a-3cd6-4838-89ed-dd198ad96f83", () => AddContactAdress.EntitySchemaId);
			MetaPathParameterValues.Add("dcf0939b-5ae1-4506-a7a2-453c0eb2f2d8", () => AddContactAdress.DataSourceFilters);
			MetaPathParameterValues.Add("55cf3377-2bf5-4a73-8eb5-34e7b911258b", () => AddContactAdress.RecordAddMode);
			MetaPathParameterValues.Add("6d55db5f-8e6c-420b-9a07-be564e8b90da", () => AddContactAdress.FilterEntitySchemaId);
			MetaPathParameterValues.Add("6aa29df7-9dcf-4eea-b7dd-70cbb55c6070", () => AddContactAdress.RecordDefValues);
			MetaPathParameterValues.Add("b9f11eba-9282-49e7-842b-28c1d0f2190f", () => AddContactAdress.RecordId);
			MetaPathParameterValues.Add("97a7e2ca-58ad-4a27-8a87-3f50772b77be", () => AddContactWeb.EntitySchemaId);
			MetaPathParameterValues.Add("2f713b4e-bdb9-470a-b959-23af1cb99aaa", () => AddContactWeb.DataSourceFilters);
			MetaPathParameterValues.Add("9021827f-1e50-40f2-8b7f-ec1b0e056ccb", () => AddContactWeb.RecordAddMode);
			MetaPathParameterValues.Add("aa2e3f7d-4042-4910-b0eb-0f5b57896d58", () => AddContactWeb.FilterEntitySchemaId);
			MetaPathParameterValues.Add("7a98d7a0-39d9-4231-b19a-9c603fa6baf0", () => AddContactWeb.RecordDefValues);
			MetaPathParameterValues.Add("89ff5387-057a-41f9-a2cd-98c33da073a9", () => AddContactWeb.RecordId);
			MetaPathParameterValues.Add("d6514abc-f96a-4d19-b5f8-f55b1ac00b83", () => ReadContactsByLeadEmail.DataSourceFilters);
			MetaPathParameterValues.Add("881a211c-0037-4de8-9966-fd5b76082530", () => ReadContactsByLeadEmail.ResultType);
			MetaPathParameterValues.Add("1b0558b6-d02e-43db-a632-da912ff74169", () => ReadContactsByLeadEmail.ReadSomeTopRecords);
			MetaPathParameterValues.Add("38ac0d8a-57fb-4d3c-a724-83243171725c", () => ReadContactsByLeadEmail.NumberOfRecords);
			MetaPathParameterValues.Add("2306c9f4-91b3-4ae6-9d0d-b85b15f043a5", () => ReadContactsByLeadEmail.FunctionType);
			MetaPathParameterValues.Add("91e3ad56-02d2-495e-8f8d-6839c1e13901", () => ReadContactsByLeadEmail.AggregationColumnName);
			MetaPathParameterValues.Add("09b2ffa0-b537-4970-bb51-a8da7fb89215", () => ReadContactsByLeadEmail.OrderInfo);
			MetaPathParameterValues.Add("4e1e0793-a5ec-42a4-b7b6-dcf4eb1670ee", () => ReadContactsByLeadEmail.ResultEntity);
			MetaPathParameterValues.Add("f289649e-c0c3-403b-8124-ffe171aafe33", () => ReadContactsByLeadEmail.ResultCount);
			MetaPathParameterValues.Add("e7d2a1ae-2033-4d71-9990-c4c12f4faa89", () => ReadContactsByLeadEmail.ResultIntegerFunction);
			MetaPathParameterValues.Add("681c5445-3ca2-45de-bf7c-0f37318944d1", () => ReadContactsByLeadEmail.ResultFloatFunction);
			MetaPathParameterValues.Add("95b392b6-a727-407b-a3ec-157c1314469b", () => ReadContactsByLeadEmail.ResultDateTimeFunction);
			MetaPathParameterValues.Add("0eadc500-3c91-49a1-8071-9d0668f51d38", () => ReadContactsByLeadEmail.ResultRowsCount);
			MetaPathParameterValues.Add("849f1602-4ec0-45ef-a640-370b4ec656e7", () => ReadContactsByLeadEmail.CanReadUncommitedData);
			MetaPathParameterValues.Add("847ce0c0-4e8f-4238-a637-16f20d906278", () => ReadContactsByLeadEmail.ResultEntityCollection);
			MetaPathParameterValues.Add("1cfe3a33-faaf-4cb5-b49e-d1eadaa81bec", () => ReadContactsByLeadEmail.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("f61ce3ad-7460-43d4-b04a-9a8735ba629d", () => ReadContactsByLeadEmail.IgnoreDisplayValues);
			MetaPathParameterValues.Add("df66e2ab-a26c-4a4a-b713-f5ddc931a4ae", () => ReadContactsByLeadEmail.ResultCompositeObjectList);
			MetaPathParameterValues.Add("b3be71cf-1a55-46fd-a923-94a785cee174", () => ReadContactsByLeadEmail.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("788c3395-e8dc-443e-9c81-e57decd44c14", () => ChangeLeadContactEmail.EntitySchemaUId);
			MetaPathParameterValues.Add("40c79c51-5e3e-4a77-881f-bfb3b5148e9c", () => ChangeLeadContactEmail.IsMatchConditions);
			MetaPathParameterValues.Add("3da883c3-07af-4baf-9a48-e1f261dbd978", () => ChangeLeadContactEmail.DataSourceFilters);
			MetaPathParameterValues.Add("bec4aa50-4e70-47b5-99c8-d0f15b4b12f8", () => ChangeLeadContactEmail.RecordColumnValues);
			MetaPathParameterValues.Add("55598db2-619f-4f92-a9b5-d03ddb173ed0", () => ReadContactsByLeadPhone.DataSourceFilters);
			MetaPathParameterValues.Add("519549f0-c248-40b5-be93-602f4ff55bac", () => ReadContactsByLeadPhone.ResultType);
			MetaPathParameterValues.Add("c1675f40-4a8b-469f-807f-482b441e6236", () => ReadContactsByLeadPhone.ReadSomeTopRecords);
			MetaPathParameterValues.Add("8aacc82f-451e-44f0-a1ea-c48fac82b9aa", () => ReadContactsByLeadPhone.NumberOfRecords);
			MetaPathParameterValues.Add("1a7cefdb-8943-464e-9818-f056350796f1", () => ReadContactsByLeadPhone.FunctionType);
			MetaPathParameterValues.Add("a45be9e6-9a59-46ac-b1b7-9def07669d0c", () => ReadContactsByLeadPhone.AggregationColumnName);
			MetaPathParameterValues.Add("6b161822-7e93-4124-b2d6-c1605b5f5657", () => ReadContactsByLeadPhone.OrderInfo);
			MetaPathParameterValues.Add("97881864-f21d-4f49-b39f-662c780efdc9", () => ReadContactsByLeadPhone.ResultEntity);
			MetaPathParameterValues.Add("83016a9c-a67e-4328-a96e-bfacfc2c77c6", () => ReadContactsByLeadPhone.ResultCount);
			MetaPathParameterValues.Add("a0d9ba4a-555e-4324-ae31-f59d0233fbc6", () => ReadContactsByLeadPhone.ResultIntegerFunction);
			MetaPathParameterValues.Add("5b48e127-d50b-49a3-8459-4a9a52bf6988", () => ReadContactsByLeadPhone.ResultFloatFunction);
			MetaPathParameterValues.Add("6ef7572f-4836-4cfe-ad97-3868281a4281", () => ReadContactsByLeadPhone.ResultDateTimeFunction);
			MetaPathParameterValues.Add("ce2e72d3-d7a5-4f50-9ecf-44b4bf27b6ea", () => ReadContactsByLeadPhone.ResultRowsCount);
			MetaPathParameterValues.Add("98faeefc-cf3f-4be3-a9b9-40bd344629d3", () => ReadContactsByLeadPhone.CanReadUncommitedData);
			MetaPathParameterValues.Add("e75f4ff2-ebaa-43f4-aff7-36f8fa2f00cd", () => ReadContactsByLeadPhone.ResultEntityCollection);
			MetaPathParameterValues.Add("1a5f9685-0340-43a4-85bd-917ac7f8b75a", () => ReadContactsByLeadPhone.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("4a757dc8-11a2-46d0-962c-01dc9f7cf05c", () => ReadContactsByLeadPhone.IgnoreDisplayValues);
			MetaPathParameterValues.Add("aaf1a71e-6beb-4e10-9fbd-54d5a3ea0564", () => ReadContactsByLeadPhone.ResultCompositeObjectList);
			MetaPathParameterValues.Add("1ad992f2-bdf7-41a1-819c-2ba446fc91ed", () => ReadContactsByLeadPhone.ConsiderTimeInFilter);
			MetaPathParameterValues.Add("cfc1a8ae-2a77-49bb-a728-a1637ee8c94a", () => ChangeLeadContactPhone.EntitySchemaUId);
			MetaPathParameterValues.Add("5feb2bce-5433-4c25-a83d-3f8d28ccc8ab", () => ChangeLeadContactPhone.IsMatchConditions);
			MetaPathParameterValues.Add("9acd36f8-ce89-4f92-bdb8-e4eea778daf4", () => ChangeLeadContactPhone.DataSourceFilters);
			MetaPathParameterValues.Add("15555f52-d536-4815-a506-977a98d2f0f3", () => ChangeLeadContactPhone.RecordColumnValues);
			MetaPathParameterValues.Add("3719e46d-8e08-48ad-8083-1ccf953996c6", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("08550f59-4992-48fb-b252-df02ec268766", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("44584732-acad-4754-bde4-a1b1cfd19199", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("33aca163-6ecf-4e71-9484-09432fbc4746", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("cd3fabe0-1945-4d5e-9fb8-9e85ee54cc3b", () => ReadLandingPage.DataSourceFilters);
			MetaPathParameterValues.Add("c84ed90e-913c-4d79-be6e-0aeb6dbde695", () => ReadLandingPage.ResultType);
			MetaPathParameterValues.Add("528b68b1-c488-499b-b6a9-98d627973317", () => ReadLandingPage.ReadSomeTopRecords);
			MetaPathParameterValues.Add("7db9bc2b-3431-4feb-8af1-b2fcbc5cf552", () => ReadLandingPage.NumberOfRecords);
			MetaPathParameterValues.Add("50c50a69-929a-4ae1-8501-1657483ac91c", () => ReadLandingPage.FunctionType);
			MetaPathParameterValues.Add("5a09f02d-d645-448c-a427-3dc0ad363ad0", () => ReadLandingPage.AggregationColumnName);
			MetaPathParameterValues.Add("2793b917-606e-429f-8d6b-56caf9a5d36b", () => ReadLandingPage.OrderInfo);
			MetaPathParameterValues.Add("a435ea7f-ecdc-4500-acc1-f4ab6e8b2a76", () => ReadLandingPage.ResultEntity);
			MetaPathParameterValues.Add("e0010511-9818-4608-8cc6-966c057c7fb7", () => ReadLandingPage.ResultCount);
			MetaPathParameterValues.Add("5ce1ad73-33d5-4d54-99dc-103fe2185918", () => ReadLandingPage.ResultIntegerFunction);
			MetaPathParameterValues.Add("f1d51e05-81e8-439e-be55-ef17ce69d451", () => ReadLandingPage.ResultFloatFunction);
			MetaPathParameterValues.Add("5400d0e0-9171-4da4-9833-ee4bc440d882", () => ReadLandingPage.ResultDateTimeFunction);
			MetaPathParameterValues.Add("fe6f5c9f-37df-4b0d-b855-65847152e915", () => ReadLandingPage.ResultRowsCount);
			MetaPathParameterValues.Add("ec12f3b9-746c-4f92-ba49-ce658079412a", () => ReadLandingPage.CanReadUncommitedData);
			MetaPathParameterValues.Add("6dc416c9-504c-4429-b04e-93f543f173c4", () => ReadLandingPage.ResultEntityCollection);
			MetaPathParameterValues.Add("b66e4485-d571-44cb-9e32-b832c83541ca", () => ReadLandingPage.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("1c52f53d-1e03-445c-bcbe-0982a59c336a", () => ReadLandingPage.IgnoreDisplayValues);
			MetaPathParameterValues.Add("53165197-1fec-4a54-8554-f92812f26388", () => ReadLandingPage.ResultCompositeObjectList);
			MetaPathParameterValues.Add("a481ce48-85ca-457f-98da-430695e26372", () => ReadLandingPage.ConsiderTimeInFilter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "IdentificationPassed":
					if (!hasValueToRead) break;
					IdentificationPassed = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ActionAfterIdentificationScriptTaskExecute(ProcessExecutingContext context) {
			ActionAfterIdentification();
			return true;
		}

		public virtual void ActionAfterIdentification() {
			string applicationUrl = string.Empty;
			if (Terrasoft.Web.Http.Abstractions.HttpContext.Current != null) {
				applicationUrl = Terrasoft.Web.Common.WebUtilities.GetParentApplicationUrl(Terrasoft.Web.Http.Abstractions.HttpContext.Current.Request);
			}
			var leadQualificationHelper = ClassFactory.Get<LeadQualificationHelper>(new ConstructorArgument[]{
				new ConstructorArgument("userConnection", UserConnection),
				new ConstructorArgument("applicationUrl", applicationUrl)
			});
			leadQualificationHelper.ActionAfterIdentification(LeadId);
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
			var cloneItem = (LeadManagementIdentification)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

