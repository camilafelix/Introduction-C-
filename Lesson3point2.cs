public class Lesson3point2
{
	public static void Main()
	{
		// Get input from the user
		System.Console.Out.Write("Enter the first number: ");
		
		string num1String = System.Console.ReadLine();
		double num1 = System.Convert.ToDouble(num1String);
		
		System.Console.Out.Write("Enter the second number: ");
		
		string num2String = System.Console.ReadLine();
		double num2 = System.Convert.ToDouble(num2String);
		
		// Calculate the sum
		double sum = num1 + num2;
		
		// Display the result
		System.Console.WriteLine("The sum is " + sum);
	}
}