using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                bool isBig = true;

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        isBig = false;
                    }
                }
                if (isBig)
                {
                    Console.Write(arr[i] + " ");
                }
            }
                
        }
    }
}
