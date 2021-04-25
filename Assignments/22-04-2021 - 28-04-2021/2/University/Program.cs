using System;
using System.Collections.Generic;
using System.Configuration;
using System.Collections.Specialized;

namespace University
{
    

    class Program
    {
        static void Main(string[] args)
        {
            string CollegeName, AddressLine1, AddressLine2;
            Console.WriteLine("Enter College Name:");
            CollegeName = Console.ReadLine();
            if (string.IsNullOrEmpty(CollegeName))
            {
                Console.WriteLine("College Name can't be empty!");
                Environment.Exit(0);
            }
            Console.WriteLine("Enter Address Line 1:");
            AddressLine1 = Console.ReadLine();
            if (string.IsNullOrEmpty(AddressLine1))
            {
                Console.WriteLine("Address Line 1 can't be empty!");
                Environment.Exit(0);
            }
            Console.WriteLine("Enter Address Line 2:");
            AddressLine2 = Console.ReadLine();
            Console.WriteLine("Enter number of students enrolled:");
            int NoOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>(NoOfStudents);
            SubjectScore s1 = new SubjectScore();
            SubjectScore s2= new SubjectScore();
            SubjectScore s3 = new SubjectScore();
            SubjectScore s4 = new SubjectScore();
            SubjectScore s5=new SubjectScore();
            College college = new College(CollegeName,AddressLine1,AddressLine2,students);
            string FirstName, LastName;
            StudentType studentType;
            DateTime DOB;
            for (int i = 0; i < NoOfStudents; i++)
            {
                Console.WriteLine($"-----Student {i+1} details---------");
                Console.WriteLine("Enter First Name:");
                FirstName = Console.ReadLine();
                if (string.IsNullOrEmpty(FirstName))
                {
                    Console.WriteLine("First Name can't be Empty!");
                    Environment.Exit(0);
                }
                Console.WriteLine("Enter Last Name:");
                LastName = Console.ReadLine();
                Console.WriteLine("Enter a DOB in format(MM/DD/YYYY): ");
                DOB = DateTime.Parse(Console.ReadLine());
                if (DateTime.Now.Year - DOB.Year > 120)
                {
                    Console.WriteLine("Invalid DOB!");
                    Environment.Exit(0);
                }
                Console.WriteLine("Choose the type of Student:\n1. Day Time Scholar\n2. Part Time Scholar");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:studentType = StudentType.DayTimeScholar; 
                        break;
                    case 2:studentType = StudentType.PartTimeScholar;
                        break;
                    default:
                        studentType = StudentType.DayTimeScholar;
                        break;
                }
                college.students.Add(new Student(FirstName, LastName, DOB, studentType,s1,s2,s3,s4,s5));


            }
            foreach (var student in college.students)
            {
                Console.WriteLine($"------Enter Marks for {student.FirstName} {student.LastName}---------");
                student.s1.subject = Subjects.C;
                student.s2.subject = Subjects.Database;
                student.s3.subject = Subjects.ComputerArch;
                student.s4.subject = Subjects.OOPS;
                student.s5.subject = Subjects.ComputerNetworks;
                Console.Write($"C: ");
                student.s1.marks = int.Parse(Console.ReadLine());
                Console.Write($"Database: ");
                student.s2.marks = int.Parse(Console.ReadLine());
                Console.Write($"Computer Arch: ");
                student.s3.marks = int.Parse(Console.ReadLine());
                Console.Write($"OOPS: ");
                student.s4.marks = int.Parse(Console.ReadLine());
                Console.Write($"Computer Networks: ");
                student.s5.marks = int.Parse(Console.ReadLine());
                Console.WriteLine();

            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            college.printCollegeDetails();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            string user= ConfigurationManager.AppSettings.Get("User");
            if (user.Equals("ApteanUniversity"))
            {
                ApteanUniversity apu = new ApteanUniversity();
                apu.printDetails(college);
            }
            else if (user.Equals("TakshasheelaUniversity"))
            {
                var tku = new TakshasheelaUniversity();
                tku.printDetails(college);
            }

        }
    }
}
