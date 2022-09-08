using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = string.Empty;
            string maxname = string.Empty;
            float radius = 0;
            double height = 0;
            double maxvalue = 0;

            double value = 0;

            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                radius = float.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());

                value = Math.PI * MathF.Pow(radius, 2) * height;

                if (value > maxvalue)
                {
                    maxvalue = value;
                    maxname = name;
                }
            }
            Console.WriteLine(maxname);

        }
    }
}
