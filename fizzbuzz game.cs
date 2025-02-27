
/*For those who do not know: FizzBuzz is a quite popular children's game. Counting from 1 to 100, 
and every time a number is divisible by 3 the string "Fizz" is called, 
every time a number is divisible by 5 the string "Buzz" is called and every time a number is divisible by 3 and 5 both 
strings together "FizzBuzz" are called instead of the number.*/
public class Program
{
    public static void Main()
    {
        string a = "Fizz", b = "Buzz";
        for(int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine($"{i}={a + b}");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{i}={a}");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine($"{i}={b}");

            }
            
        }
    }
}