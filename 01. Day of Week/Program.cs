using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int day = int.Parse(Console.ReadLine());

            if (day>0 && day<=days.Length)
            {
                Console.WriteLine($"{days[day-1]}");
            }
            else
            {
                Console.WriteLine($"Invalid day!");
            }



        }
    }
}
