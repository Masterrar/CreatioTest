﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventConditionalTransitionElementSchema

	/// <exclude/>
	public class EventConditionalTransitionElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventConditionalTransitionElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventConditionalTransitionElementSchema(EventConditionalTransitionElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3224a506-80e3-4d2f-ba1d-71b63408ef01");
			Name = "EventConditionalTransitionElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,91,111,26,71,20,126,38,82,254,195,132,74,41,150,96,169,193,33,137,13,68,220,156,82,53,78,100,156,228,33,170,170,241,238,193,158,118,217,37,51,179,56,174,149,255,222,51,151,101,119,205,94,136,149,168,125,1,118,230,204,185,126,251,157,51,4,116,5,98,77,93,32,23,192,57,21,225,82,58,147,48,88,178,171,136,83,201,194,224,241,163,187,199,143,106,145,96,193,21,89,220,10,9,171,147,123,207,40,239,251,224,42,97,225,188,134,0,56,115,119,100,126,103,193,231,100,241,12,110,36,74,43,99,191,137,48,72,54,210,78,172,86,69,59,28,138,214,157,119,60,116,65,136,100,95,173,78,232,106,77,217,85,176,112,175,97,69,201,224,254,161,120,223,201,10,162,18,84,243,19,135,43,12,141,76,124,42,196,49,153,109,32,144,152,33,143,169,128,169,127,193,105,32,244,239,153,15,43,220,211,135,62,77,65,160,158,55,161,7,232,209,26,184,188,109,156,97,170,209,118,93,107,56,199,172,99,6,32,201,93,189,137,231,106,239,5,189,130,139,219,181,146,76,116,108,87,157,179,80,126,96,130,93,250,208,36,111,64,210,88,187,85,94,160,59,45,117,240,71,133,127,191,82,145,104,176,113,238,231,220,200,219,208,192,5,47,215,181,60,181,59,126,173,163,75,159,185,196,85,185,174,78,53,57,38,169,237,5,124,142,0,205,159,250,225,205,182,22,181,59,93,143,164,138,104,95,210,64,98,37,223,113,182,161,18,204,254,218,60,16,87,237,19,33,185,194,206,30,217,44,43,232,73,161,226,170,92,20,150,225,196,70,3,129,103,2,202,137,142,71,174,12,185,10,80,39,211,72,180,219,109,210,23,209,106,69,249,237,48,94,152,194,146,70,190,212,190,153,83,206,86,182,157,22,182,101,169,44,72,227,128,40,182,168,125,45,49,154,242,145,132,75,34,175,49,55,126,24,64,129,105,189,178,166,156,174,72,128,153,25,212,69,24,113,23,234,195,185,46,36,18,23,42,233,11,64,45,28,150,131,122,165,143,245,246,208,233,183,181,198,111,139,173,26,142,198,181,3,165,181,118,140,145,49,209,48,75,77,18,68,190,111,62,31,152,162,112,125,251,95,101,104,199,128,199,92,121,17,158,195,37,11,188,250,112,202,52,220,209,29,34,67,194,245,42,17,134,106,193,104,20,63,19,230,137,114,165,248,27,37,13,243,214,135,239,244,19,113,45,33,91,125,63,182,112,154,227,106,181,36,158,254,235,136,33,153,169,207,33,73,7,221,204,107,43,233,0,12,6,20,10,46,169,128,45,10,178,58,50,7,12,42,106,121,111,61,178,129,81,224,228,237,106,150,169,253,9,249,36,164,218,43,158,87,95,120,98,131,4,227,44,176,65,83,159,253,3,111,47,255,66,33,235,156,83,192,98,7,39,41,180,22,241,206,41,3,223,187,79,169,185,208,94,24,2,228,176,230,32,208,160,158,49,20,64,5,40,131,224,225,150,113,65,35,166,128,142,44,167,90,54,45,139,189,130,48,45,233,50,216,135,46,19,205,25,135,181,245,125,220,254,164,186,162,106,148,219,150,91,191,235,253,114,58,154,116,122,207,90,221,23,221,78,235,168,51,122,217,26,117,58,71,173,110,175,55,238,117,143,142,198,47,198,163,175,117,221,27,99,192,207,103,65,180,2,78,113,6,232,27,104,22,148,206,66,234,10,36,25,12,115,123,14,121,250,148,60,49,89,116,230,226,12,217,233,45,255,120,205,36,44,212,72,216,40,75,172,69,248,171,12,180,112,40,200,130,171,191,227,236,112,31,173,56,102,109,143,57,179,213,90,154,87,113,216,200,160,49,183,72,115,12,205,69,112,8,164,77,42,137,220,190,235,228,154,10,164,209,220,18,62,176,120,135,189,23,179,78,183,59,110,61,63,122,54,105,29,77,15,167,173,209,236,121,167,53,158,246,38,221,151,147,211,238,248,176,251,181,222,36,115,49,251,130,142,196,39,241,125,68,118,183,116,51,23,239,49,103,247,182,50,245,222,48,46,35,234,147,203,48,244,243,171,120,71,176,198,39,24,14,126,148,229,230,125,192,112,68,194,32,49,255,108,201,96,219,93,116,69,202,123,191,202,191,1,218,220,75,1,203,252,170,109,40,223,114,181,22,138,153,117,64,22,154,94,206,97,73,48,255,147,28,25,67,96,53,14,50,226,65,190,150,39,3,221,58,201,171,220,109,39,118,235,152,120,102,162,105,40,111,13,86,20,88,42,249,11,107,123,29,26,2,11,165,134,68,73,22,47,48,97,33,194,157,171,60,146,21,194,194,163,146,34,134,168,7,133,3,84,172,119,123,146,108,66,76,232,104,189,246,111,21,178,166,168,226,3,245,35,104,168,95,231,90,151,85,25,183,6,213,73,156,156,3,86,202,68,43,110,152,116,175,137,93,116,38,17,87,61,70,207,215,113,173,92,212,179,207,104,123,108,123,88,69,107,177,150,94,131,212,238,244,13,157,196,175,170,242,27,37,254,62,73,217,174,154,126,99,195,5,189,48,49,56,198,55,194,228,32,215,152,5,195,241,238,214,55,98,34,213,212,170,165,171,186,200,71,206,20,59,41,220,16,13,156,141,138,160,136,118,118,198,164,27,117,156,103,135,59,245,10,167,6,60,5,141,143,70,172,61,36,82,221,204,114,230,166,44,16,181,124,140,171,70,162,129,24,123,25,12,102,101,173,128,73,172,121,48,18,166,50,85,197,110,230,194,161,73,150,212,23,80,168,117,15,248,54,75,231,2,59,139,87,182,147,9,130,70,149,139,146,0,110,8,139,147,174,123,11,83,203,250,238,178,157,210,205,235,182,149,43,43,170,225,59,49,156,40,5,94,162,218,170,170,28,90,177,166,177,138,188,170,134,186,255,18,173,61,190,150,197,28,171,66,169,30,155,213,253,229,123,36,8,111,46,15,201,207,255,239,194,145,45,91,184,102,63,176,108,152,180,198,119,185,136,60,180,242,165,151,149,189,81,1,95,192,141,164,26,227,50,153,50,35,179,155,248,144,154,211,202,199,144,109,162,236,31,125,169,63,123,172,209,221,141,134,154,176,48,224,192,78,126,81,230,49,206,144,26,97,18,119,147,249,165,60,101,105,251,182,191,222,179,54,184,103,207,222,50,227,153,101,16,15,85,233,245,152,179,68,241,95,122,166,143,25,126,156,7,232,139,158,186,99,36,228,36,97,39,182,131,162,195,185,209,237,115,190,34,65,133,42,44,56,119,182,75,174,158,102,53,187,136,107,255,2,244,230,49,25,207,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3224a506-80e3-4d2f-ba1d-71b63408ef01"));
		}

		#endregion

	}

	#endregion

}
