namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Linq;
	using System.Text.RegularExpressions;
	using System.Web;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: FillEmailTemplateUserTaskSchema

	/// <exclude/>
	public class FillEmailTemplateUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public FillEmailTemplateUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public FillEmailTemplateUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1");
			RealUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1");
			Name = "FillEmailTemplateUserTask";
			CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,209,110,211,48,20,125,78,190,194,243,94,92,41,170,246,62,152,96,165,160,10,6,221,186,177,7,196,131,73,238,86,163,196,233,108,7,136,208,254,157,123,109,183,113,202,54,134,84,169,145,125,238,185,199,231,30,251,21,255,33,13,107,164,150,183,96,216,75,118,101,193,204,90,173,161,116,170,213,211,185,118,202,245,171,114,13,141,60,11,160,227,156,42,46,161,217,212,210,193,124,117,142,85,26,126,178,20,122,222,129,233,69,100,45,24,231,243,70,170,122,91,195,249,228,56,79,8,166,175,171,106,214,214,93,163,5,231,171,238,219,119,108,254,36,230,180,173,250,191,0,111,85,237,192,88,2,138,60,75,119,102,6,240,43,236,95,43,183,94,74,35,27,32,48,2,179,176,62,107,155,141,52,202,182,250,178,223,192,116,126,215,201,186,96,184,205,249,162,226,220,127,110,57,23,85,158,77,242,73,48,226,142,142,122,1,182,171,29,26,145,182,125,7,46,120,130,186,235,224,167,24,219,139,20,234,134,137,132,98,58,107,59,237,216,9,59,154,176,223,121,22,205,64,226,4,243,229,232,43,113,147,206,104,201,103,89,119,240,194,58,163,244,237,201,158,135,25,153,245,191,4,59,131,239,25,212,22,72,138,1,215,25,205,156,233,0,151,243,128,101,214,143,251,35,218,137,45,194,218,116,222,108,92,31,204,177,189,13,129,120,86,178,112,132,186,90,104,235,164,46,225,180,191,90,84,98,213,219,20,184,168,162,101,3,241,1,166,175,171,107,111,215,88,205,22,50,165,133,39,142,18,46,128,210,207,138,242,208,34,206,223,110,207,23,33,228,236,112,6,2,138,81,77,236,52,202,51,37,12,183,222,40,111,141,52,125,28,69,17,45,61,97,165,135,18,133,141,26,31,7,139,168,172,145,165,105,237,7,101,41,63,100,237,25,45,136,24,14,47,101,11,32,53,23,82,223,130,24,112,148,129,9,162,110,90,188,62,229,90,16,229,32,99,41,173,101,74,39,77,252,4,212,141,56,72,180,98,156,181,195,3,219,247,208,139,113,241,196,227,179,129,149,70,22,230,69,26,130,249,193,161,211,126,41,221,122,191,30,163,77,237,98,113,26,131,44,139,233,4,123,55,219,21,249,17,237,123,191,199,25,163,130,12,233,33,232,69,25,3,139,49,181,215,114,159,227,47,164,9,124,126,146,134,187,167,96,239,1,40,152,104,195,52,46,160,108,77,229,243,61,92,122,186,164,240,203,93,127,242,19,177,96,197,96,119,193,34,174,136,237,138,52,36,72,19,239,253,211,28,4,122,140,192,159,196,58,213,224,123,22,138,145,142,243,195,121,92,59,228,156,46,163,216,206,24,255,173,11,64,49,174,11,179,190,218,84,184,242,56,170,32,173,91,242,149,159,160,160,0,222,143,148,44,85,249,144,24,92,126,142,158,93,245,191,36,237,128,15,168,194,189,40,44,125,73,248,31,175,88,149,169,75,7,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = true;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSubjectParameter());
			Parameters.Add(CreateBodyParameter());
			Parameters.Add(CreateRecordIdParameter());
			Parameters.Add(CreateTemplateIdParameter());
			Parameters.Add(CreateSysEntitySchemaIdParameter());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNoDataLocalizableStringLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNoDataLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("61db10e5-c317-40c1-8a73-5e70756abb21"),
				Name = "NoDataLocalizableString",
				CreatedInPackageId = new Guid("88636621-dfdb-4601-a5d0-d48d9d187d38"),
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaParameter CreateSubjectParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("82b57fbb-8e7b-48de-85e8-e9063cd8275a"),
				Name = "Subject",
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateBodyParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("851df5cc-c52b-4978-94a4-a3afeccfa553"),
				Name = "Body",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecordIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("04f6bb80-2f4d-4120-9fd3-6831f5236a7b"),
				Name = "RecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateTemplateIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("315ec20d-75de-4da7-9e8d-d75d5ed99ed0"),
				Name = "TemplateId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSysEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("01e6c3d6-9264-4ed4-8bf0-72f8067b77eb"),
				Name = "SysEntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
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
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateGetExecutionDataMethod());
			Methods.Add(CreateFindMacroMethod());
			Methods.Add(CreateGetEstimateStringMethod());
			Methods.Add(CreateGetEstimateStringPicMethod());
			Methods.Add(CreateGetTextWOMacrosesMethod());
			Methods.Add(CreateUpdateConstMacrosMethod());
			Methods.Add(CreateContainsConstMacrosMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("93cfd6b9-c336-4181-b7c0-04b1e4c2c236"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("210bfd1a-83b3-4f95-b5e6-69b9c56e506a"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("dcaac0c4-8da9-4934-a5ab-aaa139c2da2f"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("1c03a3fe-87f3-466f-a6b7-a88ed4e512f8")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("decdb517-2d4b-45cb-a4be-a2c01521313b"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f92127a8-c740-4049-9d20-0766b5ea7294"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2417cdb2-d558-4a2d-b526-76a2b199cf80"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("23ca1ff3-6865-4a1a-a502-84247be7e11f"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6817b341-f94c-4c95-a71f-9ffe62629c7a"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3618695e-9ec3-4573-bee0-844799f0bad1"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bc26359d-e2b6-4c3a-ba40-db5d51784a67"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				ModifiedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9bdc5516-0629-4934-ad37-5559ea38a903"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindMacroMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("068bf8bb-c681-43d6-b6b3-0bae1afeade1"),
				Name = "FindMacro",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "List<string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a4441277-8414-490d-8067-2ffe56fa4b12"),
				Name = "source",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,74,173,82,176,85,200,75,45,87,240,201,44,46,177,41,46,41,202,204,75,183,211,208,180,230,74,203,47,74,77,76,206,80,208,240,77,44,1,82,185,96,50,51,79,33,40,53,61,181,66,15,44,152,90,172,81,156,95,90,148,156,170,163,224,160,20,19,173,172,161,167,109,175,169,28,19,171,164,169,169,80,205,197,9,52,91,207,49,37,69,3,172,85,207,189,40,191,180,160,56,218,48,86,47,44,49,167,52,21,104,67,45,87,81,106,73,105,81,30,200,17,214,0,158,62,51,39,141,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEstimateStringMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a6645307-34ff-46d1-b3fd-f6b347c00721"),
				Name = "GetEstimateString",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,93,111,130,48,20,125,30,191,162,225,65,33,154,110,123,70,92,22,116,203,146,125,184,161,123,111,232,5,27,161,53,183,197,141,24,255,251,10,40,115,248,176,151,38,109,206,61,31,247,84,27,20,50,35,37,230,36,36,158,110,110,254,18,16,153,86,169,161,145,66,176,135,76,69,86,34,51,66,73,26,87,58,6,99,44,78,211,71,48,159,44,47,193,91,105,64,11,147,144,212,152,49,113,99,97,96,133,185,235,7,78,75,74,114,33,55,86,195,157,48,178,70,72,195,161,75,70,141,238,136,184,81,169,141,42,98,192,157,72,64,83,246,205,239,88,195,20,130,54,162,96,6,6,130,135,245,192,7,36,10,249,19,167,75,21,55,188,158,95,19,12,106,115,50,11,247,55,135,225,116,127,123,152,92,179,41,33,110,39,142,160,203,220,88,249,246,78,231,197,214,84,129,179,99,72,64,26,97,170,56,89,67,193,222,75,192,202,162,36,124,145,121,255,189,23,146,158,3,94,152,100,25,96,29,220,26,209,105,235,254,25,118,208,172,224,66,131,222,115,30,169,188,44,164,231,190,178,2,254,5,45,148,144,198,245,233,27,114,192,153,192,214,131,181,250,247,129,206,64,39,32,185,205,24,56,77,60,75,151,108,18,149,231,221,196,165,142,173,177,13,19,117,184,94,88,107,47,181,95,129,37,107,226,213,172,209,130,8,217,231,246,201,222,185,58,110,122,212,173,250,65,161,45,208,171,235,31,219,185,90,172,13,213,254,156,46,217,111,161,39,216,178,218,2,63,195,78,90,198,233,105,101,214,212,193,65,48,37,202,99,193,193,15,167,244,106,41,207,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEstimateStringPicMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8e6159dd-fc1b-43f1-985d-ed73381690d2"),
				Name = "GetEstimateStringPic",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,84,89,115,218,48,16,126,14,191,66,245,11,48,33,38,237,244,161,99,3,211,148,164,199,76,59,109,3,105,159,21,107,141,53,149,37,71,90,147,210,76,254,123,119,101,32,9,61,94,140,142,213,119,236,65,64,175,237,74,180,222,228,61,93,14,222,35,54,115,103,17,126,98,58,111,189,7,139,226,217,84,216,214,152,161,184,235,81,152,152,138,65,136,143,134,75,240,94,6,87,98,250,29,174,211,185,171,107,103,121,121,133,218,104,212,16,210,119,128,111,100,128,179,166,49,186,144,168,157,189,242,230,111,36,233,37,220,180,16,112,152,247,238,5,152,0,255,33,155,59,15,244,177,165,94,181,62,130,166,139,77,88,0,34,197,69,206,111,210,180,48,184,10,224,41,204,66,193,49,35,145,44,52,2,241,39,76,210,43,156,13,40,58,112,161,244,122,129,27,3,196,247,58,185,213,10,171,76,188,60,109,126,230,162,2,189,170,112,183,43,73,245,73,208,191,32,19,47,94,241,1,123,56,145,70,175,108,38,10,242,1,62,23,107,240,72,110,205,238,188,214,74,25,160,199,198,73,204,12,148,152,139,107,89,252,88,121,215,90,149,221,157,222,231,73,254,84,79,229,161,220,9,74,34,135,130,194,117,102,51,97,157,37,184,194,25,231,51,113,91,145,171,255,144,178,226,82,214,218,108,50,241,13,188,146,86,142,196,153,215,210,140,150,178,114,181,100,242,222,150,215,104,251,131,41,39,168,68,76,195,180,255,242,180,191,77,66,183,14,44,107,218,175,165,95,105,123,130,174,201,4,103,162,63,75,196,113,239,232,40,153,200,168,126,218,167,61,183,21,125,147,241,2,252,90,23,240,201,41,48,227,57,117,196,165,228,98,125,34,49,43,168,41,111,219,128,52,172,139,49,221,1,199,140,25,225,146,125,171,15,42,194,80,170,246,2,238,94,220,71,78,65,164,196,74,21,220,223,60,167,27,10,157,140,233,112,47,107,44,187,37,173,80,205,216,243,90,122,225,33,180,6,201,114,151,128,244,162,110,112,147,199,43,8,55,116,110,225,86,92,88,212,184,89,20,21,212,242,107,11,126,115,208,90,233,227,128,206,147,231,118,35,143,161,148,49,228,35,172,33,54,30,161,166,103,74,205,157,105,107,59,72,190,56,109,49,25,166,159,189,2,127,174,125,7,72,188,79,15,210,115,8,212,94,138,36,254,1,65,191,174,245,140,93,210,96,200,162,18,3,150,31,14,217,133,182,236,137,231,163,211,75,15,77,7,127,224,103,200,163,126,196,32,13,203,227,236,28,130,49,202,114,211,192,86,69,28,184,9,197,206,246,150,242,14,33,118,233,191,16,30,61,126,240,145,46,221,34,22,99,176,199,160,255,136,243,135,9,221,150,234,173,243,181,196,193,110,116,71,29,21,191,217,22,245,248,48,148,187,123,212,121,26,61,1,29,61,12,92,252,111,240,128,173,183,60,6,242,154,40,175,29,23,99,218,167,238,47,192,152,70,42,46,196,126,31,26,89,196,253,243,254,108,130,62,54,229,78,130,224,118,243,51,250,48,18,181,221,111,7,164,6,66,112,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetTextWOMacrosesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2b084abd-573c-4f2d-b4b8-582d3b9973ca"),
				Name = "GetTextWOMacroses",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("baf37087-414c-4e51-88fb-c78b858ae000"),
				Name = "Macroses",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<string>",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("357fa74c-acc2-419f-ac6a-f48804305624"),
				Name = "Text",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b563cf96-e5c4-4a7a-9802-1a5adcb30fec"),
				Name = "entity",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d59e6a4e-8147-425c-ab19-5875b408efb4"),
				Name = "columnNames",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, string>",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,207,110,194,48,12,198,207,237,83,88,229,146,138,41,47,80,33,14,48,113,97,104,26,104,23,196,193,4,111,171,148,38,40,113,17,29,226,221,73,83,65,249,115,178,108,127,223,47,249,236,217,149,230,23,118,200,248,94,237,185,129,17,44,236,52,116,115,171,80,151,255,184,213,180,140,26,249,141,186,166,34,253,177,142,80,253,129,56,160,3,101,117,93,153,5,86,244,137,222,67,105,224,3,149,179,158,124,14,167,52,241,29,189,87,5,124,55,147,241,181,226,38,57,180,240,215,45,187,166,229,36,15,132,190,241,235,199,15,108,130,37,185,162,4,25,46,185,145,51,226,73,84,197,0,162,119,228,48,30,247,201,115,185,178,93,82,145,7,204,25,20,114,136,121,186,35,222,180,237,62,77,86,116,228,48,109,139,252,162,189,70,69,34,91,15,50,24,62,223,101,8,217,96,147,189,117,41,3,253,156,58,226,218,153,232,45,46,74,65,218,129,132,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateConstMacrosMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("419457fa-ec7e-428b-94ad-e5e1b0223e3e"),
				Name = "UpdateConstMacros",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("67584c4f-1726-4855-9869-d26066896a12"),
				Name = "macros",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0a522e1b-73d3-4b89-ae28-11ba6ab5b402"),
				Name = "value",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,77,202,74,77,46,81,176,85,8,134,176,244,130,82,11,114,18,147,83,53,114,19,147,139,242,139,117,20,202,18,115,74,83,53,173,185,156,242,83,42,129,202,64,20,46,53,0,100,81,225,33,77,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateContainsConstMacrosMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("720e7993-8d68-4306-9038-0b3e0457adb5"),
				Name = "ContainsConstMacros",
				CreatedInSchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"),
				CreatedInPackageId = new Guid("91a82ca0-30c0-47ca-b870-a5b95f568416"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("dd6ef407-3efe-4c9b-a0bc-18674cb7dc35"),
				Name = "macros",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("91a82ca0-30c0-47ca-b870-a5b95f568416")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,46,77,202,74,77,46,209,115,206,207,43,73,204,204,43,214,200,77,76,46,202,47,214,84,168,169,81,112,202,79,169,196,144,176,6,0,235,38,29,239,57,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FillEmailTemplateUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1"));
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
			return new FillEmailTemplateUserTask(userConnection) {
				SchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1")
			};
		}

		#endregion

	}

	#endregion

	#region Class: FillEmailTemplateUserTask

	[DesignModeProperty(Name = "Subject", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "06a1cb59b0dc424ab7032b704cdce8a1", CaptionResourceItem = "Parameters.Subject.Caption", DescriptionResourceItem = "Parameters.Subject.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Body", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "06a1cb59b0dc424ab7032b704cdce8a1", CaptionResourceItem = "Parameters.Body.Caption", DescriptionResourceItem = "Parameters.Body.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RecordId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "06a1cb59b0dc424ab7032b704cdce8a1", CaptionResourceItem = "Parameters.RecordId.Caption", DescriptionResourceItem = "Parameters.RecordId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "TemplateId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "06a1cb59b0dc424ab7032b704cdce8a1", CaptionResourceItem = "Parameters.TemplateId.Caption", DescriptionResourceItem = "Parameters.TemplateId.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SysEntitySchemaId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "06a1cb59b0dc424ab7032b704cdce8a1", CaptionResourceItem = "Parameters.SysEntitySchemaId.Caption", DescriptionResourceItem = "Parameters.SysEntitySchemaId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class FillEmailTemplateUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public FillEmailTemplateUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("06a1cb59-b0dc-424a-b703-2b704cdce8a1");
		}

		#endregion

		#region Properties: Public

		public virtual string Subject {
			get;
			set;
		}

		public virtual string Body {
			get;
			set;
		}

		public virtual Guid RecordId {
			get;
			set;
		}

		public virtual Guid TemplateId {
			get;
			set;
		}

		public virtual Guid SysEntitySchemaId {
			get;
			set;
		}

		private LocalizableString _noDataLocalizableString;
		public LocalizableString NoDataLocalizableString {
			get {
				return _noDataLocalizableString ?? (_noDataLocalizableString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "LocalizableStrings.NoDataLocalizableString.Value"));
			}
		}

		#endregion

		#region Methods: Public

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("Subject")) {
				writer.WriteValue("Subject", Subject, null);
			}
			if (!HasMapping("Body")) {
				writer.WriteValue("Body", Body, null);
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			if (!HasMapping("TemplateId")) {
				writer.WriteValue("TemplateId", TemplateId, Guid.Empty);
			}
			if (!HasMapping("SysEntitySchemaId")) {
				writer.WriteValue("SysEntitySchemaId", SysEntitySchemaId, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Subject":
					Subject = reader.GetStringValue();
				break;
				case "Body":
					Body = reader.GetStringValue();
				break;
				case "RecordId":
					RecordId = reader.GetGuidValue();
				break;
				case "TemplateId":
					TemplateId = reader.GetGuidValue();
				break;
				case "SysEntitySchemaId":
					SysEntitySchemaId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

