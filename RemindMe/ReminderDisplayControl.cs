

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace RemindMe
{

    #region class ReminderDisplayControl
    /// <summary>
    /// This class is used to display reminders.
    /// </summary>
    public partial class ReminderDisplayControl : UserControl
    {
        
        #region Private Variables
        private Reminder reminder;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'ReminderDisplayControl' object.
        /// </summary>
        public ReminderDisplayControl()
        {
            // Create Controls
            InitializeComponent();

            // Bug in DataJuggler.Win.Controls
            NoteControl.LabelTextAlign = ContentAlignment.TopRight;
            NoteControl.ValueLabelTextAlign = ContentAlignment.TopLeft;
        }
        #endregion
        
        #region Events
            
            #region DeleteButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'DeleteButton' is clicked.
            /// </summary>
            private void DeleteButton_Click(object sender, EventArgs e)
            {
                // if the Reminder exists
                if (HasReminder)
                {   
                    // Create a new instance of a 'Gateway' object.
                    Gateway gateway = new Gateway(Connection.Name);

                    // if deleted
                    bool deleted = gateway.DeleteReminder(Reminder.Id);

                    // if deleted
                    if (deleted)
                    {
                        // set to false
                        this.Visible = false;
                    }
                }
            }
            #endregion
            
            #region ExtendButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ExtendButton' is clicked.
            /// </summary>
            private void ExtendButton_Click(object sender, EventArgs e)
            {
                // if the Reminder exists
                if ((HasReminder) && (Reminder.RecurringType != RecurringTypeEnum.None))
                {
                    // Extend
                    ReminderHelper.ExtendReminder(Reminder);

                    // Extend
                    DisplaySelectedReminder();
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region DisplaySelectedReminder()
            /// <summary>
            /// Display Selected Reminder
            /// </summary>
            public void DisplaySelectedReminder()
            {
                // initial values
                string title = "";
                string date = "";
                string note = "";

                // if the value for HasReminder is true
                if (HasReminder)
                {
                    title = Reminder.Name;
                    date = Reminder.ReminderDate.ToShortDateString();
                    note = Reminder.Note;
                }

                // display the values
                TitleLabel.Text = title;
                DueDateLabel.Text = date;
                NoteControl.Text = note;

                // Enable controls
                UIEnable();
            }
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// UI Enable
            /// </summary>
            public void UIEnable()
            {
                // Show Delete if the Reminder is visible
                DeleteButton.Visible = HasReminder;

                // Show the ExtendButton if Recurring
                ExtendButton.Visible = ((HasReminder) && (Reminder.RecurringType != RecurringTypeEnum.None));
            }
            #endregion
            
        #endregion

        #region Properties

            #region HasReminder
            /// <summary>
            /// This property returns true if this object has a 'Reminder'.
            /// </summary>
            public bool HasReminder
            {
                get
                {
                    // initial value
                    bool hasReminder = (this.Reminder != null);
                    
                    // return value
                    return hasReminder;
                }
            }
            #endregion
            
            #region Reminder
            /// <summary>
            /// This property gets or sets the value for 'Reminder'.
            /// </summary>
            public Reminder Reminder
            {
                get { return reminder; }
                set { reminder = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
