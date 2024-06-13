// See https://aka.ms/new-console-template for more information
namespace Abstraction
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone mysmart = new Smartphone("Samsung","S23",70,"android 12");
            FeaturePhone myfeature = new FeaturePhone("Iphone", "14 pro max", 80, 54);
            mysmart.StartDevice();
            mysmart.UseDevice();
            myfeature.StartDevice();
            myfeature.UseDevice();

            mysmart.ShowDetails();
            myfeature.ShowDetails();
        }
    }
}

