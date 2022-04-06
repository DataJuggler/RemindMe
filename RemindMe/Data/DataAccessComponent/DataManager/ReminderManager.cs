

#region using statements

using DataAccessComponent.DataManager.Readers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager
{

    #region class ReminderManager
    /// <summary>
    /// This class is used to manage a 'Reminder' object.
    /// </summary>
    public class ReminderManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'ReminderManager' object.
        /// </summary>
        public ReminderManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteReminder()
            /// <summary>
            /// This method deletes a 'Reminder' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteReminder(DeleteReminderStoredProcedure deleteReminderProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteReminderProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllReminders()
            /// <summary>
            /// This method fetches a  'List<Reminder>' object.
            /// This method uses the 'Reminders_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<Reminder>'</returns>
            /// </summary>
            public List<Reminder> FetchAllReminders(FetchAllRemindersStoredProcedure fetchAllRemindersProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<Reminder> reminderCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allRemindersDataSet = this.DataHelper.LoadDataSet(fetchAllRemindersProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allRemindersDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allRemindersDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            reminderCollection = ReminderReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return reminderCollection;
            }
            #endregion

            #region FindReminder()
            /// <summary>
            /// This method finds a  'Reminder' object.
            /// This method uses the 'Reminder_Find' procedure.
            /// </summary>
            /// <returns>A 'Reminder' object.</returns>
            /// </summary>
            public Reminder FindReminder(FindReminderStoredProcedure findReminderProc, DataConnector databaseConnector)
            {
                // Initial Value
                Reminder reminder = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet reminderDataSet = this.DataHelper.LoadDataSet(findReminderProc, databaseConnector);

                    // Verify DataSet Exists
                    if(reminderDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(reminderDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load Reminder
                            reminder = ReminderReader.Load(row);
                        }
                    }
                }

                // return value
                return reminder;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perorm Initialization For This Object
            /// </summary>
            private void Init()
            {
                // Create DataHelper object
                this.DataHelper = new DataHelper();
            }
            #endregion

            #region InsertReminder()
            /// <summary>
            /// This method inserts a 'Reminder' object.
            /// This method uses the 'Reminder_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertReminder(InsertReminderStoredProcedure insertReminderProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertReminderProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateReminder()
            /// <summary>
            /// This method updates a 'Reminder'.
            /// This method uses the 'Reminder_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateReminder(UpdateReminderStoredProcedure updateReminderProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateReminderProc, databaseConnector);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region DataHelper
            /// <summary>
            /// This object uses the Microsoft Data
            /// Application Block to execute stored
            /// procedures.
            /// </summary>
            internal DataHelper DataHelper
            {
                get { return dataHelper; }
                set { dataHelper = value; }
            }
            #endregion

            #region DataManager
            /// <summary>
            /// A reference to this objects parent.
            /// </summary>
            internal DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
