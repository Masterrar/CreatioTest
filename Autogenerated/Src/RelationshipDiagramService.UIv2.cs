namespace Terrasoft.Configuration 
{
	using System;
	using System.Data;
	using System.Collections.Generic;
	using System.ServiceModel;
	using System.ServiceModel.Web;
	using System.ServiceModel.Activation;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.DB;
	using Terrasoft.Web.Common;
	using System.Runtime.Serialization;

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class RelationshipDiagramService : BaseService
	{

		#region Methods: Private

		/// <summary>
		/// ########## ######### ### ########## ############## #######.
		/// </summary>
		/// <param name="select">######</param>
		/// <param name="hierarchicalSelectType">### ############## #######.</param>
		/// <returns>######### ### ########## ############## #######.</returns>
		private HierarchicalSelectOptions GetHierarchicalSelectOptions(Select select,
				HierarchicalSelectType hierarchicalSelectType) {
			var hierarhicalOptions = new HierarchicalSelectOptions {
				PrimaryColumnName = "Id",
				ParentColumnName = "ParentId",
				SelectType = hierarchicalSelectType,
				IncludeLevelColumn = true
			};
			QueryCondition startingCondition = hierarhicalOptions.StartingPrimaryColumnCondition;
			startingCondition.LeftExpression = new QueryColumnExpression("Id");
			startingCondition.IsEqual(select.Parameters.GetByName("StartingAccountId"));
			return hierarhicalOptions;
		}


		/// <summary>
		/// ########## ###### ### ####### ############.
		/// </summary>
		/// <param name="accountId">########## ############# ###########.</param>
		/// <param name="additionalColumnNames">###### ############## #######.</param>
		/// <returns>###### ### ####### ############.</returns>
		private Select GetSelectQuery(Guid accountId, IEnumerable<string> additionalColumnNames) {
			var accountTableESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Account");
			accountTableESQ.AddColumn("Id");
			accountTableESQ.AddColumn("Name");
			accountTableESQ.AddColumn("Parent");
			if (additionalColumnNames != null) {
				foreach (string columnName in additionalColumnNames) {
					accountTableESQ.AddColumn(columnName);
				}
			}
			Select accountSelect = accountTableESQ.GetSelectQuery(UserConnection);
			accountSelect.Parameters.Add(new QueryParameter("StartingAccountId", accountId, "Guid"));
			accountSelect.InitializeParameters();
			return accountSelect;
		}

		/// <summary>
		/// ######### ########## ############## ###### ######## ############# ########### # ###### #### #######.
		/// </summary>
		/// <param name="accountId">Id ###########.</param>
		/// <returns>########## ############# ###########.</returns>
		private Guid GetParentAccount(Guid accountId) {
			Guid result = Guid.Empty;
			int levelMax = Int32.MinValue;
			Select accountSelect = GetSelectQuery(accountId, null);
			HierarchicalSelectOptions hierarhicalOptions = GetHierarchicalSelectOptions(accountSelect, HierarchicalSelectType.Parents);
			string sqlText = UserConnection.DBEngine.GetQuerySqlText(accountSelect, hierarhicalOptions);
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = dbExecutor.ExecuteReader(sqlText, accountSelect.Parameters)) {
					while (reader.Read()) {
						int level = reader.GetColumnValue<int>("Level");
						if (level > levelMax) {
							result = reader.GetColumnValue<Guid>("Id");
							levelMax = level;
						}
					}
				}
			}
			return result;
		}

		/// <summary>
		/// ######### #### ######## ############ # ###### #### #######.
		/// </summary>
		/// <param name="accountId">########## ############# ###########.</param>
		/// <param name="additionalColumnNames">###### ######## ############## #######.</param>
		/// <returns>###### ######## ############.</returns>
		private List<AccountInfo> GetChildAccounts(Guid accountId, List<string> additionalColumnNames) {
			var resultList = new List<AccountInfo>();
			additionalColumnNames = additionalColumnNames ?? new List<string>();
			additionalColumnNames.Add("Type.Name");
			Select accountSelect = GetSelectQuery(accountId, additionalColumnNames);
			HierarchicalSelectOptions hierarhicalOptions = GetHierarchicalSelectOptions(accountSelect, HierarchicalSelectType.Children);
			string sqlText = UserConnection.DBEngine.GetQuerySqlText(accountSelect, hierarhicalOptions);
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = dbExecutor.ExecuteReader(sqlText, accountSelect.Parameters)) {
					while (reader.Read()) {
						Guid id = reader.GetColumnValue<Guid>("Id");
						string name = reader.GetColumnValue<string>("Name");
						string accountType = reader.GetColumnValue<string>("Type.Name");
						int level = reader.GetColumnValue<int>("Level");
						Guid parentId = reader.GetColumnValue<Guid>("ParentId");
						var additionalColumnValues = new Dictionary<string, object>();
						foreach (string columnName in additionalColumnNames) {
							additionalColumnValues.Add(columnName, reader.GetColumnValue(columnName));
						}
						resultList.Add(new AccountInfo {
							Id = id,
							Name = name,
							ParentId = parentId,
							AccountType = accountType,
							Level = level,
							AdditionalColumnValues = additionalColumnValues
						});
					}
				}
			}
			return resultList;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// ######### ############### ############.
		/// </summary>
		/// <param name="accountId">########## ############# ###########.</param>
		/// <param name="additionalColumnNames">###### ######## ############## #######.</param>
		/// <returns>###### ############.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
		ResponseFormat = WebMessageFormat.Json)]
		public RelationshipDiagramServiceResponse GetRelationshipDiagramInfo(Guid accountId, List<string> additionalColumnNames) {
			var response = new RelationshipDiagramServiceResponse();
			try {
				response.ParentId = GetParentAccount(accountId);
				response.Accounts = GetChildAccounts(response.ParentId, additionalColumnNames);
			}
			catch (Exception e) {
				response.Exception = e;
			}
			return response;
		}

		#endregion

		#region Class: Public

		[DataContract]
		public class RelationshipDiagramServiceResponse : ConfigurationServiceResponse {

			#region Properties: Public

			/// <summary>
			/// ###### ############.
			/// </summary>
			[DataMember(Name = "accounts")]
			public List<AccountInfo> Accounts {
				get;
				set;
			}

			/// <summary>
			/// ############ ########## ######## ######.
			/// </summary>
			[DataMember(Name = "parentId")]
			public Guid ParentId {
				get;
				set;
			}

			#endregion

		}

		[DataContract]
		public class AccountInfo {

			#region Properties: Public

			/// <summary>
			/// ########## ############# ###########.
			/// </summary>
			[DataMember(Name = "id")]
			public Guid Id {
				get;
				set;
			}

			/// <summary>
			/// ######## ###########.
			/// </summary>
			[DataMember(Name = "name")]
			public string Name {
				get;
				set;
			}

			/// <summary>
			/// ########## ############# ############# ###########.
			/// </summary>
			[DataMember(Name = "parentId")]
			public Guid ParentId {
				get;
				set;
			}

			/// <summary>
			/// ### ###########.
			/// </summary>
			[DataMember(Name = "accountType")]
			public string AccountType {
				get;
				set;
			}

			/// <summary>
			/// ####### # ########.
			/// </summary>
			[DataMember(Name = "level")]
			public int Level {
				get;
				set;
			}

			/// <summary>
			/// ######## ############# ########### #######.
			/// </summary>
			[DataMember(Name = "additionalColumnValues")]
			public Dictionary<string, object> AdditionalColumnValues {
				get;
				set;
			}

			#endregion

		}

		#endregion

	}
}

