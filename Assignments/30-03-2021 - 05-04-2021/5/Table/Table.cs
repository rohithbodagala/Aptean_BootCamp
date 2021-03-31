using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Table
    {
        int Width, Height;
        public Table(int Width,int Height)
        {
            this.Width = Width;
            this.Height = Height;

        }
        public void ShowData()
        {
            Console.WriteLine($"Width: {Width} cm\nHeight: {Height} cm");
        }

    }
}
