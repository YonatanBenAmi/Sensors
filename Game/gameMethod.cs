using Sensors.Models;

namespace Sensors.Game
{
    public class GameMethod
    {
        public void Menu()
        {
            Console.WriteLine("\u001b[0mSelect the sensor type.\u001b[0m");
            Console.WriteLine("1) Thermal");
            Console.WriteLine("2) Motion");
            Console.WriteLine("3) Cellular");
        }

        public int ActivateSingle(Sensor sensor, Dictionary<string, int> exposureSensors)
        {
            return sensor.Activate(exposureSensors) ? 1 : 0;
        }

    }
}
