using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFA
{
    class CFData
    {
        double x;
        double y;
        public CFData(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void setX(double x)
        {
            this.x = x;
        }
        public double getX()
        {
            return x;
        }
        public void setY(double y)
        {
            this.y = y;
        }
        public double getY()
        {
            return y;
        }
    }
}