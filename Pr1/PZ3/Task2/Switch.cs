
namespace PZ3.Task2
{
    internal class Switch
    {
        private bool _isOn;

        private ISwitcheable _switcheable;

        public Switch(ISwitcheable switcheable)
        {
            _switcheable = switcheable;
            _isOn = false;
        }

        public void Toggle()
        {
            if (_isOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }

        private void TurnOn()
        {
            _isOn = true;
            Console.WriteLine("Switch is ON.");
           _switcheable.TurnOn();
        }

        private void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Switch is OFF.");
            _switcheable.TurnOff();
        }
    }
}
