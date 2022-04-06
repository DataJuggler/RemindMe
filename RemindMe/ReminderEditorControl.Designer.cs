
namespace RemindMe
{

    #region class ReminderEditorControl
    /// <summary>
    /// This class is used to create, edit and extend reminders.
    /// </summary>
    partial class ReminderEditorControl
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private DataJuggler.Win.Controls.LabelTextBoxControl NotesControl;
        private DataJuggler.Win.Controls.LabelComboBoxControl RecurringTypeControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl DateControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl RecurringControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl NameControl;
        private Label TitleLabel;
        private DataJuggler.Win.Controls.Button ExtendButton;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                this.NotesControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
                this.RecurringTypeControl = new DataJuggler.Win.Controls.LabelComboBoxControl();
                this.DateControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
                this.RecurringControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.NameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
                this.TitleLabel = new System.Windows.Forms.Label();
                this.ExtendButton = new DataJuggler.Win.Controls.Button();
                this.SuspendLayout();
                //
                // NotesControl
                //
                this.NotesControl.BackColor = System.Drawing.Color.Transparent;
                this.NotesControl.BottomMargin = 0;
                this.NotesControl.Editable = true;
                this.NotesControl.Encrypted = false;
                this.NotesControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.NotesControl.Inititialized = true;
                this.NotesControl.LabelBottomMargin = 0;
                this.NotesControl.LabelColor = System.Drawing.Color.LemonChiffon;
                this.NotesControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.NotesControl.LabelText = "Notes:";
                this.NotesControl.LabelTopMargin = 0;
                this.NotesControl.LabelWidth = 160;
                this.NotesControl.Location = new System.Drawing.Point(33, 231);
                this.NotesControl.MultiLine = true;
                this.NotesControl.Name = "NotesControl";
                this.NotesControl.OnTextChangedListener = null;
                this.NotesControl.PasswordMode = false;
                this.NotesControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.NotesControl.Size = new System.Drawing.Size(415, 129);
                this.NotesControl.TabIndex = 20;
                this.NotesControl.TextBoxBottomMargin = 0;
                this.NotesControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
                this.NotesControl.TextBoxEditableColor = System.Drawing.Color.White;
                this.NotesControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.NotesControl.TextBoxTopMargin = 0;
                this.NotesControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                //
                // RecurringTypeControl
                //
                this.RecurringTypeControl.BackColor = System.Drawing.Color.Transparent;
                this.RecurringTypeControl.ComboBoxLeftMargin = 1;
                this.RecurringTypeControl.ComboBoxText = "";
                this.RecurringTypeControl.ComoboBoxFont = null;
                this.RecurringTypeControl.Editable = true;
                this.RecurringTypeControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.RecurringTypeControl.HideLabel = false;
                this.RecurringTypeControl.LabelBottomMargin = 0;
                this.RecurringTypeControl.LabelColor = System.Drawing.Color.LemonChiffon;
                this.RecurringTypeControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.RecurringTypeControl.LabelText = "Recurring Type:";
                this.RecurringTypeControl.LabelTopMargin = 0;
                this.RecurringTypeControl.LabelWidth = 160;
                this.RecurringTypeControl.List = null;
                this.RecurringTypeControl.Location = new System.Drawing.Point(33, 181);
                this.RecurringTypeControl.Name = "RecurringTypeControl";
                this.RecurringTypeControl.SelectedIndex = -1;
                this.RecurringTypeControl.SelectedIndexListener = null;
                this.RecurringTypeControl.Size = new System.Drawing.Size(415, 32);
                this.RecurringTypeControl.Sorted = true;
                this.RecurringTypeControl.Source = null;
                this.RecurringTypeControl.TabIndex = 19;
                //
                // DateControl
                //
                this.DateControl.BackColor = System.Drawing.Color.Transparent;
                this.DateControl.BottomMargin = 0;
                this.DateControl.Editable = true;
                this.DateControl.Encrypted = false;
                this.DateControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.DateControl.Inititialized = true;
                this.DateControl.LabelBottomMargin = 0;
                this.DateControl.LabelColor = System.Drawing.Color.LemonChiffon;
                this.DateControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.DateControl.LabelText = "Date:";
                this.DateControl.LabelTopMargin = 0;
                this.DateControl.LabelWidth = 160;
                this.DateControl.Location = new System.Drawing.Point(33, 93);
                this.DateControl.MultiLine = false;
                this.DateControl.Name = "DateControl";
                this.DateControl.OnTextChangedListener = null;
                this.DateControl.PasswordMode = false;
                this.DateControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.DateControl.Size = new System.Drawing.Size(415, 32);
                this.DateControl.TabIndex = 18;
                this.DateControl.TextBoxBottomMargin = 0;
                this.DateControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
                this.DateControl.TextBoxEditableColor = System.Drawing.Color.White;
                this.DateControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.DateControl.TextBoxTopMargin = 0;
                this.DateControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                //
                // RecurringControl
                //
                this.RecurringControl.BackColor = System.Drawing.Color.Transparent;
                this.RecurringControl.CheckBoxHorizontalOffSet = 0;
                this.RecurringControl.CheckBoxVerticalOffSet = 4;
                this.RecurringControl.CheckChangedListener = null;
                this.RecurringControl.Checked = false;
                this.RecurringControl.Editable = true;
                this.RecurringControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.RecurringControl.LabelColor = System.Drawing.Color.LemonChiffon;
                this.RecurringControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.RecurringControl.LabelText = "Recurring:";
                this.RecurringControl.LabelWidth = 160;
                this.RecurringControl.Location = new System.Drawing.Point(33, 132);
                this.RecurringControl.Name = "RecurringControl";
                this.RecurringControl.Size = new System.Drawing.Size(204, 32);
                this.RecurringControl.TabIndex = 17;
                this.RecurringControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                //
                // NameControl
                //
                this.NameControl.BackColor = System.Drawing.Color.Transparent;
                this.NameControl.BottomMargin = 0;
                this.NameControl.Editable = true;
                this.NameControl.Encrypted = false;
                this.NameControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.NameControl.Inititialized = true;
                this.NameControl.LabelBottomMargin = 0;
                this.NameControl.LabelColor = System.Drawing.Color.LemonChiffon;
                this.NameControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.NameControl.LabelText = "Name:";
                this.NameControl.LabelTopMargin = 0;
                this.NameControl.LabelWidth = 160;
                this.NameControl.Location = new System.Drawing.Point(33, 47);
                this.NameControl.MultiLine = false;
                this.NameControl.Name = "NameControl";
                this.NameControl.OnTextChangedListener = null;
                this.NameControl.PasswordMode = false;
                this.NameControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.NameControl.Size = new System.Drawing.Size(415, 32);
                this.NameControl.TabIndex = 16;
                this.NameControl.TextBoxBottomMargin = 0;
                this.NameControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
                this.NameControl.TextBoxEditableColor = System.Drawing.Color.White;
                this.NameControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.NameControl.TextBoxTopMargin = 0;
                this.NameControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
                //
                // TitleLabel
                //
                this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
                this.TitleLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.TitleLabel.ForeColor = System.Drawing.Color.LemonChiffon;
                this.TitleLabel.Location = new System.Drawing.Point(43, 1);
                this.TitleLabel.Name = "TitleLabel";
                this.TitleLabel.Size = new System.Drawing.Size(405, 23);
                this.TitleLabel.TabIndex = 15;
                this.TitleLabel.Text = "Create Reminder";
                //
                // ExtendButton
                //
                this.ExtendButton.BackColor = System.Drawing.Color.Transparent;
                this.ExtendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.ExtendButton.ButtonText = "Extend";
                this.ExtendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ExtendButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.ExtendButton.ForeColor = System.Drawing.Color.Black;
                this.ExtendButton.Location = new System.Drawing.Point(352, 367);
                this.ExtendButton.Margin = new System.Windows.Forms.Padding(4);
                this.ExtendButton.Name = "ExtendButton";
                this.ExtendButton.Size = new System.Drawing.Size(96, 40);
                this.ExtendButton.TabIndex = 21;
                this.ExtendButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
                this.ExtendButton.Click += new System.EventHandler(this.ExtendButton_Click);
                //
                // ReminderEditorControl
                //
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
                this.BackColor = System.Drawing.Color.Black;
                this.Controls.Add(this.ExtendButton);
                this.Controls.Add(this.NotesControl);
                this.Controls.Add(this.RecurringTypeControl);
                this.Controls.Add(this.DateControl);
                this.Controls.Add(this.RecurringControl);
                this.Controls.Add(this.NameControl);
                this.Controls.Add(this.TitleLabel);
                this.Name = "ReminderEditorControl";
                this.Size = new System.Drawing.Size(480, 447);
                this.ResumeLayout(false);
                
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
