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

namespace ConsoleApp3
{
	
	 public class Student
    {
        private int studyDebts;
        private bool isGood;
        private int iq;
        private string name;
        private string faculty;

        private bool isExpelled;
        private string myMessage;

        public int StudyDebts { get => studyDebts; set => studyDebts = value; }
        public bool IsGood { get => isGood; set => isGood = value; }
        public int Iq { get => iq; set => iq = value; }
        public string Name { get => name; set => name = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public bool IsExpelled { get => isExpelled; set => isExpelled = value; }

        public Student(string NewName,
                       string NewFaculty,
                       int NewStudyDebts,
                       bool NewIsGood,
                       int NewIq
                       )
        {
            name = NewName;
            faculty = NewFaculty;
            studyDebts = NewStudyDebts;
            isGood = NewIsGood;
            iq = NewIq;
        }
        public void CheckStatus()
        {
            isExpelled = false;
            
            if ((isGood == false) && (iq < 70) || (isGood == false) && (studyDebts > 3) || (iq < 70) && (studyDebts > 3))
            {
                if (isGood == false)
                {
                    myMessage = "Перерандомить пьяный/трезвый";
                    throw (new ArgumentOutOfRangeException("", isGood, myMessage));
                }
                isExpelled = true;

            }

            WriteLine("Признак отчисления: " + ((isExpelled) ? "Отчислен" : "Оставлен"));
        }

        public void GetInfo()
        {
            WriteLine($"\nСтудент: {name}");
            WriteLine($"Факультет: {faculty}");
            WriteLine($"IQ: {iq}");
            WriteLine("Состояние студента: " + ((IsGood) ? "Трезв" : "Пьян"));
            WriteLine($"Хвосты: {studyDebts}");
        }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Random SourceGen = new Random(); 

            string[] studentNames = { "Антон Василенко", "Олег Перегуда", "Евгений Саратов", "Денис Ганжуга", "Анастасия Герус", "Роман Проскученко" };
            string[] facultyNames = { "ФЭА", "РТФ", "ФИВТ", "СФ", "ИПСА", "ФПМ" };
            Student[] students = new Student[studentNames.Length];

            int newStudyDebts;
            bool newIsGood;
            int newIq;

            for (int i = 0; i < studentNames.Length; i++)
            {
                newStudyDebts = SourceGen.Next(7);
                newIsGood = (SourceGen.Next(2) == 0);
                newIq = SourceGen.Next(150);

                students[i] = new Student(studentNames[i], facultyNames[i], newStudyDebts, newIsGood, newIq);
                students[i].GetInfo();

                try
                {
                    students[i].CheckStatus();
                }
                catch (ArgumentOutOfRangeException e)
                {
                    WriteLine($"Message:\n\"{e.Message}\"");
                    newIsGood = (SourceGen.Next(2) == 0);

                    if (newIsGood == true)
                    {
                        students[i].IsGood = newIsGood;
                        students[i].Iq += 10;
                        students[i].IsExpelled = false;
                    }
                    else students[i].IsExpelled = true;

                    students[i].GetInfo();
                    WriteLine("Признак отчисления: " + ((students[i].IsExpelled) ? "Отчислен" : "Оставлен"));
                }
            }
            ReadKey();
        }
    }
}

