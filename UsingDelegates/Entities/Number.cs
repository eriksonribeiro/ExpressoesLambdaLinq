using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegates.Entities
{
    public class Number
    {
        public double ValueX { get; set; }
        public double ValueY { get; set; }
        public Number(double valueX, double valueY)
        {
            ValueX = valueX;
            ValueY = valueY;
        }
    }
}
