using Sensors.ENUM;
namespace Sensors.Models
{
    public class Sensor
    {
        public SensorType Type { get; }

        public Sensor(SensorType type)
        {
            Type = type;
        }

        public bool Activate(Dictionary<SensorType, int> exposureSensors)
        {
            if (exposureSensors.ContainsKey(Type) && exposureSensors[Type] > 0)
            {
                exposureSensors[Type] -= 1;
                return true;
            }
            return false;
        }
    }
}
