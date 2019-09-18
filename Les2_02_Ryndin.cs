using System;

namespace Lesson2_02_Ryndin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            float money = Convert.ToSingle(Console.ReadLine());
            int discount1 = 1;
            float discount2 = 0.98F;
            float discount3 = 0.97F;
            float discount4 = 0.95F;
            float Pay;

            if (money >= 0 && money < 300)
            {
                Pay = money * discount1;
                Console.WriteLine($"No discount, total {Pay}");
                Console.ReadKey();
            }
            else if (money >= 300 && money < 400)
            {
                Pay = money * discount2;
                Console.WriteLine($"Your discount's 2%, total {Pay}");
                Console.ReadKey();
            }
            else if (money >= 400 && money < 500)
            {
                Pay = money * discount3;
                Console.WriteLine($"Your discount's 3%, total {Pay}");
                Console.ReadKey();
            }
            else if (money >= 500 && money >= 500)
            {
                Pay = money * discount4;
                Console.WriteLine($"Your discount's 5%, total {Pay}");
                Console.ReadKey();

            }
        }
    }
}
