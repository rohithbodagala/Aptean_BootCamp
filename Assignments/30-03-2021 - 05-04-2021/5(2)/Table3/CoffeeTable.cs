using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table3
{
    class CoffeeTable : Table
    {
        //public int Width, Height;
        public CoffeeTable(int Width, int Height) : base(Width, Height)
        {
            Width = base.Width;
            Height = base.Height;
        }
        public override string ShowData()
        {
            return $"{base.ShowData()}(Coffee table).";
        }
    }
}
