using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_BattleSimulator
{
    public class Hero
    {
        public string Name { get; set; } = "Arnost";
        public int HP { get; set; } = 100;

        public int DMG { get; set; } = 10;
        public int ENG { get; set; } = 100;
        public bool HeroAttack(Monster monster)
        {
            if (ENG >= 0)
            {
                ENG = ENG - 20;
                monster.HP = monster.HP - DMG;
                return true;
            }
            else
            {
                ENG = ENG + 50;
                return false;



            }

        }
    }
}