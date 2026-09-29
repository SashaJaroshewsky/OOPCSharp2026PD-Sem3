using System;
using System.Collections.Generic;
using System.Text;

namespace PZ3
{
    internal class Build
    {
        private int _floor;

        private DateTime _dateTime;

        public Build()
        {
            _floor = 5;
            _dateTime = DateTime.Now;
        }

        public Build(int floor)
        {
            _floor = floor;
            _dateTime = DateTime.Now;
        }

        public void Show()
        {
            Console.WriteLine($"{_floor} {_dateTime}");
        }
        public void Show(string s)
        {
            Console.WriteLine($"{s} {_floor} {_dateTime}");
        }

        public void BuildFloor()
        {
            _floor++;
        }

    }
}
