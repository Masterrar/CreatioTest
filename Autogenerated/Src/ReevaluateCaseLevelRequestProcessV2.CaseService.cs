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

	#region Class: ReevaluateCaseLevelRequestProcessV2Schema

	/// <exclude/>
	public class ReevaluateCaseLevelRequestProcessV2Schema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ReevaluateCaseLevelRequestProcessV2Schema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ReevaluateCaseLevelRequestProcessV2Schema(ReevaluateCaseLevelRequestProcessV2Schema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ReevaluateCaseLevelRequestProcessV2";
			UId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b");
			CreatedInPackageId = new Guid("f8dd4f1e-7fc4-4d0a-b383-ef9d0203cd67");
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
			Tag = @"Business process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,93,79,219,48,20,125,6,137,255,224,229,41,145,170,136,177,71,62,36,8,45,138,180,117,168,41,227,217,36,55,173,37,199,238,252,209,81,141,253,247,93,219,5,66,210,142,143,49,77,173,162,198,247,158,227,123,143,143,175,186,183,187,176,55,156,149,100,201,148,177,148,147,165,100,21,41,12,85,102,196,148,54,83,214,128,186,84,178,4,173,153,152,197,9,249,185,183,187,147,81,13,19,40,165,170,242,138,28,147,11,203,170,116,216,44,204,234,112,111,55,215,25,151,26,78,69,53,188,101,6,163,53,229,26,48,192,106,18,123,226,130,205,4,229,31,211,7,134,15,109,138,141,59,108,196,33,231,175,30,237,193,27,105,15,58,180,75,170,72,237,20,24,219,230,6,212,53,101,6,251,63,167,43,77,142,99,38,76,50,5,165,168,150,181,73,51,169,0,31,162,102,51,171,168,97,82,164,197,74,23,96,28,66,167,23,96,190,81,110,33,190,210,160,48,77,64,233,114,6,36,242,10,79,0,150,24,246,184,214,46,81,226,37,139,183,213,112,76,246,67,75,61,189,141,178,78,238,29,5,198,42,241,216,141,145,134,242,2,155,20,21,226,137,128,31,196,157,110,177,160,98,203,46,3,178,31,190,73,58,109,129,145,50,163,166,156,123,111,76,229,67,3,224,251,73,189,168,95,235,90,131,171,6,27,94,130,50,72,144,11,243,233,32,110,87,225,90,244,229,185,207,86,31,134,228,205,70,68,129,80,222,92,23,40,159,174,169,23,246,106,81,97,45,159,97,9,28,21,209,6,83,239,238,136,79,115,199,223,14,36,175,18,80,251,66,254,161,31,66,167,207,24,98,91,21,71,206,17,239,102,136,45,187,188,214,17,33,254,78,150,184,145,146,111,62,71,239,5,215,82,137,129,2,56,42,186,110,40,188,116,164,78,48,27,15,136,219,70,196,35,43,74,252,109,133,137,163,188,138,18,31,27,41,217,196,145,219,37,242,239,215,115,80,16,226,105,174,135,223,177,154,56,224,211,75,170,104,3,6,84,220,158,45,129,6,143,32,142,218,214,244,53,123,150,177,196,178,145,107,108,57,199,250,169,94,87,138,237,135,99,106,181,146,14,111,161,180,40,102,73,57,85,71,104,182,19,132,156,144,253,23,105,245,204,213,184,87,78,247,210,30,116,252,107,33,251,37,60,145,213,9,247,26,105,55,169,181,173,252,183,104,231,71,143,191,67,110,223,255,49,105,64,24,102,86,69,57,135,134,126,161,130,206,64,97,246,83,237,211,97,63,233,176,15,71,220,6,54,55,132,114,161,13,21,37,156,173,198,40,243,189,221,145,34,16,175,97,110,181,195,145,102,10,176,239,144,214,117,4,226,31,129,41,6,79,171,134,137,9,155,205,141,238,252,25,104,229,141,0,167,135,51,203,249,89,239,30,57,229,90,169,56,71,131,63,194,16,141,112,182,24,171,209,63,3,226,226,94,225,176,230,106,249,19,210,165,90,5,153,172,224,9,124,189,246,66,248,185,179,243,160,123,56,153,85,10,177,110,213,105,189,126,117,185,110,70,162,31,186,228,116,9,177,23,39,57,92,251,210,63,126,3,117,226,85,147,160,9,0,0 };
			RealUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("139575f5-1fcd-4511-8b6e-8fcca638b068"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCloseAndExitParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("53928eba-9c90-4f6f-880b-0ca34bb3e439"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"IsCloseAndExit",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseClosureCodeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1dd18ad4-0125-4b96-9e2d-6f2c3401376b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"CaseClosureCode",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.66827e0a-27d4-4616-b69a-ac6321b7be52.b69f315c-f36b-1410-159b-0050ba5d6c38#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCaseCloseStatusParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1830b7fa-15a4-4836-af66-3bacbb623476"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"CaseCloseStatus",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.99f35013-6b7a-47d6-b440-e3f1a0ba991c.3e7f420c-f46b-1410-fc9a-0050ba5d6c38#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateEmailTemplateIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3b72b4ac-4c8f-4e6a-b29b-c81d60d4fcc7"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"EmailTemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#Lookup.93030575-f70f-4041-902e-c4badaf62c63.291b7433-d6ca-43da-b194-2590d86369b2#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseRecordIdParameter());
			Parameters.Add(CreateIsCloseAndExitParameter());
			Parameters.Add(CreateCaseClosureCodeParameter());
			Parameters.Add(CreateCaseCloseStatusParameter());
			Parameters.Add(CreateEmailTemplateIdParameter());
		}

		protected virtual void InitializeSubProcessSendEmailParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var caseIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("1b650b5e-22ff-46e0-ad2d-e25e8e700487"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"CaseId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			caseIdParameter.SourceValue = new ProcessSchemaParameterValue(caseIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{139575f5-1fcd-4511-8b6e-8fcca638b068}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b")
			};
			parametrizedElement.Parameters.Add(caseIdParameter);
			var templateIdParameter = new ProcessSchemaParameter(this) {
				ReferenceSchemaUId = new Guid("93030575-f70f-4041-902e-c4badaf62c63"),
				UId = new Guid("17055d89-452d-460d-9d37-22df0ac6b836"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"TemplateId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			templateIdParameter.SourceValue = new ProcessSchemaParameterValue(templateIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{3b72b4ac-4c8f-4e6a-b29b-c81d60d4fcc7}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b")
			};
			parametrizedElement.Parameters.Add(templateIdParameter);
			var senderEmailParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("85c9eaf8-db1d-4ce6-8bf1-cc26c5dc3888"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"SenderEmail",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText")
			};
			senderEmailParameter.SourceValue = new ProcessSchemaParameterValue(senderEmailParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#SysSettings.SupportServiceEmail<String>#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b")
			};
			parametrizedElement.Parameters.Add(senderEmailParameter);
			var subjectParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("b8920a1d-2eef-4cc5-868f-8019b825a0f2"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"Subject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText")
			};
			subjectParameter.SourceValue = new ProcessSchemaParameterValue(subjectParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(subjectParameter);
			var parentActivityIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("87f97434-3e0f-4951-968e-ca47568beb0b"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"ParentActivityId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			parentActivityIdParameter.SourceValue = new ProcessSchemaParameterValue(parentActivityIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(parentActivityIdParameter);
			var isMultiLanguageEnabledParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ab3e353c-12b4-480d-bd63-47bf13e0d85f"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"IsMultiLanguageEnabled",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMultiLanguageEnabledParameter.SourceValue = new ProcessSchemaParameterValue(isMultiLanguageEnabledParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#BooleanValue.True#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b")
			};
			parametrizedElement.Parameters.Add(isMultiLanguageEnabledParameter);
			var isEstimateWithIconsEnabledParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("3330db69-5369-4399-8e81-1019cb2f7264"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"IsEstimateWithIconsEnabled",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isEstimateWithIconsEnabledParameter.SourceValue = new ProcessSchemaParameterValue(isEstimateWithIconsEnabledParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(isEstimateWithIconsEnabledParameter);
			var isMultilanguageV2EnabledParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("abc04395-1cd3-47f0-b8a4-b3149e331d9d"),
				ContainerUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				Name = @"IsMultilanguageV2Enabled",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			isMultilanguageV2EnabledParameter.SourceValue = new ProcessSchemaParameterValue(isMultilanguageV2EnabledParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce")
			};
			parametrizedElement.Parameters.Add(isMultilanguageV2EnabledParameter);
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("30fc86ce-b02b-4d00-8276-3f023dee5566"),
				ContainerUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
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
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("d46fb24f-a5d8-484e-bdc3-8065a7da191e"),
				ContainerUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeStartSignal2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("45d8dd87-236b-4301-8a97-113a71a04d29"),
				ContainerUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
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
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e405b39d-9a4f-4a66-a35a-707bdf998f1e"),
				ContainerUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeCatchTimerToReevaluateFirstParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var startOffsetParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("ee6b7a7e-e889-4f79-ade3-114e4895482d"),
				ContainerUId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"StartOffset",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startOffsetParameter.SourceValue = new ProcessSchemaParameterValue(startOffsetParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b")
			};
			parametrizedElement.Parameters.Add(startOffsetParameter);
		}

		protected virtual void InitializeCatchTimerToReevaluateSecondParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var startOffsetParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("4bbaea95-8c50-4f35-ac3c-93ca19ff3b2d"),
				ContainerUId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"StartOffset",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer")
			};
			startOffsetParameter.SourceValue = new ProcessSchemaParameterValue(startOffsetParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"0",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b")
			};
			parametrizedElement.Parameters.Add(startOffsetParameter);
		}

		protected virtual void InitializeIntermediateCatchSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("21c64e29-5cd9-4d94-8115-916f7cd44bda"),
				ContainerUId = new Guid("a09882fe-81f6-4ef9-9e42-724756f47811"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{139575f5-1fcd-4511-8b6e-8fcca638b068}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeIntermediateCatchSignal2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("82b2ecf5-25b4-4d60-9348-fef5039182d5"),
				ContainerUId = new Guid("de9e1342-9793-428a-b3b9-5eb41abcb92f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{139575f5-1fcd-4511-8b6e-8fcca638b068}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b")
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaSubProcess subprocesssendemail = CreateSubProcessSendEmailSubProcess();
			FlowElements.Add(subprocesssendemail);
			ProcessSchemaTerminateEvent terminate1086974 = CreateTerminate1086974TerminateEvent();
			FlowElements.Add(terminate1086974);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaStartSignalEvent startsignal2 = CreateStartSignal2StartSignalEvent();
			FlowElements.Add(startsignal2);
			ProcessSchemaExclusiveGateway exclusivegateway111111111111111111 = CreateExclusiveGateway111111111111111111ExclusiveGateway();
			FlowElements.Add(exclusivegateway111111111111111111);
			ProcessSchemaScriptTask startfirsttimerprocessingscripttask = CreateStartFirstTimerProcessingScriptTaskScriptTask();
			FlowElements.Add(startfirsttimerprocessingscripttask);
			ProcessSchemaIntermediateCatchTimerEvent catchtimertoreevaluatefirst = CreateCatchTimerToReevaluateFirstIntermediateCatchTimerEvent();
			FlowElements.Add(catchtimertoreevaluatefirst);
			ProcessSchemaScriptTask startsecondtimerprocessingscripttask = CreateStartSecondTimerProcessingScriptTaskScriptTask();
			FlowElements.Add(startsecondtimerprocessingscripttask);
			ProcessSchemaIntermediateCatchTimerEvent catchtimertoreevaluatesecond = CreateCatchTimerToReevaluateSecondIntermediateCatchTimerEvent();
			FlowElements.Add(catchtimertoreevaluatesecond);
			ProcessSchemaScriptTask closecasescripttask = CreateCloseCaseScriptTaskScriptTask();
			FlowElements.Add(closecasescripttask);
			ProcessSchemaIntermediateCatchSignalEvent intermediatecatchsignal1 = CreateIntermediateCatchSignal1IntermediateCatchSignalEvent();
			FlowElements.Add(intermediatecatchsignal1);
			ProcessSchemaTerminateEvent terminateevent1 = CreateTerminateEvent1TerminateEvent();
			FlowElements.Add(terminateevent1);
			ProcessSchemaIntermediateCatchSignalEvent intermediatecatchsignal2 = CreateIntermediateCatchSignal2IntermediateCatchSignalEvent();
			FlowElements.Add(intermediatecatchsignal2);
			ProcessSchemaTerminateEvent terminateevent2 = CreateTerminateEvent2TerminateEvent();
			FlowElements.Add(terminateevent2);
			ProcessSchemaEventBasedGateway eventbasedgateway1 = CreateEventBasedGateway1EventBasedGateway();
			FlowElements.Add(eventbasedgateway1);
			ProcessSchemaEventBasedGateway eventbasedgateway2 = CreateEventBasedGateway2EventBasedGateway();
			FlowElements.Add(eventbasedgateway2);
			FlowElements.Add(CreateSequenceFlow19546735SequenceFlow());
			FlowElements.Add(CreateSequenceFlow29868587SequenceFlow());
			FlowElements.Add(CreateSequenceFlow33453543SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4958986784SequenceFlow());
			FlowElements.Add(CreateSequenceFlow762532546SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8524524SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow165867ConditionalFlow());
			FlowElements.Add(CreateDefaultSequenceFlow17453654SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow234SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow262574684ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19546735SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19546735",
				UId = new Guid("6eb1d5ca-06f4-4c7c-8363-c0239f722300"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cd92481c-0570-43b4-b4b9-f7abce8bbe5a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(147, 313));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow29868587SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow29868587",
				UId = new Guid("83fd9fd3-2e4a-4b15-81e1-12326e12ee5a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cd92481c-0570-43b4-b4b9-f7abce8bbe5a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("14bba315-e0f3-4300-b097-2c089d9cdb14"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow33453543SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow33453543",
				UId = new Guid("ffff5dfd-220f-4f15-b936-978019d94507"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cd92481c-0570-43b4-b4b9-f7abce8bbe5a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(147, 113));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4958986784SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4958986784",
				UId = new Guid("a55a1fd5-64c4-4d2d-a32b-a2e097fe5d3f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d2c716a7-30a5-45f9-adbb-431118668991"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow762532546SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow762532546",
				UId = new Guid("ee0330fb-43c1-43e0-987c-0d4eb428141d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2c716a7-30a5-45f9-adbb-431118668991"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a92db02c-08c7-4f4a-881b-032d16da77f6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8524524SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8524524",
				UId = new Guid("36efe2c2-194e-45d4-b9e7-b88e5dcbfb2a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3d7d065a-195a-4be2-80d4-196d130f2023"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow165867ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow165867",
				UId = new Guid("b721b4be-1338-4df2-b3e6-08a78ca1c1eb"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{53928eba-9c90-4f6f-880b-0ca34bb3e439}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf1065a6-92fd-4c15-9139-11de754f136e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a92db02c-08c7-4f4a-881b-032d16da77f6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow17453654SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow17453654",
				UId = new Guid("19028fd2-7863-4257-a99c-87fdf6058309"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bf1065a6-92fd-4c15-9139-11de754f136e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(605, 187));
			schemaFlow.PolylinePointPositions.Add(new Point(607, 187));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow234SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow234",
				UId = new Guid("ec631169-2b03-49d1-b5b6-f48246ec3577"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("14bba315-e0f3-4300-b097-2c089d9cdb14"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7fbf168c-161b-4670-811f-36adfc384b38"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow262574684ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow262574684",
				UId = new Guid("c863baaa-bf59-4331-825f-f0e475e77b99"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{53928eba-9c90-4f6f-880b-0ca34bb3e439}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("14bba315-e0f3-4300-b097-2c089d9cdb14"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a92db02c-08c7-4f4a-881b-032d16da77f6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(245, 307));
			schemaFlow.PolylinePointPositions.Add(new Point(1032, 307));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("d4c828d9-7a8d-40e9-914b-3247cf8b6343"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bf1065a6-92fd-4c15-9139-11de754f136e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("3a950068-1a9d-414a-b97b-b64d4d66386a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a09882fe-81f6-4ef9-9e42-724756f47811"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45a66392-0072-4438-921e-1b2982c9157f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("db97009c-790a-4f1a-8c58-3d5df0f1645c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("de9e1342-9793-428a-b3b9-5eb41abcb92f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d72a53b-b9a7-4471-b91f-a83d19f67160"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("e19e28b3-5eff-4204-81d4-c8897e10cfe2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7fbf168c-161b-4670-811f-36adfc384b38"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a09882fe-81f6-4ef9-9e42-724756f47811"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(352, 155));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("1bc46ef2-9e0f-4796-922c-2a63920bb358"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7fbf168c-161b-4670-811f-36adfc384b38"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("284f9634-eb27-4872-a213-de4f5eb44b39"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d7d065a-195a-4be2-80d4-196d130f2023"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow11",
				UId = new Guid("f2390b1b-ad5e-4d53-b539-20469bc7364d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3d7d065a-195a-4be2-80d4-196d130f2023"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("de9e1342-9793-428a-b3b9-5eb41abcb92f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(738, 44));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("492956c3-9985-4387-9dba-30a80ab3301d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("492956c3-9985-4387-9dba-30a80ab3301d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1086974TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("a92db02c-08c7-4f4a-881b-032d16da77f6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"Terminate1086974",
				Position = new Point(1019, 221),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(20, 300),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal2StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"StartSignal2",
				NewEntityChangedColumns = false,
				Position = new Point(20, 100),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("a71adaea-3464-4dee-bb4f-c7a535450ad7");
			InitializeStartSignal2Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway111111111111111111ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("cd92481c-0570-43b4-b4b9-f7abce8bbe5a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"ExclusiveGateway111111111111111111",
				Position = new Point(120, 207),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateStartFirstTimerProcessingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("14bba315-e0f3-4300-b097-2c089d9cdb14"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"StartFirstTimerProcessingScriptTask",
				Position = new Point(211, 207),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,73,44,42,113,203,44,42,46,9,201,204,77,45,10,40,202,79,78,45,46,206,204,75,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,27,159,177,206,41,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaSubProcess CreateSubProcessSendEmailSubProcess() {
			ProcessSchemaSubProcess schemaSubProcessSendEmail = new ProcessSchemaSubProcess(this) {
				UId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				DragGroupName = @"SubProcess",
				EntitySchemaUId = Guid.Empty,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("49eafdbb-a89e-4bdf-a29d-7f17b1670a45"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"SubProcessSendEmail",
				Position = new Point(572, 102),
				SchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce"),
				SerializeToDB = true,
				Size = new Size(69, 55),
				TriggeredByEvent = false,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			InitializeSubProcessSendEmailParameters(schemaSubProcessSendEmail);
			return schemaSubProcessSendEmail;
		}

		protected virtual ProcessSchemaIntermediateCatchTimerEvent CreateCatchTimerToReevaluateFirstIntermediateCatchTimerEvent() {
			ProcessSchemaIntermediateCatchTimerEvent schemaCatchTimerEvent = new ProcessSchemaIntermediateCatchTimerEvent(this) {
				UId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("97d1af3d-ef13-465c-b6d8-5425f78bf000"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"CatchTimerToReevaluateFirst",
				Position = new Point(453, 221),
				Size = new Size(27, 27)
			};
			InitializeCatchTimerToReevaluateFirstParameters(schemaCatchTimerEvent);
			return schemaCatchTimerEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateStartSecondTimerProcessingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bf1065a6-92fd-4c15-9139-11de754f136e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"StartSecondTimerProcessingScriptTask",
				Position = new Point(571, 207),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,46,73,44,42,9,78,77,206,207,75,9,201,204,77,45,10,40,202,79,78,45,46,206,204,75,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,73,197,15,185,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateCatchTimerEvent CreateCatchTimerToReevaluateSecondIntermediateCatchTimerEvent() {
			ProcessSchemaIntermediateCatchTimerEvent schemaCatchTimerEvent = new ProcessSchemaIntermediateCatchTimerEvent(this) {
				UId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("97d1af3d-ef13-465c-b6d8-5425f78bf000"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"CatchTimerToReevaluateSecond",
				Position = new Point(853, 116),
				Size = new Size(27, 27)
			};
			InitializeCatchTimerToReevaluateSecondParameters(schemaCatchTimerEvent);
			return schemaCatchTimerEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCloseCaseScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d2c716a7-30a5-45f9-adbb-431118668991"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"CloseCaseScriptTask",
				Position = new Point(998, 102),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,201,47,78,117,78,44,78,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,225,243,46,39,25,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateIntermediateCatchSignal1IntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("a09882fe-81f6-4ef9-9e42-724756f47811"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = false,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"IntermediateCatchSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(414, 142),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("a71adaea-3464-4dee-bb4f-c7a535450ad7");
			InitializeIntermediateCatchSignal1Parameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("45a66392-0072-4438-921e-1b2982c9157f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"TerminateEvent1",
				Position = new Point(493, 142),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaIntermediateCatchSignalEvent CreateIntermediateCatchSignal2IntermediateCatchSignalEvent() {
			ProcessSchemaIntermediateCatchSignalEvent schemaCatchSignalEvent = new ProcessSchemaIntermediateCatchSignalEvent(this) {
				UId = new Guid("de9e1342-9793-428a-b3b9-5eb41abcb92f"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = false,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = false,
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("5ccad23d-fc4b-4ec7-8051-e3a825b698fc"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"IntermediateCatchSignal2",
				NewEntityChangedColumns = false,
				Position = new Point(853, 31),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaCatchSignalEvent.EntityChangedColumns.Add("a71adaea-3464-4dee-bb4f-c7a535450ad7");
			InitializeIntermediateCatchSignal2Parameters(schemaCatchSignalEvent);
			return schemaCatchSignalEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent2TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("2d72a53b-b9a7-4471-b91f-a83d19f67160"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"TerminateEvent2",
				Position = new Point(1020, 31),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaEventBasedGateway CreateEventBasedGateway1EventBasedGateway() {
			ProcessSchemaEventBasedGateway gateway = new ProcessSchemaEventBasedGateway(this) {
				UId = new Guid("7fbf168c-161b-4670-811f-36adfc384b38"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				ImageList = null,
				ImageName = null,
				Instantiate = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ddbda75-9cac-4e42-b94c-5cf1edb45846"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"EventBasedGateway1",
				Position = new Point(325, 207),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEventBasedGateway CreateEventBasedGateway2EventBasedGateway() {
			ProcessSchemaEventBasedGateway gateway = new ProcessSchemaEventBasedGateway(this) {
				UId = new Guid("3d7d065a-195a-4be2-80d4-196d130f2023"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("45c29e78-802b-45b9-a6e6-32a883774fbd"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6"),
				CreatedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				ImageList = null,
				ImageName = null,
				Instantiate = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0ddbda75-9cac-4e42-b94c-5cf1edb45846"),
				ModifiedInSchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"),
				Name = @"EventBasedGateway2",
				Position = new Point(710, 102),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ReevaluateCaseLevelRequestProcessV2(userConnection);
		}

		public override object Clone() {
			return new ReevaluateCaseLevelRequestProcessV2Schema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b"));
		}

		#endregion

	}

	#endregion

	#region Class: ReevaluateCaseLevelRequestProcessV2

	/// <exclude/>
	public class ReevaluateCaseLevelRequestProcessV2 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ReevaluateCaseLevelRequestProcessV2 process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: SubProcessSendEmailFlowElement

		/// <exclude/>
		public class SubProcessSendEmailFlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public SubProcessSendEmailFlowElement(UserConnection userConnection, ReevaluateCaseLevelRequestProcessV2 process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("7c391a20-e766-436b-8c18-fe98a522ddce");
			}

			#endregion

			#region Properties: Public

			public Guid CaseId {
				get {
					return GetParameterValue<Guid>("CaseId");
				}
				set {
					SetParameterValue("CaseId", value);
				}
			}

			public Guid TemplateId {
				get {
					return GetParameterValue<Guid>("TemplateId");
				}
				set {
					SetParameterValue("TemplateId", value);
				}
			}

			public string SenderEmail {
				get {
					return GetParameterValue<string>("SenderEmail");
				}
				set {
					SetParameterValue("SenderEmail", value);
				}
			}

			public string Subject {
				get {
					return GetParameterValue<string>("Subject");
				}
				set {
					SetParameterValue("Subject", value);
				}
			}

			public Guid ParentActivityId {
				get {
					return GetParameterValue<Guid>("ParentActivityId");
				}
				set {
					SetParameterValue("ParentActivityId", value);
				}
			}

			public bool IsMultiLanguageEnabled {
				get {
					return GetParameterValue<bool>("IsMultiLanguageEnabled");
				}
				set {
					SetParameterValue("IsMultiLanguageEnabled", value);
				}
			}

			public bool IsEstimateWithIconsEnabled {
				get {
					return GetParameterValue<bool>("IsEstimateWithIconsEnabled");
				}
				set {
					SetParameterValue("IsEstimateWithIconsEnabled", value);
				}
			}

			public bool IsMultilanguageV2Enabled {
				get {
					return GetParameterValue<bool>("IsMultilanguageV2Enabled");
				}
				set {
					SetParameterValue("IsMultilanguageV2Enabled", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (ReevaluateCaseLevelRequestProcessV2)owner;
				Name = "SubProcessSendEmail";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("fda14892-104a-48ed-85cb-0bc9b6c62463");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (ReevaluateCaseLevelRequestProcessV2)Owner;
				SetParameterValue("CaseId", (Guid)((process.CaseRecordId)));
				SetParameterValue("TemplateId", (Guid)((process.EmailTemplateId)));
				SetParameterValue("SenderEmail", new LocalizableString(((String)SysSettings.GetValue(UserConnection, "SupportServiceEmail"))));
				SetParameterValue("IsMultiLanguageEnabled", (bool)(true));
			}

			#endregion

		}

		#endregion

		#region Class: CatchTimerToReevaluateFirstFlowElement

		/// <exclude/>
		public class CatchTimerToReevaluateFirstFlowElement : ProcessIntermediateCatchTimerEvent
		{

			#region Constructors: Public

			public CatchTimerToReevaluateFirstFlowElement(UserConnection userConnection, ReevaluateCaseLevelRequestProcessV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchTimerEvent";
				Name = "CatchTimerToReevaluateFirst";
				IsLogging = true;
				SchemaElementUId = new Guid("553ce2c0-4662-49b8-a937-de141892e8e4");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private int _startOffset = 0;
			public override int StartOffset {
				get {
					return _startOffset;
				}
				set {
					_startOffset = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: CatchTimerToReevaluateSecondFlowElement

		/// <exclude/>
		public class CatchTimerToReevaluateSecondFlowElement : ProcessIntermediateCatchTimerEvent
		{

			#region Constructors: Public

			public CatchTimerToReevaluateSecondFlowElement(UserConnection userConnection, ReevaluateCaseLevelRequestProcessV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchTimerEvent";
				Name = "CatchTimerToReevaluateSecond";
				IsLogging = true;
				SchemaElementUId = new Guid("7ac2cdf4-9c14-4cf8-b583-3980fb41c88c");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private int _startOffset = 0;
			public override int StartOffset {
				get {
					return _startOffset;
				}
				set {
					_startOffset = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: IntermediateCatchSignal1FlowElement

		/// <exclude/>
		public class IntermediateCatchSignal1FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignal1FlowElement(UserConnection userConnection, ReevaluateCaseLevelRequestProcessV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignal1";
				IsLogging = true;
				SchemaElementUId = new Guid("a09882fe-81f6-4ef9-9e42-724756f47811");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = false;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""a71adaea-3464-4dee-bb4f-c7a535450ad7""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\"",\""key\"":\""\""}"",""dataSourceFilters"":""{\""items\"":{},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\""}""}";
				_recordId = () => (Guid)((process.CaseRecordId));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: IntermediateCatchSignal2FlowElement

		/// <exclude/>
		public class IntermediateCatchSignal2FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignal2FlowElement(UserConnection userConnection, ReevaluateCaseLevelRequestProcessV2 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignal2";
				IsLogging = true;
				SchemaElementUId = new Guid("de9e1342-9793-428a-b3b9-5eb41abcb92f");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = false;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""a71adaea-3464-4dee-bb4f-c7a535450ad7""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\"",\""key\"":\""\""}"",""dataSourceFilters"":""{\""items\"":{},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Case\""}""}";
				_recordId = () => (Guid)((process.CaseRecordId));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		public ReevaluateCaseLevelRequestProcessV2(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReevaluateCaseLevelRequestProcessV2";
			SchemaUId = new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_caseClosureCode = () => { return (Guid)(new Guid("b69f315c-f36b-1410-159b-0050ba5d6c38")); };
			_caseCloseStatus = () => { return (Guid)(new Guid("3e7f420c-f46b-1410-fc9a-0050ba5d6c38")); };
			_emailTemplateId = () => { return (Guid)(new Guid("291b7433-d6ca-43da-b194-2590d86369b2")); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1491372d-a6b4-4e69-80a9-4339b0bd808b");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ReevaluateCaseLevelRequestProcessV2, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ReevaluateCaseLevelRequestProcessV2, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid CaseRecordId {
			get;
			set;
		}

		public virtual bool IsCloseAndExit {
			get;
			set;
		}

		private Func<Guid> _caseClosureCode;
		public virtual Guid CaseClosureCode {
			get {
				return (_caseClosureCode ?? (_caseClosureCode = () => Guid.Empty)).Invoke();
			}
			set {
				_caseClosureCode = () => { return value; };
			}
		}

		private Func<Guid> _caseCloseStatus;
		public virtual Guid CaseCloseStatus {
			get {
				return (_caseCloseStatus ?? (_caseCloseStatus = () => Guid.Empty)).Invoke();
			}
			set {
				_caseCloseStatus = () => { return value; };
			}
		}

		private Func<Guid> _emailTemplateId;
		public virtual Guid EmailTemplateId {
			get {
				return (_emailTemplateId ?? (_emailTemplateId = () => Guid.Empty)).Invoke();
			}
			set {
				_emailTemplateId = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessTerminateEvent _terminate1086974;
		public ProcessTerminateEvent Terminate1086974 {
			get {
				return _terminate1086974 ?? (_terminate1086974 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1086974",
					SchemaElementUId = new Guid("a92db02c-08c7-4f4a-881b-032d16da77f6"),
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
					SchemaElementUId = new Guid("519da548-83ee-4a8d-b6df-a1239bac7a6a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal2;
		public ProcessStartSignalEvent StartSignal2 {
			get {
				return _startSignal2 ?? (_startSignal2 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal2",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("77985812-eb1a-4510-a968-989e18fef9ea"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway111111111111111111;
		public ProcessExclusiveGateway ExclusiveGateway111111111111111111 {
			get {
				return _exclusiveGateway111111111111111111 ?? (_exclusiveGateway111111111111111111 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway111111111111111111",
					SchemaElementUId = new Guid("cd92481c-0570-43b4-b4b9-f7abce8bbe5a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway111111111111111111.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _startFirstTimerProcessingScriptTask;
		public ProcessScriptTask StartFirstTimerProcessingScriptTask {
			get {
				return _startFirstTimerProcessingScriptTask ?? (_startFirstTimerProcessingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "StartFirstTimerProcessingScriptTask",
					SchemaElementUId = new Guid("14bba315-e0f3-4300-b097-2c089d9cdb14"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = StartFirstTimerProcessingScriptTaskExecute,
				});
			}
		}

		private SubProcessSendEmailFlowElement _subProcessSendEmail;
		public SubProcessSendEmailFlowElement SubProcessSendEmail {
			get {
				return _subProcessSendEmail ?? ((_subProcessSendEmail) = new SubProcessSendEmailFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private CatchTimerToReevaluateFirstFlowElement _catchTimerToReevaluateFirst;
		public CatchTimerToReevaluateFirstFlowElement CatchTimerToReevaluateFirst {
			get {
				return _catchTimerToReevaluateFirst ?? ((_catchTimerToReevaluateFirst) = new CatchTimerToReevaluateFirstFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _startSecondTimerProcessingScriptTask;
		public ProcessScriptTask StartSecondTimerProcessingScriptTask {
			get {
				return _startSecondTimerProcessingScriptTask ?? (_startSecondTimerProcessingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "StartSecondTimerProcessingScriptTask",
					SchemaElementUId = new Guid("bf1065a6-92fd-4c15-9139-11de754f136e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = StartSecondTimerProcessingScriptTaskExecute,
				});
			}
		}

		private CatchTimerToReevaluateSecondFlowElement _catchTimerToReevaluateSecond;
		public CatchTimerToReevaluateSecondFlowElement CatchTimerToReevaluateSecond {
			get {
				return _catchTimerToReevaluateSecond ?? ((_catchTimerToReevaluateSecond) = new CatchTimerToReevaluateSecondFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _closeCaseScriptTask;
		public ProcessScriptTask CloseCaseScriptTask {
			get {
				return _closeCaseScriptTask ?? (_closeCaseScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CloseCaseScriptTask",
					SchemaElementUId = new Guid("d2c716a7-30a5-45f9-adbb-431118668991"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CloseCaseScriptTaskExecute,
				});
			}
		}

		private IntermediateCatchSignal1FlowElement _intermediateCatchSignal1;
		public IntermediateCatchSignal1FlowElement IntermediateCatchSignal1 {
			get {
				return _intermediateCatchSignal1 ?? ((_intermediateCatchSignal1) = new IntermediateCatchSignal1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("45a66392-0072-4438-921e-1b2982c9157f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private IntermediateCatchSignal2FlowElement _intermediateCatchSignal2;
		public IntermediateCatchSignal2FlowElement IntermediateCatchSignal2 {
			get {
				return _intermediateCatchSignal2 ?? ((_intermediateCatchSignal2) = new IntermediateCatchSignal2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminateEvent2;
		public ProcessTerminateEvent TerminateEvent2 {
			get {
				return _terminateEvent2 ?? (_terminateEvent2 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent2",
					SchemaElementUId = new Guid("2d72a53b-b9a7-4471-b91f-a83d19f67160"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessExclusiveEventBasedGateway _eventBasedGateway1;
		public ProcessExclusiveEventBasedGateway EventBasedGateway1 {
			get {
				return _eventBasedGateway1 ?? (_eventBasedGateway1 = new ProcessExclusiveEventBasedGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventBasedGateway",
					Name = "EventBasedGateway1",
					SchemaElementUId = new Guid("7fbf168c-161b-4670-811f-36adfc384b38"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Events = new Collection<string> { "IntermediateCatchSignal1", "CatchTimerToReevaluateFirst", },
				});
			}
		}

		private ProcessExclusiveEventBasedGateway _eventBasedGateway2;
		public ProcessExclusiveEventBasedGateway EventBasedGateway2 {
			get {
				return _eventBasedGateway2 ?? (_eventBasedGateway2 = new ProcessExclusiveEventBasedGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventBasedGateway",
					Name = "EventBasedGateway2",
					SchemaElementUId = new Guid("3d7d065a-195a-4be2-80d4-196d130f2023"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Events = new Collection<string> { "CatchTimerToReevaluateSecond", "IntermediateCatchSignal2", },
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow165867;
		public ProcessConditionalFlow ConditionalSequenceFlow165867 {
			get {
				return _conditionalSequenceFlow165867 ?? (_conditionalSequenceFlow165867 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow165867",
					SchemaElementUId = new Guid("b721b4be-1338-4df2-b3e6-08a78ca1c1eb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow262574684;
		public ProcessConditionalFlow ConditionalSequenceFlow262574684 {
			get {
				return _conditionalSequenceFlow262574684 ?? (_conditionalSequenceFlow262574684 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow262574684",
					SchemaElementUId = new Guid("c863baaa-bf59-4331-825f-f0e475e77b99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessToken _startSecondTimerProcessingScriptTaskSubProcessSendEmailToken;
		public ProcessToken StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken {
			get {
				return _startSecondTimerProcessingScriptTaskSubProcessSendEmailToken ?? (_startSecondTimerProcessingScriptTaskSubProcessSendEmailToken = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken",
					SchemaElementUId = new Guid("515ff829-304b-4387-a843-fc7211856ea1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Terminate1086974.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1086974 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[StartSignal2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal2 };
			FlowElements[ExclusiveGateway111111111111111111.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway111111111111111111 };
			FlowElements[StartFirstTimerProcessingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { StartFirstTimerProcessingScriptTask };
			FlowElements[SubProcessSendEmail.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessSendEmail };
			FlowElements[CatchTimerToReevaluateFirst.SchemaElementUId] = new Collection<ProcessFlowElement> { CatchTimerToReevaluateFirst };
			FlowElements[StartSecondTimerProcessingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSecondTimerProcessingScriptTask };
			FlowElements[CatchTimerToReevaluateSecond.SchemaElementUId] = new Collection<ProcessFlowElement> { CatchTimerToReevaluateSecond };
			FlowElements[CloseCaseScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CloseCaseScriptTask };
			FlowElements[IntermediateCatchSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignal1 };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[IntermediateCatchSignal2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignal2 };
			FlowElements[TerminateEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent2 };
			FlowElements[EventBasedGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventBasedGateway1 };
			FlowElements[EventBasedGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventBasedGateway2 };
			FlowElements[StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1086974":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway111111111111111111", e.Context.SenderName));
						break;
					case "StartSignal2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway111111111111111111", e.Context.SenderName));
						break;
					case "ExclusiveGateway111111111111111111":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartFirstTimerProcessingScriptTask", e.Context.SenderName));
						break;
					case "StartFirstTimerProcessingScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EventBasedGateway1", e.Context.SenderName));
						if (ConditionalSequenceFlow262574684ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1086974", e.Context.SenderName));
							break;
						}
						Log.ErrorFormat(DeadEndGatewayLogMessage, "StartFirstTimerProcessingScriptTask");
						break;
					case "SubProcessSendEmail":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("EventBasedGateway2", e.Context.SenderName));
						break;
					case "CatchTimerToReevaluateFirst":
						EventBasedGateway1.CancelNonexecutedEvents("CatchTimerToReevaluateFirst");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartSecondTimerProcessingScriptTask", e.Context.SenderName));
						break;
					case "StartSecondTimerProcessingScriptTask":
						if (ConditionalSequenceFlow165867ExpressionExecute()) {
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1086974", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken", e.Context.SenderName));
						Log.ErrorFormat(DeadEndGatewayLogMessage, "StartSecondTimerProcessingScriptTask");
						break;
					case "CatchTimerToReevaluateSecond":
						EventBasedGateway2.CancelNonexecutedEvents("CatchTimerToReevaluateSecond");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CloseCaseScriptTask", e.Context.SenderName));
						break;
					case "CloseCaseScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1086974", e.Context.SenderName));
						break;
					case "IntermediateCatchSignal1":
						EventBasedGateway1.CancelNonexecutedEvents("IntermediateCatchSignal1");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "IntermediateCatchSignal2":
						EventBasedGateway2.CancelNonexecutedEvents("IntermediateCatchSignal2");
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent2", e.Context.SenderName));
						break;
					case "TerminateEvent2":
						CompleteProcess();
						break;
					case "EventBasedGateway1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignal1", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CatchTimerToReevaluateFirst", e.Context.SenderName));
						break;
					case "EventBasedGateway2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CatchTimerToReevaluateSecond", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignal2", e.Context.SenderName));
						break;
					case "StartSecondTimerProcessingScriptTaskSubProcessSendEmailToken":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SubProcessSendEmail", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow165867ExpressionExecute() {
			bool result = Convert.ToBoolean((IsCloseAndExit));
			Log.InfoFormat(ConditionalExpressionLogMessage, "StartSecondTimerProcessingScriptTask", "ConditionalSequenceFlow165867", "(IsCloseAndExit)", result);
			return result;
		}

		private bool ConditionalSequenceFlow262574684ExpressionExecute() {
			bool result = Convert.ToBoolean((IsCloseAndExit));
			Log.InfoFormat(ConditionalExpressionLogMessage, "StartFirstTimerProcessingScriptTask", "ConditionalSequenceFlow262574684", "(IsCloseAndExit)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CaseRecordId")) {
				writer.WriteValue("CaseRecordId", CaseRecordId, Guid.Empty);
			}
			if (!HasMapping("IsCloseAndExit")) {
				writer.WriteValue("IsCloseAndExit", IsCloseAndExit, false);
			}
			if (!HasMapping("CaseClosureCode")) {
				writer.WriteValue("CaseClosureCode", CaseClosureCode, Guid.Empty);
			}
			if (!HasMapping("CaseCloseStatus")) {
				writer.WriteValue("CaseCloseStatus", CaseCloseStatus, Guid.Empty);
			}
			if (!HasMapping("EmailTemplateId")) {
				writer.WriteValue("EmailTemplateId", EmailTemplateId, Guid.Empty);
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
			MetaPathParameterValues.Add("139575f5-1fcd-4511-8b6e-8fcca638b068", () => CaseRecordId);
			MetaPathParameterValues.Add("53928eba-9c90-4f6f-880b-0ca34bb3e439", () => IsCloseAndExit);
			MetaPathParameterValues.Add("1dd18ad4-0125-4b96-9e2d-6f2c3401376b", () => CaseClosureCode);
			MetaPathParameterValues.Add("1830b7fa-15a4-4836-af66-3bacbb623476", () => CaseCloseStatus);
			MetaPathParameterValues.Add("3b72b4ac-4c8f-4e6a-b29b-c81d60d4fcc7", () => EmailTemplateId);
			MetaPathParameterValues.Add("30fc86ce-b02b-4d00-8276-3f023dee5566", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("d46fb24f-a5d8-484e-bdc3-8065a7da191e", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("45d8dd87-236b-4301-8a97-113a71a04d29", () => StartSignal2.RecordId);
			MetaPathParameterValues.Add("e405b39d-9a4f-4a66-a35a-707bdf998f1e", () => StartSignal2.EntitySchemaUId);
			MetaPathParameterValues.Add("1b650b5e-22ff-46e0-ad2d-e25e8e700487", () => SubProcessSendEmail.CaseId);
			MetaPathParameterValues.Add("17055d89-452d-460d-9d37-22df0ac6b836", () => SubProcessSendEmail.TemplateId);
			MetaPathParameterValues.Add("85c9eaf8-db1d-4ce6-8bf1-cc26c5dc3888", () => SubProcessSendEmail.SenderEmail);
			MetaPathParameterValues.Add("b8920a1d-2eef-4cc5-868f-8019b825a0f2", () => SubProcessSendEmail.Subject);
			MetaPathParameterValues.Add("87f97434-3e0f-4951-968e-ca47568beb0b", () => SubProcessSendEmail.ParentActivityId);
			MetaPathParameterValues.Add("ab3e353c-12b4-480d-bd63-47bf13e0d85f", () => SubProcessSendEmail.IsMultiLanguageEnabled);
			MetaPathParameterValues.Add("3330db69-5369-4399-8e81-1019cb2f7264", () => SubProcessSendEmail.IsEstimateWithIconsEnabled);
			MetaPathParameterValues.Add("abc04395-1cd3-47f0-b8a4-b3149e331d9d", () => SubProcessSendEmail.IsMultilanguageV2Enabled);
			MetaPathParameterValues.Add("ee6b7a7e-e889-4f79-ade3-114e4895482d", () => CatchTimerToReevaluateFirst.StartOffset);
			MetaPathParameterValues.Add("4bbaea95-8c50-4f35-ac3c-93ca19ff3b2d", () => CatchTimerToReevaluateSecond.StartOffset);
			MetaPathParameterValues.Add("21c64e29-5cd9-4d94-8115-916f7cd44bda", () => IntermediateCatchSignal1.RecordId);
			MetaPathParameterValues.Add("82b2ecf5-25b4-4d60-9348-fef5039182d5", () => IntermediateCatchSignal2.RecordId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CaseRecordId":
					if (!hasValueToRead) break;
					CaseRecordId = reader.GetValue<System.Guid>();
				break;
				case "IsCloseAndExit":
					if (!hasValueToRead) break;
					IsCloseAndExit = reader.GetValue<System.Boolean>();
				break;
				case "CaseClosureCode":
					if (!hasValueToRead) break;
					CaseClosureCode = reader.GetValue<System.Guid>();
				break;
				case "CaseCloseStatus":
					if (!hasValueToRead) break;
					CaseCloseStatus = reader.GetValue<System.Guid>();
				break;
				case "EmailTemplateId":
					if (!hasValueToRead) break;
					EmailTemplateId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool StartFirstTimerProcessingScriptTaskExecute(ProcessExecutingContext context) {
			StartFirstTimerProcessing();
			return true;
		}

		public virtual bool StartSecondTimerProcessingScriptTaskExecute(ProcessExecutingContext context) {
			StartSecondTimerProcessing();
			return true;
		}

		public virtual bool CloseCaseScriptTaskExecute(ProcessExecutingContext context) {
			CloseCase();
			return true;
		}

			
			public virtual void StartFirstTimerProcessing() {
				CaseRecordId = Guid.Empty;
			IsCloseAndExit = false;
			if (StartSignal1.RecordId != Guid.Empty) {
				CaseRecordId = StartSignal1.RecordId;
			}
			if (StartSignal2.RecordId != Guid.Empty) {
				CaseRecordId = StartSignal2.RecordId;
			}
			var firstNumberWaitingDays =(int)Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "FirstReevaluationWaitingDays");
			if(firstNumberWaitingDays == 0) {
				IsCloseAndExit = true;
				return;
			}
			var totalSeconds = new TimeSpan(firstNumberWaitingDays, 0, 0, 0).TotalSeconds;
			CatchTimerToReevaluateFirst.StartOffset = Convert.ToInt32(totalSeconds);
			
			}
			
			
			public virtual void StartSecondTimerProcessing() {
				if(GetIsSatisfactionUpdateLevelExist() || GetIsCaseLevelExist()){
				IsCloseAndExit = true;
				return;
			}
			var secondNumberWaitingDays =(int)Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "SecondReevaluationWaitingDays");
			if(secondNumberWaitingDays <= 0){
				IsCloseAndExit = true;
				return;
			}
			var totalSeconds = new TimeSpan(secondNumberWaitingDays, 0, 0, 0).TotalSeconds;
			CatchTimerToReevaluateSecond.StartOffset = Convert.ToInt32(totalSeconds);
			
			}
			
			
			public virtual bool GetIsCaseLevelExist() {
				var caseSelect = new Select(UserConnection)
				.Column(Func.Count("Id"))
				.From("Case")
				.Where("Id").IsEqual(Column.Parameter(CaseRecordId))
				.And("SatisfactionLevelId").Not().IsNull() as Select;
			return caseSelect.ExecuteScalar<int>() > 0;
			
			}
			
			
			public virtual bool GetIsSatisfactionUpdateLevelExist() {
				var satisfactionUpdateSelect =  new Select(UserConnection)
				.Column(Func.Count("Id"))
				.From("SatisfactionUpdate")
				.Where("CaseId").IsEqual(Column.Parameter(CaseRecordId)) as Select;
			return satisfactionUpdateSelect.ExecuteScalar<int>() > 0;
			
			}
			
			
			public virtual void CloseCase() {
				if(GetIsSatisfactionUpdateLevelExist() || GetIsCaseLevelExist()){
				IsCloseAndExit = true;
				return;
			}
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchema = entitySchemaManager.GetInstanceByName("Case");
			Entity entityCase = entitySchema.CreateEntity(UserConnection);
			entityCase.UseAdminRights = false;
			if (entityCase.FetchFromDB(CaseRecordId))
			{
				entityCase.SetColumnValue("StatusId", CaseCloseStatus);
				entityCase.SetColumnValue("ClosureCodeId", CaseClosureCode);
				entityCase.SetColumnValue("ClosureDate", UserConnection.CurrentUser.GetCurrentDateTime());
				entityCase.Save(false);
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
			var cloneItem = (ReevaluateCaseLevelRequestProcessV2)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

