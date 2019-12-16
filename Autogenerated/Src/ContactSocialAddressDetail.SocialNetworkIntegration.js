﻿define("ContactSocialAddressDetail", [], function() {
	return {
		entitySchemaName: "ContactAddress",
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		attributes: {
			/**
			 * Requires generating default entity profile if no profile was found.
			 */
			UseGeneratedProfile: {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				value: false
			}
		}
	};
});