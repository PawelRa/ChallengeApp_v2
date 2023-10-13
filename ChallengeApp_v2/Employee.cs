﻿namespace ChallengeApp_v2
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade data");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float value))
            {
                this.AddGrade(value);
            }
            else { Console.WriteLine("String is not float"); }
        }

        public void AddGrade(char grade)
        {
            if (float.TryParse(grade.ToString(), out float value))
            {
                this.AddGrade(value);
            }
            else { Console.WriteLine("String is not float"); }
        }

        public void AddGrade(double grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(int grade)
        {
            float value = grade;
            this.AddGrade(value);
        }

        public void AddGrade(long grade)
        {
            if (float.TryParse(grade.ToString(), out float value))
            {
                this.AddGrade(value);
            }
            else { Console.WriteLine("String is not float"); }
        }

        public float Result
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}
