namespace TimeTracking
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            _researchButton = new Button();
            _teachingButton = new Button();
            _lunchButton = new Button();
            _researchLabel = new Label();
            _teachingLabel = new Label();
            _lunchLabel = new Label();
            _currentTimeLabel = new Label();
            _showSecondsCheckBox = new CheckBox();
            _saveButton = new Button();
            _goHomeLabel = new Label();
            _messageLabel = new Label();
            SuspendLayout();
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(_messageLabel);
            Controls.Add(_goHomeLabel);
            Controls.Add(_saveButton);
            Controls.Add(_showSecondsCheckBox);
            Controls.Add(_currentTimeLabel);
            Controls.Add(_lunchLabel);
            Controls.Add(_teachingLabel);
            Controls.Add(_researchLabel);
            Controls.Add(_lunchButton);
            Controls.Add(_teachingButton);
            Controls.Add(_researchButton);
            Name = "MainForm";
            Text = "Time Tracking";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
