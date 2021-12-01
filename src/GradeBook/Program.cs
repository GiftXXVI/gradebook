using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Book book = new Book();
            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            double result = 0.0;
            foreach (double grade in grades)
            {
                result += grade;
            }
            Console.WriteLine($"The sum is {result:N2}");
            Console.WriteLine($"The average is {result / grades.Count():N2}");

            name = (args.Count() > 0) ? args[0] : "Stranger";
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
