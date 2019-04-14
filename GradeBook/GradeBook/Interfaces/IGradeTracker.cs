namespace GradeBook.Interfaces
{
    public interface IGradeTracker
    {
        void AddGrade(double grade);
        GradeStatistic ComputeStatistics();
        string Name { get; set; }
    }
}
