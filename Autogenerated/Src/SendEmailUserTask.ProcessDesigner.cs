namespace Terrasoft.Core.Process.Configuration
{

	using MailBee.Mime;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Mail;
	using Terrasoft.Mail.Sender;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: SendEmailUserTaskSchema

	/// <exclude/>
	public class SendEmailUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SendEmailUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SendEmailUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926");
			RealUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926");
			Name = "SendEmailUserTask";
			CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = new Guid("87bb4efd-f92c-44d7-bb0b-d233d3cd4a71");
			ParametersEditPageSchemaV2UId = new Guid("b5d47e82-abb2-4e4c-950c-48ceddfb1250");
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,111,79,194,48,16,198,95,227,167,168,123,181,37,132,47,32,16,101,14,179,68,141,17,141,175,75,119,140,154,173,37,215,86,66,12,223,221,222,58,100,3,255,240,130,109,79,239,158,187,251,93,175,163,129,92,177,248,25,4,108,36,40,203,38,19,166,92,85,37,236,243,98,224,127,8,214,161,98,22,29,92,145,176,167,191,15,142,108,133,186,102,19,118,7,118,1,170,0,124,228,53,196,225,53,105,34,239,165,177,99,99,81,170,114,202,240,224,111,66,78,86,115,89,221,20,5,130,49,96,142,229,67,42,249,3,69,60,161,212,40,237,206,39,197,89,87,72,242,122,163,209,114,37,224,188,152,16,222,79,254,81,46,213,155,221,73,201,158,193,242,95,135,89,37,85,241,131,13,117,94,251,16,94,130,207,83,176,101,77,226,67,43,5,166,243,128,142,8,14,27,225,69,251,207,35,162,32,46,220,242,29,132,95,8,107,223,130,60,211,5,225,160,71,16,58,140,122,204,194,105,42,188,222,29,167,117,17,164,247,230,108,182,219,12,65,23,130,154,27,229,38,171,55,118,23,39,135,219,64,251,109,6,122,147,118,125,11,43,238,170,118,253,113,59,117,192,240,251,181,105,90,76,43,170,56,231,194,106,164,190,211,138,27,211,126,142,60,236,113,118,22,53,141,9,102,170,149,223,145,35,229,6,75,87,251,243,56,138,156,1,244,39,202,51,146,90,69,81,24,241,181,167,38,39,55,43,116,221,221,81,59,199,121,131,67,118,98,213,56,89,223,121,128,210,241,27,209,163,143,98,207,4,183,98,221,198,18,218,203,220,228,165,210,8,25,162,70,115,96,59,176,107,212,219,128,111,255,205,172,11,50,250,2,102,230,17,205,173,3,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateSenderParameter());
			Parameters.Add(CreateRecepientParameter());
			Parameters.Add(CreateCopyRecepientParameter());
			Parameters.Add(CreateBlindCopyRecepientParameter());
			Parameters.Add(CreateSubjectParameter());
			Parameters.Add(CreateBodyParameter());
			Parameters.Add(CreateImportanceParameter());
			Parameters.Add(CreateIsIgnoreErrorsParameter());
		}

		protected virtual ProcessSchemaParameter CreateSenderParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("c8fcd086-38ba-40c2-a7bd-6265320bffe2"),
				Name = "Sender",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
				ReferenceSchemaUId = new Guid("5e487721-02e2-48ee-b755-dfa5160f5315"),
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRecepientParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8df95a2c-e79c-4f3f-a852-46b832c90e65"),
				Name = "Recepient",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateCopyRecepientParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("05cf315b-18ac-49d3-b4d6-e8182c7fbb4c"),
				Name = "CopyRecepient",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateBlindCopyRecepientParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("bc4f6a06-7765-4308-8e35-c1269515c8aa"),
				Name = "BlindCopyRecepient",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b6f25b3a-89ee-4d3c-a7b9-eded31ca9862"),
				Name = "Subject",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
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
				UId = new Guid("fdb4b83b-cf17-489d-9885-b02bad3edfa8"),
				Name = "Body",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateImportanceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("616c2cef-dc27-4e70-9a52-599452ad1423"),
				Name = "Importance",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"1",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				},
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsIgnoreErrorsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("8b368dac-9522-4e93-bde6-a8ae21beedd0"),
				Name = "IsIgnoreErrors",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"True",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				},
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
			Methods.Add(CreateGetEmailAddressesMethod());
			Methods.Add(CreateGetSenderNameMethod());
			Methods.Add(CreateGetEmailAddressCollectionMethod());
			Methods.Add(CreateSendEmailWithDefaultSenderMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("75be0f2a-2086-4675-b3cc-3e6f51d4abab"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4471a081-cc05-4c0f-a42f-ef6001e30d69"),
				Name = "Terrasoft.Mail.Sender",
				Alias = "",
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f29b7d36-ce9b-4b30-92d8-e89abe906717"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f07e0c6e-1341-451f-a638-3959a7762263"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9f88bdac-704e-4cb7-9938-ef56b33e01ea"),
				Name = "MailBee.Mime",
				Alias = "",
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6ff61d39-65f5-4d72-baa1-bb5a0afb353c"),
				Name = "Terrasoft.Mail.Sender",
				Alias = "",
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("876f2646-af0d-4988-835d-3ab83840aee6"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4c2f6716-d1ae-4e79-89c2-d15af1b26cca"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("68b01b91-e13e-4884-8de4-e33ad84b1d21"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cd84a5c5-e2db-4212-874a-52e2893b8c62"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("66555beb-7a37-42c8-a1d9-84955cdb690c"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,206,207,45,200,73,45,73,117,173,72,77,46,45,201,204,75,215,40,72,44,74,204,5,138,20,21,107,90,3,0,145,9,166,203,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("8c92915f-e5da-4cc9-a75b-23b16899daa0"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("659edb1b-eb83-492e-906e-174f1c657aaa"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				ModifiedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,115,78,204,75,78,205,113,173,72,77,46,45,201,204,75,215,40,72,44,74,204,77,45,73,45,42,214,180,6,0,4,172,171,3,33,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("168b697c-dbbe-4939-8028-d0deee0595f6"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				CreatedInPackageId = new Guid("736f5080-fcc3-4dd4-bb55-19fa3135d61b"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEmailAddressesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("04ddcea2-90a9-4ebc-bfbb-681aed7f424f"),
				Name = "GetEmailAddresses",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7"),
				ResultValueTypeName = "List<string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fa9d1e8b-6004-4be2-8c8b-aa548c51f93e"),
				Name = "addresses",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,189,14,194,48,12,132,231,240,20,102,74,34,85,121,129,210,110,12,72,8,134,86,98,64,12,81,107,32,82,250,35,39,133,162,170,239,78,255,128,5,15,94,238,62,223,153,49,102,174,32,156,39,83,222,212,206,29,26,107,143,180,45,106,255,18,58,207,9,157,67,39,37,116,43,54,12,161,111,168,132,18,159,176,55,206,111,102,44,22,50,28,229,126,92,15,77,224,176,214,164,125,69,14,162,201,156,221,53,157,47,208,1,15,121,0,60,224,208,79,196,114,239,27,164,146,218,26,47,126,188,156,98,85,130,22,51,47,90,136,98,104,85,74,166,16,114,145,78,119,36,156,149,245,223,47,218,143,51,173,198,206,67,215,55,33,147,181,172,244,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSenderNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e0b5634f-d877-4119-918b-dc5cfd88082a"),
				Name = "GetSenderName",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3936f8ed-cd7d-4877-a97e-8287dfdebff2"),
				Name = "mailboxId",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,65,75,3,49,16,133,207,219,95,17,114,202,66,89,122,87,11,178,172,210,67,197,178,85,15,226,33,221,29,219,64,118,82,39,137,186,136,255,221,196,84,90,162,94,103,222,188,55,239,43,138,226,85,18,27,164,210,27,243,190,150,27,13,77,187,98,23,12,225,141,53,232,148,27,219,110,7,131,92,121,160,81,220,89,160,218,32,66,231,148,193,234,84,176,148,40,183,64,83,198,151,201,172,29,177,107,193,57,133,91,203,203,179,73,145,162,44,96,15,212,196,196,203,190,39,176,182,54,218,15,24,50,179,47,170,176,79,59,193,219,95,87,7,203,252,230,74,105,7,100,227,173,200,119,53,129,116,144,20,15,202,237,110,37,201,1,162,92,164,97,109,134,189,36,101,13,174,199,61,84,205,139,151,58,20,90,244,124,250,243,220,162,47,143,93,14,179,111,12,10,236,31,21,174,193,37,72,161,136,78,212,50,136,201,77,61,51,145,185,85,181,241,232,216,156,205,74,246,17,53,5,129,243,132,121,234,227,236,41,198,196,143,15,184,238,165,246,112,110,29,5,244,115,241,31,240,234,38,148,79,233,159,147,163,59,231,113,244,5,140,60,170,153,24,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetEmailAddressCollectionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("709cd145-3a06-4dcc-8a43-53922b618cb6"),
				Name = "GetEmailAddressCollection",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7"),
				ResultValueTypeName = "EmailAddressCollection"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("054d1b99-deca-435f-8f98-33358a1a0e33"),
				Name = "emailAddresses",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "IEnumerable<string>",
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,227,228,228,44,75,44,82,72,205,77,204,204,113,76,73,41,74,45,46,118,206,207,201,73,77,46,201,204,207,83,176,85,200,75,45,87,112,197,42,169,161,105,205,197,201,201,153,150,95,148,154,152,156,161,160,129,110,140,66,102,30,10,63,181,88,83,161,26,164,131,19,187,101,122,64,17,13,100,41,136,249,181,32,162,40,181,164,180,40,15,135,43,173,1,207,213,50,208,196,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSendEmailWithDefaultSenderMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("73174729-915c-4cae-b231-f5307bddd073"),
				Name = "SendEmailWithDefaultSender",
				CreatedInSchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"),
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("db83e8d6-f43b-4750-b22b-4bbb681baea7"),
				Name = "emailMessage",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EmailMessage",
				CreatedInPackageId = new Guid("280c479b-4214-48d2-8ad6-756cf8c224d7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,65,75,244,48,16,134,207,235,175,136,61,37,80,138,247,85,193,173,139,122,88,89,168,122,17,15,105,58,174,145,52,145,73,234,82,100,255,187,73,154,106,119,249,248,80,75,105,211,100,222,39,239,76,166,179,21,151,170,68,104,64,59,201,149,37,98,50,62,35,26,182,228,48,226,227,104,230,175,107,99,157,15,160,214,161,212,27,86,245,182,2,231,252,208,22,87,224,30,184,234,128,222,91,192,210,104,13,194,73,163,115,146,85,173,123,11,194,140,229,17,178,54,24,32,82,187,98,205,209,2,253,57,38,72,51,86,220,153,42,26,160,44,33,125,112,101,85,112,86,27,163,126,225,107,169,121,173,130,54,251,38,225,45,111,225,79,89,142,226,41,108,205,173,221,26,108,254,12,28,1,25,11,204,221,60,60,7,208,227,19,113,198,115,161,245,135,181,2,107,249,6,124,109,252,125,129,200,123,202,98,236,50,172,94,52,13,250,128,210,40,53,108,64,132,240,74,191,251,191,151,233,30,179,20,255,69,213,191,97,45,68,130,189,115,36,214,231,88,42,233,155,44,181,93,245,53,113,80,144,65,179,250,6,145,54,189,207,38,148,194,183,44,119,144,66,232,194,52,125,78,170,174,126,245,144,220,23,43,159,118,122,49,30,87,60,44,135,29,228,209,195,165,140,59,114,236,79,175,58,217,228,228,174,123,83,112,90,247,14,30,159,114,50,212,254,252,156,158,176,193,84,251,85,37,239,69,136,189,185,69,44,77,125,48,187,70,105,80,186,62,244,68,72,105,252,102,123,149,26,103,231,243,193,95,159,126,194,73,186,21,232,102,76,54,193,247,82,28,12,238,136,224,78,188,36,185,124,38,244,248,198,222,108,180,65,88,34,26,180,44,45,205,220,11,154,109,212,204,118,81,249,9,150,129,27,169,42,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SendEmailUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926"));
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
			return new SendEmailUserTask(userConnection) {
				SchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SendEmailUserTask

	[DesignModeGroup(Name = "General", Position = 1, UseSolutionStorage = true, ResourceManager = "b749e6e7cde44a2eade00b8cf36b0926", CaptionResourceItem = "Parameters.Sender.Group", DescriptionResourceItem = "Parameters.Sender.Group")]
	[DesignModeProperty(Name = "Sender", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b749e6e7cde44a2eade00b8cf36b0926", CaptionResourceItem = "Parameters.Sender.Caption", DescriptionResourceItem = "Parameters.Sender.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Recepient", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b749e6e7cde44a2eade00b8cf36b0926", CaptionResourceItem = "Parameters.Recepient.Caption", DescriptionResourceItem = "Parameters.Recepient.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CopyRecepient", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b749e6e7cde44a2eade00b8cf36b0926", CaptionResourceItem = "Parameters.CopyRecepient.Caption", DescriptionResourceItem = "Parameters.CopyRecepient.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "BlindCopyRecepient", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b749e6e7cde44a2eade00b8cf36b0926", CaptionResourceItem = "Parameters.BlindCopyRecepient.Caption", DescriptionResourceItem = "Parameters.BlindCopyRecepient.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Subject", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b749e6e7cde44a2eade00b8cf36b0926", CaptionResourceItem = "Parameters.Subject.Caption", DescriptionResourceItem = "Parameters.Subject.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Body", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b749e6e7cde44a2eade00b8cf36b0926", CaptionResourceItem = "Parameters.Body.Caption", DescriptionResourceItem = "Parameters.Body.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Importance", Group = "General", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b749e6e7cde44a2eade00b8cf36b0926", CaptionResourceItem = "Parameters.Importance.Caption", DescriptionResourceItem = "Parameters.Importance.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsIgnoreErrors", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "b749e6e7cde44a2eade00b8cf36b0926", CaptionResourceItem = "Parameters.IsIgnoreErrors.Caption", DescriptionResourceItem = "Parameters.IsIgnoreErrors.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SendEmailUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public SendEmailUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("b749e6e7-cde4-4a2e-ade0-0b8cf36b0926");
		}

		#endregion

		#region Properties: Public

		public  virtual Guid Sender {
			get;
			set;
		}

		public  virtual string Recepient {
			get;
			set;
		}

		public  virtual string CopyRecepient {
			get;
			set;
		}

		public  virtual string BlindCopyRecepient {
			get;
			set;
		}

		private LocalizableString _subject;
		public  virtual LocalizableString Subject {
			get {
				return _subject ?? (_subject = new LocalizableString());
			}
			set {
				_subject = value;
			}
		}

		private LocalizableString _body;
		public  virtual LocalizableString Body {
			get {
				return _body ?? (_body = new LocalizableString());
			}
			set {
				_body = value;
			}
		}

		private int _importance = 1;
		public  virtual int Importance {
			get {
				return _importance;
			}
			set {
				_importance = value;
			}
		}

		private bool _isIgnoreErrors = true;
		public  virtual bool IsIgnoreErrors {
			get {
				return _isIgnoreErrors;
			}
			set {
				_isIgnoreErrors = value;
			}
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
				if (Recepient == null) {
							return true;
						}
						var from = GetSenderName(Sender);
						List<string> recepients = GetEmailAddresses(Recepient);
						var emailPriority = (EmailPriority)Importance;
						List<string> ccRecipients = GetEmailAddresses(CopyRecepient);
						List<string> bccRecipients = GetEmailAddresses(BlindCopyRecepient);
						var message = new EmailMessage {
							From = from,
							To = recepients,
							Subject = Subject,
							Body = Body,
							Priority = emailPriority,
							Cc = ccRecipients,
							Bcc = bccRecipients
						};
						if (from.IsEmpty()) {
							SendEmailWithDefaultSender(message);
							return true;
						}
						var emailClientFactory = ClassFactory.Get<EmailClientFactory>(new ConstructorArgument("userConnection",
							UserConnection));
						var emailSender = new EmailSender(emailClientFactory, UserConnection);
						try {
							emailSender.Send(message);
						} catch {
							if (!IsIgnoreErrors) {
								throw;
							}
						}
						return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			return base.CompleteExecuting(parameters);
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
		}

		public override string GetExecutionData() {
			return string.Empty;
		}

		public virtual List<string> GetEmailAddresses(string addresses) {
						if (string.IsNullOrEmpty(addresses)) {
							return new List<string>();
						}
						var separators = new char[] { ';', ',' };
						return addresses.Split(separators)
							.Select(x => x.Trim())
							.Where(x => !string.IsNullOrEmpty(x))
							.ToList();
		}

		public virtual string GetSenderName(Guid mailboxId) {
						var mailboxTableESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "MailboxSyncSettings");
						var senderEmailAddressColumn = mailboxTableESQ.AddColumn("SenderEmailAddress");
						mailboxTableESQ.Filters.Add(mailboxTableESQ.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", mailboxId));
						var mailboxEntities = mailboxTableESQ.GetEntityCollection(UserConnection);
						if (mailboxEntities.Count > 0) {
							return mailboxEntities[0].GetTypedColumnValue<string>(senderEmailAddressColumn.Name);
						}
						return "";
					
		}

		public virtual EmailAddressCollection GetEmailAddressCollection(IEnumerable<string> emailAddresses) {
						var emailAddressCollection = new EmailAddressCollection();
						foreach (var emailAddress in emailAddresses) {
							emailAddressCollection.Add(emailAddress);
						}
						return emailAddressCollection;
		}

		public virtual void SendEmailWithDefaultSender(EmailMessage emailMessage) {
				MailCredentials credentials = new MailCredentials {
							Host = (string)SysSettings.GetValue(UserConnection, "SmtpHost"),
							Port = int.Parse(SysSettings.GetValue(UserConnection, "SmtpPort").ToString()),
							UseSsl = (bool)SysSettings.GetValue(UserConnection, "SmtpEnableSsl"),
							UserName = (string)SysSettings.GetValue(UserConnection, "SmtpUserName"),
							UserPassword = (string)SysSettings.GetValue(UserConnection, "SmtpUserPassword")
						};
						string[] to = emailMessage.To.ToArray();
						EmailAddressCollection cc = GetEmailAddressCollection(emailMessage.Cc);
						EmailAddressCollection bcc = GetEmailAddressCollection(emailMessage.Bcc);
						var smtpClient = new SmtpClient(UserConnection);
						MailMessage message = smtpClient.CreateMessage(Body, Subject, to, credentials.UserName,
						true, new Dictionary<Guid, Tuple<byte[], string>>(0));
						message.Cc = cc;
						message.Bcc = bcc;
						message.Priority = (MailPriority)emailMessage.Priority;;
						try {
							smtpClient.SendMessage(message, credentials);
						} catch {
							if (!IsIgnoreErrors) {
								throw;
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
			if (!HasMapping("Sender")) {
				writer.WriteValue("Sender", Sender, Guid.Empty);
			}
			if (!HasMapping("Recepient")) {
				writer.WriteValue("Recepient", Recepient, null);
			}
			if (!HasMapping("CopyRecepient")) {
				writer.WriteValue("CopyRecepient", CopyRecepient, null);
			}
			if (!HasMapping("BlindCopyRecepient")) {
				writer.WriteValue("BlindCopyRecepient", BlindCopyRecepient, null);
			}
			if (!HasMapping("Importance")) {
				writer.WriteValue("Importance", Importance, 0);
			}
			if (!HasMapping("IsIgnoreErrors")) {
				writer.WriteValue("IsIgnoreErrors", IsIgnoreErrors, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Sender":
					Sender = reader.GetGuidValue();
				break;
				case "Recepient":
					Recepient = reader.GetStringValue();
				break;
				case "CopyRecepient":
					CopyRecepient = reader.GetStringValue();
				break;
				case "BlindCopyRecepient":
					BlindCopyRecepient = reader.GetStringValue();
				break;
				case "Subject":
					Subject = reader.GetLocalizableStringValue();
				break;
				case "Body":
					Body = reader.GetLocalizableStringValue();
				break;
				case "Importance":
					Importance = reader.GetIntValue();
				break;
				case "IsIgnoreErrors":
					IsIgnoreErrors = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

