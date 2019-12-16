﻿define("ProjectProductPageV2", ["BusinessRuleModule"],
	function() {
		return {
			entitySchemaName: "ProjectProduct",
			columns: {},
			details: /**SCHEMA_DETAILS*/{}, /**SCHEMA_DETAILS*/
			methods: {},
			diff: /**SCHEMA_DIFF*/[
				{"operation": "insert",
					"name": "ProjectProductPageGeneralTabContainer",
					"values": {"itemType": 7,
						"items": []}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralTabContainer",
					"propertyName": "items",
					"name": "ProjectProductPageGeneralBlock",
					"values": {"itemType": 0,
						"items": []}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "Project",
					"values": {"bindTo": "Project",
						"layout": {"column": 0,
							"row": 0,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "Product",
					"values": {"bindTo": "Product",
						"layout": {"column": 0,
							"row": 1,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "CustomProduct",
					"values": {"bindTo": "CustomProduct",
						"layout": {"column": 0,
							"row": 2,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "Quantity",
					"values": {"bindTo": "Quantity",
						"layout": {"column": 0,
							"row": 3,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "Unit",
					"values": {"bindTo": "Unit",
						"layout": {"column": 0,
							"row": 4,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "DeliveryDate",
					"values": {"bindTo": "DeliveryDate",
						"layout": {"column": 0,
							"row": 5,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "Cost",
					"values": {"bindTo": "Cost",
						"layout": {"column": 0,
							"row": 6,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "Price",
					"values": {"bindTo": "Price",
						"layout": {"column": 0,
							"row": 7,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "Amount",
					"values": {"bindTo": "Amount",
						"layout": {"column": 0,
							"row": 8,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "DiscountPercent",
					"values": {"bindTo": "DiscountPercent",
						"layout": {"column": 0,
							"row": 9,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "DiscountAmount",
					"values": {"bindTo": "DiscountAmount",
						"layout": {"column": 0,
							"row": 10,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "Tax",
					"values": {"bindTo": "Tax",
						"layout": {"column": 0,
							"row": 11,
							"colSpan": 12},
						"contentType": "Terrasoft.ContentType.ENUM"}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "DiscountTax",
					"values": {"bindTo": "DiscountTax",
						"layout": {"column": 0,
							"row": 12,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "TaxAmount",
					"values": {"bindTo": "TaxAmount",
						"layout": {"column": 0,
							"row": 13,
							"colSpan": 12}}},
				{"operation": "insert",
					"parentName": "ProjectProductPageGeneralBlock",
					"propertyName": "items",
					"name": "TotalAmount",
					"values": {"bindTo": "TotalAmount",
						"layout": {"column": 0,
							"row": 14,
							"colSpan": 12}}}
			]/**SCHEMA_DIFF*/,
			rules: {"Product": {"BindParameterEnabledProductToCustomProduct": {"ruleType": 0,
				"property": 1,
				"conditions": [
					{"leftExpression": {"type": 1,
						"attribute": "CustomProduct"},
						"comparisonType": 1}
				]}},
				"CustomProduct": {"BindParameterEnabledCustomProductToProduct": {"ruleType": 0,
					"property": 1,
					"conditions": [
						{"leftExpression": {"type": 1,
							"attribute": "Product"},
							"comparisonType": 1}
					]}}},
					userCode: {}
				};
	});
