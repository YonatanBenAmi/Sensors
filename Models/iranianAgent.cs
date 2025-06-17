using Sensors.ENUM;

namespace Sensors.Models
{
    public class IranianAgent
    {
        string Rank;
        public int SensorsForExposure { get; }
        private Dictionary<SensorType, int> ExposureSensors { get; }
        public List<Sensor> AttachedSensors { get; private set; }

        public IranianAgent(string rank = "Junior")
        {
            Rank = rank;
            SensorsForExposure = 2;
            ExposureSensors = CreateRandomExposureSensors();
            AttachedSensors = new List<Sensor>();
        }

        Dictionary<SensorType, int> CreateRandomExposureSensors()
        {
            Random random = new Random();
            Dictionary<SensorType, int> myExposureSensors = new Dictionary<SensorType, int>
            {
                { SensorType.Thermal, 0 },
                { SensorType.Motion, 0 },
                { SensorType.Cellular, 0 }
            };

            SensorType[] types = { SensorType.Thermal, SensorType.Motion, SensorType.Cellular };
            while (myExposureSensors.Values.Sum() < SensorsForExposure)
            {
                int randTypes = random.Next(0, types.Length);
                myExposureSensors[types[randTypes]] += 1;
            }
            return myExposureSensors;
        }

        public Dictionary<SensorType, int> GetExposureSensors()
        {
            return ExposureSensors;
        }

        public int AttachAndActivateSensor(Sensor sensor)
        {
            AttachedSensors.Add(sensor);

            if (ExposureSensors.ContainsKey(sensor.Type) && ExposureSensors[sensor.Type] > 0)
            {
                ExposureSensors[sensor.Type]--;
                return 1;
            }
            return 0;
        }

    }
}
