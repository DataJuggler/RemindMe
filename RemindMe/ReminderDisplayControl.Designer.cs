namespace RemindMe
{
    partial class ReminderDisplayControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            this.DueDateLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            this.BottomMarginPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.ButtonPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.DeleteButton = new DataJuggler.Win.Controls.Button();
            this.panelExtender4 = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.ExtendButton = new DataJuggler.Win.Controls.Button();
            this.panelExtender3 = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.NoteControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.LabelColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.LabelText = "Title:";
            this.TitleLabel.LabelWidth = 100;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(854, 28);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.ValueLabelColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.ValueLabelFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DueDateLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DueDateLabel.LabelColor = System.Drawing.SystemColors.ControlText;
            this.DueDateLabel.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DueDateLabel.LabelText = "Due Date:";
            this.DueDateLabel.LabelWidth = 100;
            this.DueDateLabel.Location = new System.Drawing.Point(0, 28);
            this.DueDateLabel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(854, 28);
            this.DueDateLabel.TabIndex = 1;
            this.DueDateLabel.ValueLabelColor = System.Drawing.SystemColors.ControlText;
            this.DueDateLabel.ValueLabelFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // BottomMarginPanel
            // 
            this.BottomMarginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomMarginPanel.Location = new System.Drawing.Point(0, 140);
            this.BottomMarginPanel.MaximumSize = new System.Drawing.Size(854, 8);
            this.BottomMarginPanel.Name = "BottomMarginPanel";
            this.BottomMarginPanel.Size = new System.Drawing.Size(854, 8);
            this.BottomMarginPanel.TabIndex = 6;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.DeleteButton);
            this.ButtonPanel.Controls.Add(this.panelExtender4);
            this.ButtonPanel.Controls.Add(this.ExtendButton);
            this.ButtonPanel.Controls.Add(this.panelExtender3);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 98);
            this.ButtonPanel.MaximumSize = new System.Drawing.Size(854, 42);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(854, 42);
            this.ButtonPanel.TabIndex = 8;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.ButtonText = "Delete";
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(638, 0);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.MaximumSize = new System.Drawing.Size(100, 42);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 42);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // panelExtender4
            // 
            this.panelExtender4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelExtender4.Location = new System.Drawing.Point(738, 0);
            this.panelExtender4.Name = "panelExtender4";
            this.panelExtender4.Size = new System.Drawing.Size(8, 42);
            this.panelExtender4.TabIndex = 14;
            // 
            // ExtendButton
            // 
            this.ExtendButton.BackColor = System.Drawing.Color.Transparent;
            this.ExtendButton.ButtonText = "Extend";
            this.ExtendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExtendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtendButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExtendButton.ForeColor = System.Drawing.Color.Black;
            this.ExtendButton.Location = new System.Drawing.Point(746, 0);
            this.ExtendButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ExtendButton.MaximumSize = new System.Drawing.Size(100, 42);
            this.ExtendButton.Name = "ExtendButton";
            this.ExtendButton.Size = new System.Drawing.Size(100, 42);
            this.ExtendButton.TabIndex = 13;
            this.ExtendButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Wood;
            this.ExtendButton.Click += new System.EventHandler(this.ExtendButton_Click);
            // 
            // panelExtender3
            // 
            this.panelExtender3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelExtender3.Location = new System.Drawing.Point(846, 0);
            this.panelExtender3.Name = "panelExtender3";
            this.panelExtender3.Size = new System.Drawing.Size(8, 42);
            this.panelExtender3.TabIndex = 12;
            // 
            // NoteControl
            // 
            this.NoteControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteControl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoteControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.NoteControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoteControl.LabelText = "Note:";
            this.NoteControl.LabelWidth = 100;
            this.NoteControl.Location = new System.Drawing.Point(0, 56);
            this.NoteControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NoteControl.MaximumSize = new System.Drawing.Size(854, 62);
            this.NoteControl.Name = "NoteControl";
            this.NoteControl.Size = new System.Drawing.Size(854, 42);
            this.NoteControl.TabIndex = 9;
            this.NoteControl.ValueLabelColor = System.Drawing.SystemColors.ControlText;
            this.NoteControl.ValueLabelFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // ReminderDisplayControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NoteControl);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.BottomMarginPanel);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ReminderDisplayControl";
            this.Size = new System.Drawing.Size(854, 148);
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelLabelControl TitleLabel;
        private LabelLabelControl DueDateLabel;
        private DataJuggler.Win.Controls.Objects.PanelExtender BottomMarginPanel;
        private DataJuggler.Win.Controls.Objects.PanelExtender ButtonPanel;
        private DataJuggler.Win.Controls.Button DeleteButton;
        private DataJuggler.Win.Controls.Objects.PanelExtender panelExtender4;
        private DataJuggler.Win.Controls.Button ExtendButton;
        private DataJuggler.Win.Controls.Objects.PanelExtender panelExtender3;
        private LabelLabelControl NoteControl;
    }
}
