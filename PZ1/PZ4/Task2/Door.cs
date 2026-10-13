
namespace PZ4.Task2
{
    internal class Door : ISwitchable
    {
        private bool _isOpen;

        public Door()
        {
            _isOpen = false;
        }

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
