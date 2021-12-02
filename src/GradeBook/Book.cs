using System;
namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;

        public Book(string in_name)
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
            this.grades.Add(grade);
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
    }
}