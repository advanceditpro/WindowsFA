using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Xml;

namespace WindowsFA
{
    public partial class FormCFLO : FormFA
    {
        static int MAXC = 20;
        private CashFlow cf = new CashFlow(MAXC);
        private System.Windows.Forms.Panel[] panel = new Panel[MAXC];
        private System.Windows.Forms.Panel[] cfi = new Panel[MAXC];
        private System.Windows.Forms.Label[] label = new Label[MAXC];
        private System.Windows.Forms.MaskedTextBox[] nj = new MaskedTextBox[MAXC];
        private System.Windows.Forms.MaskedTextBox[] cj = new MaskedTextBox[MAXC];
//        Microsoft.VisualBasic.DueDate duedate = Microsoft.VisualBasic.DueDate.EndOfPeriod;
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        Boolean xmlHasChanged = false;
        string xmlFilename = "";
        string xmloutput = "";
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;


        public FormCFLO()
        {
            InitializeComponent();
            #region Manually Initialize Components
            // 

            for (int i = 0; i < MAXC; i++)
            {
                label[i] = new System.Windows.Forms.Label();
                label[i].AutoSize = true;
                label[i].Location = new System.Drawing.Point(3, 11);
                label[i].Name = "label" + i.ToString();
                label[i].Size = new System.Drawing.Size(52, 13);
                label[i].TabIndex = 0;
                label[i].Text = "Period " + i.ToString();
                if (i == 0)
                {
                    label[i].Text = "Initial " + i.ToString();
                }
                // 
                cj[i] = new System.Windows.Forms.MaskedTextBox();
                cj[i].Location = new System.Drawing.Point(61, 8);
                cj[i].Name = "cj" + i.ToString();
                cj[i].Size = new System.Drawing.Size(100, 20);
                cj[i].Text = "0.0";
                cj[i].TabIndex = 1;
                cj[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                // 
                nj[i] = new System.Windows.Forms.MaskedTextBox();
                nj[i].Location = new System.Drawing.Point(168, 8);
                nj[i].Name = "nj" + i.ToString();
                nj[i].Size = new System.Drawing.Size(42, 20);
                nj[i].Text = "1";
                nj[i].TabIndex = 2;
                nj[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                if (i == 0)
                {
                    nj[i].ReadOnly = true;
                }
                // 
                panel[i] = new System.Windows.Forms.Panel();
                panel[i].Location = new System.Drawing.Point(3, 3);
                panel[i].Name = "panel" + i.ToString();
                panel[i].Size = new System.Drawing.Size(271, 24);
                panel[i].TabIndex = 1;
                panel[i].Controls.Add(label[i]);
                panel[i].Controls.Add(cj[i]);
                panel[i].Controls.Add(nj[i]);
                panel[i].SuspendLayout();
                panel[i].ResumeLayout(false);
                panel[i].PerformLayout();
                // 
                leftcentr2.Controls.Add(panel[i]);
                cfi[i] = new System.Windows.Forms.Panel();
                cfi[i] = panel[i];
            }
            setformTitle("Uneven Cashflow Calculator");
            this.Text = formTitle;
            #endregion
        }

        private void FormCFLO_Load(object sender, EventArgs e)
        {

        }

        private void recalc()
        {
            try
            {
                MaskedTextBox tf = (MaskedTextBox)cfi[0].Controls[1];
                Double dc0 = (Double.Parse(tf.Text));
                CFData d1 = new CFData(dc0, 1.0);
                cf.setCFData(d1, 0);
                for (int cj = 1; cj < cfi.Length; ++cj)
                {
                    System.Windows.Forms.Panel c1 = (Panel)(cfi[cj]);
                    MaskedTextBox tf1 = (MaskedTextBox)c1.Controls[1];
                    Double dc1 = (Double.Parse(tf1.Text));
                    MaskedTextBox tf2 = (MaskedTextBox)c1.Controls[2];
                    Double dc2 = (Double.Parse(tf2.Text));
                    CFData d2 = new CFData(dc1, dc2);
                    cf.setCFData(d2, cj);
                }
                cf.setSafeI(Double.Parse(S.Text) / 100.0);
                S.Text = (cf.getSafeI() * 100.0).ToString("N", nfi);
                cf.setRiskI(Double.Parse(R.Text) / 100.0);
                R.Text = (cf.getRiskI() * 100.0).ToString("N", nfi);
                double dnpv1 = cf.getNPV();
                npvchar.Text = Math.Round(dnpv1, 2).ToString("C", nfi);
                double dmirr1 = cf.getMIRR() * 100.0;
                mirrchar.Text = Math.Round(dmirr1, 2).ToString() + "%";
                try {
                    double dirr1 = cf.getIRR() * 100.0;
                    irrchar.Text = Math.Round(dirr1, 2).ToString() + "%";
                } catch (ArgumentException){
                    irrchar.Text = "No Solution";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("One or more cash flow contains invalid character.\nCheck the cash flows entered before continuing.", "Input Error");
            }
            xmlHasChanged = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            recalc();
        }

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
                    mainSaveFileDialog.Filter = "CFLO Files (*.cfo)|*.cfo|TVM Files (*.tvm)|*.tvm|All Files (*.*)|*.*";
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
                            <CFLO>
                                <SafeI>5.00</SafeI>
                                <RiskI>10.00</RiskI>
                                <CF id="0">
                                    <C>-100000</C>
                                    <N>1</N>
                                </CF>
                                <CF id="1">
                                    <C>100000</C>
                                    <N>5</N>
                                </CF>
                                <CF id="2">
                                    <C>-100000</C>
                                    <N>5</N>
                                </CF>
                            </CFLO>
                        </FA>                       
                        */
                        // Write XML data.
                        writer.WriteStartElement("FA");
                        writer.WriteStartElement("CFLO");
                        writer.WriteStartElement("SafeI");
                        writer.WriteString(S.Text);
                        writer.WriteEndElement();
                        writer.WriteStartElement("RiskI");
                        writer.WriteString(R.Text);
                        writer.WriteEndElement();
                        for (int i = 0; i < MAXC; i++)
                        {
                            writer.WriteStartElement("CF");
                            writer.WriteAttributeString("id", i.ToString());
                            writer.WriteStartElement("C");
                            writer.WriteString(cj[i].Text);
                            writer.WriteEndElement();
                            writer.WriteStartElement("N");
                            writer.WriteString(nj[i].Text);
                            writer.WriteEndElement();
                            writer.WriteEndElement(); //CF
                        }
                        writer.WriteEndElement(); //CFLO
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
            openFileDialog.Filter = "CFLO Files (*.cfo)|*.cfo|TVM Files (*.tvm)|*.tvm|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    xmlFilename = openFileDialog.FileName;
                    xmlHasChanged = true;
                    doc.Load(xmlFilename);
                    XmlNode root = doc.DocumentElement;
                    XmlNodeList fa_cflo_safei = doc.GetElementsByTagName("SafeI");
                    XmlNodeList fa_cflo_riski = doc.GetElementsByTagName("RiskI");
                    XmlNodeList fa_cflo_cf = doc.GetElementsByTagName("CF");
                    S.Text = fa_cflo_safei[0].InnerText;
                    R.Text = fa_cflo_riski[0].InnerText;
                    for (int i=0; i<MAXC; i++){
                        cj[i].Text = doc.GetElementsByTagName("C")[i].InnerText;
                        nj[i].Text = doc.GetElementsByTagName("N")[i].InnerText;
                    }
                    recalc();
                    /*
                     * Sample document
                     * 
                    <?xml version="1.0" encoding="utf-16"?>
                    <FA>
                        <CFLO>
                            <SafeI>5.00</SafeI>
                            <RiskI>10.00</RiskI>
                            <CF id="0">
                                <C>-100000</C>
                                <N>1</N>
                            </CF>
                            <CF id="1">
                                <C>100000</C>
                                <N>5</N>
                            </CF>
                            <CF id="2">
                                <C>-100000</C>
                                <N>5</N>
                            </CF>
                        </CFLO>
                    </FA>                       
                    */
                    this.Text = formTitle + " - " + xmlFilename;
                    xmlHasChanged = false;
                }
                catch (XmlException)
                {
                    MessageBox.Show("Invalid file.\nThe file you have opened is not valid for this application.", "Invalid file");
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


    }
}