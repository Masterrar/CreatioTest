﻿namespace Terrasoft.Core.Process
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

	#region Class: LeadManagement78Schema

	/// <exclude/>
	public class LeadManagement78Schema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LeadManagement78Schema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LeadManagement78Schema(LeadManagement78Schema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LeadManagement78";
			UId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5");
			CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08");
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
			Tag = @"LeadManagement78";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5");
			Version = 0;
			PackageUId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb");
		}

		protected virtual ProcessSchemaParameter CreateLeadIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dcaf025e-49c8-42ea-8f2d-0ffad1fb7e33"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"LeadId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup"),
			};
		}

		protected virtual ProcessSchemaParameter CreateShowDistributionPageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("76349b0a-e191-4050-abc2-0ee4dd58c60f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"ShowDistributionPage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLeadIdParameter());
			Parameters.Add(CreateShowDistributionPageParameter());
		}

		protected virtual void InitializeQualificationSubProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var leadIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("6a02c7ac-f88e-4d98-ad0b-0a80752dc15e"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadIdParameter.SourceValue = new ProcessSchemaParameterValue(leadIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{dcaf025e-49c8-42ea-8f2d-0ffad1fb7e33}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(leadIdParameter);
			var accountIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				UId = new Guid("0c30db4d-e0b5-49a8-8e34-213faa727629"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"AccountId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			accountIdParameter.SourceValue = new ProcessSchemaParameterValue(accountIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(accountIdParameter);
			var contactIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("3165a642-cb3e-4a83-b0e1-798fe6b07acf"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"ContactId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			contactIdParameter.SourceValue = new ProcessSchemaParameterValue(contactIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(contactIdParameter);
			var leadAddressTypeParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("50837bfc-43ff-466b-94bb-de0847eecd1b"),
				UId = new Guid("fba88d70-5de2-44c5-93f4-cc452e20c363"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAddressType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadAddressTypeParameter.SourceValue = new ProcessSchemaParameterValue(leadAddressTypeParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadAddressTypeParameter);
			var leadCityParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("19118434-012e-4446-8e6c-28a3e684b371"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadCity",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadCityParameter.SourceValue = new ProcessSchemaParameterValue(leadCityParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadCityParameter);
			var leadZipParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2ec8157d-f152-477f-ae87-4a49d651570b"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadZip",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			leadZipParameter.SourceValue = new ProcessSchemaParameterValue(leadZipParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{e1f35c38-67f2-4da3-a3f6-d4294aada246}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadZipParameter);
			var leadRegionParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("422678c2-6295-4e50-815a-cc20ab495eae"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadRegion",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadRegionParameter.SourceValue = new ProcessSchemaParameterValue(leadRegionParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadRegionParameter);
			var leadCountryParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5ea496ee-a83b-43ae-b366-0d2117f520f5"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadCountry",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadCountryParameter.SourceValue = new ProcessSchemaParameterValue(leadCountryParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadCountryParameter);
			var leadWebsiteParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("46363fb8-30a1-495c-86b7-9ba73723a8a2"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadWebsite",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			leadWebsiteParameter.SourceValue = new ProcessSchemaParameterValue(leadWebsiteParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{e753916c-14d1-4213-bb77-9334d5e6bf7f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadWebsiteParameter);
			var leadFaxParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("53e00707-d204-46e3-a09e-0af83330c855"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadFax",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			leadFaxParameter.SourceValue = new ProcessSchemaParameterValue(leadFaxParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{75485248-dedd-4fa5-ace4-787e2d097627}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadFaxParameter);
			var leadBusinessPhoneParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4fd2acc3-4c17-4805-bdff-0f7b1984f95f"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadBusinessPhone",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			leadBusinessPhoneParameter.SourceValue = new ProcessSchemaParameterValue(leadBusinessPhoneParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{94a3a853-08cb-485f-89f4-182878a5aaeb}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadBusinessPhoneParameter);
			var leadEmailParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("359e3a5d-0f44-42e9-bef1-441160b2ab00"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadEmail",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			leadEmailParameter.SourceValue = new ProcessSchemaParameterValue(leadEmailParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{fee32d81-7e24-4a34-91c7-3083e4d4938f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadEmailParameter);
			var leadMobilePhoneParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f8b7046b-d813-4939-b8c1-06adebe9267d"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadMobilePhone",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			leadMobilePhoneParameter.SourceValue = new ProcessSchemaParameterValue(leadMobilePhoneParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{40fef1d9-f9d9-4246-a90f-389e256aacd4}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadMobilePhoneParameter);
			var leadDecisionRoleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("cf8d5f0a-6818-40d4-9e32-0368b74bb2e6"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadDecisionRole",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadDecisionRoleParameter.SourceValue = new ProcessSchemaParameterValue(leadDecisionRoleParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadDecisionRoleParameter);
			var leadGenderParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("086038af-8c86-436c-893f-9eecfdc7fb1f"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadGender",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadGenderParameter.SourceValue = new ProcessSchemaParameterValue(leadGenderParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadGenderParameter);
			var leadDepartmentParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4312da27-20e3-4d72-99c4-c8f1de49f49f"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadDepartment",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadDepartmentParameter.SourceValue = new ProcessSchemaParameterValue(leadDepartmentParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadDepartmentParameter);
			var leadJobParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("48420f80-50bd-4d72-b1d0-5e30d558cb6e"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadJob",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadJobParameter.SourceValue = new ProcessSchemaParameterValue(leadJobParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadJobParameter);
			var leadSalutationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d3c07dc5-4858-4e2b-8a4f-aa43fd8c994c"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadSalutation",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			leadSalutationParameter.SourceValue = new ProcessSchemaParameterValue(leadSalutationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadSalutationParameter);
			var leadDearParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("9fe6e73b-982b-447a-8026-b87f752c8ff7"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadDear",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			leadDearParameter.SourceValue = new ProcessSchemaParameterValue(leadDearParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{ee7282d6-232b-449f-bf7b-1bd2e1f36a58}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadDearParameter);
			var leadFullJobTitleParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5115cd23-d7b1-4910-9649-548f99d28702"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadFullJobTitle",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			leadFullJobTitleParameter.SourceValue = new ProcessSchemaParameterValue(leadFullJobTitleParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{4d0cc359-3e5f-481c-b8aa-117ca6b24c06}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadFullJobTitleParameter);
			var leadContactNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("41facd7c-ad34-4602-a964-3a2cb47018cf"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadContactName",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			leadContactNameParameter.SourceValue = new ProcessSchemaParameterValue(leadContactNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{865eb25f-3941-423f-a4c0-c7834368a7af}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadContactNameParameter);
			var leadAccountNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a3acd3d1-aaec-4a94-b346-dc5725644397"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAccountName",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			leadAccountNameParameter.SourceValue = new ProcessSchemaParameterValue(leadAccountNameParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{85e56029-bf1f-46b8-9293-a6395e7f00f9}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadAccountNameParameter);
			var leadAnnualRevenueParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("df432b89-5d4b-4f34-b607-c97cae9b9834"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAnnualRevenue",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadAnnualRevenueParameter.SourceValue = new ProcessSchemaParameterValue(leadAnnualRevenueParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadAnnualRevenueParameter);
			var leadEmployeesNumberParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1e718980-7754-4358-8acf-81f7a5de8b77"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadEmployeesNumber",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadEmployeesNumberParameter.SourceValue = new ProcessSchemaParameterValue(leadEmployeesNumberParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadEmployeesNumberParameter);
			var leadAccountCategoryParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1eabd5bb-a8fd-44f3-afe9-c642cbde68e1"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAccountCategory",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadAccountCategoryParameter.SourceValue = new ProcessSchemaParameterValue(leadAccountCategoryParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadAccountCategoryParameter);
			var leadIndustryParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5a67e4f6-2125-403a-b3c9-2d2659044f13"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadIndustry",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadIndustryParameter.SourceValue = new ProcessSchemaParameterValue(leadIndustryParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadIndustryParameter);
			var leadOwnershipParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("6967a991-5415-427a-9bf5-720119cf9334"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadOwnership",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadOwnershipParameter.SourceValue = new ProcessSchemaParameterValue(leadOwnershipParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadOwnershipParameter);
			var leadAccountIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("50a54ec0-4636-4e41-b878-1ae823817b17"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAccountId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadAccountIdParameter.SourceValue = new ProcessSchemaParameterValue(leadAccountIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadAccountIdParameter);
			var leadContactIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("2021661f-8546-4ddf-85f1-8ab635dea624"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadContactId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadContactIdParameter.SourceValue = new ProcessSchemaParameterValue(leadContactIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadContactIdParameter);
			var leadAddressParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("54cec4eb-e866-4e01-8338-a580dc7bc315"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadAddress",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText")
			};
			leadAddressParameter.SourceValue = new ProcessSchemaParameterValue(leadAddressParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{8bf25d2e-0f4c-4ed1-b885-635952f9e063}].[Parameter:{724a8768-9516-4d2c-aa88-41a1bb2d5e37}].[EntityColumn:{76b846c6-6af5-40c2-9576-5c5dbc0d6200}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadAddressParameter);
			var createAccountOnQualificationParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e96ce45e-a998-48b8-909b-1a3954692c17"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"CreateAccountOnQualification",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			createAccountOnQualificationParameter.SourceValue = new ProcessSchemaParameterValue(createAccountOnQualificationParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(createAccountOnQualificationParameter);
			var leadQualificationPassedParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("685c5b79-fe06-472c-876c-31ea8abad81b"),
				ContainerUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				Name = @"LeadQualificationPassed",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			leadQualificationPassedParameter.SourceValue = new ProcessSchemaParameterValue(leadQualificationPassedParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a")
			};
			parametrizedElement.Parameters.Add(leadQualificationPassedParameter);
		}

		protected virtual void InitializeDistributionSubProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var leadIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("c4d81683-7824-4985-9713-d894b57a454f"),
				ContainerUId = new Guid("60e186ba-1d76-49c6-9960-3f9af79ce90f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"LeadId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadIdParameter.SourceValue = new ProcessSchemaParameterValue(leadIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{dcaf025e-49c8-42ea-8f2d-0ffad1fb7e33}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(leadIdParameter);
			var createReminderParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("91ff4dcd-9b74-47bb-b67c-b5e00e41aa30"),
				ContainerUId = new Guid("60e186ba-1d76-49c6-9960-3f9af79ce90f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"CreateReminder",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			createReminderParameter.SourceValue = new ProcessSchemaParameterValue(createReminderParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
			};
			parametrizedElement.Parameters.Add(createReminderParameter);
			var responsibleIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				UId = new Guid("72f93bc7-be46-4da5-8605-89d9315f59f2"),
				ContainerUId = new Guid("60e186ba-1d76-49c6-9960-3f9af79ce90f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"ResponsibleId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			responsibleIdParameter.SourceValue = new ProcessSchemaParameterValue(responsibleIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe")
			};
			parametrizedElement.Parameters.Add(responsibleIdParameter);
			var showDistributionPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1a306a50-841a-4857-9780-6af6fbce14a6"),
				ContainerUId = new Guid("60e186ba-1d76-49c6-9960-3f9af79ce90f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				Name = @"ShowDistributionPage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			showDistributionPageParameter.SourceValue = new ProcessSchemaParameterValue(showDistributionPageParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{76349b0a-e191-4050-abc2-0ee4dd58c60f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(showDistributionPageParameter);
		}

		protected virtual void InitializeHandoffSubProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var leadIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("012cc585-99f3-4ed1-8ccd-d387890c425e"),
				ContainerUId = new Guid("bf4fdb46-796a-4290-9134-de7fe2eab40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7ee7590a-758b-4ee3-990c-188743946765"),
				Name = @"LeadId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadIdParameter.SourceValue = new ProcessSchemaParameterValue(leadIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{dcaf025e-49c8-42ea-8f2d-0ffad1fb7e33}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(leadIdParameter);
			var openTaskPageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("790c0284-b579-4d01-9aef-64233b859d9e"),
				ContainerUId = new Guid("bf4fdb46-796a-4290-9134-de7fe2eab40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"OpenTaskPage",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			openTaskPageParameter.SourceValue = new ProcessSchemaParameterValue(openTaskPageParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{76349b0a-e191-4050-abc2-0ee4dd58c60f}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(openTaskPageParameter);
			var feedMessageParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("042def73-bc02-4dfe-8751-5b5aeb9994b0"),
				ContainerUId = new Guid("bf4fdb46-796a-4290-9134-de7fe2eab40d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				Name = @"FeedMessage",
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText")
			};
			feedMessageParameter.SourceValue = new ProcessSchemaParameterValue(feedMessageParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = @"Information about proceeding to handoff:",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0")
			};
			parametrizedElement.Parameters.Add(feedMessageParameter);
		}

		protected virtual void InitializeAwaitingSalesSubProcessParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var leadIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("68e66100-46fa-4d20-a6ba-fbaf9d940720"),
				ContainerUId = new Guid("a9a73c32-a953-4b47-a375-b5b163a62fed"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("6c2f6588-5216-4902-9d51-e0adf8a1201a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("6c2f6588-5216-4902-9d51-e0adf8a1201a"),
				Name = @"LeadId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Lookup")
			};
			leadIdParameter.SourceValue = new ProcessSchemaParameterValue(leadIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{dcaf025e-49c8-42ea-8f2d-0ffad1fb7e33}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(leadIdParameter);
		}

		protected virtual void InitializeReadLeadDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var dataSourceFiltersParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("79d7c595-8697-4a57-a10a-79ee7ae30ce4"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,69,178,100,75,118,143,203,182,44,148,52,208,180,20,146,37,140,165,81,86,224,63,27,75,166,9,102,191,123,229,117,54,133,28,74,233,173,224,195,104,164,247,244,155,135,60,223,251,240,209,183,17,199,218,65,27,48,155,118,182,38,194,72,208,162,40,168,229,218,82,233,114,69,117,14,21,149,10,10,198,92,46,81,84,36,235,161,195,154,172,234,173,245,145,100,62,98,23,234,219,249,183,105,28,39,204,238,221,121,241,213,28,176,131,111,203,5,146,131,211,21,86,84,21,172,161,18,155,134,106,3,134,58,39,170,166,148,90,114,52,100,101,145,37,103,92,57,78,11,151,39,2,135,154,54,156,105,138,214,49,81,230,150,149,170,33,89,139,46,110,159,142,35,134,224,135,190,158,241,181,190,121,62,38,202,245,238,205,208,78,93,79,178,14,35,92,67,60,212,4,144,161,44,12,80,35,171,98,113,87,20,68,101,169,128,70,229,74,35,47,185,34,153,129,99,92,108,201,206,146,204,66,132,239,208,78,120,118,158,125,98,204,5,227,186,40,147,150,11,67,165,200,25,213,165,86,212,217,210,85,40,202,170,106,236,37,175,79,147,79,181,15,87,83,135,163,55,47,177,99,202,111,24,235,217,12,125,28,135,118,177,190,58,31,191,193,167,184,134,251,178,245,99,29,40,166,254,34,34,167,108,10,184,105,61,246,113,219,155,193,250,254,97,245,60,157,146,164,59,194,232,195,37,133,237,227,4,45,201,70,255,112,248,99,90,155,41,196,161,251,143,70,205,210,152,201,35,61,178,51,238,242,6,173,15,199,22,158,207,235,154,188,123,156,134,248,225,51,130,93,43,242,70,81,147,59,98,13,56,150,23,72,101,101,52,149,57,2,213,46,183,148,57,7,150,187,70,161,16,119,36,81,252,131,247,237,46,124,249,217,95,254,129,149,122,255,62,117,223,52,174,47,202,122,254,27,156,211,126,1,218,159,210,247,11,49,170,147,157,202,3,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(dataSourceFiltersParameter);
			var resultTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("a18edb14-dfeb-4d04-90bb-d26913e2ac5a"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(resultTypeParameter);
			var readSomeTopRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("af294c4d-71dd-4e98-b5ea-ca04bf60c63a"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(readSomeTopRecordsParameter);
			var numberOfRecordsParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("02aa9ff0-24e7-4104-b3be-a9743c914f93"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(numberOfRecordsParameter);
			var functionTypeParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("366c7a6d-876d-435a-8556-d7b90838c1f2"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(functionTypeParameter);
			var aggregationColumnNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e0614378-f986-43e1-abbc-202a6926f125"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				UId = new Guid("23fa8dea-6c00-412e-9c43-408c3e68a1b9"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				Value = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,73,77,76,241,75,204,77,181,50,180,50,4,0,119,185,58,103,19,0,0,0 })),
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(orderInfoParameter);
			var resultEntityParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				UId = new Guid("410ce1cd-f5a9-43a4-81dd-e3ddcc55020d"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(resultEntityParameter);
			var resultCountParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("32c199ed-0dd3-4cf1-818c-a1fe154b949b"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				UId = new Guid("dff9a69d-c27b-43d4-bb6f-65043863e873"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				UId = new Guid("a8d7bc3f-493b-473f-9a5f-e05829be523a"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				UId = new Guid("b2e829b1-49d7-48b1-8ca0-11c5c2fb6a3f"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				UId = new Guid("e2b7fb69-f082-4171-aa4b-62a5f4a7f7bf"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				UId = new Guid("c38a2d93-07b6-45bb-8d39-cd8976a2f6e0"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				UId = new Guid("be3f7962-de04-4446-b20d-854d0c23e8c9"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(resultEntityCollectionParameter);
			var entityColumnMetaPathesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("04dce9b6-f80f-43f3-ab64-d3b51a737d1d"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5")
			};
			parametrizedElement.Parameters.Add(entityColumnMetaPathesParameter);
			var ignoreDisplayValuesParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("62c4740f-9091-4733-97bc-8f6f4966d30e"),
				ContainerUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
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

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLeadManagementLaneSet = CreateLeadManagementLaneSetLaneSet();
			LaneSets.Add(schemaLeadManagementLaneSet);
			ProcessSchemaLane schemaLeadManagementLane = CreateLeadManagementLaneLane();
			schemaLeadManagementLaneSet.Lanes.Add(schemaLeadManagementLane);
			ProcessSchemaSubProcess qualificationsubprocess = CreateQualificationSubProcessSubProcess();
			FlowElements.Add(qualificationsubprocess);
			ProcessSchemaSubProcess distributionsubprocess = CreateDistributionSubProcessSubProcess();
			FlowElements.Add(distributionsubprocess);
			ProcessSchemaSubProcess handoffsubprocess = CreateHandoffSubProcessSubProcess();
			FlowElements.Add(handoffsubprocess);
			ProcessSchemaSubProcess awaitingsalessubprocess = CreateAwaitingSalesSubProcessSubProcess();
			FlowElements.Add(awaitingsalessubprocess);
			ProcessSchemaExclusiveGateway exclusivegatewaystage = CreateExclusiveGatewayStageExclusiveGateway();
			FlowElements.Add(exclusivegatewaystage);
			ProcessSchemaUserTask readleaddata = CreateReadLeadDataUserTask();
			FlowElements.Add(readleaddata);
			ProcessSchemaTerminateEvent terminateprocess = CreateTerminateProcessTerminateEvent();
			FlowElements.Add(terminateprocess);
			ProcessSchemaScriptTask attachleadtoprocessscripttask = CreateAttachLeadToProcessScriptTaskScriptTask();
			FlowElements.Add(attachleadtoprocessscripttask);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaScriptTask detachleadscripttask = CreateDetachLeadScriptTaskScriptTask();
			FlowElements.Add(detachleadscripttask);
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlowDistributionConditionalFlow());
			FlowElements.Add(CreateSequenceFlowAfterDistributionSequenceFlow());
			FlowElements.Add(CreateConditionalFlowHandoffConditionalFlow());
			FlowElements.Add(CreateSequenceFlowAfterHandoffSequenceFlow());
			FlowElements.Add(CreateConditionalFlowAwaitingSalesConditionalFlow());
			FlowElements.Add(CreateSequenceFlowAfterAwaitingSalesSequenceFlow());
			FlowElements.Add(CreateReadLeadSequenceFlowSequenceFlow());
			FlowElements.Add(CreateAttachLeadSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("e79f3de4-a9c1-4d82-8991-94d9bcbe48ae"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(232, 157),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1730fd69-e909-49b4-bee7-2e358d794c12"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("37b88c6b-a9e5-4f0d-b00c-a51a1a18c6b4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(614, 176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1730fd69-e909-49b4-bee7-2e358d794c12"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a45a1ebd-8b78-4129-8703-af43a5f0cdc6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowDistributionConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowDistribution",
				UId = new Guid("a0c89092-ae72-4c59-8105-e575a38e00ae"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{71939dca-8599-4c6d-963d-6537e0a150d0}].[Parameter:{410ce1cd-f5a9-43a4-81dd-e3ddcc55020d}].[EntityColumn:{bc0c2d60-5a3d-4840-aa4e-c60ea776e206}]#] == [#Lookup.22341cd1-5b33-4c40-9011-6f7693ef6e44.14cfc644-e3ed-497e-8279-ed4319bb8093#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(558, 176),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1730fd69-e909-49b4-bee7-2e358d794c12"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("60e186ba-1d76-49c6-9960-3f9af79ce90f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(658, 97));
			schemaFlow.PolylinePointPositions.Add(new Point(826, 97));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowAfterDistributionSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowAfterDistribution",
				UId = new Guid("8fa29a01-73ae-4bf7-8fc7-34c3b2e582c0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(584, 173),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("60e186ba-1d76-49c6-9960-3f9af79ce90f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(826, 266));
			schemaFlow.PolylinePointPositions.Add(new Point(532, 266));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowHandoffConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowHandoff",
				UId = new Guid("ad137d98-4229-4ff5-80f9-7b1a5c112e9d"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{71939dca-8599-4c6d-963d-6537e0a150d0}].[Parameter:{410ce1cd-f5a9-43a4-81dd-e3ddcc55020d}].[EntityColumn:{bc0c2d60-5a3d-4840-aa4e-c60ea776e206}]#] == [#Lookup.22341cd1-5b33-4c40-9011-6f7693ef6e44.ceb70b3c-985f-4867-ae7c-88f9dd710688#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(868, 124),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1730fd69-e909-49b4-bee7-2e358d794c12"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bf4fdb46-796a-4290-9134-de7fe2eab40d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(658, 52));
			schemaFlow.PolylinePointPositions.Add(new Point(975, 52));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowAfterHandoffSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowAfterHandoff",
				UId = new Guid("8cfa3ed4-1d9d-48dc-89a7-4137c4a46f71"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(800, 177),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf4fdb46-796a-4290-9134-de7fe2eab40d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(975, 296));
			schemaFlow.PolylinePointPositions.Add(new Point(532, 296));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlowAwaitingSalesConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlowAwaitingSales",
				UId = new Guid("59385c40-88e6-4ba2-bb3c-9e0830ba6c41"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{71939dca-8599-4c6d-963d-6537e0a150d0}].[Parameter:{410ce1cd-f5a9-43a4-81dd-e3ddcc55020d}].[EntityColumn:{bc0c2d60-5a3d-4840-aa4e-c60ea776e206}]#] == [#Lookup.22341cd1-5b33-4c40-9011-6f7693ef6e44.7a90900b-53b5-4598-92b3-0aee90626c56#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(928, 120),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1730fd69-e909-49b4-bee7-2e358d794c12"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a9a73c32-a953-4b47-a375-b5b163a62fed"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(658, 9));
			schemaFlow.PolylinePointPositions.Add(new Point(1123, 9));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowAfterAwaitingSalesSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowAfterAwaitingSales",
				UId = new Guid("8a5adc56-96f6-44aa-9c8e-235a05d1306b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(863, 178),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a9a73c32-a953-4b47-a375-b5b163a62fed"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(1123, 326));
			schemaFlow.PolylinePointPositions.Add(new Point(532, 326));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateReadLeadSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "ReadLeadSequenceFlow",
				UId = new Guid("8a311f82-72c4-4049-bba9-95d238e4a0d8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(406, 162),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a345f734-629f-4b63-ad21-12ca047e4c89"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateAttachLeadSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "AttachLeadSequenceFlow",
				UId = new Guid("580a67d9-18bb-4a27-9a36-607b69144423"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c4378b15-b4d5-4764-beda-4087a06455d5"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(263, 161),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1068b0b8-c902-43c4-8b8e-53cf6cc6d058"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a345f734-629f-4b63-ad21-12ca047e4c89"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("04b3f7ff-221a-439c-9f93-52f75f15521c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("fc539133-b8d9-4984-b7be-a58958c7add2"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("d23516f2-d825-426c-9913-bfad5f33a117"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a45a1ebd-8b78-4129-8703-af43a5f0cdc6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("26eee7a8-6134-4ef9-b114-ddab59ddb05b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLeadManagementLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaLeadManagementLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("82ac26ed-ce03-4305-a802-e8b49e625913"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"LeadManagementLaneSet",
				Position = new Point(5, 5),
				Size = new Size(0, 0)
			};
			return schemaLeadManagementLaneSet;
		}

		protected virtual ProcessSchemaLane CreateLeadManagementLaneLane() {
			ProcessSchemaLane schemaLeadManagementLane = new ProcessSchemaLane(this) {
				UId = new Guid("2dff3312-98bc-4d7a-a7b0-f854e675b32a"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("82ac26ed-ce03-4305-a802-e8b49e625913"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"LeadManagementLane",
				Position = new Point(29, 0),
				Size = new Size(0, 0)
			};
			return schemaLeadManagementLane;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayStageExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("1730fd69-e909-49b4-bee7-2e358d794c12"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dff3312-98bc-4d7a-a7b0-f854e675b32a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"ExclusiveGatewayStage",
				Position = new Point(631, 128),
				SerializeToDB = false,
				Size = new Size(55, 55)
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateReadLeadDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dff3312-98bc-4d7a-a7b0-f854e675b32a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"ReadLeadData",
				Position = new Point(498, 128),
				SchemaUId = new Guid("cb455b6f-78ff-4b1e-b241-c2bbc0b37e9f"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeReadLeadDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaSubProcess CreateQualificationSubProcessSubProcess() {
			ProcessSchemaSubProcess schemaQualificationSubProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dff3312-98bc-4d7a-a7b0-f854e675b32a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"QualificationSubProcess",
				Position = new Point(370, 128),
				SchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a"),
				SerializeToDB = false,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseLastSchemaVersion = true
			};
			InitializeQualificationSubProcessParameters(schemaQualificationSubProcess);
			return schemaQualificationSubProcess;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("26eee7a8-6134-4ef9-b114-ddab59ddb05b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dff3312-98bc-4d7a-a7b0-f854e675b32a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"TerminateProcess",
				Position = new Point(645, 453),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaSubProcess CreateDistributionSubProcessSubProcess() {
			ProcessSchemaSubProcess schemaDistributionSubProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("60e186ba-1d76-49c6-9960-3f9af79ce90f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dff3312-98bc-4d7a-a7b0-f854e675b32a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"DistributionSubProcess",
				Position = new Point(792, 128),
				SchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseLastSchemaVersion = true
			};
			InitializeDistributionSubProcessParameters(schemaDistributionSubProcess);
			return schemaDistributionSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateAttachLeadToProcessScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a345f734-629f-4b63-ad21-12ca047e4c89"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dff3312-98bc-4d7a-a7b0-f854e675b32a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("e0d01508-647f-45d1-be6b-8fb83a5b47c5"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"AttachLeadToProcessScriptTask",
				Position = new Point(232, 128),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,206,187,10,194,48,20,6,224,217,66,223,33,100,202,129,146,23,232,88,58,4,28,42,82,156,67,114,138,129,54,105,79,18,84,196,119,55,85,55,231,255,194,231,38,38,142,168,173,178,82,197,126,89,211,67,0,176,103,93,29,8,83,38,207,38,61,71,108,235,234,85,87,30,111,108,92,173,78,40,198,136,212,5,239,209,36,23,124,195,248,254,193,161,204,228,25,147,224,167,172,103,55,57,163,247,120,160,96,48,70,101,121,195,186,48,231,197,203,65,147,94,48,33,137,81,89,248,236,46,87,36,20,188,180,96,167,108,229,65,252,181,191,84,0,217,223,209,228,2,129,66,251,73,19,101,108,223,168,174,143,80,208,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaSubProcess CreateHandoffSubProcessSubProcess() {
			ProcessSchemaSubProcess schemaHandoffSubProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("bf4fdb46-796a-4290-9134-de7fe2eab40d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dff3312-98bc-4d7a-a7b0-f854e675b32a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"HandoffSubProcess",
				Position = new Point(940, 128),
				SchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseLastSchemaVersion = false
			};
			InitializeHandoffSubProcessParameters(schemaHandoffSubProcess);
			return schemaHandoffSubProcess;
		}

		protected virtual ProcessSchemaSubProcess CreateAwaitingSalesSubProcessSubProcess() {
			ProcessSchemaSubProcess schemaAwaitingSalesSubProcess = new ProcessSchemaSubProcess(this) {
				UId = new Guid("a9a73c32-a953-4b47-a375-b5b163a62fed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dff3312-98bc-4d7a-a7b0-f854e675b32a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("8ecfd6ca-7945-4fe1-b150-3316de6e5f08"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"AwaitingSalesSubProcess",
				Position = new Point(1089, 128),
				SchemaUId = new Guid("6c2f6588-5216-4902-9d51-e0adf8a1201a"),
				SerializeToDB = true,
				Size = new Size(70, 56),
				TriggeredByEvent = false,
				UseLastSchemaVersion = false
			};
			InitializeAwaitingSalesSubProcessParameters(schemaAwaitingSalesSubProcess);
			return schemaAwaitingSalesSubProcess;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("1068b0b8-c902-43c4-8b8e-53cf6cc6d058"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dff3312-98bc-4d7a-a7b0-f854e675b32a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c4378b15-b4d5-4764-beda-4087a06455d5"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"Start1",
				Position = new Point(113, 142),
				SerializeToDB = false,
				Size = new Size(27, 27)
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDetachLeadScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a45a1ebd-8b78-4129-8703-af43a5f0cdc6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2dff3312-98bc-4d7a-a7b0-f854e675b32a"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("34a08715-d94b-478c-887e-dbb951baceeb"),
				CreatedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"),
				Name = @"DetachLeadScriptTask",
				Position = new Point(624, 360),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,206,177,10,131,48,16,198,241,185,130,239,16,50,229,64,242,2,142,226,32,116,176,20,233,28,146,147,6,98,180,151,11,109,41,125,247,198,226,124,223,255,248,249,89,168,51,26,55,56,61,164,126,217,248,173,0,196,167,174,78,132,156,41,138,217,132,132,109,93,125,235,42,226,83,76,155,51,140,106,74,72,221,26,35,90,246,107,108,132,220,127,72,40,153,190,34,43,121,201,38,248,217,91,179,159,71,90,45,166,52,56,217,136,110,13,121,137,186,180,137,85,204,33,192,63,186,221,145,80,201,50,129,221,241,40,185,58,166,163,33,179,32,35,29,78,0,221,191,208,230,162,128,226,58,152,76,25,219,31,71,178,151,166,205,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LeadManagement78(userConnection);
		}

		public override object Clone() {
			return new LeadManagement78Schema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadManagement78

	/// <exclude/>
	public class LeadManagement78 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLeadManagementLane

		/// <exclude/>
		public class ProcessLeadManagementLane : ProcessLane
		{

			public ProcessLeadManagementLane(UserConnection userConnection, LeadManagement78 process)
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

			public ReadLeadDataFlowElement(UserConnection userConnection, LeadManagement78 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadLeadData";
				IsLogging = true;
				SchemaElementUId = new Guid("71939dca-8599-4c6d-963d-6537e0a150d0");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,79,107,220,48,16,197,191,139,14,61,89,69,178,100,75,118,143,203,182,44,148,52,208,180,20,146,37,140,165,81,86,224,63,27,75,166,9,102,191,123,229,117,54,133,28,74,233,173,224,195,104,164,247,244,155,135,60,223,251,240,209,183,17,199,218,65,27,48,155,118,182,38,194,72,208,162,40,168,229,218,82,233,114,69,117,14,21,149,10,10,198,92,46,81,84,36,235,161,195,154,172,234,173,245,145,100,62,98,23,234,219,249,183,105,28,39,204,238,221,121,241,213,28,176,131,111,203,5,146,131,211,21,86,84,21,172,161,18,155,134,106,3,134,58,39,170,166,148,90,114,52,100,101,145,37,103,92,57,78,11,151,39,2,135,154,54,156,105,138,214,49,81,230,150,149,170,33,89,139,46,110,159,142,35,134,224,135,190,158,241,181,190,121,62,38,202,245,238,205,208,78,93,79,178,14,35,92,67,60,212,4,144,161,44,12,80,35,171,98,113,87,20,68,101,169,128,70,229,74,35,47,185,34,153,129,99,92,108,201,206,146,204,66,132,239,208,78,120,118,158,125,98,204,5,227,186,40,147,150,11,67,165,200,25,213,165,86,212,217,210,85,40,202,170,106,236,37,175,79,147,79,181,15,87,83,135,163,55,47,177,99,202,111,24,235,217,12,125,28,135,118,177,190,58,31,191,193,167,184,134,251,178,245,99,29,40,166,254,34,34,167,108,10,184,105,61,246,113,219,155,193,250,254,97,245,60,157,146,164,59,194,232,195,37,133,237,227,4,45,201,70,255,112,248,99,90,155,41,196,161,251,143,70,205,210,152,201,35,61,178,51,238,242,6,173,15,199,22,158,207,235,154,188,123,156,134,248,225,51,130,93,43,242,70,81,147,59,98,13,56,150,23,72,101,101,52,149,57,2,213,46,183,148,57,7,150,187,70,161,16,119,36,81,252,131,247,237,46,124,249,217,95,254,129,149,122,255,62,117,223,52,174,47,202,122,254,27,156,211,126,1,218,159,210,247,11,49,170,147,157,202,3,0,0 })));
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

		#region Class: QualificationSubProcessFlowElement

		/// <exclude/>
		public class QualificationSubProcessFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public QualificationSubProcessFlowElement(UserConnection userConnection, LeadManagement78 process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("63c69a32-4ff6-4ed8-bdd0-2ff85dfbe88a");
			}

			#endregion

			#region Properties: Public

			public  Guid LeadId {
				get {
					return GetParameterValue<Guid>("LeadId");
				}
				set {
					SetParameterValue("LeadId", value);
				}
			}

			public  Guid AccountId {
				get {
					return GetParameterValue<Guid>("AccountId");
				}
				set {
					SetParameterValue("AccountId", value);
				}
			}

			public  Guid ContactId {
				get {
					return GetParameterValue<Guid>("ContactId");
				}
				set {
					SetParameterValue("ContactId", value);
				}
			}

			public  Guid LeadAddressType {
				get {
					return GetParameterValue<Guid>("LeadAddressType");
				}
				set {
					SetParameterValue("LeadAddressType", value);
				}
			}

			public  Guid LeadCity {
				get {
					return GetParameterValue<Guid>("LeadCity");
				}
				set {
					SetParameterValue("LeadCity", value);
				}
			}

			public  string LeadZip {
				get {
					return GetParameterValue<string>("LeadZip");
				}
				set {
					SetParameterValue("LeadZip", value);
				}
			}

			public  Guid LeadRegion {
				get {
					return GetParameterValue<Guid>("LeadRegion");
				}
				set {
					SetParameterValue("LeadRegion", value);
				}
			}

			public  Guid LeadCountry {
				get {
					return GetParameterValue<Guid>("LeadCountry");
				}
				set {
					SetParameterValue("LeadCountry", value);
				}
			}

			public  string LeadWebsite {
				get {
					return GetParameterValue<string>("LeadWebsite");
				}
				set {
					SetParameterValue("LeadWebsite", value);
				}
			}

			public  string LeadFax {
				get {
					return GetParameterValue<string>("LeadFax");
				}
				set {
					SetParameterValue("LeadFax", value);
				}
			}

			public  string LeadBusinessPhone {
				get {
					return GetParameterValue<string>("LeadBusinessPhone");
				}
				set {
					SetParameterValue("LeadBusinessPhone", value);
				}
			}

			public  string LeadEmail {
				get {
					return GetParameterValue<string>("LeadEmail");
				}
				set {
					SetParameterValue("LeadEmail", value);
				}
			}

			public  string LeadMobilePhone {
				get {
					return GetParameterValue<string>("LeadMobilePhone");
				}
				set {
					SetParameterValue("LeadMobilePhone", value);
				}
			}

			public  Guid LeadDecisionRole {
				get {
					return GetParameterValue<Guid>("LeadDecisionRole");
				}
				set {
					SetParameterValue("LeadDecisionRole", value);
				}
			}

			public  Guid LeadGender {
				get {
					return GetParameterValue<Guid>("LeadGender");
				}
				set {
					SetParameterValue("LeadGender", value);
				}
			}

			public  Guid LeadDepartment {
				get {
					return GetParameterValue<Guid>("LeadDepartment");
				}
				set {
					SetParameterValue("LeadDepartment", value);
				}
			}

			public  Guid LeadJob {
				get {
					return GetParameterValue<Guid>("LeadJob");
				}
				set {
					SetParameterValue("LeadJob", value);
				}
			}

			public  Guid LeadSalutation {
				get {
					return GetParameterValue<Guid>("LeadSalutation");
				}
				set {
					SetParameterValue("LeadSalutation", value);
				}
			}

			public  string LeadDear {
				get {
					return GetParameterValue<string>("LeadDear");
				}
				set {
					SetParameterValue("LeadDear", value);
				}
			}

			public  string LeadFullJobTitle {
				get {
					return GetParameterValue<string>("LeadFullJobTitle");
				}
				set {
					SetParameterValue("LeadFullJobTitle", value);
				}
			}

			public  string LeadContactName {
				get {
					return GetParameterValue<string>("LeadContactName");
				}
				set {
					SetParameterValue("LeadContactName", value);
				}
			}

			public  string LeadAccountName {
				get {
					return GetParameterValue<string>("LeadAccountName");
				}
				set {
					SetParameterValue("LeadAccountName", value);
				}
			}

			public  Guid LeadAnnualRevenue {
				get {
					return GetParameterValue<Guid>("LeadAnnualRevenue");
				}
				set {
					SetParameterValue("LeadAnnualRevenue", value);
				}
			}

			public  Guid LeadEmployeesNumber {
				get {
					return GetParameterValue<Guid>("LeadEmployeesNumber");
				}
				set {
					SetParameterValue("LeadEmployeesNumber", value);
				}
			}

			public  Guid LeadAccountCategory {
				get {
					return GetParameterValue<Guid>("LeadAccountCategory");
				}
				set {
					SetParameterValue("LeadAccountCategory", value);
				}
			}

			public  Guid LeadIndustry {
				get {
					return GetParameterValue<Guid>("LeadIndustry");
				}
				set {
					SetParameterValue("LeadIndustry", value);
				}
			}

			public  Guid LeadOwnership {
				get {
					return GetParameterValue<Guid>("LeadOwnership");
				}
				set {
					SetParameterValue("LeadOwnership", value);
				}
			}

			public  Guid LeadAccountId {
				get {
					return GetParameterValue<Guid>("LeadAccountId");
				}
				set {
					SetParameterValue("LeadAccountId", value);
				}
			}

			public  Guid LeadContactId {
				get {
					return GetParameterValue<Guid>("LeadContactId");
				}
				set {
					SetParameterValue("LeadContactId", value);
				}
			}

			public  string LeadAddress {
				get {
					return GetParameterValue<string>("LeadAddress");
				}
				set {
					SetParameterValue("LeadAddress", value);
				}
			}

			public  bool CreateAccountOnQualification {
				get {
					return GetParameterValue<bool>("CreateAccountOnQualification");
				}
				set {
					SetParameterValue("CreateAccountOnQualification", value);
				}
			}

			public  bool LeadQualificationPassed {
				get {
					return GetParameterValue<bool>("LeadQualificationPassed");
				}
				set {
					SetParameterValue("LeadQualificationPassed", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (LeadManagement78)owner;
				Name = "QualificationSubProcess";
				SerializeToDB = false;
				IsLogging = true;
				SchemaElementUId = new Guid("00173f2d-130c-458b-950c-ccbef1bc016e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadManagementLane;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (LeadManagement78)Owner;
				SetParameterValue("LeadId", (Guid)((process.LeadId)));
			}

			#endregion

		}

		#endregion

		#region Class: DistributionSubProcessFlowElement

		/// <exclude/>
		public class DistributionSubProcessFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public DistributionSubProcessFlowElement(UserConnection userConnection, LeadManagement78 process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("2747a386-3328-4c0d-a1bc-2acc2ae61cfe");
			}

			#endregion

			#region Properties: Public

			public  Guid LeadId {
				get {
					return GetParameterValue<Guid>("LeadId");
				}
				set {
					SetParameterValue("LeadId", value);
				}
			}

			public  bool CreateReminder {
				get {
					return GetParameterValue<bool>("CreateReminder");
				}
				set {
					SetParameterValue("CreateReminder", value);
				}
			}

			public  Guid ResponsibleId {
				get {
					return GetParameterValue<Guid>("ResponsibleId");
				}
				set {
					SetParameterValue("ResponsibleId", value);
				}
			}

			public  bool ShowDistributionPage {
				get {
					return GetParameterValue<bool>("ShowDistributionPage");
				}
				set {
					SetParameterValue("ShowDistributionPage", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (LeadManagement78)owner;
				Name = "DistributionSubProcess";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("60e186ba-1d76-49c6-9960-3f9af79ce90f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadManagementLane;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (LeadManagement78)Owner;
				SetParameterValue("LeadId", (Guid)((process.LeadId)));
				SetParameterValue("ShowDistributionPage", (bool)((process.ShowDistributionPage)));
			}

			#endregion

		}

		#endregion

		#region Class: HandoffSubProcessFlowElement

		/// <exclude/>
		public class HandoffSubProcessFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public HandoffSubProcessFlowElement(UserConnection userConnection, LeadManagement78 process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("cb7254e0-1520-4e0a-8182-9b0d833246e0");
			}

			#endregion

			#region Properties: Public

			public  Guid LeadId {
				get {
					return GetParameterValue<Guid>("LeadId");
				}
				set {
					SetParameterValue("LeadId", value);
				}
			}

			public  bool OpenTaskPage {
				get {
					return GetParameterValue<bool>("OpenTaskPage");
				}
				set {
					SetParameterValue("OpenTaskPage", value);
				}
			}

			public  string FeedMessage {
				get {
					return GetParameterValue<string>("FeedMessage");
				}
				set {
					SetParameterValue("FeedMessage", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (LeadManagement78)owner;
				Name = "HandoffSubProcess";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("bf4fdb46-796a-4290-9134-de7fe2eab40d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadManagementLane;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (LeadManagement78)Owner;
				SetParameterValue("LeadId", (Guid)((process.LeadId)));
				SetParameterValue("OpenTaskPage", (bool)((process.ShowDistributionPage)));
			}

			#endregion

		}

		#endregion

		#region Class: AwaitingSalesSubProcessFlowElement

		/// <exclude/>
		public class AwaitingSalesSubProcessFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public AwaitingSalesSubProcessFlowElement(UserConnection userConnection, LeadManagement78 process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("6c2f6588-5216-4902-9d51-e0adf8a1201a");
			}

			#endregion

			#region Properties: Public

			public  Guid LeadId {
				get {
					return GetParameterValue<Guid>("LeadId");
				}
				set {
					SetParameterValue("LeadId", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (LeadManagement78)owner;
				Name = "AwaitingSalesSubProcess";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("a9a73c32-a953-4b47-a375-b5b163a62fed");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.LeadManagementLane;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (LeadManagement78)Owner;
				SetParameterValue("LeadId", (Guid)((process.LeadId)));
			}

			#endregion

		}

		#endregion

		public LeadManagement78(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadManagement78";
			SchemaUId = new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_showDistributionPage = () => { return (bool)(false); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("003b59b2-441f-44b9-b696-2b94ce2acbb5");
			}
		}

		#endregion

		#region Properties: Public

		public  virtual Guid LeadId {
			get;
			set;
		}

		private Func<bool> _showDistributionPage;
		public  virtual bool ShowDistributionPage {
			get {
				return (_showDistributionPage ?? (_showDistributionPage = () => false)).Invoke();
			}
			set {
				_showDistributionPage = () => { return value; };
			}
		}

		private ProcessLeadManagementLane _leadManagementLane;
		public  ProcessLeadManagementLane LeadManagementLane {
			get {
				return _leadManagementLane ?? ((_leadManagementLane) = new ProcessLeadManagementLane(UserConnection, this));
			}
		}

		private ProcessExclusiveGateway _exclusiveGatewayStage;
		public  ProcessExclusiveGateway ExclusiveGatewayStage {
			get {
				return _exclusiveGatewayStage ?? (_exclusiveGatewayStage = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGatewayStage",
					SchemaElementUId = new Guid("1730fd69-e909-49b4-bee7-2e358d794c12"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGatewayStage.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ReadLeadDataFlowElement _readLeadData;
		public  ReadLeadDataFlowElement ReadLeadData {
			get {
				return _readLeadData ?? (_readLeadData = new ReadLeadDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private QualificationSubProcessFlowElement _qualificationSubProcess;
		public  QualificationSubProcessFlowElement QualificationSubProcess {
			get {
				return _qualificationSubProcess ?? ((_qualificationSubProcess) = new QualificationSubProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminateProcess;
		public  ProcessTerminateEvent TerminateProcess {
			get {
				return _terminateProcess ?? (_terminateProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateProcess",
					SchemaElementUId = new Guid("26eee7a8-6134-4ef9-b114-ddab59ddb05b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private DistributionSubProcessFlowElement _distributionSubProcess;
		public  DistributionSubProcessFlowElement DistributionSubProcess {
			get {
				return _distributionSubProcess ?? ((_distributionSubProcess) = new DistributionSubProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _attachLeadToProcessScriptTask;
		public  ProcessScriptTask AttachLeadToProcessScriptTask {
			get {
				return _attachLeadToProcessScriptTask ?? (_attachLeadToProcessScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AttachLeadToProcessScriptTask",
					SchemaElementUId = new Guid("a345f734-629f-4b63-ad21-12ca047e4c89"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = AttachLeadToProcessScriptTaskExecute,
				});
			}
		}

		private HandoffSubProcessFlowElement _handoffSubProcess;
		public  HandoffSubProcessFlowElement HandoffSubProcess {
			get {
				return _handoffSubProcess ?? ((_handoffSubProcess) = new HandoffSubProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AwaitingSalesSubProcessFlowElement _awaitingSalesSubProcess;
		public  AwaitingSalesSubProcessFlowElement AwaitingSalesSubProcess {
			get {
				return _awaitingSalesSubProcess ?? ((_awaitingSalesSubProcess) = new AwaitingSalesSubProcessFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _start1;
		public  ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("1068b0b8-c902-43c4-8b8e-53cf6cc6d058"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _detachLeadScriptTask;
		public  ProcessScriptTask DetachLeadScriptTask {
			get {
				return _detachLeadScriptTask ?? (_detachLeadScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DetachLeadScriptTask",
					SchemaElementUId = new Guid("a45a1ebd-8b78-4129-8703-af43a5f0cdc6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = DetachLeadScriptTaskExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowDistribution;
		public  ProcessConditionalFlow ConditionalFlowDistribution {
			get {
				return _conditionalFlowDistribution ?? (_conditionalFlowDistribution = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowDistribution",
					SchemaElementUId = new Guid("a0c89092-ae72-4c59-8105-e575a38e00ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowHandoff;
		public  ProcessConditionalFlow ConditionalFlowHandoff {
			get {
				return _conditionalFlowHandoff ?? (_conditionalFlowHandoff = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowHandoff",
					SchemaElementUId = new Guid("ad137d98-4229-4ff5-80f9-7b1a5c112e9d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlowAwaitingSales;
		public  ProcessConditionalFlow ConditionalFlowAwaitingSales {
			get {
				return _conditionalFlowAwaitingSales ?? (_conditionalFlowAwaitingSales = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlowAwaitingSales",
					SchemaElementUId = new Guid("59385c40-88e6-4ba2-bb3c-9e0830ba6c41"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _attachLeadToProcessScriptTaskQualificationSubProcessToken;
		public  ProcessToken AttachLeadToProcessScriptTaskQualificationSubProcessToken {
			get {
				return _attachLeadToProcessScriptTaskQualificationSubProcessToken ?? (_attachLeadToProcessScriptTaskQualificationSubProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "AttachLeadToProcessScriptTaskQualificationSubProcessToken",
					SchemaElementUId = new Guid("49605345-0eb7-462f-a3bf-7d8b4930677f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _exclusiveGatewayStageDistributionSubProcessToken;
		public  ProcessToken ExclusiveGatewayStageDistributionSubProcessToken {
			get {
				return _exclusiveGatewayStageDistributionSubProcessToken ?? (_exclusiveGatewayStageDistributionSubProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "ExclusiveGatewayStageDistributionSubProcessToken",
					SchemaElementUId = new Guid("eda90d9c-dcc8-4593-98d1-d5ae70b72bc8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _exclusiveGatewayStageHandoffSubProcessToken;
		public  ProcessToken ExclusiveGatewayStageHandoffSubProcessToken {
			get {
				return _exclusiveGatewayStageHandoffSubProcessToken ?? (_exclusiveGatewayStageHandoffSubProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "ExclusiveGatewayStageHandoffSubProcessToken",
					SchemaElementUId = new Guid("0b4080cb-ce47-41cf-975d-c05e37593e5c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessToken _exclusiveGatewayStageAwaitingSalesSubProcessToken;
		public  ProcessToken ExclusiveGatewayStageAwaitingSalesSubProcessToken {
			get {
				return _exclusiveGatewayStageAwaitingSalesSubProcessToken ?? (_exclusiveGatewayStageAwaitingSalesSubProcessToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "ExclusiveGatewayStageAwaitingSalesSubProcessToken",
					SchemaElementUId = new Guid("7ddc5e6b-c600-467d-b3b5-12cd9da54a47"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ExclusiveGatewayStage.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayStage };
			FlowElements[ReadLeadData.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadLeadData };
			FlowElements[QualificationSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { QualificationSubProcess };
			FlowElements[TerminateProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateProcess };
			FlowElements[DistributionSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DistributionSubProcess };
			FlowElements[AttachLeadToProcessScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AttachLeadToProcessScriptTask };
			FlowElements[HandoffSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { HandoffSubProcess };
			FlowElements[AwaitingSalesSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AwaitingSalesSubProcess };
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[DetachLeadScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DetachLeadScriptTask };
			FlowElements[AttachLeadToProcessScriptTaskQualificationSubProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { AttachLeadToProcessScriptTaskQualificationSubProcessToken };
			FlowElements[ExclusiveGatewayStageDistributionSubProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayStageDistributionSubProcessToken };
			FlowElements[ExclusiveGatewayStageHandoffSubProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayStageHandoffSubProcessToken };
			FlowElements[ExclusiveGatewayStageAwaitingSalesSubProcessToken.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGatewayStageAwaitingSalesSubProcessToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ExclusiveGatewayStage":
						if (ConditionalFlowDistributionExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayStageDistributionSubProcessToken", e.Context.SenderName));
							break;
						}
						if (ConditionalFlowHandoffExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayStageHandoffSubProcessToken", e.Context.SenderName));
							break;
						}
						if (ConditionalFlowAwaitingSalesExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayStageAwaitingSalesSubProcessToken", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("DetachLeadScriptTask", e.Context.SenderName));
						break;
					case "ReadLeadData":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGatewayStage", e.Context.SenderName));
						break;
					case "QualificationSubProcess":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "TerminateProcess":
						CompleteProcess();
						break;
					case "DistributionSubProcess":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "AttachLeadToProcessScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AttachLeadToProcessScriptTaskQualificationSubProcessToken", e.Context.SenderName));
						break;
					case "HandoffSubProcess":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "AwaitingSalesSubProcess":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadLeadData", e.Context.SenderName));
						break;
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AttachLeadToProcessScriptTask", e.Context.SenderName));
						break;
					case "DetachLeadScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateProcess", e.Context.SenderName));
						break;
					case "AttachLeadToProcessScriptTaskQualificationSubProcessToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("QualificationSubProcess", e.Context.SenderName));
						break;
					case "ExclusiveGatewayStageDistributionSubProcessToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("DistributionSubProcess", e.Context.SenderName));
						break;
					case "ExclusiveGatewayStageHandoffSubProcessToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("HandoffSubProcess", e.Context.SenderName));
						break;
					case "ExclusiveGatewayStageAwaitingSalesSubProcessToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AwaitingSalesSubProcess", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlowDistributionExpressionExecute() {
			return Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifyStatus").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifyStatusId") : Guid.Empty)) == new Guid("14cfc644-e3ed-497e-8279-ed4319bb8093"));
		}

		private bool ConditionalFlowHandoffExpressionExecute() {
			return Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifyStatus").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifyStatusId") : Guid.Empty)) == new Guid("ceb70b3c-985f-4867-ae7c-88f9dd710688"));
		}

		private bool ConditionalFlowAwaitingSalesExpressionExecute() {
			return Convert.ToBoolean(((ReadLeadData.ResultEntity.IsColumnValueLoaded(ReadLeadData.ResultEntity.Schema.Columns.GetByName("QualifyStatus").ColumnValueName) ? ReadLeadData.ResultEntity.GetTypedColumnValue<Guid>("QualifyStatusId") : Guid.Empty)) == new Guid("7a90900b-53b5-4598-92b3-0aee90626c56"));
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("ShowDistributionPage")) {
				writer.WriteValue("ShowDistributionPage", ShowDistributionPage, false);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start1", string.Empty));
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
			MetaPathParameterValues.Add("dcaf025e-49c8-42ea-8f2d-0ffad1fb7e33", () => LeadId);
			MetaPathParameterValues.Add("76349b0a-e191-4050-abc2-0ee4dd58c60f", () => ShowDistributionPage);
			MetaPathParameterValues.Add("79d7c595-8697-4a57-a10a-79ee7ae30ce4", () => ReadLeadData.DataSourceFilters);
			MetaPathParameterValues.Add("a18edb14-dfeb-4d04-90bb-d26913e2ac5a", () => ReadLeadData.ResultType);
			MetaPathParameterValues.Add("af294c4d-71dd-4e98-b5ea-ca04bf60c63a", () => ReadLeadData.ReadSomeTopRecords);
			MetaPathParameterValues.Add("02aa9ff0-24e7-4104-b3be-a9743c914f93", () => ReadLeadData.NumberOfRecords);
			MetaPathParameterValues.Add("366c7a6d-876d-435a-8556-d7b90838c1f2", () => ReadLeadData.FunctionType);
			MetaPathParameterValues.Add("e0614378-f986-43e1-abbc-202a6926f125", () => ReadLeadData.AggregationColumnName);
			MetaPathParameterValues.Add("23fa8dea-6c00-412e-9c43-408c3e68a1b9", () => ReadLeadData.OrderInfo);
			MetaPathParameterValues.Add("410ce1cd-f5a9-43a4-81dd-e3ddcc55020d", () => ReadLeadData.ResultEntity);
			MetaPathParameterValues.Add("32c199ed-0dd3-4cf1-818c-a1fe154b949b", () => ReadLeadData.ResultCount);
			MetaPathParameterValues.Add("dff9a69d-c27b-43d4-bb6f-65043863e873", () => ReadLeadData.ResultIntegerFunction);
			MetaPathParameterValues.Add("a8d7bc3f-493b-473f-9a5f-e05829be523a", () => ReadLeadData.ResultFloatFunction);
			MetaPathParameterValues.Add("b2e829b1-49d7-48b1-8ca0-11c5c2fb6a3f", () => ReadLeadData.ResultDateTimeFunction);
			MetaPathParameterValues.Add("e2b7fb69-f082-4171-aa4b-62a5f4a7f7bf", () => ReadLeadData.ResultRowsCount);
			MetaPathParameterValues.Add("c38a2d93-07b6-45bb-8d39-cd8976a2f6e0", () => ReadLeadData.CanReadUncommitedData);
			MetaPathParameterValues.Add("be3f7962-de04-4446-b20d-854d0c23e8c9", () => ReadLeadData.ResultEntityCollection);
			MetaPathParameterValues.Add("04dce9b6-f80f-43f3-ab64-d3b51a737d1d", () => ReadLeadData.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("62c4740f-9091-4733-97bc-8f6f4966d30e", () => ReadLeadData.IgnoreDisplayValues);
			MetaPathParameterValues.Add("6a02c7ac-f88e-4d98-ad0b-0a80752dc15e", () => QualificationSubProcess.LeadId);
			MetaPathParameterValues.Add("0c30db4d-e0b5-49a8-8e34-213faa727629", () => QualificationSubProcess.AccountId);
			MetaPathParameterValues.Add("3165a642-cb3e-4a83-b0e1-798fe6b07acf", () => QualificationSubProcess.ContactId);
			MetaPathParameterValues.Add("fba88d70-5de2-44c5-93f4-cc452e20c363", () => QualificationSubProcess.LeadAddressType);
			MetaPathParameterValues.Add("19118434-012e-4446-8e6c-28a3e684b371", () => QualificationSubProcess.LeadCity);
			MetaPathParameterValues.Add("2ec8157d-f152-477f-ae87-4a49d651570b", () => QualificationSubProcess.LeadZip);
			MetaPathParameterValues.Add("422678c2-6295-4e50-815a-cc20ab495eae", () => QualificationSubProcess.LeadRegion);
			MetaPathParameterValues.Add("5ea496ee-a83b-43ae-b366-0d2117f520f5", () => QualificationSubProcess.LeadCountry);
			MetaPathParameterValues.Add("46363fb8-30a1-495c-86b7-9ba73723a8a2", () => QualificationSubProcess.LeadWebsite);
			MetaPathParameterValues.Add("53e00707-d204-46e3-a09e-0af83330c855", () => QualificationSubProcess.LeadFax);
			MetaPathParameterValues.Add("4fd2acc3-4c17-4805-bdff-0f7b1984f95f", () => QualificationSubProcess.LeadBusinessPhone);
			MetaPathParameterValues.Add("359e3a5d-0f44-42e9-bef1-441160b2ab00", () => QualificationSubProcess.LeadEmail);
			MetaPathParameterValues.Add("f8b7046b-d813-4939-b8c1-06adebe9267d", () => QualificationSubProcess.LeadMobilePhone);
			MetaPathParameterValues.Add("cf8d5f0a-6818-40d4-9e32-0368b74bb2e6", () => QualificationSubProcess.LeadDecisionRole);
			MetaPathParameterValues.Add("086038af-8c86-436c-893f-9eecfdc7fb1f", () => QualificationSubProcess.LeadGender);
			MetaPathParameterValues.Add("4312da27-20e3-4d72-99c4-c8f1de49f49f", () => QualificationSubProcess.LeadDepartment);
			MetaPathParameterValues.Add("48420f80-50bd-4d72-b1d0-5e30d558cb6e", () => QualificationSubProcess.LeadJob);
			MetaPathParameterValues.Add("d3c07dc5-4858-4e2b-8a4f-aa43fd8c994c", () => QualificationSubProcess.LeadSalutation);
			MetaPathParameterValues.Add("9fe6e73b-982b-447a-8026-b87f752c8ff7", () => QualificationSubProcess.LeadDear);
			MetaPathParameterValues.Add("5115cd23-d7b1-4910-9649-548f99d28702", () => QualificationSubProcess.LeadFullJobTitle);
			MetaPathParameterValues.Add("41facd7c-ad34-4602-a964-3a2cb47018cf", () => QualificationSubProcess.LeadContactName);
			MetaPathParameterValues.Add("a3acd3d1-aaec-4a94-b346-dc5725644397", () => QualificationSubProcess.LeadAccountName);
			MetaPathParameterValues.Add("df432b89-5d4b-4f34-b607-c97cae9b9834", () => QualificationSubProcess.LeadAnnualRevenue);
			MetaPathParameterValues.Add("1e718980-7754-4358-8acf-81f7a5de8b77", () => QualificationSubProcess.LeadEmployeesNumber);
			MetaPathParameterValues.Add("1eabd5bb-a8fd-44f3-afe9-c642cbde68e1", () => QualificationSubProcess.LeadAccountCategory);
			MetaPathParameterValues.Add("5a67e4f6-2125-403a-b3c9-2d2659044f13", () => QualificationSubProcess.LeadIndustry);
			MetaPathParameterValues.Add("6967a991-5415-427a-9bf5-720119cf9334", () => QualificationSubProcess.LeadOwnership);
			MetaPathParameterValues.Add("50a54ec0-4636-4e41-b878-1ae823817b17", () => QualificationSubProcess.LeadAccountId);
			MetaPathParameterValues.Add("2021661f-8546-4ddf-85f1-8ab635dea624", () => QualificationSubProcess.LeadContactId);
			MetaPathParameterValues.Add("54cec4eb-e866-4e01-8338-a580dc7bc315", () => QualificationSubProcess.LeadAddress);
			MetaPathParameterValues.Add("e96ce45e-a998-48b8-909b-1a3954692c17", () => QualificationSubProcess.CreateAccountOnQualification);
			MetaPathParameterValues.Add("685c5b79-fe06-472c-876c-31ea8abad81b", () => QualificationSubProcess.LeadQualificationPassed);
			MetaPathParameterValues.Add("c4d81683-7824-4985-9713-d894b57a454f", () => DistributionSubProcess.LeadId);
			MetaPathParameterValues.Add("91ff4dcd-9b74-47bb-b67c-b5e00e41aa30", () => DistributionSubProcess.CreateReminder);
			MetaPathParameterValues.Add("72f93bc7-be46-4da5-8605-89d9315f59f2", () => DistributionSubProcess.ResponsibleId);
			MetaPathParameterValues.Add("1a306a50-841a-4857-9780-6af6fbce14a6", () => DistributionSubProcess.ShowDistributionPage);
			MetaPathParameterValues.Add("012cc585-99f3-4ed1-8ccd-d387890c425e", () => HandoffSubProcess.LeadId);
			MetaPathParameterValues.Add("790c0284-b579-4d01-9aef-64233b859d9e", () => HandoffSubProcess.OpenTaskPage);
			MetaPathParameterValues.Add("042def73-bc02-4dfe-8751-5b5aeb9994b0", () => HandoffSubProcess.FeedMessage);
			MetaPathParameterValues.Add("68e66100-46fa-4d20-a6ba-fbaf9d940720", () => AwaitingSalesSubProcess.LeadId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "ShowDistributionPage":
					if (!hasValueToRead) break;
					ShowDistributionPage = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool AttachLeadToProcessScriptTaskExecute(ProcessExecutingContext context) {
			if (LeadId.IsEmpty()) {
				return false;
			}
			new Update(UserConnection, "Lead")
				.Set("QualificationProcessId", Column.Parameter(UId))
				.Where("Id").IsEqual(Column.Parameter(LeadId)).Execute();
			return true;
		}

		public virtual bool DetachLeadScriptTaskExecute(ProcessExecutingContext context) {
			if (LeadId.IsEmpty()) {
				return false;
			}
			new Update(UserConnection, "Lead")
				.Set("QualificationProcessId", Column.Const(null))
				.Where("Id").IsEqual(Column.Parameter(LeadId)).Execute();
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
			var cloneItem = (LeadManagement78)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}
