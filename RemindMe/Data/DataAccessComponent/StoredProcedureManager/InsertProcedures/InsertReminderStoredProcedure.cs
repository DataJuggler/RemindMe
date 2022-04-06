

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertReminderStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'Reminder' object.
    /// </summary>
    public class InsertReminderStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertReminderStoredProcedure' object.
        /// </summary>
        public InsertReminderStoredProcedure()
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
                this.ProcedureName = "Reminder_Insert";

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
