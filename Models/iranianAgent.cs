using Sensors.ENUM;
using Sensors.Factory;

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
            ExposureSensors = AgentFactory.CreateRandomExposureSensors(SensorsForExposure);
            AttachedSensors = new List<Sensor>();
        }

        public int GetSensorsForExposure()
        {
            return SensorsForExposure;
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
