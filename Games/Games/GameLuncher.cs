using Games.Common;

using Games.Logics;
using Games.Logics.Animal_Fight;
using Games.Logics.Palindrome;
using Games.Logics.RockPaperScissors;

namespace Games
{
    internal class GameLuncher
    {
        public static readonly int PRINT_DELAY_TIME = 2000;

        public static void Init()
        {
            try
            {

                PrintStarterTexts();

                int userInput = Helper.GetUserInput();

                if (!GameValidator.Check(userInput)) return;

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
            Console.WriteLine(input);
            switch (input)
            {
                case InputId.RockPaperScissors:
                    Game rps = new RockPaperScissors();
                    rps.Lunch();
                    break;

                case InputId.Palindrome:
                    Game p = new Palindrome();
                    p.Lunch();
                    break;

                case InputId.AnimalFight:
                    Game af = new AnimalFight();
                    af.Lunch();
                    break;

                default:
                    throw new Exception("Invalid input. ");

            }

        }

        public static void PrintStarterTexts()
        {
            Helper.PrintAvailableCommands<InputId>();
        }


        public static void Exit()
        {
            Helper.PrintWarning("Game will be closed after couple of seconds...");
            Thread.Sleep(GameLuncher.PRINT_DELAY_TIME);
            Helper.PrintSuccess("Game Closed.");
            Environment.Exit(0);
        }
    }
}
