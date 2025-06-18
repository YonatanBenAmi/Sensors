using Sensors.ENUM;
using Sensors.Interface;
using Sensors.Models;

namespace Sensors.Factory
{
    public class SensorFactory
    {
        public static Sensor CreateSensor(SensorType type)
        {
            Sensor sensor = null!;

            switch (type)
            {
                case SensorType.Cellular:
                    sensor = new Sensor(SensorType.Cellular);
                    break;
                case SensorType.Motion:
                    sensor = new Sensor(SensorType.Motion);
                    break;
                case SensorType.Thermal:
                    sensor = new Sensor(SensorType.Thermal);
                    break;
            }
            return sensor;
        }
    }
}