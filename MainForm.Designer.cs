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
            this.components = new System.ComponentModel.Container();
            this._researchButton = new System.Windows.Forms.Button();
            this._teachingButton = new System.Windows.Forms.Button();
            this._lunchButton = new System.Windows.Forms.Button();
            this._researchLabel = new System.Windows.Forms.Label();
            this._teachingLabel = new System.Windows.Forms.Label();
            this._lunchLabel = new System.Windows.Forms.Label();
            this._currentTimeLabel = new System.Windows.Forms.Label();
            this._showSecondsCheckBox = new System.Windows.Forms.CheckBox();
            this._saveButton = new System.Windows.Forms.Button();
            this._goHomeLabel = new System.Windows.Forms.Label();
            this._messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // _researchButton
            // 
            this._researchButton.Location = new System.Drawing.Point(12, 26);
            this._researchButton.Name = "_researchButton";
            this._researchButton.Size = new System.Drawing.Size(75, 23);
            this._researchButton.TabIndex = 0;
            this._researchButton.Text = "Forskning";
            this._researchButton.UseVisualStyleBackColor = true;
            this._researchButton.Click += new System.EventHandler(this.ResearchButton_Click);
            // 
            // _teachingButton
            // 
            this._teachingButton.Location = new System.Drawing.Point(12, 76);
            this._teachingButton.Name = "_teachingButton";
            this._teachingButton.Size = new System.Drawing.Size(75, 23);
            this._teachingButton.TabIndex = 1;
            this._teachingButton.Text = "Undervisning";
            this._teachingButton.UseVisualStyleBackColor = true;
            this._teachingButton.Click += new System.EventHandler(this.TeachingButton_Click);
            // 
            // _lunchButton
            // 
            this._lunchButton.Location = new System.Drawing.Point(12, 126);
            this._lunchButton.Name = "_lunchButton";
            this._lunchButton.Size = new System.Drawing.Size(75, 23);
            this._lunchButton.TabIndex = 2;
            this._lunchButton.Text = "Lunch";
            this._lunchButton.UseVisualStyleBackColor = true;
            this._lunchButton.Click += new System.EventHandler(this.LunchButton_Click);
            // 
            // _researchLabel
            // 
            this._researchLabel.AutoSize = true;
            this._researchLabel.Location = new System.Drawing.Point(108, 31);
            this._researchLabel.Name = "_researchLabel";
            this._researchLabel.Size = new System.Drawing.Size(62, 13);
            this._researchLabel.TabIndex = 3;
            this._researchLabel.Text = "00:00:00";
            // 
            // _teachingLabel
            // 
            this._teachingLabel.AutoSize = true;
            this._teachingLabel.Location = new System.Drawing.Point(108, 81);
            this._teachingLabel.Name = "_teachingLabel";
            this._teachingLabel.Size = new System.Drawing.Size(62, 13);
            this._teachingLabel.TabIndex = 4;
            this._teachingLabel.Text = "00:00:00";
            //
            // _lunchLabel
            // 
            this._lunchLabel.AutoSize = true;
            this._lunchLabel.Location = new System.Drawing.Point(108, 131);
            this._lunchLabel.Name = "_lunchLabel";
            this._lunchLabel.Size = new System.Drawing.Size(62, 13);
            this._lunchLabel.TabIndex = 5;
            this._lunchLabel.Text = "00:00:00";
            // _currentTimeLabel
            // 
            this._currentTimeLabel.AutoSize = true;
            this._currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._currentTimeLabel.Location = new System.Drawing.Point(221, 41);
            this._currentTimeLabel.Name = "_currentTimeLabel";
            this._currentTimeLabel.Size = new System.Drawing.Size(130, 29);
            this._currentTimeLabel.TabIndex = 6;
            this._currentTimeLabel.Text = "00:00:00";
            // _showSecondsCheckBox
            // 
            this._showSecondsCheckBox.AutoSize = true;
            this._showSecondsCheckBox.Location = new System.Drawing.Point(226, 81);
            this._showSecondsCheckBox.Name = "_showSecondsCheckBox";
            this._showSecondsCheckBox.Size = new System.Drawing.Size(97, 17);
            this._showSecondsCheckBox.TabIndex = 7;
            this._showSecondsCheckBox.Text = "Visa sekunder";
            this._showSecondsCheckBox.UseVisualStyleBackColor = true;
            this._showSecondsCheckBox.CheckedChanged += new System.EventHandler(this.ShowSecondsCheckBox_CheckedChanged);
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(226, 126);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(75, 23);
            this._saveButton.TabIndex = 8;
            this._saveButton.Text = "Spara";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // _goHomeLabel
            // 
            this._goHomeLabel.AutoSize = true;
            this._goHomeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this._goHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._goHomeLabel.Location = new System.Drawing.Point(390, 9);
            this._goHomeLabel.Name = "_goHomeLabel";
            this._goHomeLabel.Size = new System.Drawing.Size(81, 20);
            this._goHomeLabel.TabIndex = 9;
            this._goHomeLabel.Text = "Gå hem ->";
            this._goHomeLabel.Click += new System.EventHandler(this.GoHomeLabel_Click);
            // _messageLabel
            // 
            this._messageLabel.AutoSize = true;
            this._messageLabel.Location = new System.Drawing.Point(12, 173);
            this._messageLabel.Name = "_messageLabel";
            this._messageLabel.Size = new System.Drawing.Size(0, 13);
            this._messageLabel.TabIndex = 10;
            //MainForm
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
