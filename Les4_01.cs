#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            WriteLine("Введите первую строку:");
            string myString1 = ReadLine();
            char[] myChars1 = myString1.ToCharArray();

            WriteLine("Введите вторую строку:");
            string myString2 = ReadLine();
            char[] myChars2 = myString2.ToCharArray();

            if (myChars1.Length > myChars2.Length)
            {
                int indexBegin = (myChars1.Length - myChars2.Length) / 2;

                int i = 0;
                while (i < myChars2.Length)
                {
                    if (i + indexBegin < myChars1.Length)
                        myChars1[i + indexBegin] = myChars2[i];

                    i++;
                }
            }
            myString1 = new string(myChars1);
            WriteLine(value: $"Выводим итоговый массив в строку: {myString1}");

            ReadLine();
        }
    }
}