using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class UserInput
    {
        public static char AskForShape()
        {
            Console.Write("Which shape do you wish to calculate?: ");
            try
            {
                return Convert.ToChar(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please enter a shape. t = triangle, c = circle, s = square");
                return Convert.ToChar(Console.ReadLine());
            }
        }
        // Asks for the which formula the user wishes to calculate in the given shape.
        public static char AskFormula()
        {
            Console.Write("Choose a formula c = circumference a = area ");
            // Checks if the user filled in a character.
            try
            {
                return Convert.ToChar(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a valid character (c / a)");
                return Convert.ToChar(Console.ReadLine());
            }
        }

        public static double AskForRadius()
        {
            // Asks the user to inpu a radius, then converts it to a double. Catches exception if a non double is entered.
            Console.Write("Please enter the radius: ");
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please enter a number: ");
                return Convert.ToDouble(Console.ReadLine());
            }
        }

        public static double AskForHeight()
        {
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please enter a number: ");
                return Convert.ToDouble(Console.ReadLine());
            }
        }

        public static double AskForNumber(string number)
        {
            Console.Write($"Please enter the {number}: ");
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please enter a number: ");
                return Convert.ToDouble(Console.ReadLine());
            }
        }

        public static char AskForContinue()
        {
            // Asks the user to input an answer for whether or not they want to continue. If they enter 'y' or 'n' the catch is not triggered.
            try
            {
                Console.Write("Do you wish to continue? y/n: ");
                return Convert.ToChar(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please enter y for yes or n for no: ");
                return Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
