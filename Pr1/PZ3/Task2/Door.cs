using System;
using System.Collections.Generic;
using System.Text;

namespace PZ3.Task2
{
    internal class Door : ISwitcheable
    {
        private bool _isOpen;
        public bool IsOpen => _isOpen;

        public void Open()
        {
            _isOpen = true;
            Console.WriteLine("Door is open.");
        }

        public void Close()
        {
            _isOpen = false;
            Console.WriteLine("Door is closed.");
        }

        public void TurnOn()
        {
            Open();
        }

        public void TurnOff()
        {
            Close();
        }
    }
}
