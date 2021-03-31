using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog
{
    class ComputerProgram : Item
    {
        public ComputerProgram(string Name, string Code, Category category, double Size) : base(Name, Code, category, Size)
        {
        }
    }
}
