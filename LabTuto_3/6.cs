using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_3
{
    internal class _6
    {
        class Line
        {
            private double length; // Length of a line
            public Line()
            {
                length = 10; // Missing statement-1: Set the initial length to 10 when the object is created.
            }
            public void setLength(double len)
            {
                length = len; // Missing statement-3: Set the length to the given value.
            }
            public double getLength()
            {
                return length; // Missing statement-4: Return the current length.
            }
        }
        class TestLine
        {
            static void Main(string[] args)
            {
                Console.WriteLine("VIRAJ - 21SOECE11011");
                Line line = new Line();
                Console.WriteLine("Object is being created, length = {0}", line.getLength());
                line.setLength(6); // Set line length to 6.
                Console.WriteLine("Length of line : {0}", line.getLength());
                Console.ReadKey();
            }
        }
    }
}
