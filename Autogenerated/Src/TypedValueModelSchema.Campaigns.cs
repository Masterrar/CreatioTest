namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TypedValueModelSchema

	/// <exclude/>
	public class TypedValueModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TypedValueModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TypedValueModelSchema(TypedValueModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e563da35-a0e4-4fae-aeed-9e1cbe43a1ed");
			Name = "TypedValueModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,80,203,106,195,48,16,60,199,224,127,88,200,221,190,55,165,23,231,26,200,33,244,190,150,215,174,138,245,64,43,21,140,233,191,87,146,237,144,180,197,23,193,206,206,206,140,70,163,34,182,40,8,110,228,28,178,233,125,213,24,221,203,33,56,244,210,232,170,65,101,81,14,154,203,98,46,139,67,96,169,135,39,178,163,83,89,196,205,209,209,16,15,160,25,145,249,5,110,147,165,238,29,199,64,23,211,209,152,41,117,93,195,43,7,165,208,77,111,235,124,38,22,78,182,196,160,18,15,122,227,64,172,158,64,218,75,63,1,139,15,82,8,10,133,51,240,149,52,171,77,173,126,144,179,161,29,165,0,145,2,252,245,63,204,57,195,61,231,213,25,75,206,75,138,97,175,249,114,217,255,14,153,129,44,4,166,223,141,86,221,207,31,83,109,177,76,251,73,194,175,74,51,12,228,79,192,233,249,222,241,189,36,93,222,204,132,25,131,210,208,161,199,165,6,240,241,151,251,182,231,72,206,158,169,144,220,202,127,230,71,210,221,210,75,158,23,244,25,140,216,15,227,77,157,246,46,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e563da35-a0e4-4fae-aeed-9e1cbe43a1ed"));
		}

		#endregion

	}

	#endregion

}

