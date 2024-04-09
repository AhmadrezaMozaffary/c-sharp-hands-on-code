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

            int[] gameIdEnumArray = (int[])Enum.GetValues(typeof(InputId));

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
        private static void PrintName(InputId gameId)
        {
            switch (gameId)
            {
                case InputId.RockPaperScissors:
                    Helper.Print("The game name is Rock Paper Scissors");
                    break;

                default:
                    ValidationError(ErrorCodes.InvalidGameId);
                    break;
            }
        }

        private static void ValidationError(ErrorCodes errCode)
        {
            switch (errCode)
            {
                case ErrorCodes.InvalidGameId:
                    Helper.PrintError("Invalid Game Id.");
                    break;

            }
            GameLuncher.Init();
        }

    }
}
