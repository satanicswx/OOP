using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            task1();
            task2();
            task3();
        }

        private static void task1()
        {
            for (int i = 2; i <= 20; i += 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");
        }

        private static void task2()
        {
            int sum = 0;
            while (true)
            {
                Console.Write("Введіть число: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number == 0) break;
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Некоректне введення! Введіть число.");
                }
            }
            Console.WriteLine("Сума: " + sum);
            Console.WriteLine("\n");
        }

        private static void task3()
        {
            const string correctPassword = "1234";
            string input;

            do
            {
                Console.Write("Введіть пароль: ");
                input = Console.ReadLine();

                if (input != correctPassword)
                {
                    Console.WriteLine("Неправильний пароль!");
                }
            }
            while (input != correctPassword);

            Console.WriteLine("Доступ дозволено");

        }
    }
}
