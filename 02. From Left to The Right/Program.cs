using System;
using System.Numerics;

namespace _2.fromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string left = string.Empty;
                string right = string.Empty;
                bool space = false;
                for (int j = 0; j < input.Length; j++)
                {
                    if (char.Parse(Convert.ToString(input[j])) == ' ')
                    {
                        space = true;
                        continue;
                    }
                    if (!space)
                    {
                        left += (input[j]);
                    }
                    else
                    {
                        right += (input[j]);
                    }
                }
                float sum = 0;
                if (double.Parse(Convert.ToString(left)) > double.Parse(Convert.ToString(right)))
                {

                    for (int k = 0; k < Convert.ToString(left).Length; k++)
                    {
                        bool symbol = int.TryParse(Convert.ToString(left[k]), out int digit);
                        sum += digit;
                    }
                }
                else
                {
                    for (int k = 0; k < Convert.ToString(right).Length; k++)
                    {
                        bool symbol = int.TryParse(Convert.ToString(right[k]), out int digit);
                        sum += digit;
                    }
                }
                Console.WriteLine(sum);
                Console.WriteLine( $"{double.Parse(Convert.ToString(left))}"); 
            }
        }
    }
}