using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n(1-6):");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1": Task1.Execute(); break;
                    case "2": Task2.Execute(); break;
                    case "3": Task3.Execute(); break;
                    case "4": Task4.Execute(); break;
                    case "5": Task5.Execute(); break;
                    case "6": Task6.Execute(); break;
                    case "0": return;
                    default: Console.WriteLine("Невірний вибір."); break;
                }
            }
        }
    }
}