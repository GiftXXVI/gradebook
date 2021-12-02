using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryBook book = new InMemoryBook("The Academy");
            List<double> grades = GetGrades();
            book.AddGrades(grades);
            book.ShowStatistics();
            string name = "";
            name = (args.Count() > 0) ? args[0] : "Stranger";
            Console.WriteLine($"Hello, {name}!");
        }

        static List<double> GetGrades()
        {
            List<double> grades = new List<double>();
            while (true)
            {
                Console.WriteLine("Please type a grade or 'q' if finished!");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                else
                {
                    if (double.TryParse(input, out double grade) && (grade >= 0) && (grade <= 100))
                    {
                        grades.Add(grade);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input Detected!!!");
                    }
                }
            }
            return grades;
        }
    }
}
