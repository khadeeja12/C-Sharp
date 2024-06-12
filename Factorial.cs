// See https://aka.ms/new-console-template for more information
using System;

public class program1
{
    
        static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.WriteLine("Enter any number:");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + number + " is : " + fact);

    }
    
}

