namespace Sensors.Models
{
    public class Sensor
    {
        public string Type;

        public Sensor(string type)
        {
            Type = type;
        }

        public bool Activate(Dictionary<string, int> exposureSensors)
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
