using GradeBook.Interfaces;

namespace GradeBook
{
    internal class Program
    {
        private static void Main()
        {
            var normalStudent = CreateStudent("Gabriel", new GradeBook());
            normalStudent.AddGradeToBook(25);
            normalStudent.AddGradeToBook(50);
            normalStudent.AddGradeToBook(75);
            normalStudent.AddGradeToBook(100);

            var badDayStudent = CreateStudent("Leirbag", new BadDayGradeBook());
            badDayStudent.AddGradeToBook(25);
            badDayStudent.AddGradeToBook(50);
            badDayStudent.AddGradeToBook(75);
            badDayStudent.AddGradeToBook(100);

            normalStudent.PrintStatistics();
            badDayStudent.PrintStatistics();
        }
        private static Student CreateStudent(string name, IGradeTracker gradeBook)
        {
            return new Student(name, gradeBook);
        }
    }
}
