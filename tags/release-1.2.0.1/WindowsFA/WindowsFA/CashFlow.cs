using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFA
{
    class CashFlow
    {
            CFData[] data = null;
            double safeI = 0;
            double riskI = 0;

            public CashFlow(int n)
            {
                this.data = new CFData[n];
                for (int i = 0; i < n; i++)
                {
                    this.data[i] = new CFData(0.0, 0.0);
                }
            }

            public CFData getCFData(int i)
            {
                if (i >= 0 && i < this.data.Length)
                {
                    return this.data[i];
                }
                else
                {
                    return null;
                }
            }

            public void setCFData(CFData d, int i)
            {
                this.data[i] = d;
            }
            public double getRiskI()
            {
                return riskI;
            }

            public void setRiskI(double riskI)
            {
                this.riskI = riskI;
            }

            public double getSafeI()
            {
                return safeI;
            }

            public void setSafeI(double safeI)
            {
                this.safeI = safeI;
            }
            public float getNPV()
            {
                return this.getNPV(this.safeI);
            }
            public float getNPV(double s)
            {
                double disc = 1.0 / (1.0 + s);
                double npvsum = 0.0;
                int cp = 0;
                CFData d1 = this.data[0];
                double dc0 = d1.getX();
                for (int cj = 1; cj < this.data.Length; ++cj)
                {
                    d1 = this.data[cj];
                    double dc1 = d1.getX();
                    int c2 = (int)d1.getY();
                    for (int ck = 1; ck <= c2; ++ck)
                    {
                        cp += 1;
                        npvsum += Math.Pow(disc, cp) * dc1;
                    }
                }
                return (float)(dc0 + npvsum);
            }
        public float getIRR()
        {
            return this.getIRR(this.safeI, this.riskI);
        }

        public float getIRR(double s, double r)
        {
            double[] cfexpanded = new double[100];
            int cp = 0;
            CFData d1 = this.data[0];
            double dc0 = d1.getX();
            cfexpanded.SetValue(dc0, cp);
            for (int cj = 1; cj < this.data.Length; ++cj)
            {
                d1 = this.data[cj];
                double dc1 = d1.getX();
                int c2 = (int)d1.getY();
                for (int ck = 1; ck <= c2; ++ck)
                {
                    cp += 1;
                    cfexpanded.SetValue(dc1, cp);
                }
            }
            double intermediate = Microsoft.VisualBasic.Financial.IRR(
                ref cfexpanded, 0.1);
            if (Double.IsNaN(intermediate))
            {
                return (float) 0.0;
            } else {
                return (float) intermediate;
            }

        }

        public float getMIRR()
        {
            return this.getMIRR(this.safeI, this.riskI);
        }
        public float getMIRR(double s, double r)
        {
            try
            {
                double discs = 1.0 / (1.0 + s);
                double discr = 1.0 / (1.0 + r);
                double npvsum = 0.0;
                double pnpvsum = 0.0;
                double nnpvsum = 0.0;
                int cp = 0;
                CFData d1 = this.data[0];
                double dc0 = d1.getX();
                for (int cj = 1; cj < this.data.Length; ++cj)
                {
                    d1 = this.data[cj];
                    double dc1 = d1.getX();
                    int c2 = (int)d1.getY();
                    for (int ck = 1; ck <= c2; ++ck)
                    {
                        cp += 1;
                        npvsum += Math.Pow(discs, cp) * dc1;
                        if (dc1 > 0)
                        {
                            pnpvsum += Math.Pow(discr, cp) * dc1;
                        }
                        if (dc1 < 0)
                        {
                            nnpvsum += Math.Pow(discs, cp) * dc1;
                        }
                    }
                }
                if (dc0 > 0)
                {
                    pnpvsum += dc0;
                }
                if (dc0 < 0)
                {
                    nnpvsum += dc0;
                }
                double top = (-1.0 * pnpvsum * Math.Pow(1.0 + r, this.data.Length));
                double bottom = (nnpvsum * (1.0 + s));
                double intermediate = (Math.Pow(top / bottom, 1.0 / (this.data.Length - 1.0)));
                double intermediate2 = intermediate - 1.0;
                if (Double.IsNaN(intermediate2))
                {
                    return (float)(0.0);
                }
                else
                {
                    return (float)(intermediate - 1.0);
                }
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("ERROR. Divided by 0.");
                return (float)(0.0);
            }
            catch (NotFiniteNumberException)
            {
                Console.WriteLine("ERROR. Not a Finite Number.");
                return (float)(0.0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return (float)(0.0);
            }

        }
    }
}
