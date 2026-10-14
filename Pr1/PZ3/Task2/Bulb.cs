

namespace PZ3.Task2
{
    internal class Bulb: ISwitcheable
    {
        private bool _isOn;
        public Bulb()
        {
            _isOn = false;
        }
        public void TurnOn()
        {
            _isOn = true;
            Console.WriteLine("Bulb is ON.");
        }
        public void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Bulb is OFF.");
        }
    }
}
