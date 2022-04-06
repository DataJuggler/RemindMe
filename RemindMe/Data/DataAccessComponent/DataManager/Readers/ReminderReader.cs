

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class ReminderReader
    /// <summary>
    /// This class loads a single 'Reminder' object or a list of type <Reminder>.
    /// </summary>
    public class ReminderReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'Reminder' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'Reminder' DataObject.</returns>
            public static Reminder Load(DataRow dataRow)
            {
                // Initial Value
                Reminder reminder = new Reminder();

                // Create field Integers
                int idfield = 0;
                int namefield = 1;
                int notefield = 2;
                int recurringfield = 3;
                int recurringTypefield = 4;
                int reminderDatefield = 5;

                try
                {
                    // Load Each field
                    reminder.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    reminder.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    reminder.Note = DataHelper.ParseString(dataRow.ItemArray[notefield]);
                    reminder.Recurring = DataHelper.ParseBoolean(dataRow.ItemArray[recurringfield], false);
                    reminder.RecurringType = (RecurringTypeEnum) DataHelper.ParseInteger(dataRow.ItemArray[recurringTypefield], 0);
                    reminder.ReminderDate = DataHelper.ParseDate(dataRow.ItemArray[reminderDatefield]);
                }
                catch
                {
                }

                // return value
                return reminder;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'Reminder' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A Reminder Collection.</returns>
            public static List<Reminder> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<Reminder> reminders = new List<Reminder>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'Reminder' from rows
                        Reminder reminder = Load(row);

                        // Add this object to collection
                        reminders.Add(reminder);
                    }
                }
                catch
                {
                }

                // return value
                return reminders;
            }
            #endregion

        #endregion

    }
    #endregion

}
