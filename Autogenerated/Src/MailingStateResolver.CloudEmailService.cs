namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core.Entities;

	#region Class: MailingStateResolver

	/// <summary>
	/// Class for geting states of sending of the bulk email in proper sequence.
	/// </summary>
	public class MailingStateResolver
	{

		#region Fields: Private

		private readonly Dictionary<Type, Type> _allLaunchStates;
		private readonly Entity _bulkEmail;
		private readonly Dictionary<Type, Type> _currentStateSequence;
		private readonly Dictionary<Guid, Type> _initialStates;
		private readonly Dictionary<Type, Type> _scheduledLaunchStates;
		private MailingState _lastState;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MailingStateResolver"/> class.
		/// Also sets sequence of states by bulk email options.
		/// </summary>
		/// <param name="bulkEmail">The bulk email.</param>
		public MailingStateResolver(Entity bulkEmail) {
			_bulkEmail = bulkEmail;
			_initialStates = new Dictionary<Guid, Type> {
				[MailingConsts.BulkEmailStatusPlannedId] = typeof(ValidationMailingState),
				[MailingConsts.BulkEmailStatusActiveId] = typeof(ValidationMailingState),
				[MailingConsts.BulkEmailStatusStoppedId] = typeof(ValidationMailingState),
				[MailingConsts.BulkEmailStatusStartPlanedId] = typeof(PreparingMailingState)
			};
			_allLaunchStates = new Dictionary<Type, Type> {
				[typeof(ValidationMailingState)] = typeof(PreparingMailingState),
				[typeof(PreparingMailingState)] = typeof(SendingMailingState)
			};
			_scheduledLaunchStates = new Dictionary<Type, Type> {
				[typeof(ValidationMailingState)] = typeof(ScheduleMailingState)
			};
			_currentStateSequence = GetStateSequenceByInitialState();
		}

		#endregion

		#region Methods: Private

		private Dictionary<Type, Type> GetStateSequenceByInitialState() {
			var currentStatusId = _bulkEmail.GetTypedColumnValue<Guid>("StatusId");
			var launchOptionId = _bulkEmail.GetTypedColumnValue<Guid>("LaunchOptionId");
			var result = _allLaunchStates;
			if (launchOptionId == MailingConsts.BulkEmailScheduledaunchOptionId &&
				(currentStatusId == MailingConsts.BulkEmailStatusPlannedId ||
				currentStatusId == MailingConsts.BulkEmailStatusStoppedId)) {
				result = _scheduledLaunchStates;
			}
			return result;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Determines whether this instance can resolve next state.
		/// </summary>
		/// <returns>
		///   <c>true</c> if this instance can resolve state; otherwise, <c>false</c>.
		/// </returns>
		public virtual bool CanResolve() {
			return _lastState == null ? _initialStates.ContainsKey(_bulkEmail.GetTypedColumnValue<Guid>("StatusId"))
				: _currentStateSequence.ContainsKey(_lastState.GetType());
			;
		}

		/// <summary>
		/// Resolves next state.
		/// </summary>
		/// <returns>Concrete instance of <see cref="MailingState"/>.</returns>
		/// <exception cref="Exception">Can't resolve more states</exception>
		public virtual MailingState Resolve() {
			if (!CanResolve()) {
				throw new Exception("Can't resolve more states");
			}
			var stateType = _lastState == null ? _initialStates[_bulkEmail.GetTypedColumnValue<Guid>("StatusId")]
				: _currentStateSequence[_lastState.GetType()];
			_lastState = (MailingState)Activator.CreateInstance(stateType);
			return _lastState;
		}

		#endregion

	}

	#endregion

}

