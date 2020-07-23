using System;
using System.Collections.Generic;


namespace Gradebook
{

    public class Book
    {

        public Book(string name) //This is the constructor for the Book class. This takes a name and also the grades list
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade) // This is an addGrade method, it allows another grade to be added to the book
        {
           
            grades.Add(grade);

        }

        public Statistics GetStatistics() //  This is the stats method - it allows to work out stats based on grade data
        {
           
            var res = new Statistics();
            res.Average = 0.0;
            res.High = double.MinValue;
            res.Low = double.MaxValue;

            foreach(var grade in grades) 
            {
                // if(grade > highGrade) {
                //     highGrade = Math.Max(grade, highGrade);
                // }
                res.Low = Math.Min(grade, res.Low);
                res.High = Math.Max(grade, res.High);
                res.Average += grade;

            }
            res.Average /= grades.Count;

            return res;
        }

        private List<double> grades; // These are the fields which are being used in this class.
        private string name;

    }
//-------------------------------------------------- Below is some earlier code that I messed around with.
// var book = new Book();
            // book.AddGrade(15.0);
            // List<double> grades = new List<double>(); 
            // grades.Add(56.1); OR


            // var grades = new List<double>() {1.5, 2.5, 5.5, 2.0, 10.5};
            // grades.Add(3.5);
            // grades.Add(7.5);
            // grades.Add(12.5);


            //------------
}
        
