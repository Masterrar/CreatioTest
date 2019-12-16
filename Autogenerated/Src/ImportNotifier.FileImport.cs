namespace Terrasoft.Configuration.FileImport
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Messaging.Common;

	#region Class: ImportNotifier
	[DefaultBinding(typeof(IImportNotifier), Name = nameof(ImportNotifier))]
	public class ImportNotifier : IImportNotifier
	{

		#region Constants: Private

		private const string MessageBodyFormat =
			"{{\"importSessionId\": \"{0}\", \"status\": {{\"stage\": \"{1}\", \"percent\": {2}}}}}";

		/// <summary>
		/// Message header.
		/// </summary>
		private const string MessageHeader = "FileImport";

		/// <summary>
		/// Message header.
		/// </summary>
		private const string TagImportMessageHeader = "TagImport";

		#endregion

		#region Fields: Private

		/// <summary>
		/// One percent value.
		/// </summary>
		private double _onePercentValue;

		/// <summary>
		/// User connection. 
		/// </summary>
		private readonly IMsgChannel _channel;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Creates instance of type <see cref="ImportNotifier"/>.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="importParameters">Import parameters.</param>
		public ImportNotifier(UserConnection userConnection, ImportParameters importParameters) {
			UserConnection = userConnection;
			ImportParameters = importParameters;
			_channel = MsgChannelManager.Instance.FindItemByUId(UserConnection.CurrentUser.Id);
			if (_channel != null) {
				_channel.OnMessage += ImportMsgHandler;
			}
		}
		protected ImportParameters ImportParameters { get; }

		/// <summary>
		/// User connection. 
		/// </summary>
		protected UserConnection UserConnection { get; }
		#endregion

		#region Methods: Private

		/// <summary>
		/// Returns one percent value.
		/// </summary>
		/// <param name="rowsCount">Rows count.</param>
		/// <returns>One percent value.</returns>
		private double GetOnePercentValue(uint rowsCount) {
			if (_onePercentValue > 0) {
				return _onePercentValue;

			}
			_onePercentValue = Math.Ceiling(rowsCount / 100f);
			return _onePercentValue;
		}

		/// <summary>
		/// Returns one percent value.
		/// </summary>
		/// <param name="stage"></param>
		/// <param name="percent"></param>
		/// <returns>One percent value.</returns>
		private void PostMessage(string stage, uint percent) {
			if (_channel == null) {
				return;
			}
			SimpleMessage simpleMessage = new SimpleMessage {
				Body = string.Format(MessageBodyFormat, ImportParameters.ImportSessionId, stage, percent)
			};
			simpleMessage.Header.Sender = MessageHeader;
			_channel.PostMessage(simpleMessage);
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="IImportNotifier"/>
		public void Notify(object sender, ImportEntitySavingEventArgs eventArgs) {
			uint totalRowsCount = eventArgs.TotalRowsCount;
			uint processedRowsCount = eventArgs.ProcessedRowsCount;
			double onePercentValue = GetOnePercentValue(totalRowsCount);
			if (processedRowsCount % onePercentValue > 0) {
				return;
			}
			uint percent = processedRowsCount * 100 / totalRowsCount;
			PostMessage("processing", percent);
		}

		/// <inheritdoc cref="IImportNotifier"/>
		public void NotifyEnd() {
			PostMessage("complete", 100);
		}

		/// <summary>
		/// Import message handler.
		/// </summary>
		/// <param name="sender">Message sender.</param>
		/// <param name="args">Event arguments.</param>
		public void ImportMsgHandler(IMsgChannel sender, IMsg args) {
			if (args == null || args.Header.Sender != TagImportMessageHeader || args.Body == null) {
				return;
			}
			SimpleMessage message = new SimpleMessage {
					Body = args.Body
			};
			message.Header.Sender = TagImportMessageHeader;
			_channel.PostMessage(message);
		}

		#endregion

	}

	#endregion

}

