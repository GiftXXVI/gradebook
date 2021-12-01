using System;
namespace GradeBook{
    class Book{
        List<double> grades = new List<double>();
        public Boolean AddGrades(List<double> in_grades){
            grades = in_grades;
            return true;
        }
        public Boolean AddGrade(double grade){
            grades.Add(grade);
            return true;
        }
        public double CalculateAverage(){
            double result = 0.0;
            foreach (double grade in this.grades)
            {
                result += grade;
            }
            return result;
        }
    }
}