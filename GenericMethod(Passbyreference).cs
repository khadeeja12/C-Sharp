using System;

namespace GenericMethodExample
{
    public class Utility
    {
        // Define a generic method to swap two elements
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    class Program
    {
        static void Main()
        {
            // Demonstrate Swap with integers
            int int1 = 1;
            int int2 = 2;
            Console.WriteLine($"Before Swap: int1 = {int1}, int2 = {int2}");
            Utility.Swap(ref int1, ref int2);
            Console.WriteLine($"After Swap: int1 = {int1}, int2 = {int2}");

            // Demonstrate Swap with strings
            string str1 = "Hello";
            string str2 = "World";
            Console.WriteLine($"\nBefore Swap: str1 = {str1}, str2 = {str2}");
            Utility.Swap(ref str1, ref str2);
            Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");

            // Demonstrate Swap with doubles
            double dbl1 = 1.23;
            double dbl2 = 4.56;
            Console.WriteLine($"\nBefore Swap: dbl1 = {dbl1}, dbl2 = {dbl2}");
            Utility.Swap(ref dbl1, ref dbl2);
            Console.WriteLine($"After Swap: dbl1 = {dbl1}, dbl2 = {dbl2}");
        }
    }
}
