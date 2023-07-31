using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_3
{
    internal class _2
    {
        // Define the Clock class
        internal class Clock
        {
            private int hour;
            private int min;
            private int sec;
            // No-argument constructor to initialize time value to 12:00:00
            public Clock()
            {
                hour = 12;
                min = 0;
                sec = 0;
            }
            // Three-argument constructor to initialize the time
            public Clock(int hour, int min, int sec)
            {
                this.hour = hour;
                this.min = min;
                this.sec = sec;
            }
            // Increment time to the next second
            public void IncrementTime()
            {
                sec++;
                if (sec >= 60)
                {
                    sec = 0;
                    min++;
                    if (min >= 60)
                    {
                        min = 0;
                        hour++;
                        if (hour >= 24)
                        {
                            hour = 0;
                        }
                    }
                }
            }
            // Display the time value
            public void DisplayTime()
            {
                Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
            }
            // Return the hour
            public int GetHour()
            {
                return hour;
            }
            // Return the minute
            public int GetMinute()
            {
                return min;
            }
            // Return the seconds
            public int GetSeconds()
            {
                return sec;
            }
        }
        // Main method to test the Clock class
        public static void Main(string[] args)
        {
            Console.WriteLine("VIRAJ - 21SOECE11011");
            // Create a Clock object with no arguments (initialized to 12:00:00)
            Clock clock1 = new Clock();
            Console.WriteLine("Clock 1:");
            clock1.DisplayTime();

            // Create a Clock object with three arguments
            Clock clock2 = new Clock(6, 30, 45);
            Console.WriteLine("Clock 2:");
            clock2.DisplayTime();

            // Increment time for clock2 and display the updated time
            clock2.IncrementTime();
            Console.WriteLine("Updated Clock 2:");
            clock2.DisplayTime();

            // Get individual components of time for clock2 and display them
            Console.WriteLine($"Hour: {clock2.GetHour()}");
            Console.WriteLine($"Minute: {clock2.GetMinute()}");
            Console.WriteLine($"Seconds: {clock2.GetSeconds()}");
        }
    }
}
