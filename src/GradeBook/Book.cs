using System;
namespace GradeBook
{
    public abstract class Book : NamedObject
    {
        public Book(string in_name) : base(in_name) { }
        public abstract Boolean SetName(string in_name);
        public abstract string GetName();
        public abstract Boolean AddGrades(List<double> in_grades);
        public abstract Boolean AddGrade(double grade);
    }
}