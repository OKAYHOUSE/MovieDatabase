using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    internal class Validator
    {
        //Checks if value is between min and max
        public static bool InRange(int value, int min, int max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool InRange(double value, double min, double max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool InRange(float value, float min, float max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool InRange(decimal value, decimal min, decimal max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Return a number
        public static int GetUserNumberInt(string message)
        {
            int result = 0;
            Console.Write(message);
            //if parse fails, get input again
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("\nInvalid entry. Please enter a number between 1 and 5! ");
            }
            //input is now valid
            return result;
        }

        public static double GetUserNumberDouble(string message)
        {
            double result = 0;
            Console.Write(message);
            //if parse fails, get input again
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid entry\n");
            }
            //input is now valid
            return result;
        }
        public static float GetUserNumberFloat()
        {
            float result = 0;
            Console.Write("Please enter a number: ");
            //if parse fails, get input again
            while (!float.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("\nInvalid entry. Please try again");
            }
            //input is now valid
            return result;
        }
        public static decimal GetUserNumberDecimal()
        {
            decimal result = 0;
            Console.WriteLine("Please enter a number: ");
            //if parse fails, get input again
            while (!decimal.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("\nInvalid entry. Please try again\n");
            }
            //input is now valid
            return result;
        }

        public static bool GetContinue()
        {
            //default value
            bool result = true;
            //check if user wants to continue
            while (true)
            {
                Console.Write("Would you like to check another Genre? y/n: ");
                string choice = Console.ReadLine().Trim().ToLower();

                //Check user input
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    Console.Write("Goodbye.");
                    break;
                }
                else
                {
                    Console.Write("\nInvalid entry. Please try again: ");
                }
            }
            return result;
        }

        //Overloaded. Allows for custom message
        public static bool GetContinue(string message)
        {
            //default value
            bool result = true;
            //check if user wants to continue
            while (true)
            {
                Console.Write($"{message} y/n");
                string choice = Console.ReadLine().Trim().ToLower();

                //Check user input
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    Console.Write("Goodbye.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.\n");
                }
            }
            return result;
        }

        public static bool GetContinue(string message, string yes, string no)
        {
            //default value
            bool result = true;
            //check if user wants to continue
            while (true)
            {
                Console.Write($"{message} {yes}/{no}");
                string choice = Console.ReadLine().Trim().ToLower();

                //Check user input
                if (choice == yes.ToLower())
                {
                    result = true;
                    break;
                }
                else if (choice == no.ToLower())
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.\n");
                }
            }
            return result;
        }
    }
}