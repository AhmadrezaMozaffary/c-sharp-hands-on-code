using System;

namespace Games
{
    enum GameId
    {
        RockPaperScissors = 1,
    }

    enum ErrorCodes
    {
        InvalidGameId = 1
    }

  static  class GameValidator
    {
       public static void Check(int gameId)
       {
            if (IsValid(gameId))
            {
                PrintName((GameId)gameId); // fix to (LunchGame)
            }
       }

        private static bool IsValid(int gameId)
        {
            int[] gameIdEnumArray = (int[])Enum.GetValues(typeof(GameId));

            if (!gameIdEnumArray.Contains(gameId)) 
            { 
                PrintError(ErrorCodes.InvalidGameId);
                return false;
            }
            else {
                return true;
            }

        }
        private static void PrintName(GameId gameId)
        {
            switch(gameId)
            {
                case GameId.RockPaperScissors:
                    Console.WriteLine("The game name is Rock Paper Scissors");
                    break;

                default:
                    PrintError(ErrorCodes.InvalidGameId);
                    break;
            }
        }

        private static void PrintError(ErrorCodes errCode)
        {
            switch (errCode)
            {
                case ErrorCodes.InvalidGameId:
                    Console.Clear();
                    Console.WriteLine("Invalid game id .");
                    Game.Init();
                    break;

            }
        }



    }
}
