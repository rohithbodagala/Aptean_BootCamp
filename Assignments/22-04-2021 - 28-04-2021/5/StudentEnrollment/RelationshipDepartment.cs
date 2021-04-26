using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment
{
    class RelationshipDepartment
    {
        public void OnStudentEnrolled(object source,Student student)
        {
            Console.WriteLine("Giving starter kit to the student...");
        }
    }
}
