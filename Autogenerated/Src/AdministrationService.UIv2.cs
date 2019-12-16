﻿namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Security;
	using System.ServiceModel;
	using System.ServiceModel.Web;
	using System.ServiceModel.Activation;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;
	using Terrasoft.Web.Http.Abstractions;

	#region Class: AdministrationService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public partial class AdministrationService
	{

		#region Properties: Public

		private UserConnection _userConnection;

		/// <summary>
		/// ################ ###########.
		/// </summary>
		public UserConnection UserConnection {
			get {
				return _userConnection ?? (_userConnection = HttpContext.Current.Session["UserConnection"] as UserConnection);
			}
			set {
				_userConnection = value;
			}
		}

		#endregion

		#region Constructors: Public

		public AdministrationService() {
		}

		public AdministrationService(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private string GetSessionId(Guid sessionRecordId) {
			string sessionId = null;
			Select getSessionIdSelect =
				new Select(UserConnection)
					.Column("SessionId")
					.From("SysUserSession")
					.Where("Id").IsEqual(Column.Parameter(sessionRecordId)) as Select;
			getSessionIdSelect.ExecuteReader((IDataReader dataReader) => {
				sessionId = dataReader.GetColumnValue<string>("SessionId");
			});
			return sessionId;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// ##### ######### ##### ### ######### ######.
		/// </summary>
		/// <param name="recordId">### ############.</param>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "TerminateSession", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public int TerminateSession(string recordId) {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			if (!Guid.TryParse(recordId, out Guid parsedRecordId)) {
				return -1;
			}
			string sessionId = GetSessionId(parsedRecordId);
			if (string.IsNullOrWhiteSpace(sessionId)) {
				return -1;
			}
			var userSessionManager = ClassFactory.Get<IUserSessionManager>();
			userSessionManager.Expire(sessionId);
			return 1;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ValidatePassword", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		/// <summary>
		/// ##### ######### ###### ## ############ ######## ############, ########### # #######.
		/// </summary>
		/// <param name="userName">### ############.</param>
		/// <param name="password">######, ####### ##### ############.</param>
		/// <returns>##### ##########, #### # ######## ######### #### ############# ########## SecurityException, ##### ###### ######.</returns>
		public string ValidatePassword(string userName, string password) {
			string validationMessage = string.Empty;
			try {
				password.ValidatePassword(UserConnection, userName);
			} catch (SecurityException ex) {
				validationMessage = ex.Message;
			}
			return validationMessage;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ActualizeAdminUnitInRole", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		/// <summary>
		/// ##### ######### ######## ######### "tsp_ActualizeAdminUnitInRole" ### ############ ############### #####.
		/// </summary>
		/// <returns>True, #### ######### ########### #######, ##### False.</returns>
		public bool ActualizeAdminUnitInRole() {
			UserConnection.DBSecurityEngine.CheckCanExecuteOperation("CanManageAdministration");
			var actualizeAdminUnitInRole = new StoredProcedure(UserConnection, "tsp_ActualizeAdminUnitInRole") as StoredProcedure;
			actualizeAdminUnitInRole.PackageName = UserConnection.DBEngine.CoreUtilitiesPackageName;
			var result = (actualizeAdminUnitInRole.Execute() == -1);
			if (result) {
				SysAdminUtilities.ReloadSysAdminUnitsCache(UserConnection);
			}
			return result;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetChildAdminUnitsAndUsersCount",
			BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		/// <summary>
		/// ##### ## ########### ############## #### ####### ############## #### ########
		/// ############### ### ############## ##### # ########## ############# # #### #####.
		/// </summary>
		/// <param name="parentRoleId">############# ############### ### ##############
		/// ####.</param>
		/// <returns>#######, ######### ## #### ######### - ###### ###############
		/// ########### ##### # ####### ####, # ###### ####### - ########## #############
		/// # #### #####</returns>
		public Dictionary<string, object> GetChildAdminUnitsAndUsersCount(string parentRoleId) {
			object[] groups = GetChildAdminUnits(parentRoleId);
			var entitySchemaQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysAdminUnit");
			entitySchemaQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
				"[SysUserInRole:SysUser:Id].[SysAdminUnit:Id:SysRole].Id", groups));
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
				"SysAdminUnitTypeValue", Terrasoft.Core.DB.SysAdminUnitType.User));
			EntityCollection entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			var result = new Dictionary<string, object>();
			result.Add("deletedItems", groups);
			result.Add("userCount", entities.Count);
			return result;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetChildAdminUnits", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		/// <summary>
		/// ##### ## ########### ############## #### ###### ###### # ########## ############## #### ######## ###############
		/// (###########, #############, ############ ### #######) ### ############## ##### ####### ##########.
		/// </summary>
		/// <param name="parentRoleId">############# ############### ### ############## ####.</param>
		/// <returns>###### ############### #### ########### ############### #####, ####### ##########.</returns>
		public object[] GetChildAdminUnits(string parentRoleId) {
			Query adminUnitSelect =
				new Terrasoft.Core.DB.Select(UserConnection).Column("Id")
					.As("Id")
					.Column("Name")
					.As("Name")
					.Column("ParentRoleId")
					.As("ParentRoleId")
					.From("SysAdminUnit")
					.Where("SysAdminUnitTypeValue")
						.In(Column.Parameter(Terrasoft.Core.DB.SysAdminUnitType.Organisation, "AdminUnitType_Organisation", Common.ParameterDirection.Input),
							Column.Parameter(Terrasoft.Core.DB.SysAdminUnitType.Department, "AdminUnitType_Department", Common.ParameterDirection.Input),
							Column.Parameter(Terrasoft.Core.DB.SysAdminUnitType.Manager, "AdminUnitType_Manager", Common.ParameterDirection.Input),
							Column.Parameter(Terrasoft.Core.DB.SysAdminUnitType.Team, "AdminUnitType_Team", Common.ParameterDirection.Input),
							Column.Parameter(6, "AdminUnitType_FunctionalRole", Common.ParameterDirection.Input));
			adminUnitSelect.Parameters.Add(new QueryParameter("StartingUnitId", null));
			adminUnitSelect.Parameters.Add(new QueryParameter("MaxDepth", null));
			adminUnitSelect.InitializeParameters();
			HierarchicalSelectOptions options = new HierarchicalSelectOptions()
			{
				PrimaryColumnName = "Id",
				ParentColumnName = "ParentRoleId",
				SelectType = HierarchicalSelectType.Children,
				MaxDepthParameter = adminUnitSelect.Parameters.GetByName("MaxDepth")
			};
			QueryCondition startingCondition = options.StartingPrimaryColumnCondition;
			startingCondition.LeftExpression = new QueryColumnExpression("ParentRoleId");
			startingCondition.IsEqual(Column.Parameter(parentRoleId, "FolderId", Common.ParameterDirection.Input));
			string sqlText = UserConnection.DBEngine.GetQuerySqlText(adminUnitSelect as Select, options);
			var parameters = new QueryParameterCollection();
			parameters.Add(new QueryParameter()
			{
				Name = "AdminUnitType_Organisation",
				Value = Terrasoft.Core.DB.SysAdminUnitType.Organisation,
				ValueTypeName = "Integer"
			});
			parameters.Add(new QueryParameter()
			{
				Name = "AdminUnitType_Department",
				Value = Terrasoft.Core.DB.SysAdminUnitType.Department,
				ValueTypeName = "Integer"
			});
			parameters.Add(new QueryParameter()
			{
				Name = "AdminUnitType_Manager",
				Value = Terrasoft.Core.DB.SysAdminUnitType.Manager,
				ValueTypeName = "Integer"
			});
			parameters.Add(new QueryParameter()
			{
				Name = "AdminUnitType_Team",
				Value = Terrasoft.Core.DB.SysAdminUnitType.Team,
				ValueTypeName = "Integer"
			});
			parameters.Add(new QueryParameter()
			{
				Name = "AdminUnitType_FunctionalRole",
				Value = 6,
				ValueTypeName = "Integer"
			});
			parameters.Add(new QueryParameter()
			{
				Name = "FolderId",
				Value = parentRoleId,
				ValueTypeName = "Guid"
			});
			var list = new List<object>();
			list.Add(new Guid(parentRoleId));
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection())
			{
				using (IDataReader reader = dbExecutor.ExecuteReader(sqlText, parameters))
				{
					while (reader.Read())
					{
						Guid id = reader.GetColumnValue<Guid>("Id");
						list.Add(id);
					}
				}
			}
			return list.ToArray();
		}
		#endregion Methods: Public
	}
	#endregion Class: AdministrationService
}

