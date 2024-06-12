using System;

class Program
{
    static void Main()
    {
        // Implicit casting
        int intValue = 10;
        double doubleValue = intValue;
        Console.WriteLine("Implicit casting: " + doubleValue);

        // Explicit casting
        doubleValue = 10.5;
        intValue = (int)doubleValue;
        Console.WriteLine("Explicit casting: " + intValue);

        // Using Convert class
        string strValue = "123";
        intValue = Convert.ToInt32(strValue);
        Console.WriteLine("Convert class: " + intValue);

        // Using Parse method
        strValue = "456";
        intValue = int.Parse(strValue);
        Console.WriteLine("Parse method: " + intValue);

        // Using TryParse method
        strValue = "789";
        bool success = int.TryParse(strValue, out intValue);
        if (success)
        {
            Console.WriteLine("TryParse method: " + intValue);
        }
        else
        {
            Console.WriteLine("Conversion failed.");
        }

        // Using 'as' operator
        object obj = "Hello, World!";
        strValue = obj as string;
        if (strValue != null)
        {
            Console.WriteLine("'as' operator: " + strValue);
        }
        else
        {
            Console.WriteLine("Conversion failed.");
        }

        // Using 'is' operator
        if (obj is string strValue2)
        {
            Console.WriteLine("'is' operator: " + strValue2);
        }
        else
        {
            Console.WriteLine("Conversion failed.");
        }
    }
}