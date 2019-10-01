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
using System.Diagnostics;
#endregion

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSize = 10; // ���������� �������� � �������
            char[][] charData = new char[maxSize][];

            Random sourceGen = new Random(); // ������� ��������� ��������� ����� (���� ��� ���� ���������)
            char myDirection = 'g'; // ����� �� ��� ������ ��� ������� �������

            WriteLine("a) ����\nd) �����\nw) �����\ns) ����\nq) �����");
            WriteLine("������ � ������ ����:");

            int dogIndex1 = 0, dogIndex2 = 0; // ���������� ������
            int bmbIndex1 = 0, bmbIndex2 = 0; // ���������� ��������
            int medIndex1 = 0, medIndex2 = 0; // ���������� ���. �������

            int dogHealth = 100, bmbFault = -40, medKit = 40; // �����
            do
            {
                for (int i = 0; i < charData.Length; i++)
                {
                    // ��������� ���������� �������� � �������
                    bmbIndex1 = i; // sourceGen.Next(10);
                    bmbIndex2 = sourceGen.Next(10);

                    medIndex1 = i; // sourceGen.Next(10);
                    medIndex2 = sourceGen.Next(10);

                    charData[i] = new char[maxSize];                    // �������� ����������� ����������� �������
                    for (int j = 0; j < charData[i].Length; j++)
                    {
                        if (i == dogIndex1 && j == dogIndex2)
                        {   // ��������� ����������� ������
                            charData[i][j] = '@';
                            // �������
                            if (medIndex1 == dogIndex1 && medIndex2 == dogIndex2)
                            {
                                charData[i][j] = '$';
                                dogHealth += medKit;
                            }
                            // ��������
                            if (bmbIndex1 == dogIndex1 && bmbIndex2 == dogIndex2)
                            {
                                charData[i][j] = '#';
                                dogHealth += bmbFault;
                            }
                        }
                        else if (i == bmbIndex1 && j == bmbIndex2)
                            // ���������� ��������
                            charData[i][j] = 'B';
                        else if (i == medIndex1 && j == medIndex2)
                            // ���������� �������
                            charData[i][j] = 'M';
                        else charData[i][j] = '_'; // �� ���� ��������� ��������
                    }
                }
                // ����� ����� ���� �� �����
                for (int i = 0; i < charData.Length; i++)
                {
                    Write("\n");
                    for (int j = 0; j < charData[i].Length; j++)
                        Write($"{charData[i][j]}");
                }

                WriteLine("\n\n����� �����������:");
                myDirection = ToChar(ReadLine().Substring(0, 1)); // ���������: ����� � ������� ������� ���� ����

                switch (myDirection)
                {
                    case 'a' when dogIndex2 > 0:
                        dogIndex2--;
                        break;
                    case 'd' when dogIndex2 < maxSize:
                        dogIndex2++;
                        break;
                    case 'w' when dogIndex1 > 0:
                        dogIndex1--;
                        break;
                    case 's' when dogIndex1 < maxSize:
                        dogIndex1++;
                        break;
                    default:
                        break;
                }
                if ((dogIndex1 > maxSize - 1) || (dogIndex2 > maxSize - 1)) // ����� �� ������� ����
                {
                    dogIndex1 = 0; dogIndex2 = 0; // �� ������ �������
                }
            }
            while (myDirection != 'q' || dogHealth <= 0);

            WriteLine($"�����. �������� � ������ ��������: {dogHealth}");
            WriteLine("������� Enter");
            ReadLine();
        }
    }
}
