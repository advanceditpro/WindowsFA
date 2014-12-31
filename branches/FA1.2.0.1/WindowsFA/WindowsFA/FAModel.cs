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
        public float eff(double r)
        {
            return (float)(Math.Pow(Math.E, r) - 1.0);
        }
        public float eff(double r, double p)
        {
            return (float)(Math.Pow(1.0 + r / p, p) - 1.0);
        }
        public float nom(double r)
        {
            return (float)(Math.Log(r + 1.0));
        }
        public float nom(double r, double p)
        {
            return (float)(p * ((Math.Pow(r + 1.0, 1.0 / p) - 1.0)));
        }
    }
}
