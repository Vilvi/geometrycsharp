using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool running = true;
        double pi, radius, result;
        char choice, formula;
        pi = Math.PI;

        while (running)
        {
            Console.Write("Choose a formula c = circumference a = area ");
            formula = Convert.ToChar(Console.ReadLine());
            if (formula == 'c')
            {
                Console.Write("What's the radius? ");
                radius = Convert.ToDouble(Console.ReadLine());
                result = 2 * pi * radius;
                Console.WriteLine("Circumference is: " + result);

            } else if (formula == 'a')
            {
                Console.Write("What's the radius? ");
                radius = Convert.ToDouble(Console.ReadLine());
                result = pi * Math.Pow(radius, 2);
                Console.WriteLine("Area is: " + result);
            }
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