using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInheritance
{
    public struct Student
    {
        // Fields
        public int Id;
        public string Name;
        public double GPA;

        // Constructor
        public Student(int id, string name, double gpa)
        {
            Id = id;
            Name = name;
            GPA = gpa;
        }

        // Method
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, GPA: {GPA}");
        }
    }
}
