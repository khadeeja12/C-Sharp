using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dt2
{
    public class Mobile
    {
        
            public string brand;
            public string model;
            public int batterylevel;
            public Mobile(string brand, string model)
            {
            this.brand = brand;
            this.model = model;  
            this.batterylevel = 0;
            }
            public void MakeCall(string phoneNo)
            {
                Console.WriteLine(phoneNo);
            }
            public void ChargeBattery(int amount)
            {
              batterylevel = amount;
             //Console.WriteLine("Enter the amount to increase battery level:");
            //amount = int.Parse(Console.ReadLine());
            //batterylevel = batterylevel + amount;
            Console.WriteLine("Battery level after charging: " + batterylevel);
        }
            public void UseBattery(int amount)
            {
            batterylevel = batterylevel - amount;
            Console.WriteLine("Battery level after usage: " + batterylevel);
        }
             public virtual void PrintDetails()
             {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Battery Level: " + batterylevel);


        }
        
    }
}
