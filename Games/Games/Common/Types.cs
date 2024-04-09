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
        NavigateToGameMene = 1,
        RockPaperScissors = 2,
    }

    enum ErrorCodes
    {
        InvalidGameId = 1
    }

    enum PrintType {
        Success = 1,
        Failure = 2,
    }

    public abstract class Game
    {
        public abstract void Lunch();
        public abstract string Name { get; }
        public void PrintGameName() { Helper.PrintSuccess($"Starting ({Name})"); } 

    }
}
