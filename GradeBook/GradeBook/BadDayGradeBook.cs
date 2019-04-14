using System.Linq;

namespace GradeBook
{
    public class BadDayGradeBook : GradeBook
    {
        public override GradeStatistic ComputeStatistics()
        {
            var lowest = Grades.Min();
            Grades.Remove(lowest);
            return base.ComputeStatistics();
        }
    }
}
