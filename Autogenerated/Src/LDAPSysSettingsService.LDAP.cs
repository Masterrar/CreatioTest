﻿namespace Terrasoft.Configuration.LDAPSysSettingsService
{
	using System;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Core;
	using Terrasoft.Core.Scheduler;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.LDAP;
	using Terrasoft.Core.Entities;
	using Terrasoft.Web.Common;
	using CoreLdap = Terrasoft.Core.LDAP;

	#region Class: LDAPSysSettingsService

	/// <summary>
	/// ##### ####### ## ###### ## ######## ######## LDAP # ######### ##########
	/// </summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class LDAPSysSettingsService : BaseService
	{
		#region Constants: Private

		/// <summary>
		/// ### ######### ######### ######## ############# # LDAP.
		/// </summary>
		private const string LdapSyncIntervalSysSettingsCode = "LDAPSynchInterval";

		#endregion

		#region Fields: Private

		private static readonly object _lockObject = new object();

		#endregion

		#region Fields: Public

		private UserConnection _userConnection;
		public UserConnection CurrentUserConnection {
			get {
				return _userConnection ?? (_userConnection = GetUserConnectionFromHttpContext());
			}
			set {
				_userConnection = value;
			}
		}

		#endregion

		#region Methods: Private

		private UserConnection GetUserConnectionFromHttpContext() {
			return UserConnection;
		}

		/// <summary>
		/// ######## ############ ###### #################.
		/// </summary>
		/// <returns>############# ####### #################.</returns>
		private Guid GetParentSysAdminUnitId() {
			var adminUnitId = Guid.Empty;
			var manager = CurrentUserConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(manager, "SysAdminUnit");
			var primaryColumnName = query.AddColumn(query.RootSchema.GetPrimaryColumnName()).Name;
			query.Filters.Add(query.CreateIsNullFilter("ParentRole"));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "SysAdminUnitTypeValue", 0));
			var collection = query.GetEntityCollection(CurrentUserConnection);
			if (collection.Any()) {
				adminUnitId = collection[0].GetTypedColumnValue<Guid>(primaryColumnName);
			}
			return adminUnitId;
		}
		
		/// <summary>
		/// ######## ############# ###### LDAP.
		/// </summary>
		/// <param name="entryId">SID ###### LDAP.</param>
		/// <returns>############# ###### LDAP.</returns>
		private Guid GetLdapGroupId(string entryId) {
			var ldapGroupId = Guid.Empty;
			if (string.IsNullOrEmpty(entryId)) {
				return ldapGroupId;
			}
			var manager = CurrentUserConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(manager, "LDAPElement");
			var primaryColumnName = query.AddColumn(query.RootSchema.GetPrimaryColumnName()).Name;
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "LDAPEntryId", entryId));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.NotEqual, "Type",
				(int)Core.DB.SysAdminUnitType.User));
			var collection = query.GetEntityCollection(CurrentUserConnection);
			if (collection.Any()) {
				ldapGroupId = collection[0].GetTypedColumnValue<Guid>(primaryColumnName);
			}
			return ldapGroupId;
		}

		/// <summary>
		/// ######### ########## ######### LDAP.
		/// </summary>
		private void InsertLDAPElementValues() {
			CurrentUserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			var ldapGroups = new List<LdapGroup>();
			var ldapUsers = new List<LdapUser>();
			using (var ldapUtils = new LdapUtilities(CurrentUserConnection)) {
				ldapGroups = ldapUtils.GetGroups();
				InsertLDAPGroups(ldapGroups);
				foreach (var ldapGroup in ldapGroups) {
					var ldapGroupId = GetLdapGroupId(ldapGroup.Id);
					if (ldapGroupId == Guid.Empty) {
						continue;
					}
					ldapUsers = ldapUtils.GetMembersOfGroup(ldapGroup);
					if (ldapUsers.Count == 0) {
						continue;
					}
					InsertLDAPUsers(ldapUsers, ldapGroupId);
				}
			}
		}

		/// <summary>
		/// ######### ########## ##### LDAP.
		/// </summary>
		private void InsertLDAPGroups(List<LdapGroup> ldapElements) {
			foreach (var ldapElement in ldapElements) {
				var entity = new LDAPElement(CurrentUserConnection);
				var conditions = new Dictionary<string, object> {
					{ "LDAPEntryId", ldapElement.Id },
					{ "Type", (int)Core.DB.SysAdminUnitType.Team }
				};
				lock(_lockObject) {
					if (!entity.FetchFromDB(conditions)) {
						entity.SetDefColumnValues();
						entity.SetColumnValue("Type", (int)Core.DB.SysAdminUnitType.Team);
						entity.SetColumnValue("IsActive", true);
						entity.SetColumnValue("LDAPEntryId", ldapElement.Id);
					} else if (entity.Name == ldapElement.Name && entity.LDAPEntryDN == ldapElement.Dn) {
						continue;
					}
					entity.SetColumnValue("Name", ldapElement.Name);
					entity.SetColumnValue("LDAPEntryDN", ldapElement.Dn);
					entity.Save();
				}
			}
		}

		/// <summary>
		/// ######### ########## ############# LDAP.
		/// </summary>
		private void InsertLDAPUsers(List<LdapUser> ldapElements, Guid ldapGroupId) {
			var activeLdapElements = ldapElements.Where(item => item.IsActive).ToList();
			foreach (var ldapElement in activeLdapElements) {
				var entity = new LDAPElement(CurrentUserConnection);
				var conditions = new Dictionary<string, object> {
					{ "LDAPEntryId", ldapElement.Id },
					{ "Type", (int)Core.DB.SysAdminUnitType.User }
				};
				lock(_lockObject) {
					if (!entity.FetchFromDB(conditions)) {
						entity.SetDefColumnValues();
						entity.SetColumnValue("Type", (int)Core.DB.SysAdminUnitType.User);
						entity.SetColumnValue("IsActive", true);
						entity.SetColumnValue("LDAPEntryId", ldapElement.Id);
					}
					entity.SetColumnValue("Name", ldapElement.Name);
					entity.SetColumnValue("FullName", ldapElement.FullName);
					entity.SetColumnValue("Company", ldapElement.Company);
					entity.SetColumnValue("Email", ldapElement.Email);
					entity.SetColumnValue("Phone", ldapElement.Phone);
					entity.SetColumnValue("JobTitle", ldapElement.JobTitle);
					entity.SetColumnValue("LDAPEntryDN", ldapElement.Dn);
					entity.Save();
					Guid ldapUserId = entity.PrimaryColumnValue;
					var esqLdapLElement = new EntitySchemaQuery(CurrentUserConnection.EntitySchemaManager, "LDAPUserInLDAPGroup");
					esqLdapLElement.AddColumn("LDAPUser");
					esqLdapLElement.Filters.Add(esqLdapLElement.CreateFilterWithParameters(
						FilterComparisonType.Equal, "LDAPUser", ldapUserId));
					esqLdapLElement.Filters.Add(esqLdapLElement.CreateFilterWithParameters(
						FilterComparisonType.Equal, "LDAPGroup", ldapGroupId));
					var collection = esqLdapLElement.GetEntityCollection(CurrentUserConnection);
					if(collection.Count == 0) {
						var userInLDAPGroupEntity = new Terrasoft.Configuration.LDAPUserInLDAPGroup(CurrentUserConnection);
						userInLDAPGroupEntity.SetDefColumnValues();
						userInLDAPGroupEntity.SetColumnValue("LDAPUserId", ldapUserId);
						userInLDAPGroupEntity.SetColumnValue("LDAPGroupId", ldapGroupId);
						userInLDAPGroupEntity.Save();
					}
				}
			}
		}

		/// <summary>
		/// ############# ######## ## ######### ######### #########.
		/// </summary>
		/// <param name="code">### ######### #########.</param>
		/// <param name="value">######## ######### #########.</param>
		private void SetSysSettingsDefValue(string code, object value) {
			var sysSettings = new Terrasoft.Core.Configuration.SysSettings(CurrentUserConnection);
			if (sysSettings.FetchFromDB("Code", code)) {
				Terrasoft.Core.Configuration.SysSettings.SetDefValue(CurrentUserConnection, code, value);
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// ######### ######### ######### # ######### ########### ############# # LDAP.
		/// </summary>
		/// <param name="request">####### ######## ######### ######## LDAP #############.</param>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse SetSysSettingValues(Dictionary<string, string> request) {
			var response = new ConfigurationServiceResponse();
			try {
				var userConnection = GetUserConnectionFromHttpContext();
				userConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
				var newInterval = int.Parse(request[LdapSyncIntervalSysSettingsCode]);
				request.Where(sysSettings => sysSettings.Key != LdapSyncIntervalSysSettingsCode).ToList()
					.ForEach(sysSettings => SetSysSettingsDefValue(sysSettings.Key, sysSettings.Value));
				request.Where(sysSettings => sysSettings.Key == LdapSyncIntervalSysSettingsCode).ToList()
					.ForEach(sysSettings => SetSysSettingsDefValue(sysSettings.Key, newInterval));
				var scheduler = AppScheduler.GetSchedulerOrDefault("LdapQuartzScheduler");
				AppScheduler.ScheduleImmediateProcessJob("RunLDAPImport", "LDAP", "RunLDAPImport",
					CurrentUserConnection.Workspace.Name, CurrentUserConnection.CurrentUser.Name, 
					scheduler: scheduler);
				AppScheduler.ScheduleMinutelyProcessJob("SyncWithLDAPProcess", "LDAP", "SyncWithLDAPProcess",
					CurrentUserConnection.Workspace.Name, CurrentUserConnection.CurrentUser.Name, newInterval * 60,
					scheduler: scheduler);
			} catch (Exception e) {
				response.Exception = e;
			}
			return response;
		}

		/// <summary>
		/// ######## ######## ######### ######## LDAP #############.
		/// </summary>
		/// <param name="request">####### ######## ######### ######## LDAP #############.</param>
		[Obsolete("7.12.2 | Method is obsolete and will be removed in upcoming releases")]
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public Dictionary<string, string> GetSysSettingValues(Dictionary<string, string> request) {
			var response = new Dictionary<string, string>();
			request.ToList()
					.ForEach(sysSettings => {
						object sysSettingsValue;
						if (Terrasoft.Core.Configuration.SysSettings.TryGetValue(CurrentUserConnection, sysSettings.Key,
							out sysSettingsValue)) {
							if (sysSettingsValue == null) {
								sysSettingsValue = string.Empty;
							}
							response.Add(sysSettings.Key, sysSettingsValue.ToString());
						};
					});
			return response;
		}

		/// <summary>
		/// ######### ########## ########### ######### LDAP.
		/// </summary>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public void InsertLDAPElements() {
			InsertLDAPElementValues();
		}

		public void InsertLDAPElements(UserConnection userConnection) {
			_userConnection = userConnection;
			InsertLDAPElementValues();
		}

		#endregion
	}

	#endregion
}
