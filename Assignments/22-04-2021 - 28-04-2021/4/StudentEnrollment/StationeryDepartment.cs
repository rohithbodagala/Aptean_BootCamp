using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment
{
    class StationeryDepartment
    {
        public void OnStudentEnrolled(object source, EventArgs args)
        {
            Console.WriteLine("Giving Stationery to the student...");
        }
    }
}
