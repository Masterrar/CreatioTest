define("ContentItemPanel", ["ContentItemPanelResources", "DynamicBlockPropertiesPage",
		"DynamicContentAttributesPropertiesPage"], function() {
	return {
		modules: {
			DynamicBlockPropertiesPageModule: {
				moduleId: "DynamicBlockPropertiesPageModule",
				moduleName: "ConfigurationModuleV2",
				config: {
					schemaName: "DynamicBlockPropertiesPage",
					isSchemaConfigInitialized: true,
					useHistoryState: false
				}
			},
			DynamicContentAttributesPropertiesPageModule: {
				moduleId: "DynamicContentAttributesPropertiesPageModule",
				moduleName: "ConfigurationModuleV2",
				config: {
					schemaName: "DynamicContentAttributesPropertiesPage",
					isSchemaConfigInitialized: true,
					useHistoryState: false
				}
			}
		},
		messages: {
			"GetDynamicContentEnabled": {
				direction: Terrasoft.MessageDirectionType.PUBLISH,
				mode: Terrasoft.MessageMode.PTP
			}
		},
		attributes: {},
		methods: {
			/**
			 * Initializes model values.
			 * @protected
			 * @overridden
			 */
			init: function() {
				this.callParent(arguments);
				this.initTabs();
			},

			/**
			 * Initializes properties tabs.
			 * @protected
			 * @overridden
			 */
			initTabs: function() {
				var dynamicBlockTab = this.$PropertiesTabs.get("DynamicBlockTab");
				var dcAttributesTab = this.$PropertiesTabs.get("DCAttributesTab");
				var isDynamicContentEnabled = this.isDynamicContentEnabled();
				dynamicBlockTab.set("Visible", isDynamicContentEnabled);
				dcAttributesTab.set("Visible", isDynamicContentEnabled);
			},

			/**
			 * Returns state of dynamic content functionality.
			 * @protected
			 * @virtual
			 */
			isDynamicContentEnabled: function() {
				return this.sandbox.publish("GetDynamicContentEnabled");
			},

			/**
			 * Sign for properties tabs can be scrolled.
			 * @override
			 */
			IsTabPanelScrollable: function() {
				return this.callParent() || this.isDynamicContentEnabled();
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "DynamicBlockTab",
				"parentName": "PropertiesTabPanel",
				"propertyName": "tabs",
				"values": {
					"wrapClass": ["content-properties-tab", "tabs", "editors-ct"],
					"caption": "$Resources.Strings.DynamicBlockTabCaption",
					"markerValue": "DynamicContentTab",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "DynamicBlockTabContainer",
				"parentName": "DynamicBlockTab",
				"propertyName": "items",
				"values": {
					"classes": {
						"wrapClassName": ["content-properties-tab-container", "scrollable-container"]
					},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "DynamicBlockPropertiesPageModule",
				"parentName": "DynamicBlockTabContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.MODULE
				}
			},
			{
				"operation": "insert",
				"name": "DCAttributesTab",
				"parentName": "PropertiesTabPanel",
				"propertyName": "tabs",
				"values": {
					"wrapClass": ["content-properties-tab", "tabs", "editors-ct"],
					"caption": "$Resources.Strings.DynamicSegmentsTabCapion",
					"markerValue": "DCAttributesTab",
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "DCAttributesTabContainer",
				"parentName": "DCAttributesTab",
				"propertyName": "items",
				"values": {
					"classes": {
						"wrapClassName": ["content-properties-tab-container", "scrollable-container"]
					},
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "DynamicContentAttributesPropertiesPageModule",
				"parentName": "DCAttributesTabContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.MODULE
				}
			}
		]
	};
});
