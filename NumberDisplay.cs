using System;

namespace TimeTracking
{
    public class NumberDisplay
    {
        private int _maxNumber;
        private int _number;

        public NumberDisplay() : this(0, 99) { }

        public NumberDisplay(int number, int maxNumber)
        {
            if (number < 0 || number > maxNumber)
            {
                throw new ArgumentException("Invalid argument");
            }

            _number = number;
            _maxNumber = maxNumber;
        }

        public int Number
        {
            get { return _number; }
            set
            {
                if (value < 0 || value > _maxNumber)
                {
                    throw new ArgumentException("Invalid argument");
                }
                _number = value;
            }
        }

        public string GetDisplayNumber()
        {
            return _number < 10 ? "0" + _number.ToString() : _number.ToString();
        }

        public void Increment()
        {
            _number++;
            if (_number > _maxNumber)
            {
                _number = 0;
            }
        }
    }
}
