
namespace RemindMe
{
    public class ReminderHelper
    {
        #region  Methods

            #region ExtendReminder()
            /// <summary>
            /// Extend Reminder
            /// </summary>
            public static void ExtendReminder(Reminder reminder)
            {
                // If the reminder object exists
                if (NullHelper.Exists(reminder))
                {
                    // Get the extendDate
                    reminder.ReminderDate = GetExtendDate(reminder);

                    // Create the Gateway
                    Gateway gateway = new Gateway(Connection.Name);

                    // perform the save
                    gateway.SaveReminder(ref reminder);
                }
            }
            #endregion

            #region GetExtendDate(Reminder reminder)
            /// <summary>
            /// returns the Extend Days
            /// </summary>
            public static DateTime GetExtendDate(Reminder reminder)
            {
                // initial value
                DateTime extendDate = DateTime.Now;

                // If the reminder object exists
                if (NullHelper.Exists(reminder))
                {  
                    // set the return value in case of no changes
                    extendDate = reminder.ReminderDate;

                    // if recurring
                    if (reminder.Recurring)
                    {
                        switch(reminder.RecurringType)
                        {
                            case RecurringTypeEnum.Annual:

                                // add to the extendDate
                                extendDate = reminder.ReminderDate.AddYears(1);

                                // required
                                break;

                            case RecurringTypeEnum.Bi_Weekly:

                                // add to the extendDate
                                extendDate = reminder.ReminderDate.AddDays(14);

                                // required
                                break;

                            case RecurringTypeEnum.Daily:

                                    // add to the extendDate
                                extendDate = reminder.ReminderDate.AddDays(1);

                                // required
                                break;

                            case RecurringTypeEnum.Five_Years:

                                    // add to the extendDate
                                extendDate = reminder.ReminderDate.AddYears(5);

                                // required
                                break;

                            case RecurringTypeEnum.Monthly:

                                    // add to the extendDate
                                extendDate = reminder.ReminderDate.AddMonths(1);

                                // required
                                break;

                            case RecurringTypeEnum.Ten_Years:

                                    // add to the extendDate
                                extendDate = reminder.ReminderDate.AddYears(10);

                                // required
                                break;

                                case RecurringTypeEnum.Weekly:

                                    // add to the extendDate
                                extendDate = reminder.ReminderDate.AddDays(7);

                                // required
                                break;
                        }
                    }
                }
                
                // return value
                return extendDate;
            }
            #endregion
            
        #endregion
    }
}
