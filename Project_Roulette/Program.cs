using Project_Roulette;

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
        Console.WriteLine($"Vitaj {player.Username}, mas {player.Money} eur");

        Roulette roulette = new Roulette();

        Console.Write("Zadaj sumu, ktoru chces vsadit: ");
        int bet = int.Parse(Console.ReadLine());    
        
        if (bet > player.Money)
        {
            Console.WriteLine("Nemozes vsadit viac, nez mas penazi!");
            return;
        }
        if (bet <= 0)
        {
            Console.WriteLine("Vsadit musis aspon 1 euro!");
            return;
        }
       
        Console.Write("Zadaj farbu (red / black): ");
        string chosenColor = Console.ReadLine();

        int number = roulette.Spin();
        string color = roulette.GetColor(number);

        Console.WriteLine("Padlo: " + number + " (" + color + ")");

        if (chosenColor == color)
        {
            player.Money += bet;
            Console.WriteLine("Vyhra!");
        }
        else
        {
            player.Money -= bet;
            Console.WriteLine("Prehra!");
        }

        player.Level++;

        if (player.Level == 20 || player.Level == 50 || player.Level == 100)
        {
            Random random = new Random();
            int bonus = random.Next(20, 76);

            player.Money += bonus;
            Console.WriteLine("BONUS! Dostavas " + bonus + " €");
        }
        Console.WriteLine("Vsetko si prehral XD");
        Console.WriteLine("Dosiahol si level " + player.Level);
        Console.WriteLine("Koniec hry.");
    }
}