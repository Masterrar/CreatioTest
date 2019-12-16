namespace Terrasoft.Configuration
{

	using System;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: MailingState

	/// <summary>
	/// Abstract class of mailing state.
	/// </summary>
	public abstract class MailingState
	{

		#region Properties: Public

		public MailingContext Context { get; private set; }

		#endregion

		#region Methods: Private

		private void CreateReminding(Entity entity, string lczStringName, string caption, params object[] parameters) {
			var description = parameters.Any() ? string.Format(GetLczStringValue(lczStringName), parameters)
				: GetLczStringValue(lczStringName);
			MailingUtilities.CreateReminding(Context.UserConnection, entity, description, caption);
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Creates the reminding.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="lczStringName">Name of the localizible string.</param>
		/// <param name="parameters">The parameters.</param>
		protected void CreateReminding(Entity entity, string lczStringName, params object[] parameters) {
			CreateReminding(entity, lczStringName, GetLczStringValue("RemindingMsgCaption"), parameters);
		}

		protected string GetLczStringValue(string lczName) {
			var localizableStringName = $"LocalizableStrings.{lczName}.Value";
			var localizableString = new LocalizableString(Context.UserConnection.Workspace.ResourceStorage,
				"CESMaillingProvider", localizableStringName);
			var value = localizableString.Value ??
				localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
			return value;
		}

		/// <summary>
		/// Sets the bulk email status.
		/// </summary>
		/// <param name="bulkEmailId">The bulk email identifier.</param>
		/// <param name="bulkEmailStatusId">The bulk email status identifier.</param>
		protected virtual void SetBulkEmailStatus(Guid bulkEmailId, Guid bulkEmailStatusId) {
			new Update(Context.UserConnection, "BulkEmail").WithHints(new RowLockHint())
				.Set("StatusId", Column.Parameter(bulkEmailStatusId)).Where("Id").IsEqual(Column.Parameter(bulkEmailId))
				.Execute();
		}

		#endregion

		#region Methods: Public
		
		/// <summary>
		/// Executes the state.
		/// </summary>
		/// <returns>Instance of <see cref="MailingResponse"/>.</returns>
		public abstract MailingResponse ExecuteState();

		/// <summary>
		/// Initializes this instance.
		/// </summary>
		public virtual void Initialize() { }

		/// <summary>
		/// Executes this state. Sets status of email by resulting response from <see cref="ExecuteState"/>.
		/// Creates reminding if needed.
		/// </summary>
		/// <returns>Instance of <see cref="MailingResponse"/>.</returns>
		public MailingResponse Execute() {
			var mailingResponse = ExecuteState();
			SetBulkEmailStatus(Context.BulkEmailEntity.PrimaryColumnValue, mailingResponse.StatusId);
			if (mailingResponse.RemindingLczStringCode != null) {
				CreateReminding(Context.BulkEmailEntity, mailingResponse.RemindingLczStringCode);
			}
			return mailingResponse;
		}

		/// <summary>
		/// Sets the context of sending.
		/// </summary>
		/// <param name="context">Instance of <see cref="MailingContext"/>.</param>
		public void SetContext(MailingContext context) {
			Context = context;
		}

		#endregion

	}

	#endregion

}

