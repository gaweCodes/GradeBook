using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class GradeBook : GradeTracker
    {
        protected List<double> Grades;
        public GradeBook()
        {
            _name = "Default";
            Grades = new List<double>();
        }
        public override void AddGrade(double grade)
        {
            Grades.Add(grade);
        }
        public override GradeStatistic ComputeStatistics()
        {
            var statistics = new GradeStatistic
            {
                LowestGrade = Grades.Min(), HighestGrade = Grades.Max(), AverageGrade = Grades.Average()
            };
            return statistics;
        }
    }
}
