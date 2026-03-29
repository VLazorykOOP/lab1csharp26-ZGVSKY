using System;

namespace Lab1
{
    public class Task5
    {
        public static void Execute()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine()!);

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"res: {Multiply(a, b)}");
        }
        
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}