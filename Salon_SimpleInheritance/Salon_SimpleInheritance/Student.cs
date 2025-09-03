using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_SimpleInheritance
{
    internal class Student
    {
        public string Name { get; set; }
        public string Program { get; set; }

        public Student(string name, string program)
        {
            Name = name;
            Program = program;
        }

        public virtual void BasicInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Program: {Program}");
        }
        // For the IRegularStudent
        public class IrregularStudent : Student
        {
            public int UnitsEnrolled { get; set; }

            public IrregularStudent(string name, string program, int unitsEnrolled)
                : base(name, program)
            {
                UnitsEnrolled = unitsEnrolled;
            }

            public void EnrolledSemUnits()
            {
                Console.WriteLine($"Units Enrolled: {UnitsEnrolled}");
            }
            public override void BasicInfo()
            {
                base.BasicInfo();
                EnrolledSemUnits();
            }
            //For the RegularStudent
            public class RegularStudent : Student
            {
                public string Section { get; set; }

                public RegularStudent(string name, string program, string section)
                    : base(name, program)
                {
                    Section = section;
                }

                public void SectionEnrolled()
                {
                    Console.WriteLine($"Section: {Section}");
                }

                public override void BasicInfo()
                {
                    base.BasicInfo();
                    SectionEnrolled();
                }
            }
        }
    }
}
