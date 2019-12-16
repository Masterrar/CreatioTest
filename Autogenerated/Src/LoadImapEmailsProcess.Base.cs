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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;

	#region Class: LoadImapEmailsProcessSchema

	/// <exclude/>
	public class LoadImapEmailsProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LoadImapEmailsProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LoadImapEmailsProcessSchema(LoadImapEmailsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LoadImapEmailsProcess";
			UId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,88,109,111,219,54,16,254,236,2,253,15,154,62,201,128,172,56,137,243,134,188,0,177,99,167,222,154,54,173,147,229,51,45,209,141,48,189,184,36,149,196,27,242,223,119,71,82,214,187,162,22,195,6,172,1,106,137,60,62,119,188,187,231,120,212,251,119,235,100,25,248,174,241,228,51,145,144,192,152,79,163,36,164,140,44,3,122,118,157,248,222,133,113,77,197,36,97,140,70,226,158,83,118,67,252,96,25,191,44,54,145,251,200,226,200,255,147,8,63,142,22,84,8,63,250,198,239,231,30,183,250,198,95,239,223,245,158,8,51,194,86,225,105,36,124,177,89,184,143,52,36,198,185,129,232,147,56,138,168,139,66,78,126,246,134,68,228,27,101,14,152,50,143,184,32,145,75,199,155,79,36,164,150,153,179,39,197,53,251,167,90,63,205,97,124,73,40,219,128,154,136,62,27,211,242,184,245,182,114,219,232,174,107,18,7,73,24,129,178,138,1,206,165,231,169,89,171,187,115,112,223,183,204,15,9,219,168,181,114,235,125,169,186,170,97,230,7,130,50,142,154,44,16,168,145,152,48,74,4,85,114,15,190,120,188,37,12,0,113,145,165,6,39,113,184,38,204,231,113,116,183,89,83,103,250,29,50,195,54,16,172,103,46,54,252,210,11,253,232,62,242,133,105,151,163,150,203,20,103,238,253,71,38,98,156,22,148,61,129,13,56,9,86,98,208,49,155,45,243,120,52,154,13,143,247,143,6,211,203,203,225,96,52,27,13,7,227,147,195,131,193,209,238,236,224,106,124,50,189,156,30,78,205,126,127,27,214,239,104,206,87,202,147,64,240,218,128,66,108,84,172,32,52,129,242,66,41,155,36,22,163,34,97,145,177,98,113,104,48,9,103,248,81,17,157,83,92,175,103,17,23,141,215,217,242,59,9,18,77,72,171,154,105,14,38,4,170,121,125,255,14,255,74,156,70,127,128,67,61,92,72,2,142,140,206,92,148,155,176,16,95,146,86,77,1,155,51,46,107,163,21,129,74,136,150,220,162,191,50,172,194,98,227,151,115,233,117,103,26,174,197,70,65,85,184,162,233,85,45,0,96,101,65,194,50,107,88,105,246,13,194,141,154,137,211,84,87,102,81,169,222,212,24,209,84,96,212,122,197,245,22,208,10,71,65,75,189,100,3,163,127,4,191,25,91,205,115,212,161,55,209,209,220,76,191,171,104,156,237,93,199,253,142,50,70,120,188,18,160,36,90,249,223,18,38,139,150,147,9,214,229,190,130,220,170,225,119,241,140,10,247,81,99,126,244,185,56,227,130,65,213,187,80,41,210,51,161,48,64,190,113,211,86,175,183,49,19,233,51,224,47,22,31,211,183,57,95,8,194,196,93,192,77,28,120,45,169,171,83,53,173,208,231,66,123,126,21,67,213,1,97,171,104,47,18,181,106,189,78,231,94,81,145,44,105,157,227,146,161,170,130,211,123,197,255,144,71,149,0,56,18,126,6,229,227,106,220,37,158,118,145,199,118,201,33,253,212,124,93,109,62,196,28,185,93,85,171,35,113,154,23,198,112,212,10,227,68,65,18,131,197,131,90,89,21,199,130,116,26,202,90,249,44,210,91,79,189,102,117,85,33,52,86,192,223,232,70,86,208,91,226,179,179,154,99,220,46,87,180,139,98,145,148,73,93,87,40,91,91,161,114,241,108,239,157,114,165,181,100,93,29,167,138,168,57,219,58,20,232,86,163,107,139,54,174,236,178,135,74,150,182,251,167,152,132,229,99,234,188,249,160,234,100,75,182,20,84,157,54,43,194,84,100,186,92,119,2,78,229,223,194,188,37,156,63,199,204,251,17,220,116,77,27,246,130,70,30,80,31,253,171,233,217,85,67,117,101,129,76,149,115,254,39,120,131,120,157,226,99,215,231,111,190,91,122,131,213,79,49,176,240,150,81,104,4,105,187,174,91,56,221,63,175,105,4,207,22,254,226,59,122,251,142,240,63,140,184,52,208,245,254,34,215,204,61,237,42,213,94,174,92,122,124,124,56,162,131,163,229,112,119,48,218,59,161,131,147,189,93,58,24,30,28,238,187,71,123,7,30,252,102,119,134,118,252,107,230,123,117,58,220,99,151,238,238,147,225,96,255,120,255,112,48,90,146,163,193,114,255,248,4,158,78,232,222,112,119,52,220,221,119,149,142,242,206,28,124,201,90,105,141,122,229,203,178,2,71,135,62,134,109,67,31,199,214,214,210,117,186,16,23,189,5,11,29,89,51,102,90,136,48,96,227,248,101,22,7,30,18,212,56,47,148,29,89,23,106,245,40,111,116,246,156,204,239,204,122,121,62,155,9,71,149,111,221,94,156,187,120,33,109,214,87,173,87,131,6,156,202,228,48,126,222,182,54,187,24,117,129,250,210,50,93,250,0,103,238,149,125,213,175,88,86,23,107,204,115,144,214,237,172,180,44,125,209,250,43,75,224,65,187,224,18,28,242,68,113,18,150,9,150,208,70,18,102,45,225,253,220,121,160,75,112,167,96,49,84,169,237,195,13,148,25,185,209,136,6,122,95,82,109,126,188,248,209,32,210,138,225,174,41,104,136,168,206,7,33,214,136,72,95,68,26,38,231,3,137,188,0,122,83,200,183,70,43,16,105,75,183,156,66,45,0,74,90,151,194,85,53,242,244,200,120,51,9,124,208,59,151,29,158,180,209,54,204,49,225,133,157,64,236,208,95,253,58,165,152,28,53,54,180,217,95,235,197,92,137,12,139,195,45,133,114,241,24,63,79,61,95,164,137,168,1,181,231,119,118,106,140,109,12,214,105,121,5,8,43,126,59,179,152,133,68,88,159,40,245,22,180,225,8,208,96,182,241,118,213,190,207,243,208,28,155,125,173,59,111,41,146,39,221,77,23,189,69,204,79,102,223,6,102,172,164,221,32,52,33,107,252,177,211,173,73,133,150,149,171,104,88,167,182,245,172,175,65,121,95,114,184,68,85,219,232,98,80,137,207,45,65,188,138,159,163,32,38,158,60,194,57,54,90,90,97,161,37,205,183,158,188,220,60,149,251,170,114,111,155,97,56,242,236,199,237,11,182,81,173,90,194,193,74,117,65,146,247,139,237,118,182,87,196,155,210,112,169,121,181,171,6,105,194,232,102,112,103,167,93,71,254,10,202,128,159,196,21,49,243,41,48,37,128,214,73,189,202,175,50,103,101,75,224,56,75,27,206,50,174,51,143,124,209,217,210,211,122,12,124,153,135,100,141,122,245,141,178,151,38,199,36,78,34,145,94,217,243,139,190,210,48,22,116,242,72,162,84,42,235,200,12,151,224,221,213,66,208,233,139,75,101,94,26,20,54,209,83,158,250,81,202,234,37,207,132,97,39,164,19,93,199,237,75,66,57,190,166,135,65,249,210,225,60,20,86,105,184,38,26,22,85,216,6,117,50,206,171,7,249,217,78,99,42,227,58,115,108,155,161,57,220,154,35,177,158,70,146,39,133,211,85,142,172,210,179,53,71,156,64,187,102,33,63,204,149,29,130,38,235,59,125,253,103,104,56,28,224,40,87,114,200,212,134,143,213,114,254,35,93,137,207,9,116,79,191,198,62,192,201,227,23,46,246,170,140,152,125,231,115,117,16,224,241,18,162,0,122,112,63,150,223,64,27,77,209,195,217,18,231,225,145,50,90,7,139,86,111,241,244,23,198,109,123,103,109,61,37,63,189,41,223,160,199,115,180,245,150,211,23,234,38,192,196,186,239,250,60,97,244,106,156,13,165,180,52,224,159,62,213,192,247,142,130,160,11,151,4,132,233,79,159,25,112,123,144,85,222,228,194,92,189,248,88,255,108,164,171,10,254,127,145,47,183,161,255,106,2,164,87,146,134,20,248,27,26,173,190,89,201,26,0,0 };
			RealUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
			Version = 0;
			PackageUId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97");
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4fe53caa-18f6-4c4b-b63b-d475fe7b8a0f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"PageInstanceId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b9ae9fb7-09a7-4689-89fe-c1c439f10368"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"ActiveTreeGridCurrentRowId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentUserMailboxSynchronizationSettingsUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ff591096-1b06-47b0-a988-cbd658b46fef"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"CurrentUserMailboxSynchronizationSettingsUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMailboxSynchronizationSettingsPageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("be94aa4b-5b04-442f-88b6-6841d5c40218"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"MailboxSynchronizationSettingsPageUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"fce8864e-7b01-429e-921e-0563c725d563",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetMailboxSynchronizationMessageUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9891be68-d59b-4533-9be3-85e194af599f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"NeedSetMailboxSynchronizationMessageUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"{E9D59B5B-D6D0-47D6-9F8E-C475806C019C}",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMailBoxFolderIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3be2837e-0163-4330-836b-ffca8a2909be"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"MailBoxFolderId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("532cb61b-8379-42bc-9a48-99fd98f7801b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadResult",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMessagesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("574326c8-1b08-4af9-9e49-7da640ea2c9e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"Messages",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMessagesCountParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("562516d4-4d62-4421-b65f-3924fb92a101"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"MessagesCount",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9df9ed0b-1c24-40f3-94dc-f7cfa995d7db"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"SenderEmailAddress",
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetMailboxSynchronizationMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("21444bbc-5fee-4669-9cb3-26a7af386911"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"NeedSetMailboxSynchronizationMessage",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateInformationCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c7cc5b5d-0efd-428c-80d5-c6feea55dec6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"InformationCaption",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSuccessLoadEmailsMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e255669d-4628-4d24-b91e-f4e34a99cc0a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"SuccessLoadEmailsMessage",
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
			Parameters.Add(CreateCurrentUserMailboxSynchronizationSettingsUIdParameter());
			Parameters.Add(CreateMailboxSynchronizationSettingsPageUIdParameter());
			Parameters.Add(CreateNeedSetMailboxSynchronizationMessageUIdParameter());
			Parameters.Add(CreateMailBoxFolderIdParameter());
			Parameters.Add(CreateLoadResultParameter());
			Parameters.Add(CreateMessagesParameter());
			Parameters.Add(CreateMessagesCountParameter());
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateNeedSetMailboxSynchronizationMessageParameter());
			Parameters.Add(CreateInformationCaptionParameter());
			Parameters.Add(CreateSuccessLoadEmailsMessageParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLoadImapEmailsUserTaskLaneSet = CreateLoadImapEmailsUserTaskLaneSetLaneSet();
			LaneSets.Add(schemaLoadImapEmailsUserTaskLaneSet);
			ProcessSchemaLane schemaLoadImapEmailsUserTaskLane = CreateLoadImapEmailsUserTaskLaneLane();
			schemaLoadImapEmailsUserTaskLaneSet.Lanes.Add(schemaLoadImapEmailsUserTaskLane);
			ProcessSchemaStartEvent loadimapemailsusertaskstart = CreateLoadImapEmailsUserTaskStartStartEvent();
			FlowElements.Add(loadimapemailsusertaskstart);
			ProcessSchemaEndEvent loadimapemailsusertaskend = CreateLoadImapEmailsUserTaskEndEndEvent();
			FlowElements.Add(loadimapemailsusertaskend);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("336acfd9-6be3-4f8e-9ee0-842af3c10118"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				CurveCenterPosition = new Point(374, 210),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fb4cf670-1ecc-4fbe-ad34-44ab952d9f62"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("4fcbcae3-6713-47fc-ade0-561c841d572b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				CurveCenterPosition = new Point(440, 212),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("279c7f52-7577-4bf9-a283-8d6621415e69"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLoadImapEmailsUserTaskLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaLoadImapEmailsUserTaskLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("21cd00c5-c917-4b96-a25b-d555ef360329"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskLaneSet",
				Position = new Point(5, 5),
				Size = new Size(0, 0)
			};
			return schemaLoadImapEmailsUserTaskLaneSet;
		}

		protected virtual ProcessSchemaLane CreateLoadImapEmailsUserTaskLaneLane() {
			ProcessSchemaLane schemaLoadImapEmailsUserTaskLane = new ProcessSchemaLane(this) {
				UId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("21cd00c5-c917-4b96-a25b-d555ef360329"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskLane",
				Position = new Point(29, 0),
				Size = new Size(0, 0)
			};
			return schemaLoadImapEmailsUserTaskLane;
		}

		protected virtual ProcessSchemaStartEvent CreateLoadImapEmailsUserTaskStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("fb4cf670-1ecc-4fbe-ad34-44ab952d9f62"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskStart",
				Position = new Point(50, 191),
				SerializeToDB = false,
				Size = new Size(27, 27)
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateLoadImapEmailsUserTaskEndEndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("279c7f52-7577-4bf9-a283-8d6621415e69"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"LoadImapEmailsUserTaskEnd",
				Position = new Point(547, 191),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a105506e-8d97-4c59-8fb8-a2e5b037ce28"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"),
				Name = @"ScriptTask1",
				Position = new Point(267, 177),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,147,95,111,155,48,20,197,159,83,169,223,225,150,135,10,180,128,64,107,166,238,79,38,173,129,84,209,154,86,106,212,189,44,123,240,194,109,98,9,236,201,54,77,179,136,239,62,27,27,200,162,110,125,195,230,222,115,127,231,112,153,163,148,100,141,18,198,192,112,11,41,93,41,202,25,17,187,79,215,21,205,135,32,149,160,108,253,217,15,62,158,158,60,17,1,130,115,149,149,132,22,83,94,228,40,102,185,107,52,213,190,151,92,38,211,247,233,219,139,112,148,102,89,152,197,73,18,126,185,124,119,21,198,113,50,26,165,241,197,36,78,82,207,72,209,71,240,231,90,229,138,63,247,66,227,70,37,202,202,95,106,23,192,254,244,100,176,216,240,109,150,83,181,64,165,52,134,156,91,218,134,102,32,80,85,130,129,18,21,234,99,109,69,95,224,27,195,209,36,171,109,220,208,220,24,191,70,53,169,132,64,166,30,36,10,83,252,147,63,47,118,108,181,17,156,209,223,196,36,210,18,60,204,114,105,199,155,105,186,63,154,240,138,41,63,48,115,98,171,252,127,108,13,58,120,228,2,201,106,227,91,6,160,204,144,184,230,148,111,89,193,73,222,184,144,83,193,75,135,175,167,181,2,53,96,33,177,179,81,90,228,230,99,104,51,243,246,120,28,113,199,221,55,156,29,134,14,231,231,240,215,43,86,21,197,171,88,93,135,165,235,209,94,205,161,182,59,85,246,59,104,215,205,210,232,162,195,156,92,149,9,203,255,215,154,6,110,130,203,178,19,126,211,41,79,185,40,137,242,189,253,126,233,209,124,233,125,128,165,183,143,235,165,55,212,15,174,222,221,38,250,182,174,135,250,141,187,143,190,226,174,63,124,35,69,133,65,191,121,103,110,194,76,222,234,212,238,68,227,193,111,17,130,35,162,113,231,58,186,199,146,63,97,87,25,221,32,91,171,13,132,144,56,245,27,29,251,61,202,170,80,240,130,15,141,218,186,54,224,223,181,155,31,80,215,61,182,52,50,135,63,203,31,235,249,231,92,244,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("276b5906-88fa-4d43-a6ea-8d6213245d72"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3e068d19-8d8c-4768-b6a9-83bd4995c9bc"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b6da2fd2-6cc9-4667-ab57-4f614f3fc9ca"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ef7eb62b-f609-42c2-af07-585c5670410d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LoadImapEmailsProcess(userConnection);
		}

		public override object Clone() {
			return new LoadImapEmailsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f9740b2-eaba-4296-af86-64b5692d7435"));
		}

		#endregion

	}

	#endregion

	#region Class: LoadImapEmailsProcess

	/// <exclude/>
	public class LoadImapEmailsProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLoadImapEmailsUserTaskLane

		/// <exclude/>
		public class ProcessLoadImapEmailsUserTaskLane : ProcessLane
		{

			public ProcessLoadImapEmailsUserTaskLane(UserConnection userConnection, LoadImapEmailsProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public LoadImapEmailsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LoadImapEmailsProcess";
			SchemaUId = new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("2f9740b2-eaba-4296-af86-64b5692d7435");
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

		public  virtual string PageInstanceId {
			get;
			set;
		}

		public  virtual Guid ActiveTreeGridCurrentRowId {
			get;
			set;
		}

		public  virtual Guid CurrentUserMailboxSynchronizationSettingsUId {
			get;
			set;
		}

		private Guid _mailboxSynchronizationSettingsPageUId = new Guid("fce8864e-7b01-429e-921e-0563c725d563");
		public  Guid MailboxSynchronizationSettingsPageUId {
			get {
				return _mailboxSynchronizationSettingsPageUId;
			}
			set {
				_mailboxSynchronizationSettingsPageUId = value;
			}
		}

		private Guid _needSetMailboxSynchronizationMessageUId = new Guid("{E9D59B5B-D6D0-47D6-9F8E-C475806C019C}");
		public  Guid NeedSetMailboxSynchronizationMessageUId {
			get {
				return _needSetMailboxSynchronizationMessageUId;
			}
			set {
				_needSetMailboxSynchronizationMessageUId = value;
			}
		}

		public  virtual Guid MailBoxFolderId {
			get;
			set;
		}

		public  virtual string LoadResult {
			get;
			set;
		}

		public  virtual Object Messages {
			get;
			set;
		}

		public  virtual int MessagesCount {
			get;
			set;
		}

		public  virtual string SenderEmailAddress {
			get;
			set;
		}

		private LocalizableString _needSetMailboxSynchronizationMessage;
		public  virtual LocalizableString NeedSetMailboxSynchronizationMessage {
			get {
				return _needSetMailboxSynchronizationMessage ?? (_needSetMailboxSynchronizationMessage = GetLocalizableString("2f9740b2eaba4296af8664b5692d7435",
						 "Parameters.NeedSetMailboxSynchronizationMessage.Value"));
			}
			set {
				_needSetMailboxSynchronizationMessage = value;
			}
		}

		private LocalizableString _informationCaption;
		public  virtual LocalizableString InformationCaption {
			get {
				return _informationCaption ?? (_informationCaption = GetLocalizableString("2f9740b2eaba4296af8664b5692d7435",
						 "Parameters.InformationCaption.Value"));
			}
			set {
				_informationCaption = value;
			}
		}

		private LocalizableString _successLoadEmailsMessage;
		public  virtual LocalizableString SuccessLoadEmailsMessage {
			get {
				return _successLoadEmailsMessage ?? (_successLoadEmailsMessage = GetLocalizableString("2f9740b2eaba4296af8664b5692d7435",
						 "Parameters.SuccessLoadEmailsMessage.Value"));
			}
			set {
				_successLoadEmailsMessage = value;
			}
		}

		private ProcessLoadImapEmailsUserTaskLane _loadImapEmailsUserTaskLane;
		public  ProcessLoadImapEmailsUserTaskLane LoadImapEmailsUserTaskLane {
			get {
				return _loadImapEmailsUserTaskLane ?? ((_loadImapEmailsUserTaskLane) = new ProcessLoadImapEmailsUserTaskLane(UserConnection, this));
			}
		}

		private ProcessFlowElement _loadImapEmailsUserTaskStart;
		public  ProcessFlowElement LoadImapEmailsUserTaskStart {
			get {
				return _loadImapEmailsUserTaskStart ?? (_loadImapEmailsUserTaskStart = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "LoadImapEmailsUserTaskStart",
					SchemaElementUId = new Guid("fb4cf670-1ecc-4fbe-ad34-44ab952d9f62"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessEndEvent _loadImapEmailsUserTaskEnd;
		public  ProcessEndEvent LoadImapEmailsUserTaskEnd {
			get {
				return _loadImapEmailsUserTaskEnd ?? (_loadImapEmailsUserTaskEnd = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "LoadImapEmailsUserTaskEnd",
					SchemaElementUId = new Guid("279c7f52-7577-4bf9-a283-8d6621415e69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public  ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("9ddd22ce-1f21-454f-8dff-aa6510f4434e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[LoadImapEmailsUserTaskStart.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadImapEmailsUserTaskStart };
			FlowElements[LoadImapEmailsUserTaskEnd.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadImapEmailsUserTaskEnd };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "LoadImapEmailsUserTaskStart":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "LoadImapEmailsUserTaskEnd":
						CompleteProcess();
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LoadImapEmailsUserTaskEnd", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (!HasMapping("ActiveTreeGridCurrentRowId")) {
				writer.WriteValue("ActiveTreeGridCurrentRowId", ActiveTreeGridCurrentRowId, Guid.Empty);
			}
			if (!HasMapping("CurrentUserMailboxSynchronizationSettingsUId")) {
				writer.WriteValue("CurrentUserMailboxSynchronizationSettingsUId", CurrentUserMailboxSynchronizationSettingsUId, Guid.Empty);
			}
			if (!HasMapping("MailboxSynchronizationSettingsPageUId")) {
				writer.WriteValue("MailboxSynchronizationSettingsPageUId", MailboxSynchronizationSettingsPageUId, Guid.Empty);
			}
			if (!HasMapping("NeedSetMailboxSynchronizationMessageUId")) {
				writer.WriteValue("NeedSetMailboxSynchronizationMessageUId", NeedSetMailboxSynchronizationMessageUId, Guid.Empty);
			}
			if (!HasMapping("MailBoxFolderId")) {
				writer.WriteValue("MailBoxFolderId", MailBoxFolderId, Guid.Empty);
			}
			if (!HasMapping("LoadResult")) {
				writer.WriteValue("LoadResult", LoadResult, null);
			}
			if (Messages != null) {
				if (Messages.GetType().IsSerializable ||
					Messages.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Messages", Messages, null);
				}
			}
			if (!HasMapping("MessagesCount")) {
				writer.WriteValue("MessagesCount", MessagesCount, 0);
			}
			if (!HasMapping("SenderEmailAddress")) {
				writer.WriteValue("SenderEmailAddress", SenderEmailAddress, null);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("LoadImapEmailsUserTaskStart", string.Empty));
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
			MetaPathParameterValues.Add("4fe53caa-18f6-4c4b-b63b-d475fe7b8a0f", () => PageInstanceId);
			MetaPathParameterValues.Add("b9ae9fb7-09a7-4689-89fe-c1c439f10368", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("ff591096-1b06-47b0-a988-cbd658b46fef", () => CurrentUserMailboxSynchronizationSettingsUId);
			MetaPathParameterValues.Add("be94aa4b-5b04-442f-88b6-6841d5c40218", () => MailboxSynchronizationSettingsPageUId);
			MetaPathParameterValues.Add("9891be68-d59b-4533-9be3-85e194af599f", () => NeedSetMailboxSynchronizationMessageUId);
			MetaPathParameterValues.Add("3be2837e-0163-4330-836b-ffca8a2909be", () => MailBoxFolderId);
			MetaPathParameterValues.Add("532cb61b-8379-42bc-9a48-99fd98f7801b", () => LoadResult);
			MetaPathParameterValues.Add("574326c8-1b08-4af9-9e49-7da640ea2c9e", () => Messages);
			MetaPathParameterValues.Add("562516d4-4d62-4421-b65f-3924fb92a101", () => MessagesCount);
			MetaPathParameterValues.Add("9df9ed0b-1c24-40f3-94dc-f7cfa995d7db", () => SenderEmailAddress);
			MetaPathParameterValues.Add("21444bbc-5fee-4669-9cb3-26a7af386911", () => NeedSetMailboxSynchronizationMessage);
			MetaPathParameterValues.Add("c7cc5b5d-0efd-428c-80d5-c6feea55dec6", () => InformationCaption);
			MetaPathParameterValues.Add("e255669d-4628-4d24-b91e-f4e34a99cc0a", () => SuccessLoadEmailsMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PageInstanceId":
					if (!hasValueToRead) break;
					PageInstanceId = reader.GetValue<System.String>();
				break;
				case "ActiveTreeGridCurrentRowId":
					if (!hasValueToRead) break;
					ActiveTreeGridCurrentRowId = reader.GetValue<System.Guid>();
				break;
				case "CurrentUserMailboxSynchronizationSettingsUId":
					if (!hasValueToRead) break;
					CurrentUserMailboxSynchronizationSettingsUId = reader.GetValue<System.Guid>();
				break;
				case "MailboxSynchronizationSettingsPageUId":
					if (!hasValueToRead) break;
					MailboxSynchronizationSettingsPageUId = reader.GetValue<System.Guid>();
				break;
				case "NeedSetMailboxSynchronizationMessageUId":
					if (!hasValueToRead) break;
					NeedSetMailboxSynchronizationMessageUId = reader.GetValue<System.Guid>();
				break;
				case "MailBoxFolderId":
					if (!hasValueToRead) break;
					MailBoxFolderId = reader.GetValue<System.Guid>();
				break;
				case "LoadResult":
					if (!hasValueToRead) break;
					LoadResult = reader.GetValue<System.String>();
				break;
				case "Messages":
					if (!hasValueToRead) break;
					Messages = reader.GetSerializableObjectValue();
				break;
				case "MessagesCount":
					if (!hasValueToRead) break;
					MessagesCount = reader.GetValue<System.Int32>();
				break;
				case "SenderEmailAddress":
					if (!hasValueToRead) break;
					SenderEmailAddress = reader.GetValue<System.String>();
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
			Messages = new Dictionary<Guid, string>();
			var rootEmailFolderId = new Guid("181F9D34-5DEE-E011-A86B-00155D04C01D");
			if (MailBoxFolderId == Guid.Empty) {
				ShowEditSettingsMessage();
				return true;
			}
			if (rootEmailFolderId == MailBoxFolderId) {
				var ids = GetCurrentUserMailboxSynchronizationSettingsUIds();
				if (ids.Count() == 0) {
					ShowEditSettingsMessage();
				}
				foreach(var id in ids) {
					DownloadEmailsFromMailBox(id);
				}
			} else {
				var mailboxId = GetMailboxId(MailBoxFolderId);
				if (mailboxId != Guid.Empty && mailboxId != null) {
					DownloadEmailsFromMailBox(mailboxId);
				} else {
					ShowEditSettingsMessage();
				}
			}
			var messages = string.Empty;
			foreach(var message in (Dictionary<Guid, string>)Messages) {
				messages += string.Format("{{\"id\": \"{0}\", \"message\": \"{1}\"}},", message.Key, message.Value);
			}
			if (!string.IsNullOrEmpty(messages)) {
				messages = messages.Remove(messages.Length - 1);
			}
			LoadResult = string.Format("{{ \"Messages\": [{0}] }}", messages);
			return true;
		}

			
			public virtual IEnumerable<Guid> GetCurrentUserMailboxSynchronizationSettingsUIds() {
				var mailboxSynchronizationSettingsEntitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("MailboxSyncSettings");
				var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "MailboxSyncSettings");
				var entitySchemaColumn = entitySchemaQuery.AddColumn(mailboxSynchronizationSettingsEntitySchema.GetPrimaryColumnName());
				entitySchemaQuery.Filters.Add(
					entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						"SysAdminUnit", UserConnection.CurrentUser.Id));
				entitySchemaQuery.Filters.Add(
					entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
						"MailServer.Type", new Guid("844F0837-EAA0-4F40-B965-71F5DB9EAE6E")));
				var queryResults = entitySchemaQuery.GetEntityCollection(UserConnection);
				return from result in queryResults select result.GetTypedColumnValue<Guid>(entitySchemaColumn.Name);
			}
			
			
			public virtual MailCredentials GetMailServerCredentials(Guid mailServerUId) {
				var result = new MailCredentials();
				if (mailServerUId != Guid.Empty) {
					var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
					var mailServerEntitySchema = entitySchemaManager.GetInstanceByName("MailServer");
					var mailServerEntitySchemaPrimaryColumnName = mailServerEntitySchema.GetPrimaryColumnName();
					var mailServerEntitySchemaPrimaryColumn = mailServerEntitySchema.Columns.GetByName(mailServerEntitySchemaPrimaryColumnName);
					var currentMailServer = new Terrasoft.Configuration.MailServer(UserConnection);
					var columnNamesToFetch = new List<string> {
						"Address",
						"Port",
						"UseSSL",
						"IsStartTls"
					};
					var columnsToFetch = new List<EntitySchemaColumn>();
					foreach (var columnName in columnNamesToFetch) {
						columnsToFetch.Add(mailServerEntitySchema.Columns.GetByName(columnName));
					}
					if (currentMailServer.FetchFromDB(mailServerEntitySchemaPrimaryColumn, mailServerUId, columnsToFetch)) {
						result.Host = currentMailServer.Address;
						result.Port = currentMailServer.Port;
						result.UseSsl = currentMailServer.UseSSL;
						result.StartTls = currentMailServer.IsStartTls;
					}
				}
				return result;
			}
			
			
			public virtual KeyValuePair<MailboxSyncSettings, MailCredentials> GetMailServerUserCredentials(Guid mailboxSynchronizationSettingsUId) {
				var resultMailboxSynchronizationSettings = new MailboxSyncSettings(UserConnection);
				var resultMailCredentials= new MailCredentials();
				if (mailboxSynchronizationSettingsUId != Guid.Empty) {
					if (resultMailboxSynchronizationSettings.FetchFromDB(mailboxSynchronizationSettingsUId)) {
						resultMailCredentials = GetMailServerCredentials(resultMailboxSynchronizationSettings.MailServerId);
						resultMailCredentials.UserName = resultMailboxSynchronizationSettings.UserName;
						resultMailCredentials.UserPassword = resultMailboxSynchronizationSettings.UserPassword;
						resultMailCredentials.SenderEmailAddress = resultMailboxSynchronizationSettings.SenderEmailAddress;
					}
				}
				var result = new KeyValuePair<MailboxSyncSettings, MailCredentials> 
					(resultMailboxSynchronizationSettings, resultMailCredentials);
				return result;
			}
			
			
			public virtual void PrepareMailboxSynchronizationSettingsPageOpening(OpenPageUserTask openPageUserTask) {
				var mailboxSynchronizationSettingsPageUId = new Guid("fce8864e-7b01-429e-921e-0563c725d563");
				var mailboxSynchronizationSettingsGridPageUId = new Guid("c8ce13a0-3836-4ba7-b389-4b9e2014013c");
				openPageUserTask.PageParameters = new Dictionary<string, string>();
				var pageParams = openPageUserTask.PageParameters as Dictionary<string, string>;
				if (MailBoxFolderId == Guid.Empty){
					openPageUserTask.PageUId = mailboxSynchronizationSettingsGridPageUId;
					pageParams.Add("userId", UserConnection.CurrentUser.Id.ToString());
				} else {
				 	openPageUserTask.PageUId = mailboxSynchronizationSettingsPageUId;
					pageParams.Add("recordId", GetMailboxId(MailBoxFolderId).ToString());
				}
				openPageUserTask.OpenerInstanceId = InstanceUId;
				openPageUserTask.UseCurrentActivePage = true;
			}
			
			
			public virtual Terrasoft.UI.WebControls.Controls.MessagePanel GetMainPageMessagePanel() {
				var mainPage = System.Web.HttpContext.Current.Handler as Terrasoft.UI.WebControls.Page;
				var messagePanelControl = Terrasoft.UI.WebControls.Page.FindControlByClientId(mainPage, "BaseMessagePanel", true);
				var messagePanel = messagePanelControl as Terrasoft.UI.WebControls.Controls.MessagePanel;
				return messagePanel;
			}
			
			
			public virtual void ShowEditSettingsMessage() {
				//var messagePanel = GetMainPageMessagePanel();
				//var message = string.Format(NeedSetMailboxSynchronizationMessage, MailboxSynchronizationSettingsPageUId.ToString("B"));
				//messagePanel.AddMessage(NeedSetMailboxSynchronizationMessageUId.ToString("N"), InformationCaption, message);
				((Dictionary<Guid, string>)Messages).Add(MailBoxFolderId, NeedSetMailboxSynchronizationMessage.ToString());
			}
			
			
			public virtual void DownloadEmailsFromMailBox(Guid mailboxId) {
				var serverCredentials = GetMailServerUserCredentials(mailboxId).Value;
				try {
					using (var mailSynchronizer = new MailSynchronizer(UserConnection, serverCredentials, true)) {
					//using (var mailSynchronizer = Terrasoft.Core.Factories.ClassFactory.Get<MailSynchronizer>()) {
						mailSynchronizer.Init(UserConnection, serverCredentials, true);
						mailSynchronizer.SyncImapMail();
						MessagesCount = mailSynchronizer.RemoteChangesCount;
					}
				} catch (ImapException e) {	
					//var messagePanel = GetMainPageMessagePanel();
					//var warningCaption = new QuestionUserTask(UserConnection).WarningCaption;
					//messagePanel.AddMessage(warningCaption, e.Message, MessageType.Warning);
					((Dictionary<Guid, string>)Messages).Add(mailboxId, e.Message.ToString());
				}
			}
			
			
			public virtual Guid GetMailboxId(Guid folderId) {
				var sel = new Select(UserConnection)
					.Column("MailboxSyncSettings", "Id")
					.From("MailboxSyncSettings")
					.LeftOuterJoin("ActivityFolder").On("ActivityFolder", "Name")
						.IsEqual("MailboxSyncSettings", "MailboxName")
					.Where("ActivityFolder", "Id").IsEqual(Column.Parameter(folderId)) as Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				    return sel.ExecuteScalar<Guid>(dbExecutor);
				}
			}
			
			
			public virtual string GetMailboxSenderEmailAddress() {
				var sel = new Select(UserConnection)
					.Column("MailboxSyncSettings", "SenderEmailAddress")
					.From("MailboxSyncSettings")
					.LeftOuterJoin("ActivityFolder").On("ActivityFolder", "Name")
						.IsEqual("MailboxSyncSettings", "MailboxName")
					.Where("ActivityFolder", "Id").IsEqual(Column.Parameter(MailBoxFolderId)) as Select;
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				    return sel.ExecuteScalar<string>(dbExecutor);
				}
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
			var cloneItem = (LoadImapEmailsProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.Messages = Messages;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

