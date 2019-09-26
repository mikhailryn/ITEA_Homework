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
            string monthName;
            int[] months = new int[12];

            WriteLine("Задайте год:");
            int myYear = Convert.ToInt32(ReadLine());

            int i = 0;
            while (i < 12)
            {
                monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i + 1);

                months[i] = DateTime.DaysInMonth(myYear, i + 1);
                WriteLine(value: $"{monthName}: {months[i]}");
                i++;
            }

            ReadLine();
        }
    }
}
