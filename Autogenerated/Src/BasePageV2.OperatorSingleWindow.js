define("BasePageV2", ["terrasoft", "ServiceHelper"],
	function(Terrasoft, ServiceHelper) {
		return {
			messages: {

				/**
				 * @message QueueItemPostponed
				 * ########### ##### ######### ######## ########## ## ######### ######## #######.
				 */
				"QueueItemPostponed": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message CloseQueueItemEdit
				 * ########### ### ######## ######## ###### ######## #######.
				 */
				"CloseQueueItemEdit": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message PostponeProcessExecution
				 * ######## ## ############# ######## ########## #### ######## ######## #######.
				 */
				"PostponeProcessExecution": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			},
			attributes: {

				/**
				 * ############# ######## ####### ####### ####.
				 * @type {String}
				 */
				"QueueItemId": {
					"dataValueType": this.Terrasoft.DataValueType.GUID,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * ####### ####, ### ######## #### ####### ######### ######### ####### ####### ####.
				 * @type {Boolean}
				 */
				"IsQueueProcessMode": {
					"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": false
				}
			},
			methods: {

				/**
				 * ######### ##### ############## ######## ####### ## ############## ########## ########### ########.
				 * @private
				 * @param {String} processId ############# ########## ########### ########.
				 * @param {Function} callback ####### ######### ######.
				 * @param {String} callback.queueItemId (optional) ############# ########## ######## #######.
				 */
				findQueueItemId: function(processId, callback) {
					var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "QueueItem"
					});
					esq.addColumn("Id");
					esq.filters.addItem(esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"SysProcessDataId", processId, this.Terrasoft.DataValueType.GUID));
					esq.getEntityCollection(function(result) {
						if (!result.success) {
							callback();
							return;
						}
						var entities = result.collection;
						var queueItemsCount = entities.getCount();
						if (queueItemsCount === 0) {
							callback();
							return;
						} else if (queueItemsCount > 1) {
							this.error(this.get("Resources.Strings.MultipleQueueItemsFoundError"));
							callback();
							return;
						}
						var entity = entities.getByIndex(0);
						var queueItemId = entity.get("Id");
						callback(queueItemId);
					}, this);
				},

				/**
				 * ########### (########## # #######) ####### #######.
				 * @private
				 * @param {String} queueItemId ############# ######## #######.
				 * @param {Function} callback ####### ######### ######.
				 * @param {Boolean} callback.success ####### ######### ########## ########.
				 */
				postponeQueueItem: function(queueItemId, callback) {
					var serviceCallBack = function(response, success) {
						if (!success) {
							var errorMessage =
								this.Ext.String.format(this.get("Resources.Strings.PostponeQueueItemError"),
									response.responseText);
							this.error(errorMessage);
							if (callback) {
								callback(false);
							}
							return;
						}
						if (callback) {
							callback(response === 1);
						}

					};
					ServiceHelper.callService({
						serviceName: "QueuesService",
						methodName: "PostponeQueueItem",
						data: {
							queueItemId: queueItemId
						},
						callback: serviceCallBack,
						scope: this
					});
				},

				/**
				 * @inheritDoc
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						var isProcessMode = this.get("IsProcessMode");
						if (!isProcessMode) {
							callback.call(scope || this);
							return;
						}
						this.initQueueInfo(callback.bind(scope || this));
					}, this]);
				},

				/**
				 * ############## ########## # ######### # ####### ######### ######### ####### ####### ####.
				 * @param {Function} callback ####### ######### ######.
				 */
				initQueueInfo: function(callback) {
					var processData = this.get("ProcessData");
					if (!processData || !processData.processId) {
						callback();
						return;
					}
					var processId = processData.processId;
					this.findQueueItemId(processId, function(queueItemId) {
						if (!queueItemId) {
							callback();
							return;
						}
						this.set("QueueItemId", queueItemId);
						this.set("IsQueueProcessMode", true);
						this.sandbox.subscribe("QueueItemPostponed", function() {
							this.onQueueItemPostponed();
						}, this);

						this.sandbox.subscribe("CloseQueueItemEdit", this.closeQueueItemEdit, this,
							[this.getQueueItemEditModuleId()]);
						callback();
					}.bind(this));

				},

				/**
				 * @inheritDoc Terrasoft.DelayExecutionUtilities#getDelayExecutionButtonVisible
				 * @overridden
				 */
				getDelayExecutionButtonVisible: function() {
					return this.callParent(arguments) && !this.get("IsQueueProcessMode");
				},

				/**
				 * ########## ############# ###### ######### ###### ######## #######.
				 * @protected
				 * @returns {String}
				 */
				getQueueItemEditModuleId: function() {
					return this.sandbox.id + "_OpenQueueItemEditPage";
				},

				/**
				 * ######### ###### ######### ###### ######## #######.
				 * @protected
				 * @param {String} queueItemId ############# ######## #######.
				 */
				loadQueueItemEditPageModule: function(queueItemId) {
					this.showBodyMask();
					this.sandbox.loadModule("CardModuleV2", {
						renderTo: "DelayExecutionModuleContainer",
						id: this.getQueueItemEditModuleId(),
						keepAlive: false,
						instanceConfig: {
							isSchemaConfigInitialized: true,
							useHistoryState: false,
							isSeparateMode: true,
							schemaName: "QueueItemEditPage",
							entitySchemaName: "QueueItem",
							operation: Terrasoft.ConfigurationEnums.CardOperation.EDIT,
							primaryColumnValue: queueItemId
						}
					});
				},

				/**
				 * ######### ###### ######### ###### ######## #######.
				 * @param {String} moduleId ############# ######.
				 * @protected
				 */
				closeQueueItemEdit: function(moduleId) {
					this.set("DelayExecutionModuleContainerVisible", false);
					this.sandbox.unloadModule(moduleId);
				},

				/**
				 * ############ ############ ########## #### ######## ######## #######.
				 * @private
				 */
				onQueueItemPostponed: function() {
					this.sandbox.publish("PostponeProcessExecution");
				},

				/**
				 * ############ ####### ## ###### ############# ## ####.
				 * @private
				 */
				onChangeQueueItemDateButtonClick: function() {
					var queueItemId = this.get("QueueItemId");
					if (!queueItemId) {
						this.error(this.get("Resources.Strings.QueueItemIsEmptyError"));
						return;
					}
					this.get("DelayExecutionModuleContainerVisible");
					this.set("DelayExecutionModuleContainerVisible", true);
					this.loadQueueItemEditPageModule(queueItemId);
				},

				/**
				 * ############ ####### ## ###### ####### # #######.
				 * @private
				 */
				onPostponeQueueItemButtonClick: function() {
					var queueItemId = this.get("QueueItemId");
					if (!queueItemId) {
						this.error(this.get("Resources.Strings.QueueItemIsEmptyError"));
						return;
					}
					this.postponeQueueItem(queueItemId, function(success) {
						var messageString = (success)
							? "QueueItemPostponeSucceedMessage"
							: "QueueItemPostponeFailedMessage";
						var message = this.get("Resources.Strings." + messageString);
						this.showInformationDialog(message, function() {
							if (success) {
								this.onQueueItemPostponed();
							}
						}.bind(this));
					}.bind(this));
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "LeftContainer",
					"propertyName": "items",
					"name": "ChangeQueueItemDateButton",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": {"bindTo": "Resources.Strings.ChangeQueueItemDateButtonCaption"},
						"classes": {"textClass": "actions-button-margin-right"},
						"click": {"bindTo": "onChangeQueueItemDateButtonClick"},
						"visible": {"bindTo": "IsQueueProcessMode"}
					},
					"index": 2
				},
				{
					"operation": "insert",
					"parentName": "LeftContainer",
					"propertyName": "items",
					"name": "PostponeQueueItemButton",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": {"bindTo": "Resources.Strings.PostponeQueueItemButtonCaption"},
						"classes": {"textClass": "actions-button-margin-right"},
						"click": {"bindTo": "onPostponeQueueItemButtonClick"},
						"visible": {"bindTo": "IsQueueProcessMode"}
					},
					"index": 3
				}
			]/**SCHEMA_DIFF*/
		};
	});
