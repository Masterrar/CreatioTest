namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageNotifierSchema

	/// <exclude/>
	public class PortalMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageNotifierSchema(PortalMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d380dfa-98cc-4b28-8b3b-626ea934efae");
			Name = "PortalMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3cbee395-bc39-4c92-abe2-fb401673f115");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,221,106,194,64,16,133,175,35,248,14,139,189,81,144,60,128,182,133,170,197,10,109,149,106,123,63,221,76,226,66,178,43,251,67,9,146,119,239,100,55,106,108,69,188,218,236,236,55,103,102,78,198,25,33,51,182,46,141,197,98,220,237,184,214,53,158,170,60,71,110,133,146,38,158,163,68,45,248,17,217,160,214,96,84,106,137,210,24,63,75,43,172,64,67,239,221,142,132,2,205,14,56,158,81,50,21,153,211,80,203,117,59,251,154,139,238,52,102,116,101,211,28,140,25,177,149,210,22,242,55,52,6,50,124,87,86,164,2,181,7,121,13,92,126,103,35,54,1,131,255,178,162,80,226,84,131,166,176,218,113,171,52,85,114,223,185,224,1,216,249,239,203,226,125,63,87,201,208,31,3,182,175,19,162,6,90,200,84,177,7,38,241,135,181,35,129,57,64,4,132,100,114,208,110,202,29,38,228,170,43,228,23,228,14,239,169,35,50,243,177,223,107,232,222,96,24,178,167,26,193,98,50,41,23,201,117,133,185,19,9,229,183,248,191,26,75,121,93,97,70,208,70,20,120,82,89,202,163,198,11,152,39,107,129,111,11,82,32,29,114,16,155,167,131,71,31,200,149,78,218,125,174,180,40,64,151,173,34,77,202,154,111,177,128,207,54,27,66,49,197,26,230,85,208,238,209,174,25,234,11,26,123,103,194,111,33,105,250,121,135,204,79,125,112,58,218,223,96,80,248,145,199,6,104,192,155,147,106,154,85,161,86,56,170,113,125,84,205,130,161,76,194,142,249,123,136,158,7,171,95,191,212,208,73,102,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d380dfa-98cc-4b28-8b3b-626ea934efae"));
		}

		#endregion

	}

	#endregion

}

