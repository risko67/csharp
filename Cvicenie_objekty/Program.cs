
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
       /* string meno = "Jakub Lukac";
        string adresa = "Stara Bystrica";
        int vek = 15;
        char pohlavie = 'M';    
        Console.WriteLine(meno + " byva v " + adresa + " a ma " + vek);

        string meno2 = "Jozik lisko";
        string adresa2 = "Rudinska 67";
        int vek2 = 16;
        Console.WriteLine(meno2 + " byva v " + adresa2 + " a ma " + vek2);
       */
   
        
       Student student1 = new Student();
       
       student1.Vek = 15;
       student1.Meno = "Jakub Lukac";
       student1.Adresa = "Stara Bystrica";
       student1.Pohlavie = 'M';

       

        Student student2 = new Student();

        student2.Vek = 15;
        student2.Meno = "Jozko Lisko";
        student2.Adresa = "Rudisnka";
        student2.Pohlavie = 'M';

        Student staryStudent = student1;
        staryStudent.Meno += " Pindac ";
        Console.WriteLine(staryStudent.Meno);


        Console.WriteLine(student1.VypisInfo());






        










    }
}