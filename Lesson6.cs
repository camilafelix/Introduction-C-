using System;
 
 class Lesson6
 {
      public static void Main( )
      {
            string strHours, strRate, strAnswer;
            double hours, rate, pay;
            char answer;
 
            Console.Out.Write("How many hours did you work last week? ");
            strHours = Console.ReadLine();
            hours = Convert.ToDouble(strHours);
 
            Console.Out.WriteLine();
            Console.Out.Write("What is your hourly rate? ");
            strRate = Console.ReadLine();
            rate = Convert.ToDouble(strRate);
 
            if (hours <= 40.0)
                  pay = hours * rate;
            else
            {
                  pay = hours * rate;
 
                  // Calculate overtime pay as time 
                  //   and a half for all
                  //   hours over 40
                  pay = pay + ( (hours - 40) * (rate / 2.0) );
            }
 
            Console.Out.WriteLine();
            Console.Out.WriteLine("Your weekly pay is: " + pay);
 
            Console.Out.WriteLine();
            Console.Out.WriteLine("Are you happy with your pay? (Y/N)");
            strAnswer = Console.ReadLine();
            answer = Convert.ToChar(strAnswer);
 
            if (answer == 'y' || answer == 'Y')
                  Console.Out.WriteLine("I'm glad that you are happy!");
            else
                  Console.Out.WriteLine("Maybe next week you can work more hours");
      }
 }