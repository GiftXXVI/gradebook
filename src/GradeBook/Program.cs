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
            double result = 0.0;
            book.AddGrades(grades);
            result = book.CalculateAverage();
            Console.WriteLine($"The sum for {book.GetName()} is {result:N2}");
            Console.WriteLine($"The average for {book.GetName()} is {result / grades.Count():N2}");

            name = (args.Count() > 0) ? args[0] : "Stranger";
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
