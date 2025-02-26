//c# program to display largest factor if the number is a prime number
public class Program
{
    public static void Main()
    {
        int num,a=0;
        Console.Write("Enter your number ");
        num = int.Parse(Console.ReadLine());
        for(int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                a++;
            }
        }
        if (a == 2)
        {
            Console.WriteLine($"The largest factor of prime number {num} is {num} ");
        }
        else
        {
            Console.WriteLine("The number is not a prime number ");
        }

    }
}