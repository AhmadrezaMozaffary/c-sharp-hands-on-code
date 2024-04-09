using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.ExtendedProperties;
using Games.Common;
using Games.Logics;

namespace Games
{
    internal class GameLuncher
    {
        public static void Init()
        {
            try
            {
                int userInput;

                PrintStarterTexts();
   
                userInput = GetUserInput();

                if (GameValidator.Check(userInput))
                    LunchGameBy((InputId)userInput);
            }
            catch (Exception ex)
            {
                Helper.PrintError(ex.Message);
                Init();
            }
        }

        private static void LunchGameBy(InputId input)
        {
            switch (input)
            {
                case InputId.RockPaperScissors:
                    RockPaperScissors rps = new();
                    rps.Lunch();
                    return;
            }

        }

        public static void PrintStarterTexts() {
            Helper.PrintAvailableCommands();
            Helper.Print("------------------------");
            Helper.Print("Enter Command number to start...");
            Helper.Print("------------------------");

        }

        public static int GetUserInput() { 
            return int.Parse(Console.ReadLine());
        }

        public static void Exit()
        {
            Helper.PrintSuccess("Game will be closed after couple of seconds...");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }
    }
}
