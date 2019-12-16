namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Newtonsoft.Json;
	using Terrasoft.Core;
	using Terrasoft.Common;
	using Terrasoft.Messaging.Common;

	#region Class: WebSocketNotificationHandler

	public class WebSocketNotificationHandler : BaseNotificationInfoHandler, INotificationHandler
	{
		#region Constants: Private

		private const string SENDER = "NotificationInfo";

		#endregion

		#region Fields: Private

		private readonly MsgChannelManager _channelManager;

		#endregion

		#region Construstors: Public

		public WebSocketNotificationHandler(UserConnection userConnection)
			: this(userConnection, null) {
		}

		public WebSocketNotificationHandler(UserConnection userConnection,
			IDictionary<string, object> parameters)
			: base(userConnection, parameters) {
			_channelManager = MsgChannelManager.Instance;
		}

		#endregion

		#region Properties: Private

		private string _bodyTypeName;

		protected string BodyTypeName {
			get {
				if (_bodyTypeName == null) {
					object bodyTypeName = string.Empty;
					if (_parameters != null) {
						_parameters.TryGetValue("typeParameter", out bodyTypeName);
					}

					_bodyTypeName = (string) bodyTypeName;
				}

				return _bodyTypeName;
			}
		}

		#endregion

		#region Methods: Private

		private IMsgChannel GetSysAdminUnitChannel(Guid sysAdminUnit) {
			return _channelManager.FindItemByUId(sysAdminUnit);
		}

		private DateTime RoundDateToSeconds(DateTime dateSource) {
			return dateSource.AddTicks(TimeSpan.TicksPerSecond - (dateSource.Ticks % TimeSpan.TicksPerSecond));
		}

		private DateTime GetLastRemindTime() {
			return RoundDateToSeconds(_userConnection.CurrentUser.GetCurrentDateTime());
		}

		private NotificationInfoResponse GetNotificationInfoResponse(IEnumerable<INotificationInfo> notifications) {
			var counters = notifications.Where(n => n.GroupName.IsNotEmpty())
				.GroupBy(n => n.GroupName)
				.Select(group => new {
					group.Key,
					Count = group.Count()
				}).ToDictionary(x => x.Key, x => x.Count);
			
			var notificationInfoResponse = new NotificationInfoResponse {
				Counters = counters,
				Notifications = notifications
			};
			if (_userConnection.GetIsFeatureEnabled("UseDateForNotificationsQuery")) {
				notificationInfoResponse.LastRemindTime = GetLastRemindTime();
			}
			return notificationInfoResponse;
		}

		private IMsg GetChannelMessage(Guid sysAdminUnit, NotificationInfoResponse messageBody) {
			var message = new SimpleMessage {
				Id = sysAdminUnit,
				Body = messageBody,
				Header = {
					Sender = SENDER,
					BodyTypeName = BodyTypeName
				}
			};
			return message;
		}

		private void SendMessage(Guid sysAdminUnitId, NotificationInfoResponse messageBody) {
			IMsgChannel channel = GetSysAdminUnitChannel(sysAdminUnitId);
			if (channel == null) {
				return;
			}
			IMsg message = GetChannelMessage(sysAdminUnitId, messageBody);
			channel.PostMessage(message);
		}

		#endregion

		#region Methods: Protected

		protected override void HandleInfo() {
			lock (_locker) {
				Handle(_notificationInfo);
			}
		}

		#endregion

		#region Methods: Public

		public void Handle(IEnumerable<INotificationInfo> notifications) {
			notifications.CheckArgumentNullOrEmpty("notifications");
			var notificationGroups = notifications.GroupBy(g => g.SysAdminUnit);
			foreach (var notificationGroup in notificationGroups) {
				var messageBody = GetNotificationInfoResponse(notificationGroup.ToList());
				SendMessage(notificationGroup.Key, messageBody);
			}
		}

		#endregion
	}

	#endregion

	#region Class: NotificationInfoResponse

	[JsonObject(MemberSerialization.OptIn)]
	public class NotificationInfoResponse
	{
		[JsonProperty("Counters")]
		public IDictionary<string, int> Counters { get; set; }

		[JsonProperty("Notifications")]
		public IEnumerable<INotificationInfo> Notifications { get; set; }

		[JsonProperty("LastRemindTime")]
		public DateTime LastRemindTime { get; set; }

	}

	#endregion
}
