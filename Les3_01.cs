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
           Console.WriteLine("������� �����");
           int Number = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("������� ����� ��������: 1.���������� ���� � �����  2.����� ������ ����  3.���������� ������� ����");
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
                    Console.WriteLine("�� ������� ����������� ��������");
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
                Console.WriteLine($"���������� ���� � ����� {i} ");
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
                Console.WriteLine($"����� ������ ���� � ����� {i} ");
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
                Console.WriteLine($"���������� ���� ������� ���� � ����� {i} ");
                Console.ReadKey();
            }

        }
        }
    }