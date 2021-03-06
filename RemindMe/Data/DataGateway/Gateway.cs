
#region using statements

using ApplicationLogicComponent.Controllers;
using ApplicationLogicComponent.DataOperations;
using DataAccessComponent.DataManager;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

#endregion

namespace DataGateway
{

    #region class Gateway
    /// <summary>
    /// This class is used to manage DataOperations
    /// between the client and the DataAccessComponent.
    /// Do not change the method name or the parameters for the
    /// code generated methods or they will be recreated the next 
    /// time you code generate with DataTier.Net. If you need additional
    /// parameters passed to a method either create an override or
    /// add or set properties to the temp object that is passed in.
    /// </summary>
    public class Gateway
    {

        #region Private Variables
        private ApplicationController appController;
        private string connectionName;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a Gateway object.
        /// </summary>
        public Gateway(string connectionName = "")
        {
            // store the ConnectionName
            this.ConnectionName = connectionName;

            // Perform Initializations for this object
            Init();
        }
        #endregion

        #region Methods
        
            #region DeleteReminder(int id, Reminder tempReminder = null)
            /// <summary>
            /// This method is used to delete Reminder objects.
            /// </summary>
            /// <param name="id">Delete the Reminder with this id</param>
            /// <param name="tempReminder">Pass in a tempReminder to perform a custom delete.</param>
            public bool DeleteReminder(int id, Reminder tempReminder = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempReminder does not exist
                    if (tempReminder == null)
                    {
                        // create a temp Reminder
                        tempReminder = new Reminder();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempReminder.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.ReminderController.Delete(tempReminder);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            /// <summary>
            /// This method Executes a Non Query StoredProcedure
            /// </summary>
            public PolymorphicObject ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            {
                // initial value
                PolymorphicObject returnValue = new PolymorphicObject();

                // locals
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // create the parameters
                PolymorphicObject procedureNameParameter = new PolymorphicObject();
                PolymorphicObject sqlParametersParameter = new PolymorphicObject();

                // if the procedureName exists
                if (!String.IsNullOrEmpty(procedureName))
                {
                    // Create an instance of the SystemMethods object
                    SystemMethods systemMethods = new SystemMethods();

                    // setup procedureNameParameter
                    procedureNameParameter.Name = "ProcedureName";
                    procedureNameParameter.Text = procedureName;

                    // setup sqlParametersParameter
                    sqlParametersParameter.Name = "SqlParameters";
                    sqlParametersParameter.ObjectValue = sqlParameters;

                    // Add these parameters to the parameters
                    parameters.Add(procedureNameParameter);
                    parameters.Add(sqlParametersParameter);

                    // get the dataConnector
                    DataAccessComponent.DataManager.DataConnector dataConnector = GetDataConnector();

                    // Execute the query
                    returnValue = systemMethods.ExecuteNonQuery(parameters, dataConnector);
                }

                // return value
                return returnValue;
            }
            #endregion

            #region FindReminder(int id, Reminder tempReminder = null)
            /// <summary>
            /// This method is used to find 'Reminder' objects.
            /// </summary>
            /// <param name="id">Find the Reminder with this id</param>
            /// <param name="tempReminder">Pass in a tempReminder to perform a custom find.</param>
            public Reminder FindReminder(int id, Reminder tempReminder = null)
            {
                // initial value
                Reminder reminder = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempReminder does not exist
                    if (tempReminder == null)
                    {
                        // create a temp Reminder
                        tempReminder = new Reminder();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempReminder.UpdateIdentity(id);
                    }

                    // perform the find
                    reminder = this.AppController.ControllerManager.ReminderController.Find(tempReminder);
                }

                // return value
                return reminder;
            }
            #endregion

            #region GetDataConnector()
            /// <summary>
            /// This method (safely) returns the Data Connector from the
            /// AppController.DataBridget.DataManager.DataConnector
            /// </summary>
            private DataConnector GetDataConnector()
            {
                // initial value
                DataConnector dataConnector = null;

                // if the AppController exists
                if (this.AppController != null)
                {
                    // return the DataConnector from the AppController
                    dataConnector = this.AppController.GetDataConnector();
                }

                // return value
                return dataConnector;
            }
            #endregion

            #region GetLastException()
            /// <summary>
            /// This method returns the last Exception from the AppController if one exists.
            /// Always test for null before refeferencing the Exception returned as it will be null 
            /// if no errors were encountered.
            /// </summary>
            /// <returns></returns>
            public Exception GetLastException()
            {
                // initial value
                Exception exception = null;

                // If the AppController object exists
                if (this.HasAppController)
                {
                    // return the Exception from the AppController
                    exception = this.AppController.Exception;

                    // Set to null after the exception is retrieved so it does not return again
                    this.AppController.Exception = null;
                }

                // return value
                return exception;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perform Initializations for this object.
            /// </summary>
            private void Init()
            {
                // Create Application Controller
                this.AppController = new ApplicationController(ConnectionName);
            }
            #endregion

            #region LoadReminders(Reminder tempReminder = null)
            /// <summary>
            /// This method loads a collection of 'Reminder' objects.
            /// </summary>
            public List<Reminder> LoadReminders(Reminder tempReminder = null)
            {
                // initial value
                List<Reminder> reminders = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    reminders = this.AppController.ControllerManager.ReminderController.FetchAll(tempReminder);
                }

                // return value
                return reminders;
            }
            #endregion

                #region LoadRemindersForReminderDate(DateTime reminderDate)
                /// <summary>
                /// This method is used to load 'Reminder' objects for the ReminderDate given.
                /// </summary>
                public List<Reminder> LoadRemindersForReminderDate(DateTime reminderDate)
                {
                    // initial value
                    List<Reminder> reminders = null;
                    
                    // Create a temp Reminder object
                    Reminder tempReminder = new Reminder();
                    
                    // Set the value for LoadByReminderDate to true
                    tempReminder.LoadByReminderDate = true;
                    
                    // Set the value for ReminderDate
                    tempReminder.ReminderDate = reminderDate;
                    
                    // Perform the load
                    reminders = LoadReminders(tempReminder);
                    
                    // return value
                    return reminders;
                }
                #endregion
                
            #region SaveReminder(ref Reminder reminder)
            /// <summary>
            /// This method is used to save 'Reminder' objects.
            /// </summary>
            /// <param name="reminder">The Reminder to save.</param>
            public bool SaveReminder(ref Reminder reminder)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.ReminderController.Save(ref reminder);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            /// <summary>
            /// This property gets or sets the value for 'AppController'.
            /// </summary>
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ConnectionName
            /// <summary>
            /// This property gets or sets the value for 'ConnectionName'.
            /// </summary>
            public string ConnectionName
            {
                get { return connectionName; }
                set { connectionName = value; }
            }
            #endregion
            
            #region HasAppController
            /// <summary>
            /// This property returns true if this object has an 'AppController'.
            /// </summary>
            public bool HasAppController
            {
                get
                {
                    // initial value
                    bool hasAppController = (this.AppController != null);

                    // return value
                    return hasAppController;
                }
            }
            #endregion

            #region HasConnectionName
            /// <summary>
            /// This property returns true if the 'ConnectionName' exists.
            /// </summary>
            public bool HasConnectionName
            {
                get
                {
                    // initial value
                    bool hasConnectionName = (!String.IsNullOrEmpty(this.ConnectionName));
                    
                    // return value
                    return hasConnectionName;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
