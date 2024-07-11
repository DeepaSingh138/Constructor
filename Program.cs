namespace Constructor_assignment{
public class Program
{
    public static void Main(string[] args)
    {
            Constructor_assignment.Student S1 = new Student();
               Student S2 = new Student("deepa",20);
            Console.WriteLine($"Student is {S2.name} and enrollment number is {S2.rollno}");

    }

}
    }

