using System;
using TimeTracking;

namespace TimeTracking
{
    class ClockDisplay
    {
        private NumberDisplay _hours;
        private NumberDisplay _minutes;
        private NumberDisplay _seconds;
        private bool _showSeconds;
        private Label _label;

        public ClockDisplay(bool showSeconds)
        {
            _hours = new NumberDisplay(24, 0);
            _minutes = new NumberDisplay(60, 0);
            _seconds = new NumberDisplay(60, 0);
            _showSeconds = showSeconds;
        }

        public bool ShowSeconds { get; set; }

        public Label Label
        {
            get { return _label; }
            set { _label = value; }
        }


        public ClockDisplay(int hour, int minute, int second, bool showSeconds)
        {
            _hours = new NumberDisplay(hour, 24);
            _minutes = new NumberDisplay(minute, 60);
            _seconds = new NumberDisplay(second, 60);
            _showSeconds = showSeconds;
        }

        public void TimeTick()
        {
            _seconds.Increment();
            if (_seconds.Number == 0)
            {
                _minutes.Increment();
                if (_minutes.Number == 0)
                {
                    _hours.Increment();
                }
            }
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            if (_label != null)
            {
                if (_showSeconds)
                {
                    _label.Text = $"{_hours.GetValue():D2}:{_minutes.GetValue():D2}:{_seconds.GetValue():D2}";
                }
                else
                {
                    _label.Text = $"{_hours.GetValue():D2}:{_minutes.GetValue():D2}";
                }
            }
        }

        public void SetTime(int hour, int minute, int second)
        {
            _hours.Number = hour;
            _minutes.Number = minute;
            _seconds.Number = second;
        }

        public string GetTime()
        {
            string timeString = _hours.GetDisplayNumber() + ":" + _minutes.GetDisplayNumber();
            if (_showSeconds)
            {
                timeString += ":" + _seconds.GetDisplayNumber();
            }
            return timeString;
        }

    }
}
