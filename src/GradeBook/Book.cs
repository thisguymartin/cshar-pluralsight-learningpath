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

        public double showStatistics()
        {

            foreach (var g in this.grades)
            {
                this.averageGrade += g;
            }

            this.averageGrade /= this.grades.Count;

            return averageGrade;

        }

    }
}