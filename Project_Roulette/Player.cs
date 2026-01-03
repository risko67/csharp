using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Roulette
{
    internal class Player
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        public decimal Money { get; set; }

        public Player(string username, string password, int age)
        {
            Username = username;
            Password = password;
            Age = age;
            Level = 1;
            Money = 100;
        }
    }
}

