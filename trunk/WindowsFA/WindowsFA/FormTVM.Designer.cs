using System.Windows.Forms;
using System;
namespace WindowsFA
{
    partial class FormTVM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTVM));
            this.lblN = new System.Windows.Forms.Label();
            this.lblPV = new System.Windows.Forms.Label();
            this.lblPMT = new System.Windows.Forms.Label();
            this.lblFV = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.textBoxPV = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPMT = new System.Windows.Forms.MaskedTextBox();
            this.textBoxFV = new System.Windows.Forms.MaskedTextBox();
            this.textBoxI = new System.Windows.Forms.MaskedTextBox();
            this.textBoxP = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonBegin = new System.Windows.Forms.RadioButton();
            this.radioButtonEnd = new System.Windows.Forms.RadioButton();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonPV = new System.Windows.Forms.Button();
            this.buttonPMT = new System.Windows.Forms.Button();
            this.buttonFV = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.groupBoxPP = new System.Windows.Forms.GroupBox();
            this.groupBoxPeriodType = new System.Windows.Forms.GroupBox();
            this.radioButtonPeriods = new System.Windows.Forms.RadioButton();
            this.radioButtonYears = new System.Windows.Forms.RadioButton();
            this.labelHeading = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.ComboBox();
            this.groupBoxAmort = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxBalance = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxInterest = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPrincipal = new System.Windows.Forms.MaskedTextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelInterest = new System.Windows.Forms.Label();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.numericUpDownTo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFrom = new System.Windows.Forms.NumericUpDown();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.groupBoxRequired = new System.Windows.Forms.GroupBox();
            this.groupBoxOptional = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownExpenseYear = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxTotal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownExtra = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownInsurance = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownTax = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonToggleOptionalInfo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxPP.SuspendLayout();
            this.groupBoxPeriodType.SuspendLayout();
            this.groupBoxAmort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            this.groupBoxRequired.SuspendLayout();
            this.groupBoxOptional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpenseYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(32, 34);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "N";
            // 
            // lblPV
            // 
            this.lblPV.AutoSize = true;
            this.lblPV.Location = new System.Drawing.Point(32, 83);
            this.lblPV.Name = "lblPV";
            this.lblPV.Size = new System.Drawing.Size(21, 13);
            this.lblPV.TabIndex = 1;
            this.lblPV.Text = "PV";
            // 
            // lblPMT
            // 
            this.lblPMT.AutoSize = true;
            this.lblPMT.Location = new System.Drawing.Point(32, 131);
            this.lblPMT.Name = "lblPMT";
            this.lblPMT.Size = new System.Drawing.Size(30, 13);
            this.lblPMT.TabIndex = 2;
            this.lblPMT.Text = "PMT";
            // 
            // lblFV
            // 
            this.lblFV.AutoSize = true;
            this.lblFV.Location = new System.Drawing.Point(32, 174);
            this.lblFV.Name = "lblFV";
            this.lblFV.Size = new System.Drawing.Size(20, 13);
            this.lblFV.TabIndex = 3;
            this.lblFV.Text = "FV";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(32, 221);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(26, 13);
            this.lblI.TabIndex = 4;
            this.lblI.Text = "I%R";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(36, 270);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(26, 13);
            this.lblP.TabIndex = 5;
            this.lblP.Text = "P/Y";
            // 
            // textBoxPV
            // 
            this.textBoxPV.Location = new System.Drawing.Point(196, 83);
            this.textBoxPV.Name = "textBoxPV";
            this.textBoxPV.Size = new System.Drawing.Size(117, 20);
            this.textBoxPV.TabIndex = 3;
            this.textBoxPV.Text = "$0.00";
            this.textBoxPV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPV.GotFocus += new System.EventHandler(this.textBoxPV_GotFocus);
            this.textBoxPV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPV_KeyPress);
            this.textBoxPV.MouseLeave += new System.EventHandler(this.textBoxPV_MouseLeave);
            this.textBoxPV.MouseHover += new System.EventHandler(this.textBoxPV_MouseHover);
            // 
            // textBoxPMT
            // 
            this.textBoxPMT.Location = new System.Drawing.Point(196, 130);
            this.textBoxPMT.Name = "textBoxPMT";
            this.textBoxPMT.Size = new System.Drawing.Size(117, 20);
            this.textBoxPMT.TabIndex = 5;
            this.textBoxPMT.Text = "$0.00";
            this.textBoxPMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPMT.GotFocus += new System.EventHandler(this.textBoxPMT_GotFocus);
            this.textBoxPMT.MouseLeave += new System.EventHandler(this.textBoxPMT_MouseLeave);
            this.textBoxPMT.MouseHover += new System.EventHandler(this.textBoxPMT_MouseHover);
            // 
            // textBoxFV
            // 
            this.textBoxFV.Location = new System.Drawing.Point(196, 173);
            this.textBoxFV.Name = "textBoxFV";
            this.textBoxFV.Size = new System.Drawing.Size(117, 20);
            this.textBoxFV.TabIndex = 7;
            this.textBoxFV.Text = "$0.00";
            this.textBoxFV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxFV.GotFocus += new System.EventHandler(this.textBoxFV_GotFocus);
            this.textBoxFV.MouseLeave += new System.EventHandler(this.textBoxFV_MouseLeave);
            this.textBoxFV.MouseHover += new System.EventHandler(this.textBoxFV_MouseHover);
            // 
            // textBoxI
            // 
            this.textBoxI.Location = new System.Drawing.Point(196, 220);
            this.textBoxI.Name = "textBoxI";
            this.textBoxI.Size = new System.Drawing.Size(117, 20);
            this.textBoxI.TabIndex = 9;
            this.textBoxI.Text = "6.00";
            this.textBoxI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxI.GotFocus += new System.EventHandler(this.textBoxI_GotFocus);
            this.textBoxI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxI_KeyPress);
            this.textBoxI.MouseLeave += new System.EventHandler(this.textBoxI_MouseLeave);
            this.textBoxI.MouseHover += new System.EventHandler(this.textBoxI_MouseHover);
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(196, 268);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(117, 20);
            this.textBoxP.TabIndex = 11;
            this.textBoxP.Text = "12";
            this.textBoxP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxP.ValidatingType = typeof(int);
            this.textBoxP.MouseLeave += new System.EventHandler(this.textBoxP_MouseLeave);
            this.textBoxP.MouseHover += new System.EventHandler(this.textBoxP_MouseHover);
            // 
            // radioButtonBegin
            // 
            this.radioButtonBegin.AutoSize = true;
            this.radioButtonBegin.Location = new System.Drawing.Point(6, 19);
            this.radioButtonBegin.Name = "radioButtonBegin";
            this.radioButtonBegin.Size = new System.Drawing.Size(52, 17);
            this.radioButtonBegin.TabIndex = 12;
            this.radioButtonBegin.Text = "Begin";
            this.radioButtonBegin.UseVisualStyleBackColor = true;
            this.radioButtonBegin.MouseLeave += new System.EventHandler(this.radioButtonBegin_MouseLeave);
            this.radioButtonBegin.MouseHover += new System.EventHandler(this.radioButtonBegin_MouseHover);
            // 
            // radioButtonEnd
            // 
            this.radioButtonEnd.AutoSize = true;
            this.radioButtonEnd.Checked = true;
            this.radioButtonEnd.Location = new System.Drawing.Point(64, 19);
            this.radioButtonEnd.Name = "radioButtonEnd";
            this.radioButtonEnd.Size = new System.Drawing.Size(44, 17);
            this.radioButtonEnd.TabIndex = 13;
            this.radioButtonEnd.TabStop = true;
            this.radioButtonEnd.Text = "End";
            this.radioButtonEnd.UseVisualStyleBackColor = true;
            this.radioButtonEnd.CheckedChanged += new System.EventHandler(this.radioButtonEnd_CheckedChanged);
            this.radioButtonEnd.MouseLeave += new System.EventHandler(this.radioButtonEnd_MouseLeave);
            this.radioButtonEnd.MouseHover += new System.EventHandler(this.radioButtonEnd_MouseHover);
            // 
            // buttonN
            // 
            this.buttonN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonN.Location = new System.Drawing.Point(323, 34);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(75, 23);
            this.buttonN.TabIndex = 2;
            this.buttonN.Text = "Solve";
            this.toolTip.SetToolTip(this.buttonN, "Calculates how many payments it would take to\r\npayoff all of the Loan Amount give" +
        "n the\r\nPeriodic Payment and Interest Rate.");
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonPV
            // 
            this.buttonPV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPV.Location = new System.Drawing.Point(323, 83);
            this.buttonPV.Name = "buttonPV";
            this.buttonPV.Size = new System.Drawing.Size(75, 23);
            this.buttonPV.TabIndex = 4;
            this.buttonPV.Text = "Solve";
            this.toolTip.SetToolTip(this.buttonPV, "Solve for the total loan value that you can borrow.\r\nMust specify Periodic Paymen" +
        "t\r\nand Interest Rate should not be zero.");
            this.buttonPV.UseVisualStyleBackColor = true;
            this.buttonPV.Click += new System.EventHandler(this.buttonPV_Click);
            // 
            // buttonPMT
            // 
            this.buttonPMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPMT.Location = new System.Drawing.Point(323, 131);
            this.buttonPMT.Name = "buttonPMT";
            this.buttonPMT.Size = new System.Drawing.Size(75, 23);
            this.buttonPMT.TabIndex = 6;
            this.buttonPMT.Text = "Solve";
            this.toolTip.SetToolTip(this.buttonPMT, "Solve for Periodic scheduled payment amount.\r\nFor example, monthly mortgage payme" +
        "nt\r\nor car loan payment.");
            this.buttonPMT.UseVisualStyleBackColor = true;
            this.buttonPMT.Click += new System.EventHandler(this.buttonPMT_Click);
            // 
            // buttonFV
            // 
            this.buttonFV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFV.Location = new System.Drawing.Point(323, 174);
            this.buttonFV.Name = "buttonFV";
            this.buttonFV.Size = new System.Drawing.Size(75, 23);
            this.buttonFV.TabIndex = 8;
            this.buttonFV.Text = "Solve";
            this.toolTip.SetToolTip(this.buttonFV, "Solve for ending loan valance.");
            this.buttonFV.UseVisualStyleBackColor = true;
            this.buttonFV.Click += new System.EventHandler(this.buttonFV_Click);
            // 
            // buttonI
            // 
            this.buttonI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonI.Location = new System.Drawing.Point(323, 221);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(75, 23);
            this.buttonI.TabIndex = 10;
            this.buttonI.Text = "Solve";
            this.toolTip.SetToolTip(this.buttonI, "Solve for interest rate.");
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // groupBoxPP
            // 
            this.groupBoxPP.Controls.Add(this.radioButtonEnd);
            this.groupBoxPP.Controls.Add(this.radioButtonBegin);
            this.groupBoxPP.Location = new System.Drawing.Point(323, 250);
            this.groupBoxPP.Name = "groupBoxPP";
            this.groupBoxPP.Size = new System.Drawing.Size(119, 52);
            this.groupBoxPP.TabIndex = 12;
            this.groupBoxPP.TabStop = false;
            this.groupBoxPP.Text = "Payment Period";
            this.toolTip.SetToolTip(this.groupBoxPP, "Whether the payment starts in the beginning or at the end of period.\r\nChoose Begi" +
        "n for loans such as auto loan.\r\nChoose End for mortgages.");
            this.groupBoxPP.MouseLeave += new System.EventHandler(this.groupBoxPP_MouseLeave);
            // 
            // groupBoxPeriodType
            // 
            this.groupBoxPeriodType.Controls.Add(this.radioButtonPeriods);
            this.groupBoxPeriodType.Controls.Add(this.radioButtonYears);
            this.groupBoxPeriodType.Location = new System.Drawing.Point(404, 10);
            this.groupBoxPeriodType.Name = "groupBoxPeriodType";
            this.groupBoxPeriodType.Size = new System.Drawing.Size(108, 64);
            this.groupBoxPeriodType.TabIndex = 1;
            this.groupBoxPeriodType.TabStop = false;
            this.groupBoxPeriodType.Text = "Period Type";
            this.groupBoxPeriodType.MouseLeave += new System.EventHandler(this.groupBoxPeriodType_MouseLeave);
            this.groupBoxPeriodType.MouseHover += new System.EventHandler(this.groupBoxPeriodType_MouseHover);
            // 
            // radioButtonPeriods
            // 
            this.radioButtonPeriods.AutoSize = true;
            this.radioButtonPeriods.Location = new System.Drawing.Point(17, 41);
            this.radioButtonPeriods.Name = "radioButtonPeriods";
            this.radioButtonPeriods.Size = new System.Drawing.Size(60, 17);
            this.radioButtonPeriods.TabIndex = 1;
            this.radioButtonPeriods.Text = "Periods";
            this.radioButtonPeriods.UseVisualStyleBackColor = true;
            this.radioButtonPeriods.CheckedChanged += new System.EventHandler(this.radioButtonPeriods_CheckedChanged);
            this.radioButtonPeriods.MouseLeave += new System.EventHandler(this.radioButtonPeriods_MouseLeave);
            this.radioButtonPeriods.MouseHover += new System.EventHandler(this.radioButtonPeriods_MouseHover);
            // 
            // radioButtonYears
            // 
            this.radioButtonYears.AutoSize = true;
            this.radioButtonYears.Checked = true;
            this.radioButtonYears.Location = new System.Drawing.Point(17, 19);
            this.radioButtonYears.Name = "radioButtonYears";
            this.radioButtonYears.Size = new System.Drawing.Size(52, 17);
            this.radioButtonYears.TabIndex = 0;
            this.radioButtonYears.TabStop = true;
            this.radioButtonYears.Text = "Years";
            this.radioButtonYears.UseVisualStyleBackColor = true;
            this.radioButtonYears.CheckedChanged += new System.EventHandler(this.radioButtonYears_CheckedChanged);
            this.radioButtonYears.MouseLeave += new System.EventHandler(this.radioButtonYears_MouseLeave);
            this.radioButtonYears.MouseHover += new System.EventHandler(this.radioButtonYears_MouseHover);
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.Location = new System.Drawing.Point(17, 64);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(327, 26);
            this.labelHeading.TabIndex = 21;
            this.labelHeading.Text = "Time Value of Money Worksheet";
            // 
            // textBoxN
            // 
            this.textBoxN.FormattingEnabled = true;
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
            this.textBoxN.Location = new System.Drawing.Point(196, 34);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(121, 21);
            this.textBoxN.TabIndex = 0;
            this.textBoxN.SelectedValueChanged += new System.EventHandler(this.textBoxN_SelectedValueChanged);
            this.textBoxN.GotFocus += new System.EventHandler(this.textBoxN_GotFocus);
            this.textBoxN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxN_KeyPress);
            this.textBoxN.MouseLeave += new System.EventHandler(this.textBoxN_MouseLeave);
            this.textBoxN.MouseHover += new System.EventHandler(this.textBoxN_MouseHover);
            // 
            // groupBoxAmort
            // 
            this.groupBoxAmort.Controls.Add(this.maskedTextBoxBalance);
            this.groupBoxAmort.Controls.Add(this.maskedTextBoxInterest);
            this.groupBoxAmort.Controls.Add(this.maskedTextBoxPrincipal);
            this.groupBoxAmort.Controls.Add(this.labelBalance);
            this.groupBoxAmort.Controls.Add(this.labelInterest);
            this.groupBoxAmort.Controls.Add(this.labelPrincipal);
            this.groupBoxAmort.Controls.Add(this.numericUpDownTo);
            this.groupBoxAmort.Controls.Add(this.numericUpDownFrom);
            this.groupBoxAmort.Controls.Add(this.labelTo);
            this.groupBoxAmort.Controls.Add(this.labelFrom);
            this.groupBoxAmort.Location = new System.Drawing.Point(22, 436);
            this.groupBoxAmort.Name = "groupBoxAmort";
            this.groupBoxAmort.Size = new System.Drawing.Size(540, 91);
            this.groupBoxAmort.TabIndex = 27;
            this.groupBoxAmort.TabStop = false;
            this.groupBoxAmort.Text = "Amortization";
            // 
            // maskedTextBoxBalance
            // 
            this.maskedTextBoxBalance.Location = new System.Drawing.Point(414, 48);
            this.maskedTextBoxBalance.Name = "maskedTextBoxBalance";
            this.maskedTextBoxBalance.ReadOnly = true;
            this.maskedTextBoxBalance.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxBalance.TabIndex = 23;
            this.maskedTextBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.maskedTextBoxBalance, "Ending balance\r\nat the end of \r\nspecified period.\r\nPrincipal amount left.");
            // 
            // maskedTextBoxInterest
            // 
            this.maskedTextBoxInterest.Location = new System.Drawing.Point(293, 48);
            this.maskedTextBoxInterest.Name = "maskedTextBoxInterest";
            this.maskedTextBoxInterest.ReadOnly = true;
            this.maskedTextBoxInterest.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxInterest.TabIndex = 22;
            this.maskedTextBoxInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.maskedTextBoxInterest, "Total interest paid");
            // 
            // maskedTextBoxPrincipal
            // 
            this.maskedTextBoxPrincipal.Location = new System.Drawing.Point(170, 50);
            this.maskedTextBoxPrincipal.Name = "maskedTextBoxPrincipal";
            this.maskedTextBoxPrincipal.ReadOnly = true;
            this.maskedTextBoxPrincipal.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPrincipal.TabIndex = 21;
            this.maskedTextBoxPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.maskedTextBoxPrincipal, "Total principal paid");
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(432, 26);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(82, 13);
            this.labelBalance.TabIndex = 6;
            this.labelBalance.Text = "Ending Balance";
            // 
            // labelInterest
            // 
            this.labelInterest.AutoSize = true;
            this.labelInterest.Location = new System.Drawing.Point(327, 26);
            this.labelInterest.Name = "labelInterest";
            this.labelInterest.Size = new System.Drawing.Size(66, 13);
            this.labelInterest.TabIndex = 5;
            this.labelInterest.Text = "Interest Paid";
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.Location = new System.Drawing.Point(199, 26);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(71, 13);
            this.labelPrincipal.TabIndex = 4;
            this.labelPrincipal.Text = "Principal Paid";
            // 
            // numericUpDownTo
            // 
            this.numericUpDownTo.Location = new System.Drawing.Point(80, 51);
            this.numericUpDownTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTo.Name = "numericUpDownTo";
            this.numericUpDownTo.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownTo.TabIndex = 20;
            this.toolTip.SetToolTip(this.numericUpDownTo, "Ending payment period.");
            this.numericUpDownTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTo.ValueChanged += new System.EventHandler(this.numericUpDownTo_ValueChanged);
            // 
            // numericUpDownFrom
            // 
            this.numericUpDownFrom.Location = new System.Drawing.Point(9, 51);
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownFrom.TabIndex = 19;
            this.toolTip.SetToolTip(this.numericUpDownFrom, "Beginning payment period.");
            this.numericUpDownFrom.ValueChanged += new System.EventHandler(this.numericUpDownFrom_ValueChanged);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(77, 26);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 1;
            this.labelTo.Text = "To";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(6, 26);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(30, 13);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From";
            // 
            // groupBoxRequired
            // 
            this.groupBoxRequired.Controls.Add(this.groupBoxPeriodType);
            this.groupBoxRequired.Controls.Add(this.groupBoxPP);
            this.groupBoxRequired.Controls.Add(this.textBoxN);
            this.groupBoxRequired.Controls.Add(this.lblN);
            this.groupBoxRequired.Controls.Add(this.buttonI);
            this.groupBoxRequired.Controls.Add(this.lblPV);
            this.groupBoxRequired.Controls.Add(this.buttonFV);
            this.groupBoxRequired.Controls.Add(this.lblPMT);
            this.groupBoxRequired.Controls.Add(this.buttonPMT);
            this.groupBoxRequired.Controls.Add(this.lblFV);
            this.groupBoxRequired.Controls.Add(this.buttonPV);
            this.groupBoxRequired.Controls.Add(this.lblI);
            this.groupBoxRequired.Controls.Add(this.buttonN);
            this.groupBoxRequired.Controls.Add(this.lblP);
            this.groupBoxRequired.Controls.Add(this.textBoxP);
            this.groupBoxRequired.Controls.Add(this.textBoxPV);
            this.groupBoxRequired.Controls.Add(this.textBoxI);
            this.groupBoxRequired.Controls.Add(this.textBoxPMT);
            this.groupBoxRequired.Controls.Add(this.textBoxFV);
            this.groupBoxRequired.Location = new System.Drawing.Point(22, 105);
            this.groupBoxRequired.Name = "groupBoxRequired";
            this.groupBoxRequired.Size = new System.Drawing.Size(540, 325);
            this.groupBoxRequired.TabIndex = 28;
            this.groupBoxRequired.TabStop = false;
            this.groupBoxRequired.Text = "Required Information";
            // 
            // groupBoxOptional
            // 
            this.groupBoxOptional.Controls.Add(this.label8);
            this.groupBoxOptional.Controls.Add(this.label7);
            this.groupBoxOptional.Controls.Add(this.numericUpDownExpenseYear);
            this.groupBoxOptional.Controls.Add(this.label6);
            this.groupBoxOptional.Controls.Add(this.label5);
            this.groupBoxOptional.Controls.Add(this.maskedTextBoxTotal);
            this.groupBoxOptional.Controls.Add(this.label4);
            this.groupBoxOptional.Controls.Add(this.numericUpDownExtra);
            this.groupBoxOptional.Controls.Add(this.label3);
            this.groupBoxOptional.Controls.Add(this.numericUpDownInsurance);
            this.groupBoxOptional.Controls.Add(this.label2);
            this.groupBoxOptional.Controls.Add(this.label1);
            this.groupBoxOptional.Controls.Add(this.numericUpDownTax);
            this.groupBoxOptional.Location = new System.Drawing.Point(676, 105);
            this.groupBoxOptional.Name = "groupBoxOptional";
            this.groupBoxOptional.Size = new System.Drawing.Size(235, 378);
            this.groupBoxOptional.TabIndex = 29;
            this.groupBoxOptional.TabStop = false;
            this.groupBoxOptional.Text = "Optional Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Yearly Extras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Monthly Extras";
            // 
            // numericUpDownExpenseYear
            // 
            this.numericUpDownExpenseYear.DecimalPlaces = 2;
            this.numericUpDownExpenseYear.Increment = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownExpenseYear.Location = new System.Drawing.Point(119, 119);
            this.numericUpDownExpenseYear.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownExpenseYear.Name = "numericUpDownExpenseYear";
            this.numericUpDownExpenseYear.Size = new System.Drawing.Size(110, 20);
            this.numericUpDownExpenseYear.TabIndex = 15;
            this.numericUpDownExpenseYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownExpenseYear.ThousandsSeparator = true;
            this.numericUpDownExpenseYear.ValueChanged += new System.EventHandler(this.numericUpDownExpenseYear_ValueChanged);
            this.numericUpDownExpenseYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownExpenseYear_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "All Other Expenses\r\n(Yearly)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Monthly\r\nincluding\r\nPrincipal + Interest";
            // 
            // maskedTextBoxTotal
            // 
            this.maskedTextBoxTotal.Location = new System.Drawing.Point(119, 323);
            this.maskedTextBoxTotal.Name = "maskedTextBoxTotal";
            this.maskedTextBoxTotal.ReadOnly = true;
            this.maskedTextBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTotal.TabIndex = 18;
            this.maskedTextBoxTotal.Text = "$0.00";
            this.maskedTextBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "_________________________";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericUpDownExtra
            // 
            this.numericUpDownExtra.DecimalPlaces = 2;
            this.numericUpDownExtra.Location = new System.Drawing.Point(119, 228);
            this.numericUpDownExtra.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownExtra.Name = "numericUpDownExtra";
            this.numericUpDownExtra.Size = new System.Drawing.Size(110, 20);
            this.numericUpDownExtra.TabIndex = 16;
            this.numericUpDownExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownExtra.ThousandsSeparator = true;
            this.numericUpDownExtra.ValueChanged += new System.EventHandler(this.numericUpDownExtra_ValueChanged);
            this.numericUpDownExtra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownExtra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Extra Principal \r\nPayment\r\n(Monthly)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDownInsurance
            // 
            this.numericUpDownInsurance.DecimalPlaces = 2;
            this.numericUpDownInsurance.Increment = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownInsurance.Location = new System.Drawing.Point(119, 79);
            this.numericUpDownInsurance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownInsurance.Name = "numericUpDownInsurance";
            this.numericUpDownInsurance.Size = new System.Drawing.Size(110, 20);
            this.numericUpDownInsurance.TabIndex = 14;
            this.numericUpDownInsurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownInsurance.ThousandsSeparator = true;
            this.numericUpDownInsurance.ValueChanged += new System.EventHandler(this.numericUpDownInsurance_ValueChanged);
            this.numericUpDownInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownInsurance_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insurance\r\n(Yearly)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tax (Yearly)";
            // 
            // numericUpDownTax
            // 
            this.numericUpDownTax.DecimalPlaces = 2;
            this.numericUpDownTax.Increment = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownTax.Location = new System.Drawing.Point(119, 41);
            this.numericUpDownTax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTax.Name = "numericUpDownTax";
            this.numericUpDownTax.Size = new System.Drawing.Size(110, 20);
            this.numericUpDownTax.TabIndex = 13;
            this.numericUpDownTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTax.ThousandsSeparator = true;
            this.numericUpDownTax.ValueChanged += new System.EventHandler(this.numericUpDownTax_ValueChanged);
            this.numericUpDownTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownTax_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFA.Properties.Resources.check;
            this.pictureBox1.Location = new System.Drawing.Point(352, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // buttonToggleOptionalInfo
            // 
            this.buttonToggleOptionalInfo.Image = global::WindowsFA.Properties.Resources.people;
            this.buttonToggleOptionalInfo.Location = new System.Drawing.Point(601, 221);
            this.buttonToggleOptionalInfo.Name = "buttonToggleOptionalInfo";
            this.buttonToggleOptionalInfo.Size = new System.Drawing.Size(25, 25);
            this.buttonToggleOptionalInfo.TabIndex = 32;
            this.toolTip.SetToolTip(this.buttonToggleOptionalInfo, "Toggle Optional Information");
            this.buttonToggleOptionalInfo.UseVisualStyleBackColor = true;
            this.buttonToggleOptionalInfo.Click += new System.EventHandler(this.buttonToggleOptionalInfo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(583, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 26);
            this.label10.TabIndex = 33;
            this.label10.Text = "Show or Hide\r\nOptional Info";
            // 
            // FormTVM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 580);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonToggleOptionalInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxOptional);
            this.Controls.Add(this.groupBoxRequired);
            this.Controls.Add(this.groupBoxAmort);
            this.Controls.Add(this.labelHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTVM";
            this.Load += new System.EventHandler(this.FormTVM_Load);
            this.Controls.SetChildIndex(this.labelHeading, 0);
            this.Controls.SetChildIndex(this.groupBoxAmort, 0);
            this.Controls.SetChildIndex(this.groupBoxRequired, 0);
            this.Controls.SetChildIndex(this.groupBoxOptional, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.buttonToggleOptionalInfo, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.groupBoxPP.ResumeLayout(false);
            this.groupBoxPP.PerformLayout();
            this.groupBoxPeriodType.ResumeLayout(false);
            this.groupBoxPeriodType.PerformLayout();
            this.groupBoxAmort.ResumeLayout(false);
            this.groupBoxAmort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            this.groupBoxRequired.ResumeLayout(false);
            this.groupBoxRequired.PerformLayout();
            this.groupBoxOptional.ResumeLayout(false);
            this.groupBoxOptional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExpenseYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void radioButtonYears_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(radioButtonYears);
            toolTip.ToolTipTitle = "";
        }

        void radioButtonPeriods_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(radioButtonPeriods);
            toolTip.ToolTipTitle = "";
        }


        void textBoxP_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(textBoxP);
            toolTip.ToolTipTitle = "";
        }

        void radioButtonEnd_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(radioButtonEnd);
            toolTip.ToolTipTitle = "";
        }

        void radioButtonBegin_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(radioButtonBegin);
            toolTip.ToolTipTitle = "";
        }

        void groupBoxPeriodType_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(groupBoxPeriodType);
            toolTip.ToolTipTitle = "";
        }

        void groupBoxPP_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(groupBoxPP);
            toolTip.ToolTipTitle = "";
        }

        void textBoxN_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(textBoxN);
            toolTip.ToolTipTitle = "";
        }

        void textBoxI_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(textBoxI);
            toolTip.ToolTipTitle = "";
        }

        void textBoxFV_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(textBoxFV);
            toolTip.ToolTipTitle = "";
        }

        void textBoxPMT_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(textBoxPMT);
            toolTip.ToolTipTitle = "";
        }

        void textBoxPV_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(textBoxPV);
            toolTip.ToolTipTitle = "";
        }

        void radioButtonYears_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Number of Years or Periods";
            toolTip.Show("Choose to display either in Years or Periods.\n" +
                "Periods = (No. of Years) x (Periods per Year).\n" +
                "Amortization section also uses this value for\n" +
                "calculations."
                , radioButtonYears, radioButtonYears.Location.X, radioButtonYears.Location.Y, 3000);
        }

        void radioButtonPeriods_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Number of Years or Periods";
            toolTip.Show("Choose to display either in Years or Periods.\n" +
                "Periods = (No. of Years) x (Periods per Year).\n" +
                "Amortization section also uses this value for\n" +
                "calculations."
                , radioButtonPeriods, radioButtonPeriods.Location.X, radioButtonPeriods.Location.Y, 3000);
        }

        void groupBoxPeriodType_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Number of Years or Periods";
            toolTip.Show("Choose to display either in Years or Periods.\n" +
                "Periods = (No. of Years) x (Periods per Year).\n" +
                "Amortization section also uses this value for\n" +
                "calculations."
                , groupBoxPeriodType, groupBoxPeriodType.Location.X, groupBoxPeriodType.Location.Y, 3000);

        }

        void textBoxPMT_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Periodic Payment";
            toolTip.Show("Periodic payments you will need to make.\n" +
                "This is principal + interest.\n"
                , textBoxPMT, textBoxPMT.Location.X, textBoxPMT.Location.Y, 3000);
            
        }

        void textBoxN_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Total Length of the Loan or Mortgage";
            toolTip.Show("Total length of the loan or mortgage\n" +
                "in number of years or periods.\n" +
                "Depends on Period Type.\n"
                , textBoxN, textBoxN.Location.X, textBoxN.Location.Y, 3000);

        }

        void textBoxFV_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Future Value or Ending Balance of the Loan";
            toolTip.Show("Leftover loan or mortgage balance at then end of the\n" +
                "loan or mortgage period.\n" +
                "Put zero if not sure.\n" +
                "Usually this value is zero at the end of the loan."
                , textBoxFV, textBoxFV.Location.X, textBoxFV.Location.Y, 3000);

        }

        void textBoxP_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Number of Payments per Year";
            toolTip.Show("Number of payments per year.\n" +
                "For example,\n" +
                "12 for monthly.\n" +
                "4 for quartly.\n"+
                "1 for yearly.", textBoxP, textBoxP.Location.X, textBoxP.Location.Y, 3000);

        }

        void radioButtonEnd_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Lease or Mortgage";
            toolTip.Show("Whether the payment starts in the beginning or at the end of period.\n" +
                "Choose Begin for loans such as auto loan.\n" +
                "Choose End for mortgages."
                , radioButtonEnd, radioButtonEnd.Location.X, radioButtonEnd.Location.Y, 3000);

        }

        void radioButtonBegin_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Lease or Mortgage";
            toolTip.Show("Whether the payment starts in the beginning or at the end of period.\n"+
                "Choose Begin for loans such as auto loan.\n" +
                "Choose End for mortgages."
                , radioButtonBegin, radioButtonBegin.Location.X, radioButtonBegin.Location.Y, 3000);

        }

        void textBoxPV_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Loan or Mortgage Amount";
            toolTip.Show("Total loan amount or total mortgage amount.\n"+
                "Press enter to calculate Periodic payment amount."
                , textBoxPV, textBoxPV.Location.X, textBoxPV.Location.Y, 3000);
        }

        void textBoxI_MouseHover(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle="APR Rate - Effective Rate(APY)";
            toolTip.Show("APR. This is your mortgage rate.\nThe effective rate is " + Math.Round((famodel.eff(Double.Parse(textBoxI.Text.ToString()) / 100.0, Double.Parse(this.textBoxP.Text.ToString())) * 100.0), 2).ToString("N", nfi) + "%."
                + "\nEffective rate is also called Annaul Percentage Yield or APY.", textBoxI, textBoxI.Location.X, textBoxI.Location.Y, 3000);
        }

        void numericUpDownExpenseYear_ValueChanged(object sender, EventArgs e)
        {
            xmlHasChanged = true; 
            calcOptional();
        }

        void numericUpDownExtra_ValueChanged(object sender, EventArgs e)
        {
            xmlHasChanged = true;
            calcOptional();
            amortize();
        }

        void numericUpDownInsurance_ValueChanged(object sender, EventArgs e)
        {
            xmlHasChanged = true;
            calcOptional();
        }

        void numericUpDownExpenseMonth_ValueChanged(object sender, EventArgs e)
        {
            xmlHasChanged = true;
            calcOptional();
        }

        void numericUpDownTax_ValueChanged(object sender, EventArgs e)
        {
            xmlHasChanged = true;
            calcOptional();
        }


        void textBoxI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                xmlHasChanged = true;
                recalc(TVMObjects.PMT);
                textBoxI.Text = Math.Round(tvm.getI()*100.0, 2).ToString("N", nfi);
                textBoxI_GotFocus(sender, e);
            }
        }

        void textBoxPV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                xmlHasChanged = true;
                recalc(TVMObjects.PMT);
                textBoxPV.Text = Math.Round(tvm.getPV(), 2).ToString("C", nfi);
                textBoxPV_GotFocus(sender,  e);
            }
        }

        void numericUpDownExtra_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                xmlHasChanged = true;
                recalc(TVMObjects.PMT);
            }
        }

        void numericUpDownExpenseYear_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                xmlHasChanged = true;
                calcOptional();
            }
        }

        void numericUpDownExpenseMonth_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                xmlHasChanged = true;
                calcOptional();
            }
        }

        void numericUpDownInsurance_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                xmlHasChanged = true;
                calcOptional();
            }
        }

        void numericUpDownTax_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                xmlHasChanged = true;
                calcOptional();
            }
        }
        void textBoxN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                //recalc(TVMObjects.PMT);
                //textBoxN.Text = (isYear) ? (tvm.getN() / tvm.getP()).ToString("N", nfi) : tvm.getN().ToString("N", nfi);
                //textBoxN_GotFocus(sender, e);
                xmlHasChanged = true;
                textBoxN_SelectedValueChanged(sender, e);
            }
        }

        void textBoxN_SelectedValueChanged(object sender, EventArgs e)
        {
            xmlHasChanged = true;
            double tempN = (isYear) ? Double.Parse(textBoxN.Text.ToString()) * Double.Parse(textBoxP.Text.ToString()) : Double.Parse(textBoxN.Text.ToString());
            tvm.setN(tempN);
            fromtovalue();
            recalc(TVMObjects.PMT);
            textBoxN_GotFocus(sender, e);
        }

        void textBoxN_GotFocus(object sender, System.EventArgs e)
        {
            textBoxN.SelectAll();
        }

        void textBoxI_GotFocus(object sender, System.EventArgs e)
        {
            textBoxI.SelectAll();
        }

        void textBoxFV_GotFocus(object sender, System.EventArgs e)
        {
            textBoxFV.SelectAll();
        }

        void textBoxPMT_GotFocus(object sender, System.EventArgs e)
        {
            textBoxPMT.SelectAll();
        }

        void textBoxPV_GotFocus(object sender, System.EventArgs e)
        {
            textBoxPV.SelectAll();
        }

        #endregion

        protected System.Windows.Forms.Label lblN;
        protected System.Windows.Forms.Label lblPV;
        protected System.Windows.Forms.Label lblPMT;
        protected System.Windows.Forms.Label lblFV;
        protected System.Windows.Forms.Label lblI;
        protected System.Windows.Forms.Label lblP;
        private System.Windows.Forms.MaskedTextBox textBoxPV;
        private System.Windows.Forms.MaskedTextBox textBoxPMT;
        private System.Windows.Forms.MaskedTextBox textBoxFV;
        private System.Windows.Forms.MaskedTextBox textBoxI;
        private System.Windows.Forms.MaskedTextBox textBoxP;
        private System.Windows.Forms.RadioButton radioButtonBegin;
        private System.Windows.Forms.RadioButton radioButtonEnd;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonPV;
        private System.Windows.Forms.Button buttonPMT;
        private System.Windows.Forms.Button buttonFV;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.GroupBox groupBoxPP;
        private System.Windows.Forms.GroupBox groupBoxPeriodType;
        private System.Windows.Forms.RadioButton radioButtonPeriods;
        private System.Windows.Forms.RadioButton radioButtonYears;
        protected System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.ComboBox textBoxN;
        private System.Windows.Forms.GroupBox groupBoxAmort;
        private System.Windows.Forms.NumericUpDown numericUpDownTo;
        private System.Windows.Forms.NumericUpDown numericUpDownFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBalance;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInterest;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrincipal;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelInterest;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.GroupBox groupBoxRequired;
        private System.Windows.Forms.GroupBox groupBoxOptional;
        private System.Windows.Forms.NumericUpDown numericUpDownInsurance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownExtra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownExpenseYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private PictureBox pictureBox1;
        private Button buttonToggleOptionalInfo;
        private Label label10;
    }
}