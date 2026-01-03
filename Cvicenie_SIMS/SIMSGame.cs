using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_SIMS
{
    public class SIMSGame
    {
        public Player MyPlayer { get; set; } = new Player();

        public void StartGame()
        {
            bool isRunning = true;
            while (isRunning)
            { 
                MyPlayer.Starving();
                MyPlayer.Thirsting();
                if (MyPlayer.Health <= 0)
                {
                    Console.WriteLine(" Game over. ");
                    isRunning = false;
                }
                  Console.WriteLine(MyPlayer.Hunger + " " + MyPlayer.Health);

                {
               

               
            }

        }
    }
}
}


