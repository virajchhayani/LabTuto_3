using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_3
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public Student(string name, int age, string course)
        {
            Name = name;
            Age = age;
            Course = course;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Course : {Course}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            List<Student> students = new List<Student>();
            // Create objects for 5 students
            Student student1 = new Student("Viraj", 20, "Computer Engineering");
            Student student2 = new Student("Jeet", 20, "Electrical Engineering");
            Student student3 = new Student("Darsh", 19, "Mechanical Engineering");
            Student student4 = new Student("Jay", 21, "Computer Engineering");
            Student student5 = new Student("Uday", 18, "Computer Engineering");
            // Add students to the list
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            // Display information of all students
            Console.WriteLine("Information of all students : ");
            foreach (var student in students)
            {
                student.DisplayInfo();
            }
        }
    }
}
