//c# program to convert 2D array to 1D array using methods
public class Program
{
   static string [] num;
    string[,] twoD;
    public Program(int x, int y)
    {

        twoD = new string[x, y];
        num = new string[x * y];
    }
    public void TwoD()
    {
        for (int i = 0; i < twoD.GetLength(0); i++)
        {
            for (int j = 0; j < twoD.GetLength(1); j++)
            {
                Console.Write($"Enter your [{i},{j}] index value ");
                twoD[i, j] = Console.ReadLine();
            }
        }
        Console.WriteLine();

    }
    public int PrintTwoD()
    {
        Console.WriteLine("The 2D array is ");
        int a = 0;
        for (int i = 0; i < twoD.GetLength(0); i++)
        {
            for (int j = 0; j < twoD.GetLength(1); j++)
            {
                Console.WriteLine($"[{i},{j}]={twoD[i, j]}");
                num[a] = twoD[i, j];
                a++;
            }
           
        }
        Console.WriteLine();
        return 10;
    }
    public static bool OneD()
    {
        Console.Write("The conversion of 2D array to 1D array is ");
        for(int i = 0; i < num.Length; i++)
        {
            Console.Write($"{num[i]}"+" ");
        }
        return true;
    }


}
public class Person
{
    public static void Main()
    {
        int row, column;
        Console.Write("Enter your length of row ");
        row = int.Parse(Console.ReadLine());
        Console.Write("Enter your length of column ");
        column = int.Parse(Console.ReadLine());

        Program obj1 = new Program(row, column);
        obj1.TwoD();
        obj1.PrintTwoD();
        Program.OneD();
        Console.WriteLine();


    }
}