namespace Terrasoft.Configuration
{
	using Newtonsoft.Json;
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Globalization;
	using System.Threading;
	using System.Threading.Tasks;
	using Terrasoft.Common;
	using Terrasoft.Configuration.MandrillService;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Common.Json;
	using Terrasoft.Nui.ServiceModel.Extensions;

	#region Class: ContactServiceHelper

	/// <summary>
	/// Helper class for contact service.
	/// </summary>
	public class ContactServiceHelper
	{
		#region Constructors: Public

		public ContactServiceHelper(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Fields: Private

		private readonly UserConnection UserConnection;

		#endregion

		#region Properties: Public

		private RemindingUtilities _remindingUtilities;
		/// <summary>
		/// Utility methods for notification messages.
		/// </summary>
		public RemindingUtilities RemindingUtilities {
			get {
				return _remindingUtilities ??
					(_remindingUtilities = new RemindingUtilities());
			}
			set {
				_remindingUtilities = value;
			}
		}

		#endregion

		#region Methods: Private

		private string CreateReminding(EntitySchemaQuery contactEsq) {
			int totalContactCount = GetTotalContactCount(contactEsq);
			int applyingContactCount = GetApplyingContactCount(contactEsq);
			var remindingDescription = string.Format(GetLczStringValue("RemindingUpdateMessage"),
				applyingContactCount, totalContactCount);
			return remindingDescription;
		}

		private Update GetContactUpdate(Select contactsSelect) {
			Update contactUpdate = new Update(UserConnection, "Contact")
				.Set("IsNonActualEmail", Column.Const(false))
				.Where("Id").In(contactsSelect)
				.And("IsNonActualEmail").IsEqual(Column.Const(true)) as Update;
			return contactUpdate;
		}

		private Update GetContactCommunicationUpdate(Select contactsSelect) {
			Update contactCommunicationUpdate = new Update(UserConnection, "ContactCommunication")
				.Set("NonActual", Column.Const(false))
				.Set("NonActualReasonId", Column.Const(null))
				.Set("DateSetNonActual", Column.Const(null))
				.Where("CommunicationTypeId").IsEqual(Column.Parameter(Guid.Parse(CommunicationTypeConsts.EmailId)))
				.And("ContactId").In(contactsSelect) as Update;
			return contactCommunicationUpdate;
		}

		private EntitySchemaQuery GetContactEsq(string filters, Guid entitySchemaUId) {
			var jsonFilters = Json.Deserialize<Terrasoft.Nui.ServiceModel.DataContract.Filters>(filters);
			var esqFilters = jsonFilters.BuildEsqFilter(entitySchemaUId, UserConnection);
			var contactEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
			contactEsq.UseAdminRights = false;
			contactEsq.PrimaryQueryColumn.IsVisible = true;
			contactEsq.Filters.Add(esqFilters);
			return contactEsq;
		}

		private int GetTotalContactCount(EntitySchemaQuery contactEsq) {
			contactEsq.ResetSelectQuery();
			contactEsq.PrimaryQueryColumn.IsVisible = false;
			var countFunction = contactEsq.CreateAggregationFunction(AggregationTypeStrict.Count,
				contactEsq.RootSchema.GetPrimaryColumnName());
			var contactCount = contactEsq.AddColumn(countFunction);
			var entityCollection = contactEsq.GetEntityCollection(UserConnection);
			contactEsq.RemoveColumn(contactCount.Name);
			return entityCollection.Count > 0
				? entityCollection[0].GetTypedColumnValue<int>(contactCount.Name)
				: 0;
		}

		private int GetApplyingContactCount(EntitySchemaQuery contactEsq) {
			contactEsq.ResetSelectQuery();
			var countFunction = contactEsq.CreateAggregationFunction(AggregationTypeStrict.Count,
				contactEsq.RootSchema.GetPrimaryColumnName());
			contactEsq.AddColumn(countFunction);
			var contactCommunicationSelect = new Select(UserConnection)
				.Column("SubContactCommunication", "Id").As("Id")
				.From("ContactCommunication").As("SubContactCommunication")
				.Where("SubContactCommunication", "ContactId").IsEqual("Contact", "Id")
				.And("SubContactCommunication", "CommunicationTypeId")
					.IsEqual(Column.Parameter(Guid.Parse(CommunicationTypeConsts.EmailId)))
				.And("SubContactCommunication", "NonActual").IsEqual(Column.Const(true)) as Select;
			var select = contactEsq.GetSelectQuery(UserConnection)
				.And()
				.Exists(contactCommunicationSelect) as Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
					if (dr.Read()) {
						return UserConnection.DBTypeConverter.DBValueToInt(dr[0]);
					}
				}
			}
			return 0;
		}

		private string GetLczStringValue(string lczName) {
			var localizableStringName = string.Format("LocalizableStrings.{0}.Value", lczName);
			var localizableString = new LocalizableString(
				UserConnection.Workspace.ResourceStorage, "ContactService", localizableStringName);
			string value = localizableString.Value;
			if (value == null) {
				value = localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
			}
			return value;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Sets NonActual sign of email to false.
		/// </summary>
		/// <param name="args">Parameters object for update query.</param>
		public void SetActualEmailAction(object args) {
			var argsDictionary = (Dictionary<string, object>)args;
			var filters = (string)argsDictionary["filters"];
			var entitySchemaUIdAsString = (string)argsDictionary["entitySchemaUId"];
			Thread.CurrentThread.CurrentCulture = (CultureInfo)argsDictionary["Culture"];
			var entitySchemaUId = new Guid(entitySchemaUIdAsString);
			try {
				EntitySchemaQuery contactEsq = GetContactEsq(filters, entitySchemaUId);
				Select contactsSelect = contactEsq.GetSelectQuery(UserConnection);
				Update contactCommunicationUpdate = GetContactCommunicationUpdate(contactsSelect);
				Update contactUpdate = GetContactUpdate(contactsSelect);
				string description = CreateReminding(contactEsq);
				contactCommunicationUpdate.Execute();
				contactUpdate.Execute();
				RemindingConfig remindingConfig = new RemindingConfig(entitySchemaUId);
				remindingConfig.Description = description;
				remindingConfig.AuthorId = remindingConfig.ContactId = UserConnection.CurrentUser.ContactId;
				this.RemindingUtilities.CreateReminding(UserConnection, remindingConfig);
			} catch (Exception e) {
				MandrillUtilities.Log.Error("[ContactService.SetActualEmailAction]: ", e);
				throw e;
			}
		}

		/// <summary>
		/// Updates contacts asynchroniosly.
		/// </summary>
		/// <param name="filters">Collection of filters for update query.</param>
		/// <param name="entitySchemaUId">Identifier of entity schema.</param>
		public Task UpdateContactAsync(string filters, string entitySchemaUId) {
			CultureInfo culture = Thread.CurrentThread.CurrentCulture;
			var args = new Dictionary<string, object>();
			args.Add("filters", filters);
			args.Add("entitySchemaUId", entitySchemaUId);
			args.Add("Culture", culture);
			return Task.Factory.StartNew(SetActualEmailAction, args);
		}

		#endregion
	}

	#endregion
}

