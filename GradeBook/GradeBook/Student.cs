using System;
using GradeBook.Interfaces;

namespace GradeBook
{
    public class Student
    {
        public int Id { get; }
        // In this tutorial it is not possible to change the name of a student.
        public string Name { get; }
        // this is a static Field. We can access it without instantiate an object. The value are saved in the class not in the object.
        // So it is a good way to generate some id numbers.
        private readonly IGradeTracker _gradeBook;
        private static int CurrentId { get; set; }
        public Student(string name, IGradeTracker gradeBook)
        {
            //Add the next higher id number to the id
            Id = ++CurrentId;
            Name = name;
            _gradeBook = gradeBook;
        }
        public void AddGradeToBook(double grade)
        {
            _gradeBook.AddGrade(grade);
        }
        public void PrintStatistics()
        {
            var statistics = _gradeBook.ComputeStatistics();
            Console.WriteLine($"Student-ID: {Id} {Environment.NewLine}Student-Name: {Name} {Environment.NewLine}Book-Name: {_gradeBook.Name}");
            Console.WriteLine($"Highest-Grade: {statistics.HighestGrade} {Environment.NewLine}Lowest-Grade: {statistics.LowestGrade} {Environment.NewLine}Average-Grade: {statistics.AverageGrade} {Environment.NewLine}Grade-Letter: {statistics.LetterGrade} {Environment.NewLine}Grade-Description: {statistics.GradeDescription}{Environment.NewLine}{Environment.NewLine}");
            Console.ReadLine();
        }
    }
}
