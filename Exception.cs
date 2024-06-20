using System;

namespace ExceptionExample
{
    public class ExceptionDemo
    {
        static void Main()
        {
            try
            {
                object[] array = new object[5]; // this object array can be of any type
                array[0] = "String element";
                array[1] = 42;
                array[2] = new object[5]; // array of objects
                Console.WriteLine("No Exception occurred");
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine("ArrayTypeMismatchException occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred: " + ex.Message);
            }
        }
    }
}
