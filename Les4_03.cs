#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Console;
using static System.Convert;
using static System.Char;
#endregion

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charData = new char[10];
            char myDirection = 's';
            WriteLine("a) Лево\nd) Право\nx) Выход");
            WriteLine("Собака в начале пути:");
            int dogIndex = 0;
            do
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i == dogIndex)
                        charData[i] = '@';
                    else charData[i] = '_';
                }

                for (int i = 0; i < 10; i++)
                    Write($"{charData[i]}");

                WriteLine("\n\nВыбор направления:");
                myDirection = ToChar(ReadLine());

                switch (myDirection)
                {
                    case 'a' when dogIndex > 0:
                        dogIndex--;
                        break;
                    case 'd' when dogIndex < 10:
                        dogIndex++;
                        break;
                    default:
                        break;
                }
            }
            while (myDirection != 'x');
        }
    }
}
