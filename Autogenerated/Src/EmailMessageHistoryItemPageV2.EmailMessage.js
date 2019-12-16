define("EmailMessageHistoryItemPageV2", ["EmailMessageHistoryItemPageV2Resources",
		"css!EmailMessageHistoryItemStyleV2"],
	function(resources) {
		return {
			entitySchemaName: "BaseMessageHistory",
			details: /**SCHEMA_DETAILS*/{
				"EmailFiles": {
					"schemaName": "HistoryMessageFilesDetail",
					"entitySchemaName": "ActivityFile",
					"filter": {
						"masterColumn": "RecordId",
						"detailColumn": "Activity"
					},
					"additionalFileFilters": [{
						"filterColumnName": "Inline",
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"filterColumnValue": 0
					}]
				}
			}/**SCHEMA_DETAILS*/,
			attributes: {
			},
			messages: {
			},
			methods: {
				/**
				 * @inheritdoc Terrasoft.BasePageV2#init
				 * @override
				 */
				init: function() {
					this.callParent(arguments);
					this.subscribeDetailsEvents();
				},

				/**
				 * @inheritdoc Terrasoft.BaseMessageHistoryPage#getHistoryMessageFilesContainer
				 * @override
				 */
				getHistoryMessageFilesContainer: function() {
					return this.Ext.String.format("EmailMessageHistoryItemPageV2EmailFilesContainer-" +
						"{0}-{1}", this.get("Id"), this.sandbox.id);
				},

				/**
				 * @inheritdoc Terrasoft.BaseMessageHistoryPage#getHistoryMessageFilesDetailId
				 * @override
				 */
				getHistoryMessageFilesDetailId: function() {
					return this.getDetailId("EmailFiles");
				},

				/**
				 * @inheritDoc BaseMessageHistoryItemPage#getChannelIcon
				 * @override
				 */
				getChannelIcon: function () {
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.EmailChannelIcon"));
				},

				/**
				 * Return email subject for page.
				 * @return {String} Subject.
				 */
				getSubject: function() {
					return this.get(this.$ConnectionColumnsPath + ".Title");
				},

				/**
				 * Execute actions for email.
				 */
				emailAction: function () {
					var action = arguments[3];
					var emailId = this.get("RecordId");
					var emailConfig = this.getModuleStructure("Activity");
					var actionLink = emailConfig.cardModule + "/EmailPageV2/add/Type/Email/" + action + "/" + emailId;
					this.sandbox.publish("PushHistoryState", {hash: actionLink});
				},

				/**
				 * @inheritdoc BaseMessageHistoryItemPage#getOpacityMode
				 * @override
				 */
				getOpacityMode: function() {
					if (this.isDraftLabelVisible() || this.get(this.$ConnectionColumnsPath + ".IsAutoSubmitted")
						&& !this.get("IsMessageVisibleOnPortal")) {
						return Terrasoft.controls.opacityMode.Translucent;
					} else {
						return Terrasoft.controls.opacityMode.Opaque;
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseMessageHistoryPage#isFileDetailContainerVisible
				 * @override
				 */
				isFileDetailContainerVisible: function () {
					return true;
				},

				/**
				 * Get text for recipients hint.
				 * @return {string} Text for hint.
				 */
				getRecipientsHintContent: function() {
					var template = this.get("Resources.Strings.RecipientsHintTemplate");
					var hintText = this.Ext.String.format(template, this.get("Resources.Strings.RecepientCaption"),
						this._getEmailStringWithBreaks(this.get("[Activity:Id:RecordId].Recepient"), 100),
						this.get("Resources.Strings.CopyRecepientCaption"),
						this._getEmailStringWithBreaks(this.get("[Activity:Id:RecordId].CopyRecepient"), 100));
					return hintText;
				},

				_getEmailStringWithBreaks: function(source, symbolsCountPerLine) {
					var lines = source.replace(/\s*;\s*/g, "; ")
						.match(new RegExp(".{1," + symbolsCountPerLine + "}(; |$)", "g"));
					return lines && lines.join("<br/>&nbsp;&nbsp;&nbsp;&nbsp;") || source;
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "HistoryV1Container"
				},
				{
					"operation": "merge",
					"name": "HistoryV2EmailRecepient",
					"values": {
						"caption": {
							"bindTo": "[Activity:Id:RecordId].Recepient"
						},
						"hint": {"bindTo": "getRecipientsHintContent"}
					}
				},
				{
					"operation": "merge",
					"name": "HistoryV2CreatedByLink",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.HYPERLINK,
						"href": {
							"bindTo": "getCreatedByUrl"
						},
						"target": this.Terrasoft.controls.HyperlinkEnums.target.SELF
					}
				},
				{
					"operation": "insert",
					"name": "HistoryV2EmailLinkImage",
					"parentName": "HistoryV2MessageHeaderContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.HYPERLINK,
						"tpl": [
							/* eslint-disable quotes */
							'<a id="{id}" name="{name}" href="{href}" target="_self"' +
							' class="{hyperlinkClass}" style="{hyperlinkStyle}" title="{hint}" type="{type}">',
							'<img src="{imageSrc}">',
							'</a>'
							/* eslint-enable quotes */
						],
						"tplData": {
							"imageSrc": this.Terrasoft.ImageUrlBuilder
								.getUrl(resources.localizableImages.GoToEmailPage)
						},
						"href": {"bindTo": "getEmailPageHref"},
						"classes": {
							"hyperlinkClass": ["email-link-image"]
						},
						"markerValue": {
							"bindTo": "getEmailLinkImageMarker"
						}
					},
					"index": 3
				},
				{
					"operation": "insert",
					"name": "EmailAction",
					"parentName": "HistoryV2MessageHeaderContainer",
					"propertyName": "items",
					"values": {
						"id": "EmailAction",
						"itemType": this.Terrasoft.ViewItemType.BUTTON,
						"imageConfig": {
							"bindTo": "isCloudVisible",
							"bindConfig": {
								"converter": "getActionsButtonImage"
							}
						},
						"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"items": [],
						"markerValue": {
							"bindTo": "getActionsButtonMarkerValue"
						},
						"visible": {
							"bindTo": "isHistoryActionVisible"
						},
						"controlConfig": {
							"menu": {
								"items": {"bindTo": "EmailActionsMenuCollection"}
							}
						},
						"classes": {
							"wrapperClass": ["email-message-actions-button-wrapper"],
							"menuClass": ["email-message-actions-button-menu"]
						}
					},
					"index": 4
				},
				{
					"operation": "merge",
					"name": "HistoryV2MessageText",
					"values": {
						"generator": function() {
							return {
								"id": "MessageText",
								"markerValue": "MessageText",
								"className": "Terrasoft.MessageHistorySelectionHandler",
								"classes": {
									"multilineLabelClass": ["messageText"]
								},
								"caption": {
									"bindTo": "Message",
									"bindConfig": {"converter": "prepareMessage"}
								},
								"showLinks": true,
								"isHtmlBody": true,
								"selectedTextChanged": {"bindTo": "onSelectedTextChanged"},
								"selectedTextHandlerButtonClick": {"bindTo": "onSelectedTextButtonClick"},
								"showFloatButton": {"bindTo": "CreateCaseFromHistoryFeatureState"},
								"changeOpacity": {"bindTo": "getOpacityMode"},
								"frameBodyStyle": {
									"overflow": "hidden",
									"margin": 0,
									"font-family": "Calibri",
									"font-size": "15px",
									"lineHeight": "18px",
									"color": "#444444"
								},
								"visible": {
									"bindTo": "Message",
									"bindConfig": {
										"converter": "isMessageTextNotEmptyConverter"
									}
								}
							};
						}
					},
					"index": 2
				},
				{
					"operation": "insert",
					"name": "HistoryV2DraftContentContainer",
					"parentName": "HistoryV2MessageContentContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["draft-content-container"],
						"items": [],
						"visible": {
							"bindTo": "isDraftLabelVisible"
						}
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "HistoryV2DraftLabel",
					"parentName": "HistoryV2DraftContentContainer",
					"propertyName": "items",
					"values": {
						"id": "DraftLabel",
						"labelClass": ["draft-label"],
						"markerValue": "DraftLabel",
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.DraftStringColon"
						},
						"visible": {
							"bindTo": "isDraftLabelVisible"
						}
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "HistoryV2MessageSubject",
					"parentName": "HistoryV2DraftContentContainer",
					"propertyName": "items",
					"values": {
						"labelClass": ["email-subject"],
						"markerValue": "HistoryV2MessageSubject",
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "getSubject"
						},
						"visible": {
							"bindTo": "isDraftLabelVisible"
						}
					},
					"index": 1
				},
				{
					"operation": "merge",
					"name": "HistoryV2CreationInfo",
					"parentName": "HistoryV2MessageHeaderRightContainer",
					"values": {
						"id": "CreationInfo",
						"labelClass": ["creationInfoLabel"],
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "getCreatedOn"
						}
					},
					"index": 1
				},
				{
					"operation": "insert",
					"name": "HistoryV2EmailActionsContainer",
					"parentName": "HistoryV2MessageHeaderRightContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["email-actions-container"],
						"items": []
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "ReplyEmailAction",
					"parentName": "HistoryV2EmailActionsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"imageConfig": {"bindTo": "Resources.Images.ReplyEmailActionIcon"},
						"classes": {"imageClass": ["email-action-button"]},
						"click": {"bindTo": "emailAction"},
						"tag": "Reply"
					},
					"index": 0
				},
				{
					"operation": "insert",
					"name": "ReplyToAllEmailAction",
					"parentName": "HistoryV2EmailActionsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"imageConfig": {"bindTo": "Resources.Images.ReplyToAllEmailActionIcon"},
						"classes": {"imageClass": ["email-action-button"]},
						"click": {"bindTo": "emailAction"},
						"tag": "ReplyAll"
					},
					"index": 1
				},
				{
					"operation": "insert",
					"name": "ReplyUsingTemplateEmailAction",
					"parentName": "HistoryV2EmailActionsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"imageConfig": {"bindTo": "Resources.Images.ReplyUsingTemplateEmailActionIcon"},
						"classes": {"imageClass": ["email-action-button"]},
						"click": {"bindTo": "replyToAllWithTemplate"}
					},
					"index": 2
				},
				{
					"operation": "insert",
					"name": "ForwardEmailAction",
					"parentName": "HistoryV2EmailActionsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"imageConfig": {"bindTo": "Resources.Images.ForwardEmailActionIcon"},
						"classes": {"imageClass": ["email-action-button"]},
						"click": {"bindTo": "emailAction"},
						"tag": "Forward"
					},
					"index": 3
				},
				{
					"operation": "merge",
					"name": "HistoryV2FileDetailContainer",
					"parentName": "HistoryV2MessageFooterContainer",
					"propertyName": "items",
					"values": {
						"afterrender": {"bindTo": "loadDetailModule"},
						"afterrerender": {"bindTo": "loadDetailModule"},
						"visible": {
							"bindTo": "FilesDetailVisible"
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "HistoryV2FileDetailContainer",
					"propertyName": "items",
					"name": "EmailFiles",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.DETAIL,
						"markerValue": "FileDetail"
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
