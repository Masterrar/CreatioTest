define("SystemDesigner", ["RightUtilities"],
	function() {
		return {
			attributes: {
				
				"UsedFeatureBonus": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: null
				},

				
				"IsExistBonusInSales": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: null
				},

				
				"BonusInSalesCaption": {
					dataValueType: this.Terrasoft.DataValueType.TEXT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: this.Ext.emptyString
				}
			},
			methods: {
				
				setFeatureParameter: function() {
					this.callParent();
					var featureState = this.Terrasoft.Features.getIsEnabled("Bonus");
					this.set("UsedFeatureBonus", featureState);
				},

				
				getInstallPackages: function() {
					var packageNames = this.callParent(arguments);
					if (this.get("UsedFeatureBonus")) {
						packageNames.push("BonusInSales");
					}
					return packageNames;
				},

				
				setDefaultParameters: function() {
					if (this.get("UsedFeatureBonus")) {
						this.set("IsExistBonusInSales", false);
					}
					this.callParent(arguments);
				}
			},
			diff: [
				{
					"operation": "insert",
					"index": 30,
					"propertyName": "items",
					"parentName": "InstallExtensionsTile",
					"name": "InstallPackageBonusLink",
					"values": {
						"visible": {"bindTo": "UsedFeatureBonus"},
						"itemType": Terrasoft.ViewItemType.LINK,
						"caption": {"bindTo": "BonusInSalesCaption"},
						"click": {"bindTo": "onInstallPackageClick"},
						"tag": "BonusInSales"
					}
				}
			]
		};
	});
