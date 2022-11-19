using System;

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
            // User chooses which formula for the chosen shape they want to use.
            Console.Write("Choose a formula c = circumference a = area ");
            // Saves the user choice in a variable called "formula", and converts it to a char to save space, since the input is always going to be 1 character.
            formula = Convert.ToChar(Console.ReadLine());
            if (formula == 'c')
            {
                // Asks for the radius and puts it into a circumference formula and then outputs the result.
                Console.Write("What's the radius? ");
                radius = Convert.ToDouble(Console.ReadLine());
                result = 2 * pi * radius;
                Console.WriteLine("Circumference is: " + result);

            } else if (formula == 'a')
            {
                // Asks for the radius and puts it into a area formula and then outputs the result.
                Console.Write("What's the radius? ");
                radius = Convert.ToDouble(Console.ReadLine());
                result = pi * Math.Pow(radius, 2);
                Console.WriteLine("Area is: " + result);
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
}