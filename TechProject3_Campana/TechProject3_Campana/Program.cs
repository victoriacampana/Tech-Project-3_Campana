// Tech Project #3 Iterative Statements
// Due Date: September 21, 2021

using System;

namespace TechProject3_Campana
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Asking user to input a value between 10 - 25 for KM conversion
            Console.WriteLine("Please enter the kilometer (KM) value here: ");

            try
            {
                // Creating a space for company to input the number in kilometers
                // Float 
                string inputdata = Console.ReadLine();
                float kilometers = float.Parse(inputdata);

                Console.WriteLine("You entered " + inputdata + " kilometers");

                // Start of if statement
                if ((kilometers >= 10) && (kilometers <= 25))
                {
                    
                    Console.WriteLine("Loop for iterating increments" + " " + kilometers.ToString() + " " + "Untill 200 KM");

                    // Loop 
                    for (float i = 0; i <= 200; i += kilometers)
                    {
                        // This states the previous input in kilometers. It will start with 0 and will increase with the input
                        // This states the miles once they are converted from kilometers.
                        Console.WriteLine("Kilometers: " + i);
                        Console.WriteLine("Miles: " + i * 0.621371);
                    }
                }
                // End of if statement
                // Start of else statement
                else
                {
                    // If input isn't between 10 and 25 
                    Console.WriteLine("You entered a value that isn't within the range. Please enter a value between 10 and 25");
                }
                // End of else statement
            }
            // End of try 
            catch
            {
                Console.WriteLine("Please enter only a numeric value between 10 and 25");
                Console.WriteLine("Please exit the program and try again");
            }
            // End of catch

        }
        // End of main

    }
    // End of class
}
