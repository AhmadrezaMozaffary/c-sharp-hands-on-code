using Games.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Logics
{
    internal class Palindrome : Game
    {
        public override string Name => "Palindrome";

        public override void Lunch()
        {
            PrintGameName();
        }
    }
}
