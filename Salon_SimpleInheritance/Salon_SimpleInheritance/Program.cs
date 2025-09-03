using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Salon_SimpleInheritance.Student;
using static Salon_SimpleInheritance.Student.IrregularStudent;

namespace Salon_SimpleInheritance
{
    //Khert Khen Salon
    //IT-306
    //Simple Inheritance with Properties
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STUDENT INFORMATION SYSTEM");
            Console.WriteLine("===========================");

            // Create objects for both derived classes
            RegularStudent regularStudent = new RegularStudent(
                "John Smith",
                "Computer Science",
                "CS-3A"
            );

            IrregularStudent irregularStudent = new IrregularStudent(
                "Jane Doe",
                "Business Administration",
                15
            );

            // Display student information
            Console.WriteLine("\n=== REGULAR STUDENT INFORMATION ===");
            regularStudent.BasicInfo();

            Console.WriteLine("\n=== IRREGULAR STUDENT INFORMATION ===");
            irregularStudent.BasicInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        }
    }
