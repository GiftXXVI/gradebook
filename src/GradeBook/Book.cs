using System;
namespace GradeBook
{
    public class Book : NamedObject
    {
        private List<double> grades;

        public Book(string in_name) : base(in_name)
        {
            grades = new List<double>();
            this.name = in_name;
        }

        public Boolean SetName(string in_name)
        {
            this.name = in_name;
            return true;
        }

        public string GetName()
        {
            return this.name;
        }
        public Boolean AddGrades(List<double> in_grades)
        {
            this.grades = in_grades;
            return true;
        }
        public Boolean AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            return true;
        }
        public double CalculateAverage()
        {
            double result = 0.0;
            result = this.SumGrades() / this.CountGrades();
            return result;
        }

        public int CountGrades()
        {
            return this.grades.Count();
        }

        public double SumGrades()
        {
            double result = 0.0;
            foreach (double grade in this.grades)
            {
                result += grade;
            }
            return result;
        }

        public double MaxGrade()
        {
            double result = double.MinValue;
            foreach (double grade in this.grades)
            {
                if (grade > result) result = grade;
            }
            return result;
        }

        public double MinGrade()
        {
            double result = double.MaxValue;
            foreach (double grade in this.grades)
            {
                if (grade < result) result = grade;
            }
            return result;
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"The sum for {this.GetName()} is {this.SumGrades():N2}");
            Console.WriteLine($"The minimum for {this.GetName()} is {this.MinGrade():N2}");
            Console.WriteLine($"The maximum for {this.GetName()} is {this.MaxGrade():N2}");
            Console.WriteLine($"The average for {this.GetName()} is {this.CalculateAverage():N2}");
        }
    }
}