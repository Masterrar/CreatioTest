namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DevExpressAppEventListenerSchema

	/// <exclude/>
	public class DevExpressAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DevExpressAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DevExpressAppEventListenerSchema(DevExpressAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("43c7569b-ed28-41ff-bde2-1d974003ceee");
			Name = "DevExpressAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("72ee322a-d034-4f96-8457-df052341cb21");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,209,106,2,49,16,124,86,240,31,22,250,98,65,242,1,90,10,213,218,34,216,86,172,208,231,152,172,26,56,179,33,137,135,86,250,239,205,37,94,213,227,20,251,116,100,118,118,38,187,147,211,124,141,206,112,129,48,67,107,185,163,133,103,3,210,11,181,220,88,238,21,233,86,115,223,106,54,54,78,233,229,25,101,189,38,221,171,173,88,100,47,92,120,178,10,93,29,99,70,148,57,246,140,249,112,107,44,58,55,69,67,214,223,206,100,3,46,86,200,210,97,182,51,24,207,255,232,31,147,224,153,250,142,227,213,181,125,225,252,56,96,168,223,89,92,6,42,12,50,238,92,23,142,122,79,198,12,115,212,126,172,156,71,141,54,178,205,102,158,41,1,162,32,95,225,66,23,170,80,159,59,12,2,251,40,243,231,250,134,126,69,50,248,78,162,112,42,30,76,40,15,151,86,18,33,39,37,225,67,7,197,79,207,173,111,151,210,33,74,143,91,15,34,125,239,161,8,179,209,152,7,39,118,66,47,203,189,88,141,115,166,8,119,172,175,180,124,24,165,205,77,44,229,193,205,118,160,88,121,88,90,117,181,37,225,177,125,89,234,157,36,142,228,107,49,48,15,112,7,42,192,181,222,74,230,29,168,0,215,122,171,119,61,125,5,83,228,113,172,35,167,248,7,46,241,74,151,159,67,80,168,101,202,42,158,19,122,14,6,236,23,42,81,87,202,105,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("43c7569b-ed28-41ff-bde2-1d974003ceee"));
		}

		#endregion

	}

	#endregion

}

