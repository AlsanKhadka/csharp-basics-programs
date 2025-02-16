/* using multidimensional array to display this 
 *   *
 *   **
 *   ***
 *   ****
 *   */
public class Program
{
    public static void Main()
    {
        string[,] MulD = new string[4, 1];
        string a = "*";
        for(int i = 0; i < MulD.GetLength(0); i++)
        {
            for(int j = 0; j <= 0; j++)
            {
                MulD[i,j] = a ;
                a = a + "*";
                Console.Write($"{MulD[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}