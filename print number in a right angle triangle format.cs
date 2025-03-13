/* 1
 * 23
 * 456
 * 78910
 * 456
 * 23
 * 1*/
public class Program
{
    public static void Main()
    {
        int a = 0 ;
        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                a++;
                Console.Write($"{a}");

            }
            Console.WriteLine();
        }
        a = a - 7; int b = 0;
        for(int i = 3; i >= 1; i--)
        {
            for(int j = 1; j <= i; j++)
            {
                a++;
                Console.Write($"{a}");
            }
            Console.WriteLine();
            a = a - 5+ b;
            b = 2;
        }
    }
}