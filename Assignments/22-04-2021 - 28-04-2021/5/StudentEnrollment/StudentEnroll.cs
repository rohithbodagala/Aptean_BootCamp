using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment
{
    public class StudentEnroll
    {
        public delegate void StudentEnrolledEventHandler(object source,Student student);
        public event StudentEnrolledEventHandler StudentEnrolled;
        
        public void EnrollStudent(Student student)
        {
            Console.WriteLine("Enrolling the student....");
            OnStudentEnrolled(student);
        }
        protected virtual void OnStudentEnrolled(Student student)
        {
            if (StudentEnrolled != null)
            {
                StudentEnrolled(this,student);
            }

        }
    }
    
}
