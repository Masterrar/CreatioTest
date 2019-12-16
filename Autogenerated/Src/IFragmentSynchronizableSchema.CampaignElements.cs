namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFragmentSynchronizableSchema

	/// <exclude/>
	public class IFragmentSynchronizableSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFragmentSynchronizableSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFragmentSynchronizableSchema(IFragmentSynchronizableSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d438be3-42dd-4256-9b99-40dbca5fc709");
			Name = "IFragmentSynchronizable";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,207,78,195,48,12,198,207,171,212,119,176,198,5,46,237,125,148,94,54,129,122,152,132,128,23,112,51,167,141,212,58,149,147,30,6,226,221,73,255,141,50,4,151,72,159,99,255,242,125,14,99,75,174,67,69,240,70,34,232,172,246,201,222,178,54,85,47,232,141,229,56,250,136,163,56,218,220,8,85,65,66,193,158,68,135,129,29,20,143,130,85,75,236,95,207,172,106,177,108,222,177,108,104,108,79,211,20,50,215,183,45,202,57,159,245,129,156,18,83,146,3,215,145,50,218,40,104,108,21,78,109,5,20,182,29,154,138,161,67,241,70,153,14,217,135,198,111,242,96,38,89,200,233,10,221,245,101,19,32,102,49,246,183,175,205,20,229,146,229,72,190,182,39,183,131,231,17,49,93,94,59,31,11,47,228,123,225,95,126,160,69,198,138,4,124,141,30,204,42,216,24,169,23,9,46,128,26,26,220,36,23,122,122,141,207,100,226,231,5,59,143,28,50,88,29,76,16,129,18,210,15,219,98,63,111,103,157,236,56,189,189,205,147,44,93,230,7,224,127,205,240,68,107,121,123,119,63,111,132,248,52,45,101,212,159,211,151,255,40,134,218,23,244,171,79,220,45,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d438be3-42dd-4256-9b99-40dbca5fc709"));
		}

		#endregion

	}

	#endregion

}

