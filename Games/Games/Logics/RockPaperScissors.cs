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
                        userScore += 1;
                        Helper.PrintSuccess($"System: Rock, Score: {sysScore} | You: Paper, Score: {userScore}");
                    }
                    else
                    {
                        sysScore += 1;
                        Helper.PrintError($"System: Rock, Score: {sysScore} | You: Scissors, Score: {userScore}");
                    }
                    break;
                case Choices.Paper:
                    if (userChoice == Choices.Rock)
                    {
                        sysScore += 1;
                        Helper.PrintError($"System: Paper, Score: {sysScore} | You: Rock, Score: {userScore}");
                    }
                    else if (userChoice == Choices.Paper) { Helper.PrintWarning("Same choice !"); }
                    else
                    {
                        userScore += 1;
                        Helper.PrintSuccess($"System: Paper, Score:{sysScore} | You: Scissors, Score: {userScore}");
                    }
                    break;
                case Choices.Scissors:
                    if (userChoice == Choices.Rock)
                    {
                        userScore += 1;
                        Helper.PrintSuccess($"System: Scissors, Score: {sysScore} | You: Rock, Score: {userScore}");
                    }
                    else if (userChoice == Choices.Paper)
                    {
                        sysScore += 1;
                        Helper.PrintError($"System: Scissors, Score: {sysScore} | You: Paper, Scoer: {userScore}");
                    }
                    else { Helper.PrintWarning("Same choice !"); }
                    break;

            }
        }
    }
}
