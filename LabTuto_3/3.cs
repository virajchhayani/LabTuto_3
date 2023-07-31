using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_3
{
    internal class _3
    {
        // Define the Student class
        public class Student
        {
            // Data members
            public string Name { get; set; }
            public int Age { get; set; }
            public string Field { get; set; }
            // Constructors
            public Student() { } // Default constructor
            public Student(string name, int age, string field)
            {
                Name = name;
                Age = age;
                Field = field;
            }
            // Method to display student information
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Field: {Field}");
            }
        }
        // Define the TestStudent class
        internal class TestStudent
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("VIRAJ - 21SOECE11011");
                // Create an object of the Student class
                Student student1 = new Student("Viraj Chhayani", 20, "Computer Engineering");
                // Display student information using the method from the Student class
                Console.WriteLine("Student Information:");
                student1.DisplayInfo();
            }
        }
    }
}
