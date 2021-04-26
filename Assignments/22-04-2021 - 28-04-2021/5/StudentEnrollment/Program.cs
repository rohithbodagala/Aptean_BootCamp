using System;

namespace StudentEnrollment
{
    class Program
    {
        public static void Main(string[] args)
        {
            StudentEnroll enroll = new StudentEnroll();
            StationeryDepartment stationeryDept = new StationeryDepartment();
            RelationshipDepartment relDept = new RelationshipDepartment();
            SystemAdminDepartment adminDept = new SystemAdminDepartment();

            enroll.StudentEnrolled += stationeryDept.OnStudentEnrolled;
            enroll.StudentEnrolled += relDept.OnStudentEnrolled;
            enroll.StudentEnrolled += adminDept.OnStudentEnrolled;
            Console.WriteLine("Do you want Stationery?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Student student;
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:student = new Student(true);
                    break;
                case 2:student = new Student(false);
                    break;
                default:student = new Student(true);
                    break;
            }
            Console.WriteLine();
            enroll.EnrollStudent(student);
            
        }
    }
}
