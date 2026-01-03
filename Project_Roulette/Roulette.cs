using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_Roulette
{
    internal class Roulette
    {
        Random random = new Random();

        public int Spin()
        {
            return random.Next(0, 37); // Generuje cisla od 0 az 36
        }
        public string GetColor(int number)
        {
            if (number == 0)
            {
                return "Green";
            }
            else if (number % 2 == 0)
            {
                return "Black";
            }
            else
            {
                return "Red";
            }     
        }
        public string GetParity(int number)
        {
            if (number == 0)
            {
                return "None";
            }
            else if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
} 

