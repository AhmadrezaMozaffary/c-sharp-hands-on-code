using Games.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Logics
{
    internal enum Choices
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3,
        NavigateToGameMenu = 0
    }

    class RockPaperScissors : Game
    {
        public override string Name => "Rock Paper Scissors";
        private int[]? AvailableCommands { get; set; }

        private const int WINNER_SCORE = 3;

        private int userScore = 0;

        private int sysScore = 0;

        public override void Lunch()
        {
            PrintGameName();

            while (userScore < WINNER_SCORE && sysScore < WINNER_SCORE)
                Init();

            if (sysScore == WINNER_SCORE)
            {
                Helper.PrintError("You Lose!");
                NavigateToGameMenu();
            }

            if (userScore == WINNER_SCORE)
            {
                Helper.PrintSuccess("You win !");
                NavigateToGameMenu();
            }
        }

        private void Init()
        {
            Helper.Print("Enter Your Choice number");
            AvailableCommands = Helper.PrintAvailableCommands<Choices>();

            ApplyRules((int)Helper.GetUserInput());
        }

        private Choices GetSystemChoice()
        {
            int randomNo = new Random().Next(1, 3);
            Console.WriteLine(randomNo);
            return (Choices)randomNo;
        }

        private void ApplyRules(int input)
        {
            if (!AvailableCommands.Contains(input))
            {
                Helper.PrintError("Please enter a valid choice !");
                Init();
                return;
            }

            if (input == (int)Choices.NavigateToGameMenu)
            {
                NavigateToGameMenu();
                return;
            }

            Choices sysChoice = GetSystemChoice();
            Choices userChoice = (Choices)input;

            switch (sysChoice)
            {
                case Choices.Rock:
                    if (userChoice == Choices.Rock)
                    {
                        Helper.PrintWarning("Same choice !");
                    }
                    else if (userChoice == Choices.Paper)
                    {
                        Helper.PrintWarning("System: Rock, You: Paper");
                        userScore += 1;
                    }
                    else
                    {
                        Helper.PrintWarning("System: Rock, You: Scissors");
                        sysScore += 1;
                    }
                    break;
                case Choices.Paper:
                    if (userChoice == Choices.Rock)
                    {
                        Helper.PrintWarning("System: Paper, You: Rock"); sysScore += 1;
                    }
                    else if (userChoice == Choices.Paper) { Helper.PrintWarning("Same choice !"); }
                    else
                    {
                        Helper.PrintWarning("System: Paper, You: Scissors");
                        userScore += 1;
                    }
                    break;
                case Choices.Scissors:
                    if (userChoice == Choices.Rock)
                    {
                        Helper.PrintWarning("System: Scissors, You: Rock");
                        userScore += 1;
                    }
                    else if (userChoice == Choices.Paper)
                    {
                        Helper.PrintWarning("System: Scissors, You: Paper");
                        sysScore += 1;
                    }
                    else { Helper.PrintWarning("Same choice !"); }
                    break;

            }
        }
    }
}
