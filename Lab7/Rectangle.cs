using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Rectangle : Geometri
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle() 
        {
            Height = 2;
            Width = 4;
        }
        public override double Area()
        {
            return Height * Width;
        }
    }
}
