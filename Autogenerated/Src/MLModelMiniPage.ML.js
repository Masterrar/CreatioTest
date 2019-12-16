﻿define("MLModelMiniPage", ["RootSchemaLookupMixin"], function() {
	return {
		entitySchemaName: "MLModel",
		mixins: {
			RootSchemaLookupMixin: "Terrasoft.RootSchemaLookupMixin"
		},
		attributes: {
			"MiniPageModes": {
				"value": [this.Terrasoft.ConfigurationEnums.CardOperation.ADD]
			},
			/**
			 * Root schema lookup value.
			 */
			"RootSchema": {
				"dataValueType": Terrasoft.DataValueType.LOOKUP,
				"isLookup": true,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"isRequired": true,
				"caption": {"bindTo": "getRootSchemaCaption"}
			},
			/**
			 * Uid of the root schema.
			 */
			"RootSchemaUId": {
				"dependencies": [
					{
						"columns": ["RootSchema"],
						"methodName": "onRootSchemaChanged"
					}
				]
			}
		},
		methods: {
			/**
			 * @inheritdoc BaseMiniPage#onEntityInitialized
			 * @protected
			 * @override
			 */
			onEntityInitialized: function() {
				this.callParent(arguments);
				this.initializeRootSchema();
			},
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"name": "Name",
				"parentName": "MiniPage",
				"operation": "insert",
				"propertyName": "items",
				"index": 0,
				"values": {
					"labelConfig": {
						"visible": true
					},
					"isMiniPageModelItem": true,
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 24
					}
				}
			},
			{
				"name": "MLProblemType",
				"parentName": "MiniPage",
				"operation": "insert",
				"propertyName": "items",
				"values": {
					"isMiniPageModelItem": true,
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 24
					}
				}
			},
			{
				"name": "RootSchema",
				"parentName": "MiniPage",
				"operation": "insert",
				"propertyName": "items",
				"values": {
					"isMiniPageModelItem": true,
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 24
					},
					"contentType": Terrasoft.ContentType.ENUM,
					"controlConfig": {
						"prepareList": {
							"bindTo": "prepareRootSchemaList"
						}
					}
				}
			},
			{
				"operation": "merge",
				"name": "SaveEditButton",
				"values": {
					"click": {"bindTo": "openCurrentEntityPage"},
				}
			}
		]/**SCHEMA_DIFF*/
	};
});