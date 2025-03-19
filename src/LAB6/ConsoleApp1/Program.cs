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
            task4();
            task5();
            task6();
        }

        private static void task1()
        {
            Console.Write("Введіть число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                    Console.WriteLine("Результат: Число парне.");
                else
                    Console.WriteLine("Результат: Число непарне.");
            }
            else
            {
                Console.WriteLine("Помилка: введіть коректне ціле число!");
            }
        }

        private static void task2()
        {
            Console.Write("Введіть вашу оцінку (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                if (grade >= 90 && grade <= 100)
                    Console.WriteLine("Ваша оцінка: A");
                else if (grade >= 75 && grade < 90)
                    Console.WriteLine("Ваша оцінка: B");
                else if (grade >= 60 && grade < 75)
                    Console.WriteLine("Ваша оцінка: C");
                else
                    Console.WriteLine("Ваша оцінка: F");
            }
            else
            {
                Console.WriteLine("Помилка: введіть коректне число!");
            }
        }

        private static void task3()
        {
            Console.Write("Введіть число (1-7): ");
            if (int.TryParse(Console.ReadLine(), out int dayNumber))
            {
                string day;

                switch (dayNumber)
                {
                    case 1:
                        day = "Понеділок";
                        break;
                    case 2:
                        day = "Вівторок";
                        break;
                    case 3:
                        day = "Середа";
                        break;
                    case 4:
                        day = "Четвер";
                        break;
                    case 5:
                        day = "П’ятниця";
                        break;
                    case 6:
                        day = "Субота";
                        break;
                    case 7:
                        day = "Неділя";
                        break;
                    default:
                        day = "Некоректне число! Введіть від 1 до 7.";
                    break;
                }
           
                    Console.WriteLine("Результат: " + day);
            }
            else
            {
                Console.WriteLine("Помилка: введіть коректне число!");
            }
        }

        private static void task4()
        {
            Console.Write("Введіть марку авто (Toyota, BMW, Tesla): ");
            string carBrand = Console.ReadLine();
            switch (carBrand)
            {
                case "Toyota":
                    Console.WriteLine("Результат: Японія");
                    break;
                case "BMW":
                    Console.WriteLine("Результат: Німеччина");
                    break;
                case "Tesla":
                    Console.WriteLine("Результат: США");
                    break;
                default:
                    Console.WriteLine("Помилка: Невідома марка авто.");
                    break;
            }
        }

        private static void task5()
        {
            Console.Write("Введіть температуру: ");
            if (int.TryParse(Console.ReadLine(), out int temperature))
            {
                string weather = temperature >= 0 ? "Погода тепла." : "Погода холодна.";
                Console.WriteLine("Результат: " + weather);
            }
            else
            {
                Console.WriteLine("Помилка: введіть коректне число!");
            }
        }

        private static void task6()
        {
            try
            {
                Console.Write("Введіть перше число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введіть друге число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (num2 == 0)
                    throw new DivideByZeroException();

                double result = num1 / num2;
                Console.WriteLine($"Результат: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Помилка: поділ на нуль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: введіть коректні числа!");
            }
        }
    }
}
