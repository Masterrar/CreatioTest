namespace Terrasoft.Configuration
{
	/// <summary>
	/// Interface for notification execution.
	/// </summary>
	public interface INotificationInfoExecutor
	{

		/// <summary>
		/// Notification execution.
		/// </summary>
		/// <returns>Returns execution state.</returns>
		bool Execute();
	}
}

