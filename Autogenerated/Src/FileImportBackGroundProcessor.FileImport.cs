namespace Terrasoft.Configuration.FileImport
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.Process;

	#region  Class: FileImportBackGroundProcessor

	public class FileImportBackGroundProcessor : IJobExecutor
	{

		#region Field: Private

		private readonly Guid fileImportPersistentTask = Guid.Parse("2C488A31-9F43-43E5-AC28-0A3A3EA2489C");

		#endregion

		#region Methods: Private

		private void RestartUncompletedImport(ProcessEngine processEngine, Guid processId, ImportParameters importParameter) {
			Process process = processEngine.FindProcessByUId(processId.ToString(), true);
			if(process == null) {
				return;
			}
			var element = process.FindFlowElementBySchemaElementUId(fileImportPersistentTask);
			if(element != null) {
				((ProcessActivity)element).CompleteExecuting(importParameter);
			}
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="IJobExecutor"/>
		public void Execute(UserConnection userConnection, IDictionary<string, object> parameters) {
			var repository = new ImportParametersRepository(userConnection);
			var processesImportParameters = repository.GetWithProcessIncomplete();
			foreach(var processImportParameter in processesImportParameters) {
				RestartUncompletedImport(userConnection.ProcessEngine,
					processImportParameter.Key,
					processImportParameter.Value
				);
			}
		}

		#endregion

	}

	#endregion

}

