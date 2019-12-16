namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IConfigurableMailingProviderSchema

	/// <exclude/>
	public class IConfigurableMailingProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IConfigurableMailingProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IConfigurableMailingProviderSchema(IConfigurableMailingProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cc13a695-7766-435a-88b7-db1edaea23f9");
			Name = "IConfigurableMailingProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,144,191,14,130,48,16,135,103,72,120,135,75,92,116,129,93,141,139,147,3,9,131,47,80,203,129,151,208,150,92,11,137,49,188,187,13,45,248,103,113,235,93,239,247,245,187,106,161,208,246,66,34,92,145,89,88,211,184,252,108,116,67,237,192,194,145,209,121,41,168,35,221,102,233,51,75,179,52,217,48,182,190,13,23,237,144,27,31,220,195,101,13,220,58,140,227,21,155,145,106,228,57,83,20,5,28,237,160,148,224,199,41,214,113,192,130,66,119,55,181,5,103,64,70,14,130,10,20,232,35,38,95,40,197,7,166,31,110,29,73,160,197,228,143,72,18,22,88,55,40,195,195,123,168,102,78,184,252,85,157,27,11,214,219,122,161,30,217,145,63,154,6,228,192,140,218,121,5,235,132,150,152,175,136,79,207,100,52,84,191,33,219,221,33,138,160,174,131,203,92,79,225,127,191,154,211,11,127,193,109,112,160,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cc13a695-7766-435a-88b7-db1edaea23f9"));
		}

		#endregion

	}

	#endregion

}

