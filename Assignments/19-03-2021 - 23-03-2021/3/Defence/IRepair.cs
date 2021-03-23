using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    interface IRepair
    {
        int hoursWorked { get; set; }
        string partName { get; set; }

    }
}
