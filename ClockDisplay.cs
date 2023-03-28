﻿using System;
using TimeTracking;

namespace TimeTracking
{
    class ClockDisplay
    {
        private NumberDisplay _hours;
        private NumberDisplay _minutes;
        private NumberDisplay _seconds;
        private bool _showSeconds;

        public ClockDisplay(bool showSeconds)
        {
            _hours = new NumberDisplay(24, 0);
            _minutes = new NumberDisplay(60, 0);
            _seconds = new NumberDisplay(60, 0);
            _showSeconds = showSeconds;
        }

        public ClockDisplay(int hour, int minute, int second, bool showSeconds)
        {
            _hours = new NumberDisplay(24, hour);
            _minutes = new NumberDisplay(60, minute);
            _seconds = new NumberDisplay(60, second);
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