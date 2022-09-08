using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = false;


            for (int i = 0; i < arr.Length; i++)
            {

                int sumLeft = 0;
                for (int k = 0; k < i; k++)
                {
                    sumLeft += arr[k];
                }
                int sumRight = 0;
                for (int l = arr.Length - 1; l > i; l--)
                {
                    sumRight += arr[l];
                }





                if (sumLeft == sumRight && !isEqual)
                {
                    Console.WriteLine(i);
                    isEqual = true;

                }


            }

            if (!isEqual)
            {
                Console.WriteLine("no");
            }


        }
    }
}
