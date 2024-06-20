using System;

namespace ExceptionExample
{
    public class ExceptionDemo
    {
        static void Main()
        {
            try
            {
                // Creating an object array and assigning a string array
                object[] objArray = new string[10];
                // Attempting to assign an integer to an element of the string array through object array reference
                objArray[0] = 42;  // This will cause ArrayTypeMismatchException at runtime

                // This line will not be executed
                Console.WriteLine("No Exception occurred in the first try block");
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine("ArrayTypeMismatchException occurred: " + ex.Message);
            }

            try
            {
                // Creating an array of integers with 5 elements
                int[] numbers = new int[5];
                // Attempting to access an element at index 10 (which is out of range)
                int value = numbers[10];  // This will cause IndexOutOfRangeException

                // This line will not be executed
                Console.WriteLine("No Exception occurred in the second try block");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException occurred: " + e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
        }
    }
}
