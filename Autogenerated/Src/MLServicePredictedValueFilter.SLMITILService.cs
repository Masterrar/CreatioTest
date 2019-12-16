namespace Terrasoft.Configuration.ML
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.ML.Interfaces;

	#region Class: MLServicePredictedValueFilter

	/// <summary>
	/// Handler for Service field prediction and filtering.
	/// </summary>
	[Override]
	public class MLServicePredictedValueFilter: MLBasePredictedValueFilter
	{

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLServicePredictedValueFilter"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public MLServicePredictedValueFilter(UserConnection userConnection): base(userConnection) {
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Called when entity field need to be setted by predicted value.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="columnValueName">Name of the column value.</param>
		/// <param name="result">The predicted value.</param>
		/// <returns><c>true</c> - if value may be setted to field, else - <c>false</c>.</returns>
		public override bool OnSetupPredictedValue(Entity entity, string columnValueName,
				ClassificationResult result) {
			if (!base.OnSetupPredictedValue(entity, columnValueName, result)) {
				return false;
			}
			if (columnValueName != "ServiceItemId") {
				return true;
			}
			if (!Guid.TryParse(result.Value, out var serviceItemId)) {
				return false;
			}
			Guid servicePactId = entity.GetTypedColumnValue<Guid>("ServicePactId");
			var select = (Select)new Select(UserConnection)
					.Column(Column.Const(1))
				.From("ServiceInServicePact").As("sp")
				.InnerJoin("ServiceStatus").As("ss").On("sp", "StatusId").IsEqual("ss", "Id")
				.Where("sp", "ServiceItemId").IsEqual(Column.Parameter(serviceItemId, "Guid"))
					.And("sp", "ServicePactId").IsEqual(Column.Parameter(servicePactId, "Guid"))
					.And("ss", "Active").IsEqual(Column.Parameter(true, "Boolean"));
			try {
				return select.ExecuteScalar<int>() > 0;
			} catch (Exception e) {
				Log.Error($"MLServicePredictedValueFilter.OnSetupPredictedValue throws exception {e}");
				return false;
			}
		}

		#endregion

	}

	#endregion

}

