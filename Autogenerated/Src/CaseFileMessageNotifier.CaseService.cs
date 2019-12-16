using System;
using System.Collections.Generic;
using Terrasoft.Core.Entities;

namespace Terrasoft.Configuration
{

	#region Class: CaseFileMessageNotifier

	public class CaseFileMessageNotifier : BaseMessageNotifier
	{

		#region Constants: Private

		private const string FileUrlTemplate = "<a href=\'../rest/FileService/GetFile/{0}/{1}\'>{2}</a>";

		#endregion

		#region Fields: Private

		private readonly Guid _caseSchemaUid = Guid.Parse("117D32F9-8275-4534-8411-1C66115CE9CD");

		#endregion

		#region Constructor: Public

		/// <summary>
		/// Initialize new instance of <see cref="CaseFileMessageNotifier" />.
		/// </summary>
		/// <param name="entity">CaseFile entity.</param>
		public CaseFileMessageNotifier(Entity entity) {
			MessageInfo = new MessageInfo {
				Message = string.Format(FileUrlTemplate, entity.Schema.UId, entity.PrimaryColumnValue, entity.GetTypedColumnValue<string>("Name")),
				CreatedById = entity.GetTypedColumnValue<Guid>("CreatedById"),
				CreatedOn = entity.GetTypedColumnValue<DateTime>("CreatedOn"),
				HasAttachment = false,
				NotifierRecordId = entity.PrimaryColumnValue,
				SchemaUId = entity.Schema.UId,
				ListenersData = new Dictionary<Guid, Guid> {
					{ _caseSchemaUid, entity.GetTypedColumnValue<Guid>("CaseId") }
				}
			};
		}

		#endregion

	}

	#endregion

}


