using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment
{
    public class StudentEnroll
    {
        public delegate void StudentEnrolledEventHandler(object source, EventArgs args);
        public event StudentEnrolledEventHandler StudentEnrolled;
        
        public void EnrollStudent()
        {
            Console.WriteLine("Enrolling student....");
            OnStudentEnrolled();
        }
        protected virtual void OnStudentEnrolled()
        {
            if (StudentEnrolled != null)
            {
                StudentEnrolled(this, EventArgs.Empty);
            }

        }
    }
    
}
