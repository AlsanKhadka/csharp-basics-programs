//print even and odd numbers in a given range using nested for loop
public class Program
{
    public static void Main()
    {
        int terms, start,a=0,b=0;
        Console.Write("Enter your starting number ");
        start = int.Parse(Console.ReadLine());
        Console.Write("Enter your terms ");
        bool A = int.TryParse(Console.ReadLine(), out terms);
        Console.WriteLine("The odd and even numbers are ");
        for(int i = start; i <=terms; i++)
        {
            for (int j = i; j <= terms; j++)
            {
                if (i > start)
                {
                    break;
                }
                if (j % 2 != 0)
                {

                    Console.Write($"{j} ");
                }
            }
                if (start == i)
                {
                    Console.WriteLine();
                }
                if (i % 2 == 0)
                {
                    
                    Console.Write($"{i} ");
                }
            }
        }
    }
