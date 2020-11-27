/*
Write a program that will display the user's letter grade based on their numerical average. 
Prompt the user for a number, and then display the corresponding letter grade based on the 10-point scale:
A 90 - 100
B 80 - 89.9
C 70 - 79.9
D 60 - 69.9
F < 60.0
*/

using System;
 
 class Lesson6Assignment
 {
      public static void Main( )
      {
            string strNumber, grade = "";
            int number;
 
            Console.Out.Write("Enter a number from 0 to 100: ");
            strNumber = Console.ReadLine();
            number = Convert.ToInt32(strNumber);
 
            if (number >= 90 && number <= 100)
                grade = "A";
            if (number >= 80 && number <= 89.9)
                grade = "B";
            else if (number >= 70 && number <= 79.9)
                grade = "C";
            else if (number >= 60 && number <= 69.9)
                grade = "D";
            else if (number < 60)
                grade = "F";
            else
			{
				Console.Out.Write("Please enter a valid number! ");
				return;
			}
			
 
            Console.Out.WriteLine("Your grade is: " + grade);
      }
 }