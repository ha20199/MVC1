using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class GiaiPtb1
    {
        public double GiaiPTB1(double HeSoA, double HeSoB)
        {
            double x;
            x = -HeSoB / HeSoA;
            return x;
        }
    }
}