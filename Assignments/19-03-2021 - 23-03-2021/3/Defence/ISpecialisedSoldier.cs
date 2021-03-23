using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    interface ISpecialisedSoldier : IPrivate
    {
        string corps { get; set; }
    }
}
