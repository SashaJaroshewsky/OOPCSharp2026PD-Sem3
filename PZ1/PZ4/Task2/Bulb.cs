
namespace PZ4.Task2
{
    internal class Bulb: ISwitchable
    {
        private bool _isOn;
        public Bulb()
        {
            _isOn = false;
        }
        public void TurnOn()
        {
            _isOn = true;
            Console.WriteLine("Bulb is on.");
        }
        public void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Bulb is off.");
        }
    }
}
