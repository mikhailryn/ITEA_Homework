using System;
using System.Globalization;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("ֲגוהטעו װָ־:");
           string[] FullName = Console.ReadLine().Split(' ');
           Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(FullName[0] + " " + FullName[1][0] + ". " + FullName[2][0]+ ". "));
           Console.ReadKey();
        }
    }
}
