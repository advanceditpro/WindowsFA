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
    public partial class FormFA : Form
    {
        protected String formTitle = "";
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        TVM tvm = new TVM();
        Boolean xmlHasChanged = false;
        string xmlFilename = "";
        string xmloutput="";
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
        public FormFA()
        {
            InitializeComponent();
            this.Text = formTitle;
        }

        private void FormFA_Load(object sender, EventArgs e)
        {


//            toolTip.IsBalloon = true;
        }
        public void setformTitle(String s){
            this.formTitle=s;
        }


        private void ShowNewForm_TVM(object sender, EventArgs e)
        {
            tVMToolStripMenuItem_Click(sender, e);
        }
        private void ShowNewForm_CFLO(object sender, EventArgs e)
        {
            cFLOToolStripMenuItem_Click(sender, e);
        }
        private void ShowNewForm_TVMMortgage(object sender, EventArgs e)
        {
            tVMMortgageToolStripMenuItem_Click(sender, e);
        }

        public virtual void SaveXml(bool confirm)
        {
            if (xmlHasChanged)
            {
                if (confirm)
                {
                    if (MessageBox.Show("Do you want to save the changes you made to your worksheet?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
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
                            </TVM>
                        </FA>                       
                        */
                        // Write XML data.
                        //beginning of TVM specific code
                        /*
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
                        writer.WriteEndElement(); //TVM
                        writer.WriteEndElement(); //FA
                        writer.Flush();
                        */
                        //end of TVM specific code
                    }
                    xmloutput = stringb.ToString();
                    sw.WriteLine(xmloutput);
                }
                this.Text = formTitle + " - " + xmlFilename;
                xmlHasChanged = false;
            }

        }
        public virtual void OpenFile(object sender, EventArgs e)
        {
            SaveXml(true);
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
                    //beginning of TVM specific code
                    /*
                    XmlNodeList fa_tvm_n = doc.GetElementsByTagName("N");
                    XmlNodeList fa_tvm_pv = doc.GetElementsByTagName("PV");
                    XmlNodeList fa_tvm_pmt = doc.GetElementsByTagName("PMT");
                    XmlNodeList fa_tvm_fv = doc.GetElementsByTagName("FV");
                    XmlNodeList fa_tvm_i = doc.GetElementsByTagName("I");
                    XmlNodeList fa_tvm_p = doc.GetElementsByTagName("P");
     
                    textBoxN.Text = fa_tvm_n[0].InnerText;
                    XmlAttribute isYearatt = doc.GetElementsByTagName("N")[0].Attributes[0];
                    if (isYearatt.InnerText == "true")
                    {
                        radioButtonYears.Checked = true;
                        radioButtonPeriods.Checked = false;
                    }
                    else
                    {
                        radioButtonPeriods.Checked = true;
                        radioButtonYears.Checked = false;
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
                        </TVM>
                    </FA>
                     * */
                    //end of TVM specific code
                    this.Text = formTitle + " - " + xmlFilename;
                    xmlHasChanged = false;
                }
                catch (XmlException)
                {
                    MessageBox.Show("Invalid file.\nThe file you have opened is not valid for this application.", "Invalid file");
                }
            }
        }

        public virtual void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveXml(false);
        }

        public virtual void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlFilename = "";
            xmlHasChanged = true;
            SaveXml(false);
        }

        public virtual void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xmlHasChanged)
            {
                SaveXml(true);
            }
            Application.Exit();
        }


        void undoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            throw new System.Exception("The method or operation is not implemented.");
        }

        void redoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            throw new System.Exception("The method or operation is not implemented.");
        }
        
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
            Clipboard.Clear();
            Clipboard.SetText(this.ActiveControl.Text);
            this.ActiveControl.Text = "";
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
            Clipboard.Clear();
            Clipboard.SetText(this.ActiveControl.Text);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
            this.ActiveControl.Text = Clipboard.GetText();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void tVMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new FormTVM();
            // Make it a child of this MDI form before showing it.
//            childForm.MdiParent = this;
//            childForm.Text = "Time Value of Money " + childFormNumber++;
            childForm.Show();
        }

        private void cFLOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new FormCFLO();
            // Make it a child of this MDI form before showing it.
//            childForm.MdiParent = this;
//            childForm.Text = "Cash Flow " + childFormNumber++;
            childForm.Show();

        }
        private void tVMMortgageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new FormTVMMortgage();
            // Make it a child of this MDI form before showing it.
//            childForm.MdiParent = this;
//            childForm.Text = "Mortgage Payment Calculator " + childFormNumber++;
            childForm.Show();

        }

        private void peToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new FormPE();
            // Make it a child of this MDI form before showing it.
            //            childForm.MdiParent = this;
            //            childForm.Text = "Cash Flow " + childFormNumber++;
            childForm.Show();

        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new AboutBox1();
            aboutForm.Show();
        }
        private void changeOpacityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            double opacity = Convert.ToDouble(menuItem.Tag.ToString());
            this.Opacity = opacity;

            // The Opacity settings are exclusive of each other. Ensure only the current 
            // setting is checked.
            ToolStripMenuItem menuChangeOpacity = (ToolStripMenuItem)viewMenu.DropDownItems[2];
            foreach (ToolStripMenuItem item in menuChangeOpacity.DropDownItems)
            {
                item.Checked = false;
            }
            menuItem.Checked = true;

        }

        public virtual void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveXml(false);
        }

        private void newToolStripButtonPE_Click(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new FormPE();
            // Make it a child of this MDI form before showing it.
            //            childForm.MdiParent = this;
            //            childForm.Text = "Cash Flow " + childFormNumber++;
            childForm.Show();

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new FormOptions();
            // Make it a child of this MDI form before showing it.
            //            childForm.MdiParent = this;
            //            childForm.Text = "Cash Flow " + childFormNumber++;
            childForm.Show();

        }


    }
}