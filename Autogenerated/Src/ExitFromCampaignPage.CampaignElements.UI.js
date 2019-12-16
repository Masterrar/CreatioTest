define("ExitFromCampaignPage", ["MultilineLabel", "css!MultilineLabel"],
	function() {
		return {
			messages: {
				"ReRenderElement": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.PTP
				}
			},
			attributes: {
				/**
				 * Flag to indicate that element is campaign's goal or not.
				 */
				"IsCampaignGoal": {
					"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			methods: {
				/**
				 * @inheritdoc CampaignBaseAudiencePropertiesPage#getContextHelpCode
				 * @overridden
				 */
				getContextHelpCode: function() {
					return "CampaignExitFromCampaignElement";
				},

				/**
				 * @inheritdoc BaseProcessSchemaElementPropertiesPage#initParameters
				 * @override
				 */
				initParameters: function(element) {
					this.callParent(arguments);
					this.$IsCampaignGoal = element.isCampaignGoal;
				},

				/**
				 * @inheritdoc BaseProcessSchemaElementPropertiesPage#saveValues
				 * @overridden
				 */
				saveValues: function() {
					this.callParent(arguments);
					var element = this.get("ProcessElement");
					element.isCampaignGoal = this.$IsCampaignGoal;
					element.initLargeImage();
					this.sandbox.publish("ReRenderElement", element);
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "InformationLabel",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"className": "Terrasoft.MultilineLabel",
						"caption": {"bindTo": "Resources.Strings.ProcessInformationText"},
						"contentVisible": true,
						"classes": {
							"labelClass": ["label-small"]
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"name": "ContactFolderHint",
					"values": {
						"layout": {"column": 22, "row": 1, "colSpan": 1},
						"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
						"content": {"bindTo": "Resources.Strings.ContactFolderSelectionHint"},
						"controlConfig": {
							"classes": {
								"wrapperClass": "t-folder-information-btn"
							}
						}
					}
				},
				{
					"operation": "insert",
					"name": "IsCampaignGoalLabel",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 24
						},
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.IsCampaignGoalLabel"
						},
						"classes": {
							"labelClass": ["t-title-label-proc"]
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ContentContainer",
					"propertyName": "items",
					"name": "IsCampaignGoal",
					"values": {
						"wrapClass": ["t-checkbox-control"],
						"visible": true,
						"caption": {"bindTo": "Resources.Strings.IsCampaignGoalCaption"},
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 24
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
});
