    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name: ");
            string fn = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter last name: ");
            string ln = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter year: ");
            string y = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter course: ");
            string c = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter section: ");
            string s = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter midterm grade: ");
            float mg = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter final grade: ");
            float fg = Convert.ToSingle(Console.ReadLine());



            Student record = new Student(fn,ln,y,c,s,mg,fg);
            record.introduceSelf();
            Console.WriteLine();
            record.evaluateGrade();
        }
    }
}
