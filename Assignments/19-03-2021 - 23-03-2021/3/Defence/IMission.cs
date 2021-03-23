using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    interface IMission
    {
        string codeName { get; set; }
        string state { get; set; }
        void CompleteMission();
    }
}
