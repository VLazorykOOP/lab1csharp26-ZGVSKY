using System;

namespace Lab1
{
    public class Task2
    {
        public static void Execute()
        {
            Console.Write("двозначне число: ");
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            int first = num / 10;
            int second = num % 10;

            if (first > second)
                Console.WriteLine("перша більша.");
            else if (second > first)
                Console.WriteLine("друга більша.");
            else
                Console.WriteLine("однакові");
        }
    }
}