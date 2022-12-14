using System;
using System.Security.Cryptography.X509Certificates;

public class Calculations
{
	// Takes pi from the Math object and makes it into a variable that is easier to write. Also makes it static so the static method can use it.
	static double pi = Math.PI;
	
	public static double CalcCircleArea(double radius)
	{
		return pi * Math.Pow(radius, 2);
    }
	public static double CalcCircleCircumference(double radius)
	{
        return 2 * pi * radius;
    }
}
