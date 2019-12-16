﻿namespace Terrasoft.Configuration.LDAP
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Linq;
	using global::Common.Logging;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Web.Common;

	#region Class: LDAPUtility

	public class SyncWithLDAPProcessHelper
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;
		private readonly Guid _allEmployeesGroupId = new Guid("{A29A3BA5-4B0D-DE11-9A51-005056C00008}");
		private readonly Guid _sspUsersGroupId = new Guid("{720B771C-E7A7-4F31-9CFB-52CD21C3739F}");
		private readonly ILog _log = LogManager.GetLogger("LDAP");

		#endregion

		#region Constructors: Public

		public SyncWithLDAPProcessHelper(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private DateTime? GetMinModifiedDateOfNewUsers() {
			var getMinModifiedDateOfNewUsers = (Select)new Select(_userConnection)
				.Column(Func.Min("ModifiedOn"))
				.From("SysLDAPSynchUser")
				.Where().Not().Exists(new Select(_userConnection)
					.Column(Column.Const(1))
					.From("SysAdminUnit")
					.Where("SysAdminUnit", "LDAPEntryId").IsEqual("SysLDAPSynchUser", "Id")
				);
			DateTime result = getMinModifiedDateOfNewUsers.ExecuteScalar<DateTime>();
			return (result == DateTime.MinValue) ? default(DateTime?) : result;
		}

		private void CheckUsersInGroup(LdapGroup group, Guid groupId, out DateTime? minModifiedDateOfNewUser) {
			int lusersCount;
			using (var ldapUtils = new LdapUtilities(_userConnection)) {
				lusersCount = ldapUtils.InsertMembersOfGroupToTable(group);
			}
			var delete = new Delete(_userConnection).From("SysUserInRole").
				Where("SysRoleId").IsEqual(Column.Parameter(groupId)).
				//And("User", "SynchronizeWithLDAP").IsEqual(Column.Parameter(true)).
				And().Exists(new Select(_userConnection).
					Column("Id").From("SysAdminUnit").
					Where("SysUserInRole", "SysUserId").IsEqual("SysAdminUnit", "Id").
					And("SynchronizeWithLDAP").IsEqual(Column.Parameter(true)).
					And("SysAdminUnit", "SysAdminUnitTypeValue").IsEqual(Column.Parameter((int)SysAdminUnitType.User)).
					And().Not().Exists(new Select(_userConnection).
						Column("Id").
						From("SysLDAPSynchUser").
						Where("SysLDAPSynchUser", "Id").IsEqual("SysAdminUnit", "LDAPEntryId")) as Select);
			var operationsCount = delete.Execute();
			_log.InfoFormat("{1} user(s) removed from folder {0}", group.Name, operationsCount);

			if (lusersCount < 1) {
				minModifiedDateOfNewUser = DateTime.MaxValue;
				return;
			}

			var insertSelect = new InsertSelect(_userConnection).
				Into("SysUserInRole").
				Set("CreatedOn", "ModifiedOn", "SysRoleId", "SysUserId").
				FromSelect(new Select(_userConnection)
					.Column(Column.Const(DateTime.Now))
					.Column(Column.Const(DateTime.Now))
					.Column(Column.Const(groupId))
					.Column("Id")
					.From("SysAdminUnit")
					.Where().Not().Exists(new Select(_userConnection).
						Column("Id").
						From("SysUserInRole").As("ur").
						Where("ur", "SysUserId").IsEqual("SysAdminUnit", "Id").
						And("ur", "SysRoleId").IsEqual(Column.Parameter(groupId)) as Select).
					And().Exists(new Select(_userConnection).
						Column("Id").
						From("SysLDAPSynchUser").
						Where("SysLDAPSynchUser", "Id").IsEqual("SysAdminUnit", "LDAPEntryId") as Select)
					.And("SysAdminUnit", "SysAdminUnitTypeValue").IsEqual(Column.Parameter((int)SysAdminUnitType.User)));
			operationsCount = insertSelect.Execute();
			_log.InfoFormat("{1} user(s) added to folder {0}", group.Name, operationsCount);


			var manager = _userConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(manager, "LDAPElement") {
				UseAdminRights = false
			};
			var primaryColumnName = query.AddColumn(query.RootSchema.GetPrimaryColumnName()).Name;
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "LDAPEntryId", group.Id));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.NotEqual, "Type", (int)SysAdminUnitType.User));
			var collection = query.GetEntityCollection(_userConnection);
			if (collection.Any()) {
				var ldapGroupId = collection[0].GetTypedColumnValue<Guid>(primaryColumnName);
				var deleteLdapGroup =
					new Delete(_userConnection)
					.From("LDAPUserInLDAPGroup")
					.Where("LDAPGroupId").IsEqual(Column.Parameter(ldapGroupId))
					.And().Exists(
						new Select(_userConnection).
							Column("Id")
						.From("LDAPElement")
						.Where("LDAPUserInLDAPGroup", "LDAPUserId").IsEqual("LDAPElement", "Id")
						.And("LDAPElement", "Type").IsEqual(Column.Const((int)SysAdminUnitType.User))
						.And().Not().Exists(
							new Select(_userConnection)
								.Column("Id")
							.From("SysLDAPSynchUser")
							.Where("SysLDAPSynchUser", "Id").IsEqual("LDAPElement", "LDAPEntryId")));
				deleteLdapGroup.Execute();

				var insertSelectGroup = new InsertSelect(_userConnection)
				.Into("LDAPUserInLDAPGroup")
				.Set("CreatedOn", "ModifiedOn", "LDAPGroupId", "LDAPUserId")
				.FromSelect(new Select(_userConnection)
					.Column(Column.Const(DateTime.Now))
					.Column(Column.Const(DateTime.Now))
					.Column(Column.Const(ldapGroupId))
					.Column("Id")
					.From("LDAPElement")
					.Where().Not().Exists(new Select(_userConnection).
						Column("Id").
						From("LDAPUserInLDAPGroup").As("ug").
						Where("ug", "LDAPUserId").IsEqual("LDAPElement", "Id").
						And("ug", "LDAPGroupId").IsEqual(Column.Parameter(ldapGroupId)) as Select)
					.And().Exists(new Select(_userConnection).
						Column("Id").
						From("SysLDAPSynchUser").
						Where("SysLDAPSynchUser", "Id").IsEqual("LDAPElement", "LDAPEntryId") as Select)
					.And("LDAPElement", "Type").IsEqual(Column.Const((int)SysAdminUnitType.User)));
				insertSelectGroup.Execute();
			}

			minModifiedDateOfNewUser = GetMinModifiedDateOfNewUsers();
			if (minModifiedDateOfNewUser.HasValue) {
				_log.InfoFormat("Minimal date of new users in group {0}: {1}", group.Name,
					minModifiedDateOfNewUser.Value);
			} else {
				_log.InfoFormat("Group {0} doesn't have a new users", group.Name);
			}
			var del = new Delete(_userConnection).
				From("SysLDAPSynchUser");
			del.Execute();
		}

		private void AddLicForUser(Guid userId) {
			string packageNames = SysSettings.GetValue(_userConnection, "LdapUserLicPackages", string.Empty);
			var packages = packageNames.IsNullOrWhiteSpace() ? null : new Collection<string>(packageNames.Split(';'));
			_userConnection.LicHelper.AddUserAvailableLicences(userId, packages);
		}

		private bool GetIsSSPUser(Guid userId) {
			Select isSSPUserSelect =
				new Select(_userConnection)
					.Column(Func.Count(Column.Const(1))).As("Count")
				.From("SysAdminUnit")
				.Where("Id").IsEqual(Column.Parameter(userId))
				.And("SysAdminUnitTypeValue").IsEqual(Column.Parameter(Core.DB.SysAdminUnitType.User))
				.And("ConnectionType").IsEqual(Column.Parameter(UserType.SSP)) as Select;
			bool isSSPUser = isSSPUserSelect.ExecuteScalar<int>() > 0;
			return isSSPUser;
		}

		private void AddLicForSSPUser(Guid userId) {
			SysAdminUtilities sysAdminUtilities = new SysAdminUtilities();
			Collection<string> packageNames = sysAdminUtilities.GetLicPackageNames(_userConnection, UserType.SSP);
			if (packageNames != null) {
				sysAdminUtilities.AddUserLicences(_userConnection, userId, packageNames);
			}
		}

		private void AddLicForSSPOrGeneralUser(Guid userId) {
			if (GetIsSSPUser(userId)) {
				AddLicForSSPUser(userId);
			} else {
				AddLicForUser(userId);
			}
		}

		private List<Guid> GetExistingContact(string FullName, string Phone, string Email) {
			List<Guid> contacts = new List<Guid>();
			var s = new Select(_userConnection).Column("Id").From("Contact")
						.Where("Name").IsEqual(Column.Parameter(string.IsNullOrEmpty(FullName) ? "" : FullName));

			if (!string.IsNullOrEmpty(Email)) {
				s.And().Exists(new Select(_userConnection).
					Column("Id").From("ContactCommunication").
					Where("Number").IsEqual(Column.Parameter(string.IsNullOrEmpty(Email) ? "" : Email)));
			}
			if (!string.IsNullOrEmpty(Phone)) {
				s.And().Exists(new Select(_userConnection).
					Column("Id").From("ContactCommunication").
					Where("Number").IsEqual(Column.Parameter(string.IsNullOrEmpty(Phone) ? "" : Phone)));
			}
			Select select = s as Select;
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						var val = dr.GetValue(0).ToString();
						contacts.Add(new Guid(val));
					}
				}
			}
			return contacts;
		}

		private Guid? GetIdByName(string name, string entityName, bool createNewIfNotFound) {
			if (string.IsNullOrEmpty(name)) {
				return null;
			}
			var select = new Select(_userConnection).
				Column("Id").
				From(entityName).
				Where("Name").IsEqual(Column.Parameter(name)) as Select;
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = select.ExecuteReader(dbExecutor)) {
					if (dataReader.Read()) {
						return dataReader.GetColumnValue<Guid>("Id");
					}
				}
			}
			if (createNewIfNotFound) {
				//todo find out is it necessary
			}
			return null;
		}

		private void ActualizeAdminUnitInRole() {
			var actualizeAdminUnitInRole = new StoredProcedure(_userConnection, "tsp_ActualizeAdminUnitInRole") {
				PackageName = _userConnection.DBEngine.CoreUtilitiesPackageName
			};
			var result = actualizeAdminUnitInRole.Execute();
			if (result == -1) {
				SysAdminUtilities.ReloadSysAdminUnitsCache(_userConnection);
			}
		}

		private void ImportUsers(DateTime? minModifiedDateOfNewUser, out DateTime? maxModificationDateOfLDAPEntry) {
			var createUsersAutomaticallyWhenLdapSynchronize = Core.Configuration.SysSettings.GetValue(_userConnection,
				"CreateUsersAutomaticallyWhenLdapSynchronize", false);
			if (!createUsersAutomaticallyWhenLdapSynchronize) {
				maxModificationDateOfLDAPEntry = default(DateTime?);
				return;
			}
			int users = 0;
			int errors = 0;

			#region GroupsLoad

			var groupSelect =
				new Select(_userConnection)
					.Column("LDAPEntryId")
					.Column("LDAPEntry")
					.Column("LDAPEntryDN")
				.From("SysAdminUnit")
				.Where("SynchronizeWithLDAP").IsEqual(Column.Parameter(true))
				.And("SysAdminUnitTypeValue").Not().IsEqual(Column.Parameter((int)SysAdminUnitType.User))
				.And("LDAPEntryId").Not().IsNull() as Select;
			var groupList = new List<LdapGroup>();
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader dr = groupSelect.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						string groupId = dr.GetValue(0).ToString();
						string groupName = dr.GetValue(1).ToString();
						string groupDn = dr.GetValue(2).ToString();
						groupList.Add(new LdapGroup(groupId, groupName, groupDn));
					}
				}
			}

			#endregion

			#region ExistingUsersLoad

			Select existedUsersSelect =
				new Select(_userConnection)
					.Column("Name")
				.From("SysAdminUnit")
				.Where("SysAdminUnitTypeValue").IsEqual(Column.Parameter(4)) as Select;
			var existingUsers = new List<string>();
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader dr = existedUsersSelect.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						existingUsers.Add(dr.GetValue(0).ToString());
					}
				}
			}

			#endregion

			#region ExistingJobsLoad

			var jobs = new Dictionary<Guid, string>();
			var jobsSelect =
				new Select(_userConnection)
					.Column("Id")
					.Column("Name")
				.From("Job");
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader dr = jobsSelect.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						var id = dr.GetColumnValue<Guid>("Id");
						var name = dr.GetColumnValue<string>("Name");
						jobs.Add(id, name);
					}
				}
			}

			#endregion

			_log.Info("Start LDAP sync!");
			var groupCount = 0;
			List<Guid> newUserIds = new List<Guid>();
			_log.InfoFormat("Found {0} LDAP group(s) to synchronize.", groupList.Count);
			var cultureSelect =
				new Select(_userConnection)
					.Column("Id")
				.From("SysCulture")
				.Where("Default").IsEqual(Column.Parameter(true)) as Select;
			Guid defaultSysCultureId = cultureSelect.ExecuteScalar<Guid>();
			DateTime lastUserModifiedOn = DateTime.MinValue;
			foreach (var groupItem in groupList) {
				Guid groupId;
				UserType connectionType;
				Select groupPropertiesSelect = new Select(_userConnection)
					.Column("Id")
					.Column("ConnectionType")
				.From("SysAdminUnit")
				.Where("SysAdminUnitTypeValue").Not().IsEqual(Column.Const((int)SysAdminUnitType.User))
					.And("LDAPEntry").IsEqual(Column.Parameter(groupItem.Name)) as Select;
				using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
					using (IDataReader dataReader = groupPropertiesSelect.ExecuteReader(dbExecutor)) {
						if (dataReader.Read()) {
							groupId = dataReader.GetColumnValue<Guid>("Id");
							connectionType = dataReader.GetColumnValue<UserType>("ConnectionType");
						} else {
							_log.ErrorFormat("Organizational role not found for LDAP group '{0}'",
								groupItem.Name);
							continue;
						}
					}
				}
				List<LdapUser> ldapUsers;
				using (var ldapUtils = new LdapUtilities(_userConnection)) {
					ldapUsers = ldapUtils.GetMembersOfGroup(groupItem, minModifiedDateOfNewUser);
				}
				_log.InfoFormat("Found {0} LDAP users to synchronize in LDAP group {1}", ldapUsers.Count,
					groupItem.Name);
				var sysAdminUnitSchema = _userConnection.EntitySchemaManager.FindInstanceByName("SysAdminUnit");
				var employeeSchema = _userConnection.EntitySchemaManager.FindInstanceByName("Employee");
				var contactSchema = _userConnection.EntitySchemaManager.FindInstanceByName("Contact");
				var usersCount = 0;
				foreach (var user in ldapUsers) {
					/*todo search in existing employees*/
					if (string.IsNullOrEmpty(user.FullName)) {
						continue;
					}
					if (lastUserModifiedOn < user.ModifiedOn) {
						lastUserModifiedOn = user.ModifiedOn;
					}
					Guid contactId;
					Guid accountId = GetAccountId(user);
					var ldapElementId = Guid.Empty;
					var ldapElementSchema = _userConnection.EntitySchemaManager.GetInstanceByName("LDAPElement");
					var ldapElementEntity = ldapElementSchema.CreateEntity(_userConnection);
					ldapElementEntity.UseAdminRights = false;
					var conditions = new Dictionary<string, object> {
						{ "LDAPEntryId", user.Id },
						{ "Type", (int)SysAdminUnitType.User }
					};
					if (ldapElementEntity.FetchFromDB(conditions)) {
						ldapElementId = ldapElementEntity.GetTypedColumnValue<Guid>("Id");
						ldapElementEntity.SetColumnValue("IsActive", user.IsActive);
						ldapElementEntity.Save();
					}

					var sysAdminUnitQuery = new EntitySchemaQuery(sysAdminUnitSchema);
					sysAdminUnitQuery.UseAdminRights = false;
					sysAdminUnitQuery.AddAllSchemaColumns();
					var contactNameColumn = sysAdminUnitQuery.AddColumn("Contact.Name");
					var contactAccountIdColumn = sysAdminUnitQuery.AddColumn("Contact.Account.Id");
					var entryIdFilter = sysAdminUnitQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
						"LDAPEntryId", user.Id);
					var userTypeFilter = sysAdminUnitQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
						"SysAdminUnitTypeValue", (int)SysAdminUnitType.User);
					sysAdminUnitQuery.Filters.Add(entryIdFilter);
					sysAdminUnitQuery.Filters.Add(userTypeFilter);
					var sysAdminUnitCollection = sysAdminUnitQuery.GetEntityCollection(_userConnection);
					var sysAdminUnit = sysAdminUnitCollection.FirstOrDefault();
					if (sysAdminUnit != null) {
						sysAdminUnit.SetColumnValue("LDAPEntryId", user.Id);
						sysAdminUnit.SetColumnValue("LDAPEntry", user.Name);
						sysAdminUnit.SetColumnValue("LDAPEntryDN", user.Dn);
						sysAdminUnit.SetColumnValue("Name", user.Name);
						sysAdminUnit.SetColumnValue("Active", user.IsActive);
						sysAdminUnit.SetColumnValue("SynchronizeWithLDAP", true);
						sysAdminUnit.SetColumnValue("UserPassword", string.Empty);
						if (ldapElementId != Guid.Empty) {
							sysAdminUnit.SetColumnValue("LDAPElementId", ldapElementId);
						}
						sysAdminUnit.Save();
						Guid userId = sysAdminUnit.GetTypedColumnValue<Guid>(sysAdminUnitSchema.PrimaryColumn.Name);
						string contactName = sysAdminUnit.GetTypedColumnValue<string>(contactNameColumn.Name);
						Guid contactAccountId = sysAdminUnit.GetTypedColumnValue<Guid>(contactAccountIdColumn.Name);
						if (contactName != user.FullName || accountId != contactAccountId) {
							contactId = sysAdminUnit.GetTypedColumnValue<Guid>("ContactId");
							var contact = contactSchema.CreateEntity(_userConnection);
							if (contact.FetchFromDB(contactId)) {
								contact.SetColumnValue("Name", user.FullName);
								contact.SetColumnValue("AccountId", accountId);
								contact.Save();
							}
						}

						AddUserToRolesIfNotExist(userId, groupId, connectionType);

						_log.InfoFormat("LDAP user {0} saved", user.Name);
						usersCount++;
						_log.InfoFormat("Progress: {0} users processed from {1}", usersCount, ldapUsers.Count);
						continue;
					}

					if (!user.IsActive) {
						_log.InfoFormat("User AD {0} - deactivated", user.Name);
						continue;
					}

					if (existingUsers.Any(x => x == user.Name)) {
						_log.InfoFormat("Bpm'online user has the LDAP username - {0}", user.Name);
						usersCount++;
						_log.InfoFormat("Progress: {0} users processed from {1}", usersCount, ldapUsers.Count);
						errors++;
						continue;
					}

					contactId = Guid.NewGuid();

					#region FindExistingContact
					bool empl = true;
					List<Guid> contactIds = LdapUtilities.GetExistingContactIds(_userConnection, user.FullName,
						user.Phone, user.Email);

					if (contactIds.Count > 1) {
						_log.InfoFormat("Several contacts found in bpm'online that can be duplicates of user {0}",
							user.Name);
						usersCount++;
						_log.InfoFormat("Progress: {0} users processed from {1}", usersCount, ldapUsers.Count);
						errors++;
						continue;
					} else if (contactIds.Count == 1) {
						contactId = contactIds.First();
						empl = false;
					}

					#endregion

					#region SkipCreateUserAndRoleIfContactAlreadyHaveUser

					if (contactIds.Any()) {
						using (var ldapUtils = new LdapUtilities(_userConnection)) {
							List<Guid> userIds = ldapUtils.GetUserIdsByContactId(contactId);
							if (userIds.Any()) {
								_log.InfoFormat("User is already created for the found bpm'online contact ({0})",
									user.FullName);
								usersCount++;
								_log.InfoFormat("Progress: {0} users processed from {1}", usersCount, ldapUsers.Count);
								errors++;
								continue;
							}
						}
					}

					#endregion

					#region CreateUser

					if (empl) {
						var contact = contactSchema.CreateEntity(_userConnection);
						contact.SetDefColumnValues();
						contact.SetColumnValue("Id", contactId);
						contact.SetColumnValue(employeeSchema.PrimaryColumn.Name, contactId);
						contact.SetColumnValue("Name", user.FullName);
						contact.SetColumnValue("AccountId", accountId);
						contact.SetColumnValue("Email", user.Email);
						contact.SetColumnValue("Phone", user.Phone);
						string jobTitle = user.JobTitle;
						Guid? jobId = GetJobIdByName(jobs, jobTitle);
						contact.SetColumnValue("JobId", jobId);
						contact.SetColumnValue("JobTitle", jobTitle);
						contact.Save();
					}
					Guid newUserId = Guid.NewGuid();
					sysAdminUnit = sysAdminUnitSchema.CreateEntity(_userConnection);
					sysAdminUnit.SetDefColumnValues();
					sysAdminUnit.SetColumnValue(sysAdminUnitSchema.PrimaryColumn.Name, newUserId);
					sysAdminUnit.SetColumnValue("SysAdminUnitTypeValue", (int)SysAdminUnitType.User);
					sysAdminUnit.SetColumnValue("ContactId", contactId);
					sysAdminUnit.SetColumnValue("LDAPEntryId", user.Id);
					sysAdminUnit.SetColumnValue("LDAPEntry", user.Name);
					sysAdminUnit.SetColumnValue("Name", user.Name);
					sysAdminUnit.SetColumnValue("SynchronizeWithLDAP", true);
					sysAdminUnit.SetColumnValue("Active", true);
					sysAdminUnit.SetColumnValue("UserPassword", string.Empty);
					sysAdminUnit.SetColumnValue("ConnectionType", connectionType);
					if (defaultSysCultureId != Guid.Empty) {
						sysAdminUnit.SetColumnValue("SysCultureId", defaultSysCultureId);
					}
					if (ldapElementId != Guid.Empty) {
						sysAdminUnit.SetColumnValue("LDAPElementId", ldapElementId);
					}
					try {
						sysAdminUnit.Save();
						newUserIds.Add(newUserId);
					} catch (Exception e) {
						_log.Error(e.Message, e);
						throw;
					}

					#endregion

					AddUserToRolesIfNotExist(newUserId, groupId, connectionType);

					_log.InfoFormat("LDAP user {0} saved", user.Name);
					usersCount++;
					_log.InfoFormat("Progress: {0} users processed from {1}", usersCount, ldapUsers.Count);
					users++;
				}
				_log.InfoFormat("LDAP group {0} processed", groupItem.Name);
				groupCount++;
				_log.InfoFormat("Progress: {0} groups processed from {1}", groupCount, groupList.Count);
			}

			#region Update users in all groups

			var sel =
				new Select(_userConnection)
					.Column("LDAPEntryId")
					.Column("LDAPEntry")
					.Column("LDAPEntryDN")
					.Column("Id")
					.Column("Name")
				.From("SysAdminUnit").Where("SynchronizeWithLDAP").IsEqual(Column.Parameter(true))
				.And("SysAdminUnitTypeValue").Not().IsEqual(Column.Parameter((int)SysAdminUnitType.User)) as Select;
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader dr = sel.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						var ldapEntryId = dr.GetValue(0).ToString();
						var ldapEntry = dr.GetValue(1).ToString();
						var ldapEntryDn = dr.GetValue(2).ToString();
						var groupId = new Guid(dr.GetValue(3).ToString());
						var ldapGroup = new LdapGroup(ldapEntryId, ldapEntry, ldapEntryDn);
						CheckUsersInGroup(ldapGroup, groupId, out _);
					}
				}
			}

			#endregion

			foreach (Guid newUserId in newUserIds) {
				AddLicForSSPOrGeneralUser(newUserId);
			}

			if (users > 0) {
				ActualizeAdminUnitInRole();
			}

			maxModificationDateOfLDAPEntry = lastUserModifiedOn > DateTime.MinValue ? lastUserModifiedOn :
				default(DateTime?);
			string syncResult = "LDAP synchronization completed";
			if (users > 0) {
				syncResult += string.Format(" Users added: {0}", users);
			}
			if (errors > 0) {
				syncResult += string.Format(" Errors: {0}", errors);
			}
			_log.InfoFormat("LDAP sync finished! SyncResult: {0}", syncResult);
		}

		private Guid GetAccountId(LdapUser user) {
			return GetIdByName(user.Company, "Account", false) ?? AccountConsts.OurCompanyAccountId;
		}

		private void AddUserToRolesIfNotExist(Guid userId, Guid groupId, UserType connectionType) {
			Guid mainGroupId = connectionType == UserType.SSP ? _sspUsersGroupId : _allEmployeesGroupId;
			AddUserToRoleIfNotExist(userId, mainGroupId);
			AddUserToRoleIfNotExist(userId, groupId);
		}

		private void AddUserToRoleIfNotExist(Guid userId, Guid groupId) {
			var userInRoleSelect =
				(Select)new Select(_userConnection)
					.Column(Func.Count(Column.Const(1)))
					.From("SysUserInRole")
					.Where("SysUserId").IsEqual(Column.Parameter(userId))
					.And("SysRoleId").IsEqual(Column.Parameter(groupId));
			int recordCount = userInRoleSelect.ExecuteScalar<int>();
			if (recordCount == 0) {
				var sysUserInRoleSchema = _userConnection.EntitySchemaManager.FindInstanceByName("SysUserInRole");
				Entity sysUserInRole = sysUserInRoleSchema.CreateEntity(_userConnection);
				sysUserInRole.UseAdminRights = false;
				sysUserInRole.SetDefColumnValues();
				sysUserInRole.SetColumnValue("SysUserId", userId);
				sysUserInRole.SetColumnValue("SysRoleId", groupId);
				sysUserInRole.Save();
			}
		}

		private void CheckAllLDAPUsersInEverySyncGroup(out DateTime? minModifiedDateOfNewUser) {
			var delete = new Delete(_userConnection).From("SysLDAPSynchGroup");
			delete.Execute();

			minModifiedDateOfNewUser = default(DateTime?);

			using (var ldapUtils = new LdapUtilities(_userConnection)) {
				int groupsCount = ldapUtils.InsertGroupsToTable();
				if (groupsCount < 1) {
					return;
				}
			}

			var update = new Update(_userConnection, "SysAdminUnit").
				Set("SynchronizeWithLDAP", Column.Parameter(false)).
				Set("LDAPEntryId", Column.Parameter(string.Empty)).
				Set("LDAPEntry", Column.Parameter(string.Empty)).
				Set("LDAPEntryDN", Column.Parameter(string.Empty)).
				Where("SynchronizeWithLDAP").IsEqual(Column.Parameter(true)).
				And("SysAdminUnitTypeValue").Not().IsEqual(Column.Parameter((int)SysAdminUnitType.User)).
				And().Not().Exists(new Select(_userConnection).
					Column("Id").
					From("SysLDAPSynchGroup").
					Where("SysLDAPSynchGroup", "Id").IsEqual("SysAdminUnit", "LDAPEntryId"));
			int operationsCount = update.Execute();

			delete = (Delete)new Delete(_userConnection).
				From("SysLDAPSynchGroup").
				Where().Exists(new Select(_userConnection).
					Column("Id").From("SysAdminUnit").
					Where("SysLDAPSynchGroup", "Id").IsEqual("SysAdminUnit", "LDAPEntryId").
					And("SysLDAPSynchGroup", "Name").IsEqual("SysAdminUnit", "LDAPEntry").
					And("SysLDAPSynchGroup", "Dn").IsEqual("SysAdminUnit", "LDAPEntryDN").
					And("SysAdminUnit", "SysAdminUnitTypeValue").Not()
						.IsEqual(Column.Parameter((int)SysAdminUnitType.User))).
				Or().Not().Exists(new Select(_userConnection).
					Column("Id").From("SysAdminUnit").
					Where("SysLDAPSynchGroup", "Id").IsEqual("SysAdminUnit", "LDAPEntryId").
					And("SysAdminUnit", "SysAdminUnitTypeValue").Not()
						.IsEqual(Column.Parameter((int)SysAdminUnitType.User)));
			delete.Execute();

			Select s =
				new Select(_userConnection)
					.Column("Id")
					.Column("Name")
					.Column("Dn")
				.From("SysLDAPSynchGroup");
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader dr = s.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						var ldapEntryId = dr.GetValue(0).ToString();
						var ldapEntry = dr.GetValue(1).ToString();
						var ldapEntryDn = dr.GetValue(2).ToString();
						update = new Update(_userConnection, "SysAdminUnit")
							.Set("LDAPEntry", Column.Parameter(ldapEntry))
							.Set("LDAPEntryDN", Column.Parameter(ldapEntryDn))
							.Where("LDAPEntryId").IsEqual(Column.Parameter(ldapEntryId))
							.And("SysAdminUnitTypeValue").Not().IsEqual(Column.Const((int)SysAdminUnitType.User));
						update.Execute();
						operationsCount++;
					}
				}
			}
			_log.InfoFormat("LDAP fields have been updated for {0} group(s)", operationsCount);

			delete = new Delete(_userConnection).
				From("SysLDAPSynchGroup");
			delete.Execute();

			var sel =
				new Select(_userConnection)
					.Column("LDAPEntryId")
					.Column("LDAPEntry")
					.Column("LDAPEntryDN")
					.Column("Id")
					.Column("Name")
				.From("SysAdminUnit")
				.Where("SynchronizeWithLDAP").IsEqual(Column.Parameter(true))
				.And("SysAdminUnitTypeValue").Not().IsEqual(Column.Parameter((int)SysAdminUnitType.User)) as Select;
			using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
				using (IDataReader dr = sel.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						var ldapEntryId = dr.GetValue(0).ToString();
						var ldapEntry = dr.GetValue(1).ToString();
						var ldapEntryDn = dr.GetValue(2).ToString();
						CheckUsersInGroup(new LdapGroup(ldapEntryId, ldapEntry, ldapEntryDn),
							new Guid(dr.GetValue(3).ToString()), out DateTime? minModifiedDate);
						if (minModifiedDate.HasValue && (!minModifiedDateOfNewUser.HasValue ||
								minModifiedDateOfNewUser.Value > minModifiedDate.Value)) {
							minModifiedDateOfNewUser = minModifiedDate;
						}
					}
				}
			}
		}

		#endregion

		#region Methods: Public

		public void SetEntryMaxModifiedOn(DateTime synchronizationDate) {
			if (GlobalAppSettings.FeatureUseSysSettingsEngine) {
				if (Core.Configuration.SysSettings.Exists(_userConnection, "LDAPEntryMaxModifiedOn")) {
					Core.Configuration.SysSettings.SetDefValue(_userConnection, "LDAPEntryMaxModifiedOn", synchronizationDate);
				}
			} else {
				var settings = new SysSettings(_userConnection);
				if (!settings.FetchFromDB("Code", "LDAPEntryMaxModifiedOn")) {
					return;
				}
				var updateSettingsValue = new Update(_userConnection, "SysSettingsValue")
					.Set("DateTimeValue", Column.Parameter(synchronizationDate))
					.Where("SysSettingsId").IsEqual(Column.Parameter(settings.GetColumnValue("Id")))
					.And("IsDef").IsEqual(Column.Parameter(true));
				updateSettingsValue.Execute();
			}
		}

		public Guid? GetJobIdByName(Dictionary<Guid, string> jobs, string name) {
			if (string.IsNullOrEmpty(name)) {
				return null;
			}
			foreach (KeyValuePair<Guid, string> item in jobs) {
				if (item.Value.Equals(name, StringComparison.InvariantCulture)) {
					return item.Key;
				}
			}
			var job = new Job(_userConnection);
			job.SetDefColumnValues();
			job.Name = name;
			job.Save();
			Guid jobId = job.Id;
			jobs.Add(jobId, name);
			return jobId;
		}

		public void CheckLDAPUsersWhichCanBeSynchronized() {
			try {
				using (var ldapUtils = new LdapUtilities(_userConnection)) {
					int usersCount = ldapUtils.InsertUsersToTable();
					if (usersCount < 1) {
						return;
					}
					var isActiveSubSelect = new Select(_userConnection)
						.Column("IsActive")
						.From("SysLDAPSynchUser")
						.Where("SysLDAPSynchUser", "Id").IsEqual("SysAdminUnit", "LDAPEntryId");
					var update = new Update(_userConnection, "SysAdminUnit")
						.Set("Active", isActiveSubSelect)
						.Where("SynchronizeWithLDAP").IsEqual(Column.Parameter(true))
						.And("SysAdminUnitTypeValue").IsEqual(Column.Parameter((int)SysAdminUnitType.User))
						.And().Exists(new Select(_userConnection)
							.Column("Id")
							.From("SysLDAPSynchUser")
							.Where("SysLDAPSynchUser", "Id").IsEqual("SysAdminUnit", "LDAPEntryId"));
					var operationCount = update.Execute();
					_log.InfoFormat("{0} users became active", operationCount);
					var delete = new Delete(_userConnection)
						.From("SysLDAPSynchUser")
						.Where().Not().Exists(new Select(_userConnection)
							.Column("Id").From("SysAdminUnit")
							.Where("SysLDAPSynchUser", "Id").IsEqual("SysAdminUnit", "LDAPEntryId"));
					delete.Execute();
					var currentUser = _userConnection.CurrentUser;
					DateTime currentDateTime = currentUser.GetCurrentDateTime();
					var select = new Select(_userConnection).Column("Name")
						.From("SysLDAPSynchUser")
						.Where("Id").IsEqual("SysAdminUnit", "LDAPEntryId")
							.And("SysLDAPSynchUser", "Name").IsNotEqual("SysAdminUnit", "LDAPEntry");
					update = new Update(_userConnection, "SysAdminUnit")
						.Set("ModifiedOn", Column.Parameter(currentDateTime))
						.Set("ModifiedById", Column.Parameter(currentUser.Id))
						.Set("LDAPEntry", select)
						.Where().Exists(select)
						.And("SysAdminUnitTypeValue").IsEqual(Column.Const((int)SysAdminUnitType.User)) as Update;
					operationCount = update.Execute();
					if (ldapUtils.IsPhoneNeedUpdate || ldapUtils.IsEmailNeedUpdate || ldapUtils.IsJobTitleNeedUpdate) {
						operationCount = 0;
						var jobs = new Dictionary<Guid, string>();
						var jobsSelect =
							new Select(_userConnection)
								.Column("Id")
								.Column("Name")
							.From("Job");
						var contactQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "Contact");
						contactQuery.AddAllSchemaColumns();
						EntitySchemaQueryColumn ldapEntryColumn = contactQuery.AddColumn("[SysAdminUnit:Contact].LDAPEntryId");
						contactQuery.UseAdminRights = false;
						string ldapEntryColumnName = ldapEntryColumn.Name;
						contactQuery.Filters.Add(contactQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
							"[SysAdminUnit:Contact].Active", true));
						contactQuery.Filters.Add(contactQuery.CreateFilterWithParameters(FilterComparisonType.IsNotNull,
							"[SysAdminUnit:Contact].LDAPEntryId"));
						contactQuery.Filters.Add(contactQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
							"[SysAdminUnit:Contact].SysAdminUnitTypeValue", (int)SysAdminUnitType.User));
						EntityCollection contacts = contactQuery.GetEntityCollection(_userConnection);
						var ldapUsersSelect =
							new Select(_userConnection)
								.Column("Id")
								.Column("Email")
								.Column("Phone")
								.Column("JobTitle")
							.From("SysLDAPSynchUser");
						using (DBExecutor dbExecutor = _userConnection.EnsureDBConnection()) {
							using (IDataReader dr = jobsSelect.ExecuteReader(dbExecutor)) {
								while (dr.Read()) {
									var id = dr.GetColumnValue<Guid>("Id");
									var name = dr.GetColumnValue<string>("Name");
									jobs.Add(id, name);
								}
							}
							using (IDataReader dr = ldapUsersSelect.ExecuteReader(dbExecutor)) {
								while (dr.Read()) {
									var ldapEntryId = dr.GetColumnValue<string>("Id");
									var email = dr.GetColumnValue<string>("Email");
									var phone = dr.GetColumnValue<string>("Phone");
									var jobTitle = dr.GetColumnValue<string>("JobTitle");
									Entity contact = contacts.Find(entity =>
										entity.GetTypedColumnValue<string>(ldapEntryColumnName) == ldapEntryId);
									if (contact == null) {
										_log.InfoFormat("Could not find contact for ldapEntryId={0}", ldapEntryId);
										continue;
									}
									if (ldapUtils.IsEmailNeedUpdate) {
										contact.SetColumnValue("Email", email);
									}
									if (ldapUtils.IsPhoneNeedUpdate) {
										contact.SetColumnValue("Phone", phone);
									}
									if (ldapUtils.IsJobTitleNeedUpdate) {
										Guid? jobId = GetJobIdByName(jobs, jobTitle);
										contact.SetColumnValue("JobId", jobId);
										contact.SetColumnValue("JobTitle", jobTitle);
									}
									contact.Save();
									operationCount++;
								}
							}
						}
					}
					_log.InfoFormat("LDAP fields have been updated for {0} user(s)", operationCount);
				}
			} catch (Exception e) {
				_log.Error(e.Message, e);
				throw;
			} finally {
				var del = new Delete(_userConnection).
					From("SysLDAPSynchUser");
				del.Execute();
			}
		}

		public void SyncWithLDAP() {
			try {
				// Checking for LDAP users that can be synchronized
				CheckLDAPUsersWhichCanBeSynchronized();

				// Checking if the LDAP users are part of the synchronized business units
				CheckAllLDAPUsersInEverySyncGroup(out DateTime? minModifiedDateOfNewUser);

				// Import users automatically
				ImportUsers(minModifiedDateOfNewUser, out DateTime? maxModificationDateOfLDAPEntry);

				if (maxModificationDateOfLDAPEntry.HasValue) {
					SetEntryMaxModifiedOn(maxModificationDateOfLDAPEntry.Value);
				}

			} catch (Exception e) {
				_log.Error(e.Message, e);
				throw;
			}
		}

		#endregion

	}

	#endregion

}

