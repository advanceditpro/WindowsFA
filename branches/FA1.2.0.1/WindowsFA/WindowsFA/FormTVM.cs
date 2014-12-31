using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Specialized;
using System.IO;
using System.Xml;

namespace WindowsFA
{
    public partial class FormTVM : WindowsFA.FormFA
    {
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        TVM tvm = new TVM();
        Boolean isYear = true;
        Boolean isEnd = true;
        Boolean xmlHasChanged = false;
        string xmlFilename = "";
        string xmloutput="";
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
        public FormTVM()
        {
            InitializeComponent();
            setformTitle("Time Value of Money Calculator");
            this.Text = formTitle;
        }

        private void FormTVM_Load(object sender, EventArgs e)
        {
            textBoxN.Text = (isYear) ? (tvm.getN() / tvm.getP()).ToString("N", nfi) : tvm.getN().ToString("N", nfi);
            //            textBoxPMT.Text = tvm.getPMT().ToString();
            //            textBoxI.Text = tvm.getI().ToString();
            //            textBoxFV.Text = tvm.getFV().ToString();
            textBoxPV.FormatProvider = nfi;
            textBoxP.Text = tvm.getP().ToString();

//            textBoxN.ValidatingType = typeof(System.Int16);
//            textBoxN.TypeValidationCompleted += new TypeValidationEventHandler(textBoxN_TypeValidationCompleted);
            fromtovalue();
//            toolTip.IsBalloon = true;
        }
        private void recalc(TVMObjects tf)
        {

            //if (tvm.getCalculating() != TVMObjects.OPEN)
            //{
            //    xmlHasChanged = true;
            //}
            if (tvm.getCalculating() != TVMObjects.P)
            {
                tvm.setP(Double.Parse(textBoxP.Text.ToString()));
            }
            if (tvm.getCalculating() != TVMObjects.I)
            {
                tvm.setI(Double.Parse(textBoxI.Text.ToString()) / 100);
            }
            if (tvm.getCalculating() != TVMObjects.N)
            {
                try
                {
                    double tempN = (isYear) ? Double.Parse(textBoxN.Text.ToString()) * Double.Parse(textBoxP.Text.ToString()) : Double.Parse(textBoxN.Text.ToString());
                    tvm.setN(tempN);
                }
                catch (FormatException)
                {
                    textBoxN.Text = (isYear) ? (tvm.getN() / tvm.getP()).ToString("N", nfi) : tvm.getN().ToString("N", nfi);
                }
            }
            if (tvm.getCalculating() != TVMObjects.FV)
            {
                tvm.setFV(Double.Parse(textBoxFV.Text.ToString(), NumberStyles.Currency));
            }
            if (tvm.getCalculating() != TVMObjects.PV)
            {
                tvm.setPV(Double.Parse(textBoxPV.Text.ToString(), NumberStyles.Currency));
            }
            if (tvm.getCalculating() != TVMObjects.PMT)
            {
                try
                {
                    tvm.setPMT(Double.Parse(textBoxPMT.Text.ToString(), NumberStyles.Currency) * -1.0);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format.");
                }
            }
            if (tf == TVMObjects.PV)
            {
                textBoxPV.Text = Math.Round(tvm.getPV("solve"), 2).ToString("C", nfi);

            }
            if (tf == TVMObjects.PMT)
            {
                textBoxPMT.Text = Math.Round(tvm.getPMT("solve") * -1.0, 2).ToString("C", nfi);
            }
            if (tf == TVMObjects.FV)
            {
                textBoxFV.Text = Math.Round(tvm.getFV("solve"), 2).ToString("C", nfi);
            }
            if (tf == TVMObjects.N)
                try
                {
                    textBoxN.Text = (isYear) ? (tvm.getN("solve") / tvm.getP()).ToString("N", nfi) : tvm.getN("solve").ToString("N", nfi);
                }
                catch (ArgumentException)
                {
                    textBoxN.Text = (isYear) ? (tvm.getN() / tvm.getP()).ToString("N", nfi) : tvm.getN().ToString("N", nfi);
                    Console.WriteLine("FormTVM: Invalid argument during N calculation.");
                }
            if (tf == TVMObjects.I)
                try
                {
                    textBoxI.Text = Math.Round(tvm.getI("solve") * 100.0, 2).ToString("N", nfi);
                }
                catch (ArgumentException)
                {
                    textBoxI.Text = Math.Round(tvm.getI() * 100.0, 2).ToString("N", nfi);
                    Console.WriteLine("FormTVM: Invalid argument during I calculation.");
                }
            amortize();
            xmlHasChanged = true;
        }

        private void amortize()
        {
            float totalIPMT = 0.0f;
            float totalPPMT = 0.0f;
            float grandtotalIPMT = 0.0f;
            float grandtotalPPMT = 0.0f;
            fromtovalue();
//            float singlePPMT = tvm.getPPMT(1);
            int toTrueValue = isYear ? (Int32)numericUpDownTo.Value * (Int32)tvm.getP() : (Int32)numericUpDownTo.Value ;
            int fromTrueValue = isYear ? (Int32)numericUpDownFrom.Value * (Int32)tvm.getP() : (Int32)numericUpDownFrom.Value;
            for (int i = fromTrueValue; i <= toTrueValue; i++)
            {
                totalIPMT += tvm.getIPMT(i);
                totalPPMT += tvm.getPPMT(i);
            }
            for (int i = 1; i <= toTrueValue; i++)
            {
                grandtotalIPMT += tvm.getIPMT(i);
                grandtotalPPMT += tvm.getPPMT(i);
            }
            maskedTextBoxInterest.Text = Math.Round(Math.Abs(totalIPMT), 2).ToString("C", nfi);
            maskedTextBoxPrincipal.Text = Math.Round(Math.Abs(totalPPMT), 2).ToString("C", nfi);
            maskedTextBoxBalance.Text = Math.Round((decimal)tvm.getPV()+((decimal)grandtotalPPMT), 2).ToString("C", nfi);
        }

        private void buttonPV_Click(object sender, EventArgs e)
        {
            try
            {
                tvm.setCalculating(TVMObjects.PV);
                recalc(TVMObjects.PV);
                recalc(TVMObjects.FV);
                recalc(TVMObjects.N);
                recalc(TVMObjects.I);
                recalc(TVMObjects.PMT);
            }
            catch (FormatException)
            {
                MessageBox.Show("One or more values contain invalid characters.\nCheck the cash flows entered before continuing.", "Input Error");
            }

        }
        private void buttonPMT_Click(object sender, EventArgs e)
        {
            try
            {
                tvm.setCalculating(TVMObjects.PMT);
                recalc(TVMObjects.PMT);
                recalc(TVMObjects.PV);
                recalc(TVMObjects.FV);
                recalc(TVMObjects.N);
                recalc(TVMObjects.I);
            }
            catch (FormatException)
            {
                MessageBox.Show("One or more values contain invalid characters.\nCheck the cash flows entered before continuing.", "Input Error");
            }
        }

        private void buttonFV_Click(object sender, EventArgs e)
        {
            try
            {
                tvm.setCalculating(TVMObjects.FV);
                recalc(TVMObjects.FV);
                recalc(TVMObjects.PV);
                recalc(TVMObjects.N);
                recalc(TVMObjects.I);
                recalc(TVMObjects.PMT);
            }
            catch (FormatException)
            {
                MessageBox.Show("One or more values contain invalid characters.\nCheck the cash flows entered before continuing.", "Input Error");
            }
        }

        private void radioButtonEnd_CheckedChanged(object sender, EventArgs e)
        {
            xmlHasChanged = true;
            if (this.radioButtonEnd.Checked)
            {
                tvm.setS(0.0);
                isEnd = true;
            }
            else
            {
                tvm.setS(1.0);
                isEnd = false;
            }
        }

        private void radioButtonBegin_CheckedChanged(object sender, EventArgs e)
        {
            xmlHasChanged = true;
            if (this.radioButtonBegin.Checked)
            {
                tvm.setS(1.0);
                isEnd = false;
            }
            else
            {
                tvm.setS(0.0);
                isEnd = true;
            }
        }
        private void radioButtonYears_CheckedChanged(object sender, EventArgs e)
        {
            xmlHasChanged = true;
            if (this.radioButtonYears.Checked)
            {
                isYear = true;
                textBoxN.Text = (isYear) ? (tvm.getN() / tvm.getP()).ToString("N", nfi) : tvm.getN().ToString("N", nfi);
            }
            else
            {
                isYear = false;
                textBoxN.Text = (isYear) ? (tvm.getN() / tvm.getP()).ToString("N", nfi) : tvm.getN().ToString("N", nfi);
            }
        }
        private void radioButtonPeriods_CheckedChanged(object sender, EventArgs e)
        {
            xmlHasChanged = true;
            if (this.radioButtonPeriods.Checked)
            {
                isYear = false;
                textBoxN.Items.Clear();
                this.textBoxN.Items.AddRange(new object[] {
                    "12",
                    "24",
                    "36",
                    "48",
                    "180",
                    "360"});
                textBoxN.Text = (isYear) ? (tvm.getN() / tvm.getP()).ToString("N", nfi) : tvm.getN().ToString("N", nfi);
            }
            else
            {
                isYear = true;
                textBoxN.Items.Clear();
                this.textBoxN.Items.AddRange(new object[] {
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "7",
                    "10",
                    "12",
                    "15",
                    "20",
                    "25",
                    "30",
                    "40",
                    "50",
                    "99"});
                textBoxN.Text = (isYear) ? (tvm.getN() / tvm.getP()).ToString("N", nfi) : tvm.getN().ToString("N", nfi);
            }
            amortize();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            try {
                tvm.setCalculating(TVMObjects.N);
                recalc(TVMObjects.N);
                recalc(TVMObjects.FV);
                recalc(TVMObjects.PV);
                recalc(TVMObjects.I);
                recalc(TVMObjects.PMT);
            }
            catch (FormatException)
            {
                MessageBox.Show("One or more values contain invalid characters.\nCheck the cash flows entered before continuing.", "Input Error");
            }
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            try {
                tvm.setCalculating(TVMObjects.I);
                recalc(TVMObjects.I);
                recalc(TVMObjects.FV);
                recalc(TVMObjects.N);
                recalc(TVMObjects.PV);
                recalc(TVMObjects.PMT);
            }
            catch (FormatException)
            {
                MessageBox.Show("One or more values contain invalid characters.\nCheck the cash flows entered before continuing.", "Input Error");
            }
        }
        void textBoxN_SelectionChangeCommitted(object sender, EventArgs e)
        {
            xmlHasChanged = true;
            double tempN = (isYear) ? Double.Parse(textBoxN.Text.ToString()) * Double.Parse(textBoxP.Text.ToString()) : Double.Parse(textBoxN.Text.ToString());
            tvm.setN(tempN);
            fromtovalue();
        }
        //void textBoxN_KeyDown(object sender, KeyEventArgs e)
        //{
        //    toolTip.Hide(textBoxN);
        //}
        //void textBoxN_MouseHover(object sender, EventArgs e)
        //{
        //    //            throw new Exception("The method or operation is not implemented.");
        //    toolTip.ToolTipTitle = "Number of years or periods.";
        //    toolTip.Show("Number of years or total number of periods.\nTotal number of periods = (years x periods/year)", textBoxN, textBoxN.Location.X, textBoxN.Location.Y, 5000);
        //}
        //void textBoxPV_KeyDown(object sender, KeyEventArgs e)
        //{
        //    toolTip.Hide(textBoxPV);
        //}
        //void textBoxPV_MouseHover(object sender, EventArgs e)
        //{
        //    //            throw new Exception("The method or operation is not implemented.");
        //    toolTip.ToolTipTitle = "Loan amount.";
        //    toolTip.Show("Total loan amount. Present value.", textBoxPV, textBoxPV.Location.X, textBoxPV.Location.Y, 5000);
        //}
        //void textBoxPMT_KeyDown(object sender, KeyEventArgs e)
        //{
        //    toolTip.Hide(textBoxPMT);
        //}
        //void textBoxPMT_MouseHover(object sender, EventArgs e)
        //{
        //    //            throw new Exception("The method or operation is not implemented.");
        //    toolTip.ToolTipTitle = "Periodic payment amount.";
        //    toolTip.Show("This is the scheduled periodic payment amount.\nThis is a negative number if you are making payments.", textBoxPMT, textBoxPMT.Location.X, textBoxPV.Location.Y, 5000);
        //}
        //void textBoxFV_KeyDown(object sender, KeyEventArgs e)
        //{
        //    toolTip.Hide(textBoxFV);
        //}
        //void textBoxFV_MouseHover(object sender, EventArgs e)
        //{
        //    //            throw new Exception("The method or operation is not implemented.");
        //    toolTip.ToolTipTitle = "Ending loan balance.";
        //    toolTip.Show("This is the ending balance of the loan.\nUsually you want to leave it at $0.00.", textBoxFV, textBoxFV.Location.X, textBoxPV.Location.Y, 5000);
        //}

        public override void SaveXml(bool confirm)
        {
            if (xmlHasChanged)
            {
                if (confirm)
                {
                    if (MessageBox.Show("Do you want to save the changes you made to your worksheet?", "Finance Advisor Calculator - Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                }
                if (xmlFilename == "")
                {
                    mainSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    mainSaveFileDialog.Filter = "TVM Files (*.tvm)|*.tvm|CFLO Files (*.cfo)|*.cfo|All Files (*.*)|*.*";
                    if (mainSaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        xmlFilename = mainSaveFileDialog.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
                using (StreamWriter sw = new StreamWriter(xmlFilename, false, Encoding.Unicode))
                {
                    StringBuilder stringb = new StringBuilder();
                    XmlWriterSettingsLibrary settings = new XmlWriterSettingsLibrary();
                    using (XmlWriter writer = XmlWriter.Create(stringb, settings.maindocxmlsettings))
                    {
                        /*
                         * Sample document
                         * 
                        <?xml version="1.0" encoding="utf-16"?>
                        <FA>
                            <TVM>
                                <N isYear="true">30.00</N>
                                <PV>$600,000.00</PV>
                                <PMT>($3,597.30)</PMT>
                                <FV>$0.00</FV>
                                <I>6.00</I>
                                <P isEnd="true">12</P>
                                <FROM>1</FROM>
                                <TO>12</TO>
                            </TVM>
                        </FA>                       
                        */
                        // Write XML data.
                        writer.WriteStartElement("FA");
                        writer.WriteStartElement("TVM");
                        writer.WriteStartElement("N");
                        string isYearstring = isYear ? "true" : "false";
                        writer.WriteAttributeString("isYear", isYearstring);
                        writer.WriteString(textBoxN.Text);
                        writer.WriteEndElement();
                        writer.WriteStartElement("PV");
                        writer.WriteString(textBoxPV.Text);
                        writer.WriteEndElement();
                        writer.WriteStartElement("PMT");
                        writer.WriteString(textBoxPMT.Text);
                        writer.WriteEndElement();
                        writer.WriteStartElement("FV");
                        writer.WriteString(textBoxFV.Text);
                        writer.WriteEndElement();
                        writer.WriteStartElement("I");
                        writer.WriteString(textBoxI.Text);
                        writer.WriteEndElement();
                        writer.WriteStartElement("P");
                        string isEndstring = isEnd ? "true" : "false";
                        writer.WriteAttributeString("isEnd", isEndstring);
                        writer.WriteString(textBoxP.Text);
                        writer.WriteEndElement();
                        writer.WriteStartElement("FROM");
                        writer.WriteString(numericUpDownFrom.Value.ToString());
                        writer.WriteEndElement();
                        writer.WriteStartElement("TO");
                        writer.WriteString(numericUpDownTo.Value.ToString());
                        writer.WriteEndElement();
                        writer.WriteEndElement(); //TVM
                        writer.WriteEndElement(); //FA
                        writer.Flush();
                    }
                    xmloutput = stringb.ToString();
                    sw.WriteLine(xmloutput);
                }
                this.Text = formTitle + " - " + xmlFilename;
                xmlHasChanged = false;
            }

        }
        public override void OpenFile(object sender, EventArgs e) 
        {
            if (xmlHasChanged)
            {
                SaveXml(true);
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "TVM Files (*.tvm)|*.tvm|CFLO Files (*.cfo)|*.cfo|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    xmlFilename = openFileDialog.FileName;
                    xmlHasChanged = true;
                    doc.Load(xmlFilename);
                    XmlNode root = doc.DocumentElement;
                    XmlNodeList fa_tvm_n = doc.GetElementsByTagName("N");
                    XmlNodeList fa_tvm_pv = doc.GetElementsByTagName("PV");
                    XmlNodeList fa_tvm_pmt = doc.GetElementsByTagName("PMT");
                    XmlNodeList fa_tvm_fv = doc.GetElementsByTagName("FV");
                    XmlNodeList fa_tvm_i = doc.GetElementsByTagName("I");
                    XmlNodeList fa_tvm_p = doc.GetElementsByTagName("P");
                    XmlNodeList fa_tvm_from = doc.GetElementsByTagName("FROM");
                    XmlNodeList fa_tvm_to = doc.GetElementsByTagName("TO");

                    textBoxN.Text = fa_tvm_n[0].InnerText;
                    XmlAttribute isYearatt = doc.GetElementsByTagName("N")[0].Attributes[0];
                    if (isYearatt.InnerText == "true")
                    {
                        radioButtonYears.Checked = true;
                        radioButtonPeriods.Checked = false;
                        isYear = true;
                    }
                    else
                    {
                        radioButtonPeriods.Checked = true;
                        radioButtonYears.Checked = false;
                        isYear = false;
                    }
                    textBoxPV.Text = fa_tvm_pv[0].InnerText;
                    textBoxPMT.Text = fa_tvm_pmt[0].InnerText;
                    textBoxFV.Text = fa_tvm_fv[0].InnerText;
                    textBoxI.Text = fa_tvm_i[0].InnerText;
                    textBoxP.Text = fa_tvm_p[0].InnerText;
                    XmlAttribute isEndatt = doc.GetElementsByTagName("P")[0].Attributes[0];
                    if (isEndatt.InnerText == "true")
                    {
                        radioButtonEnd.Checked = true;
                        radioButtonBegin.Checked = false;
                    }
                    else
                    {
                        radioButtonBegin.Checked = true;
                        radioButtonEnd.Checked = false;
                    }
                    // * IMPORTANT * must set the To value before From value
                    //   because of event handler checking for correct From to To value
                    numericUpDownTo.Value = decimal.Parse(fa_tvm_to[0].InnerText);
                    numericUpDownFrom.Value = decimal.Parse(fa_tvm_from[0].InnerText);
                    tvm.setCalculating(TVMObjects.OPEN);
                    recalc(TVMObjects.OPEN);
                    /*
                     * Sample tvm file for loading
                     * 
                    <?xml version="1.0" encoding="utf-16"?>
                    <FA>
                        <TVM>
                            <N isYear="true">30.00</N>
                            <PV>$300,000.00</PV>
                            <PMT>($1,798.65)</PMT>
                            <FV>$0.00</FV>
                            <I>6.00</I>
                            <P isEnd="true">12</P>
                            <FROM>1</FROM>
                            <TO>12</TO>
                        </TVM>
                    </FA>
                     * */
                    this.Text = formTitle + " - " + xmlFilename;
                    xmlHasChanged = false;
                }
                catch (XmlException)
                {
                    MessageBox.Show("Invalid file.\nThe file you have opened is not valid for this application.", "Invalid file");
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Incomplete file.\nThe file you have opened is not valid for this application.", "Invalid file");
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Value is out of range.\nThe file you have opened is not valid for this application.", "Invalid file");
                }

            }
        }

        public override void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveXml(false);
        }

        public override void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlFilename = "";
            xmlHasChanged = true;
            SaveXml(false);
        }

        public override void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xmlHasChanged)
            {
                SaveXml(true);
            }
            Application.Exit();
        }

        private void fromtovalue()
        {
            // * IMPORTANT * must set the To value before From value
            //   because of event handler checking for correct From to To value
            numericUpDownTo.Maximum = (isYear) ? (decimal)(tvm.getN() / tvm.getP()) : (decimal)(tvm.getN());
            numericUpDownFrom.Maximum = (isYear) ? (decimal)(tvm.getN() / tvm.getP()) : (decimal)(tvm.getN());
            if (numericUpDownFrom.Value.Equals(1.0) && isYear)
            {
                numericUpDownFrom.Value = 0.0m;
            }
            if (numericUpDownTo.Value < numericUpDownFrom.Value)
            {
                numericUpDownTo.Value = numericUpDownFrom.Value;
            }
            if (numericUpDownFrom.Value > numericUpDownTo.Value)
            {
                numericUpDownFrom.Value = numericUpDownTo.Value;
            }
        }
        private void numericUpDownTo_ValueChanged(object sender, EventArgs e)
        {
            fromtovalue();
            amortize();
        }

        private void numericUpDownFrom_ValueChanged(object sender, EventArgs e)
        {
            fromtovalue();
            amortize();
        }

    }
}