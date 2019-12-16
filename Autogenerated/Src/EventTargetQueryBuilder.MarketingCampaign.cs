namespace Terrasoft.Configuration
{

	#region Class: EventTargetQueryBuilder

	/// <summary>
	/// Concrete query builder for all web forms with EventTarget type.
	/// </summary>
	public sealed class EventTargetQueryBuilder : LandingContactQueryBuilder<EventTarget>
	{

		#region Constructors: Public

		public EventTargetQueryBuilder() : base() {
			WebFormIdColumnName = "GeneratedWebFormId";
			ContactIdColumnName = "ContactId";
		}

		#endregion

	}

	#endregion

}
