using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    internal class Game
    {
        public static void Init()
        {
            PrintStarterTexts();
            int userInput = GetUserInput();
            GameValidator.Check(userInput);
        }

        public static void PrintStarterTexts() {
            Console.WriteLine("Rock Paper Scissors = 1");
            Console.WriteLine("------------------------");
            Console.WriteLine("Enter GameId to start...");
        }

        public static int GetUserInput() { 
        return int.Parse(Console.ReadLine());
        }
    }
}
