using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_3
{
    class _7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            // Demonstration of using the Student class
            Student student1 = new Student("21SOECE11011", "Viraj Chhayani");
            student1.DisplayStudentInfo();
            Student student2 = new Student("21SOECE11011", "Viraj Chhayani");
            student2.DisplayStudentInfo();
            // You can also use properties to set and get values
            student2.EnrolmentNo = "21SOECE11011";
            student2.Name = "Viraj Chhayani";
            student2.DisplayStudentInfo();
        }
    }
    class Student
    {
        // Data members
        private string enrolmentNo;
        private string name;
        // Properties
        public string EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Constructors
        public Student(string enrolmentNo, string name)
        {
            this.enrolmentNo = enrolmentNo;
            this.name = name;
        }
        // Method to display student information
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Enrolment No: {enrolmentNo}, Name: {name}");
        }
    }
}
