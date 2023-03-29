using System;
using System.IO;
using System.Windows.Forms;

namespace TimeTracking
{
    public partial class MainForm : Form
    {
        // Declare the clock and activity timers
        private ClockDisplay? _clockDisplay;
        private ClockDisplay? _researchClockDisplay;
        private ClockDisplay? _teachingClockDisplay;
        private ClockDisplay? _lunchClockDisplay;
        private System.Windows.Forms.Timer _clockTimer;
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

        // Declare the counters for research, teaching, and lunch
        private int _researchCounter;
        private int _teachingCounter;
        private int _lunchCounter;

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Create a new instance of the ClockDisplay class
            _clockDisplay = new ClockDisplay(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, true);

            // Set the text of the label control to the current time
            _currentTimeLabel.Text = _clockDisplay.GetTime();
        }

        private void CreateAndStartClockTimer()
        {
            // Create a timer to update the current time every second
            System.Windows.Forms.Timer clockTimer = new System.Windows.Forms.Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;

            // Start the timer
            clockTimer.Start();
        }
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            // Update the current time label with the current time
            _currentTimeLabel.Text = GetTimeString(DateTime.Now);
        }

        private string GetTimeString(DateTime time)
        {
            // Get the current time as a string in the format HH:mm:ss
            return time.ToString("HH:mm:ss");
        }

        public MainForm()
        {
            InitializeComponent();

            // Initialize the clock and activity timers
            _clockDisplay = new ClockDisplay(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, true);
            _clockTimer = new System.Windows.Forms.Timer();
            _researchTimer = new System.Windows.Forms.Timer();
            _teachingTimer = new System.Windows.Forms.Timer();
            _lunchTimer = new System.Windows.Forms.Timer();
            _clockTimer.Interval = 1000;
            _researchTimer.Interval = 1000;
            _teachingTimer.Interval = 1000;
            _lunchTimer.Interval = 1000;
            _clockTimer.Tick += clockTimer_Tick;
            _researchTimer.Tick += researchTimer_Tick;
            _teachingTimer.Tick += teachingTimer_Tick;
            _lunchTimer.Tick += lunchTimer_Tick;
            _researchClockDisplay = new ClockDisplay(0, 0, 0, true);
            _teachingClockDisplay = new ClockDisplay(0, 0, 0, true);
            _lunchClockDisplay = new ClockDisplay(0, 0, 0, true);

            // Initialize the labels
            _researchLabel = new Label();
            _teachingLabel = new Label();
            _lunchLabel = new Label();
            _currentTimeLabel = new Label();
            _goHomeLabel = new Label();

            // Initialize the clock display
            _clockDisplay = new ClockDisplay(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, true);

            // Set the label control for the clock display
            _clockDisplay.Label = _currentTimeLabel;

            // Start the timer to update the clock display every second
            _clockTimer.Start();

            // Set the text of the message label
            _goHomeLabel.Text = "Åk HEM!!!";

            // Set the labels for the activity displays
            _researchClockDisplay.Label = _researchLabel;
            _teachingClockDisplay.Label = _teachingLabel;
            _lunchClockDisplay.Label = _lunchLabel;

            // Initialize the buttons
            _researchButton = new Button();
            _teachingButton = new Button();
            _lunchButton = new Button();
            _saveButton = new Button();

            // Initialize the checkbox
            _showSecondsCheckBox = new CheckBox();

            // Initialize the message label
            _messageLabel = new Label();

            // Set the initial values of the counters
            _researchCounter = 0;
            _teachingCounter = 0;
            _lunchCounter = 0;

            // Set the labels of the ClockDisplay objects
            _researchLabel = _researchClockDisplay?.Label;
            _teachingLabel = _teachingClockDisplay?.Label;
            _lunchLabel = _lunchClockDisplay?.Label;

            // Set the text of the current time label
            _currentTimeLabel.Text = _clockDisplay.GetTime();

            // Set the text of the message label
            _goHomeLabel.Text = "Åk HEM!!!";
        }

        // Handle the ResearchButton Click event
        private void ResearchButton_Click(object sender, EventArgs e)
        {
            if (!_researchTimer.Enabled)
            {
                _researchTimer.Start();
                _researchButton.Text = "Sluta";
            }
            else
            {
                _researchTimer.Stop();
                _researchButton.Text = "Forskning";
            }
        }

        // Handle the TeachingButton Click event
        private void TeachingButton_Click(object sender, EventArgs e)
        {
            if (_teachingTimer.Enabled)
            {
                _teachingTimer.Stop();
            }
            else
            {
                _teachingTimer.Start();
            }
        }

        // Handle the LunchButton Click event
        private void LunchButton_Click(object sender, EventArgs e)
        {
            if (_lunchTimer.Enabled)
            {
                _lunchTimer.Stop();
            }
            else
            {
                _lunchTimer.Start();
            }
        }

        // Handle the SaveButton Click event
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Get the current date and time
            DateTime now = DateTime.Now;

            // Format the date and time as a string
            string dateTimeString = now.ToString("yyyy-MM-dd HH:mm:ss");

            // Format the research time as a string
            string researchTimeString = _researchClockDisplay.GetTime();

            // Format the teaching time as a string
            string teachingTimeString = _teachingClockDisplay.GetTime();

            // Format the lunch time as a string
            string lunchTimeString = _lunchClockDisplay.GetTime();

            // Create the file name using the current date
            string fileName = now.ToString("yyyy-MM-dd") + ".txt";

            // Create a StreamWriter object to write to the file
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                // Write the date and time to the file
                writer.WriteLine(dateTimeString);

                // Write the research time to the file
                writer.WriteLine("Research: " + researchTimeString);

                // Write the teaching time to the file
                writer.WriteLine("Teaching: " + teachingTimeString);

                // Write the lunch time to the file
                writer.WriteLine("Lunch: " + lunchTimeString);

                // Write a blank line to the file
                writer.WriteLine();
            }
        }

        // Handle the ShowSecondsCheckBox CheckedChanged event
        private void ShowSecondsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _clockDisplay.ShowSeconds = _showSecondsCheckBox.Checked;
        }

        // Handle the clockTimer Tick event
        // Handle the clockTimer Tick event
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            // Update the current time label
            _currentTimeLabel.Text = _clockDisplay?.GetTime();

            // Update the clock display
            _clockDisplay?.TimeTick();

            // Update the message label if the total time spent on research and teaching exceeds 8 hours
            int researchTimeInSeconds = _researchClockDisplay.GetTotalSeconds();
            int teachingTimeInSeconds = _teachingClockDisplay.GetTotalSeconds();
            int totalTimeInSeconds = researchTimeInSeconds + teachingTimeInSeconds;

            if (totalTimeInSeconds >= 8 * 60 * 60) // 8 hours in seconds
            {
                _messageLabel.Visible = true;

                // Blink the message label
                if (DateTime.Now.Second % 2 == 0)
                {
                    _messageLabel.ForeColor = System.Drawing.Color.Black;
                    _goHomeLabel.ForeColor = System.Drawing.Color.Black;
                }
                else
                {
                    _messageLabel.ForeColor = System.Drawing.Color.Red;
                    _goHomeLabel.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                _messageLabel.Visible = false;
            }
        }
        // Handle the ResearchTimer Tick event
        private void researchTimer_Tick(object sender, EventArgs e)
        {
            // Update the research time label
            _researchClockDisplay.TimeTick();
        }

        // Handle the TeachingTimer Tick event
        private void teachingTimer_Tick(object sender, EventArgs e)
        {
            // Update the teaching time label
            _teachingClockDisplay.TimeTick();
        }

        // Handle the LunchTimer Tick event
        private void lunchTimer_Tick(object sender, EventArgs e)
        {
            // Update the lunch time label
            _lunchClockDisplay.TimeTick();
        }
    }
}