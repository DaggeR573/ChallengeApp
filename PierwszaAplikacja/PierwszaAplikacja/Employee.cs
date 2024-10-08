﻿using System;
using System.Diagnostics;

namespace PierwszaAplikacja
{
    public class Employee
    {

        private List<float> grades = new List<float>();

        public Employee(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

        public string FirstName { get; private set; }

        public string SecondName { get; private set; }

        public void AddGrade(float grade)
        {
            //Rzutowanie (casting)
            int valueInInt = (int)Math.Ceiling(grade);


            //WALIDACJA DANYCH
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {

            if (float.TryParse(grade, out float result))
            {
                this.grades.Add(result);
                Console.WriteLine("String variable");
            }
            else
            {
                Console.WriteLine("String is not float.");
            }
        }
        public void AddGrade(double grade)
        {
            Console.WriteLine("Double variable, possible lack of precision");
            float value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(long grade)
        {
            Console.WriteLine("Long variable, possible lack of precision");
            float value = (float)grade;
            this.AddGrade(value);
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;


            for (var i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average +=   this.grades[i];

            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithForeach()
        {
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;


            foreach (var grade in this.grades)
            {
                statistics1.Max = Math.Max(statistics1.Max, grade);
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Average += grade;
            }

            statistics1.Average /= this.grades.Count;

            return statistics1;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;

            var index = 0;

            while (index < grades.Count)
            {
                statistics2.Max = Math.Max(statistics2.Max, this.grades[index]);
                statistics2.Min = Math.Min(statistics2.Min, this.grades[index]);
                statistics2.Average += this.grades[index];

                index++;

            }


            statistics2.Average /= this.grades.Count;

            return statistics2;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistics3.Max = Math.Max(statistics3.Max, this.grades[index]);
                statistics3.Min = Math.Min(statistics3.Min, this.grades[index]);
                statistics3.Average += this.grades[index];

                index++;

            }
            while (index < this.grades.Count);


            statistics3.Average /= this.grades.Count;

            return statistics3;
        }


    }

}
