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

	public static double CalcTriangleArea(double length, double height)
	{
		return 0.5 * length * height;
	}

	public static double CalcTriangleCicumference(double side1, double side2, double side3)
	{
		return side1 * side2 * side3;
	}

	public static double CalcSquareArea(double length, double height)
	{
		return length * height;
	}

	public static double CalcSquareCircumference(double length)
	{
		return 4 * length;
	}
}
