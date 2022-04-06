

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class Reminder
    public partial class Reminder
    {

        #region Private Variables
        private int id;
        private string name;
        private string note;
        private bool recurring;
        private RecurringTypeEnum recurringType;
        private DateTime reminderDate;
        #endregion

        #region Methods

            #region UpdateIdentity(int id)
            // <summary>
            // This method provides a 'setter'
            // functionality for the Identity field.
            // </summary>
            public void UpdateIdentity(int id)
            {
                // Update The Identity field
                this.id = id;
            }
            #endregion

        #endregion

        #region Properties

            #region int Id
            public int Id
            {
                get
                {
                    return id;
                }
            }
            #endregion

            #region string Name
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            #endregion

            #region string Note
            public string Note
            {
                get
                {
                    return note;
                }
                set
                {
                    note = value;
                }
            }
            #endregion

            #region bool Recurring
            public bool Recurring
            {
                get
                {
                    return recurring;
                }
                set
                {
                    recurring = value;
                }
            }
            #endregion

            #region RecurringTypeEnum RecurringType
            public RecurringTypeEnum RecurringType
            {
                get
                {
                    return recurringType;
                }
                set
                {
                    recurringType = value;
                }
            }
            #endregion

            #region DateTime ReminderDate
            public DateTime ReminderDate
            {
                get
                {
                    return reminderDate;
                }
                set
                {
                    reminderDate = value;
                }
            }
            #endregion

            #region bool IsNew
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
