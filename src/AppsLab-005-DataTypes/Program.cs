

using System;
using System.Diagnostics.Contracts;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int myAge = 15;
            Console.WriteLine(myAge);

            float pi = 6.7f;
            Console.WriteLine(pi);

            string name = "Risko";
            Console.WriteLine(name);

            char gender = 'M';

            Console.WriteLine(gender);

            bool isChild = true;
            Console.WriteLine(isChild);
       */
/*
          int a = 10;
            int b = 5;

            int sum = a + b;
            Console.WriteLine(sum);
           

            int d = 29;
            int c = 30;
           
            
            Console.WriteLine(d - c);

            Console.WriteLine(c / a);

            Console.WriteLine(d*b);

            Console.WriteLine("volam sa riso"); 
*/


            int birthday = 25;
            int birthmonth = 2;
            int birthyear = 2010;
           
            //scitanie tychto 3 veci 

            int birthSum = birthday + birthmonth + birthyear;
            Console.WriteLine(birthSum);

            int BirthSum2 = (birthSum * 10);
            Console.WriteLine(BirthSum2);

            // vykratenie 10

            int sum3 = ((birthday + birthmonth) * birthyear);


            Console.WriteLine(sum3);

            string name = ("risko ciprich");
           Console.WriteLine(name + birthyear);

            Console.WriteLine(birthday + birthmonth + name);

            bool result = 6 != 6;
            Console.WriteLine(result);
       







        
        
        }



    }
}