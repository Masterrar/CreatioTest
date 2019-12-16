define("ProblemSection", ["terrasoft", "BaseFiltersGenerateModule", "CheckBoxFixedFilterStyle",
		"css!CheckBoxFixedFilterStyle"],
	function(Terrasoft, BaseFiltersGenerateModule, CheckBoxFixedFilterStyle) {
		return {
			entitySchemaName: "Problem",
			contextHelpId: "1001",
			attributes: {
				"IsActive": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: false
				}
			},
			diff: /**SCHEMA_DIFF*/[
				//FiltersContainer
				{
					"operation": "insert",
					"name": "IsActiveFiltersContainer",
					"parentName": "FiltersContainer",
					"propertyName": "items",
					"index": 0,
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["isActive-filter-container-wrapClass"],
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "IsActiveFiltersContainer",
					"propertyName": "items",
					"name": "IsActive",
					"values": {
						"caption": {
							"bindTo": "Resources.Strings.CheckboxFilterCaption"
						},
						"bindTo": "IsActive",
						"controlConfig": {
							"className": "Terrasoft.CheckBoxEdit",
							"checkedchanged": {"bindTo": "onCheckboxChecked"},
							"checked": {"bindTo": "IsActive"}
						}
					}
				}
			]/**SCHEMA_DIFF*/,
			messages: {},
			methods: {
				
				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#onSectionModeChanged
				 * @overridden
				 */
				onSectionModeChanged: function() {
					this.callParent(arguments);
					CheckBoxFixedFilterStyle.setFilterContainerStyle(this);
				},

				/**
				 * Changing the state of the CheckBox.
				 * @param {Object} value CheckBox value.
				 */
				onCheckboxChecked: function(value) {
					var config = {
						isActive: value
					};
					CheckBoxFixedFilterStyle.onClick(value, this);
					this.sandbox.publish("FiltersChanged", config, [this.sandbox.id]);
				},

				/**
				 * Adds or removes IsActiveFilter to filter collection.
				 * @protected
				 * @param {Terrasoft.Collection} filterCollection Filter collection.
				 */
				setIsActiveFilter: function(filterCollection) {
					var isActive = this.get("IsActive");
					filterCollection.removeByKey("FilterStatus");
					if (!isActive) {
						filterCollection.add("FilterStatus", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Status.IsFinal", 0));
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getFilters
				 * @overridden
				 */
				getFilters: function() {
					var sectionFilters = this.callParent(arguments);
					this.setIsActiveFilter(sectionFilters);
					return sectionFilters;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#initFixedFiltersConfig
				 * @overridden
				 */
				initFixedFiltersConfig: function() {
					var fixedFilterConfig = {
						entitySchema: this.entitySchema,
						filters: [
							{
								name: "Owner",
								caption: this.get("Resources.Strings.OwnerFilterCaption"),
								dataValueType: this.Terrasoft.DataValueType.LOOKUP,
								filter: BaseFiltersGenerateModule.OwnerFilter,
								columnName: "Owner",
								defValue: {
									value: this.Terrasoft.SysValue.CURRENT_USER_CONTACT.value,
									displayValue: this.Terrasoft.SysValue.CURRENT_USER_CONTACT.displayValue
								}
							}
						]
					};
					this.set("FixedFilterConfig", fixedFilterConfig);
				},

				/**
				 * @inheritdoc Terrasoft.ContextHelpMixin#initContextHelp
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1064);
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.GridUtilitiesV2#afterFiltersUpdated
				 * @overridden
				 */
				afterFiltersUpdated: function() {
					this.scrollTop();
					this.loadActiveViewData();
					var config = {
						isActive: this.get("IsActive")
					};
					this.sandbox.publish("FiltersChanged", config, [this.sandbox.id]);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#setGridOffsetClass
				 * @overridden
				 */
				setGridOffsetClass: function(linesCount) {
					this.callParent([linesCount + 1]);
				}
			}
		};
	});
