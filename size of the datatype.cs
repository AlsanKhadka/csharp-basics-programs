//convert from double value to integer
public class Program
{
    public static void Conversion(int a,int b=12)
    {
        double d = 1.223d;
        a = (int)d;
        float f = 1.22f;
        b = f;
        Console.WriteLine($"The conversion from double to int is {a} and the conversion from float to int is {b}");
    }
    public static void Main()
    {
        Program.Conversion(10);
    }
}