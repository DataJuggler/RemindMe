

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindReminderStoredProcedure
    /// <summary>
    /// This class is used to Find a 'Reminder' object.
    /// </summary>
    public class FindReminderStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindReminderStoredProcedure' object.
        /// </summary>
        public FindReminderStoredProcedure()
        {
            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Set Procedure Properties
            /// </summary>
            private void Init()
            {
                // Set Properties For This Proc

                // Set ProcedureName
                this.ProcedureName = "Reminder_Find";

                // Set tableName
                this.TableName = "Reminder";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
