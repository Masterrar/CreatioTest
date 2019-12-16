namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITermIntervalSchema

	/// <exclude/>
	public class ITermIntervalSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITermIntervalSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITermIntervalSchema(ITermIntervalSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a8612d32-9e85-4a58-a2a0-2c095913c7e1");
			Name = "ITermInterval";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,203,106,195,48,16,60,59,144,127,88,232,165,189,216,247,36,228,98,104,200,33,80,168,219,251,214,94,59,162,122,4,105,85,48,37,255,94,89,126,196,109,72,232,109,53,154,217,217,157,213,168,200,157,176,36,40,200,90,116,166,230,52,55,186,22,141,183,200,194,232,229,226,123,185,72,188,19,186,129,215,214,49,169,245,114,17,144,7,75,77,248,134,92,162,115,43,40,132,162,208,65,197,191,44,203,96,227,188,82,104,219,237,240,142,60,40,141,102,20,154,44,212,198,2,31,9,56,8,65,104,38,251,133,114,212,102,51,241,201,127,72,81,66,25,245,23,155,164,27,107,154,226,89,144,172,194,24,47,145,28,135,24,133,55,246,74,115,148,164,43,180,46,237,154,190,105,193,80,180,39,130,216,55,105,136,215,177,112,67,113,158,181,12,227,194,59,74,255,47,242,206,139,10,70,179,125,117,71,18,23,10,180,126,167,240,234,177,57,52,11,126,5,251,46,181,58,220,46,148,93,40,251,41,197,27,55,152,4,96,106,8,165,154,130,239,227,77,239,228,47,38,237,47,175,77,177,29,111,113,101,217,35,7,226,163,169,194,173,145,193,18,123,171,93,239,93,75,108,162,101,114,109,58,64,3,127,91,92,248,155,108,4,35,173,128,29,241,1,221,231,227,211,186,79,236,79,94,231,31,165,175,24,147,226,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a8612d32-9e85-4a58-a2a0-2c095913c7e1"));
		}

		#endregion

	}

	#endregion

}

