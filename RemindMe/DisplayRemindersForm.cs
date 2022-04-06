

#region using statements


#endregion

namespace RemindMe
{

    #region class DisplayRemindersForm
    /// <summary>
    /// This class [Enter Class Description]
    /// </summary>
    public partial class DisplayRemindersForm : Form, ISaveCancelHost
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DisplayRemindersForm' object.
        /// </summary>
        public DisplayRemindersForm()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion

        #region Methods

            #region OnCancel()
            /// <summary>
            /// method On Cancel
            /// </summary>
            public void OnCancel()
            {
                // Close this form
                Close();
            }
            #endregion
            
            #region OnSave(bool close)
            /// <summary>
            /// method returns the Save
            /// </summary>
            public bool OnSave(bool close)
            {
                // not app9licable here
                return false;
            }
            #endregion
            
            #region SetupReminders(List<Reminder> reminders)
            /// <summary>
            /// Setup Reminders
            /// </summary>
            public void SetupReminders(List<Reminder> reminders)
            {
                // If the reminders collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(reminders))
                {   
                    // switch order
                    reminders.Reverse();

                    // Remove all
                    RemindersPanel.Controls.Clear();

                    // Iterate the collection of Reminder objects
                    foreach (Reminder reminder in reminders)
                    {
                        // Create a new instance of a 'ReminderDisplayControl' object.
                        ReminderDisplayControl reminderDisplay = new ReminderDisplayControl();

                        // set the Reminder
                        reminderDisplay.Reminder = reminder;

                        // Display
                        reminderDisplay.DisplaySelectedReminder();

                        // Dock to the top
                        reminderDisplay.Dock = DockStyle.Top;

                        // Add this control
                        RemindersPanel.Controls.Add(reminderDisplay);
                    }

                    // Setup the Done button
                    SaveCancelControl.SetupCancelButton("Done", 80, true, true);
                }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
