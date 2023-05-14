using System;
using System.Collections.Generic;
using System.Text;

namespace S4
{
    class Player : Character
    {
        public int Level;
        public int EXP;

        public int EXP_Required => GetRequiredEXP();
        public int Health => GetHealth();
        public int Attack => GetAttackDamage();


        public Player(string name) : base(name)
        {
            Level = 1;
            EXP = 0;
        }

        public void AddEXP(int amount)
        {
            EXP += amount;
            if(EXP >= EXP_Required)
            {
                Level++;
                EXP = 0;
            }
        }

        private int GetRequiredEXP()
        {
            return 100 * Level;
        }
        private int GetAttackDamage()
        {
            return baseAttack * Level;
        }
        private int GetHealth()
        {
            return baseHealth * Level;
        }
    }
}
