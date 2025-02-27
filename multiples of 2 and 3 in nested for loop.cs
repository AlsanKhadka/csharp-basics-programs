//multiples of 2 and 3 in nested for loop
public class program
{
    public static void Main()
    {
        int range, start, a = 0, b = 0, sum1 = 0, sum2 = 0;
        Console.Write("Enter your starting point ");
        start = int.Parse(Console.ReadLine());
        Console.Write("Enter your range ");
        range = int.Parse(Console.ReadLine());
        for (int i = start; i <= range; i++)
        {
            for (int j = start; j <= range; j++)
            {
                if (j % 2 == 0 && i == start)
                {
                    if (a == 0)
                    {
                        a++;
                        Console.Write("The multiples of 2 are ");
                    }
                    Console.Write($"{j} ");
                    sum1 = sum1 + j;
                }

            }

          
            if (i==start)
            {
                Console.WriteLine();
                Console.WriteLine($"The sum of multiples of 2 are {sum1}");
            }

            if (i % 3 == 0)
            {
                if (b == 0)
                {
                    b++;
                    Console.Write("The multiples of 3 are ");
                }
                Console.Write($"{i} ");
                sum2 = sum2 + i;
            }
            if (i == range)
            {
                Console.WriteLine();
                Console.Write($"The multiples of sum of 3 is {sum2}");
            }


        }
    }
}