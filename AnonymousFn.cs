
using System;
class Program
{
  public delegate int SumDeligate(int x, int y);    //declare a deligate
    public static void Main(string[] args)
    {
        SumDeligate sd1 = delegate (int x, int y) { return x + y; };  //lambda expression for anonymous fn
        Console.WriteLine(sd1(32, 21));

    }
}
