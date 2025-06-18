using Sensors.Models;
using Sensors.ENUM;
using Sensors.Factory;

namespace Sensors.Game
{
    public class Gameing
    {
        private static Gameing? instance;
        public static Gameing Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Gameing();
                }
                return instance;
            }
        }
        private Gameing() {}
        public void StartGame()
        {
            
            IranianAgent iranianAgent =AgentFactory.CreateAgent();
            GameMethod gameMethod = new GameMethod();
            string color = "\u001b[36m";
            int found = 0;

            Console.WriteLine($"{color}<<<<<The Sensor Game>>>>>\u001b[0m");

            while (found < iranianAgent.SensorsForExposure)
            {
                gameMethod.Menu();
                string userChoice = Console.ReadLine()!;
                if (!gameMethod.AvailableSensors.ContainsKey(userChoice))
                {
                    Console.WriteLine("\u001b[31mChoiceError\u001b[0m");
                    continue;
                }

                SensorType sensorType = gameMethod.AvailableSensors[userChoice];
                Sensor sensor = SensorFactory.CreateSensor(sensorType);

                int singleFound = iranianAgent.AttachAndActivateSensor(sensor);

                if (singleFound > 0)
                    Console.WriteLine($"\u001b[32mWell done! You found the right sensor.\u001b[0m");
                else
                    Console.WriteLine($"\u001b[31mThe sensor is incorrect.\u001b[0m");

                found += singleFound;
                Console.WriteLine($"\u001b[36mTotal: {found}/{iranianAgent.SensorsForExposure}\u001b[0m");
            }
            Console.WriteLine("\u001b[32mYou won!\u001b[0m");
        }
    }
}
