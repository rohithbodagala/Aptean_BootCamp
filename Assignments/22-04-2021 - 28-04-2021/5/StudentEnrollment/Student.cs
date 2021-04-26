using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment
{
    public class Student : EventArgs
    {
        public bool wantStationery;
        public Student(bool wantStationery)
        {
            this.wantStationery = wantStationery;
        }
    }
}
