using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table3
{
    class Table
    {
        public int Width, Height;
        List<Leg> legs = new List<Leg>();
        public Table(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;

        }
        public void AddLeg()
        {
            legs.Add(new Leg(Width, Height));
        }
        public virtual string ShowData()
        {
            return $"Width: {Width} cm\nHeight: {Height} cm";
        }

    }
}
