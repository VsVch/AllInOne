﻿using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string delimiter = Console.ReadLine();



            Console.WriteLine($"{first}{delimiter}{second}");
        }
    }
}
