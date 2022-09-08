using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int countLength = 0;
            int maxCount = 0;
            int index = 0;
            string num = string.Empty;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                    countLength++;
                    if (countLength > maxCount)
                    {
                        maxCount = countLength;
                        index = i;
                        num = arr[i].ToString();
                    }
                }
                else
                {
                    countLength = 0;
                }

            }
            for (int k = 0; k <= maxCount; k++)
            {
                Console.Write(num + " ");
            }



        }
    }
}
