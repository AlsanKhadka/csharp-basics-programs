//Random class and Next method example
public class Program
{
    public void Method1()
    {
        Console.WriteLine("The random number is ");
        Random obj = new Random();
        int A = obj.Next();
        Console.WriteLine($"{A}");
    }
}
public class Person
{
    public static void Main()
    {
       
        Program obj1 = new Program();
        obj1.Method1();
        Console.WriteLine("The random numbers are ");
        Random rand = new Random();
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{rand.Next()}");
        }
    }
}