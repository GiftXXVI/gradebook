namespace GradeBook
{
    public class InMemoryBook : Book
    {
        private List<double> grades;

        public InMemoryBook(string in_name) : base(in_name)
        {
            grades = new List<double>();
            this.name = in_name;
        }

        public override Boolean SetName(string in_name)
        {
            this.name = in_name;
            return true;
        }

        public override string GetName()
        {
            return this.name;
        }
        public override Boolean AddGrades(List<double> in_grades)
        {
            this.grades = in_grades;
            return true;
        }
        public override Boolean AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            return true;
        }
        public override double CalculateAverage()
        {
            double result = 0.0;
            result = this.CalculateSum() / this.CalculateCount();
            return result;
        }

        public override int CalculateCount()
        {
            return this.grades.Count();
        }

        public override double CalculateSum()
        {
            double result = 0.0;
            foreach (double grade in this.grades)
            {
                result += grade;
            }
            return result;
        }

        public override double CalculateMax()
        {
            double result = double.MinValue;
            foreach (double grade in this.grades)
            {
                if (grade > result) result = grade;
            }
            return result;
        }

        public override double CalculateMin()
        {
            double result = double.MaxValue;
            foreach (double grade in this.grades)
            {
                if (grade < result) result = grade;
            }
            return result;
        }

        public override void ShowStatistics()
        {
            Console.WriteLine($"The sum for {this.GetName()} is {this.CalculateSum():N2}");
            Console.WriteLine($"The minimum for {this.GetName()} is {this.CalculateMin():N2}");
            Console.WriteLine($"The maximum for {this.GetName()} is {this.CalculateMax():N2}");
            Console.WriteLine($"The average for {this.GetName()} is {this.CalculateAverage():N2}");
        }
    }
}