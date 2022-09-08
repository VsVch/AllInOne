using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < arr.Length / 2; i++)
            {

                string newSt = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = newSt;

            }



            //Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));



        }
    }
}
