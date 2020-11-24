/*
A friend of yours has a job installing carpet. 
To better serve their customers, your friend asks you to write a program that will calculate the cost of carpeting a client's floor. 
Write a program that will ask the user for the length and width of the room in feet. 
Next, ask the user for the cost of the carpet per square foot in dollars and cents. 
Using this information, calculate and display in a friendly, descriptive sentence, 
the area of the room (area = length * width) 
and the cost of carpeting that room (cost = area * price per square foot).
*/

public class Lesson3Assignment
{
	public static void Main()
	{
		// Get input from the user
		System.Console.Write("Enter the length of the room (in feet): ");
		string lengthString = System.Console.ReadLine();
		double length = System.Convert.ToDouble(lengthString);
		
		System.Console.Write("Enter the width of the room (in feet): ");
		string widthString = System.Console.ReadLine();
		double width = System.Convert.ToDouble(widthString);
				
		System.Console.Write("Enter the cost of the carpet per square foot (in dollars and cents): ");
		string costPerSquareString = System.Console.ReadLine();
		double costPerSquare = System.Convert.ToDouble(costPerSquareString);
		
		double area = length * width;
		decimal cost = System.Convert.ToDecimal(area * costPerSquare);
				
		System.Console.WriteLine("The area of the room is {0} feet", area);
		System.Console.WriteLine("The cost of carpeting is $" + cost);
	}
}