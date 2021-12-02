using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Book book = new Book("The Academy");
            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            book.AddGrades(grades);
            Console.WriteLine($"The sum for {book.GetName()} is {book.SumGrades():N2}");
            Console.WriteLine($"The minimum for {book.GetName()} is {book.MinGrade():N2}");
            Console.WriteLine($"The maximum for {book.GetName()} is {book.MaxGrade():N2}");
            Console.WriteLine($"The average for {book.GetName()} is {book.CalculateAverage():N2}");

            name = (args.Count() > 0) ? args[0] : "Stranger";
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
