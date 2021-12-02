using System;
namespace GradeBook
{
    public abstract class Book : NamedObject, IStatistics
    {
        public Book(string in_name) : base(in_name) { }
        public abstract Boolean SetName(string in_name);
        public abstract string GetName();
        public abstract Boolean AddGrades(List<double> in_grades);
        public abstract Boolean AddGrade(double grade);
        public abstract double CalculateAverage();
        public abstract int CalculateCount();
        public abstract double CalculateSum();
        public abstract double CalculateMax();
        public abstract double CalculateMin();
        public abstract void ShowStatistics();
    }
}