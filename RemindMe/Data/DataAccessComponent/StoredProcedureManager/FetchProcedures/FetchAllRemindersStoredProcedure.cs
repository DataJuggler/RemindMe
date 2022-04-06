

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllRemindersStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'Reminder' objects.
    /// </summary>
    public class FetchAllRemindersStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllRemindersStoredProcedure' object.
        /// </summary>
        public FetchAllRemindersStoredProcedure()
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
                this.ProcedureName = "Reminder_FetchAll";

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
