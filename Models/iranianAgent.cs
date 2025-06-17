namespace Sensors.Models
{
    public class IranianAgent
    {
        string Rank;
        int SumSensorsForExposure;
        private Dictionary<string, int> ExposureSensors { get; }

        public IranianAgent(int sumSensorsForExposure, string rank = "Junior")
        {
            Rank = rank;
            SumSensorsForExposure = sumSensorsForExposure;
            ExposureSensors = CreateRandomExposureSensors();
        }

        public Dictionary<string, int> CreateRandomExposureSensors()
        {
            Random random = new Random();
            Dictionary<string, int> myExposureSensors = new Dictionary<string, int>
            {
                { "Thermal", 0 },
                { "Motion", 0 },
                { "Cellular", 0 }
            };

            string[] types = { "Thermal", "Motion", "Cellular" };
            while (myExposureSensors.Values.Sum() < SumSensorsForExposure)
            {
                int randTypes = random.Next(0, types.Length);
                myExposureSensors[types[randTypes]] += 1;
            }
            return myExposureSensors;
        }

        public Dictionary<string, int> GetExposureSensors()
        {
            return ExposureSensors;
        }
    }
}
