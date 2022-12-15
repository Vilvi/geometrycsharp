using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    internal class UserInput
    {
        public static double AskForRadius()
        {
            // Asks the user to inpu a radius, then converts it to a double. Catches exception if a non double is entered.
            Console.Write("Enter the radius: ");
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
