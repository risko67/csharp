using cvicenia_ukladanie;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Napis co treba");
        string command = Console.ReadLine();
        string subor = "osoba.txt";
        if (command == "write")
        {           
          Osoba osoba = new Osoba(meno: "Igor", vek: 17);
          Osoba osoba1 = new Osoba(meno: "Anna", vek: 25);
          Osoba osoba2 = new Osoba(meno: "Peter", vek: 30);          
         List<Osoba> ludia = new List<Osoba>();
         ludia.Add(osoba);
            ludia.Add(osoba1);
            ludia.Add(osoba2);
            string json = JsonSerializer.Serialize(ludia);
           File.WriteAllText(subor, json);
        }
        if (command == "read")
        {
            string[] read = File.ReadAllLines(subor);
            List<Osoba> ludia = new List<Osoba>();
            foreach (string line in read)
            {
                string[] dataArr = line.Split(',');
                string name = dataArr[0];
                int vek = int.Parse(dataArr[1]);
                Osoba o = new Osoba(name, vek);
                ludia.Add(o); 
            }

            
            
        }







            
        

    }
}