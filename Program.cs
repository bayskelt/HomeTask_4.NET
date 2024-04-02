using System;
namespace HomeTask_4.NET
{
    internal class Program
    {
        static void Main()
        {
            Console.Write($"Введiть кiлькiсть елементiв списку: ");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введiть {i + 1} елемент списку: ");
                mas[i] = int.Parse(Console.ReadLine());
            }

            int min = mas[0];
            int max = mas[0];

            for (int i = 1; i < n; i++)
            {
                if (min > mas[i])
                {
                    min = mas[i];
                }
                if (max < mas[i])
                {
                    max = mas[i];
                }
            }

            Console.Write($"Сума максимального та мiнiмального чисел дорiвнює {min + max}");
        }
    }
}
