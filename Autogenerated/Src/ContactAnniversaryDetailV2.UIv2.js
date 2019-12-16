define("ContactAnniversaryDetailV2", ["ConfigurationConstants"], function(ConfigurationConstants) {
	return {
		entitySchemaName: "ContactAnniversary",
		attributes: {
			/**
			 * ####, ############ ########### ######### #### ######## ## ###### "############## #######"
			 * @Type {Boolean}
			 */
			"IsBirthdayEnabled": {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				value: true
			}
		},
		methods: {

			/**
			 * ########## ### ####### ### ########## ## #########.
			 * @overridden
			 * @return {String} ### #######.
			 */
			getFilterDefaultColumnName: function() {
				return "AnniversaryType";
			},

			/**
			 * ############## ######## ########### ########## ### ######## ## ######.
			 * @overridden
			 */
			onDataChanged: function() {
				this.callParent(arguments);
				this.checkIsBirthdayEnabled();
			},

			/**
			 * ######### ######## ########### ###### ########## ############### ####### # ##### "#### ########".
			 * @protected
			 */
			checkIsBirthdayEnabled: function() {
				var gridData = this.getGridData();
				if (gridData && gridData.getCount() > 0) {
					gridData.each(function(item) {
						var type = item.get("AnniversaryType");
						if (type && type.value === ConfigurationConstants.AnniversaryType.Birthday) {
							this.set("IsBirthdayEnabled", false);
							return false;
						} else {
							this.set("IsBirthdayEnabled", true);
						}
					}, this);
				} else {
					this.set("IsBirthdayEnabled", true);
				}
			},

			/**
			 * @inheritdoc Terrasoft.BaseAnniversaryDetailV2#getEditPages
			 * @protected
			 */
			getEditPages: function() {
				var editPages = this.callParent(arguments);
				var birthdayPage = editPages.get(ConfigurationConstants.AnniversaryType.Birthday);
				if (birthdayPage) {
					birthdayPage.set("Enabled", {"bindTo": "IsBirthdayEnabled"});
				}
				return editPages;
			}
		},
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
	};
});
