internal class Program
{
    private static void Main(string[] args)
    {
        List<int> teploty = new List<int> { 3, -1, 12, 7, -3, 0, 19, 14, 2, 5, -5, 8 };
        int max = int.MinValue;
        max = teploty[0];   
        foreach (int teplota in teploty)
        {
            if (teplota > max)
            {
                max = teplota;
            }
        }
        Console.WriteLine("Maximalne teplota: "+max);
        int min = int.MaxValue;
        foreach (int teplota in teploty)
        {
            if (teplota < min)
            {
                min = teplota;
            }
        }

        Console.WriteLine("Minimalna teplota: "+min);

        int sucet = 0;  
        foreach (int teplota in teploty)
        {
            sucet += teplota;
        }
        int pocet = teploty.Count;  
        double priemer = (double)sucet / pocet;
        Console.WriteLine("Priemer: " +priemer);

        int pocetNadPriemerom = 0;
        foreach (int teplota in teploty)
        {
            if (teplota > priemer)
            {
                pocetNadPriemerom++;
            }
        }

        Console.WriteLine("Nad priemerom je "
                          + pocetNadPriemerom+" cisel ");


        
        List<int> kladneteploty = new List<int>();
        foreach (int teplota in teploty)
        {
            if (teplota >= 0)
            {
                kladneteploty.Add(teplota);
            }
        }

        Console.WriteLine("Kladne: ");
        foreach (var i in kladneteploty)
        {
            Console.Write(i);
        }











        string riadok = ""; 
        foreach (int teplota in teploty)
        {
            riadok +=teplota + " ";   
        }









    }

}