using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace WindowsFA
{
    class PriceEarning
    {
        string Symbol;
        PEMember Price = new PEMember(0.0, false);
        PEMember EPS = new PEMember(0.0, false);
        PEMember PE = new PEMember(0.0, false);
        PEMember Yield = new PEMember(0.0, false);
        double I = 0.0; //full year interest rate
        double MarketCap = 0.0;
        string MarketCapstr;
        string CompanyName;
        string htmlIndex;
        double PriceOpen;

        public PriceEarning()
        {

        }

        public string getCompanyName()
        {
            return CompanyName;
        }
        public double getMarketCap()
        {
            return MarketCap;
        }
        public string getMarketCapstr()
        {
            return MarketCapstr;
        }
        public string getSymbol()
        {
            return Symbol;
        }
        public void setSymbol(String s)
        {
            Symbol = s.Trim();
        }
        public void lockPrice(bool blocked)
        {
            Price.setLocked(blocked);
        }

        public double getPriceOpen()
        {
            return PriceOpen;
        }
        public double getPrice()
        {
            return Price.getValue();
        }
        public double getPrice(String s)
        {
            return PE.getValue() * EPS.getValue();
        }
        public void setPrice(double p)
        {
            Price.setValue(p);
            if ((EPS.getValue() != 0.0))
            {
                PE.setValue(p / EPS.getValue());
            }
        }
        public void lockEPS(bool blocked)
        {
            EPS.setLocked(blocked);
        }
        public double getEPS()
        {
            return EPS.getValue();
        }
        public double getEPS(string s)
        {
            if (this.PE.getValue().Equals(0))
            {
                return EPS.getValue();
            }
            else
            {
                EPS.setValue(Price.getValue() / PE.getValue());
                return Price.getValue()/PE.getValue();
            }
        }
        public void setEPS(double eps)
        {
            EPS.setValue(eps);
            if ((EPS.getValue() != 0.0))
            {
                PE.setValue(Price.getValue() / eps);
            }
            else
            {
                PE.setValue(0.0);
            }
            Price.setValue(EPS.getValue() * PE.getValue());
        }
        public void lockPE(bool blocked)
        {
            PE.setLocked(blocked);
        }
        public double getPE()
        {
            return PE.getValue();
        }
        public double getPE(string s)
        {
            if (EPS.getValue() != 0)
            {
                return (Price.getValue() / EPS.getValue());
            }
            else
            {
                return 0.0;
            }
        }
        public void setPE(double pe)
        {
            PE.setValue(pe);
            if ((PE.getValue() != 0.0))
            {
                Yield.setValue(1.0 / PE.getValue());
            }
            else
            {
                Yield.setValue(0.0);
            }
            Price.setValue(EPS.getValue() * PE.getValue());
        }
        public void lockYield(bool blocked)
        {
            Yield.setLocked(blocked);
        }
        public double getYield()
        {
            return Yield.getValue();
        }
        public double getYield(string s)
        {
            if ((PE.getValue() != 0))
            {
                Yield.setValue(1.0 / PE.getValue());
                return Yield.getValue();
            }
            else
            {
                return Yield.getValue();
            }
        }
        public void setYield(double yld)
        {
            Yield.setValue(yld);
        }
        public double getI()
        {
            return I;
        }
        public void setI(double i)
        {
            I = i;
        }

        public void GetQuotesYahoo()
        {
            string serverURL = @"http://finance.yahoo.com/q?s=" + this.Symbol + "&d=e";
            //Create a HttpWebRequest object for the server search URL
            HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(serverURL);
            WebProxy myProxy = new WebProxy();
            // Obtain the 'Proxy' of the  Default browser.  
//            myProxy = (WebProxy)webreq.Proxy;
            if (Program.cApp.InetConnectionIndex == 1)
            {
                // Create a new Uri object.
                Uri newUri = new Uri(Program.cApp.ProxyURL);
                // Associate the newUri object to 'myProxy' object so that new myProxy settings can be set.
                myProxy.Address = newUri;
                // Create a NetworkCredential object and associate it with the Proxy property of request object.
//                myProxy.Credentials = new NetworkCredential(username, password);
                webreq.Proxy = myProxy;

            }
            webreq.MaximumAutomaticRedirections = 60;
            webreq.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0;Windows NT 5.0)";
            //Retrieve HttpWebResponse object from the Search server URL
            HttpWebResponse webresp = (HttpWebResponse)webreq.GetResponse();
            //Create StreamReader object and pass the searchserver stream as parameter, with ASCII encoding
            StreamReader strm = new StreamReader(webresp.GetResponseStream(), Encoding.ASCII);
            //iterate through the stream, building return XML Document string
            string res = strm.ReadToEnd();
            strm.Close();
            int startpos=1;
            int endpos;
            string mcapstr;
            string mcapnumberstr; 
            string mfactstr;
            string strCaptured;
            double mfact = 1.0;
            string startposSS = string.Empty;
            string endposSS = string.Empty;
//            string[] arSymbols = QuoteList.Split(Convert.ToChar(" "));
// for loop is for multiple quote
//            for (int i = 0; i < arSymbols.Length; i++)
//            {
//            res = res.Substring(startpos);
            startposSS = "Last Trade:</td><td class=\"yfnc_tabledata1\"><big><b><span id=\"yfs_l10_";
            startpos = res.IndexOf(startposSS)+2+Symbol.Length;
            endposSS = "</span></b></big></td></tr><tr><td class=\"yfnc_tablehead1\" width=\"48%\">Trade Time";
            endpos = res.IndexOf(endposSS);
            this.Price.setValue(Double.Parse(res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length))));
            startposSS = "EPS <small>(ttm)</small>:</td><td class=\"yfnc_tabledata1\">";
            startpos = res.IndexOf(startposSS);
            endposSS = "</td></tr><tr><td class=\"yfnc_tablehead1\" width=\"48%\">Div &amp; Yield";
            endpos = res.IndexOf(endposSS);
            strCaptured = res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length));
            if (strCaptured.Contains("N/A"))
            { this.EPS.setValue(this.getPrice()); }
            else
            {
                this.EPS.setValue(Double.Parse(strCaptured));
            }
            startposSS = "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=iso-8859-1\"><title>";
            startpos = res.IndexOf(startposSS);
            endposSS = " - Yahoo! Finance</title><link rel=\"stylesheet\" type=\"text/css\"";
            endpos = res.IndexOf(endposSS);
            this.CompanyName = (res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length)));
            startposSS = "Open:</td><td class=\"yfnc_tabledata1\">";
            startpos = res.IndexOf(startposSS);
            endposSS = "</td></tr><tr><td class=\"yfnc_tablehead1\" width=\"48%\">Bid:";
            endpos = res.IndexOf(endposSS);
            strCaptured = res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length));
            if (strCaptured.Contains("N/A"))
            { this.PriceOpen = this.getPrice(); }
            else
            {
                this.PriceOpen = Double.Parse(strCaptured);
            }
            startposSS = "P/E <small>(ttm)</small>:</td><td class=\"yfnc_tabledata1\">";
            startpos = res.IndexOf(startposSS);
            endposSS = "</td></tr><tr><td class=\"yfnc_tablehead1\" width=\"48%\">EPS <small>(ttm)</small>";
            endpos = res.IndexOf(endposSS);
            strCaptured = res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length));
            if (strCaptured.StartsWith("N/A"))
            {
                if (!EPS.getValue().Equals(0))
                { this.PE.setValue(Price.getValue() / EPS.getValue()); }
                else
                { this.PE.setValue(-1); }
            }
            else
            {
                this.PE.setValue(Double.Parse(strCaptured));
            }
            startposSS = "Market Cap:</td><td class=\"yfnc_tabledata1\"><span id=\"yfs_j10_";
            startpos = res.IndexOf(startposSS)+2+Symbol.Length;
            endposSS = "</span></td></tr><tr><td class=\"yfnc_tablehead1\" width=\"48%\">P/E <small>(ttm)</small>:</td><td class=\"yfnc_tabledata1\">";
            endpos = res.IndexOf(endposSS);
            if (endpos < 0)
            {
                startposSS = "Market Cap:</td><td class=\"yfnc_tabledata1\">";
                startpos = res.IndexOf(startposSS);
                endposSS = "</td></tr><tr><td class=\"yfnc_tablehead1\" width=\"48%\">P/E <small>(ttm)</small>:</td><td class=\"yfnc_tabledata1\">";
                endpos = res.IndexOf(endposSS);
            }
            mcapstr = res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length));
            if (mcapstr.Contains("N/A"))
            {
                this.MarketCapstr = "N/A";
                this.MarketCap = 0;

            }else {
                mcapnumberstr = mcapstr.Substring(0, mcapstr.Length - 1);
                mfactstr = mcapstr.Substring(mcapstr.Length-1, mcapstr.Length-(mcapstr.Length-1));
                switch (mfactstr){
                    case "B" :
                        mfact = 1000000000.0;
                        break;
                    case "M":
                        mfact = 1000000.0;
                        break;
                    case "K":
                        mfact = 1000.0;
                        break;
                }
                this.MarketCapstr = mcapstr;
                this.MarketCap = (Double.Parse(mcapnumberstr)*mfact);
            }
            //            }
        } // end GetQuotesYahoo

        public void GetQuotesGoogle()
        {
            string serverURL = @"http://finance.google.com/finance?q=" + this.Symbol;
            //Create a HttpWebRequest object for the server search URL
            HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(serverURL);
            WebProxy myProxy = new WebProxy();
            // Obtain the 'Proxy' of the  Default browser.  
            //            myProxy = (WebProxy)webreq.Proxy;
            if (Program.cApp.InetConnectionIndex == 1)
            {
                // Create a new Uri object.
                Uri newUri = new Uri(Program.cApp.ProxyURL);
                // Associate the newUri object to 'myProxy' object so that new myProxy settings can be set.
                myProxy.Address = newUri;
                // Create a NetworkCredential object and associate it with the Proxy property of request object.
                //                myProxy.Credentials = new NetworkCredential(username, password);
                webreq.Proxy = myProxy;

            }
            webreq.MaximumAutomaticRedirections = 60;
            webreq.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0;Windows NT 5.0)";
            //Retrieve HttpWebResponse object from the Search server URL
            HttpWebResponse webresp = (HttpWebResponse)webreq.GetResponse();
            //Create StreamReader object and pass the searchserver stream as parameter, with ASCII encoding
            StreamReader strm = new StreamReader(webresp.GetResponseStream(), Encoding.ASCII);
            //iterate through the stream, building return XML Document string
            string res = strm.ReadToEnd();
            strm.Close();
            int startpos = 1;
            int endpos;
            string _companyId=String.Empty;
            string mcapstr;
            string mcapnumberstr;
            string mfactstr;
            string strCaptured;
            double mfact = 1.0;
            string startposSS = String.Empty;
            string endposSS = String.Empty;
            //            string[] arSymbols = QuoteList.Split(Convert.ToChar(" "));
            // for loop is for multiple quote
            //            for (int i = 0; i < arSymbols.Length; i++)
            //            {
            //            res = res.Substring(startpos);
            startposSS = "var _companyId = ";
            startpos = res.IndexOf(startposSS);
            endposSS = ";\n  \n  \n    var _kAsyncKeydevsParam";
            endpos = res.IndexOf(endposSS);
            _companyId = (res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length)));
            //
            startposSS = "<td  width=\"1%\" rowspan=\"2\" valign=\"top\"><span class=\"pr\" id=\"ref_";
            startpos = res.IndexOf(startposSS) + 4 + _companyId.Length;
            endposSS = "</span></td>\n<td>&nbsp;</td>\n<td  width=\"1%\" class=\"key\">&nbsp;Open:&nbsp;</td>";
            endpos = res.IndexOf(endposSS);
            this.Price.setValue(Double.Parse(res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length))));
            startposSS = "<td  class=\"key\">&nbsp;EPS:&nbsp;</td>\n<td  class=\"val\">";
            startpos = res.IndexOf(startposSS);
            endposSS = "</td>\n</tr>\n</table>\n<table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\">\n<tbody><tr id=\"tabsTR\">";
            endpos = res.IndexOf(endposSS);
            // for after-market
            if (endpos == -1)
            {
                endposSS = "</td>\n</tr>\n<tr><td colspan=\"10\" style=\"padding-top:5px\">\n<span style=\"color:black;white-space:normal\">\n<nobr><b>After Hours:&nbsp;";
                endpos = res.IndexOf(endposSS);
            }
            // for pre-market
            if (endpos == -1)
            {
                endposSS = "</td>\n</tr>\n<tr><td colspan=\"10\" style=\"padding-top:5px\">\n<span style=\"color:black;white-space:normal\">\n<nobr><b>Pre-Market:&nbsp;";
                endpos = res.IndexOf(endposSS);
            }
            strCaptured = res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length));
            if (strCaptured.Contains("N/A"))
            { this.EPS.setValue(this.getPrice()); }
            else
            {
                this.EPS.setValue(Double.Parse(strCaptured));
            }
            startposSS = "<title>";
            startpos = res.IndexOf(startposSS);
            endposSS = " - Google Finance</title>";
            endpos = res.IndexOf(endposSS);
            this.CompanyName = (res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length)));
            startposSS = "<td  width=\"1%\" class=\"key\">&nbsp;Open:&nbsp;</td>\n<td  width=\"1%\" class=\"val\"><span id=\"ref_";
            startpos = res.IndexOf(startposSS) + 5 + _companyId.Length;
            endposSS = "</span></td>\n<td>&nbsp;&nbsp;&nbsp;</td>\n<td  width=\"1%\" class=\"key\">&nbsp;Mkt&nbsp;Cap:&nbsp;</td>";
            endpos = res.IndexOf(endposSS);
            strCaptured = res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length));
            if (strCaptured.Contains("N/A"))
            { this.PriceOpen = this.getPrice(); }
            else
            {
                this.PriceOpen = Double.Parse(strCaptured);
            }
            startposSS = "<td  width=\"1%\" class=\"key\">&nbsp;P/E:&nbsp;</td>\n<td  width=\"1%\" class=\"val\"><span id=\"ref_";
            startpos = res.IndexOf(startposSS)+5+_companyId.Length;
            endposSS = "</span></td>\n</tr>\n<tr>\n<td>&nbsp;</td>\n<td  class=\"key\">&nbsp;High:&nbsp;</td>";
            endpos = res.IndexOf(endposSS);
            strCaptured = res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length));
            if (strCaptured.StartsWith("N/A"))
            {
                if (!EPS.getValue().Equals(0))
                { this.PE.setValue(Price.getValue() / EPS.getValue()); }
                else
                { this.PE.setValue(-1); }
            }
            else
            {
                this.PE.setValue(Double.Parse(strCaptured));
            }
            startposSS = "<td  width=\"1%\" class=\"key\">&nbsp;Mkt&nbsp;Cap:&nbsp;</td>\n<td  width=\"1%\"  class=\"val\"><span id=\"ref_";
            startpos = res.IndexOf(startposSS)+5+_companyId.Length;
            endposSS = "</span></td>\n<td>&nbsp;&nbsp;&nbsp;</td>\n<td  width=\"1%\" class=\"key\">&nbsp;P/E:&nbsp;</td>";
            endpos = res.IndexOf(endposSS);
            mcapstr = res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length));
            if (mcapstr.Contains("N/A"))
            {
                this.MarketCapstr = "N/A";
                this.MarketCap = 0;
            }
            else
            {
                mcapnumberstr = mcapstr.Substring(0, mcapstr.Length - 1);
                mfactstr = mcapstr.Substring(mcapstr.Length - 1, mcapstr.Length - (mcapstr.Length - 1));
                switch (mfactstr)
                {
                    case "B":
                        mfact = 1000000000.0;
                        break;
                    case "M":
                        mfact = 1000000.0;
                        break;
                    case "K":
                        mfact = 1000.0;
                        break;
                }
                this.MarketCapstr = mcapstr;
                this.MarketCap = (Double.Parse(mcapnumberstr) * mfact);
            }
            //            }
        } // end GetQuotesGoogle

        public string GetQuotesIndex()
        {
            string serverURL = @"http://finance.google.com/finance";
            //Create a HttpWebRequest object for the server search URL
            HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(serverURL);
            WebProxy myProxy = new WebProxy();
            // Obtain the 'Proxy' of the  Default browser.  
            //            myProxy = (WebProxy)webreq.Proxy;
            if (Program.cApp.InetConnectionIndex == 1)
            {
                // Create a new Uri object.
                Uri newUri = new Uri(Program.cApp.ProxyURL);
                // Associate the newUri object to 'myProxy' object so that new myProxy settings can be set.
                myProxy.Address = newUri;
                // Create a NetworkCredential object and associate it with the Proxy property of request object.
                //                myProxy.Credentials = new NetworkCredential(username, password);
                webreq.Proxy = myProxy;

            }
            webreq.MaximumAutomaticRedirections = 60;
            webreq.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0;Windows NT 5.0)";
            //Retrieve HttpWebResponse object from the Search server URL
            HttpWebResponse webresp = (HttpWebResponse)webreq.GetResponse();
            //Create StreamReader object and pass the searchserver stream as parameter, with ASCII encoding
            StreamReader strm = new StreamReader(webresp.GetResponseStream(), Encoding.ASCII);
            //iterate through the stream, building return XML Document string
            string res = strm.ReadToEnd();
            strm.Close();
            int startpos = 1;
            int endpos;
            string headerStr = String.Empty;
            string footerStr = String.Empty;
            string startposSS = String.Empty;
            string endposSS = String.Empty;
            headerStr = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0//EN\"><HTML><HEAD><TITLE>Index</TITLE>";
            headerStr += "<STYLE type=\"text/css\">";
            headerStr += "BODY { font-family: Arial,sans-serif ;font-size: 80% }";
            headerStr += "</STYLE></HEAD><BODY>";
            footerStr = "</BODY></HTML>";
            startposSS = "<table cellpadding=\"\" cellspacing=\"0\" width=\"100%\" id=\"mktsumm\">";
            startpos = res.IndexOf(startposSS) - startposSS.Length;
            endposSS = "</td>\n<td style=\"width:1%\">\n<img width=2 height=1 src=\"/finance/images/cleardot.gif\">";
            endpos = res.IndexOf(endposSS);
            htmlIndex = (res.Substring(startpos + startposSS.Length, endpos - (startpos + startposSS.Length)));
            string cleanhtmlIndex0 = htmlIndex.Replace("<img src=\"/finance/images/index0dot.gif\" width=10 height=10>&nbsp;<a href=\"/finance?cid=983582\">Dow", "<font color=blue>Dow</font>");
            string cleanhtmlIndex1 = cleanhtmlIndex0.Replace("<img src=\"/finance/images/index1dot.gif\" width=10 height=10>&nbsp;<a href=\"/finance?cid=13756934\">Nasdaq", "<font color=red>Nasdaq</font>");
            string cleanhtmlIndex2 = cleanhtmlIndex1.Replace("<img src=\"/finance/images/index2dot.gif\" width=10 height=10>&nbsp;<a href=\"/finance?cid=626307\">S&P&nbsp;500", "<font color=orange>S&P&nbsp;500</font>");
            string cleanhtmlIndex3 = cleanhtmlIndex2.Replace("<img id=indexDot0 class=hsprite src=\"/finance/images/cleardot.gif\" width=10 height=10>&nbsp;<a href=\"/finance?cid=983582\">Dow","<font color=blue>Dow</font>");
            string cleanhtmlIndex4 = cleanhtmlIndex3.Replace("<img id=indexDot1 class=hsprite src=\"/finance/images/cleardot.gif\" width=10 height=10>&nbsp;<a href=\"/finance?cid=13756934\">Nasdaq", "<font color=red>Nasdaq</font>");
            string cleanhtmlIndex5 = cleanhtmlIndex4.Replace("<img id=indexDot2 class=hsprite src=\"/finance/images/cleardot.gif\" width=10 height=10>&nbsp;<a href=\"/finance?cid=626307\">S&P&nbsp;500", "<font color=orange>S&P&nbsp;500</font>");
            return headerStr + cleanhtmlIndex5 + footerStr;
        } // end GetQuotesIndex


    } //Class PriceEarning
} //namespace
