// See https://aka.ms/new-console-template for more information
namespace dt2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Android myAndroid = new Android("Samsung", "Galaxy S21","Android 12");

 
            Console.WriteLine("Initial Android Details:");
            myAndroid.PrintDetails();


            myAndroid.MakeCall("123-456-7890");

            
            Console.WriteLine("\nCharging the battery:");
            myAndroid.ChargeBattery(70);  

            Console.WriteLine("\nUsing the battery:");
            myAndroid.UseBattery(20);

            
            Console.WriteLine("\nFinal Andorid Details:");
            myAndroid.PrintDetails();

        }
    }
}
