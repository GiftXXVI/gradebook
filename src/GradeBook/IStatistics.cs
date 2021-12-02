namespace GradeBook
{
    public interface IStatistics
    {
        public double CalculateAverage();
        public int CalculateCount();
        public double CalculateSum();
        public double CalculateMax();
        public double CalculateMin();
        public void ShowStatistics();
    }
}