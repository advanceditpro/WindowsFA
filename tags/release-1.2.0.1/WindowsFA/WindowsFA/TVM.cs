using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFA
{
    class TVM
    {
        TVMObjects Calculating; 
        double N = 360.0; //number of periods (year * period per year)
        double PV = 0.0;
        double PMT = 0.0;
        double FV = 0.0;
        double I = 0.0; //full year interest rate
        double P = 12.0; //period per year
        double S = 0.0; //0.0 for End, 1.0 for Begin
        double IP = 0.0;
        double K = 1.0; //1.0 for End, 1.0+IP for Begin
        Microsoft.VisualBasic.DueDate duedate = Microsoft.VisualBasic.DueDate.EndOfPeriod;
        public TVM()
        {

        }
        public TVMObjects getCalculating()
        {
            return Calculating;
        }

        public void setCalculating(TVMObjects s)
        {
            Calculating = s;
        }
        public void setI(double i)
        {
            I = i;
            IP = i / P;
            calcK();
        }
        public void setN(double n)
        {
            if (n > 0)
            {
                N = n;
            }
        }
        public double getP()
        {
            return P;
        }
        public void setP(double p)
        {
            if (p <= 0)
            {
                P = 1.0;
            }
            else
            {
                P = p;
            }
            IP = I / p;
            calcK();
        }
        public double getS()
        {
            return S;
        }
        public void setS(double s)
        {
            S = s;
            duedate = S == 0.0 ? Microsoft.VisualBasic.DueDate.EndOfPeriod : Microsoft.VisualBasic.DueDate.BegOfPeriod ;
            calcK();
        }
        private void calcK()
        {
            if (S == 0.0)
            {
                this.K = 1.0;
            }
            else
            {
                this.K = 1.0 + IP;
            }

        }
        public void setPMT(double pmt)
        {
            PMT = pmt;
        }
        public void setFV(double fv)
        {
            FV = fv;
        }
        public void setPV(double pv)
        {
            PV = pv;
        }
        /*
         * iteration based solution, Begin and End is not working
            public float getPV() {
                double disc = 1.0/(1.0+IP);
                double pvsum=0.0;
                for (int cj=1; cj<N; ++cj) {
                    pvsum += Math.pow(disc,(double)cj)*PMT;
                }
                return (float)(-1.0 * (FV / Math.pow(disc, N)+ pvsum));
            }
        */
        public double getPV()
        {
            return this.PV;
        }
        public float getPV(String s)
        {
            double disc = 1.0 / (1.0 + IP);
            double pvsum = 0.0;
            pvsum = ((PMT * K) / IP - FV) * Math.Pow(disc, N) - ((PMT * K) / IP);
            if (Double.IsNaN(pvsum))
            {
                return (float)0.0;
            }
            else
            {
                PV = pvsum;
                return (float)pvsum;
            }
        }
        /*
         * iteration based solution, Begin and End is not working
            public float getFV() {
                double disc = (1.0+IP);
                double pvsum=0.0;
                for (int cj=1; cj<N; ++cj) {
                    pvsum += Math.pow(disc,(double)cj)*PMT;
                }
                return (float)( (PV * Math.pow(disc, N)) + 1.0 *(pvsum));
            }
        */
        public double getFV()
        {
            return this.FV;
        }
        public float getFV(String s)
        {
            try
            {
                double disc = (1.0 + IP);
                double fvsum = (PMT * K) / IP - Math.Pow(disc, N) * (PV + (PMT * K) / IP);
                if (Double.IsNaN(fvsum))
                {
                    return (float)0.0;
                }
                else
                {
                    FV = fvsum;
                    return (float)fvsum;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TVM: Invalid argument during FV calculation.");
                return (float)(this.FV);
            }
        }
        public double getPMT()
        {
            return this.PMT;
        }
        public float getPMT(String s)
        {
            try
            {
                double disc = (1.0 + IP);
                double fmt = (PV + ((PV + FV) / (Math.Pow(disc, N) - 1.0))) * (-1.0 * (IP / K));
                if (Double.IsNaN(fmt))
                {
                    return (float)0.0;
                }
                else
                {
                    PMT = fmt;
                    return (float)fmt;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TVM: Invalid argument during PMT calculation.");
                return (float)(this.PMT);
            }
        }

        public double getI()
        {
            return I;
        }
        public float getI(String s)
        {
            try
            {
                double tempI;
                tempI = Microsoft.VisualBasic.Financial.Rate(
                    this.N,
                    this.PMT,
                    this.PV,
                    this.FV,
                    this.duedate, 0.1
                    ) * this.P ;
                I = tempI;
                return (float) I;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TVM: Invalid argument during I calculation.");
                return (float)(this.I);
            }

        }
        public double getN()
        {
            return this.N;
        }
        public float getN(String s)
        {

            try
            {
                double tempN;
                tempN = Microsoft.VisualBasic.Financial.NPer(
                    this.IP, 
                    this.PMT,
                    this.PV,
                    this.FV,
                    duedate
                    );
                if (tempN > 0)
                {
                    N = tempN;
                }
                return (float)N;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TVM: Invalid argument during N calculation.");
                return (float)(this.N);
            }
        }//getN(String s)
        public float getIPMT(int iPeriod)
        {
            try
            {
                double IPMT;
                IPMT = Microsoft.VisualBasic.Financial.IPmt(
                    this.IP,
                    iPeriod,
                    this.N,
                    this.PV,
                    this.FV,
                    duedate
                    );
                return (float)IPMT;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TVM: Invalid argument during Interest PMT calculation.");
                return (float)(0.0);
            }

        } //getIPMT(int iPeriod)

        public float getPPMT(int iPeriod)
        {
            try
            {
                double PPMT;
                PPMT = Microsoft.VisualBasic.Financial.PPmt(
                    this.IP,
                    iPeriod,
                    this.N,
                    this.PV,
                    this.FV,
                    duedate
                    );
                return (float)PPMT;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TVM: Invalid argument during Principal PMT calculation.");
                return (float)(0.0);
            }

        } //getIPMT(int iPeriod)

    }
}
