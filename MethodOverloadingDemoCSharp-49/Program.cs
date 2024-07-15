namespace MethodOverloadingDemoCSharp_49;

class Program
{
    public static int Add(int numOne, int numTwo)
    {
        return numOne + numTwo;
    }

    public static double Add(double numOne, double numTwo)
    {
        return numOne + numTwo;
    }

    public static void Greet(string firstName)
    {
        Console.WriteLine($"Hello, {firstName}!");
    }
    public static void Greet(string firstName, string lastName)
    {
        Console.WriteLine($"Hello, {firstName} {lastName}!");
    }
    
    public static void Greet(string firstName, string lastName, int age)
    {
        Console.WriteLine($"Hello, {firstName} {lastName} you are {age} years old!");
    }
    
    static void Main(string[] args)
    {
        //Console.WriteLine(Add(2, 2);
        Greet("Mack", "McCall", 26);
    }
}