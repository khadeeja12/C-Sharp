using System;

class Program
{
    public void Add<T>(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        T sum = x + y;
        Console.WriteLine($"Result of adding {a} and {b} : {sum}");

    }

    static void Main( string[] args )
    {
        int x = 1;
        int y = 2;
        Program obj = new Program();
        obj.Add(x,y);

    }
}
