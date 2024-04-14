using Games.Common;

namespace Games.Logics.AnimalFight.Models
{
    class Team
    {
        private string _name;
        private Fighter firstFighter;
        private Fighter secondFighter;

        public Team(string teamName,Fighter firstOne, Fighter secondOne)
        {
            _name = teamName;
            firstFighter = firstOne;
            secondFighter = secondOne;
        }

        public void IntroduceFighters()
        {
            Helper.PrintWarning($"Members of the {_name} are : ", ClearType.Disable);
            firstFighter.Introduce();
            secondFighter.Introduce();
            Helper.Print("");
        }

        public int GetTeamPower()
        {
            return firstFighter.GetPower() + secondFighter.GetPower();
        }
    }
}
