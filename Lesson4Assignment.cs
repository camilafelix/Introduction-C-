/*
Write a program that will calculate the hypotenuse of a right triangle. 
Have your Main method get the lengths of the two sides. 
It should then call on a method called calcHypotenuse. 
This method should take two doubles as parameters and return the hypotenuse as a double. 
Remember that to calculate the hypotenuse, you add the square of the first side to the square of the second side. 
Take the square root of that sum to get the hypotenuse. 
For example, to calculate a right triangle with sides of length 3 and 4:

hypotenuse = square root ( 3^2 + 4^2 ) = 5

*/

using System;

public class Lesson4Assignment
{	 
	public static void Main()
	{
		string strFirst, strSecond;
		double first, second, result;

		Console.Out.Write("Enter a number: ");
		strFirst = Console.ReadLine();
		first = Convert.ToInt32(strFirst);

		Console.Out.Write("Enter a second number: ");
		strSecond = Console.ReadLine();
		second = Convert.ToInt32(strSecond);
		
		result = calcHypotenuse(first, second);
		
		// Display the result
		System.Console.WriteLine("The result is " + result);
	}
	
	public static double calcHypotenuse(double number1, double number2)
	 {
		  double sqrNumber1, sqrNumber2, hypotenuse;
		  sqrNumber1 = Math.Pow(number1, 2);
		  sqrNumber2 = Math.Pow(number2, 2);
		  hypotenuse = Math.Sqrt(sqrNumber1 + sqrNumber2);
	 
		  return hypotenuse;
	 }
}