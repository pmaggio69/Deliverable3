// Author: Patrick Maggio
// Create an iterative statement to deliver numbers based on user input


using System;

namespace Deliverable3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while(true) 
            {
                Console.WriteLine("Enter an interger number between 1 and 100: ");
                input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <= 100)
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Specify the series type: Even or Odd");
                series = Console.ReadLine();

                if (series == "Even" || series == "Odd")
                {
                    break;
                }
            }

            if (series == "Odd")
            {
                Console.WriteLine("You have selected " + series +
                    " series. The number between 0 and " + input + "are:");
                for (int i = 1; i <= input; i +=2 )
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "Even")
            {
                Console.WriteLine("You have selected " + series +
                    " series. The number between 0 and " + input + "are:");
                for (int i = 0; i <= input; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}