namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Text;
	using Newtonsoft.Json;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Nui.ServiceModel.Extensions;
	using CoreEntitySchemaColumn = Terrasoft.Core.Entities.EntitySchemaColumn;
	using EntitySchema = Terrasoft.Core.Entities.EntitySchema;
	using Utilities = Terrasoft.Configuration.ProcessUserTaskUtilities;

	#region Class: PreconfiguredPageUserTask

	public partial class PreconfiguredPageUserTask
	{

		#region Constants: Private

		private const string Action = "add";
		private const string DefUrlTemplate = "[Module]/[Page]/" + Action;

		#endregion

		#region Properties: Private

		private ClientUnitSchemaManager ClientUnitSchemaManager => UserConnection.ClientUnitSchemaManager;

		private EntitySchemaManager EntitySchemaManager => UserConnection.EntitySchemaManager;

		#endregion

		#region Methods: Private

		private string GetEntitySchemaName(Guid uid) {
			return uid.IsEmpty() ? string.Empty : EntitySchemaManager.GetItemByUId(uid).Name;
		}

		private string GetUrlToken(string pageName) {
			var module = ClientUnitSchemaManager.FindItemByUId(Module);
			string moduleName = module?.Name ?? "ProcessCardModuleV2";
			string template = Url.IsNullOrEmpty() ? DefUrlTemplate : Url;
			return template.Replace("[Module]", moduleName).Replace("[Page]", pageName);
		}

		private object GetParameterLookupValue(ProcessSchemaParameter parameter) {
			var value = GetParameterValue(parameter);
			var primaryColumnValue = (Guid?)value;
			if (primaryColumnValue?.IsEmpty() != false) {
				return null;
			}
			var displayValue = string.Empty;
			if (parameter.ParentMetaSchema == null) {
				parameter.ParentMetaSchema = Owner.Schema;
				Log.Warn("[PreconfiguredPageUserTask]. Parameter metadata modified at runtime.");
			}
			EntitySchema referenceSchema = parameter.ReferenceSchema;
			if (referenceSchema.PrimaryDisplayColumn != null) {
				Entity entity = referenceSchema.CreateEntity(UserConnection);
				entity.UseAdminRights = false;
				var columns = new Collection<CoreEntitySchemaColumn>() {
					referenceSchema.PrimaryDisplayColumn
				};
				entity.FetchFromDB(referenceSchema.PrimaryColumn, primaryColumnValue.Value, columns);
				displayValue = entity.PrimaryDisplayColumnValue;
			}
			return new LookupColumnValue {
				Value = primaryColumnValue.Value.ToString(),
				DisplayValue = displayValue
			};
		}

		private object GetParameterDateTimeValue(ProcessSchemaParameter parameter) {
			object value = GetParameterValue(parameter);
			if (value == null) {
				return null;
			}
			var dateTime = (DateTime)value;
			if (dateTime == DateTime.MinValue) {
				return null;
			}
			if (dateTime.Kind == DateTimeKind.Local) {
				value = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
			}
			var dataValueType = (DateTimeDataValueType)parameter.DataValueType;
			return new {
				dataValueType = (int)dataValueType.ToEnum(),
				value = DateTimeDataValueType.Serialize(value, TimeZoneInfo.Utc)
			};
		}

		/// <summary>
		/// Returns page parameters.
		/// </summary>
		/// <param name="processSchema">Parent process schema.</param>
		/// <param name="useLookupValues">Load lookup display value only for new pages.
		/// Old pages are using parameter value as simple guid value, not object (value, displayValue)</param>
		/// <returns>Parameters dictionary</returns>
		private Dictionary<string, object> GetPageParameters(ProcessSchema processSchema, bool useLookupValues) {
			var userTask = (ProcessSchemaUserTask)processSchema.GetBaseElementByUId(SchemaElementUId);
			var result = new Dictionary<string, object>();
			foreach (ProcessSchemaParameter parameter in userTask.Parameters) {
				if (parameter.CreatedInSchemaUId != processSchema.UId) {
					continue;
				}
				object parameterValue;
				if (parameter.DataValueType.IsDateTime) {
					parameterValue = GetParameterDateTimeValue(parameter);
				} else if (useLookupValues && parameter.DataValueType.IsLookup) {
					parameterValue = GetParameterLookupValue(parameter);
				} else {
					parameterValue = GetParameterValue(parameter) ?? string.Empty;
				}
				result.Add(parameter.Name, parameterValue);
			}
			return result;
		}

		private Dictionary<string, object> GetAttributes() {
			var result = new Dictionary<string, object>();
			var instance = ClientUnitSchemaManager.GetInstanceByUId(ClientUnitSchemaUId);
			var parameters = instance.Parameters;
			parameters.ForEach(p => {
				var value = new {
					caption = p.Caption?.Value,
					dataValueType = (int)p.DataValueType.ToEnum(),
					isLookup = p.DataValueType.IsLookup,
					referenceSchemaName = GetEntitySchemaName(p.ReferenceSchemaUId),
					isRequired = p.IsRequired
				};
				result.Add(p.Name, value);
			});
			return result;
		}

		private string GetUserContextExecutionData(string jsonData) {
			string userContextData = ProcessLane?.GetUserContextData();
			if (userContextData.IsNullOrEmpty()) {
				return jsonData;
			}
			var sb = new StringBuilder(jsonData);
			sb.Length--;
			sb.Append(",").Append(userContextData).Append("}");
			return sb.ToString();
		}

		private JsonSerializerSettings GetSerializeJsonSettings() {
			return new JsonSerializerSettings {
				TypeNameHandling = TypeNameHandling.None,
				TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
				NullValueHandling = NullValueHandling.Include
			};
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc/>
		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (EntryPointId.IsEmpty()) {
				EntryPointId = Utilities.AddProcessEntryPoint(UserConnection, EntitySchemaUId, EntityId, UId);
			}
			InteractWithUser(context, IsRunning, ShowExecutionPage);
			IsRunning = true;
			return false;
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc/>
		public override bool CompleteExecuting(params object[] parameters) {
			Utilities.DeactivateProcessEntryPoint(UserConnection, EntryPointId, EntitySchemaUId, EntityId);
			GenerateSignal();
			return base.CompleteExecuting(parameters);
		}

		/// <inheritdoc/>
		public override void CancelExecuting(params object[] parameters) {
			Utilities.DeactivateProcessEntryPoint(UserConnection, EntryPointId, EntitySchemaUId, EntityId);
			base.CancelExecuting(parameters);
		}

		/// <inheritdoc/>
		public override string GetExecutionData() {
			var page = ClientUnitSchemaManager.GetItemByUId(ClientUnitSchemaUId);
			var processSchema = (ProcessSchema)Owner.Schema;
			bool isInheritedFromTemplate = ClientUnitSchemaManager.IsInheritedFrom(ClientUnitSchemaUId, Template);
			string recommendation = LocalizableString.IsNullOrEmpty(Recommendation)
				? GetParameterValue("Recommendation")?.ToString() ?? string.Empty
				: Recommendation.Value;
			string informationOnStep = LocalizableString.IsNullOrEmpty(InformationOnStep)
				? GetParameterValue("InformationOnStep")?.ToString() ?? string.Empty
				: InformationOnStep.Value;
			var executionData = new {
				procElUId = UId,
				name = Name,
				processId = Utilities.GetParentProcessId(Owner),
				isProcessExecutedBySignal = Utilities.GetIsProcessExecutedBySignal(Owner),
				processName = Owner.Name,
				header = Title.Value,
				recommendation,
				informationOnStep,
				pageCaption = page.Caption.ToString(),
				nextProcElUId = "nextProcElUIdValue",
				urlToken = GetUrlToken(page.Name),
				recordId = EntityId,
				entitySchemaUId = EntitySchemaUId,
				entitySchemaName = GetEntitySchemaName(EntitySchemaUId),
				parameters = GetPageParameters(processSchema, isInheritedFromTemplate),
				attributes = isInheritedFromTemplate ? GetAttributes() : null,
				preconfiguredPage = true,
				action = Action
			};
			string jsonData = JsonConvert.SerializeObject(executionData, Formatting.None, GetSerializeJsonSettings());
			jsonData = GetUserContextExecutionData(jsonData);
			return jsonData;
		}

		/// <inheritdoc/>
		public override ProcessElementNotification GetNotificationData() {
			ProcessElementNotification notification = base.GetNotificationData();
			if (Recommendation != null && Recommendation.HasValue && !Recommendation.Value.IsNullOrEmpty()) {
				notification.Title = Recommendation;
			}
			return notification;
		}

		public virtual void GenerateSignal() {
			if (string.IsNullOrEmpty(PressedButtonCode)) {
				return;
			}
			var processSchema = (ProcessSchema)Owner.Schema;
			var userTask = (ProcessSchemaUserTask)processSchema.GetBaseElementByUId(SchemaElementUId);
			var buttonsParameter = userTask.Parameters.FindByName("Buttons");
			var buttons = buttonsParameter?.SourceValue.LocalizableCollectionValue;
			var pressedButton = buttons?.Find(button => button["Tag"].Value == PressedButtonCode);
			LocalizableParameterValue generateSignalValue = null;
			pressedButton?.TryGetValue("GenerateSignal", out generateSignalValue);
			var generateSignal = generateSignalValue?.Value;
			if (string.IsNullOrEmpty(generateSignal)) {
				return;
			}
			var context = new ProcessExecutingContext(UserConnection) { Process = Owner };
			UserConnection.IProcessEngine.ThrowSignal(context, generateSignal);
		}

		#endregion

	}

	#endregion

}

