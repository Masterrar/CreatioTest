namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactServiceSchema

	/// <exclude/>
	public class ContactServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactServiceSchema(ContactServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a");
			Name = "ContactService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("23e6b872-7cf2-4336-8046-3b06c9b28cbc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,77,111,218,64,16,61,59,82,254,195,136,92,64,66,230,158,4,34,18,53,42,149,72,80,0,229,128,170,106,177,199,100,213,253,112,118,214,84,168,234,127,239,236,218,16,130,92,122,243,190,153,121,251,230,237,140,141,208,72,165,200,16,22,232,156,32,91,248,244,193,154,66,110,42,39,188,180,230,242,226,247,229,69,82,145,52,27,152,239,200,163,78,231,232,182,50,195,169,205,81,221,156,11,166,227,204,203,109,164,57,159,247,138,235,143,132,15,33,12,179,24,173,99,57,199,175,28,110,152,11,30,148,32,186,6,214,233,69,230,27,166,152,177,106,14,33,228,56,246,61,96,99,42,159,208,51,81,201,82,214,82,73,191,123,193,247,74,58,212,104,60,117,143,15,65,15,12,225,63,37,33,43,109,128,188,23,46,41,171,181,146,25,100,65,217,137,48,184,134,123,65,120,144,153,4,67,15,189,204,156,45,209,121,137,220,208,44,146,196,70,146,210,5,231,240,132,235,43,42,206,134,31,89,11,90,123,148,12,6,3,184,165,74,107,225,118,163,61,48,49,228,133,97,45,182,104,101,76,15,149,131,227,210,166,171,86,13,173,96,108,45,217,160,135,225,168,93,37,220,221,65,183,61,50,4,131,191,90,121,187,75,66,199,1,131,89,24,166,94,239,38,222,67,231,238,25,194,86,168,10,99,230,159,218,154,43,52,121,109,123,115,110,222,96,138,254,205,230,39,15,208,234,227,11,106,187,69,130,66,137,13,60,89,195,3,94,9,5,133,179,122,47,28,132,201,15,223,97,122,43,35,179,184,3,255,48,57,34,165,112,66,131,225,109,28,118,10,169,60,58,234,140,30,235,15,240,22,8,21,70,190,200,155,222,14,98,65,123,61,79,40,207,235,60,123,67,45,150,147,188,51,170,63,129,133,188,87,8,50,15,9,133,228,87,63,166,89,61,179,107,81,231,241,242,36,43,94,194,137,217,218,159,216,173,109,98,99,59,179,231,249,162,211,135,165,147,11,212,165,10,115,202,232,28,125,237,199,23,45,164,34,78,184,183,249,110,238,119,42,132,153,103,138,68,98,131,7,52,125,117,162,44,49,239,199,215,12,251,132,228,31,173,211,194,127,42,168,161,244,27,89,211,231,39,160,210,26,194,243,121,113,41,247,243,187,181,50,135,19,117,93,242,46,252,109,26,179,251,208,156,79,204,235,53,35,221,186,52,203,50,231,214,155,208,152,118,38,235,30,232,78,121,234,57,76,146,214,73,172,231,243,24,100,228,47,176,125,191,171,155,5,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateRemindingUpdateMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateRemindingUpdateMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dcc3279a-ae13-4ada-8127-1557b79bc092"),
				Name = "RemindingUpdateMessage",
				CreatedInPackageId = new Guid("23e6b872-7cf2-4336-8046-3b06c9b28cbc"),
				CreatedInSchemaUId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a"),
				ModifiedInSchemaUId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a"));
		}

		#endregion

	}

	#endregion

}

