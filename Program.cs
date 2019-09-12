/*
Name: Sasa Subotic
Class: ISM4300
Project Name: Deliverable 2 - Conditional Statement
*/
using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writes the introduction and asks the user for the input of the grade integer
            Console.WriteLine("Please enter what percentage grade you expect to get in ISM4300: ");

            //Try-catch to get any exceptions to an integer input
            try
            {
                //Declaring strings and variables for the program to read
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                //reads the inputs and shows a letter grade result
                if (grade >= 98 && grade < 101)
                {
                    Console.WriteLine("Congratulations! You have an A+!");
                }

                else if (grade < 98 && grade >= 92)
                {
                    Console.WriteLine("Congratulations! You have an A!");
                }

                else if (grade < 92 && grade >= 90)
                {
                    Console.WriteLine("Congratulations! You have an A-!");
                }

                else if (grade < 90 && grade >= 88)
                {
                    Console.WriteLine("Good job! You have an B+!");
                }

                else if (grade < 88 && grade >= 82)
                {
                    Console.WriteLine("Good job! You have an B!");
                }

                else if (grade < 82 && grade >= 80)
                {
                    Console.WriteLine("Good job! You have an B-!");
                }

                else if (grade < 80 && grade >= 78)
                {
                    Console.WriteLine("Nice! you have a C+!");
                }

                else if (grade < 78 && grade >= 72)
                {
                    Console.WriteLine("Nice! you have a C!");
                }

                else if (grade < 72 && grade >= 70)
                {
                    Console.WriteLine("Nice! you have a C-!");
                }

                else if (grade < 70 && grade >= 68)
                {
                    Console.WriteLine("Almost there! you have a D+!");
                }

                else if (grade < 68 && grade >= 62)
                {
                    Console.WriteLine("Almost there! you have a D!");
                }

                else if (grade < 62 && grade >= 60)
                {
                    Console.WriteLine("Almost there! you have a D-!");
                }

                else if (grade < 60 && grade >= 0)
                {
                    Console.WriteLine("Keep working harder! you have a F!");
                }

                //If a interger not between 0-100 is inputted, this "error message" appears
                else
                {
                    Console.WriteLine("This is not a valid number between 0 and 100 on the grading scale, please try again");
                }
            }

            //This will catch all inputs not integer based.
            catch
            {
                Console.WriteLine("Please use a integer number, as we are asking between a scale of 1 and 100");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }

        }
    }
}
