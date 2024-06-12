using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dt2
{
    
        public class Android : Mobile
        {
         public string osversion;
         public Android(string brand,string model,string osversion):base(brand,model)
         {
            this.osversion = osversion;
         }
        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("OS Version:" + osversion);
        }

        }

    
}
