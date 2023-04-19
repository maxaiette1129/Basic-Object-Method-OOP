using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        string firstName;
        string lastName;
        string year;
        string course;
        string section;
        float midtermGrade;
        float finalGrade;

        public Student(string firstName, string lastName, string year, string course, string section, float midtermGrade, float finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        public void introduceSelf()
        {
            Console.WriteLine("Full Name: " + firstName + " " + lastName);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Section: " + section);
        }

        public void evaluateGrade()
        {
            float average = (midtermGrade + finalGrade) / 2;
            if(average >= 90) Console.WriteLine("Grade: " + average + " Honor");

            else if (average >= 75 ) Console.WriteLine("Grade: " + average + " Passed");

            else Console.WriteLine("Fail");



        }
    }
}
