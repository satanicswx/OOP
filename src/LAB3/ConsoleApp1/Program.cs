using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            task1();
            task2();
            task3();
        }

        private static void task1()
        {
            int userAge = 20;               // Змінна віку: використовуємо camelCase
            string userName = "Андрій";      // Змінна імені: використовуємо camelCase
            Console.WriteLine("Привіт, " + userName + "! Твій вік: " + userAge);
        }

        private static void task2()
        {
            int @class = 20;                // Приклад: змінна з ім'ям, яке є зарезервованим словом, використовується з префіксом '@'
            string userName = "Андрій";
            Console.WriteLine("Привіт, " + userName + "! Твій вік: " + @class);
        }

        private static void task3()
        {
            // Оголошення змінної 'name' та присвоєння їй значення "Анна"
            string name = "Анна";

            // Оголошення змінної 'age' та присвоєння їй значення 25
            int age = 25;

            // Виведення в консоль повідомлення, що містить ім'я та вік користувача
            Console.WriteLine("Привіт, " + name + "! Твій вік: " + age);
        }
    }
}
