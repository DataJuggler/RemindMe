

#region using statements

using ApplicationLogicComponent.DataBridge;
using DataAccessComponent.DataManager;
using DataAccessComponent.DataManager.Writers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.DataOperations
{

    #region class ReminderMethods
    /// <summary>
    /// This class contains methods for modifying a 'Reminder' object.
    /// </summary>
    public class ReminderMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'ReminderMethods' object.
        /// </summary>
        public ReminderMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteReminder(Reminder)
            /// <summary>
            /// This method deletes a 'Reminder' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Reminder' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteReminder(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteReminderStoredProcedure deleteReminderProc = null;

                    // verify the first parameters is a(n) 'Reminder'.
                    if (parameters[0].ObjectValue as Reminder != null)
                    {
                        // Create Reminder
                        Reminder reminder = (Reminder) parameters[0].ObjectValue;

                        // verify reminder exists
                        if(reminder != null)
                        {
                            // Now create deleteReminderProc from ReminderWriter
                            // The DataWriter converts the 'Reminder'
                            // to the SqlParameter[] array needed to delete a 'Reminder'.
                            deleteReminderProc = ReminderWriter.CreateDeleteReminderStoredProcedure(reminder);
                        }
                    }

                    // Verify deleteReminderProc exists
                    if(deleteReminderProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.ReminderManager.DeleteReminder(deleteReminderProc, dataConnector);

                        // Create returnObject.Boolean
                        returnObject.Boolean = new NullableBoolean();

                        // If delete was successful
                        if(deleted)
                        {
                            // Set returnObject.Boolean.Value to true
                            returnObject.Boolean.Value = NullableBooleanEnum.True;
                        }
                        else
                        {
                            // Set returnObject.Boolean.Value to false
                            returnObject.Boolean.Value = NullableBooleanEnum.False;
                        }
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'Reminder' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Reminder' to delete.
            /// <returns>A PolymorphicObject object with all  'Reminders' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<Reminder> reminderListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllRemindersStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get ReminderParameter
                    // Declare Parameter
                    Reminder paramReminder = null;

                    // verify the first parameters is a(n) 'Reminder'.
                    if (parameters[0].ObjectValue as Reminder != null)
                    {
                        // Get ReminderParameter
                        paramReminder = (Reminder) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllRemindersProc from ReminderWriter
                    fetchAllProc = ReminderWriter.CreateFetchAllRemindersStoredProcedure(paramReminder);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    reminderListCollection = this.DataManager.ReminderManager.FetchAllReminders(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(reminderListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = reminderListCollection;
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FindReminder(Reminder)
            /// <summary>
            /// This method finds a 'Reminder' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Reminder' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindReminder(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Reminder reminder = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindReminderStoredProcedure findReminderProc = null;

                    // verify the first parameters is a 'Reminder'.
                    if (parameters[0].ObjectValue as Reminder != null)
                    {
                        // Get ReminderParameter
                        Reminder paramReminder = (Reminder) parameters[0].ObjectValue;

                        // verify paramReminder exists
                        if(paramReminder != null)
                        {
                            // Now create findReminderProc from ReminderWriter
                            // The DataWriter converts the 'Reminder'
                            // to the SqlParameter[] array needed to find a 'Reminder'.
                            findReminderProc = ReminderWriter.CreateFindReminderStoredProcedure(paramReminder);
                        }

                        // Verify findReminderProc exists
                        if(findReminderProc != null)
                        {
                            // Execute Find Stored Procedure
                            reminder = this.DataManager.ReminderManager.FindReminder(findReminderProc, dataConnector);

                            // if dataObject exists
                            if(reminder != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = reminder;
                            }
                        }
                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region InsertReminder (Reminder)
            /// <summary>
            /// This method inserts a 'Reminder' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Reminder' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertReminder(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Reminder reminder = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertReminderStoredProcedure insertReminderProc = null;

                    // verify the first parameters is a(n) 'Reminder'.
                    if (parameters[0].ObjectValue as Reminder != null)
                    {
                        // Create Reminder Parameter
                        reminder = (Reminder) parameters[0].ObjectValue;

                        // verify reminder exists
                        if(reminder != null)
                        {
                            // Now create insertReminderProc from ReminderWriter
                            // The DataWriter converts the 'Reminder'
                            // to the SqlParameter[] array needed to insert a 'Reminder'.
                            insertReminderProc = ReminderWriter.CreateInsertReminderStoredProcedure(reminder);
                        }

                        // Verify insertReminderProc exists
                        if(insertReminderProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.ReminderManager.InsertReminder(insertReminderProc, dataConnector);
                        }

                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region UpdateReminder (Reminder)
            /// <summary>
            /// This method updates a 'Reminder' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'Reminder' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateReminder(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                Reminder reminder = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateReminderStoredProcedure updateReminderProc = null;

                    // verify the first parameters is a(n) 'Reminder'.
                    if (parameters[0].ObjectValue as Reminder != null)
                    {
                        // Create Reminder Parameter
                        reminder = (Reminder) parameters[0].ObjectValue;

                        // verify reminder exists
                        if(reminder != null)
                        {
                            // Now create updateReminderProc from ReminderWriter
                            // The DataWriter converts the 'Reminder'
                            // to the SqlParameter[] array needed to update a 'Reminder'.
                            updateReminderProc = ReminderWriter.CreateUpdateReminderStoredProcedure(reminder);
                        }

                        // Verify updateReminderProc exists
                        if(updateReminderProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.ReminderManager.UpdateReminder(updateReminderProc, dataConnector);

                            // Create returnObject.Boolean
                            returnObject.Boolean = new NullableBoolean();

                            // If save was successful
                            if(saved)
                            {
                                // Set returnObject.Boolean.Value to true
                                returnObject.Boolean.Value = NullableBooleanEnum.True;
                            }
                            else
                            {
                                // Set returnObject.Boolean.Value to false
                                returnObject.Boolean.Value = NullableBooleanEnum.False;
                            }
                        }
                        else
                        {
                            // Raise Error Data Connection Not Available
                            throw new Exception("The database connection is not available.");
                        }
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager 
            public DataManager DataManager 
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
