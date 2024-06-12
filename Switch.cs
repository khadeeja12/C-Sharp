// See https://aka.ms/new-console-template for more information
﻿using System;

namespace evenodd
{
    class OddorEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day between 1-7");
            string input = Console.ReadLine();
            int day;

            // Validate and parse the input
            if (int.TryParse(input, out day) && day >= 1 && day <= 7)
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Day is Monday");
                        break;
                    case 2:
                        Console.WriteLine("Day is Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Day is Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Day is Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Day is Friday");
                        break;
                    case 6:
                        Console.WriteLine("Day is Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Day is Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid day entered");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number between 1 and 7.");
            }
        }
    }
}
