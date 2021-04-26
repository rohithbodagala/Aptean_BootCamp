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
            enroll.EnrollStudent();
            
        }
    }
}
