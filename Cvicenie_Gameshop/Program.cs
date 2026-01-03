using Cvicenie_Gameshop;
using System.Transactions;

internal class Program
{
    static void Main(string[] args)
    {
        List<Item> items = LootGenerator.GetRandomLoot();
   
 
        Item worst = items.MinBy(item => item.Price)!;
        Console.WriteLine(worst);

        Item best = items.MaxBy(item => item.Price)!;
        Console.WriteLine(best);

        List<Item> orderByPrice = items.OrderByDescending(item => item.Price).ToList();
        Console.WriteLine(orderByPrice[0]);
         
        List<Item> orderByPriceNajdrahsi = items.OrderBy(item => item.Price).ToList();
        Console.WriteLine(" Toto je najdrahsia vec " + orderByPriceNajdrahsi[0] );
       
        List<Item> itemUnder1000 = items.Where(vec => vec.Price <= 1000 && vec.Price >= 500).ToList();
        Console.WriteLine("Polozky s cenou pod 1000 a 500: " + itemUnder1000);
    }
}
       
        

