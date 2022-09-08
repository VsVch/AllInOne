using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (sum > 255)
                {
                    sum -= num;
                    Console.WriteLine($"Insufficient capacity!");
                }


            }
            Console.WriteLine(sum);
        }
    }
}
