namespace Terrasoft.Configuration
{
    using System;
    using Terrasoft.Core.DB;

    #region Class: ConditionalTransitionFlowElement

    /// <summary>
    /// Conditional transition process element.
    /// </summary>
    public class ConditionalTransitionFlowElement : CampaignTransitionProcessElement
    {

        #region Constants: Private

        private const string ContactTableName = "Contact";

        #endregion

        #region Properties: Protected

        private FolderHelper _folderHelper;

        /// <summary>
        /// An instance of the <see cref="FolderHelper"/>.
        /// </summary>
        protected FolderHelper FolderHelper {
            get => _folderHelper ?? (_folderHelper = new FolderHelper());
            set => _folderHelper = value;
        }

        #endregion

        #region Properties: Public

        /// <summary>
        /// Defines if transition execution is delayed.
        /// </summary>
        public bool IsDelayedStart { get; set; }

        /// <summary>
        /// Delay in days before the conditional flow execution.
        /// </summary>
        public int DelayInDays { get; set; }

        /// <summary>
        /// Delay unit for part of query with time condition.
        /// </summary>
        public ConditionalSequenceFlowDelayUnit DelayUnit { get; set; }

        /// <summary>
        /// Unique identifier of the record in ContactFolder table.
        /// </summary>
        public Guid FilterId { get; set; }

        #endregion

        #region Methods: Private

        private int GetDelayInHours() {
            return DelayUnit == ConditionalSequenceFlowDelayUnit.Days ? DelayInDays * 24 : DelayInDays;
        }

        private void ExtendWithTimeCondition() {
            if (!IsDelayedStart || DelayInDays == 0) {
                return;
            }
            if (ScheduledDate != null) {
                var jobScheduledOn = (DateTime)ScheduledDate;
                var delayedHours = GetDelayInHours();
                DateTime dateWithoutDelay = jobScheduledOn.AddHours(-delayedHours);
                TransitionQuery.And("StepCompletedOn").IsLessOrEqual(Column.Parameter(dateWithoutDelay));
            }
        }

        private void ExtendWithFilterCondition() {
            Select folderSelect = Guid.Empty.Equals(FilterId)
                ? null
                : FolderHelper.GetFolderSelectV2(ContactTableName, "ContactFolder", FilterId, UserConnection);
            if (folderSelect != null) {
                TransitionQuery.And("ContactId").In(folderSelect);
            }
        }

        #endregion

        #region Methods: Protected

        /// <summary>
        /// Returns query that includes additional logic.
        /// </summary>
        /// <returns>Base <see cref="Update"/> extended with time and filter conditions.</returns>
        protected override void CreateQuery() {
            base.CreateQuery();
            ExtendWithTimeCondition();
            ExtendWithFilterCondition();
        }

        #endregion

    }

    #endregion

}

