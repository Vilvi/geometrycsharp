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
            switch (UserInput.AskShape())
            {
                // c = circle.
                case 'c':
                    // Asks which formula in the given shape the user wishes to know.
                    switch (UserInput.AskFormula())
                    {
                        // c = circumference.
                        case 'c':
                            Console.WriteLine($"The circumference is: {Calculations.CalcCircleCircumference(UserInput.AskNumber("radius"))}");
                            break;
                        // a = area.
                        case 'a':
                            Console.WriteLine($"Area is: {Calculations.CalcCircleArea(UserInput.AskNumber("radius"))}");
                            break;
                        default:
                            Console.WriteLine("Please enter a valid letter for the formula you wish to calculate. a = area, c = circumference");
                            break;

                    }
                    break;

                case 't':
                    switch (UserInput.AskFormula())
                    {
                        case 'a':
                            double triBase = UserInput.AskNumber("length");
                            double triHeight = UserInput.AskNumber("height");
                            Console.WriteLine($"Area is: {Calculations.CalcTriangleArea(triBase, triHeight)}");
                            break;
                    }
                break;
            }

            // Ask the user if they want to run again. 'y' changes the running boolean to true to keep the program running.
            choice = UserInput.AskContinue();
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
}