﻿using Games.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Logics.Animal_Fight
{
    class Fighter
    {
        private string _name;
        private int _power;

        public Fighter(string name, int power) {
            _name = name;
            _power = power;
        }

        public void Introduce()
        {
            Helper.Print($"My name is {_name}");
        }
    }
}
