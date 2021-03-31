using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table3
{
    class Leg : Table
    {
        public Leg(int Width,int Height) : base(Width, Height)
        {
            Console.WriteLine(ShowData());
        }
        public override string ShowData()
        {
            return $"I am a leg.\n{base.ShowData()} ";
        }
    }
}
