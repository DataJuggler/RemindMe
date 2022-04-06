
#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using Microsoft.Data.SqlClient;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;

#endregion

namespace DataAccessComponent.DataManager.Writers
{

    #region class ReminderWriter
    /// <summary>
    /// This class is used for converting a 'Reminder' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class ReminderWriter : ReminderWriterBase
    {

        #region Static Methods

            #region CreateFetchAllRemindersStoredProcedure(Reminder reminder)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllRemindersStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Reminder_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllRemindersStoredProcedure' object.</returns>
            public static new FetchAllRemindersStoredProcedure CreateFetchAllRemindersStoredProcedure(Reminder reminder)
            {
                // Initial value
                FetchAllRemindersStoredProcedure fetchAllRemindersStoredProcedure = new FetchAllRemindersStoredProcedure();

                // if the reminder object exists
                if (reminder != null)
                {
                    // if LoadByReminderDate is true
                    if (reminder.LoadByReminderDate)
                    {
                        // Change the procedure name
                        fetchAllRemindersStoredProcedure.ProcedureName = "Reminder_FetchAllForReminderDate";
                        
                        // Create the @ReminderDate parameter
                        fetchAllRemindersStoredProcedure.Parameters = SqlParameterHelper.CreateSqlParameters("@ReminderDate", reminder.ReminderDate);
                    }
                }
                
                // return value
                return fetchAllRemindersStoredProcedure;
            }
            #endregion
            
        #endregion

    }
    #endregion

}
