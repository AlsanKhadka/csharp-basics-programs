//C# Program to Copy a Section of One Array to Another
public class Program
{
    public static void Method1()
    {
        int size, size1, copy;
        Console.Write("Enter the size of the array ");
        size = int.Parse(Console.ReadLine());
        int[] array1 = new int[size];
        for(int i = 0; i < array1.Length; i++)
        {
            Console.Write($"Enter your [{i}] index value ");
            array1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("Enter your size of array ");
        size1 = int.Parse(Console.ReadLine());
        int[] num2 = new int[size1];
        Console.Write("Enter how many copy do you want ");
        copy = int.Parse(Console.ReadLine());
        for(int i = 0; i < num2.Length; i++)
        {
            if (i <= copy - 1)
            {
                num2[i] = array1[i];
                Console.WriteLine($"{num2[i]} ");
                continue;
            }
            Console.WriteLine($"{num2[i]}");
        }
    }
    public static void Main()
    {
        Program.Method1();
    }
}