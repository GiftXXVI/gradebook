using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            name = (args.Count() > 0) ? args[0] : "Stranger";
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
