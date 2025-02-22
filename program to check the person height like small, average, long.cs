//c# program to find the person hight is short , average and long
public class Program
{
    public static void HeightComparision()
    {
        double height;
        do
        {
            Console.Write("Enter your height in feet ");
            height = double.Parse(Console.ReadLine());
            if (height < 5 && height>=1)
            {
                Console.WriteLine("You are short in height ");
            }
            else if (height >= 5.0 && height <= 5.10)
            {
                Console.Write("Your are average in height ");
            }
            else if (height == 0)
            {
                Console.WriteLine($"Height cannot be zero!");
            }
        } while (height == 0);
    }
}
public class NewClass
{
    public static void Main()
    {
        Program.HeightComparision();
    }
}