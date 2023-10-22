using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Ellips : Geometri
    {
        public double MajorAxis { get; set; } = 4;
        public double MinorAxis { get; set; } = 9;

        public override double Area()
        {
            return Math.PI * MajorAxis * MinorAxis;
        }
    }
}
