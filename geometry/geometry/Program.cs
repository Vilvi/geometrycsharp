using System;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // To check if the user wants to program to keep running.
        bool running = true;
        double pi, radius, result;
        char choice, formula;
        // To get pi, used in many geometry formulas.
        pi = Math.PI;

        while (running)
        {
            formula = AskFormula();
            if (formula == 'c')
            {
                radius = AskForRadius();
                Console.WriteLine("Circumference is: " + CalculateCircumference(radius));

            } else if (formula == 'a')
            {
                radius = AskForRadius();
                Console.WriteLine("Area is: " + CalculateArea(radius));
            }
            // Ask the user if they want to run again. 'y' changes the running boolean to true to keep the program running.
            Console.Write("Do you want to run again? y/n ");
            choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'y')
            {
                running = true;
            }
            else
            {
                running = false;
            }
        }
        // Calculates the circumference when given the radius.
        double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        // Calculates the area when given the radius.
        double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        // Asks the user what the radius is and returns it.
        double AskForRadius()
        {
            Console.Write("What's the radius? ");
            return Convert.ToDouble(Console.ReadLine());
        }
        // Asks for the which formula the user wishes to calculate in the given shape.
        char AskFormula()
        {
            Console.Write("Choose a formula c = circumference a = area ");
            return Convert.ToChar(Console.ReadLine());
        }
    }
}