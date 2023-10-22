using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Square : Geometri
    {
        public double OneSide { get; set; }

        public Square() 
        {
            OneSide = 8;
        }
        public override double Area()
        {
            return OneSide * OneSide;
        }
    }
}
