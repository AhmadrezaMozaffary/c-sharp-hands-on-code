using Games.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Logics.AnimalFight.Models
{
    class Fighter
    {
        private string _name;
        private int _power;

        public Fighter(string name, int power)
        {
            _name = name;
            _power = power;
        }

        public void Introduce()
        {
            Helper.Print(_name);
        }

        public int GetPower()
        {
            return _power;
        }
    }
}
