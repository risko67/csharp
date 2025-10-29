using Cvicenie_BattleSimulator; 
using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        Hero ourHero = new Hero();
        Monster monster1 = new Monster("Goblin", 150, 3);




        ourHero.HP = ourHero.HP - monster1.DMG;
        

        while (true)
        {



            // hero dostal dmg od monstra
            monster1.MonsterAttack(ourHero);
            Console.WriteLine("HERO:HP " + ourHero.HP);
           
            // monster od hera
            bool wasAttack = ourHero.HeroAttack(monster1);
            if (wasAttack)
            {
                Console.WriteLine("MONSTER:HP " + monster1.HP);
            }
            else
            {
                Console.WriteLine("...Not enough energy to attack! Restoring energy...");

                Console.WriteLine("Hero energy: " + ourHero.ENG);
            }



            if (ourHero.HP == 0)
            {
                Console.WriteLine("Hero is dead");
                break;

            }
            

            if (ourHero.HP <= 0)
            {
                Console.WriteLine("Hero is dead");
                break;
            }

            if (monster1.HP <= 1) 
            {
                Console.WriteLine("Monster is dead");
                break;








            }
        }
    }
}