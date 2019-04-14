using System;
using GradeBook.Interfaces;

namespace GradeBook
{
    public abstract class GradeTracker : IGradeTracker
    {
        // Because we need to know the name in our subclasses. But we dont't need to know it public.
        protected string _name;
        public abstract void AddGrade(double grade);
        public abstract GradeStatistic ComputeStatistics();
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be null or empty");
                _name = value;

            }
        }
    }
}
