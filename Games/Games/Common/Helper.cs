using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Common
{
    static class Helper
    {
        private static void PrintToConsole(string msg, PrintType type)
        {
            #region Mutate Console Color and Print Error
            Console.Clear();

            Console.BackgroundColor = type == PrintType.Success ? ConsoleColor.Green : type == PrintType.Failure ? ConsoleColor.Red : ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(msg);

            Console.ResetColor();
            #endregion
        }
        public static void PrintError(string msg)
        {
            PrintToConsole(msg, PrintType.Failure);
        }

        public static void PrintSuccess(string msg)
        {
            PrintToConsole(msg, PrintType.Success);
        }

        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void PrintAvailableCommands()
        {
            int[] gameIdEnumArray = (int[])Enum.GetValues(typeof(InputId));
            foreach (int gameId in gameIdEnumArray)
            {
                string enumName = Enum.GetName(typeof(InputId), gameId);
                Print(gameId + ") - " + enumName);
            }
        }

    }
}
