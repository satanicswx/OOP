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
        }

        private static void task1()
        {
            int[] numbers = { 12, 15, 7, 20, 33, 50, 8, 11, 90, 45 };

            var filteredNumbers = numbers.Where(n => n % 3 == 0 || n % 5 == 0);

            int sum = filteredNumbers.Sum();

            Console.WriteLine("Числа, що діляться на 3 або 5: " + string.Join(", ", filteredNumbers));
            Console.WriteLine("Сума цих чисел: " + sum);
        }

        private static void task2()
        {
            string[] productNames = { "Хліб", "Молоко", "Яблука", "Сир", "Шоколад", "Кава", "Чай" };
            double[] productPrices = { 25.5, 32.0, 45.3, 120.0, 80.0, 150.0, 75.5 };

            double averagePrice = productPrices.Average();
            Console.WriteLine($"Середня ціна товарів: {averagePrice:F2}");

            Console.WriteLine("Товари, дорожчі за середню:");
            for (int i = 0; i < productPrices.Length; i++)
            {
                if (productPrices[i] > averagePrice)
                {
                    Console.WriteLine($"- {productNames[i]}: {productPrices[i]:F2}");
                }
            }

            int minIndex = Array.IndexOf(productPrices, productPrices.Min());
            int maxIndex = Array.IndexOf(productPrices, productPrices.Max());

            Console.WriteLine($"Найдешевший товар: {productNames[minIndex]} ({productPrices[minIndex]:F2} грн)");
            Console.WriteLine($"Найдорожчий товар: {productNames[maxIndex]} ({productPrices[maxIndex]:F2} грн)");
        }
    }
}
