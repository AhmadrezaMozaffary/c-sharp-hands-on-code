using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Games.Common;
using Games.Logics.Animal_Fight.DB;
using Games.Logics.AnimalFight.Models;

namespace Games.Logics.Animal_Fight
{
    internal enum Choices
    {
        NavigateToGameMenu = 0,
        Start = 1,
    }
    internal enum TeamChoices
    {
        FirstTeam = 1,
        SecondTeam = 2,
    }

    internal class AnimalFight : Game
    {
        public override string Name => "Animal Fight";

        public override int[]? AvailableCommands { get; set; }

        public override void Lunch()
        {
            PrintGameName();
            Init();
        }

        private void Init()
        {
            AvailableCommands = Helper.PrintAvailableCommands<Choices>();
            int userInput = Helper.GetUserInput();

            ApplyRules(userInput);
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
            }

            AppDatabase db = new();

            Team firstTeam = db.GetRandomTeam("First team");
            Team secondTeam = db.GetRandomTeam("Second team");

            Console.Clear();

            firstTeam.IntroduceFighters();
            secondTeam.IntroduceFighters();

            int[] availableTeamChoices = Helper.PrintAvailableCommands<TeamChoices>("Guess the winner!");

            int userGuess = Helper.GetUserInput();


            if (!availableTeamChoices.Contains(userGuess))
            {
                Helper.PrintError("Please enter a valid team !");
                Init();
                return;
            }

            if (firstTeam.GetTeamPower() > secondTeam.GetTeamPower())
            {
                if (userGuess == (int)TeamChoices.FirstTeam)
                {
                    Helper.PrintSuccess("You won !");
                    NavigateToGameMenu();
                }
                else
                {
                    Helper.PrintError("You lost !");
                    NavigateToGameMenu();
                }
            }
            else if (firstTeam.GetTeamPower() < secondTeam.GetTeamPower())
            {
                if (userGuess == (int)TeamChoices.FirstTeam)
                {
                    Helper.PrintError("You Lost !");
                    NavigateToGameMenu();
                }
                else
                {
                    Helper.PrintSuccess("You Won !");
                    NavigateToGameMenu();
                }
            }
            else
            {
                Helper.PrintWarning("No team will win the game :)");
                NavigateToGameMenu();
            }

        }
    }
}
