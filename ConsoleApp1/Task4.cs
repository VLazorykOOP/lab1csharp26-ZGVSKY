using System;

namespace Lab1
{
    public class Task4
    {
        public static void Execute()
        {
            Console.Write("������ m (> 0): ");
            int m = int.Parse(Console.ReadLine()!);

            int currentMonth = (m % 12) + 1;

            string monthName = currentMonth switch
            {
                1 => "Січень",
                2 => "Лютий",
                3 => "Березень",
                4 => "Квітень",
                5 => "Травень",
                6 => "Червень",
                7 => "Липень",
                8 => "Серпень",
                9 => "Вересень",
                10 => "Жовтень",
                11 => "Листопад",
                12 => "Грудень",
                _ => "Помилка"
            };

            Console.WriteLine(monthName);
        }
    }
}