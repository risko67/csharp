using Cvicenie_pravdepodobnost;

internal class Program
{
    static void Main(string[] args)
    {
   /* Random random = new Random();
    int value = random.Next(0, 100);
        if (value < 80)
        {
            Console.WriteLine("Vyhral ten s 80%");
        }
        else
        {
            Console.WriteLine("Vyhral ten s 20%");*/

        Student student1 = new Student ("Riso", 5 );
        Student student2 = new Student ("Fero", 15);
        Student student3 = new Student ("Misko", 30);
        Student student4 = new Student ("Laco", 50);
   
        List<Student> students = new List<Student>();
        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        students.Add(student4);
        students.Add(new Student("Jano", 1));
        List<Student> klobucik = new List<Student>();

        foreach (Student stud in students)
        {
            for (int i = 0; i < stud.TicketCount; i++)
            {
                klobucik.Add(stud);
            }
        }         
        Random random = new Random();
        int index = random.Next(klobucik.Count);    
        Student winner = klobucik[index];
        Console.WriteLine($"Vyhral: {winner.Name}");
    }
}