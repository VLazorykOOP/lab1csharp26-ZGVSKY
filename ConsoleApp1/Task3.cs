using System;

namespace Lab1
{
    public class Task3
    {
        public static void Execute()
        {
            Console.Write("x = ");
            float x = float.Parse(Console.ReadLine()!);

            Console.Write("y = ");
            float y = float.Parse(Console.ReadLine()!);

            float distanceSquared = x * x + y * y;
            float absX = Math.Abs(x);

            if (distanceSquared < 225 && y > absX)
            {
                Console.WriteLine("�yes");
            }
            else if (distanceSquared > 225 || y < absX)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("in line");
            }
        }
    }
}