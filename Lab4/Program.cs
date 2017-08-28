using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;

            while(run)

            {
                //Global variable for the scope of the forloop 

                double factorial = 0;
                Console.WriteLine("Please enter a number in between 1 and 10");
                double userInput = double.Parse(Console.ReadLine());

                // Factorial of number entered by user

                Console.WriteLine();
                if (userInput > 1 && userInput < 11)
                {

                    for (double i = userInput; i > 0; i--)
                    {
                        factorial = userInput * (userInput - 1);
                    }

                    Console.WriteLine("The factorial of " + userInput + " is " + factorial);
                }

                if (userInput == 0)
                {
                    Console.WriteLine("There is no such thing as the factorial of 0!");
                }


                if (userInput == 1)
                {
                    Console.WriteLine("The factorial of 1 is 1. Duh!");
                }


                if (userInput > 10 && userInput < 1)
                {
                    Console.WriteLine("I am sorry, that number is way to big. Could you please enter in a number in between 1 and 10.");
         
                }

                run = Continue();
                Console.WriteLine();
            }
        }





            public static Boolean Continue()
        {
              bool run = true;

                Console.WriteLine("Would you like to continue, Yes or No?");
                string userInput = Console.ReadLine();

                if (userInput == "yes")
                {
                    run = true;
                }

                if (userInput == "no")
                {
                Console.WriteLine("We hate to see you go! Hopefully we will see you soon.");
                run = false;
                }

                if (userInput != "no" && userInput != "yes")
                {
                    Console.WriteLine("I am sorry you entered in nvalid input. Please try again");
                    run = Continue();
                }

            return run;
        }

    }
}
