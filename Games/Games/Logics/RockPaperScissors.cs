using Games.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Logics
{
    class RockPaperScissors : Game
    {
        public override string Name => "Rock Paper Scissors";

        public override void Lunch()
        {
            PrintGameName();
        }
    }
}
