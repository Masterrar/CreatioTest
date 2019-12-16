﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMessagePublisherSchema

	/// <exclude/>
	public class BaseMessagePublisherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMessagePublisherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMessagePublisherSchema(BaseMessagePublisherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69dcb355-a236-4771-bc8a-b1e104c699ab");
			Name = "BaseMessagePublisher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7c74fc90-4a57-4e68-9eda-fe0982d1250d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,219,106,219,64,16,125,150,193,255,48,77,95,20,48,242,123,156,164,52,113,18,76,73,9,113,210,215,178,145,70,246,130,180,50,123,113,17,193,255,222,217,139,28,73,150,82,10,198,246,238,142,206,156,153,115,70,107,20,23,27,88,215,74,99,185,152,78,76,107,153,220,86,69,129,169,230,149,80,201,3,10,148,60,61,134,188,160,148,76,85,185,166,40,137,35,219,201,157,208,92,115,84,116,62,157,8,86,162,218,177,20,59,81,34,231,27,35,153,205,50,157,188,79,39,17,125,190,74,220,208,26,110,11,166,212,5,220,48,133,143,168,20,219,224,147,121,43,184,218,162,180,128,209,206,174,82,96,111,74,75,150,106,72,109,252,96,56,92,192,234,20,34,122,119,48,199,124,247,28,139,140,18,62,73,190,103,26,253,225,124,62,135,75,101,202,146,201,250,186,217,88,114,215,23,218,130,42,7,87,25,48,145,193,158,21,134,254,210,94,238,176,146,35,194,188,13,177,243,9,64,34,203,42,81,212,109,188,75,42,134,90,57,3,255,123,13,191,209,118,177,246,228,150,76,179,69,96,141,34,243,196,199,170,168,52,201,135,153,63,222,53,203,0,12,78,156,122,157,110,177,100,63,169,2,184,10,39,201,93,185,211,245,194,62,212,125,240,72,247,85,161,36,233,132,119,71,111,249,15,122,68,107,135,210,186,226,19,138,15,134,103,129,224,51,166,149,204,86,25,188,195,6,245,2,148,253,58,52,228,198,178,16,29,42,198,164,186,146,159,164,25,178,74,220,43,206,116,150,179,150,84,39,74,245,133,58,7,107,232,40,234,33,94,245,48,93,167,163,19,153,41,110,64,121,138,236,245,229,10,30,80,147,101,75,166,107,26,89,83,138,95,214,133,241,185,139,62,156,170,17,58,23,58,245,136,122,91,117,92,223,200,238,61,234,164,24,201,224,203,11,126,218,217,0,217,14,32,106,194,20,197,72,125,201,139,172,9,215,67,157,173,178,179,25,84,70,15,192,248,66,34,137,218,72,49,152,198,231,129,111,142,172,183,47,77,188,192,63,110,35,30,131,28,116,209,104,119,70,60,228,213,176,29,242,255,226,70,245,61,147,160,220,116,81,31,186,22,72,218,179,247,200,4,249,79,210,43,86,175,200,180,76,164,120,83,219,129,140,251,19,26,26,97,129,125,51,237,200,186,211,228,150,102,83,99,96,208,77,22,158,242,79,36,116,246,61,43,185,120,230,155,173,86,4,144,179,66,161,15,225,57,196,95,66,220,61,234,116,123,47,171,114,121,19,119,13,119,222,20,24,253,63,137,134,197,26,245,18,243,150,32,42,216,213,107,50,74,150,70,58,112,205,233,126,97,233,22,226,143,110,56,107,185,201,225,226,244,173,217,99,109,41,180,189,220,131,72,126,96,61,235,227,38,109,59,30,218,166,244,129,99,3,55,108,40,119,121,5,55,249,139,108,207,165,54,172,128,125,69,35,23,94,72,29,59,29,27,222,114,91,71,221,53,219,127,50,248,180,246,187,189,205,134,219,74,104,148,57,221,208,131,183,229,199,133,203,155,184,177,75,149,216,118,74,88,140,100,62,252,5,206,123,152,143,127,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69dcb355-a236-4771-bc8a-b1e104c699ab"));
		}

		#endregion

	}

	#endregion

}
