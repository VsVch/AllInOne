using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bp = decimal.Parse(Console.ReadLine());
            decimal dollars = (decimal)(1.31) * bp;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
