﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defence
{
    interface IPrivate : ISoldier
    {
        double salary { get; set; }
    }
}
