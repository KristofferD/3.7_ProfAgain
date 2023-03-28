using System;
using System.IO;
using System.Windows.Forms;

namespace TimeTracking
{
    public partial class MainForm : Form
    {
        // Declare the clock and activity timers
        private ClockDisplay _clockDisplay;
        private System.Windows.Forms.Timer _researchTimer;
        private System.Windows.Forms.Timer _teachingTimer;
        private System.Windows.Forms.Timer _lunchTimer;

        // Declare the labels
        private Label _researchLabel;
        private Label _teachingLabel;
        private Label _lunchLabel;
        private Label _currentTimeLabel;
        private Label _goHomeLabel;

        // Declare the buttons
        private Button _researchButton;
        private Button _teachingButton;
        private Button _lunchButton;
        private Button _saveButton;

        // Declare the checkbox
        private CheckBox _showSecondsCheckBox;

        // Declare the message label
        private Label _messageLabel;


        public MainForm()
        {
            InitializeComponent();

            // Initialize the clock and activity timers
            _clockDisplay = new ClockDisplay(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, false);
            _researchTimer = new System.Windows.Forms.Timer();
            _teachingTimer = new System.Windows.Forms.Timer();
            _lunchTimer = new System.Windows.Forms.Timer();

            // Initialize the labels
            _researchLabel = new Label();
            _teachingLabel = new Label();
            _lunchLabel = new Label();
            _currentTimeLabel = new Label();
            _goHomeLabel = new Label();

            // Initialize the buttons
            _researchButton = new Button();
            _teachingButton = new Button();
            _lunchButton = new Button();
            _saveButton = new Button();

            // Initialize the checkbox
            _showSecondsCheckBox = new CheckBox();

            // Initialize the message label
            _messageLabel = new Label();
        }

        // Handle the ResearchButton Click event
        private void ResearchButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement the ResearchButton Click event handler
        }

        // Handle the TeachingButton Click event
        private void TeachingButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement the TeachingButton Click event handler
        }

        // Handle the LunchButton Click event
        private void LunchButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement the LunchButton Click event handler
        }

        // Handle the SaveButton Click event
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement the SaveButton Click event handler
        }

        // Handle the ShowSecondsCheckBox CheckedChanged event
        private void ShowSecondsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: Implement the ShowSecondsCheckBox CheckedChanged event handler
        }

        // Handle the clockTimer Tick event
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            // TODO: Implement the clockTimer Tick event handler
        }
    }
}
