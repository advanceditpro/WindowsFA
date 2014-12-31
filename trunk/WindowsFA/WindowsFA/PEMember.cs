using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFA
{
    class PEMember
    {
        double Value;
        Boolean Locked = false;
        public PEMember(double dv, bool blocked)
        {
            this.Value = dv;
            this.Locked = blocked;
        }
        public void setValue(double dv)
        {
            if (!this.Locked)
            {
                this.Value = dv;
            }
        }
        public double getValue()
        {
            return this.Value;
        }
        public void setLocked(bool blocked)
        {
            this.Locked = blocked;
        }
        public bool getLocked()
        {
            return this.Locked;
        }
    }
}
