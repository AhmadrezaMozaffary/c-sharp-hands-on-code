using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Common
{
    enum InputId
    {
        ExitGame = 0,
        RockPaperScissors = 1,
    }

    enum ErrorCodes
    {
        InvalidGameId = 1
    }

    enum PrintType {
        Success = 1,
        Failure = 2,
        Warning = 3,
    }

    enum ClearType
    {
        Enable = 1, Disable = 2,
    }

    public abstract class Game
    {
        public abstract void Lunch();
        public abstract string Name { get; }
        public void PrintGameName() { 
            Helper.PrintWarning($"Starting ({Name})");
            Thread.Sleep(2000);
            Console.Clear();
        } 
        public void NavigateToGameMenu()
        {
            #region Before Navigate
            Helper.PrintWarning("Navigating...", ClearType.Disable);
            Thread.Sleep(2000);
            Console.Clear();
            #endregion

            GameLuncher.Init();
        }

    }
}
