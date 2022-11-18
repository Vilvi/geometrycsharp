using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool kørende = true;
        double pi, radius, resultat;
        pi = Math.PI;

        while (kørende)
        {
            Console.Write("Hvad er radius? ");
            radius = Convert.ToDouble(Console.ReadLine());
            resultat = 2 * pi * radius;
            Console.WriteLine("Omkreds er: " + resultat);
            Console.Write("Vil du køre igen? j/n ");
            char valg = Convert.ToChar(Console.ReadLine());
            if (valg == 'j')
            {
                kørende = true;
            }
            else
            {
                kørende = false;
            }
        }
    }
}