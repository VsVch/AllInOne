using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split().ToArray();
            string[] second = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < second.Length; i++)
            {
                for (int k = first.Length-1; k >= 0; k--)
                {
                    if (second[i] == first[k])
                    {
                        Console.Write(second[i] + ' ');
                    }
                }
            }


        }
    }
}
