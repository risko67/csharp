using Cvicenie_BattleSimulator; 
using System.Globalization;

namespace Cvicenie_BattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Hero ourHero = new Hero();
            Monster monster1 = new Monster("Goblin", 150, 20 );
            Monster monster2 = new Monster("Ork", 200,16 );
            Monster monster3 = new Monster("Dragon", 300, 30);
            List<int> cisla = new List<int>();
            List<Monster> monsters = new List<Monster>();
            monsters.Add(monster1);
            monsters.Add(monster2);
            monsters.Add(monster3);

            while (true)
            {
                int pocetMonstier = monsters.Count;
                int ktora = r.Next(0, pocetMonstier);
                monsters[ktora].MonsterAttack(ourHero);
                if (ourHero.HP <= 0)
                {
                    Console.WriteLine("Tvoj hrdina zomrel! Koniec hry.");
                    break;
                }
               
                ourHero.HeroAttack(monsters[ktora]);
                if (monsters[ktora].HP <= 0)
                {
                   Console.WriteLine("Porazil si " + monsters[ktora].RaceType);
               monsters.RemoveAt(ktora);
                }

                if (monsters.Count == 0)
                {
                    Console.WriteLine("Vsetky monstry boli porazene! Vyhral si hru.");
                    break;
                }
                Console.WriteLine("Tvoj hrdina ma teraz " + ourHero.HP);
                foreach (Monster monster in monsters)
                {
                    Console.WriteLine(monster.RaceType + " ma " + monster.HP);
                }



               




                 
            }
        }
    }
}































