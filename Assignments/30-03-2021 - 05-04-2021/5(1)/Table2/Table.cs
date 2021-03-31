using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table2
{
    class Table
    {
        public int Width, Height;
        public Table(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;

        }
        public virtual string ShowData()
        {
            return $"Width: {Width} cm\nHeight: {Height} cm";
        }

    }
}
