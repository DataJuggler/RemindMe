

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteReminderStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'Reminder' object.
    /// </summary>
    public class DeleteReminderStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteReminderStoredProcedure' object.
        /// </summary>
        public DeleteReminderStoredProcedure()
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
                this.ProcedureName = "Reminder_Delete";

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
