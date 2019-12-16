define("ContactSectionV2", ["GridUtilitiesV2", "RightUtilities", "ConfigurationConstants",
		"GoogleIntegrationUtilitiesV2", "css!ContactSectionV2CSS"],
	function(gridUtilitiesV2, RightUtilities, ConfigurationConstants) {
		return {
			entitySchemaName: "Contact",
			attributes: {
				/**
				 * The visibility of the menu items for synchronization.
				 * @Type {Boolean}
				 */
				"canUseGoogleOrSocialFeaturesByBuildType": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					value: false
				}
			},
			messages: {
				/**
				 * @message GetMapsConfig
				 * ########## #########, ########### ### ###### ###### ####### ## #####.
				 * @param {Object} #########, ############ ### ###### ###### ####### ## #####.
				 */
				"GetMapsConfig": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			mixins: {
				GoogleIntegrationUtils: "Terrasoft.GoogleIntegrationUtilities"
			},
			methods: {
				/**
				 * @overridden
				 */
				init: function() {
					this.set("GridType", "tiled");
					this.callParent(arguments);
					var sysSettings = ["BuildType"];
					this.mixins.GoogleIntegrationUtils.init.call(this);
					Terrasoft.SysSettings.querySysSettings(sysSettings, function() {
						var buildType = Terrasoft.SysSettings.cachedSettings.BuildType &&
							Terrasoft.SysSettings.cachedSettings.BuildType.value;
						this.set("canUseGoogleOrSocialFeaturesByBuildType", buildType !==
							ConfigurationConstants.BuildType.Public);
					}, this);
				},

				/**
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1002);
					this.callParent(arguments);
				},

				/**
				 * ######## "######## ## #####".
				 */
				openShowOnMap: function() {
					var items = this.getSelectedItems();
					var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "Contact"
					});
					select.addColumn("Id");
					select.addColumn("Name");
					select.addColumn("Address");
					select.addColumn("City");
					select.addColumn("Region");
					select.addColumn("Country");
					select.addColumn("GPSN");
					select.addColumn("GPSE");
					select.filters.add("ContactIdFilter", this.Terrasoft.createColumnInFilterWithParameters("Id", items));
					select.getEntityCollection(function(result) {
						if (result.success) {
							var mapsConfig = {
								mapsData: []
							};
							result.collection.each(function(item) {
								var address = [];
								var country = item.get("Country");
								if (country && country.displayValue) {
									address.push(country.displayValue);
								}
								var region = item.get("Region");
								if (region && region.displayValue) {
									address.push(region.displayValue);
								}
								var city = item.get("City");
								if (city && city.displayValue) {
									address.push(city.displayValue);
								}
								address.push(item.get("Address"));
								var name = item.get("Name");
								var dataItem = {
									caption: name,
									content: "<h2>" + name + "</h2><div>" + address.join(", ") + "</div>",
									address: item.get("Address") ? address.join(", ") : null,
									gpsN: item.get("GPSN"),
									gpsE: item.get("GPSE"),
									updateCoordinatesConfig: {
										schemaName: "Contact",
										id: item.get("Id")
									}
								};
								mapsConfig.mapsData.push(dataItem);
							});
							var mapsModuleSandboxId = this.sandbox.id + "_MapsModule" + this.Terrasoft.generateGUID();
							this.sandbox.subscribe("GetMapsConfig", function() {
								return mapsConfig;
							}, [mapsModuleSandboxId]);
							this.sandbox.loadModule("MapsModule", {
								id: mapsModuleSandboxId,
								keepAlive: true
							});
						}
					}, this);
				},

				/**
				 * Synchronizes with Google contacts.
				 * @protected
				 */
				synchronizeNow: function() {
					if (this.get("canUseGoogleOrSocialFeaturesByBuildType")) {
						this.synchronizeWithGoogleContacts();
					} else {
						if (!this.get("IsExchangeContactSyncExist")) {
							this.showConfirmationDialog(this.get("Resources.Strings.FolderNotSet"), function(result) {
								if (result === Terrasoft.MessageBoxButtons.YES.returnCode) {
									this.showSyncDialog();
								}
							}, ["yes", "no"]);
						}
					}
				},

				/**
				 * Action "Synchronize with Google Contacts".
				 * @protected
				 */
				synchronizeWithGoogleContacts: function() {
					this.checkCanUseGoogleContactsSync(function() {
						this.showBodyMask();
						if (!this.get("GoogleSyncExists") && !this.get("IsExchangeContactSyncExist")) {
							this.showConfirmationDialog(this.get("Resources.Strings.FolderNotSet"), function(result) {
								if (result === Terrasoft.MessageBoxButtons.YES.returnCode) {
									this.showSyncDialog();
								}
							}, ["yes", "no"]);
							this.hideBodyMask();
							return;
						}
						if (!this.get("GoogleSyncExists") && this.get("IsExchangeContactSyncExist")) {
							this.hideBodyMask();
							return;
						}
						this.startGoogleSynchronization();
					}, this);
				},

				/**
				 * @obsolete
				 */
				fillContactWithSocialNetworksData: function() {
					var activeRowId = this.get("ActiveRow");
					var selectedRowIds = this.get("SelectedRows");
					if (!activeRowId) {
						if (selectedRowIds.length > 0) {
							activeRowId = selectedRowIds[0];
						}
					}
					var confirmationMessage = this.get("Resources.Strings.OpenContactCardQuestion");
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "Contact"
					});
					esq.addColumn("FacebookId");
					esq.addColumn("LinkedInId");
					esq.addColumn("TwitterId");
					var filters = this.Ext.create("Terrasoft.FilterGroup");
					filters.addItem(esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
						"Id", activeRowId));
					esq.filters = filters;
					esq.getEntity(activeRowId, function(result) {
						if (result.success && result.entity) {
							var entity = result.entity;
							var facebookId = entity.get("FacebookId");
							var linkedInId = entity.get("LinkedInId");
							var twitterId = entity.get("TwitterId");
							if (facebookId !== "" || linkedInId !== "" || twitterId !== "") {
								this.sandbox.publish("PushHistoryState", {
									hash: "FillContactWithSocialAccountDataModule",
									stateObj: {
										FacebookId: facebookId,
										LinkedInId: linkedInId,
										TwitterId: twitterId,
										ContactId: activeRowId
									}
								});
							} else {
								this.Terrasoft.utils.showConfirmation(confirmationMessage,
									function getSelectedButton(returnCode) {
										if (returnCode === this.Terrasoft.MessageBoxButtons.YES.returnCode) {
											this.editRecord(activeRowId);
											if (!this.get("ActiveRow") && selectedRowIds.length > 0) {
												this.unSetMultiSelect();
											}
										}
									}, ["yes", "no"], this, null);
							}
						}
					}, this);
				},

				/**
				 * ########## ######### ######## ####### # ###### ########### #######.
				 * @protected
				 * @overridden
				 * @return {Terrasoft.BaseViewModelCollection} ########## ######### ######## ####### # ######.
				 * ########### #######
				 */
				getSectionActions: function() {
					var actionMenuItems = this.callParent(arguments);
					actionMenuItems.addItem(this.getButtonMenuItem({
						Type: "Terrasoft.MenuSeparator",
						Caption: ""
					}));
					actionMenuItems.addItem(this.getButtonMenuItem({
						"Click": {"bindTo": "openShowOnMap"},
						"Caption": {"bindTo": "Resources.Strings.ShowOnMapActionCaption"},
						"Enabled": {"bindTo": "isAnySelected"}
					}));
					return actionMenuItems;
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "DataGridContainer",
					"values": {
						"controlConfig": {
							"classes": ["contact-grid"]
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
