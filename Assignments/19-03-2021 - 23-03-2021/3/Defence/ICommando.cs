using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    interface ICommando : ISpecialisedSoldier
    {
        List<Mission> missions { get; set; }
    }
}
