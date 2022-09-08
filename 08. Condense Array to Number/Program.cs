using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int count = arr.Length;
            int[] condensed = new int[count]; 

            if (arr.Length == 1)
            {
                sum = arr[0];
                Console.WriteLine(sum);
                return;
            }
            else
            {



                while (count >= 0)
                {

                    for (int i = 0; i < count -1 ; i++)
                    {

                        condensed[i] = arr[i] + arr[i + 1];
                        arr[i] = condensed[i];
                        sum = arr[i];
                    }



                    count--;
                }
                Console.WriteLine(sum);
                
            }


        }
    }
}
