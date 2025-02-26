/*print even number or odd number based on user input(like if user say Even then the even numbers should print
 * if the user say odd then odd numbers should print) and take input like terms and starting number and also 
 * consider the user need to restart the process then the use can do so.
 */
public class Program
{
    public static void Main()
    {
        string choice;
        do
        {
            char name;
            int start, term;
            Console.Write("Enter what you want to do(even= E and odd= O ");
            name = char.Parse(Console.ReadLine());
            Console.Write("Enter your starting number ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter your terms ");
            bool A = int.TryParse(Console.ReadLine(), out term);
            int a = 0;
            int b = 0, c = 0;
            for (int i = start; a < term; i++)
            {
            
                if (name == 'E' && i % 2 == 0)
                {
                    if (b==0)
                    {

                        Console.Write("The even numbers are: ");
                        b++;
                    }
                    Console.Write($"{i} ");
                    a++;
                }
                if (name == 'O' && i % 2 != 0)
                {
                    if (c==0)
                    {
                        Console.Write("The odd numbers are ");
                        c++;
                    }
                    Console.Write($"{i} ");
                    a++;
                }

            }
            Console.WriteLine();
            Console.Write("You need to restart the process(Yes=Y,No=N) ");
            choice = Console.ReadLine();
        }
        while (choice == "Y");
    }
}