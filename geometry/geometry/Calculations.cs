using System;

public class Calculations
{
	public float result;
	public char choice, formula;

	public Calculations()
	{
	}

	public float AskForRadius()
	{
		Console.Write("What is the radius? ");
		return System.Convert.ToFloat(System.Console.Readline());
	}

	public float CalcAreaCircle()
	{
        return Math.PI * Math.Pow(radius, 2);
    }
}
