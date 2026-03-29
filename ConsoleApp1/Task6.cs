using System;

namespace Lab1
{
    public class Task6
    {
        public static void Execute()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine()!);

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine()!);

            double result = (3.0 / (n + m * m + 1) + 1) * (m - n);
            Console.WriteLine($"res: {result}");
        }
    }
}