using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] first = new int[number];
            int[] second = new int[number];

            for (int i = 0; i < number; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    first[i] = arr[0];
                    second[i] = arr[1];
                }
                else
                {
                    first[i] = arr[1];
                    second[i] = arr[0];
                }




            }


            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
        }
    }
}
