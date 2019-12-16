namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Core.Entities;
	using Common;
	using Core;
	using GeneratedWebFormService;

	#region Class: WebFormEventTargetPreProcessHandler

	/// <summary>
	/// Executes pre event target saving processing.
	/// </summary>
	/// <seealso cref="Terrasoft.Configuration.IGeneratedWebFormPreProcessHandler" />
	public class WebFormEventTargetPreProcessHandler : IGeneratedWebFormPreProcessHandler
	{

		#region Fields: Private

		private List<FormFieldsData> _fieldsData;
		private UserConnection _userConnection;
		private const string ContactSchemaName = "Contact";
		private const string ContactIdFieldName = "contactid";
		private const string ContactNameFieldName = "contact.name";
		private const string WebFormIdFieldName = "GeneratedWebForm";

		#endregion

		#region Methods: Private

		private FormFieldsData CreateField(string columnName) {
			var field =  new FormFieldsData() {
				name = columnName
			};
			return field;
		}

		private FormFieldsData CreateContactIdField(Guid contactId) {
			var field = CreateField(ContactIdFieldName);
			field.value = contactId.ToString();
			return field;
		}

		private FormFieldsData GetField(string columnName) {
			return _fieldsData.FirstOrDefault(field =>
				field.name.ToLower().Equals(columnName));
		}

		private FormFieldsData GetContactNameField() {
			return GetField(ContactNameFieldName);
		}

		private FormFieldsData GetContactIdField() {
			return GetField(ContactIdFieldName);
		}

		private bool CheckGeneratedWebFormExists(Guid webFormId) {
			var webForm = new GeneratedWebForm(_userConnection);
			return webForm.FetchFromDB("Id", webFormId, new[] {"Id"});
		}

		private FormFieldsData CreateWebFormIdField() {
			return CreateField(WebFormIdFieldName);
		}

		private FormFieldsData GetWebFormIdField() {
			return GetField(WebFormIdFieldName);
		}

		#endregion

		#region Methods: Protected

		protected bool CheckContactExists(Guid contactId) {
			var contact = new Contact(_userConnection);
			return contact.FetchFromDB("Id", contactId, new[] {"Id"});
		}

		protected virtual void CreateContactEntity(Guid contactId, FormFieldsData contactNameField) {
			EntitySchema contactSchema = _userConnection.EntitySchemaManager.GetInstanceByName(ContactSchemaName);
			Entity contact = contactSchema.CreateEntity(_userConnection);
			contact.SetDefColumnValues();
			contact.SetColumnValue("Id", contactId);
			contact.SetColumnValue("Name", contactNameField.value);
			contact.Save(false);
		}

		protected void ProcessContactField() {
			Guid contactId = Guid.NewGuid();
			FormFieldsData contactIdField = GetContactIdField();
			if (contactIdField != null && contactIdField.value.IsValidGuid()) {
				contactId = Guid.Parse(contactIdField.value);
			}
			if (!CheckContactExists(contactId)) {
				FormFieldsData contactNameField = GetContactNameField();
				if (contactNameField == null || contactNameField.value.IsNullOrEmpty()) {
					return;
				}
				if (contactIdField == null) {
					CreateContactIdField(contactId);
				}
				_fieldsData.Add(contactIdField);
				CreateContactEntity(contactId, contactNameField);
			}
		}

		protected void ProcessGeneratedWebFormField(FormData formData) {
			Guid webFormId;
			if (Guid.TryParse(formData.formId, out webFormId)) {
				if (CheckGeneratedWebFormExists(webFormId)) {
					FormFieldsData webFormIdField = GetWebFormIdField() ?? CreateWebFormIdField();
					webFormIdField.value = webFormId.ToString();
					_fieldsData.Add(webFormIdField);
				}
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Executes pre event target saving processing.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="formData">The form data.</param>
		/// <param name="paramsGenerator">The parameters generator.</param>
		/// <returns>The form data.</returns>
		public FormData Execute(UserConnection userConnection, FormData formData, 
				IWebFormImportParamsGenerator paramsGenerator) {
			_userConnection = userConnection;
			_fieldsData = formData.formFieldsData.ToList();
			ProcessContactField();
			ProcessGeneratedWebFormField(formData);
			formData.formFieldsData = _fieldsData.ToArray();
			return formData;
		}

		#endregion

	}

	#endregion

}

