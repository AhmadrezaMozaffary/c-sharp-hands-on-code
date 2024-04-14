using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Common
{
    static class Helper
    {
        private static void PrintToConsole(string msg, PrintType type, ClearType clearable)
        {
            #region Mutate Console Color and Print Error
           if (clearable == ClearType.Enable) Console.Clear();

            Console.BackgroundColor = type == PrintType.Success ? ConsoleColor.Green : type == PrintType.Failure ? ConsoleColor.Red : type == PrintType.Info ? ConsoleColor.Cyan : ConsoleColor.DarkYellow;
            Console.ForegroundColor = type != PrintType.Warning && type != PrintType.Info ? ConsoleColor.White : ConsoleColor.Black;
            Console.WriteLine(msg);

            Console.ResetColor();
            #endregion
        }
        public static void PrintError(string msg, ClearType clearable = ClearType.Enable)
        {
            PrintToConsole(msg, PrintType.Failure, clearable);
        }

        public static void PrintSuccess(string msg, ClearType clearable = ClearType.Enable)
        {
            PrintToConsole(msg, PrintType.Success, clearable);
        }

        public static void PrintWarning(string msg, ClearType clearable = ClearType.Enable)
        {
            PrintToConsole(msg, PrintType.Warning, clearable);
        }

        public static void PrintInfo(string msg, ClearType clearable = ClearType.Enable)
        {
            PrintToConsole(msg, PrintType.Info, clearable);
        }

        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        public static int[] PrintAvailableCommands<T>(string msg = "Enter Command number to start")
        {
            int[] commandsArr = (int[])Enum.GetValues(typeof(T));
            Print("------------------------");
            PrintInfo(msg, ClearType.Disable);
            Print("------------------------");
            foreach (int cmd in commandsArr)
            {
                string enumName = Enum.GetName(typeof(T), cmd);
                Print(cmd + ") - " + enumName);
            }
            Print("------------------------");
            return commandsArr;
        }

        public static int GetUserInput()
        {
            return int.Parse(Console.ReadLine());
        }

    }
}
