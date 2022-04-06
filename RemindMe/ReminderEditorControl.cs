namespace RemindMe
{

    #region class ReminderEditorControl
    /// <summary>
    /// This class is used to create, edit and extend reminders.
    /// </summary>
    public partial class ReminderEditorControl : UserControl, ITextChanged, ICheckChangedListener, ISelectedIndexListener
    {
        
        #region Private Variables        
        private ThemeEnum theme;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'ReminderEditorControl' object.
        /// </summary>
        public ReminderEditorControl()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region ExtendButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ExtendButton' is clicked.
            /// </summary>
            private void ExtendButton_Click(object sender, EventArgs e)
            {
                // if the value for HasSelectedReminder is true
                if ((HasSelectedReminder) && (SelectedReminder.Recurring) && (!SelectedReminder.IsNew))
                {
                    // Extend
                    ReminderHelper.ExtendReminder(SelectedReminder);

                    // Now display
                    DisplaySelectedReminder();
                }
            }
            #endregion
            
            #region OnCheckChanged(LabelCheckBoxControl sender, bool isChecked)
            /// <summary>
            /// event is fired when On Check Changed
            /// </summary>
            public void OnCheckChanged(LabelCheckBoxControl sender, bool isChecked)
            {
                // If the SelectedReminder object exists
                if (NullHelper.Exists(SelectedReminder))
                {
                    // Setup the value
                    SelectedReminder.Recurring = isChecked;
                }

                // Setup the control
                UIEnable();
            }
            #endregion
            
            #region OnSelectedIndexChanged(LabelComboBoxControl control, int selectedIndex, object selectedItem)
            /// <summary>
            /// event is fired when a selection is made in the 'On'.
            /// </summary>
            public void OnSelectedIndexChanged(LabelComboBoxControl control, int selectedIndex, object selectedItem)
            {
                // if the value for HasSelectedReminder is true
                if ((HasSelectedReminder) && (control.HasSelectedObject))
                {
                    // Set the RecurringType
                    SelectedReminder.RecurringType = ParseRecurringType(control.SelectedObject);
                }

                // Enable or disable the Save button
                UIEnable();
            }
            #endregion
            
            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                // if the selectedReminder exists
                if (NullHelper.Exists(SelectedReminder, sender))
                {
                    switch (sender.Name)
                    {
                        case "NameControl":

                            // Set the name
                            SelectedReminder.Name = text;

                            // required
                            break;

                        case "NotesControl":

                            // Set the note
                            SelectedReminder.Note = text;

                            // required
                            break;

                        case "DateControl":

                            // Set the Date
                            SelectedReminder.ReminderDate = DateHelper.ParseDate(text, DateTime.Now, new DateTime(1900, 1, 1));

                            // required
                            break;
                    }
                }

                // if the value for HasParentReminderEditorForm is true
                if (HasParentReminderEditorForm)
                {
                    // Enable or disable
                    ParentReminderEditorForm.UIEnable();
                }
            }
            #endregion
            
        #endregion
        
        #region Methods
            
            #region Add()
            /// <summary>
            /// method Add
            /// </summary>
            public void Add()
            {  
                // Erase the screen
                DisplaySelectedReminder();
            }
            #endregion
            
            #region Clear()
            /// <summary>
            /// method Clear
            /// </summary>
            public void Clear()
            {
                NameControl.Text = "";
                DateControl.Text = "";
                RecurringControl.Checked = false;
            }
            #endregion
            
            #region DisplaySelectedReminder()
            /// <summary>
            /// Display Selected Reminder
            /// </summary>
            public void DisplaySelectedReminder()
            {
                // locals
                string name = "";
                string date = "";
                bool recurring = false;
                RecurringTypeEnum recurringType = RecurringTypeEnum.Annual;
                string note = "";
                string title = "View Reminder";

                // if the value for HasSelectedReminder is true
                if (HasSelectedReminder)
                {
                    // set the local values from our Reminder object
                    name = SelectedReminder.Name;
                    date = SelectedReminder.ReminderDate.ToShortDateString();
                    recurring = SelectedReminder.Recurring;
                    recurringType = SelectedReminder.RecurringType;
                    note = SelectedReminder.Note;

                    // if Add
                    if (EditMode == EditModeEnum.Add)
                    {
                        // change to create
                        title = "Create Reminder";
                    }
                    else if (EditMode == EditModeEnum.Edit)
                    {
                        // change to Edit
                        title = "Edit Reminder";
                    }
                }

                // set the values
                NameControl.Text = name;
                DateControl.Text = date;
                RecurringControl.Checked = recurring;
                RecurringTypeControl.SelectedIndex = RecurringTypeControl.FindItemIndexByValue(recurringType.ToString());
                NotesControl.Text = note;
                TitleLabel.Text = title;
            }
            #endregion

            
            
            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                 // Load the Items
               RecurringTypeControl.LoadItems(typeof(RecurringTypeEnum));

               // wire up the listeners
               NameControl.OnTextChangedListener = this;
               DateControl.OnTextChangedListener = this;
               RecurringControl.CheckChangedListener = this;
               RecurringTypeControl.SelectedIndexListener = this;
               NotesControl.OnTextChangedListener = this;

               // Default to wood
               Theme = ThemeEnum.Wood;

               // size the button
               ExtendButton.Height = 40;
               ExtendButton.Width = 96;

               // Disable controls until we are in Add or Edit mode
               UIEnable();
            }
            #endregion
            
            #region ParseRecurringType(object recurringType)
            /// <summary>
            /// returns the Recurring Type
            /// </summary>
            public static RecurringTypeEnum ParseRecurringType(object selectedObject)
            {
                // initial value
                RecurringTypeEnum recurringType = RecurringTypeEnum.None;

                // If the selectedObject object exists
                if (NullHelper.Exists(selectedObject))
                {
                    // Get the selected object
                    string temp = selectedObject.ToString();

                    // if the temp string exists
                    if (TextHelper.Exists(temp))
                    {
                        switch (temp)
                        {
                            case "Annual":

                                // Set the RecurringType
                                recurringType = RecurringTypeEnum.Annual;

                                // required
                                break;

                            case "Bi_Weekly":
                            case "Bi Weekly":

                                // Set the RecurringType
                                recurringType = RecurringTypeEnum.Bi_Weekly;

                                // required
                                break;

                            case "Daily":

                                // Set the RecurringType
                                recurringType = RecurringTypeEnum.Daily;

                                // required
                                break;

                            case "Five_Years":
                            case "Five Years":

                                // Set the RecurringType
                                recurringType = RecurringTypeEnum.Five_Years;

                                // required
                                break;

                            case "Monthly":

                                // Set the RecurringType
                                recurringType = RecurringTypeEnum.Monthly;

                                // required
                                break;

                            case "Ten_Years":
                            case "Ten Years":

                                // Set the RecurringType
                                recurringType = RecurringTypeEnum.Ten_Years;

                                // required
                                break;

                            case "Weekly":

                                // Set the RecurringType
                                recurringType = RecurringTypeEnum.Weekly;

                                // required
                                break;
                        }
                    }
                }
                
                // return value
                return recurringType;
            }
            #endregion
            
            #region SetFocusToNameTextBox()
            /// <summary>
            /// Set Focus To Name Text Box
            /// </summary>
            public void SetFocusToNameTextBox()
            {
                // Set Focus to the NameTextBox
                NameControl.SetFocusToTextBox();
            }
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// UI Enable
            /// </summary>
            public void UIEnable()
            {
                // Enable all the controls if we are in Add or Edit mode
                Enabled = (EditMode != EditModeEnum.ReadOnly);
                NameControl.Editable = (EditMode != EditModeEnum.ReadOnly);
                NameControl.Enabled = Enabled;
                DateControl.Editable = (EditMode != EditModeEnum.ReadOnly);
                DateControl.Enabled = Enabled;
                RecurringControl.Editable = (EditMode != EditModeEnum.ReadOnly);
                RecurringControl.Enabled = Enabled;                
                NotesControl.Editable = (EditMode != EditModeEnum.ReadOnly);
                NotesControl.Enabled = Enabled;

                // if checked
                if (RecurringControl.Checked)
                {
                    // enabled
                    RecurringTypeControl.Editable = (EditMode != EditModeEnum.ReadOnly);
                    RecurringTypeControl.Enabled = (EditMode != EditModeEnum.ReadOnly);                    
                }
                else
                {
                    // not enabled
                    RecurringTypeControl.Editable = false;
                    RecurringTypeControl.Enabled = false;
                }
            }
            #endregion

        #endregion

        #region Properties

            #region EditMode
            /// <summary>
            /// This read only property returns the value for 'EditMode'.
            /// </summary>
            public EditModeEnum EditMode
            {
                get
                {
                    // initial value
                    EditModeEnum editMode = EditModeEnum.ReadOnly;

                    // if the value for HasParentReminderEditorForm is true
                    if (HasParentReminderEditorForm)
                    {
                        // set the return value
                        editMode = ParentReminderEditorForm.EditMode;
                    }

                    // return value
                    return editMode;
                }
            }
            #endregion
            
            #region HasParentReminderEditorForm
            /// <summary>
            /// This property returns true if this object has a 'ParentReminderEditorForm'.
            /// </summary>
            public bool HasParentReminderEditorForm
            {
                get
                {
                    // initial value
                    bool hasParentReminderEditorForm = (this.ParentReminderEditorForm != null);
                    
                    // return value
                    return hasParentReminderEditorForm;
                }
            }
            #endregion
            
            #region HasSelectedReminder
            /// <summary>
            /// This property returns true if this object has a 'SelectedReminder'.
            /// </summary>
            public bool HasSelectedReminder
            {
                get
                {
                    // initial value
                    bool hasSelectedReminder = (this.SelectedReminder != null);
                    
                    // return value
                    return hasSelectedReminder;
                }
            }
            #endregion
            
            #region ParentReminderEditorForm
            /// <summary>
            /// This property gets or sets the value for 'ParentReminderEditorForm'.
            /// </summary>
            public ReminderEditorForm ParentReminderEditorForm
            {
                get
                {
                    // initial value
                    ReminderEditorForm form = ParentForm as ReminderEditorForm;

                    // return value
                    return form;
                }
            }
            #endregion
            
            #region SelectedReminder
            /// <summary>
            /// This property gets or sets the value for 'SelectedReminder'.
            /// </summary>
            public Reminder SelectedReminder
            {
                get
                {
                    // initiial value
                    Reminder selectedReminder = null;

                    // if the value for HasParentReminderEditorForm is true
                    if (HasParentReminderEditorForm)
                    {
                        // set the return value
                        selectedReminder = ParentReminderEditorForm.SelectedReminder;
                    }

                    // return value
                    return selectedReminder;
                }
            }
        #endregion

            #region Theme
            /// <summary>
            /// This property gets or sets the value for 'Theme'.
            /// </summary>
            public ThemeEnum Theme
            {
                get { return theme; }
                set { theme = value; }
            }
            #endregion
            
        #endregion
    }
    #endregion

}
