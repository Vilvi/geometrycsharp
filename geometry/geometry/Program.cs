using System;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // To check if the user wants to program to keep running.
        bool running = true;
        // Radius will be used in many calculations and will be asked for.
        double radius;
        // Choice is the choice of running the program again. Shape is which shape the user wishes to use. Formula is the choice of formula for the given shape. These are all input choices.
        char choice, shape, formula;

        while (running)
        {
            formula = AskFormula();
            if (formula == 'c')
            {
                radius = AskForRadius();
                Console.WriteLine("Circumference is: " + Calculations.CalcCircleCircumference(radius));

            } else if (formula == 'a')
            {
                radius = AskForRadius();
                Console.WriteLine("Area is: " + Calculations.CalcCircleArea(radius));
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
    }
    // Asks the user what the radius is and returns it.
    private static double AskForRadius()
    {
        Console.Write("What's the radius? ");
        // Checks if the string entered can be converted to a double.
        try
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Please enter a valid number");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
    // Asks for the which formula the user wishes to calculate in the given shape.
    private static char AskFormula()
    {
        Console.Write("Choose a formula c = circumference a = area ");
        // Checks if the user filled in a character.
        try
        {
            return Convert.ToChar(Console.ReadLine());
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Please enter a valid character (c / a)");
            return Convert.ToChar(Console.ReadLine());
        }
    }
}