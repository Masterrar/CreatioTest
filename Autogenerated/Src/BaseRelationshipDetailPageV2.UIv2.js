﻿define("BaseRelationshipDetailPageV2", [], function() {
	return {
		entitySchemaName: "Relationship",
		attributes: {
			"RelationType": {
				lookupListConfig: {
					filter: function() {
						var relationTypeFilterName = this.getRelType(false);
						return this.getFilterByRelationTypeFilterName(relationTypeFilterName);
					}
				},
				dependencies: [{
					columns: ["ReverseRelationType"],
					methodName: "setRelationTypeByReverseRelationType"
				}]
			},
			"ReverseRelationType": {
				lookupListConfig: {
					filter: function() {
						var relationTypeFilterName = this.getRelType(true);
						return this.getFilterByRelationTypeFilterName(relationTypeFilterName, "ReverseRelationType");
					}
				},
				dependencies: [{
					columns: ["RelationType"],
					methodName: "setReverseRelationTypeByRelationType"
				}]
			},
			"RelationTypeFilter": {
				dataValueType: Terrasoft.DataValueType.TEXT
			},
			"AccountA": {
				lookupListConfig: {
					columns: ["Parent"]
				}
			},
			"AccountB": {
				lookupListConfig: {
					columns: ["Parent"],
					filter: function() {
						var accountA = this.get("AccountA");
						return this.getFilterByRelationColumn(accountA, "Account");
					}
				}
			},
			"ContactB": {
				lookupListConfig: {
					filter: function() {
						var contactA = this.get("ContactA");
						return this.getFilterByRelationColumn(contactA);
					}
				}
			}
		},
		columns: {
			"Mode": {
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				name: "Mode"
			}
		},
		details: /**SCHEMA_DETAILS*/ {} /**SCHEMA_DETAILS*/ ,
		messages: {
			"GetAddMode": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},
			"GetMasterRecordId": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			}
		},
		methods: {
			/**
			 * #####, ############## ##### ############# #######
			 */
			onEntityInitialized: function() {
				this.callParent(arguments);
				this.initParentAccountRelationType();
				this.getAddMode();
				this.getMasterRecordId();
				this.initIfAIsPrimary();
				this.setRelationTypeFilterByColumn();
				if (!Ext.isEmpty(this.get("Mode"))) {
					this.set("Active", true);
				}
				if (this.get("RelationTypeFilter") === "Account") {
					this.addColumnValidator("AccountB", this.validateEmptyFieldB);
				}
				if (this.get("RelationTypeFilter") === "Contact") {
					this.addColumnValidator("ContactB", this.validateEmptyFieldB);
				}
			},

			/**
			 * ######### ##### ############ ########/######## ##########
			 */
			initParentAccountRelationType: function() {
				this.Terrasoft.SysSettings.querySysSettings(["ParentAccountRelationType"], function(values) {
					this.set("ParentAccountRelationType", values.ParentAccountRelationType);
					if (values.ParentAccountRelationType) {
						this.setRelationType(values.ParentAccountRelationType.value, "ChildAccountRelationType", this);
					}
				}, this);
			},

			/**
			 * Checks mandatory field while saving.
			 * @param {Object} value Db field value.
			 * @return {Object} Message.
			 */
			validateEmptyFieldB: function(value) {
				var message = "";
				if (!value) {
					message = this.get("Resources.Strings.RequiredFieldIsEmptyMessage");
				}
				return {
					invalidMessage: message
				};
			},

			/**
			 * ############ ########## ########
			 * @override
			 * @protected
			 */
			save: function() {
				if (this.validate()) {
					this.callParent(arguments);
				}
			},

			/**
			 * #####, ########## ## ######### ######### ###########
			 * @private
			 * @return {Boolean}
			 */
			getAccountVisibility: function() {
				return !Ext.isEmpty(this.get("AccountA"));
			},

			/**
			 * ######### ###### ########## ######
			 * @private
			 */
			getAddMode: function() {
				var mode = this.sandbox.publish("GetAddMode", null, [this.sandbox.id]);
				if (mode) {
					this.set("Mode", mode);
				}
			},

			/**
			 * ######### ###### ########## ######
			 * @private
			 */
			initIfAIsPrimary: function() {
				var mode = this.get("Mode");
				if (mode) {
					this.set("AIsPrimary", true);
				} else {
					var masterRecordId = this.get("MasterRecordId");
					if (this.getAccountVisibility()) {
						if (this.get("AccountA").value === masterRecordId) {
							this.set("AIsPrimary", true);
						} else {
							this.set("AIsPrimary", false);
						}
					} else {
						if (this.get("ContactA").value === masterRecordId) {
							this.set("AIsPrimary", true);
						} else {
							this.set("AIsPrimary", false);
						}
					}
				}
			},

			/**
			 * #####, ########## ## ######### ######### ###########
			 * @private
			 * @return {Boolean}
			 */
			getMainAccountPrimaryVisibility: function() {
				return !Ext.isEmpty(this.get("AccountA")) && this.getIfAIsPrimary();
			},

			/**
			 * #####, ########## ## ######### ######### ########
			 * @private
			 * @return {Boolean}
			 */
			getMainContactPrimaryVisibility: function() {
				return !Ext.isEmpty(this.get("ContactA")) && this.getIfAIsPrimary();
			},

			/**
			 * #####, ########## ## ######### ########## ########
			 * @private
			 * @return {Boolean}
			 */
			getRelatedContactPrimaryVisibility: function() {
				return (this.get("Mode") === "AddContact" ||
					this.get("RelationTypeFilter") === "Contact") && this.getIfAIsPrimary();
			},

			/**
			 * #####, ########## ## ######### ########## ###########
			 * @private
			 * @return {Boolean}
			 */
			getRelatedAccountPrimaryVisibility: function() {
				return (this.get("Mode") === "AddAccount" ||
					this.get("RelationTypeFilter") === "Account") && this.getIfAIsPrimary();
			},

			/**
			 * #####, ########## ## ######### ######### ###########
			 * @private
			 * @return {Boolean}
			 */
			getMainAccountSecondaryVisibility: function() {
				return !Ext.isEmpty(this.get("AccountB")) && !this.getIfAIsPrimary();
			},

			/**
			 * #####, ########## ## ######### ######### ########
			 * @private
			 * @return {Boolean}
			 */
			getMainContactSecondaryVisibility: function() {
				return !Ext.isEmpty(this.get("ContactB")) && !this.getIfAIsPrimary();
			},

			/**
			 * #####, ########## ## ######### ########## ########
			 * @private
			 * @return {Boolean}
			 */
			getRelatedContactSecondaryVisibility: function() {
				return (this.get("Mode") === "AddContact" || this.get("ContactA")) && this.getIfBIsPrimary();
			},

			/**
			 * Returns secondary related account container visibility.
			 * @private
			 * @return {Boolean}
			 */
			getRelatedAccountSecondaryVisibility: function() {
				var accountA = this.get("AccountA");
				var accountB = this.get("AccountB");
				return Boolean((this.get("Mode") === "AddAccount" || accountA || accountB)
						&& this.getIfBIsPrimary());
			},

			/**
			 * ######### ###### ########## ######
			 * @private
			 * @return {Boolean}
			 */
			getIfAIsPrimary: function() {
				return this.get("AIsPrimary");
			},

			/**
			 * ######### ###### ########## ######
			 * @private
			 * @return {Boolean}
			 */
			getIfBIsPrimary: function() {
				return !this.get("AIsPrimary");
			},

			/**
			 * ######### Id ###### ######### #######
			 * @private
			 */
			getMasterRecordId: function() {
				var recordId = this.sandbox.publish("GetMasterRecordId", null, [this.sandbox.id]);
				if (recordId) {
					this.set("MasterRecordId", recordId);
				}
			},

			/**
			 * ######### ######### ########
			 * @return {*}
			 */
			getHeader: function() {
				return this.get("Resources.Strings.PageCaption");
			},

			/**
			 * ######### ######## ####### #### ########### ########
			 * @private
			 */
			getRelType: function(reverse) {
				var relType = this.get("RelationTypeFilter");
				var result = "For";
				if (!reverse) {
					if (!Ext.isEmpty(relType)) {
						if (this.get("AccountA")) {
							result = result + "Account" + relType;
						}
						if (this.get("ContactA")) {
							result = result + "Contact" + relType;
						}
					}
				} else {
					if (!Ext.isEmpty(relType)) {
						if (this.get("AccountA")) {
							result = result + relType + "Account";
						}
						if (this.get("ContactA")) {
							result = result + relType + "Contact";
						}
					}
				}
				return result;
			},

			/**
			 * ##### ######### ######## # ########### ####### "RelationTypeFilter"
			 * @private
			 */
			setRelationTypeFilterByColumn: function() {
				var relType = this.get("RelationTypeFilter");
				if (Ext.isEmpty(relType)) {
					if (this.get("AccountB") || this.get("Mode") === "AddAccount") {
						this.set("RelationTypeFilter", "Account");
					}
					if (this.get("ContactB") || this.get("Mode") === "AddContact") {
						this.set("RelationTypeFilter", "Contact");
					}
				}
			},

			/**
			 * Method gets and sets feedback objects.
			 * @param {String} relationTypeId Relation id.
			 * @param {String} columnName Name of column in wich will be set feedback.
			 * @param {Object} scope Context in which the method is performed.
			 * @private
			 */
			setRelationType: function(relationTypeId, columnName, scope) {
				var selectRelationType = Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "RelationType"
				});
				selectRelationType.addColumn("Id");
				selectRelationType.addColumn("Name");
				selectRelationType.addColumn("ReverseRelationType.Id");
				selectRelationType.addColumn("ReverseRelationType.Name");
				selectRelationType.getEntity(relationTypeId, function(result) {
					var entity = result.entity;
					if (entity) {
						var t = {
							displayValue: entity.get("ReverseRelationType.Name"),
							value: entity.get("ReverseRelationType.Id")
						};
						var currentValue = scope.get(columnName);
						if (Ext.isEmpty(currentValue) || currentValue.displayValue !== t.displayValue) {
							scope.set(columnName, t);
						}
					}
				}, scope);
			},

			/**
			 * ##### ######### ######## # ####### "### ###########"
			 * @private
			 */
			setRelationTypeByReverseRelationType: function() {
				var reverseRelationType = this.get("ReverseRelationType");
				if (reverseRelationType) {
					this.setRelationType(reverseRelationType.value, "RelationType", this);
				} else {
					this.set("RelationType", null);
				}
			},

			/**
			 * ##### ######### ######## # ####### "######## ### ###########"
			 * @private
			 */
			setReverseRelationTypeByRelationType: function() {
				var relationType = this.get("RelationType");
				if (relationType) {
					this.setRelationType(relationType.value, "ReverseRelationType", this);
				} else {
					this.set("ReverseRelationType", null);
				}
			},

			/**
			 * Getting filter by interconnection type.
			 * @param {String} relationModeName Relationship mode Account-Account, Account-Contact and other.
			 * @param {String} columnName Column name.
			 * @return {Object} Main filter group.
			 * @private
			 */
			getFilterByRelationTypeFilterName: function(relationModeName, columnName) {
				var mainFilterGroup = this.Ext.create("Terrasoft.FilterGroup");
				var ext = this.Ext;
				if (!ext.isEmpty(relationModeName)) {
					var leftExpression = relationModeName;
					mainFilterGroup.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL,
						leftExpression,
						true));
				}
				if (this.isAddMode() && relationModeName === "ForAccountAccount") {
					var accountA = this.get("AccountA");
					var accountB = this.get("AccountB");
					var parentAccountA = ext.isEmpty(accountA) ? null : accountA.Parent;
					var parentAccountB = ext.isEmpty(accountB) ? null : accountB.Parent;
					var parentAccountRelationType = this.get("ParentAccountRelationType");
					var childAccountRelationType = this.get("ChildAccountRelationType");
					if (!ext.isEmpty(parentAccountRelationType) && !ext.isEmpty(childAccountRelationType)) {
						var excludedIds = [];
						if (!ext.isEmpty(parentAccountA) && columnName !== "ReverseRelationType") {
							excludedIds = [childAccountRelationType.value];
						} else {
							if (!ext.isEmpty(parentAccountB)) {
								if (columnName === "ReverseRelationType") {
									excludedIds = [childAccountRelationType.value];
								} else {
									excludedIds = [parentAccountRelationType.value];
								}
							}
						}
						var excludedFilters = this.Terrasoft.createColumnInFilterWithParameters(
							"Id",
							excludedIds);
						excludedFilters.comparisonType = this.Terrasoft.ComparisonType.NOT_EQUAL;
						mainFilterGroup.addItem(excludedFilters);
					}
				}
				return mainFilterGroup;
			},

			/**
			 * Gets filter by relationship column.
			 * @param {Object} columnValue Column value.
			 * @param {String} columnName Column name.
			 * @return {Object} Main filter group.
			 * @private
			 */
			getFilterByRelationColumn: function(columnValue, columnName) {
				var ext = this.Ext;
				var mainFilterGroup = ext.create("Terrasoft.FilterGroup");
				if (columnValue) {
					mainFilterGroup.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.NOT_EQUAL,
						"Id",
						columnValue.value));
					if (this.isAddMode() && columnName === "Account") {
						var account = this.get("AccountA");
						var parent = ext.isEmpty(account) ? null : account.Parent;
						var relationType = this.get("RelationType");
						var parentAccountRelationType = this.get("ParentAccountRelationType");
						var childAccountRelationType = this.get("ChildAccountRelationType");
						var isParentAccountRelationType = !ext.isEmpty(relationType) &&
							!ext.isEmpty(parentAccountRelationType) &&
							relationType.value === parentAccountRelationType.value;
						var isChildAccountRelationType = !ext.isEmpty(relationType) &&
							!ext.isEmpty(childAccountRelationType) &&
							relationType.value === childAccountRelationType.value;
						if (isParentAccountRelationType) {
							mainFilterGroup.addItem(this.Terrasoft.createColumnIsNullFilter("Parent"));
						} else {
							if (isChildAccountRelationType && !ext.isEmpty(parent)) {
								mainFilterGroup.addItem(this.Terrasoft.createColumnIsNotNullFilter("Parent"));
							}
						}
					}
				}
				return mainFilterGroup;
			}
		},
		diff: /**SCHEMA_DIFF*/ [{
				"operation": "merge",
				"propertyName": "items",
				"name": "Tabs",
				"values": {
					"visible": false
				}
			}, {
				"operation": "merge",
				"propertyName": "items",
				"name": "actions",
				"values": {
					"visible": false
				}
			},

			////////////////////////////////////////////////////////////////
			/////////////////////STRAIGHT RELATION ROW//////////////////////
			////////////////////////////START///////////////////////////////
			{
				"operation": "insert",
				"parentName": "Header",
				"name": "AContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					}
				}
			}, {
				"operation": "insert",
				"parentName": "Header",
				"name": "RelatedObjectsAContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12
					}
				}
			}, {
				"operation": "insert",
				"parentName": "Header",
				"name": "StraightRelationTypeContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					}
				}
			},
			//ContactA/AccountA- ########, ContactB/AccountB- ########(PRIMARY)
			{
				"operation": "insert",
				"parentName": "AContainer",
				"propertyName": "items",
				"name": "MainAccountPrimary",
				"values": {
					"bindTo": "AccountA",
					"caption": {
						"bindTo": "Resources.Strings.PrimaryAccountCaption"
					},
					"visible": {
						"bindTo": "getMainAccountPrimaryVisibility"
					},
					"enabled": false
				}
			}, {
				"operation": "insert",
				"parentName": "AContainer",
				"propertyName": "items",
				"name": "MainContactPrimary",
				"values": {
					"bindTo": "ContactA",
					"caption": {
						"bindTo": "Resources.Strings.PrimaryContactCaption"
					},
					"visible": {
						"bindTo": "getMainContactPrimaryVisibility"
					},
					"enabled": false
				}
			}, {
				"operation": "insert",
				"parentName": "StraightRelationTypeContainer",
				"propertyName": "items",
				"name": "RelationTypePrimary",
				"values": {
					"bindTo": "RelationType",
					"caption": {
						"bindTo": "Resources.Strings.RelationTypeCaption"
					},
					"visible": {
						"bindTo": "getIfAIsPrimary"
					},
					"contentType": "Terrasoft.ContentType.ENUM",
					"isRequired": true
				}
			}, {
				"operation": "insert",
				"parentName": "RelatedObjectsAContainer",
				"propertyName": "items",
				"name": "RelatedAccountPrimary",
				"values": {
					"bindTo": "AccountB",
					"caption": {
						"bindTo": "Resources.Strings.RelatedAccountCaption"
					},
					"visible": {
						"bindTo": "getRelatedAccountPrimaryVisibility"
					},
					"isRequired": {
						"bindTo": "getRelatedAccountPrimaryVisibility"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "RelatedObjectsAContainer",
				"propertyName": "items",
				"name": "RelatedContactPrimary",
				"values": {
					"bindTo": "ContactB",
					"caption": {
						"bindTo": "Resources.Strings.RelatedContactCaption"
					},
					"visible": {
						"bindTo": "getRelatedContactPrimaryVisibility"
					},
					"isRequired": {
						"bindTo": "getRelatedContactPrimaryVisibility"
					}
				}
			},
			//ContactB/AccountB- ########,ContactA/AccountA- ######## (SECONDARY)
			{
				"operation": "insert",
				"parentName": "AContainer",
				"propertyName": "items",
				"name": "MainAccountSecondary",
				"values": {
					"bindTo": "AccountB",
					"caption": {
						"bindTo": "Resources.Strings.PrimaryAccountCaption"
					},
					"visible": {
						"bindTo": "getMainAccountSecondaryVisibility"
					},
					"enabled": false
				}
			}, {
				"operation": "insert",
				"parentName": "AContainer",
				"propertyName": "items",
				"name": "MainContactSecondary",
				"values": {
					"bindTo": "ContactB",
					"caption": {
						"bindTo": "Resources.Strings.PrimaryContactCaption"
					},
					"visible": {
						"bindTo": "getMainContactSecondaryVisibility"
					},
					"enabled": false
				}
			}, {
				"operation": "insert",
				"parentName": "StraightRelationTypeContainer",
				"propertyName": "items",
				"name": "RelationTypeSecondary",
				"values": {
					"bindTo": "ReverseRelationType",
					"caption": {
						"bindTo": "Resources.Strings.RelationTypeCaption"
					},
					"layout": {
						"column": 8,
						"row": 0,
						"colSpan": 8
					},
					"visible": {
						"bindTo": "getIfBIsPrimary"
					},
					"contentType": "Terrasoft.ContentType.ENUM",
					"isRequired": true
				}
			}, {
				"operation": "insert",
				"parentName": "RelatedObjectsAContainer",
				"propertyName": "items",
				"name": "RelatedAccountSecondary",
				"values": {
					"bindTo": "AccountA",
					"caption": {
						"bindTo": "Resources.Strings.RelatedAccountCaption"
					},
					"visible": {
						"bindTo": "getRelatedAccountSecondaryVisibility"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "RelatedObjectsAContainer",
				"propertyName": "items",
				"name": "RelatedContactSecondary",
				"values": {
					"bindTo": "ContactA",
					"caption": {
						"bindTo": "Resources.Strings.RelatedContactCaption"
					},
					"visible": {
						"bindTo": "getRelatedContactSecondaryVisibility"
					}
				}
			},
			////////////////////////////////////////////////////////////////
			/////////////////////STRAIGHT RELATION ROW//////////////////////
			///////////////////////////FINISH///////////////////////////////

			///////////////////////////////////////////////////////////////
			/////////////////////REVERSE RELATION ROW//////////////////////
			////////////////////////////START//////////////////////////////
			{
				"operation": "insert",
				"parentName": "Header",
				"name": "BContainer",
				"propertyName": "items",
				"values": {
					itemType: Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					}
				}
			}, {
				"operation": "insert",
				"parentName": "Header",
				"name": "ReverseRelationTypeContainer",
				"propertyName": "items",
				"values": {
					itemType: Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12
					}
				}
			}, {
				"operation": "insert",
				"parentName": "Header",
				"name": "RelatedObjectsBContainer",
				"propertyName": "items",
				"values": {
					itemType: Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 12,
						"row": 2,
						"colSpan": 12
					}
				}
			},
			//ContactA/AccountA- ########, ContactB/AccountB- ########(PRIMARY)
			{
				"operation": "insert",
				"parentName": "BContainer",
				"propertyName": "items",
				"name": "ReverseAccountPrimary",
				"values": {
					"bindTo": "AccountB",
					"caption": {
						"bindTo": "Resources.Strings.PrimaryAccountCaption"
					},
					"visible": {
						"bindTo": "getRelatedAccountPrimaryVisibility"
					},
					"isRequired": {
						"bindTo": "getRelatedAccountPrimaryVisibility"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "BContainer",
				"propertyName": "items",
				"name": "ReverseContactPrimary",
				"values": {
					"bindTo": "ContactB",
					"caption": {
						"bindTo": "Resources.Strings.PrimaryContactCaption"
					},
					"visible": {
						"bindTo": "getRelatedContactPrimaryVisibility"
					},
					"isRequired": {
						"bindTo": "getRelatedContactPrimaryVisibility"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "ReverseRelationTypeContainer",
				"propertyName": "items",
				"name": "ReverseRelationTypePrimary",
				"values": {
					"bindTo": "ReverseRelationType",
					"caption": {
						"bindTo": "Resources.Strings.RelationTypeCaption"
					},
					"visible": {
						"bindTo": "getIfAIsPrimary"
					},
					"contentType": "Terrasoft.ContentType.ENUM",
					"isRequired": true
				}
			}, {
				"operation": "insert",
				"parentName": "RelatedObjectsBContainer",
				"propertyName": "items",
				"name": "ReverseRelatedAccountPrimary",
				"values": {
					"bindTo": "AccountA",
					"caption": {
						"bindTo": "Resources.Strings.RelatedAccountCaption"
					},
					"visible": {
						"bindTo": "getMainAccountPrimaryVisibility"
					},
					"enabled": false
				}
			}, {
				"operation": "insert",
				"parentName": "RelatedObjectsBContainer",
				"propertyName": "items",
				"name": "ReverseRelatedContactPrimary",
				"values": {
					"bindTo": "ContactA",
					"caption": {
						"bindTo": "Resources.Strings.RelatedContactCaption"
					},
					"visible": {
						"bindTo": "getMainContactPrimaryVisibility"
					},
					"enabled": false
				}
			},
			//ContactB/Account- ########, ContactB/AccountB- ########(SECONDARY)
			{
				"operation": "insert",
				"parentName": "BContainer",
				"propertyName": "items",
				"name": "ReverseAccountSecondary",
				"values": {
					"bindTo": "AccountA",
					"caption": {
						"bindTo": "Resources.Strings.PrimaryAccountCaption"
					},
					"visible": {
						"bindTo": "getRelatedAccountSecondaryVisibility"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "BContainer",
				"propertyName": "items",
				"name": "ReverseContactSecondary",
				"values": {
					"bindTo": "ContactA",
					"caption": {
						"bindTo": "Resources.Strings.PrimaryContactCaption"
					},
					"visible": {
						"bindTo": "getRelatedContactSecondaryVisibility"
					}
				}
			}, {
				"operation": "insert",
				"parentName": "ReverseRelationTypeContainer",
				"propertyName": "items",
				"name": "ReverseRelationTypeSecondary",
				"values": {
					"bindTo": "RelationType",
					"caption": {
						"bindTo": "Resources.Strings.RelationTypeCaption"
					},
					"layout": {
						"column": 8,
						"row": 1,
						"colSpan": 8
					},
					"visible": {
						"bindTo": "getIfBIsPrimary"
					},
					"contentType": "Terrasoft.ContentType.ENUM",
					"isRequired": true
				}
			}, {
				"operation": "insert",
				"parentName": "RelatedObjectsBContainer",
				"propertyName": "items",
				"name": "ReverseRelatedAccountSecondary",
				"values": {
					"bindTo": "AccountB",
					"caption": {
						"bindTo": "Resources.Strings.RelatedAccountCaption"
					},
					"visible": {
						"bindTo": "getMainAccountSecondaryVisibility"
					},
					"enabled": false
				}
			}, {
				"operation": "insert",
				"parentName": "RelatedObjectsBContainer",
				"propertyName": "items",
				"name": "ReverseRelatedContactSecondary",
				"values": {
					"bindTo": "ContactB",
					"caption": {
						"bindTo": "Resources.Strings.RelatedContactCaption"
					},
					"visible": {
						"bindTo": "getMainContactSecondaryVisibility"
					},
					"enabled": false
				}
			},
			///////////////////////////////////////////////////////////////
			/////////////////////REVERSE RELATION ROW//////////////////////
			///////////////////////////FINISH///////////////////////////////
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Active",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12
					}
				}
			}, {
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Description",
				"values": {
					"contentType": this.Terrasoft.ContentType.LONG_TEXT,
					"layout": {
						"column": 0,
						"row": 4,
						"colSpan": 24
					}
				}
			}
		] /**SCHEMA_DIFF*/ ,
		rules: {},
		userCode: {}
	};
});
