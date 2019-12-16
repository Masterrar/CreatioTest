namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Configuration.DynamicContent;
	using Terrasoft.Configuration.DynamicContent.Models;
	using Terrasoft.Configuration.Mailing;
	using Terrasoft.Configuration.Marketing.Utilities;
	using Terrasoft.Configuration.Utils;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: PreparingMailingState

	public class PreparingMailingState : MailingState
	{

		#region Constants: Private

		private const int MailingMaxTemplateSize = 5242880;

		private const int MassMailingRecipientsLimit = 20000;

		#endregion

		#region Fields: Private

		private IMailingAudienceDataSource _audienceDataSource;

		private BulkEmailEventLogger _bulkEmailEventLogger;

		#endregion

		#region Properties: Protected

		protected UserConnection UserConnection { get; set; }

		#endregion

		#region Properties: Public

		public ICESApi ServiceApi { get; set; }

		public CESMailingTemplateFactory TemplateFactory { get; set; }

		public BulkEmailValidator Validator { get; set; }

		public BulkEmailMacroParser BulkEmailMacroParser { get; set; }

		public IMailingAudienceDataSourceFactory AudienceDataSourceFactory { get; set; }

		public BulkEmailEventLogger BulkEmailEventLogger { get; set; }

		#endregion

		public DCTemplateRepository<DCTemplateModel> TemplateRepository { get; set; }

		#region Methods: Private

		private SendMessageData CreateSendMessageData(BulkEmail bulkEmail) {
			var startDateUtc = TimeZoneInfo.ConvertTimeToUtc(bulkEmail.StartDate,
				Context.UserConnection.CurrentUser.TimeZone);
			var messageData = new SendMessageData {
				UserConnection = Context.UserConnection,
				BulkEmailStartDate = startDateUtc
			};
			return messageData;
		}

		

		private BulkEmailMacroComposer GetMacroComposer(Guid contactId, Guid bulkEmailId) {
			var bulkEmailMacroComposer = ClassFactory.Get<BulkEmailMacroComposer>(
				new ConstructorArgument("userConnection", UserConnection),
				new ConstructorArgument("contactId", contactId), new ConstructorArgument("bulkEmailId", bulkEmailId));
			bulkEmailMacroComposer.AudienceDataSource = _audienceDataSource;
			bulkEmailMacroComposer.MacrosHelper.UserConnection = UserConnection;
			return bulkEmailMacroComposer;
		}

		private IEnumerable<DCReplicaModel> GetReplicasByMasks(DCTemplateModel template,
			IEnumerable<int> replicaMasks = null) {
			var replicas = template.Replicas;
			if (replicaMasks?.Any() == true) {
				replicas = replicas.Where(x => replicaMasks.Contains(x.Mask));
			}
			return replicas;
		}

		private void InitializeAudienceDataSource(Guid bulkEmailId) {
			_audienceDataSource = AudienceDataSourceFactory.CreateInstance(Context.UserConnection, bulkEmailId,
				MassMailingRecipientsLimit);
		}

		private bool IsRecipientsSelectQueryEmpty(Select select) {
			var execSelect = new Select(UserConnection).Column(Func.Count("RecipientUId")).From(select.Top(1))
				.As("IsRecipientsSelectQueryEmpty");
			var bulkEmailAudienceCount = execSelect.ExecuteScalar<int>();
			return bulkEmailAudienceCount == 0;
		}

		private void PerformWaitBeforeSend() {
			var sendDelayInSeconds =
				(int)Core.Configuration.SysSettings.GetValue(Context.UserConnection, "MandrillMailingDelayInSeconds");
			Thread.Sleep(sendDelayInSeconds * 1000);
		}

		private void PrepareRecipientsMacros(BulkEmail bulkEmail, List<IMailingTemplate> templateReplicas) {
			var macroComposer = GetMacroComposer(bulkEmail.OwnerId, bulkEmail.Id);
			foreach (var replica in templateReplicas) {
				var mailingTemplateReplica = replica as IMailingTemplateReplica;
				if (mailingTemplateReplica != null) {
					macroComposer.TrackedAliases = (mailingTemplateReplica as CESMailingTemplate)?.TrackedAliases;
					macroComposer.PrepareMacros(mailingTemplateReplica.ReplicaId, replica.MacrosCollection);
				}
			}
		}

		private void ResolveRecipientsReplica(Guid bulkEmailId) {
			var dcDataSource = _audienceDataSource as IDCAudienceDataSource;
			_audienceDataSource.PageNumber = 0;
			var dcStrategyResolver = new DCStrategyResolver(UserConnection);
			var templateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection);
			var repositoryOptions = new DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> {
				TemplateReadOptions = DCTemplateReadOption.None
			};
			var template = templateRepository.ReadByRecordId(bulkEmailId, repositoryOptions);
			if (template == null) {
				throw new NullReferenceException($"Template for BulkEmail with id {bulkEmailId} not found");
			}
			while (true) {
				_audienceDataSource.PageNumber++;
				var audienceSelect = dcDataSource.GetRecipientsIdsSelectQuery(Guid.Empty);
				var isAudienceSelectEmpty = IsRecipientsSelectQueryEmpty(audienceSelect);
				if (isAudienceSelectEmpty) {
					break;
				}
				var segmentationContext = new DCSegmentationContext(UserConnection) {
					Template = template,
					SourceAudience = dcDataSource.GetRecipientsIdsSelectQuery(Guid.Empty),
					SourceAlias = "MandrillDeliveryPackage",
					EntityIdSourceColumn = "RecipientUId",
					SourceColumnForFilter = "ContactId",
					TargetTable = "BulkEmailRecipientReplica",
					EntityIdTargetColumn = "RecipientId",
					ReplicaIdTargetColumn = "DCReplicaId",
					RecordIdTargetColumn = "BulkEmailId"
				};
				dcStrategyResolver.SegmentAudience(segmentationContext);
			}
		}

		

		#endregion

		#region Methods: Protected

		

		protected IEnumerable<IMailingTemplate> CreateTemplates(BulkEmail bulkEmail, BulkEmailMacroParser macroParser,
			IEnumerable<DCReplicaModel> replicasToProcess) {
			return TemplateFactory.CreateInstances(UserConnection, bulkEmail, replicasToProcess, macroParser);
		}

		protected IEnumerable<IMailingTemplate> CreateTemplates(BulkEmail bulkEmail, BulkEmailMacroParser macroParser,
			IEnumerable<int> replicaMasksToProcess = null) {
			var templateReadOptions = new DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> {
				TemplateReadOptions = DCTemplateReadOption.None
			};
			var template = TemplateRepository.ReadByRecordId(bulkEmail.Id, templateReadOptions);
			var replicas = GetReplicasByMasks(template, replicaMasksToProcess);
			return CreateTemplates(bulkEmail, macroParser, replicas);
		}

		protected void SaveTemplate(IMailingTemplate template, BulkEmail bulkEmail) {
			if (!Validator.ValidateTemplateSize(template, out var templateSize)) {
				throw new Exception(
					$"Template {template.Name} have size {templateSize} more than {MailingMaxTemplateSize}.");
			}
			var images = template.InlineImages.ToCESImage();
			var checksum = string.Empty;
			string replicaId = null;
			string senderEmail;
			string senderName;
			if (template is IMailingTemplateWithHeaders templateReplica) {
				checksum = templateReplica.Checksum;
				replicaId = templateReplica.ReplicaId.ToString();
				senderEmail = templateReplica.SenderEmail;
				senderName = templateReplica.SenderName;
			} else {
				senderEmail = bulkEmail.SenderEmail;
				senderName = bulkEmail.SenderName;
			}
			Utilities.RetryOnFailure(() => ServiceApi.AddTemplate(template.Name, senderEmail, senderName,
				template.TemplateSubject, template.Content, string.Empty, bulkEmail.Id, images, checksum, replicaId));
		}

		#endregion

		#region Methods: Public

		public override MailingResponse ExecuteState() {
			var bulkEmailEntity = Context.BulkEmailEntity;
			var bulkEmailId = bulkEmailEntity.PrimaryColumnValue;
			SetBulkEmailStatus(bulkEmailId, MailingConsts.BulkEmailStatusWaitingBeforeSendId);
			PerformWaitBeforeSend();
			var currentBulkEmailStatus = BulkEmailQueryHelper.GetBulkEmailStatus(bulkEmailId, Context.UserConnection);
			if (currentBulkEmailStatus == MailingConsts.BulkEmailStatusStoppedId) {
				MailingUtilities.Log.InfoFormat(
					"[CESMaillingProvider.ExecuteSendMessageTask]: Break iterations. " +
					"bulkEmilId {0} has status 'Stopped'.", bulkEmailId);
				return new MailingResponse {
					Success = true
				};
			}
			InitializeAudienceDataSource(bulkEmailId);
			MailingUtilities.Log.InfoFormat(
				"[CESMaillingProvider.CreateSendAction]: Start action for send. " + "bulkEmilId: {0}", bulkEmailId);
			try {
				var bulkEmail = (BulkEmail)bulkEmailEntity;
				ResolveRecipientsReplica(bulkEmailId);
				var templateReplicas = CreateTemplates(bulkEmail, BulkEmailMacroParser).ToList();
				foreach (var template in templateReplicas) {
					SaveTemplate(template, bulkEmail);
				}
				PrepareRecipientsMacros(bulkEmail, templateReplicas);
			} catch (Exception e) {
				SetBulkEmailStatus(bulkEmailId, MailingConsts.BulkEmailStatusErrorId);
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.ExecuteSendMessage]: " + "Error while saving template. BulkEmailId {0}.", e,
					bulkEmailId);
				BulkEmailEventLogger.LogError(bulkEmailId, DateTime.UtcNow, GetLczStringValue("BatchSendEvent"), e,
					GetLczStringValue("TemplateSaveErrorMsg"), Context.UserConnection.CurrentUser.ContactId);
				CreateReminding(Context.BulkEmailEntity, "CESTemplateFailsMsg");
				throw;
			}
			return new MailingResponse {
				Success = true
			};
		}
		
		private BulkEmailMacroParser GetMacroParser() {
			var macrosHelper = ClassFactory.Get<MacrosHelperV2>();
			macrosHelper.UserConnection = UserConnection;
			var bulkEmailMacroParser = ClassFactory.Get<BulkEmailMacroParser>(
				new ConstructorArgument("macrosHelper", macrosHelper));
			return bulkEmailMacroParser;
		}

		public override void Initialize() {
			base.Initialize();
			UserConnection = Context.UserConnection;
			TemplateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection);
			TemplateFactory = new CESMailingTemplateFactory();
			ServiceApi = Context.ServiceApi;
			Validator = new BulkEmailValidator(UserConnection, ServiceApi);
			BulkEmailEventLogger = new BulkEmailEventLogger(UserConnection);
			AudienceDataSourceFactory = new BulkEmailAudienceDataSourceFactory();
			BulkEmailMacroParser = GetMacroParser();
		}

		#endregion

	}

	#endregion

}

