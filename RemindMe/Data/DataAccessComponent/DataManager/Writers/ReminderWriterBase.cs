

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

    #region class ReminderWriterBase
    /// <summary>
    /// This class is used for converting a 'Reminder' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class ReminderWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Reminder reminder)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='reminder'>The 'Reminder' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Reminder reminder)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (reminder != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", reminder.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteReminderStoredProcedure(Reminder reminder)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteReminder'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Reminder_Delete'.
            /// </summary>
            /// <param name="reminder">The 'Reminder' to Delete.</param>
            /// <returns>An instance of a 'DeleteReminderStoredProcedure' object.</returns>
            public static DeleteReminderStoredProcedure CreateDeleteReminderStoredProcedure(Reminder reminder)
            {
                // Initial Value
                DeleteReminderStoredProcedure deleteReminderStoredProcedure = new DeleteReminderStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteReminderStoredProcedure.Parameters = CreatePrimaryKeyParameter(reminder);

                // return value
                return deleteReminderStoredProcedure;
            }
            #endregion

            #region CreateFindReminderStoredProcedure(Reminder reminder)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindReminderStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Reminder_Find'.
            /// </summary>
            /// <param name="reminder">The 'Reminder' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindReminderStoredProcedure CreateFindReminderStoredProcedure(Reminder reminder)
            {
                // Initial Value
                FindReminderStoredProcedure findReminderStoredProcedure = null;

                // verify reminder exists
                if(reminder != null)
                {
                    // Instanciate findReminderStoredProcedure
                    findReminderStoredProcedure = new FindReminderStoredProcedure();

                    // Now create parameters for this procedure
                    findReminderStoredProcedure.Parameters = CreatePrimaryKeyParameter(reminder);
                }

                // return value
                return findReminderStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Reminder reminder)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new reminder.
            /// </summary>
            /// <param name="reminder">The 'Reminder' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Reminder reminder)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[5];
                SqlParameter param = null;

                // verify reminderexists
                if(reminder != null)
                {
                    // Create [Name] parameter
                    param = new SqlParameter("@Name", reminder.Name);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [Note] parameter
                    param = new SqlParameter("@Note", reminder.Note);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Recurring] parameter
                    param = new SqlParameter("@Recurring", reminder.Recurring);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [RecurringType] parameter
                    param = new SqlParameter("@RecurringType", reminder.RecurringType);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [ReminderDate] Parameter
                    param = new SqlParameter("@ReminderDate", SqlDbType.DateTime);

                    // If reminder.ReminderDate does not exist.
                    if (reminder.ReminderDate.Year < 1900)
                    {
                        // Set the value to 1/1/1900
                        param.Value = new DateTime(1900, 1, 1);
                    }
                    else
                    {
                        // Set the parameter value
                        param.Value = reminder.ReminderDate;
                    }
                    // set parameters[4]
                    parameters[4] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertReminderStoredProcedure(Reminder reminder)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertReminderStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Reminder_Insert'.
            /// </summary>
            /// <param name="reminder"The 'Reminder' object to insert</param>
            /// <returns>An instance of a 'InsertReminderStoredProcedure' object.</returns>
            public static InsertReminderStoredProcedure CreateInsertReminderStoredProcedure(Reminder reminder)
            {
                // Initial Value
                InsertReminderStoredProcedure insertReminderStoredProcedure = null;

                // verify reminder exists
                if(reminder != null)
                {
                    // Instanciate insertReminderStoredProcedure
                    insertReminderStoredProcedure = new InsertReminderStoredProcedure();

                    // Now create parameters for this procedure
                    insertReminderStoredProcedure.Parameters = CreateInsertParameters(reminder);
                }

                // return value
                return insertReminderStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Reminder reminder)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing reminder.
            /// </summary>
            /// <param name="reminder">The 'Reminder' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Reminder reminder)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[6];
                SqlParameter param = null;

                // verify reminderexists
                if(reminder != null)
                {
                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", reminder.Name);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [Note]
                    param = new SqlParameter("@Note", reminder.Note);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Recurring]
                    param = new SqlParameter("@Recurring", reminder.Recurring);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [RecurringType]
                    param = new SqlParameter("@RecurringType", reminder.RecurringType);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [ReminderDate]
                    // Create [ReminderDate] Parameter
                    param = new SqlParameter("@ReminderDate", SqlDbType.DateTime);

                    // If reminder.ReminderDate does not exist.
                    if (reminder.ReminderDate.Year < 1900)
                    {
                        // Set the value to 1/1/1900
                        param.Value = new DateTime(1900, 1, 1);
                    }
                    else
                    {
                        // Set the parameter value
                        param.Value = reminder.ReminderDate;
                    }

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", reminder.Id);
                    parameters[5] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateReminderStoredProcedure(Reminder reminder)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateReminderStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Reminder_Update'.
            /// </summary>
            /// <param name="reminder"The 'Reminder' object to update</param>
            /// <returns>An instance of a 'UpdateReminderStoredProcedure</returns>
            public static UpdateReminderStoredProcedure CreateUpdateReminderStoredProcedure(Reminder reminder)
            {
                // Initial Value
                UpdateReminderStoredProcedure updateReminderStoredProcedure = null;

                // verify reminder exists
                if(reminder != null)
                {
                    // Instanciate updateReminderStoredProcedure
                    updateReminderStoredProcedure = new UpdateReminderStoredProcedure();

                    // Now create parameters for this procedure
                    updateReminderStoredProcedure.Parameters = CreateUpdateParameters(reminder);
                }

                // return value
                return updateReminderStoredProcedure;
            }
            #endregion

            #region CreateFetchAllRemindersStoredProcedure(Reminder reminder)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllRemindersStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Reminder_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllRemindersStoredProcedure' object.</returns>
            public static FetchAllRemindersStoredProcedure CreateFetchAllRemindersStoredProcedure(Reminder reminder)
            {
                // Initial value
                FetchAllRemindersStoredProcedure fetchAllRemindersStoredProcedure = new FetchAllRemindersStoredProcedure();

                // return value
                return fetchAllRemindersStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
