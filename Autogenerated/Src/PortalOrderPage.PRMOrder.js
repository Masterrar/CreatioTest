define("PortalOrderPage", [],
	function() {
		return {
			entitySchemaName: "Order",
			methods: {},
			details: /**SCHEMA_DETAILS*/{
				"PortalSupplyPaymentDetail": {
					"schemaName": "PortalSupplyPaymentDetailV2",
					"entitySchemaName": "SupplyPaymentElement",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Order"
					},
					"defaultValues": {
						"Currency": {
							"masterColumn": "Currency"
						},
						"CurrencyRate": {
							"masterColumn": "CurrencyRate"
						}
					},
					"subscriber": {"methodName": "refreshAmount"}
				},
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "OrderPassportTab",
					"propertyName": "items",
					"name": "PortalSupplyPaymentDetail",
					"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
				},
				{
					"operation": "remove",
					"name": "SupplyPayment"
				}
			]/**SCHEMA_DIFF*/
		};
	});
