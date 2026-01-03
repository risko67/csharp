using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Idle_Farmer
{
    public class IdleFarmer
    {
        public int Money { get; set; } = 15;
        public Random RandomGenerator { get; set; } = new Random(); 
        public int Day { get; set; }
        public List<Plant> Field { get; set; } = new List<Plant>();
        public List<Plant> Storage { get; set; } = new List<Plant>();

        public void StartGame()
        {
            Console.WriteLine("Zacala sa hra");
            
            Plant cibula = new Plant("Cibula", 22, 10);
            Plant mrkva = new Plant("Mrkva", 16, 8);
            Plant zemiak = new Plant("Zemiak", 7, 7);
             
            Field.Add(cibula);
            Field.Add(mrkva);
            Field.Add(zemiak);
            
           
            
            
            while (true)
            {
                Day++;
                
                foreach (Plant plant in Field)
                {
                    plant.TimeInground++;
                    
                }


                foreach (Plant plant in Field)
                {
                    Console.WriteLine(plant);
                }
                List<Plant> harvestedPlants = new List<Plant>();
                foreach (Plant plant in Field)
                {
                    if (plant.TimeInground >= plant.TimeForHarvest)
                    {
                        Console.WriteLine("Rastlinka nam vyrastla " + plant);
                        harvestedPlants.Add(plant);
                    }
                }

                foreach (Plant plant in harvestedPlants)
                {
                    Field.Remove(plant);
                    Storage.Add(plant);
                }


                    

                Console.WriteLine("Menu:");
                Console.WriteLine("Enter Novy den");
                Console.WriteLine("1 pridanie rastlinky");
                Console.WriteLine("2 Zobrazenie skladu");
                Console.WriteLine("3 predat sklad");


                string input = Console.ReadLine();
              switch(input)
                { 
                  case "1":
                       Plant plant1 = new Plant("Zelenina", RandomGenerator.Next(10, 30), RandomGenerator.Next(5,15));
                        Field.Add(plant1);
                        Plant newplant = plant1;
                        break;
                 
                    case "2":                                              
                        foreach (Plant plant in Storage)
                        {
                            Console.WriteLine(plant);
                        }
                        Console.ReadLine();
                        break;
                 case "3":
                        int stav = 0;
                        foreach (Plant plant in Storage)
                        {
                            stav += plant.Price;
                        }

                        Money += stav * Storage.Count;
                        Storage.Clear();

                        Console.WriteLine("Predal si storage");
                        Console.WriteLine("Mas penazi: " + Money);
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
                Console.Clear();
 
            
                       
                                                                
                      
                                
                    
                    
                            





            }

        }

    }
}
