using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module_10
{
    class Student : IStudent
    {
        Random rand = new Random();

        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, string fullName)
        {
            Name = name;
            FullName = fullName;

            Grades = new int[rand.Next(4, 10)];

            for (int i = 0; i < Grades.Length; i++)
            {
                Grades[i] = rand.Next(1, 12);
            }
        }

        public double GetAvgGrade()
        {
            int a = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                a += Grades[i];
            }
            return (double)a / (double)Grades.Length;
        }

        public string GetFullName() { return FullName; }

        public string GetName() { return Name; }
    }
}