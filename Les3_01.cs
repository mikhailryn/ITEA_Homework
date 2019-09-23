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
            int numQuantity = 0, evenSum = 0, oddQuantity = 0, multipleOf3 = 0, intNumber;

            string myString = ReadLine();
            char[] myChars = myString.ToCharArray();
            WriteLine($"Количество символов в строке2: {myChars.Length}");

            int i = 0;
            while (i < myChars.Length)
            {
                if (IsDigit(myChars[i]))
                {
                    ++numQuantity;
                    intNumber = ToInt32(GetNumericValue(myChars[i]));

                    if (intNumber % 2 == 0)
                    {
                        //WriteLine($"Четная цифра: {intNumber}"); 
                        evenSum += intNumber;
                    }
                    else
                    {
                        //WriteLine($"Нечетная цифра: {intNumber}"); 
                        ++oddQuantity;
                    }

                    if (intNumber % 3 == 0)
                    {
                        //WriteLine($"Цифра, кратная трем: {intNumber}"); 
                        ++multipleOf3;
                    }
                }
                i++;
            }

            WriteLine($"Количество цифр в строке: {numQuantity}");
            WriteLine($"Сумма четных цифр в числе: {evenSum}");
            //WriteLine($"Количество нечетных цифр: {oddQuantity}"); 
            WriteLine($"Количество цифр, кратных трем: {multipleOf3}");

            ReadLine();
        }
    }
}