
namespace PZ4.Task2
{
    internal class Robot : ISwitchable
    {
        private bool _isOn;
        public void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Robot is off.");

        }

        public void TurnOn()
        {
            _isOn = true;
            Console.WriteLine("Robot is on.");
        }
    }
}
