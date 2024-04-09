using System;
using Games.Common;

namespace Games.Logics
{
    static class GameValidator
    {
        public static bool Check(int gameId)
        {
            if (IsValid(gameId))
                return true;
            else
                return false;

        }

        private static bool IsValid(int gameId)
        {
            if ((int)InputId.ExitGame == gameId)
            {
                GameLuncher.Exit();
                return false;
            }

            int[] gameIdEnumArray = Helper.PrintAvailableCommands<InputId>() ;

            if (!gameIdEnumArray.Contains(gameId))
            {
                ValidationError(ErrorCodes.InvalidGameId);
                return false;
            }
            else
            {
                return true;
            }

        }

        private static void ValidationError(ErrorCodes errCode)
        {
            switch (errCode)
            {
                case ErrorCodes.InvalidGameId:
                    Helper.PrintError("Invalid input id.");
                    break;

            }
            GameLuncher.Init();
        }

    }
}
