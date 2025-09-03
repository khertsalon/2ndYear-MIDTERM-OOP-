using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { // Asking user for input
                Console.Write("Enter Student ID: ");
                string id = Console.ReadLine();

                Console.Write("Enter Full Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course: ");
                string course = Console.ReadLine();

                // Instantiate Student object using user input
                Student student = new Student
                {
                    StudentID = id,
                    FullName = name,
                    Age = age,
                    Course = course
                };

                // Call method to display details
                student.DisplayDetails();

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
