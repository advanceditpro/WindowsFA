using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFA
{
    public partial class FormTVMMortgage : WindowsFA.FormTVM
    {
        public FormTVMMortgage()
        {
            InitializeComponent();
            setformTitle("Loan and Mortgage Calculator - FA");
            this.Text = formTitle;
            // 
            // labelHeading
            // 
            this.labelHeading.Text = "Loan and Mortgage Calculator";
            // 
            // lblN
            // 
            this.lblN.Text = "Loan period in years or periods";
            // 
            // lblPV
            // 
            this.lblPV.Text = "Loan Amount";
            // 
            // lblPMT
            // 
            this.lblPMT.Text = "Scheduled payment";
            // 
            // lblFV
            // 
            this.lblFV.Text = "Ending amount";
            // 
            // lblI
            // 
            this.lblI.Text = "Annual interest rate";
            // 
            // lblP
            // 
            this.lblP.Text = "Number of payments per year";
        }
    }
}

