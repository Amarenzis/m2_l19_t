using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_CircleMVVM.Models
{
    static public class Geometry
    {
        static public double LengthOfCircle(double r)
        {
            double l = 2 * Math.PI * r;
            return l;
        }
    }
}
