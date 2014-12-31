using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFA
{
    public class FAModel
    {
        public FAModel()
        {
        }
        public double eff(double r)
        {
            return (Math.Pow(Math.E, r) - 1.0);
        }
        public double eff(double r, double p)
        {
            return (Math.Pow(1.0 + r / p, p) - 1.0);
        }
        public double nom(double r)
        {
            return (Math.Log(r + 1.0));
        }
        public double nom(double r, double p)
        {
            return (p * ((Math.Pow(r + 1.0, 1.0 / p) - 1.0)));
        }
    }
}
