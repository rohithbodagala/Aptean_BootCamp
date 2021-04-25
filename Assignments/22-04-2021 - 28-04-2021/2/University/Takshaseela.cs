using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class TakshasheelaUniversity : Display
    {
        public void printDetails(College college)
        {
            foreach (var student in college.students)
            {
                double avg = (student.s1.marks + student.s2.marks + student.s3.marks + student.s4.marks + student.s5.marks) / 5;
                Console.WriteLine($"Student Name: {student.FirstName}{student.LastName}");
                Console.WriteLine($"DOB: {student.DOB.ToShortDateString()}");
                Console.WriteLine($"Student Type: {student.studentType}");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Score");
                Console.WriteLine("---------------------------");
                Console.WriteLine($"{student.s1.subject}\t\t{student.s1.marks}");
                Console.WriteLine($"{student.s2.subject}\t{student.s2.marks}");
                Console.WriteLine($"{student.s3.subject}\t{student.s3.marks}");
                Console.WriteLine($"{student.s4.subject}\t\t{student.s4.marks}");
                Console.WriteLine($"{student.s5.subject} {student.s5.marks}");
                Console.WriteLine("---------------------------");
                Console.WriteLine($"Avg.Score\t{avg}");
                Console.WriteLine("---------------------------");

            }
        }
    }
}
