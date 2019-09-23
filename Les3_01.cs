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
            WriteLine($"���������� �������� � ������2: {myChars.Length}");

            int i = 0;
            while (i < myChars.Length)
            {
                if (IsDigit(myChars[i]))
                {
                    ++numQuantity;
                    intNumber = ToInt32(GetNumericValue(myChars[i]));

                    if (intNumber % 2 == 0)
                    {
                        //WriteLine($"������ �����: {intNumber}"); 
                        evenSum += intNumber;
                    }
                    else
                    {
                        //WriteLine($"�������� �����: {intNumber}"); 
                        ++oddQuantity;
                    }

                    if (intNumber % 3 == 0)
                    {
                        //WriteLine($"�����, ������� ����: {intNumber}"); 
                        ++multipleOf3;
                    }
                }
                i++;
            }

            WriteLine($"���������� ���� � ������: {numQuantity}");
            WriteLine($"����� ������ ���� � �����: {evenSum}");
            //WriteLine($"���������� �������� ����: {oddQuantity}"); 
            WriteLine($"���������� ����, ������� ����: {multipleOf3}");

            ReadLine();
        }
    }
}