{
	"Features": {
		"UseMobileInvoiceCacheManager": {
			"Models": {
				"Invoice": {
					"CacheConfig": {
						"AssociatedModels": [
							"SocialMessage"
						]
					},
					"PagesExtensions": [
						"MobileInvoiceDataCacheManager",
						"MobileInvoiceDataCacheImporter",
						"MobileCacheSyncStateControllerMixin"
					]
				}
			}
		}
	},
	"CustomSchemas": [
		"MobileInvoiceConstants"
	],
	"SyncOptions": {
		"SysSettingsImportConfig": [
			"InvoicePaymentStatusDef"
		]
	},
	"Modules": {
		"Invoice": {
			"Title": "InvoiceSectionTitle"
		}
	},
	"Models": {
		"Invoice": {
			"Grid": "MobileInvoiceGridPage",
			"PagesExtensions": [
				"MobileInvoiceModuleConfig"
			]
		}
	}
}