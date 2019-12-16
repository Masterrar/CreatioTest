define("ActivityMiniPage", [], function() {
	return {
		entitySchemaName: "Activity",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		methods: {

			//region Methods: Protected

			getOpenCurrentEntityPageVisible: function() {
				return Terrasoft.CurrentUser.userType != Terrasoft.UserType.SSP;
			}

			//endregion

		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "OpenCurrentEntityPage",
				"values": {
					"visible": {
						"bindTo": "getOpenCurrentEntityPageVisible"
					}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
 