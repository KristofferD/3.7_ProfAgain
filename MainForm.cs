using System;
using System.IO;
using System.Windows.Forms;

namespace TimeTracking
{
    public partial class MainForm : Form
    {
        // Declare the clock and activity timers
        private readonly System.Windows.Forms.Timer _clockTimer = new System.Windows.Forms.Timer();
        private readonly System.Windows.Forms.Timer _researchTimer = new System.Windows.Forms.Timer();
        private readonly System.Windows.Forms.Timer _teachingTimer = new System.Windows.Forms.Timer();
        private readonly System.Windows.Forms.Timer _lunchTimer = new System.Windows.Forms.Timer();
        private TimeSpan _researchTime = TimeSpan.Zero;
        private TimeSpan _teachingTime = TimeSpan.Zero;
        private TimeSpan _lunchTime = TimeSpan.Zero;
        private TimeSpan _currentTime = TimeSpan.Zero;

        // Declare the labels
        private Label _researchLabel;
        private Label _teachingLabel;
        private Label _lunchLabel;
        private Label _currentTimeLabel;
        private Label _goHomeLabel;
        private Label _clockDisplay;
        private Label _researchClockDisplay;
        private Label _teachingClockDisplay;
        private Label _lunchClockDisplay;



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

            // Set the form title
            this.Text = "Time Tracking Application";

            // Set the form size
            this.ClientSize = new Size(400, 300);

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

            // Set the location of the labels
            _currentTimeLabel.Location = new Point(this.ClientSize.Width / 2 - _currentTimeLabel.Width / 2, 25);
            _researchLabel.Location = new Point(25, 75);
            _teachingLabel.Location = new Point(25, 100);
            _lunchLabel.Location = new Point(25, 125);
            _goHomeLabel.Location = new Point(this.ClientSize.Width / 2 - _goHomeLabel.Width / 2, 200);
            _messageLabel.Location = new Point(this.ClientSize.Width / 2 - _messageLabel.Width / 2, 250);

            // Set the location and text of the buttons
            _lunchButton.Location = new Point(25, 75);
            _lunchButton.Text = "Lunch";
            _teachingButton.Location = new Point(25, 100);
            _teachingButton.Text = "Undervisning";
            _researchButton.Location = new Point(25, 125);
            _researchButton.Text = "Forskning";
            _saveButton.Location = new Point(25, 150);
            _saveButton.Text = "Spara";

            // Set the location and text of the checkbox
            _showSecondsCheckBox.Location = new Point(25, 175);
            _showSecondsCheckBox.Text = "Visa sekunder";

            // Set the location of the diod label
            _goHomeLabel.Location = new Point(this.ClientSize.Width / 2 - _goHomeLabel.Width / 2, 200);

            // Set the font and alignment of the message label
            _messageLabel.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            _messageLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Set the visibility of the message label
            _messageLabel.Visible = false;

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

           /* // Initialize the buttons
            _researchButton = new Button();
            _teachingButton = new Button();
            _lunchButton = new Button();
            _saveButton = new Button();*/

            // Create a new CheckBox control
            _showSecondsCheckBox = new CheckBox();

            // Set the location and size of the CheckBox control
            _showSecondsCheckBox.Location = new System.Drawing.Point(25, 125);
            _showSecondsCheckBox.Size = new System.Drawing.Size(150, 25);

            // Set the text of the CheckBox control
            _showSecondsCheckBox.Text = "Visa sekunder";

            // Add the CheckedChanged event handler for the CheckBox control
            _showSecondsCheckBox.CheckedChanged += ShowSecondsCheckBox_CheckedChanged;

            // Add the CheckBox control to the form
            Controls.Add(_showSecondsCheckBox);

            // Create a new Label control
            _messageLabel = new Label();

            // Set the location and size of the Label control
            _messageLabel.Location = new System.Drawing.Point(25, 175);
            _messageLabel.Size = new System.Drawing.Size(250, 25);

            // Set the text of the Label control
            _messageLabel.Text = "Total tid för forskning och undervisning överstiger 8 timmar!";

            // Set the Font property of the Label control
            _messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);

            // Set the ForeColor property of the Label control
            _messageLabel.ForeColor = System.Drawing.Color.Red;

            // Set the Visible property of the Label control to false
            _messageLabel.Visible = false;

            // Add the Label control to the form
            Controls.Add(_messageLabel);


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

        private void GoHomeLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Time to go home!", "Go Home", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResearchTimer_Tick(object sender, EventArgs e)
        {
            _researchClock--;
            if (_researchClock == 0)
            {
                _researchTimer.Stop();
                MessageBox.Show("Research time is over!");
            }
            else
            {
                _researchClockDisplay.Text = _researchClock.ToString();
            }
        }

        private void TeachingTimer_Tick(object sender, EventArgs e)
        {
            _teachingClock--;
            if (_teachingClock == 0)
            {
                _teachingTimer.Stop();
                MessageBox.Show("Teaching time is over!");
            }
            else
            {
                _teachingClockDisplay.Text = _teachingClock.ToString();
            }
        }

        private void LunchTimer_Tick(object sender, EventArgs e)
        {
            _lunchClock--;
            if (_lunchClock == 0)
            {
                _lunchTimer.Stop();
                MessageBox.Show("Lunch time is over!");
            }
            else
            {
                _lunchClockDisplay.Text = _lunchClock.ToString();
            }
        }


        private void InitializeTimers()
        {
            _researchTimer.Interval = 1000; // set the interval to 1 second
            _researchTimer.Tick += ResearchTimer_Tick;

            _teachingTimer.Interval = 1000; // set the interval to 1 second
            _teachingTimer.Tick += TeachingTimer_Tick;

            _lunchTimer.Interval = 1000; // set the interval to 1 second
            _lunchTimer.Tick += LunchTimer_Tick;

            _clockTimer.Interval = 1000; // set the interval to 1 second
            _clockTimer.Tick += ClockTimer_Tick;
            _clockTimer.Start(); // start the timer
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