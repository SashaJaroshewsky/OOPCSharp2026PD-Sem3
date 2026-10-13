
namespace PZ4.Task2
{
    internal class Switch
    {
        private bool _isOn;

        private ISwitchable _switchable;

        public Switch(ISwitchable switchable)
        {
            _isOn = false;
            _switchable = switchable;
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
            Console.WriteLine("Switch is on.");
            _switchable.TurnOn();
        }
        private void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Switch is off.");
           _switchable.TurnOff();
        }
    }
}
