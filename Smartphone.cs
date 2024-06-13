using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Smartphone : Mobile
    {
        public string osversion;
        public Smartphone(string brand,string model,int batterylevel,string osversion):base (brand, model, batterylevel) { 
            this.osversion=osversion;
        }
        public override void StartDevice()
        {
            Console.WriteLine("Brand:" + brand+ "is starting.....");    
        }
        public override void UseDevice()
        {
            Console.WriteLine("Using"+model);
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Osversion :" + osversion);
        }

    }
}
