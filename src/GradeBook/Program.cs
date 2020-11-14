using System;
using System.Collections.Generic;

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
            book.showStatistics();

            Console.WriteLine($" {book.name} Average Grade: {Math.Round(book.averageGrade)}%");



        }
    }


}
