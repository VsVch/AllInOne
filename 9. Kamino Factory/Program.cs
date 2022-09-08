using System;
using System.Linq;

namespace _02_SecondExercise
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            string input = string.Empty;

            int[] bestArr = new int[num];
            int bestLength = int.MinValue;
            int bestIndex = int.MinValue;
            int bestSum = int.MinValue;
            int bestStart = 0;
            int index = 1;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] arr = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int length = int.MinValue;
                int currIndex = int.MinValue;
                int currSubLength = 0;
                int currSubIndex = 0;
                bool isOne = false;

                for (int i = 0; i < num; i++)
                {
                    if (arr[i] == 1 && isOne)
                    {
                        currSubLength++;
                    }
                    else if (arr[i] == 1)
                    {
                        isOne = true;
                        currSubIndex = i;
                        currSubLength = 1;
                    }
                    else if (arr[i] == 0 && isOne)
                    {
                        if (currSubLength > length)
                        {
                            length = currSubLength;
                            currIndex = currSubIndex;
                        }
                        isOne = false;
                        currSubLength = 0;
                        currSubIndex = 0;
                    }
                }

                if (isOne)
                {
                    if (currSubLength > length)
                    {
                        length = currSubLength;
                        currIndex = currSubIndex;
                    }
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestIndex = currIndex;
                    bestSum = arr.Sum();
                    bestArr = arr;
                    bestStart = index;
                }
                else if (length == bestLength)
                {
                    if (currIndex < bestIndex)
                    {
                        bestLength = length;
                        bestIndex = currIndex;
                        bestSum = arr.Sum();
                        bestArr = arr;
                        bestStart = index;
                    }
                    else if (currIndex == bestIndex)
                    {
                        if (arr.Sum() > bestSum)
                        {
                            bestLength = length;
                            bestIndex = currIndex;
                            bestSum = arr.Sum();
                            bestArr = arr;
                            bestStart = index;
                        }
                    }
                }
                index++;
                //input = Console.ReadLine();


            }

            Console.WriteLine($"Best DNA sample {bestStart} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestArr));
        }
    }
}