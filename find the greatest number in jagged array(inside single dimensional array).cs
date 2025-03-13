//find the greatest number in jagged array(inside single dimensional array)
public class Program
{
    public static void Main()
    {
        int row, g, h;
        Console.Write("Enter your row length ");
        row = int.Parse(Console.ReadLine());
        int[][] num = new int[row][];
        for(int i = 0; i < num.Length; i++)
        {
            Console.Write($"Enter your length of {i} index ");
            int size = int.Parse(Console.ReadLine());
            num[i] = new int[size];
            for(int j = 0; j <size ; j++)
            {
                Console.Write("Enter your value of [{i}{j}] index ");
                num[i][j] = int.Parse(Console.ReadLine());
            }
        }
        for( g = 0; g< num.Length; g++)
        {
            for(h = 0; h < num[g].Length; h++)
            {
                int y = 0,z=0;
                for(int i = 0; i < num.Length; i++)
                {
                    for(int j = 0; j < num[i].Length; j++)
                    {
                        z++;

                        if (num[g][h]>= num[i][j])
                        {
                            y++;
                        }
                    }
                }
                if (y == z)
                {
                    Console.Write($"The largest number is {num[g][h]}");
                }
            }
        }
    }
}
