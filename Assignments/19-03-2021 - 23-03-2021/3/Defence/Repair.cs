using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    class Repair : IRepair
    {
        public int hoursWorked { get ; set; }
        public string partName { get; set; }
        public Repair(string partName,int hoursWorked)
        {
            this.hoursWorked = hoursWorked;
            this.partName = partName;
        }
        public override string ToString()
        {
            return $"Part Name:{partName}  Hours Worked:{hoursWorked}";
        }
    }
}
