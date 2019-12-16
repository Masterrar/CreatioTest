﻿define("EmailMessageHistoryItemPage", ["ConfigurationConstants", "EmailMessageConstants",
	"NetworkUtilities", "MaskHelper", "EmailHelper", "EmailMessageHistoryItemPageResources",
		"css!EmailMessageHistoryItemStyle"],
		function(ConfigurationConstants, EmailMessageConstants, NetworkUtilities, MaskHelper, EmailHelper, resources) {
			return {
				entitySchemaName: "BaseMessageHistory",
				details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
				attributes: {
					/**
					 * File attachment status.
					 */
					"IsFilesAttached": {
						"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
						"value": false
					},

					/**
					 * @inheritdoc Terrasoft.BaseEmailMessageHistoryPage#ConnectionColumnsPath
					 * @overridden
					 */
					"ConnectionColumnsPath": {
						"dataValueType": this.Terrasoft.DataValueType.TEXT,
						"value": "[Activity:Id:RecordId]"
					}
				},
				messages: {
					/**
					 * @message EmailTemplateLoaded
					 * Informs publisher that loaded EmailTemplate from history page
					 */
					"EmailTemplateLoaded": {
						mode: this.Terrasoft.MessageMode.PTP,
						direction: this.Terrasoft.MessageDirectionType.PUBLISH
					}
				},
				methods: {

					/**
					 * Check feature status.
					 * @private
					 * @return {Boolean} feature state.
					 */
					_isEmailTemplateMultiLanguage: function() {
						return this.getIsFeatureEnabled("EmailTemplateMultiLanguageInActionDashBoard");
					},

					/**
					 * Returns marker for email link image.
					 * @private
					 * @return {String} Marker for email link image.
					 */
					getEmailLinkImageMarker: function() {
						return "EmailLinkImage" + this.get("RecordId");
					},

					/**
					 * Returns an image of the file attachment.
					 * @private
					 * @return {String} Image of the file attachment.
					 */
					getFileAttachmentsImage: function() {
						return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.FileAttachmentsImage"));
					},

					/**
					 * Added columns and filters to collection
					 * @protected
					 */
					getActivityFileEsq: function() {
						var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "ActivityFile"
						});
						esq.addColumn("Name");
						esq.addColumn("Id");
						esq.filters.addItem(esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
								"Activity", this.get("RecordId")));
						esq.filters.addItem(esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
								"Inline", 0));
						return esq;
					},

					/**
					 * Filled collection received from callback getHistoryFiles
					 * @protected
					 */
					getHistoryFilesCallback: function(result, callback, scope) {
						var collection = result.collection;
						if (collection && collection.getCount() > 0) {
							this.set("IsFilesAttached", true);
							var filesConfigs = [];
							this.Terrasoft.each(collection.getItems(), function(item) {
								filesConfigs.push({
									Name: item.get("Name"),
									Id: item.get("Id"),
									SchemaUId: ConfigurationConstants.SysSchema.ActivityFile
								});
							}, this);
							callback.call(scope || this, filesConfigs);
						}
					},

					/**
					 * Get full link for current email edit page.
					 * @protected
					 * @returns {String} url of edit page.
					 */
					getEmailPageHref: function() {
						var urlRelativePart = NetworkUtilities.getEntityUrl("Activity", this.get("RecordId"),
								ConfigurationConstants.Activity.Type.Email);
						return this.Terrasoft.combinePath(this.Terrasoft.workspaceBaseUrl, "Nui", "ViewModule.aspx#" +
								urlRelativePart);
					},

					/**
					 * @inheritdoc Terrasoft.BaseEmailMessageHistoryPage#getNotifierGroup
					 * @overridden
					 */
					getNotifierGroup: function(esq) {
						var filterGroup = esq.createFilterGroup();
						filterGroup.name = "EmailNotifierFilter";
						filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
						filterGroup.add("EmailExists", esq.createExistsFilter(this.$ConnectionColumnsPath + ".Id"));
						filterGroup.add("NotEmailNotifier", esq.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.NOT_EQUAL, "MessageNotifier",
								EmailMessageConstants.MessageNotifier.Email));
						return filterGroup;
					},

					/**
					 * @inheritdoc Terrasoft.BaseEmailMessageHistoryPage#getHistoryMessageColumns
					 * @overridden
					 */
					getHistoryMessageColumns: function() {
						return [this.$ConnectionColumnsPath + ".Body", this.$ConnectionColumnsPath + ".Recepient",
							this.$ConnectionColumnsPath + ".Sender", this.$ConnectionColumnsPath + ".CopyRecepient",
							this.$ConnectionColumnsPath + ".StartDate", this.$ConnectionColumnsPath + ".IsHtmlBody",
							this.$ConnectionColumnsPath + ".MessageType", this.$ConnectionColumnsPath + ".EmailSendStatus",
							this.$ConnectionColumnsPath + ".Title", this.$ConnectionColumnsPath + ".SendDate",
							this.$ConnectionColumnsPath + ".IsAutoSubmitted",
							this.$ConnectionColumnsPath + ".SenderContact"];
					},

					/**
					 * @inheritDoc Terrasoft.BaseMessageHistoryItemPage#getCreatedByName
					 * @overridden
					 */
					getCreatedByName: function() {
						if (this.get(this.$ConnectionColumnsPath + ".IsAutoSubmitted") &&
							this.getIsFeatureEnabled("OpenEmailSyncSettingsPage")) {
							var emails = EmailHelper.getEmailAddresses(this.get(this.$ConnectionColumnsPath + ".Sender"));
							return emails ? emails[0] : this.callParent(arguments);
						}
						var senderContact = this.getSenderContact();
						if(!this.Ext.isEmpty(senderContact) && senderContact.displayValue) {
							 return senderContact.displayValue;
						}
						return this.callParent(arguments);
					},

					/**
					 * @inheritDoc Terrasoft.BaseMessageHistoryItemPage#getCreatedByUrl
					 * @overridden
					 */
					getCreatedByUrl: function() {
						var senderContact = this.getSenderContact();
						if(!this.Ext.isEmpty(senderContact) && senderContact.value) {
							var hash = NetworkUtilities.getEntityUrl("Contact", senderContact.value);
							return this.get("Resources.Strings.ViewModuleUrl") + hash;
						}
						return this.callParent(arguments);
					},

					/**
					 * @inheritDoc Terrasoft.BaseMessageHistoryItemPage#getCreatedByImage
					 * @override
					 */
					getCreatedByImage: function() {
						const senderContact = this.getSenderContact();
						return this.getImageUrlByEntity(senderContact);
					},

					/**
					 * Gets sender contact from the email.
					 * @returns {Object} Returns sender contact.
					 */
					getSenderContact: function() {
						return this.get(this.$ConnectionColumnsPath + ".SenderContact");
					},

					/**
					 * Returns draft label visibility.
					 * @returns {Boolean} Draft label visibility.
					 */
					isDraftLabelVisible: function() {
						var emailSendStatus = this.get(this.$ConnectionColumnsPath + ".EmailSendStatus");
						return emailSendStatus.value === EmailMessageConstants.Activity.EmailSendStatus.NotSend ||
								emailSendStatus.value === EmailMessageConstants.Activity.EmailSendStatus.Opened ||
								emailSendStatus.value === EmailMessageConstants.Activity.EmailSendStatus.ErrorOnSend ||
								emailSendStatus.value === EmailMessageConstants.Activity.EmailSendStatus.Awaiting;
					},

					/**
					 * @inheritdoc Terrasoft.BaseMessageHistoryPage#initEmailActionsMenuCollection
					 * @overridden
					 */
					initEmailActionsMenuCollection: function() {
						var collection = this.get("EmailActionsMenuCollection") ||
								this.Ext.create("Terrasoft.BaseViewModelCollection");
						var replyToAllUsingTemplateItem = this.getButtonMenuItem({
							"Caption": {
								bindTo: "Resources.Strings.ReplyToAllUsingTemplate"
							},
							"MarkerValue": "ReplyToAllUsingTemplate",
							"Click": {"bindTo": "replyToAllWithTemplate"}
						});
						collection.addItem(replyToAllUsingTemplateItem);
						this.set("EmailActionsMenuCollection", collection);
						this.callParent(arguments);
					},

					/**
					 * Handler for ReplyToAllUsingTemplate button click.
					 */
					replyToAllWithTemplate: function() {
						var config = {
							entitySchemaName: "EmailTemplate",
							multiSelect: false,
							columns: ["Body"]
						};
						this.openLookup(config, this.fillEmailWithTemplate, this);
					},

					/**
					 * Form data for email publisher page.
					 * @param {object} arguments from lookup.
					 */
					fillEmailWithTemplate: function(args) {
						var recepient = this.get(this.$ConnectionColumnsPath + ".Sender") + ";" +
								this.get(this.$ConnectionColumnsPath + ".Recepient");
						var copyRecepient = this.get(this.$ConnectionColumnsPath + ".CopyRecepient");
						var selectedItems = args.selectedRows.getItems();
						var selectedItem = selectedItems.length && selectedItems[0];
						var body = this.generateReplyBody();
						if (selectedItem && selectedItem.Body) {
							body = this._isEmailTemplateMultiLanguage() ? body : selectedItem.Body + body;
						}
						var title = this.get(this.$ConnectionColumnsPath + ".Title");
						title = title.toUpperCase().indexOf("RE: ") === 0 ? title : "RE: " + title;
						var data = {
							"body": body,
							"title": title,
							"recepient": recepient,
							"copyRecepient": copyRecepient,
							"id": selectedItem.Id
						};
						this.sandbox.publish("EmailTemplateLoaded", data, [this.sandbox.id]);
					},

					/**
					 * Generates reply body.
					 * @return {String} result Body
					 */
					generateReplyBody: function() {
						var body = this.get(this.$ConnectionColumnsPath + ".IsHtmlBody")
							? this.get(this.$ConnectionColumnsPath + ".Body")
							: this.Ext.htmlEncode(this.get(this.$ConnectionColumnsPath + ".Body"));
						var sender = this.get(this.$ConnectionColumnsPath + ".Sender");
						var recipient = this.get(this.$ConnectionColumnsPath + ".Recepient");
						var copyRecipient = this.get(this.$ConnectionColumnsPath + ".CopyRecepient");
						var startDate = this.Terrasoft.utils.string.getTypedStringValue(
								this.get(this.$ConnectionColumnsPath + ".StartDate"), this.Terrasoft.DataValueType.DATE_TIME);
						var title = this.get(this.$ConnectionColumnsPath + ".Title");
						var template = this.get("Resources.Strings.ReplyBodyHtmlTemplate");
						body = this.Ext.String.format(template, sender, startDate, recipient, copyRecipient, title, body,
								this.get("Resources.Strings.SenderCaption"),
								this.get("Resources.Strings.SendDateCaption"),
								this.get("Resources.Strings.RecepientCaption"),
								this.get("Resources.Strings.CopyRecepientCaption"),
								this.get("Resources.Strings.TitleCaption"));
						body = this.validateMessage(body);
						return body;
					},

					/**
					 * @inheritdoc Terrasoft.BaseMessageHistoryPage#getHistoryFiles
					 * @overridden
					 */
					getHistoryFiles: function(callback, scope) {
						var esq = this.getActivityFileEsq();
						esq.getEntityCollection(function(result) {
							this.getHistoryFilesCallback(result, callback, scope);
						}, this);
					},

					/**
					 * @inheritdoc Terrasoft.BaseMessageHistoryPage#addAdditionalFilters
					 * @overridden
					 */
					addAdditionalFilters: function(esq, config) {
						if (!config.needToShowSystemMessages) {
							var filterGroup = esq.createFilterGroup();
							filterGroup.name = "EmailSystemMessages";
							filterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
							filterGroup.add("IsAutoSubmitted", esq.createColumnFilterWithParameter(
									this.Terrasoft.ComparisonType.EQUAL, this.$ConnectionColumnsPath + ".IsAutoSubmitted",
									false));
							filterGroup.add("NotEmailNotifier", esq.createColumnFilterWithParameter(
									this.Terrasoft.ComparisonType.NOT_EQUAL, "MessageNotifier",
									EmailMessageConstants.MessageNotifier.Email));
							esq.filters.addItem(filterGroup);
						}
					}
				},

				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "insert",
						"name": "EmailLinkImage",
						"parentName": "MessageHeaderContainer",
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
										.getUrl(resources.localizableImages.EmailLinkImage)
							},
							"href": {"bindTo": "getEmailPageHref"},
							"classes": {
								"hyperlinkClass": ["emailLinkImage"]
							},
							"markerValue": {
								"bindTo": "getEmailLinkImageMarker"
							}
						},
						"index": 5
					},
					{
						"operation": "merge",
						"name": "MessageFiles",
						"parentName": "MessageBodyContainer",
						"propertyName": "items",
						"values": {
							"generator": function() {
								return {
									"id": "FilesText",
									"markerValue": "FilesText",
									"className": "Terrasoft.MultilineFileLabel",
									"classes": {
										"multilineLabelClass": ["inlineEmailMessageHistoryFiles"]
									},
									"caption": {
										"bindTo": "FilesText"
									},
									"showReadMoreButton": false
								};
							}
						}
					},
					{
						"operation": "merge",
						"name": "MessageText",
						"values": {
							"generator": function() {
								return {
									"id": "MessageText",
									"markerValue": "MessageText",
									"className": "Terrasoft.SelectionHandlerMultilineLabel",
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
									"showFloatButton": {"bindTo": "CreateCaseFromHistoryFeatureState"}
								};
							}
						}
					},
					{
						"operation": "merge",
						"name": "CreatedByLink",
						"parentName": "CreatedByLinkWrapContainer",
						"propertyName": "items",
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
						"name": "MessageDraftContainer",
						"parentName": "MessageContentContainer",
						"propertyName": "items",
						"values": {
							"id": "MessageDraftContainer",
							"layout": {
								"column": 0,
								"row": 2,
								"colSpan": 24,
								"rowSpan": 1
							},
							"markerValue": "MessageDraftContainer",
							"itemType": this.Terrasoft.ViewItemType.CONTAINER,
							"wrapClass": ["messageDraftContainer"],
							"items": []
						},
						"index": 3
					},
					{
						"operation": "insert",
						"name": "DraftLabel",
						"parentName": "MessageDraftContainer",
						"propertyName": "items",
						"values": {
							"id": "DraftLabel",
							"labelClass": ["draftLabel"],
							"markerValue": "DraftLabel",
							"itemType": this.Terrasoft.ViewItemType.LABEL,
							"caption": {
								"bindTo": "Resources.Strings.DraftString"
							},
							"visible": {
								"bindTo": "isDraftLabelVisible"
							}
						}
					},
					{
						"operation": "insert",
						"name": "FileAttachmentsImage",
						"parentName": "AdditionalInfoWrapContainer",
						"propertyName": "items",
						"values": {
							"getSrcMethod": "getFileAttachmentsImage",
							"onPhotoChange": this.Terrasoft.emptyFn,
							"readonly": true,
							"classes": {
								"wrapClass": ["fileAttachmentsImage"]
							},
							"markerValue": "FileAttachmentsImage",
							"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
							"visible": {
								"bindTo": "IsFilesAttached"
							}
						},
						"index": 3
					},
					{
						"operation": "merge",
						"name": "EmailRecepient",
						"parentName": "EmailRecepientWrapContainer",
						"propertyName": "items",
						"values": {
							"caption": {
								"bindTo": "[Activity:Id:RecordId].Recepient"
							}
						},
						"index": 3
					},
					{
						"operation": "merge",
						"name": "EmailSender",
						"parentName": "EmailSenderWrapContainer",
						"propertyName": "items",
						"values": {
							"caption": {
								"bindTo": "[Activity:Id:RecordId].Sender"
							}
						},
						"index": 1
					}
				]/**SCHEMA_DIFF*/
			};
		}
);
