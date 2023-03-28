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

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._messageLabel);
            this.Controls.Add(this._goHomeLabel);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._showSecondsCheckBox);
            this.Controls.Add(this._currentTimeLabel);
            this.Controls.Add(this._lunchLabel);
            this.Controls.Add(this._teachingLabel);
            this.Controls.Add(this._researchLabel);
            this.Controls.Add(this._lunchButton);
            this.Controls.Add(this._teachingButton);
            this.Controls.Add(this._researchButton);
            this.Name = "MainForm";
            this.Text = "Time Tracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
