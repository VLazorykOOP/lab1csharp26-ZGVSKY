using System;

namespace Lab1
{
    public class Task1
    {
        public static void Execute()
        {
            Console.Write("������ ����� a: ");
            double a = double.Parse(Console.ReadLine()!);

            Console.Write("������ ����� b: ");
            double b = double.Parse(Console.ReadLine()!);

            double s = 0.5 * a * b;
            Console.WriteLine($"�����: {s}");
        }
    }
}