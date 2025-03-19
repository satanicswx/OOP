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
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            task1();
            task2();
            task3();
        }

        public static void task1()
        {
            Console.WriteLine("Завдання 1: Перевірка парності числа");
            Console.WriteLine(IsEven(8)); // очікується: True
            Console.WriteLine(IsEven(7)); // очікується: False
        }

        public static void task2()
        {
            Console.WriteLine("\nЗавдання 2: Перевантаження функції Sum");
            Console.WriteLine(Sum(5, 10));      // очікується: 15
            Console.WriteLine(Sum(2, 3, 4));    // очікується: 9
            Console.WriteLine(Sum(2.5, 3.1));   // очікується: 5.6
        }

        public static void task3()
        {
            Console.WriteLine("\nЗавдання 3: Функція з ref (Swap)");
            int a = 5, b = 10;
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}"); // очікується: a = 10, b = 5
        }

        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        private static double Sum(double a, double b)
        {
            return a + b;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
