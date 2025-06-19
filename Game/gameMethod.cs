using Sensors.Models;
using Sensors.ENUM;

namespace Sensors.Game
{
    public class GameMethod
    {
        public Dictionary<string, SensorType> AvailableSensors = new Dictionary<string, SensorType>
        {
            { "1", SensorType.Thermal },
            { "2", SensorType.Motion },
            { "3", SensorType.Cellular }
        };
        public void Menu()
        {
            Console.WriteLine("\u001b[0mSelect the sensor type.\u001b[0m");
            foreach (var sensor in AvailableSensors)
            {
                Console.WriteLine($"{sensor.Key}) {sensor.Value}");
            }
            Console.Write("\u001b[33mYour choice: ");
        }

    }
}
