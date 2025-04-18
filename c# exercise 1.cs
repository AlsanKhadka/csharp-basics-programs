//Exercise 1
//EXERCISE 1.1

//Consider a window cleaner in a cradle who must clean the windows in a block of flats. The block of flats has an unspecified number of floors. The cradle is positioned at the bottom of the North side of the building ready for the window cleaner to step into it. Each floor on the North side of the block has a single window.

//The cradle consists of a platform for him to sit on, together with a control panel. The control panel contains two buttons "up" and "down". Each button will move the cradle up or down one floor, with the cradle correctly positioned to clean the windows on that floor.
 
//The cradle is initially set at ground floor level and has a safety device which prevents the window cleaner from stepping out of the cradle unless it is at ground floor level.
 
//Write down the algorithm the window cleaner must follow to clean all of the windows on the North side of the block of flats. The algorithm should start with the window cleaner stepping into the cradle and finish with him stepping out of the cradle having finished cleaning all the windows.
 
//HINT: start by drawing a simple diagram of what the North side of the building looks like to help you visualize the steps needed to clean the windows.
 
public class Program
{
    public static void Main()
    {
        int floor = 10;
        int currentFloor = 1;
        int a = 1,b=1;
     
        Console.WriteLine($"The window cleaner steps into the cradle ");
        Console.WriteLine($"The window cleaner start cleaning the ground floor");
        Console.WriteLine($"The window cleaner gives good cleaning to the ground floor");
        while (currentFloor != 0 && currentFloor <= floor) 
            {
            if (b== floor && currentFloor==1) 
            {
                break;
            }
                Console.WriteLine("Choose Up or Down");
                string controls = Console.ReadLine();
          
            if (controls == "Up")
            {
                if (currentFloor != floor)
                {
                  
                    a++;

                    currentFloor++;
                    Console.WriteLine($"The cradle is move to the {currentFloor} number floor");
                    if (currentFloor == a)
                    {
                        b++;
                        Console.WriteLine($"The window cleaner start cleaning the {currentFloor} number floor");
                        Console.Write($"The window cleaner gives good cleaning to the {currentFloor} number floor");
                    }

                    else
                    {
                        a--;
                    }
                }
                else
                {
                    Console.WriteLine("You are in a top floor ");
                }
            }
            else if (controls == "Down")
            {
              
                currentFloor--;
               
                if (currentFloor != 0)
                {
                    Console.WriteLine($"The cradle is move to the {currentFloor} number floor ");
                }
                if (currentFloor==0)
                {
                    currentFloor++;
                }

               

            }
            else
            {
                Console.WriteLine($"The cradle not moved");
            
            }
            }
        
        Console.WriteLine("The window cleaner steps out, having cleaned all the windows on the North side");
        }
    }
