using Sensors.Models;

namespace Sensors.Game
{
    public class Gameing
    {
        public void StartGame()
        {
            int sensorsForExposure = 2;
            IranianAgent iranianAgent = new IranianAgent(sensorsForExposure);
            GameMethod gameMethod = new GameMethod();
            string color = "\u001b[36m";
            int found = 0;

            Console.WriteLine($"{color}<<<<<The Sensor Game>>>>>\u001b[0m");

            while (found < sensorsForExposure)
            {
                gameMethod.Menu();
                string userChoice = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(userChoice))
                {
                    Console.WriteLine("\u001b[31mInvalid input\u001b[0m");
                    continue;
                }

                if (userChoice == "1")
                    userChoice = "Thermal";
                else if (userChoice == "2")
                    userChoice = "Motion";
                else if (userChoice == "3")
                    userChoice = "Cellular";
                else
                {
                    Console.WriteLine("\u001b[31mChoiceError\u001b[0m");
                    continue;
                }

                Sensor sensor = new Sensor(userChoice);
                int singleFound = gameMethod.ActivateSingle(sensor, iranianAgent.GetExposureSensors());

                if (singleFound > 0)
                    Console.WriteLine($"\u001b[32mWell done! You found the right sensor.\u001b[0m");
                else
                    Console.WriteLine($"\u001b[31mThe sensor is incorrect.\u001b[0m");

                found += singleFound;
                Console.WriteLine($"\u001b[36mTotal: {found}/{sensorsForExposure}\u001b[0m");

            }

            Console.WriteLine("\u001b[32mYou won!\u001b[0m");
        }
    }
}
