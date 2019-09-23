using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            double discount = 0;

            Console.WriteLine("Enter a number:");
            double var1 = Convert.ToDouble(Console.ReadLine());

            if (var1 > 300 && var1 <= 400)
                discount = 0.02;
            else
            {
                if (var1 > 400 && var1 <= 500)
                    discount = 0.03;
                else
                    if (var1 > 500)
                    discount = 0.05;
            }

            result = var1 - var1 * discount;
            Console.WriteLine($"сума до сплати {result}" +
            $", знижка {discount}");
            Console.ReadKey();
        }
    }
}