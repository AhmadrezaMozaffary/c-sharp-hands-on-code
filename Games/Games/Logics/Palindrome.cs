using Games.Common;

namespace Games.Logics.Palindrome
{
    internal enum Choices
    {
        NaigateToGameMenu = 0,
        Start = 1,
    }

    internal class Palindrome : Game
    {
        public override string Name => "Palindrome";

        public override int[]? AvailableCommands { get; set; }

        private int score = 0;
        public override void Lunch()
        {
            PrintGameName();
            Init();
        }

        private void Init()
        {
            AvailableCommands = Helper.PrintAvailableCommands<Choices>();

            ApplyRules(Helper.GetUserInput());

        }

        private void ApplyRules(int input)
        {
            if (!AvailableCommands.Contains(input))
            {
                Helper.PrintError("Please enter a valid choice !");
                Init();
                return;
            }

            if (input == (int)Choices.NaigateToGameMenu)
            {
                NavigateToGameMenu();
            }

            StartGame();
        }

        private void StartGame()
        {
            Helper.PrintWarning($"Score : {score}", ClearType.Disable);
            Helper.PrintInfo("Enter a palindrome word: ", ClearType.Disable);

            string word = Console.ReadLine();
            char[] wordCharArray = word.ToCharArray();
            string reverseWord = "";

            for (int i = wordCharArray.Length - 1; i >= 0; i--)
            {
                reverseWord += wordCharArray[i];
            }

            if (word != reverseWord)
            {
                Helper.PrintError("You Lose!, Score: " + score);
                NavigateToGameMenu();
            }
            else
            {
                score += 1;
                Helper.PrintSuccess("Yaaaay...", ClearType.Disable);
                StartGame();
            }


        }
    }
}
