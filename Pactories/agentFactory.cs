using Sensors.Models;
using Sensors.ENUM;

namespace Sensors.Factory
{
    public class AgentFactory
    {
        public static IranianAgent CreateAgent()
        {
            IranianAgent iranianAgent = new IranianAgent();
            CreateRandomExposureSensors(iranianAgent.SensorsForExposure);
            return iranianAgent;
        }

        public static Dictionary<SensorType, int> CreateRandomExposureSensors(int numSensors)
        {
            Random random = new Random();
            Dictionary<SensorType, int> myExposureSensors = new Dictionary<SensorType, int>
            {
                { SensorType.Thermal, 0 },
                { SensorType.Motion, 0 },
                { SensorType.Cellular, 0 }
            };

            SensorType[] types = { SensorType.Thermal, SensorType.Motion, SensorType.Cellular };
            while (myExposureSensors.Values.Sum() < numSensors)
            {
                int randTypes = random.Next(0, types.Length);
                myExposureSensors[types[randTypes]] += 1;
            }
            return myExposureSensors;
        }
    }
}