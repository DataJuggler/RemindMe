

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateReminderStoredProcedure
    /// <summary>
    /// This class is used to Update a 'Reminder' object.
    /// </summary>
    public class UpdateReminderStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateReminderStoredProcedure' object.
        /// </summary>
        public UpdateReminderStoredProcedure()
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
                this.ProcedureName = "Reminder_Update";

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
