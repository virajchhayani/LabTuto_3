using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_3
{
    internal class _1
    {

        // Task 1: Create a class
        class MyClass
        {
            // Task 2: Add few data members as private
            private int number;
            private string text;

            // Task 3: Add few methods as public to work on defined data members
            public void SetNumber(int num)
            {
                number = num;
            }
            public void SetText(string txt)
            {
                text = txt;
            }
            public void DisplayData()
            {
                Console.WriteLine("Number : " + number);
                Console.WriteLine("Text : " + text);
            }
        }
        // Task 4: Create a Demo class with the main method.
        class Demo
        {
            static void Main()
            {
                Console.WriteLine("VIRAJ - 21SOECE11011");
                // Task 5: Create at least two objects of a class defined in Task 1 into the main method
                MyClass obj1 = new MyClass();
                MyClass obj2 = new MyClass();

                // Task 6: Write comments for each important portion of code like data members’ declaration, methods, some important logic, etc.

                // Creating objects of the MyClass class
                // Each object will have its own private data members (number and text)

                // Task 7: Summarize the above solution in your own few words to visualize the solution to the end user.

                // In this program, we define a class called "MyClass" with private data members (number and text) and public methods to set data and display it.
                // We then create a "Demo" class with the main method where we create two objects of "MyClass," set their data, and display it.

                // Setting data for obj1
                obj1.SetNumber(10);
                obj1.SetText("Viraj Chhayani");

                // Setting data for obj2
                obj2.SetNumber(7);
                obj2.SetText("Viraj Patel");

                // Displaying data for obj1 and obj2 using the respective objects
                Console.WriteLine("Data for obj1 : ");
                obj1.DisplayData();

                Console.WriteLine("\nData for obj2 : ");
                obj2.DisplayData();
            }
        }
    }
}