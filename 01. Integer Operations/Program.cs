using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());


            int add = first + second;
            int devide = add / third;
            int multiply = devide * four;

            Console.WriteLine(multiply);
        }
    }
}
