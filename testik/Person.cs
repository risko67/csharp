using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testik
{
    public class Person
    {
       public string name { get; set; }
        public string surname { get; set; } 
        public Person(string name, string surname)
        {
            name = name;
           surname = surname;

            Console.WriteLine(" Volam sa " + name + surname);
        
        
        }
    }
}
