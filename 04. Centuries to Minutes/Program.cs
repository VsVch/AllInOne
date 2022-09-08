﻿using System;
using System.Numerics;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            BigInteger hours = (int)days * 24;
            BigInteger minuties = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days:f0} days = {hours} hours = {minuties} minutes");


        }
    }
}
