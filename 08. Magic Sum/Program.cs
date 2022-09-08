using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length-1; i++)
            {

                for (int j = arr.Length-1; j > i; j--)
                {
                    if ((arr[j] + arr[i]) == num)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }
                }
                


            }




        }
    }
}
