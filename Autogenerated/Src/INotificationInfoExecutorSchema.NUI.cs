namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationInfoExecutorSchema

	/// <exclude/>
	public class INotificationInfoExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationInfoExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationInfoExecutorSchema(INotificationInfoExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70829de2-1828-4038-881b-1a16b2b88f30");
			Name = "INotificationInfoExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,77,10,194,48,16,133,215,22,122,135,89,234,166,57,128,165,27,113,209,77,23,226,5,210,48,145,64,155,41,147,9,40,226,221,77,91,171,133,34,12,243,243,120,31,111,188,238,49,12,218,32,92,145,89,7,178,82,156,200,91,119,139,172,197,145,207,179,103,158,237,148,82,80,134,216,247,154,31,213,231,174,189,32,219,17,181,196,224,73,156,117,102,98,0,239,104,226,184,21,11,171,86,240,16,219,206,25,112,95,190,110,86,112,237,45,157,39,158,56,153,83,122,234,155,7,38,161,249,155,185,13,157,21,70,137,236,67,117,153,231,15,130,32,90,176,40,213,226,24,145,150,168,131,249,23,220,31,142,73,122,229,89,170,55,239,66,216,42,53,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70829de2-1828-4038-881b-1a16b2b88f30"));
		}

		#endregion

	}

	#endregion

}

