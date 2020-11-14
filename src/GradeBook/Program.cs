using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Martin");

            book.AddGrade(40.74);
            book.AddGrade(80.74);
            book.AddGrade(99.74);
            var statistic = book.ShowStatistics();

            Console.WriteLine($" {book.name} Average Grade: {Math.Round(statistic.AverageGrade)}%");



        }
    }


}
