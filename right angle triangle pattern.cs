/* 1
 * 23
 * 456
 * 78910
 * 654
 * 32
 * 1*/
public class Program
{
    int a = 1;
    public static void Main()
    {
        Program obj = new Program();

        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write($"{obj.a} ");
                obj.a++;
            }
            Console.WriteLine();
        }
        obj.a = obj.a - 5;
        for(int i = 3; i >= 1; i--)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write($"{obj.a} ");
                obj.a--;
            }
            Console.WriteLine();
        }
    }
}