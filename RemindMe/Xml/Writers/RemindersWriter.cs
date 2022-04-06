

#region using statements

using ObjectLibrary.BusinessObjects;
using DataJuggler.UltimateHelper;
using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace RemindMe.Xml.Writers
{

    #region class RemindersWriter
    /// <summary>
    /// This class is used to export an instance or a list of 'Reminder' objects to xml.
    /// </summary>
    public class RemindersWriter
    {

        #region Methods

            #region ExportList(List<Reminder> reminders, int indent = 0)
            // <Summary>
            // This method is used to export a list of 'Reminder' objects to xml
            // </Summary>
            public static string ExportList(List<Reminder> reminders, int indent = 0)
            {
                // initial value
                string xml = "";

                // locals
                string remindersXml = String.Empty;
                string indentString = TextHelper.Indent(indent);

                // Create a new instance of a StringBuilder object
                StringBuilder sb = new StringBuilder();

                // Add the indentString
                sb.Append(indentString);

                // Add the open Reminder Node
                sb.Append("<Reminders>");

                // Add a new line
                sb.Append(Environment.NewLine);

                // If there are one or more Reminder objects
                if ((reminders != null) && (reminders.Count > 0))
                {
                    // Iterate the reminders collection
                    foreach (Reminder reminder  in reminders)
                    {
                        // Get the xml for this reminders
                        remindersXml = ExportReminder(reminder, indent + 2);

                        // If the remindersXml string exists
                        if (TextHelper.Exists(remindersXml))
                        {
                            // Add this reminders to the xml
                            sb.Append(remindersXml);
                        }
                    }
                }

                // Add the close RemindersWriter Node
                sb.Append(indentString);
                sb.Append("</Reminders>");

                // Set the return value
                xml = sb.ToString();

                // return value
                return xml;
            }
            #endregion

            #region ExportReminder(Reminder reminder, int indent = 0)
            // <Summary>
            // This method is used to export a Reminder object to xml.
            // </Summary>
            public static string ExportReminder(Reminder reminder, int indent = 0)
            {
                // initial value
                string reminderXml = "";

                // locals
                string indentString = TextHelper.Indent(indent);
                string indentString2 = TextHelper.Indent(indent + 2);

                // If the reminder object exists
                if (NullHelper.Exists(reminder))
                {
                    // Create a StringBuilder
                    StringBuilder sb = new StringBuilder();

                    // Append the indentString
                    sb.Append(indentString);

                    // Write the open reminder node
                    sb.Append("<Reminder>" + Environment.NewLine);

                    // Write out each property

                    // Write out the value for Id

                    sb.Append(indentString2);
                    sb.Append("<Id>" + reminder.Id + "</Id>" + Environment.NewLine);

                    // Write out the value for IsNew

                    sb.Append(indentString2);
                    sb.Append("<IsNew>" + reminder.IsNew + "</IsNew>" + Environment.NewLine);

                    // Write out the value for Name

                    sb.Append(indentString2);
                    sb.Append("<Name>" + reminder.Name + "</Name>" + Environment.NewLine);

                    // Write out the value for Note

                    sb.Append(indentString2);
                    sb.Append("<Note>" + reminder.Note + "</Note>" + Environment.NewLine);

                    // Write out the value for Recurring

                    sb.Append(indentString2);
                    sb.Append("<Recurring>" + reminder.Recurring + "</Recurring>" + Environment.NewLine);

                    // Write out the value for RecurringType

                    sb.Append(indentString2);
                    sb.Append("<RecurringType>" + reminder.RecurringType + "</RecurringType>" + Environment.NewLine);

                    // Write out the value for ReminderDate

                    sb.Append(indentString2);
                    sb.Append("<ReminderDate>" + reminder.ReminderDate + "</ReminderDate>" + Environment.NewLine);

                    // Append the indentString
                    sb.Append(indentString);

                    // Write out the close reminder node
                    sb.Append("</Reminder>" + Environment.NewLine);

                    // set the return value
                    reminderXml = sb.ToString();
                }
                // return value
                return reminderXml;
            }
            #endregion

        #endregion

    }
    #endregion

}
