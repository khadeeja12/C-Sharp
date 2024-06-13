namespace EnumEx
{
    internal class Program
    {
        public enum Days //first letter caps
        {
            Sunday,
            Monday,
            tuesday,
            wednesday,
            Thursday,
            Friday,
            Saturday

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Days today= Days.wednesday;
            switch (today)
            {
                case Days.Sunday: Console.WriteLine("Sunday");break;
                case Days.Monday: Console.WriteLine("Monday");break;
                case Days.wednesday: Console.WriteLine("Wednesday");break;
            }
        }
    }
}
