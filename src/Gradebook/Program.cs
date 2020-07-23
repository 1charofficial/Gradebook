using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Connors Academy Grade book");
            book.AddGrade(15.0);
            book.AddGrade(5.5);
            book.AddGrade(10.2);
            book.AddGrade(12.5);
           
           var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");


            // var book = new Book();
            // book.AddGrade(15.0);
            // List<double> grades = new List<double>(); 
            // grades.Add(56.1); OR


            // var grades = new List<double>() {1.5, 2.5, 5.5, 2.0, 10.5};
            // grades.Add(3.5);
            // grades.Add(7.5);
            // grades.Add(12.5);

            
            
           
        }
    }
}
