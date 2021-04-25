using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class ApteanUniversity : Display
    {
        public void printDetails(College college)
        {
            Console.WriteLine("Student Name\tDOB\t\tStudentType\tC\tDatabase\tComp.Arch\tOOPS\tComp.Networks\tAvg.Score");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            foreach (var student in college.students)
            {
                double avg = (student.s1.marks + student.s2.marks + student.s3.marks + student.s4.marks + student.s5.marks) / 5;
                Console.WriteLine($"{student.FirstName} {student.LastName}\t{student.DOB.ToShortDateString()}\t{student.studentType}\t{student.s1.marks}\t{student.s2.marks}\t\t{student.s3.marks}\t\t{student.s4.marks}\t\t{student.s5.marks}\t{avg}\n");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
        }
    }
}
