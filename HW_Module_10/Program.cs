using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ivan", "Ivanov");

            string name = student.GetName();
            string fullName = student.GetFullName();
            double avgGrade = student.GetAvgGrade();

            Console.WriteLine();
            Console.WriteLine("Name: {0}, FullName: {1}, Average grade: {2}", name, fullName, avgGrade);
            Console.WriteLine();
        }
    }
}
