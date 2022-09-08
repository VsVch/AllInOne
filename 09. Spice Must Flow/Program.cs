using System;
using System.Numerics;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int countDays = 0;
            int allYield = 0;


            if (startingYield < 100)
            {
                Console.WriteLine(countDays);
                Console.WriteLine(allYield);
            }
            else
            {
                while (startingYield >= 100)
                {
                    countDays++;
                    allYield += startingYield - 26;
                    startingYield -= 10;

                }
                allYield -= 26;

                Console.WriteLine(countDays);
                Console.WriteLine(allYield);
            }

            
        }

        
    }
}
