//print binary equvalent of a decimal number
public class Program
{
    public static void Main()
    {
        int num = 20, a,i = 0;
        int[] array1 = new int[10];
        int temp = num;
        while (num > 0)
        {
            a = num % 2;
            array1[i] = a;
            num = num / 2;
            i++;
        }
        i--;
        Console.Write($"The binary equivalent of {temp} is ");
        while (i >= 0)
        {
            Console.Write($"{array1[i--]} ");
        }
    }
}