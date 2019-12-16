define("PartnershipLeadDetail", ["css!PartnershipLeadDetailCss", "css!SummaryModuleV2"], function() {
	return {
		entitySchemaName: "Lead",
		attributes: {
			IsActiveFiltrationButtonPressed: {
				dataValueType: Terrasoft.DataValueType.BOOLEAN
			}
		},
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "ActiveFiltrationButton",
				"parentName": "Detail",
				"propertyName": "tools",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"caption": {"bindTo": "Resources.Strings.ActiveFiltrationButtonCaption"},
					"pressed": {"bindTo": "IsActiveFiltrationButtonPressed"},
					"click": {"bindTo": "onActiveFiltrationButtonClick"}
				}
			},
			{
				"operation": "insert",
				"name": "summaryItemsContainer",
				"propertyName": "tools",
				"parentName": "Detail",
				"values": {
					"id": "summaryItemContainer",
					"selectors": {"wrapEl": "#summaryItemContainer"},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"wrapClass": ["summary-item-container"],
					"visible": true,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "summaryCountCaption",
				"parentName": "summaryItemsContainer",
				"propertyName": "items",
				"values": {
					"caption": { "bindTo": "Resources.Strings.RecordsCountCaption" },
					"itemType": Terrasoft.ViewItemType.LABEL,
					"classes": {"labelClass": ["summary-item-caption"]}
				}
			},
			{
				"operation": "insert",
				"name": "summaryCountValue",
				"parentName": "summaryItemsContainer",
				"propertyName": "items",
				"values": {
					"caption": { "bindTo": "RecordsCount" },
					"markerValue": "RecordsCount",
					"itemType": Terrasoft.ViewItemType.LABEL,
					"classes": {"labelClass": ["summary-item-value"]}
				}
			}
		]/**SCHEMA_DIFF*/,
		methods: {
				/**
			 * Is active filtration button click handler
			 */
			onActiveFiltrationButtonClick: function() {
				this.$IsActiveFiltrationButtonPressed = !this.$IsActiveFiltrationButtonPressed;
				this._saveFiltersToProfile();
				this.reloadGridData();
			},
			
			/**
			 * Save filters to profile
			 * @private
			 */
			_saveFiltersToProfile: function() {
				var profile = this.getProfile();
				var key = this.getProfileKey();
				if (this.isNotEmpty(profile) && this.isNotEmpty(key)) {
					profile.IsActiveFiltrationButtonPressed = this.$IsActiveFiltrationButtonPressed;
					this.set(this.getProfileColumnName(), profile);
					this.Terrasoft.utils.saveUserProfile(key, profile, false);
				}
			},
			 /**
			 * Load filters from profile
			 * @private
			 */
			_loadFiltersFromProfile: function() {
				var profile = this.getProfile();
				if (this.isNotEmpty(profile)) {
					this.$IsActiveFiltrationButtonPressed = !!profile.IsActiveFiltrationButtonPressed;
				}
			},

			 /**
			 * @inheritdoc Terrasoft.GridUtilitiesV2#init
			 * @overridden
			 */
			init: function() {
				this.callParent(arguments);
				this._loadFiltersFromProfile();
			},

			/**
			 * @inheritdoc Terrasoft.GridUtilities#addGridDataColumns
			 * @overridden
			 */
			addGridDataColumns: function(esq) {
				this.addCountOverColumn(esq);
				this.callParent(arguments);
			},

			 /**
			 * @inheritdoc Terrasoft.GridUtilitiesV2#getFilters
			 * @overridden
			 */
			getFilters: function() {
				var filterGroup = this.callParent(arguments);
				if (this.$IsActiveFiltrationButtonPressed) {
					this._addActiveFilter(filterGroup);
				}
				return filterGroup;
			},

			 /**
			 * Add Active filter
			 * @private
			 */
			_addActiveFilter: function(filterGroup) {
				filterGroup.add("ActiveFilter",
				Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, "QualifyStatus.IsFinal",
					false));
			},

			/**
			 * Checks if current user is Ssp user.
			 * //TODO SD-6008 remove method after release 7.14.2
			 * @private
			 * @return {Boolean} True if type of current user is ssp, otherwise - false.
			 */
			_isSspCurrentUser: function() {
				return Terrasoft.CurrentUser.userType === Terrasoft.UserType.SSP;
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getAddRecordButtonVisible
			 * @overridden
			 */
			getAddRecordButtonVisible: function() {
				return false;
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
			 * @overridden
			 */
			getEditRecordMenuItem: Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
			 * @overridden
			 */
			getCopyRecordMenuItem: Terrasoft.emptyFn,

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getDeleteRecordMenuItem
			 * @overridden
			 */
			getDeleteRecordMenuItem: Terrasoft.emptyFn,

			getRecordRightsSetupMenuItem: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			
			getSwitchGridModeMenuItem: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			
			getExportToExcelFileMenuItem: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			
			getShowQuickFilterButton: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			}
		}
	};
});
