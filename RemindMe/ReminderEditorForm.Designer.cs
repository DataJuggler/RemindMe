namespace RemindMe
{
    partial class ReminderEditorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderEditorForm));
            this.SaveCancelControl = new DataJuggler.Win.Controls.SaveCancelControl();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.RemindersListControl = new DataJuggler.Win.Controls.ListEditorControl();
            this.ReminderEditor = new RemindMe.ReminderEditorControl();
            this.SuspendLayout();
            // 
            // SaveCancelControl
            // 
            this.SaveCancelControl.BackColor = System.Drawing.Color.Transparent;
            this.SaveCancelControl.CancelButtonWidth = 80;
            this.SaveCancelControl.DisabledForeColor = System.Drawing.Color.DarkGray;
            this.SaveCancelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveCancelControl.DoneMode = true;
            this.SaveCancelControl.EnableCancelSaveButton = false;
            this.SaveCancelControl.EnableSaveAndCloseButton = false;
            this.SaveCancelControl.EnableSaveButton = false;
            this.SaveCancelControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveCancelControl.Location = new System.Drawing.Point(0, 568);
            this.SaveCancelControl.Name = "SaveCancelControl";
            this.SaveCancelControl.SaveAndCloseButtonWidth = 0;
            this.SaveCancelControl.SaveButtonWidth = 80;
            this.SaveCancelControl.ShowSaveAndCloseButton = false;
            this.SaveCancelControl.ShowSaveButton = true;
            this.SaveCancelControl.Size = new System.Drawing.Size(800, 52);
            this.SaveCancelControl.TabIndex = 12;
            this.SaveCancelControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(0, 407);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(800, 161);
            this.StatusLabel.TabIndex = 14;
            // 
            // RemindersListControl
            // 
            this.RemindersListControl.AllItemsLabelColor = System.Drawing.Color.LemonChiffon;
            this.RemindersListControl.AllItemsLabelText = "All Reminders";
            this.RemindersListControl.BackColor = System.Drawing.Color.Transparent;
            this.RemindersListControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemindersListControl.BottomMargin = 16;
            this.RemindersListControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.RemindersListControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemindersListControl.LeftMargin = 16;
            this.RemindersListControl.List = null;
            this.RemindersListControl.ListEditorWidth = 320;
            this.RemindersListControl.Location = new System.Drawing.Point(0, 0);
            this.RemindersListControl.Name = "RemindersListControl";
            this.RemindersListControl.ParentListEditorHost = null;
            this.RemindersListControl.RightMargin = 16;
            this.RemindersListControl.SaveControl = null;
            this.RemindersListControl.ShowAllItemsLabel = true;
            this.RemindersListControl.ShowBackgroundImage = false;
            this.RemindersListControl.ShowSelectedControlPanel = false;
            this.RemindersListControl.Size = new System.Drawing.Size(320, 407);
            this.RemindersListControl.Sorted = true;
            this.RemindersListControl.TabIndex = 15;
            this.RemindersListControl.TopMargin = 16;
            this.RemindersListControl.WidthFullControl = 720;
            // 
            // ReminderEditor
            // 
            this.ReminderEditor.BackColor = System.Drawing.Color.Black;
            this.ReminderEditor.Enabled = false;
            this.ReminderEditor.Location = new System.Drawing.Point(316, 18);
            this.ReminderEditor.Name = "ReminderEditor";
            this.ReminderEditor.Size = new System.Drawing.Size(480, 438);
            this.ReminderEditor.TabIndex = 16;
            this.ReminderEditor.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
            // 
            // ReminderEditorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::RemindMe.Properties.Resources.BlackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.ReminderEditor);
            this.Controls.Add(this.RemindersListControl);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SaveCancelControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReminderEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remind Me";
            this.ResumeLayout(false);

        }

        #endregion
        private DataJuggler.Win.Controls.SaveCancelControl SaveCancelControl;
        private Label StatusLabel;
        private DataJuggler.Win.Controls.ListEditorControl RemindersListControl;
        private ReminderEditorControl ReminderEditor;
    }
}