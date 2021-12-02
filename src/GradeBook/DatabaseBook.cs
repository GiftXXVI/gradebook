namespace GradeBook
{
    public class DatabaseBook : Book
    {
        public DatabaseBook(string in_name) : base(in_name)
        {

        }

        public override Boolean SetName(string in_name)
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            throw new NotImplementedException();
        }

        public override bool AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override bool AddGrades(List<double> in_grades)
        {
            throw new NotImplementedException();
        }

        public override double CalculateAverage()
        {
            throw new NotImplementedException();
        }

        public override double CalculateMax()
        {
            throw new NotImplementedException();
        }

        public override double CalculateMin()
        {
            throw new NotImplementedException();
        }

        public override double CalculateSum()
        {
            throw new NotImplementedException();
        }

        public override int CalculateCount()
        {
            throw new NotImplementedException();
        }

        public override void ShowStatistics()
        {
            throw new NotImplementedException();
        }
    }
}