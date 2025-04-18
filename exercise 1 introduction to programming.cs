//Consider a window cleaner in a cradle who must clean the windows in a block of flats. The block of flats has an unspecified number of floors. The cradle is positioned at the bottom of the North side of the building ready for the window cleaner to step into it. Each floor on the North side of the block has a single window.
//The cradle consists of a platform for him to sit on, together with a control panel. The control panel contains two buttons "up" and "down". Each button will move the cradle up or down one floor, with the cradle correctly positioned to clean the windows on that floor.
 
//The cradle is initially set at ground floor level and has a safety device which prevents the window cleaner from stepping out of the cradle unless it is at ground floor level.
 
//Write down the algorithm the window cleaner must follow to clean all of the windows on the North side of the block of flats. The algorithm should start with the window cleaner stepping into the cradle and finish with him stepping out of the cradle having finished cleaning all the windows.
 
//HINT: start by drawing a simple diagram of what the North side of the building looks like to help you visualize the steps needed to clean the windows.

public class WindowCleaningSimulation
{
    public static void Main()
    {
        int totalFloors;
        Console.Write("Enter the total number of floors ");
        totalFloors = int.Parse(Console.ReadLine()); // Total number of floors in the building
        int currentFloor = 1;             // The cradle starts at ground floor (floor 1)
        int cleanedFloors = 1;            // Count of floors cleaned 
        int visitedFloorCheck = 1;        // Used to ensure each floor is cleaned only once

        // Initial status at ground floor
        Console.WriteLine("The window cleaner steps into the cradle");
        Console.WriteLine("The window cleaner starts cleaning the ground floor");
        Console.WriteLine("The window cleaner gives a good cleaning to the ground floor");

    
        while (currentFloor != 0 && currentFloor <= totalFloors)
        {
            // Condition to check that the top floor is cleaned and cleaner is back at ground floor
            if (visitedFloorCheck == totalFloors && currentFloor == 1)
            {
                break;
            }

            Console.WriteLine("Choose up or down");
            string controlInput = Console.ReadLine().ToLower();

            // Move the cradle up
            if (controlInput == "up")
            {
                if (currentFloor != totalFloors)
                {
                    cleanedFloors++;
                    currentFloor++;

                    Console.WriteLine($"The cradle moves to floor {currentFloor}.");

                    if (currentFloor == cleanedFloors)
                    {
                        visitedFloorCheck++;
                        Console.WriteLine($"The window cleaner starts cleaning floor {currentFloor}.");
                        Console.WriteLine($"The window cleaner gives a good cleaning to floor {currentFloor}.");
                    }
                    else
                    {
                        cleanedFloors--; // Prevent over-counting if the floor is already cleaned
                    }
                }
                else
                {
                    Console.WriteLine("You are on the top floor.");
                }
            }

            // Move the cradle down
            else if (controlInput == "down")
            {
                currentFloor--;

                if (currentFloor != 0)
                {
                    Console.WriteLine($"The cradle moves to floor {currentFloor}.");
                }

                // Prevent cradle from going below ground level
                if (currentFloor == 0)
                {
                    currentFloor++; // Reset back to floor 1 if goes below ground accidentally
                }
            }

            // Invalid input
            else
            {
                Console.WriteLine("The cradle did not move");
            }
        }

        // Final statement after cleaning is done
        Console.WriteLine("The window cleaner steps out, having cleaned all the windows on the North side");
    }
}
