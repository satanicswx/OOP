using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void BubbleSortWithSwapCount(int[] numbers)
        {
            int swapCount = 0;
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Обмін елементів
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                        swapCount++;
                    }
                }
            }

            Console.WriteLine($"Кількість перестановок: {swapCount}");
            Console.WriteLine("Після сортування: [" + string.Join(", ", numbers) + "]");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int[] numbers = { 8, 5, 2, 9, 1, 5, 6 };
            BubbleSortWithSwapCount(numbers);
        }
    }
}
