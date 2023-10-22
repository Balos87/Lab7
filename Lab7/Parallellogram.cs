using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Parallellogram : Geometri
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Parallellogram()
        {
            Base = 5.5;
            Height = 8.3;
        }

        public override double Area()
        {
            return Base * Height;
        }
    }
}
