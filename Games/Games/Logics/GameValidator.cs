using System;
using Games.Common;

namespace Games.Logics
{
    static class GameValidator
    {
        public static bool Check(int gameId)
        {
            if ((int)InputId.ExitGame == gameId)
            {
                GameLuncher.Exit();
                return false;
            }

            int[] gameIdEnumArray = Helper.PrintAvailableCommands<InputId>() ;

            if (!gameIdEnumArray.Contains(gameId))
            {
                throw new Exception("Invalid input id.");
            }
            else
            {
                return true;
            }

        }

    }
}
