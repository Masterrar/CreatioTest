namespace Terrasoft.Configuration
{
	using System;
	using Core;
	using Core.DB;

	#region Class: Unsubscribe

	public class Unsubscribe : BaseWebHook
	{

		#region Properties: Public

		public string EmailAddress {
			get;
			set;
		}

		#endregion


		#region Methods: Public

		public override string GetGroupKey() {
			return base.GetGroupKey() + EmailAddress;
		}

		public override void HandleWebHook(UserConnection userConnection) {
			var subSelectQuery = new Select(userConnection)
				.Column(Column.Const(1))
				.From("ContactCommunication")
				.Where("ContactId").IsEqual("Contact","Id")
				.And("CommunicationTypeId")
				.IsEqual(Column.Parameter(new Guid(CommunicationTypeConsts.EmailId)))
				.And("Number").IsEqual(Column.Parameter(EmailAddress)) as Select;
			subSelectQuery.SpecifyNoLockHints();
			new Update(userConnection, "Contact")
				.Set("DoNotUseEmail", Column.Const(true))
				.Where()
				.Exists(subSelectQuery).Execute();
		}

		#endregion

	}
	
	#endregion

}

