define("PortalSupplyPaymentDetailV2", [],
	function() {
		return {
			entitySchemaName: "SupplyPaymentElement",
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseGridDetail#getAddTypedRecordButtonVisible
				 */
				getAddTypedRecordButtonVisible: function() {
					return false;
				},

				/**
				 * @inheritdoc Terrasoft.ConfigurationGridUtilites#getCellControlsConfig
				 * @overridden
				 */
				getCellControlsConfig: function() {
					const controlsConfig = this.callParent(arguments);
					this.Ext.apply(controlsConfig, {
						enabled: false
					});
					return controlsConfig;
				}
			},
			diff: [
				{
					"operation": "remove",
					"name": "activeRowActionSave"
				},
				{
					"operation": "remove",
					"name": "activeRowActionOpenCard"
				},
				{
					"operation": "remove",
					"name": "activeRowActionCancel"
				},
				{
					"operation": "remove",
					"name": "activeRowActionRemove"
				}
			]
		};
	}
);
