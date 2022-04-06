namespace RemindMe
{
    partial class DisplayRemindersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayRemindersForm));
            this.SaveCancelControl = new DataJuggler.Win.Controls.SaveCancelControl();
            this.RemindersPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.SuspendLayout();
            // 
            // saveCancelControl1
            // 
            this.SaveCancelControl.BackColor = System.Drawing.Color.Transparent;
            this.SaveCancelControl.CancelButtonWidth = 88;
            this.SaveCancelControl.DisabledForeColor = System.Drawing.Color.DarkGray;
            this.SaveCancelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveCancelControl.DoneMode = true;
            this.SaveCancelControl.EnableCancelSaveButton = false;
            this.SaveCancelControl.EnableSaveAndCloseButton = false;
            this.SaveCancelControl.EnableSaveButton = false;
            this.SaveCancelControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveCancelControl.Location = new System.Drawing.Point(0, 549);
            this.SaveCancelControl.Name = "saveCancelControl1";
            this.SaveCancelControl.SaveAndCloseButtonWidth = 140;
            this.SaveCancelControl.SaveButtonWidth = 88;
            this.SaveCancelControl.ShowSaveAndCloseButton = false;
            this.SaveCancelControl.ShowSaveButton = false;
            this.SaveCancelControl.Size = new System.Drawing.Size(784, 52);
            this.SaveCancelControl.TabIndex = 0;
            this.SaveCancelControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // RemindersPanel
            // 
            this.RemindersPanel.BackColor = System.Drawing.Color.Transparent;
            this.RemindersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemindersPanel.Location = new System.Drawing.Point(0, 0);
            this.RemindersPanel.Name = "RemindersPanel";
            this.RemindersPanel.Size = new System.Drawing.Size(784, 549);
            this.RemindersPanel.TabIndex = 1;
            // 
            // DisplayRemindersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::RemindMe.Properties.Resources.BlackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.RemindersPanel);
            this.Controls.Add(this.SaveCancelControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisplayRemindersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overdue Reminders";
            this.ResumeLayout(false);

        }

        #endregion

        private SaveCancelControl SaveCancelControl;
        private DataJuggler.Win.Controls.Objects.PanelExtender RemindersPanel;
    }
}