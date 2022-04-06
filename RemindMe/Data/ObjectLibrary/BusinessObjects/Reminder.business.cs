
#region using statements

using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using XmlMirror.Runtime6.Objects;

#endregion

namespace ObjectLibrary.BusinessObjects
{

    #region class Reminder
    [Serializable]
    public partial class Reminder
    {

        #region Private Variables
        private List<string> invalidReasons;
        private bool loadByReminderDate;
        #endregion

        #region Constructor
        public Reminder()
        {
            // Initialize to Today
            ReminderDate = DateTime.Now;

            // Create the list
            InvalidReasons = new List<string>();
        }
        #endregion

        #region Methods

            #region Clone()
            public Reminder Clone()
            {
                // Create New Object
                Reminder newReminder = (Reminder) this.MemberwiseClone();

                // Return Cloned Object
                return newReminder;
            }
            #endregion

            #region ExportValues()
            /// <summary>
            /// returns a list of Values
            /// </summary>
            public List<FieldValuePair> ExportValues()
            {
                // initial value
                List<FieldValuePair> exportValues = new List<FieldValuePair>();

                FieldValuePair name = new FieldValuePair();
                name.FieldName = "Name";
                name.FieldValue = Name;
                
                // return value
                return exportValues;
            }
            #endregion
            
            #region IsValid()
            /// <summary>
            /// method returns the Valid
            /// </summary>
            public bool IsValid()
            {
                // initial value
                bool isValid = true;

                // Clear
                InvalidReasons = new List<string>();

                // if the name doesn't exist
                if (String.IsNullOrEmpty(Name))
                {
                    // not valid
                    isValid = false;

                    // Add this value
                    InvalidReasons.Add("Name is required");
                }

                // local
                DateTime now = DateTime.Now;

                // if the Day of Year is this Year
                if ((ReminderDate.DayOfYear < now.DayOfYear) && (ReminderDate.Year == now.Year))
                {
                    // not valid
                    isValid = false;

                    // Add this value
                    InvalidReasons.Add("Reminder Date must be set and in the future");
                }
                else if (ReminderDate.Year < now.Year)
                {
                    // not valid
                    isValid = false;

                    // Add this value
                    InvalidReasons.Add("Reminder Date must be set and in the future");
                }

                // if Recurring
                if (Recurring)
                {
                    // if RecurringType is not set
                    if (RecurringType == RecurringTypeEnum.None)
                    {
                        // not valid
                        isValid = false;

                        // Add this value
                        InvalidReasons.Add("You selected Recurring, but did not select a RecurringType");
                    }
                }
                else
                {
                    // This is set for the user
                    RecurringType = RecurringTypeEnum.None;
                }

                // return value
                return isValid;
            }
            #endregion
            
            #region ToString()
            /// <summary>
            /// method returns the String
            /// </summary>
            public override string ToString()
            {
                // return the name of this object
                return Name;
            }
            #endregion
            
        #endregion

        #region Properties

            #region InvalidReasons
            /// <summary>
            /// This property gets or sets the value for 'InvalidReasons'.
            /// </summary>
            public List<string> InvalidReasons
            {
                get { return invalidReasons; }
                set { invalidReasons = value; }
            }
            #endregion
            
            #region LoadByReminderDate
            /// <summary>
            /// This property gets or sets the value for 'LoadByReminderDate'.
            /// </summary>
            public bool LoadByReminderDate
            {
                get { return loadByReminderDate; }
                set { loadByReminderDate = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
