using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Mobile
    {
        protected string brand;
        protected string model;
        protected int batterylevel;
        protected Mobile(string brand,string model,int batterylevel) { 
            this.brand = brand;
            this.model = model;
            this.batterylevel = batterylevel;
        }
        public abstract void StartDevice();
        public abstract void UseDevice();
        public virtual void ShowDetails()
        {
            //Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Brand: {brand}, Model: {model}, Battery Level: {batterylevel}%");
        }
    }
}
