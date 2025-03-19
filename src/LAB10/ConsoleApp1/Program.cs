using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static decimal CalculateMortgage(decimal P, decimal annualRate, int years)
        {
            decimal r = annualRate / 12 / 100;
            int n = years * 12;

            if (r == 0)
                return Math.Round(P / n, 2);

            decimal numerator = r * (decimal)Math.Pow((double)(1 + r), n);
            decimal denominator = (decimal)Math.Pow((double)(1 + r), n) - 1;
            decimal M = P * (numerator / denominator);

            return Math.Round(M, 2);
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Введіть суму кредиту (P): ");
            decimal P = decimal.Parse(Console.ReadLine());

            Console.Write("Введіть річну відсоткову ставку (%): ");
            decimal annualRate = decimal.Parse(Console.ReadLine());

            Console.Write("Введіть термін кредиту (роки): ");
            int years = int.Parse(Console.ReadLine());

            decimal monthlyPayment = CalculateMortgage(P, annualRate, years);
            Console.WriteLine($"Щомісячний платіж: {monthlyPayment} грн");
        }
    }
}
