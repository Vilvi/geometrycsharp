using geometry;
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
            // Asks which formula in the given shape the user wishes to know.
            formula = AskFormula();
            switch (formula)
            {
                // c = circumference.
                case 'c':
                    Console.WriteLine($"Circumference is: {Calculations.CalcCircleCircumference(UserInput.AskForRadius())}.");
                    break;
                // a = area.
                case 'a':
                    Console.WriteLine($"Area is: {Calculations.CalcCircleArea(UserInput.AskForRadius())}");
                    break;
                default:
                    Console.WriteLine("Please enter a valid letter for the formula you wish to calculate. a = area, c = circumference");
                    break;

            }
            // Ask the user if they want to run again. 'y' changes the running boolean to true to keep the program running.
            choice = UserInput.AskForContinue();
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