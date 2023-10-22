using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Circle : Geometri
    {
        public double Radius { get; set; } = 4;

        public override double Area()
        {
           return Math.PI * Radius * Radius;
        }
    }
}
