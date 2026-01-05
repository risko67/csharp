using Project_Roulette;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Zadaj username: ");
        string username = Console.ReadLine();

        Console.Write("Zadaj heslo: ");
        string password = Console.ReadLine();

        Console.Write("Zadaj vek: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 18)
        {
            Console.WriteLine("Mas smolu, pod 18 sa nehra >:)");
            return;
        }

        Player player = new Player(username, password, age);
        Console.WriteLine($"Vitaj {player.Username}, mas {player.Money} €");

        Random random = new Random();

        while (true)
        {
            if (player.Money <= 0)
            {
                Console.WriteLine("Nemas ziadne peniaze. Koniec hry.");
                break;
            }

            Console.WriteLine();
            Console.WriteLine($"PENIAZE: {player.Money} € | LEVEL: {player.Level}");
            Console.Write("Zadaj sumu stavky (alebo 'exit'): ");
            string betInput = Console.ReadLine().ToLower();

            if (betInput == "exit")
            {
                Console.WriteLine("Hra ukoncena.");
                break;
            }

            int bet = int.Parse(betInput);

            if (bet <= 0 || bet > player.Money)
            {
                Console.WriteLine("Neplatna stavka.");
                continue;
            }

            Console.WriteLine();
            Console.WriteLine("Vyber typ stavky (len jednu):");
            Console.WriteLine("1 - Farba (red / black)");
            Console.WriteLine("2 - Parne / Neparne");
            Console.WriteLine("3 - Konkretne cislo (0-36)");
            Console.Write("Tvoja volba: ");
            string choice = Console.ReadLine();

            // --- HRACOVA VOLBA ---
            string colorBet = "";
            string parityBet = "";
            int numberBet = -1;

            if (choice == "1")
            {
                Console.Write("Vyber farbu (red / black): ");
                colorBet = Console.ReadLine().ToLower();
            }
            else if (choice == "2")
            {
                Console.Write("Vyber (even / odd): ");
                parityBet = Console.ReadLine().ToLower();
            }
            else if (choice == "3")
            {
                Console.Write("Zadaj cislo (0-36): ");
                numberBet = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Neplatna volba.");
                continue;
            }

            // --- AZ TERAZ SA TOCI RULETA ---
            int rouletteNumber = random.Next(0, 37);
            string rouletteColor =
                rouletteNumber == 0 ? "green" :
                rouletteNumber % 2 == 0 ? "black" : "red";

            Console.WriteLine();
            Console.WriteLine("Padlo cislo: " + rouletteNumber);
            Console.WriteLine("Farba: " + rouletteColor);

            bool win = false;
            int payout = 0;

            if (choice == "1")
            {
                if (colorBet == rouletteColor)
                {
                    win = true;
                    payout = bet * 2;
                }
            }
            else if (choice == "2")
            {
                if (rouletteNumber != 0)
                {
                    if (rouletteNumber % 2 == 0 && parityBet == "even")
                        win = true;
                    if (rouletteNumber % 2 == 1 && parityBet == "odd")
                        win = true;
                }

                if (win)
                    payout = bet * 2;
            }
            else if (choice == "3")
            {
                if (numberBet == rouletteNumber)
                {
                    win = true;
                    payout = bet * 36;
                }
            }

            player.Money -= bet;

            if (win)
            {
                player.Money += payout;
                Console.WriteLine("VYHRAL SI!");
                Console.WriteLine("Vyhravas: " + payout + " €");
            }
            else
            {
                Console.WriteLine("Prehral si: " + bet + " €");
            }

            // LEVEL ZA KAZDY SPIN
            player.Level++;

            if (player.Level == 20 || player.Level == 50 || player.Level == 100)
            {
                int bonus = random.Next(20, 76);
                player.Money += bonus;
                Console.WriteLine("BONUS! Dostavas " + bonus + " €");
            }
        }

        Console.WriteLine("Program skoncil.");
    }
}
//oprav aby ked uz vsadis aj vyberies aby napisalo aj to posledne uvidis ked zappnes kod

