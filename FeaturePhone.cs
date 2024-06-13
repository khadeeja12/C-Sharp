using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class FeaturePhone : Mobile
    {
        public int buttoncount;
        public FeaturePhone(string brand, string model, int batterylevel, int buttoncount) : base(brand, model, batterylevel)
        {
            this.buttoncount = buttoncount;
        }
        public override void StartDevice()
        {
            Console.WriteLine("Brand:" + brand + "is starting.....");
        }
        public override void UseDevice()
        {
            Console.WriteLine("Using" + model);
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("ButtonCount :" + buttoncount);
        }
    }
}
