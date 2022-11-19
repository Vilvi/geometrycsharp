using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool kørende = true;
        double pi, radius, resultat;
        char valg, formel;
        pi = Math.PI;

        while (kørende)
        {
            Console.Write("Vælg en formel: o=omkreds a=areal ");
            formel = Convert.ToChar(Console.ReadLine());
            if (formel == 'o')
            {
                Console.Write("Hvad er radius? ");
                radius = Convert.ToDouble(Console.ReadLine());
                resultat = 2 * pi * radius;
                Console.WriteLine("Omkreds er: " + resultat);

            } else if (formel == 'a')
            {
                Console.Write("Hvad er radius? ");
                radius = Convert.ToDouble(Console.ReadLine());
                resultat = pi * Math.Pow(radius, 2);
                Console.WriteLine("Areal er: " + resultat);
            }
            Console.Write("Vil du køre igen? j/n ");
            valg = Convert.ToChar(Console.ReadLine());
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