using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_01_Ryndin
{
    class Program
    {

        static void Main(string[] args)
        {
           Console.WriteLine("Введите число");
           int Number = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Введите номер операции: 1.Количество цифр в числе  2.Сумма четных цифр  3.Количество кратных трем");
           string operation = Console.ReadLine();
            switch (operation)
            {
                case "1":
                    quantity();
                    break;
                case "2":
                    sum();
                    break;
                case "3":
                    multiple();
                    break;
                default:
                    Console.WriteLine("Вы выбрали неизвестную операцию");
                    Console.ReadKey();
                    break;
            }
            void quantity()
            {
                int i = 0;
                while (Number != 0)
                {
                    i++;
                    Number /= 10;
                }
                Console.WriteLine($"Количество цифр в числе {i} ");
                Console.ReadKey();
            }
             void sum()
            {
                int i = 0;
                while (Number > 0)
                {
                    if ((Number % 10) % 2 == 0)
                    {
                        i = i + Number % 10;
                    }
                    Number = Number / 10;
                }
                Console.WriteLine($"Сумма четных цифр в числе {i} ");
                Console.ReadKey();
            }
             void multiple()
            {
                int i = 0;
                while (Number > 0)
                {

                    if ((Number % 10) % 3 == 0)
                    {
                        i++;
                    }
                    Number = Number / 10;
                }
                Console.WriteLine($"Количество цифр кратных трем в числе {i} ");
                Console.ReadKey();
            }

        }
        }
    }