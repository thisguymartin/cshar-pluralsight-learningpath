using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public string name;
        public List<double> grades;

        public double averageGrade = 0.0;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public Statistics ShowStatistics()
        {
            var statistics = new Statistics();

            foreach (var g in this.grades)
            {
                statistics.AverageGrade += g;
            }

            statistics.AverageGrade /= this.grades.Count;

            return statistics;

        }

    }
}