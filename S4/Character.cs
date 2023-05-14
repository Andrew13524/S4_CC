using System;
using System.Collections.Generic;
using System.Text;

namespace S4
{
    class Character
    {
        public string Name;
        protected const int baseAttack = 1;
        protected const int baseHealth = 100;

        public Character(string name)
        {
            Name = name;
        }
    }
}
