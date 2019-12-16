namespace Terrasoft.Configuration
{
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using System.Collections.Generic;


	#region Class: CaseTermIntervalSelector

	/// <summary>
	/// A class that selects a strategy and gets corresponding term interval.
	/// </summary>
	[Override]
	public class CaseTermIntervalSelector : ITermIntervalSelector<CaseTermStates>
	{

		#region Properties: Public

		/// <summary>
		/// User connection.
		/// </summary>
		public UserConnection UserConnection {
			get;
			private set;
		}

		#endregion

		#region Constructors: Public

		public CaseTermIntervalSelector() {
		}

		public CaseTermIntervalSelector(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Method that returns time interval for calculation
		/// </summary>
		/// <param name="arguments">Arguments for strategies.</param>
		/// <returns>Time interval.</returns>
		public virtual ITermInterval<CaseTermStates> Get(Dictionary<string, object> arguments) {
			CaseTermInterval result = new CaseTermInterval();
			var strategyQueue = ClassFactory.Get<CaseTermStrategyQueue>(
				new ConstructorArgument("userConnection", UserConnection));
			var strategyManager = ClassFactory.Get<CaseTermStrategyManager>();
			var className = strategyQueue.Dequeue();
			var preferableFlags = CaseTermStates.ContainsResolve | CaseTermStates.ContainsResponse;
			while (className != null && !result.GetMask().HasFlag(preferableFlags)) {
				var strategy = strategyManager.GetItem(className, arguments, UserConnection);
				className = strategyQueue.Dequeue();
				CaseTermStates currentMask = result.GetMask();
				try {
					CaseTermInterval term = strategy.GetTermInterval(currentMask);
					CaseTermStates termMask = term.GetMask();
					if (!currentMask.HasFlag(CaseTermStates.ContainsResolve)
						&& termMask.HasFlag(CaseTermStates.ContainsResolve)) {
						result.ResolveTerm = term.ResolveTerm;
					}
					if (!currentMask.HasFlag(CaseTermStates.ContainsResponse)
						&& termMask.HasFlag(CaseTermStates.ContainsResponse)) {
						result.ResponseTerm = term.ResponseTerm;
					}
				} catch {
					continue;
				}
			}
			return result;
		}

		#endregion

	}

	#endregion

}
