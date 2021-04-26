 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment
{
    class SystemAdminDepartment
    {
        public void OnStudentEnrolled(object source,Student student)
        {
            Console.WriteLine("Alloting Desktop Environment to the student...");
        }
    }
}
