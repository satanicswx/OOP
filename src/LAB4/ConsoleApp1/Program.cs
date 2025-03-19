using System;
using System.Globalization;
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
        }

        private static void task1()
        {
            int age = 25;               // Вік
            double weight = 72.5;       // Вага
            char grade = 'A';           // Оцінка
            bool isStudent = true;      // Студент (true/false)
            string name = "Олександр";  // Ім'я

            Console.WriteLine("Вік: " + age);
            Console.WriteLine("Вага: " + weight);
            Console.WriteLine("Оцінка: " + grade);
            Console.WriteLine("Студент: " + isStudent);
            Console.WriteLine("Ім'я: " + name);
        }
        private static void task2()
        {
            Console.Write("Введіть число (double): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                // Перетворення double у int (з відкиданням дробової частини)
                int intNumber = (int)number;
                // Перетворення int назад у string
                string strNumber = intNumber.ToString();

                Console.WriteLine("Ви ввели (double): " + number);
                Console.WriteLine("Перетворено в int: " + intNumber);
                Console.WriteLine("Перетворено назад у string: " + strNumber);
            }
            else
            {
                Console.WriteLine("Некоректне число!");
            }
        }
        private static void task3()
        {
            Console.Write("Введіть ваше ім'я: ");
            string name = Console.ReadLine();

            Console.Write("Введіть ваш вік: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"Привіт, {name}! Твій вік: {age} років.");
            }
            else
            {
                Console.WriteLine("Некоректний вік!");
            }
        }
        private static void task4()
        {
            Console.Write("Введіть відстань (км): ");
            if (!double.TryParse(Console.ReadLine(), out double distance))
            {
                Console.WriteLine("Некоректна відстань!");
                return;
            }

            Console.Write("Введіть час (год): ");
            if (!double.TryParse(Console.ReadLine(), out double time) || time == 0)
            {
                Console.WriteLine("Некоректний час!");
                return;
            }

            double averageSpeed = distance / time;
            Console.WriteLine("Середня швидкість: " + averageSpeed + " км/год");
        }

        private static void task5()
        {
            Console.Write("Введіть речення: ");
            string sentence = Console.ReadLine();

            // 1. Вивід довжини речення
            Console.WriteLine("Довжина: " + sentence.Length + " символів");

            // 2. Перетворення речення у верхній регістр
            string upperSentence = sentence.ToUpper();
            Console.WriteLine("Верхній регістр: " + upperSentence);

            // 3. Замінюємо пробіли на підкреслення
            string replacedSentence = sentence.Replace(" ", "_");
            Console.WriteLine("Замінені пробіли: " + replacedSentence);

            // 4. Вивід перших 5 символів (якщо речення містить менше 5 символів, виводимо все)
            string firstFive = sentence.Length >= 5 ? sentence.Substring(0, 5) : sentence;
            Console.WriteLine("Перші 5 символів: " + firstFive);
        }
    }
}