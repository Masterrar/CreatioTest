using System;
using Terrasoft.Core;
using Terrasoft.Core.Scheduler;
using Terrasoft.Web.Common;

namespace Terrasoft.Configuration
{

	#region Interface: IFailoverHandler

	/// <summary>
	/// Provides methods to monitor and handle fails.
	/// </summary>
	public interface IFailoverHandler : IJobExecutor
	{

		#region Methods: Public

		/// <summary>
		/// Creates job to monitor fails.
		/// <param name="userConnection">The user connection.</param>
		/// </summary>
		void CreateJob(UserConnection userConnection);

		#endregion

	}
	
	#endregion

}

