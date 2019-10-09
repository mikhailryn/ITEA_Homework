using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Convert;
using static System.Char;

namespace NameSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSizeV = 3; 
            int maxSizeH = 3; 
            string[][] stringData = new string[maxSizeV][];

            String input, myString;
            bool isMatch;
            
            String pattern = @"\s+"; 

            for (int i = 0; i < stringData.Length; i++)
            {
                stringData[i] = new string[maxSizeH];  

                WriteLine($"С клавиатуры введите строку {i + 1} через пробел" + ((i == 0) ? " (например: Иван Иванович Иванов)" : ""));
                input = ReadLine();

                String[] elements = Regex.Split(input, pattern); 

                int j = 0;
                foreach (var element in elements)
                {
                    stringData[i][j] = element;
                    j++;
                }
            }
            for (int i = 0; i < stringData.Length; i++)
            {
                Write("\n");
                for (int j = 0; j < stringData[i].Length; j++)
                    Write($"{stringData[i][j]} ");
            }

            WriteLine("\n\nВведите подстроку (или хотя бы одну букву):");
            myString = ReadLine();

            String myPattern = @myString; 

            for (int i = 0; i < stringData.Length; i++)
            {
                isMatch = false;
                for (int j = 0; j < stringData[i].Length; j++)
                {
                    foreach (Match m in Regex.Matches(stringData[i][j], myPattern))
                    {
                        isMatch = true;
                    }
                }
                
                if (isMatch)
                {
                    Write("\n");
                    for (int j = 0; j < stringData[i].Length; j++)
                        Write($"{stringData[i][j]} ");
                }
            }
            Write("\n");
            Console.ReadKey();
        }
    }
}