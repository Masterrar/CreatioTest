﻿namespace Terrasoft.Configuration.ExternalAccessPackage
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using global::Common.Logging;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;
	using Terrasoft.Core.Factories;
	using CoreConfig = Core.Configuration;

	#region Class: ExternalAccessListener

	/// <summary>
	/// Listener for 'ExternalAccess' entity events.
	/// </summary>
	/// <seealso cref="Terrasoft.Core.Entities.Events.BaseEntityEventListener" />
	[EntityEventListener(SchemaName = "ExternalAccess")]
	public class ExternalAccessListener : BaseEntityEventListener
	{

		#region Constants: Private

		private const string IdentityAddressSettingsName = "IdentityServerUrl";
		private const string ClientIdSettingsName = "IdentityServerClientId";
		private const string ClientSecretSettingsName = "IdentityServerClientSecret";
		private const string DefaultExternalAccessClientIdSettingName = "DefaultExternalAccessClientId";

		#endregion

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("ExternalAccess");

		#endregion

		#region Methods: Private

		private static void CheckSystemOperationRestrictedMode(object sender) {
			var entity = (Entity)sender;
			var userConnection = entity.UserConnection;
			if (userConnection.IsSystemOperationsRestricted) {
				throw new SystemOperationRestrictedException();
			}
		}

		private Dictionary<string, string> CheckAndLoadRequiredSysSettings(UserConnection userConnection,
				string[] settings) {
			var values = settings.ToDictionary(
				code => code,
				code => CoreConfig.SysSettings.GetValue(userConnection, code, "")
			);
			List<string> emptySettings = values.Where(keyValue => keyValue.Value.IsNullOrWhiteSpace())
				.Select(keyValue => keyValue.Key).ToList();
			if (emptySettings.IsNotEmpty()) {
				var errorTemplate = new LocalizableString(userConnection.ResourceStorage, "ExternalAccessListener",
					"LocalizableStrings.EmptySettingsMessage.Value").ToString();
				var errorMessage = string.Format(errorTemplate, string.Join(", ", emptySettings));
				throw new ValidateException(errorMessage);
			}
			return values;
		}

		private ITempAccessProxy GetTempAccessProxy(UserConnection userConnection,
				Dictionary<string, string> requiredSettings) {
			var serverAddressArg = new ConstructorArgument("serverUrl", requiredSettings[IdentityAddressSettingsName]);
			var clientIdArg = new ConstructorArgument("clientId", requiredSettings[ClientIdSettingsName]);
			var clientSecretArg = new ConstructorArgument("clientSecret", requiredSettings[ClientSecretSettingsName]);
			var tempAccessProxy = ClassFactory.Get<ITempAccessProxy>(serverAddressArg, clientIdArg, clientSecretArg);
			return tempAccessProxy;
		}

		private Guid LoadUserId(UserConnection userConnection, Guid contactId) {
			var select = (Select)new Select(userConnection)
				.From("SysAdminUnit")
				.Cols("Id")
				.Where("ContactId").IsEqual(Column.Parameter(contactId, "Guid"));
			var id = select.ExecuteScalar<Guid>();
			return id;
		}

		private void CheckGrantor(UserConnection userConnection, Guid userId) {
			if (userId != userConnection.CurrentUser.Id) {
				userConnection.DBSecurityEngine.CheckCanExecuteOperation("CanDelegateExternalAccess");
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Handles entity Saved event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs" /> instance containing the
		/// event data.</param>
		public override void OnInserting(object sender, EntityBeforeEventArgs e) {
			base.OnInserting(sender, e);
			var entity = (Entity)sender;
			var userConnection = entity.UserConnection;
			Dictionary<string, string> requiredSettings = CheckAndLoadRequiredSysSettings(userConnection, new string[] {
				IdentityAddressSettingsName,
				ClientIdSettingsName,
				ClientSecretSettingsName,
				DefaultExternalAccessClientIdSettingName
			});
			var resourceName = entity.PrimaryColumnValue.ToString();
			var expirationDate = entity.GetTypedColumnValue<DateTime>("DueDate");
			var userContactId = entity.GetTypedColumnValue<Guid>("GrantorId");
			var userId = LoadUserId(userConnection, userContactId);
			CheckGrantor(userConnection, userId);
			EntitySchemaColumn grantorColumn = entity.Schema.FindSchemaColumnByPath("Grantor");
			entity.LoadLookupDisplayValues(new EntitySchemaColumn[] { grantorColumn });
			var userName = entity.GetColumnDisplayValue(grantorColumn);
			var reason = entity.GetTypedColumnValue<string>("AccessReason");
			var reasonMessage = $"Granted by: {userName}, reason: {reason}";
			ITempAccessProxy tempAccessProxy = GetTempAccessProxy(userConnection, requiredSettings);
			string errorMessage = null;
			Exception accessGrantException = null;
			try {
				tempAccessProxy.GrantAccess(resourceName, reasonMessage, expirationDate, userId,
					new[] { requiredSettings[DefaultExternalAccessClientIdSettingName] });
				_log.Info($"Succesfully granted access by userId {userContactId} with reason: {reason}");
			} catch (ApiServerException ex) {
				errorMessage = new LocalizableString(userConnection.ResourceStorage, "ExternalAccessListener",
					"LocalizableStrings.AccessServerErrorMessage.Value").ToString();
				accessGrantException = ex;
			} catch (ApiServerConnectivityException ex) {
				var errorTemplate = new LocalizableString(userConnection.ResourceStorage, "ExternalAccessListener",
					"LocalizableStrings.ConnectivityErrorMessage.Value").ToString();
				errorMessage = string.Format(errorTemplate, requiredSettings[IdentityAddressSettingsName]);
				accessGrantException = ex;
			} catch (Exception ex) {
				errorMessage = $"Unexpected error during grant access by userId {userContactId}";
				throw new ApplicationException(errorMessage, ex);
			}
			if (accessGrantException != null) {
				e.IsCanceled = true;
				_log.Error($"Error during grant access by userId {userContactId}: {accessGrantException}");
				throw new ApplicationException(errorMessage);
			}
		}

		/// <summary>
		/// Handles entity Saving event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityBeforeEventArgs" /> instance containing the
		/// event data.</param>
		/// <exception cref="SystemOperationRestrictedException">Current user session is created using external access.
		/// </exception>
		public override void OnSaving(object sender, EntityBeforeEventArgs e) {
			CheckSystemOperationRestrictedMode(sender);
			base.OnSaving(sender, e);
		}

		/// <summary>
		/// Handles entity Deleting event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityBeforeEventArgs" /> instance containing the
		/// event data.</param>
		/// <exception cref="SystemOperationRestrictedException">Current user session is created using external access.
		/// </exception>
		public override void OnDeleting(object sender, EntityBeforeEventArgs e) {
			CheckSystemOperationRestrictedMode(sender);
			base.OnDeleting(sender, e);
		}

		#endregion

	}

	#endregion

}

