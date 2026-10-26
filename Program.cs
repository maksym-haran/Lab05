using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string error = "Помилка введення числа\n";
            double a, b, h;

            // --- БЛОК ВВЕДЕННЯ ДАНИХ ---
            Console.Write("Введіть < a > - ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(error);
                Console.Write("Введіть < a > знову - ");
            }

            Console.Write("Введіть < b > - ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine(error);
                Console.Write("Введіть < b > знову - ");
            }

            Console.Write("Введіть < h > - ");
            while (!double.TryParse(Console.ReadLine(), out h) || h <= 0)
            {
                Console.WriteLine("Помилка введення, h має бути додатним числом\n");
                Console.Write("Введіть < h > знову - ");
            }

            // --- ЦИКЛ ОБЧИСЛЕННЯ ---
            if (a > b)
            {
                Console.WriteLine("\n'a' не може бути більше за 'b', тіло циклу не виконується.");
            }
            else
            {
                Console.WriteLine("\n   x\t|\ty\t|\tЗначення y");
                Console.WriteLine("------------------------------------------");

                for (double x = a; x <= b; x += h)
                {
                    // формула
                    double y = x * x - 4 * x + 3;

                    if (y < 0)
                    {
                        Console.WriteLine($"{x:F2}\t|\t{y:F2}\t|\tвід'ємне");
                    }
                    else
                    {
                        Console.WriteLine($"{x:F2}\t|\t{y:F2}\t|\tдодатне або 0");
                    }
                }
            }

            // --- БЛОК - КВАДРАТ ---
            Console.WriteLine("\n=== БЛОК - КВАДРАТ ===");
            Console.Write("Введіть число n (від 3 до 20): ");
            int n;

            // перевірка n на межі 3 - 20
            while (!int.TryParse(Console.ReadLine(), out n) || n < 3 || n > 20)
            {
                Console.WriteLine("Помилка! Число має бути цілим в межах від 3 до 20.");
                Console.Write("Введіть n знову: ");
            }

            Console.WriteLine();

            // малювання квадрата
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // головна та побічна діагональ
                    if (i == j || i + j == n - 1)
                    {
                        Console.Write("#");
                    }
                    // межі квадрата
                    else if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}