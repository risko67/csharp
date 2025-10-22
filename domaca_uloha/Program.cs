using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] text = File.ReadAllLines("People_100.csv");

    menej5M(text);
}
        public static void menej5M(string[] text)
    {
        List<string> peopleWithUnder05M = new List<string>();
        foreach (string line in text.Skip(1))
        {
            string[] splits = line.Split(";");
            int accountvalue = int.Parse(splits[4]);
            if (accountvalue < 5000000)
                peopleWithUnder05M.Add(splits[1]);
        }
        foreach (string menej05m in peopleWithUnder05M)
        {
            Console.WriteLine(menej05m);
        }
    }
}


























