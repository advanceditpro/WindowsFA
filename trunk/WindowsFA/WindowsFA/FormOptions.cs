using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFA
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
            LoadXml();
        } //constructor

        private void SaveXml()
        {
            /*
             * <Configuration>
               <StartupFormIndex>1</StartupFormIndex>
               <InetConnectionIndex>1</InetConnectionIndex>
               <ProxyURL></ProxyURL>
               <QuoteSourceIndex>0</QuoteSourceIndex>
               <TVMOptionalInfo>0</TVMOptionalInfo>
               </Configuration>
             */
            // Create a new configuration object
            // and initialize some variables
//            for (int i = 0; i < groupBoxStartup.Controls.Count; i++)
            {
//                if (groupBoxStartup.Controls[i].Checked())
                if (radioButton1.Checked)
                {
                    Program.cApp.StartupFormIndex = 0;
                }
                if (radioButton2.Checked)
                {
                    Program.cApp.StartupFormIndex = 1;
                }
                if (radioButton3.Checked)
                {
                    Program.cApp.StartupFormIndex = 2;
                }
            }
//            for (int i = 0; i < groupBoxProxy.Controls.Count; i++)
            {
//                if (groupBoxProxy.Controls[i].Checked())
                if (radioButtonDirect.Checked)
                {
                    Program.cApp.InetConnectionIndex = 0;
                }
                if (radioButtonProxy.Checked)
                {
                    Program.cApp.InetConnectionIndex = 1;
                }
            }
            Program.cApp.ProxyURL = maskedTextBoxURL.Text;
            if (radioButtonYahoo.Checked)
            {
                Program.cApp.QuoteSourceIndex = 0;
            }
            if (radioButtonGoogle.Checked)
            {
                Program.cApp.QuoteSourceIndex = 1;
            }

            // Serialize the configuration object to a file
            Configuration.Serialize("config.xml", Program.cApp);
        }

        private void LoadXml()
        {
            /*
             * <Configuration>
               <StartupFormIndex>1</StartupFormIndex>
               <InetConnectionIndex>1</InetConnectionIndex>
               <ProxyURL></ProxyURL>
               <QuoteSourceIndex>0</QuoteSourceIndex>
               <TVMOptionalInfo>0</TVMOptionalInfo>
               </Configuration>
             */
            try
            {
                // Read the configuration object from a file

                // Write out the variables read from the file
                //groupBoxStartup.Controls[(c2.StartupFormIndex)].Select();
                if (Program.cApp.StartupFormIndex == 0)
                {
                    radioButton1.Select();
                }
                if (Program.cApp.StartupFormIndex == 1)
                {
                    radioButton2.Select();
                }
                if (Program.cApp.StartupFormIndex == 2)
                {
                    radioButton3.Select();
                }
                //groupBoxProxy.Controls[(c2.InetConnectionIndex)].Select();
                if (Program.cApp.InetConnectionIndex == 0)
                {
                    radioButtonDirect.Select();
                    maskedTextBoxURL.Enabled = false;
                }
                if (Program.cApp.InetConnectionIndex == 1)
                {
                    radioButtonProxy.Select();
                    maskedTextBoxURL.Enabled = true;
                }
                maskedTextBoxURL.Text = (Program.cApp.ProxyURL);
                if (Program.cApp.QuoteSourceIndex == 0)
                {
                    radioButtonYahoo.Select();
                }
                if (Program.cApp.QuoteSourceIndex == 1)
                {
                    radioButtonGoogle.Select();
                }

            }
            catch (System.IO.FileNotFoundException)
            {
                SaveXml();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SaveXml();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonDirect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDirect.Checked)
            {
                maskedTextBoxURL.Enabled = false;
            }
            else
            {
                maskedTextBoxURL.Enabled = true;
            }
        }

        private void radioButtonProxy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonProxy.Checked)
            {
                maskedTextBoxURL.Enabled = true;
            }
            else
            {
                maskedTextBoxURL.Enabled = false;
            }

        }
    } //FormOptions
} //namespace