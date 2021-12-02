using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("The Academy");
            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            book.AddGrades(grades);
            book.ShowStatistics();
            string name = "";
            name = (args.Count() > 0) ? args[0] : "Stranger";
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
