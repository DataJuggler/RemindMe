namespace RemindMe
{

    #region class ReminderEditorForm : Form, IListEditorHost
    /// <summary>
    /// This is the MainForm for this app.
    /// </summary>
    public partial class ReminderEditorForm : Form, IListEditorHost, ISaveCancelHost
    {
        
        #region Private Variables
        private EditModeEnum editMode;
        private object selectedItem;
        private bool isEditing;
        private List<Reminder> reminders;
        private Gateway gateway;
        private Reminder clone;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public ReminderEditorForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Methods
            
            #region Add()
            /// <summary>
            /// method Add
            /// </summary>
            public void Add()
            {
                // Set EditMode
                EditMode = EditModeEnum.Add;

                // Create a new item
                SelectedItem = new Reminder();

                // Clone the object
                Clone = SelectedReminder.Clone();

                // Add a new Reminder
                ReminderEditor.Add();

                // Show the control
                UIEnable();

                // Prepare for Data Entry
                ReminderEditor.SetFocusToNameTextBox();
            }
            #endregion
            
            #region Cancel()
            /// <summary>
            /// method Cancel
            /// </summary>
            public void Cancel()
            {
                // if Add
                if (EditMode == EditModeEnum.Add)
                {
                    // nothing selected
                    SelectedItem = null;
                }

                // No longer editing
                EditMode = EditModeEnum.ReadOnly;

                // Reload the list
                RemindersListControl.LoadAndDisplayList(SelectedReminder);
            }
            #endregion
            
            #region Clear()
            /// <summary>
            /// Clear
            /// </summary>
            public void Clear()
            {
                // Clear the values ont the control
                ReminderEditor.Clear();
            }
            #endregion
            
            #region Delete()
            /// <summary>
            /// method Delete
            /// </summary>
            public void Delete()
            {
                // if the value for HasSelectedReminder is true
                if (HasSelectedReminder)
                {
                    // Create a new Gateway
                    Gateway gateway = new Gateway(Connection.Name);

                    // Delete
                    gateway.DeleteReminder(SelectedReminder.Id);

                    // Refresh the list with nothing selected
                    RemindersListControl.LoadAndDisplayList();

                    // nothing selected
                    SelectedItem = null;

                    // Nothing selected, so ReminderEditor control is not visible
                    UIEnable();
                }
            }
            #endregion
            
            #region Edit()
            /// <summary>
            /// method Edit
            /// </summary>
            public void Edit()
            {
                // if the value for HasSelectedItem is true
                if (HasSelectedReminder)
                {
                    // Set to edit
                    EditMode = EditModeEnum.Edit;

                    // Clone the object
                    Clone = SelectedReminder.Clone();

                    // Enable controls
                    UIEnable();

                    // Change the Title to Edit
                    ReminderEditor.DisplaySelectedReminder();

                    // Set Focus to the name text box
                    ReminderEditor.SetFocusToNameTextBox();
                }
            }
            #endregion
            
            #region EnableSaveButton(bool enabled)
            /// <summary>
            /// method Enable Save Button
            /// </summary>
            public void EnableSaveButton(bool enabled)
            {
                // Enable the SaveButton
                SaveCancelControl.EnableSaveButton = enabled;                
            }
            #endregion
            
            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Wire up the host
                RemindersListControl.ParentListEditorHost = this;

                // Default tor ReadOnly
                EditMode = EditModeEnum.ReadOnly;

                // Enable or disable controls
                UIEnable();

                // Create a new instance of a 'Gateway' object.
                Gateway gateway = new Gateway(Connection.Name);

                // Create a new instance of a 'DateTime' object.
                DateTime now = DateTime.Now;

                // get the overdue reminders
                DateTime today = new DateTime(now.Year, now.Month, now.Day);
                List<Reminder> overdueReminders = gateway.LoadRemindersForReminderDate(today);

                // If the overdueReminders collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(overdueReminders))
                {
                    DisplayRemindersForm form = new DisplayRemindersForm();

                    // Setup the Form
                    form.SetupReminders(overdueReminders);

                    // Show this form
                    form.ShowDialog();
                }

                // Move load and display to after RemindersForm, just in case any edits happen.

                // load our list of Reminders
                RemindersListControl.LoadAndDisplayList();
            }
            #endregion
            
            #region ItemSelected(object selectedItem)
            /// <summary>
            /// method Item Selected
            /// </summary>
            public void ItemSelected(object selectedItem)
            {
                // Set our selected item
                SelectedItem = selectedItem;

                // if the value for HasSelectedReminder is true
                if (HasSelectedReminder)
                {
                    // Create the Clone
                    Clone = SelectedReminder.Clone();

                    // Display the selected reminder
                    ReminderEditor.DisplaySelectedReminder();

                    // Enable controls if in EditMode
                    UIEnable();
                }
            }
            #endregion
            
            #region LoadList()
            /// <summary>
            /// method Load List
            /// </summary>
            public List<object> LoadList()
            {
                 // Create a new instance of a 'Gateway' object.
                Gateway = new Gateway(Connection.Name);

                // Load all reminders
                Reminders = Gateway.LoadReminders();

                // cast the list of Reminders as Objects
                List<object> objectList = Reminders.Cast<object>().ToList();

                // Load the object list
                RemindersListControl.List = objectList;

                // Display the list
                RemindersListControl.DisplayList();

                // return the list
                return objectList;
            }
            #endregion
            
            #region OnCancel()
            /// <summary>
            /// method On Cancel
            /// </summary>
            public void OnCancel()
            {
                // Call the Cancel code?
                Cancel();
            }
            #endregion
            
            #region OnSave(bool close)
            /// <summary>
            /// method returns the Save
            /// </summary>
            public bool OnSave(bool close)
            {
                // initial value
                bool saved = false;

                // if the value for HasSelectedReminder is true
                if (HasSelectedReminder)
                {
                    // if a valid reminder
                    if (SelectedReminder.IsValid())
                    {
                        // Show the validation errors
                        StatusLabel.Text = "Reminder does validate:" + Environment.NewLine;
                        StatusLabel.ForeColor = Color.LemonChiffon;

                        // Create a gateway instance
                        Gateway gateway = new Gateway(Connection.Name);

                        // get a local reference
                        Reminder reminder = SelectedReminder;

                        // perform the save
                        saved = gateway.SaveReminder(ref reminder);

                        // if Saved
                        if (saved)
                        {
                            // Show aborted message
                            StatusLabel.Text += "Save completed.";

                            // Reset the Clone
                            Clone = SelectedReminder.Clone();

                            // Go back to read only
                            EditMode = EditModeEnum.ReadOnly;

                            // Load the list
                            RemindersListControl.LoadAndDisplayList(reminder);
                        }
                        else
                        {
                             // Show the validation errors
                            StatusLabel.Text = "Save failed:" + Environment.NewLine;
                            StatusLabel.ForeColor = Color.Tomato;
                        }
                    }
                    else
                    {
                        // Show the validation errors
                        StatusLabel.Text = "Reminder does not validate:" + Environment.NewLine;
                        StatusLabel.ForeColor = Color.Tomato;
                        
                        // if there are one or more invalid reasons
                        if (ListHelper.HasOneOrMoreItems(SelectedReminder.InvalidReasons))
                        {
                            // iterate the list of invalid reasons
                            foreach (string invalidReason in SelectedReminder.InvalidReasons)
                            {
                                // Add this item
                                StatusLabel.Text += invalidReason + Environment.NewLine;
                            }
                        }

                        // Show aborted message
                        StatusLabel.Text += "Save Aborted.";
                    }

                    // Enable
                    UIEnable();
                }

                // return value
                return saved;
            }
            #endregion
            
            #region Save()
            /// <summary>
            /// method Save
            /// </summary>
            public bool Save()
            {
                // initial value
                bool saved = false;



                // return value
                return saved;
            }
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// UI Enable
            /// </summary>
            public void UIEnable()
            {
                // Only show the ReminderEditor if there is a SelectedReminder
                ReminderEditor.Visible = HasSelectedReminder;
                
                // Enable the Reminder Form
                ReminderEditor.UIEnable();

                // Now determine if the Save button should be enabled
                if (NullHelper.Exists(SelectedReminder, Clone))
                {
                    // Now is always enabled
                    if (SelectedReminder.IsNew)
                    {
                        // enabled
                        SaveCancelControl.EnableSaveButton = true;
                    }
                    else
                    {
                        // export two strings to compare
                        string xml = RemindersWriter.ExportReminder(SelectedReminder);

                        // export Clone
                        string xml2 = RemindersWriter.ExportReminder(Clone);

                        // Enable if the objects do not match
                        SaveCancelControl.EnableSaveButton = !TextHelper.IsEqual(xml, xml2);
                    }

                    // You can cancel if Editing
                    SaveCancelControl.EnableCancelSaveButton = (EditMode != EditModeEnum.ReadOnly);
                }
                else
                {
                    // enabled
                    SaveCancelControl.EnableSaveButton = false;
                    SaveCancelControl.EnableCancelSaveButton = false;
                }
            }
        #endregion

        #endregion

        #region Properties

            #region Clone
            /// <summary>
            /// This property gets or sets the value for 'Clone'.
            /// </summary>
            public Reminder Clone
            {
                get { return clone; }
                set { clone = value; }
            }
            #endregion
            
            #region EditMode
            /// <summary>
            /// This property gets or sets the value for 'EditMode'.
            /// </summary>
            public EditModeEnum EditMode
            {
                get { return editMode; }
                set { editMode = value; }
            }
            #endregion
            
            #region Gateway
            /// <summary>
            /// This property gets or sets the value for 'Gateway'.
            /// </summary>
            public Gateway Gateway
            {
                get { return gateway; }
                set { gateway = value; }
            }
            #endregion
            
            #region HasGateway
            /// <summary>
            /// This property returns true if this object has a 'Gateway'.
            /// </summary>
            public bool HasGateway
            {
                get
                {
                    // initial value
                    bool hasGateway = (this.Gateway != null);
                    
                    // return value
                    return hasGateway;
                }
            }
            #endregion
            
            #region HasReminders
            /// <summary>
            /// This property returns true if this object has a 'Reminders'.
            /// </summary>
            public bool HasReminders
            {
                get
                {
                    // initial value
                    bool hasReminders = (this.Reminders != null);
                    
                    // return value
                    return hasReminders;
                }
            }
            #endregion
            
            #region HasSelectedItem
            /// <summary>
            /// This property returns true if this object has a 'SelectedItem'.
            /// </summary>
            public bool HasSelectedItem
            {
                get
                {
                    // initial value
                    bool hasSelectedItem = (this.SelectedItem != null);
                    
                    // return value
                    return hasSelectedItem;
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
            
            #region IsEditing
            /// <summary>
            /// This property gets or sets the value for 'IsEditing'.
            /// </summary>
            public bool IsEditing
            {
                get { return isEditing; }
                set { isEditing = value; }
            }
            #endregion
            
            #region Reminders
            /// <summary>
            /// This property gets or sets the value for 'Reminders'.
            /// </summary>
            public List<Reminder> Reminders
            {
                get { return reminders; }
                set { reminders = value; }
            }
            #endregion
            
            #region SelectedItem
            /// <summary>
            /// This property gets or sets the value for 'SelectedItem'.
            /// </summary>
            public object SelectedItem
            {
                get { return selectedItem; }
                set { selectedItem = value; }
            }
            #endregion
            
            #region SelectedReminder
            /// <summary>
            /// This read only property returns the value for 'SelectedReminder'.
            /// </summary>
            public Reminder SelectedReminder
            {
                get
                {
                    // initial value
                    Reminder selectedReminder = SelectedItem as Reminder;
                    
                    // return value
                    return selectedReminder;
                }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
