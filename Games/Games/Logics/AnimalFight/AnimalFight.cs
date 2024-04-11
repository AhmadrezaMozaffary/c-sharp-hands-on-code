using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Games.Common;
using Games.Logics.Animal_Fight.DB;

namespace Games.Logics.Animal_Fight
{
    internal enum Choices
    {
        NavigateToGameMenu = 0,
        Start = 1,
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

            if(input == (int)Choices.NavigateToGameMenu)
            {
                NavigateToGameMenu();
            }

            AppDatabase db = new();
            Fighter[] fighters = db.GetFighters();

            foreach (Fighter fighter in fighters)
                fighter.Introduce();
        }
    }
}
