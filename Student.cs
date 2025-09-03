using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Encapsulation
{
    internal class Student
    {
        // Short-hand encapsulation using auto-implemented properties
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        // Method to display student details
        public void DisplayDetails()
        {
            Console.WriteLine("\n===== Student Details =====");
            Console.WriteLine($"ID: {StudentID}");
            Console.WriteLine($"Name: {FullName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Course: {Course}");
        }
    }
}
