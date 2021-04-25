using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public enum StudentType
    {
        DayTimeScholar, PartTimeScholar
    }
    public struct SubjectScore
    {
        public Subjects subject;
        public int marks;
    };
    public enum Subjects
    {
        C, Database, ComputerArch, OOPS, ComputerNetworks
    }
    public class Student
    {
        public string FirstName, LastName;
        public DateTime DOB;
        public StudentType studentType;
        public SubjectScore s1,s2,s3,s4,s5;
        public Student(string FirstName,string LastName,DateTime DOB,StudentType studentType, SubjectScore s1, SubjectScore s2, SubjectScore s3, SubjectScore s4, SubjectScore s5)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DOB = DOB;
            this.studentType = studentType;
            this.s1 = s1;
            this.s2 = s2;
            this.s3= s3;
            this.s4 = s4;
            this.s5= s5;

        }
        public void printStudentDetails()
        {
            double avg = (s1.marks + s2.marks + s3.marks + s4.marks + s5.marks) / 5;
            Console.WriteLine($"{FirstName} {LastName}\t{DOB.ToShortDateString()}\t{studentType}\t{s1.marks}\t{s2.marks}\t\t{s3.marks}\t\t{s4.marks}\t\t{s5.marks}\t{avg}\n");
        }
    }
}
