namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICampaignJobDispatcherSchema

	/// <exclude/>
	public class ICampaignJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICampaignJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICampaignJobDispatcherSchema(ICampaignJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc8d4fc1-fb96-4b0b-924c-b75865ecfbef");
			Name = "ICampaignJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,77,79,220,48,16,61,131,196,127,24,133,67,91,169,74,238,176,187,151,173,168,22,9,169,130,237,15,112,236,73,98,20,219,169,199,134,174,80,255,123,39,206,38,16,62,4,135,85,47,61,206,120,252,222,155,231,25,91,97,144,58,33,17,182,232,189,32,87,133,124,237,108,165,235,232,69,208,206,158,28,63,156,28,31,69,210,182,134,155,29,5,52,231,83,188,118,30,215,194,116,66,215,246,70,54,104,4,44,103,56,30,243,241,60,159,23,50,8,195,156,122,172,153,3,54,54,160,175,88,197,25,108,198,186,75,87,126,211,44,45,112,189,79,213,69,81,192,130,162,49,194,239,86,251,248,26,59,143,132,54,16,24,12,141,83,4,149,243,112,235,74,250,4,70,88,81,163,225,211,124,188,94,60,185,223,197,178,213,18,244,72,254,38,247,209,67,226,159,228,94,13,76,103,240,35,33,12,135,207,213,165,68,223,172,138,45,18,88,252,29,122,89,73,94,104,16,168,67,169,43,141,10,228,104,209,4,83,60,199,89,116,194,11,3,150,95,107,153,81,114,48,91,109,25,101,65,136,32,61,86,203,236,229,107,100,197,10,92,121,139,50,36,214,123,45,27,224,214,160,107,133,165,124,81,36,208,215,57,42,237,113,171,13,14,179,144,173,46,56,134,192,9,144,41,51,186,60,67,185,115,90,77,45,51,209,231,87,6,100,16,255,21,198,244,197,140,8,230,188,95,206,63,224,237,33,173,149,51,177,63,55,106,112,57,90,253,43,34,104,197,163,212,3,123,112,213,132,189,111,137,231,136,130,176,18,255,133,177,223,163,126,108,110,18,123,8,87,175,209,184,59,158,87,218,179,169,180,75,7,180,246,99,158,246,201,176,131,251,166,159,217,254,109,169,113,177,85,80,34,40,108,49,160,122,105,208,32,157,237,161,185,63,27,245,78,199,52,109,233,255,176,160,143,253,30,114,69,79,209,170,225,123,76,241,159,225,127,159,37,57,247,23,174,169,116,8,111,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc8d4fc1-fb96-4b0b-924c-b75865ecfbef"));
		}

		#endregion

	}

	#endregion

}

