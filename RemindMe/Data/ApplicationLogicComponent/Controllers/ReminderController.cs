

#region using statements

using ApplicationLogicComponent.DataBridge;
using ApplicationLogicComponent.DataOperations;
using ApplicationLogicComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.Controllers
{

    #region class ReminderController
    /// <summary>
    /// This class controls a(n) 'Reminder' object.
    /// </summary>
    public class ReminderController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'ReminderController' object.
        /// </summary>
        public ReminderController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateReminderParameter
            /// <summary>
            /// This method creates the parameter for a 'Reminder' data operation.
            /// </summary>
            /// <param name='reminder'>The 'Reminder' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateReminderParameter(Reminder reminder)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = reminder;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(Reminder tempReminder)
            /// <summary>
            /// Deletes a 'Reminder' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'Reminder_Delete'.
            /// </summary>
            /// <param name='reminder'>The 'Reminder' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(Reminder tempReminder)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteReminder";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempreminder exists before attemptintg to delete
                    if(tempReminder != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteReminderMethod = this.AppController.DataBridge.DataOperations.ReminderMethods.DeleteReminder;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateReminderParameter(tempReminder);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteReminderMethod, parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Test For True
                            if (returnObject.Boolean.Value == NullableBooleanEnum.True)
                            {
                                // Set Deleted To True
                                deleted = true;
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAll(Reminder tempReminder)
            /// <summary>
            /// This method fetches a collection of 'Reminder' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'Reminder_FetchAll'.</summary>
            /// <param name='tempReminder'>A temporary Reminder for passing values.</param>
            /// <returns>A collection of 'Reminder' objects.</returns>
            public List<Reminder> FetchAll(Reminder tempReminder)
            {
                // Initial value
                List<Reminder> reminderList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.ReminderMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateReminderParameter(tempReminder);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<Reminder> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        reminderList = (List<Reminder>) returnObject.ObjectValue;
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return reminderList;
            }
            #endregion

            #region Find(Reminder tempReminder)
            /// <summary>
            /// Finds a 'Reminder' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'Reminder_Find'</param>
            /// </summary>
            /// <param name='tempReminder'>A temporary Reminder for passing values.</param>
            /// <returns>A 'Reminder' object if found else a null 'Reminder'.</returns>
            public Reminder Find(Reminder tempReminder)
            {
                // Initial values
                Reminder reminder = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempReminder != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.ReminderMethods.FindReminder;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateReminderParameter(tempReminder);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as Reminder != null))
                        {
                            // Get ReturnObject
                            reminder = (Reminder) returnObject.ObjectValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return reminder;
            }
            #endregion

            #region Insert(Reminder reminder)
            /// <summary>
            /// Insert a 'Reminder' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'Reminder_Insert'.</param>
            /// </summary>
            /// <param name='reminder'>The 'Reminder' object to insert.</param>
            /// <returns>The id (int) of the new  'Reminder' object that was inserted.</returns>
            public int Insert(Reminder reminder)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If Reminderexists
                    if(reminder != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.ReminderMethods.InsertReminder;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateReminderParameter(reminder);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, insertMethod , parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Set return value
                            newIdentity = returnObject.IntegerValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region Save(ref Reminder reminder)
            /// <summary>
            /// Saves a 'Reminder' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='reminder'>The 'Reminder' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref Reminder reminder)
            {
                // Initial value
                bool saved = false;

                // If the reminder exists.
                if(reminder != null)
                {
                    // Is this a new Reminder
                    if(reminder.IsNew)
                    {
                        // Insert new Reminder
                        int newIdentity = this.Insert(reminder);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            reminder.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update Reminder
                        saved = this.Update(reminder);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(Reminder reminder)
            /// <summary>
            /// This method Updates a 'Reminder' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'Reminder_Update'.</param>
            /// </summary>
            /// <param name='reminder'>The 'Reminder' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(Reminder reminder)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(reminder != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.ReminderMethods.UpdateReminder;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateReminderParameter(reminder);
                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, updateMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.Boolean != null) && (returnObject.Boolean.Value == NullableBooleanEnum.True))
                        {
                            // Set saved to true
                            saved = true;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
