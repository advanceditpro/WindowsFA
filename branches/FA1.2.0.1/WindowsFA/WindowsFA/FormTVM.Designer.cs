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
            this.groupBoxPP.SuspendLayout();
            this.groupBoxPeriodType.SuspendLayout();
            this.groupBoxAmort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(35, 127);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "N";
            // 
            // lblPV
            // 
            this.lblPV.AutoSize = true;
            this.lblPV.Location = new System.Drawing.Point(35, 176);
            this.lblPV.Name = "lblPV";
            this.lblPV.Size = new System.Drawing.Size(21, 13);
            this.lblPV.TabIndex = 1;
            this.lblPV.Text = "PV";
            // 
            // lblPMT
            // 
            this.lblPMT.AutoSize = true;
            this.lblPMT.Location = new System.Drawing.Point(35, 224);
            this.lblPMT.Name = "lblPMT";
            this.lblPMT.Size = new System.Drawing.Size(30, 13);
            this.lblPMT.TabIndex = 2;
            this.lblPMT.Text = "PMT";
            // 
            // lblFV
            // 
            this.lblFV.AutoSize = true;
            this.lblFV.Location = new System.Drawing.Point(35, 267);
            this.lblFV.Name = "lblFV";
            this.lblFV.Size = new System.Drawing.Size(20, 13);
            this.lblFV.TabIndex = 3;
            this.lblFV.Text = "FV";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(35, 314);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(26, 13);
            this.lblI.TabIndex = 4;
            this.lblI.Text = "I%R";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(35, 358);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(26, 13);
            this.lblP.TabIndex = 5;
            this.lblP.Text = "P/Y";
            // 
            // textBoxPV
            // 
            this.textBoxPV.Location = new System.Drawing.Point(233, 173);
            this.textBoxPV.Name = "textBoxPV";
            this.textBoxPV.Size = new System.Drawing.Size(117, 20);
            this.textBoxPV.TabIndex = 7;
            this.textBoxPV.Text = "$0.00";
            this.textBoxPV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.textBoxPV, "Total loan amount or total mortgage amount.");
            this.textBoxPV.GotFocus += new System.EventHandler(this.textBoxPV_GotFocus);
            // 
            // textBoxPMT
            // 
            this.textBoxPMT.Location = new System.Drawing.Point(233, 220);
            this.textBoxPMT.Name = "textBoxPMT";
            this.textBoxPMT.Size = new System.Drawing.Size(117, 20);
            this.textBoxPMT.TabIndex = 8;
            this.textBoxPMT.Text = "$0.00";
            this.textBoxPMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.textBoxPMT, "Periodic payments you will need to make.");
            this.textBoxPMT.GotFocus += new System.EventHandler(this.textBoxPMT_GotFocus);
            // 
            // textBoxFV
            // 
            this.textBoxFV.Location = new System.Drawing.Point(233, 263);
            this.textBoxFV.Name = "textBoxFV";
            this.textBoxFV.Size = new System.Drawing.Size(117, 20);
            this.textBoxFV.TabIndex = 9;
            this.textBoxFV.Text = "$0.00";
            this.textBoxFV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.textBoxFV, "Leftover loan or mortgage balance at then end of the\r\nloan or mortgage period.\r\nP" +
                    "ut zero if not sure. Usually this value is zero at the end.");
            this.textBoxFV.GotFocus += new System.EventHandler(this.textBoxFV_GotFocus);
            // 
            // textBoxI
            // 
            this.textBoxI.Location = new System.Drawing.Point(233, 310);
            this.textBoxI.Name = "textBoxI";
            this.textBoxI.Size = new System.Drawing.Size(117, 20);
            this.textBoxI.TabIndex = 10;
            this.textBoxI.Text = "6.00";
            this.textBoxI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.textBoxI, "APR. This is your mortgage rate.");
            this.textBoxI.GotFocus += new System.EventHandler(this.textBoxI_GotFocus);
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(233, 358);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(117, 20);
            this.textBoxP.TabIndex = 11;
            this.textBoxP.Text = "12";
            this.textBoxP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.textBoxP, "Number of payments per year.\r\nFor example,\r\n12 for monthly.\r\n4 for quartly.\r\n1 fo" +
                    "r yearly.");
            this.textBoxP.ValidatingType = typeof(int);
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
            // 
            // buttonN
            // 
            this.buttonN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonN.Location = new System.Drawing.Point(356, 122);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(75, 23);
            this.buttonN.TabIndex = 14;
            this.buttonN.Text = "Solve";
            this.toolTip.SetToolTip(this.buttonN, "Calculates how many payments it would take to\r\npayoff all of the Loan Amount give" +
                    "n the\r\nPeriodic Payment and Interest Rate.");
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonPV
            // 
            this.buttonPV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPV.Location = new System.Drawing.Point(356, 171);
            this.buttonPV.Name = "buttonPV";
            this.buttonPV.Size = new System.Drawing.Size(75, 23);
            this.buttonPV.TabIndex = 15;
            this.buttonPV.Text = "Solve";
            this.toolTip.SetToolTip(this.buttonPV, "Solve for the total loan value that you can borrow.\r\nMust specify Periodic Paymen" +
                    "t\r\nand Interest Rate should not be zero.");
            this.buttonPV.UseVisualStyleBackColor = true;
            this.buttonPV.Click += new System.EventHandler(this.buttonPV_Click);
            // 
            // buttonPMT
            // 
            this.buttonPMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPMT.Location = new System.Drawing.Point(356, 219);
            this.buttonPMT.Name = "buttonPMT";
            this.buttonPMT.Size = new System.Drawing.Size(75, 23);
            this.buttonPMT.TabIndex = 16;
            this.buttonPMT.Text = "Solve";
            this.toolTip.SetToolTip(this.buttonPMT, "Solve for Periodic scheduled payment amount.\r\nFor example, monthly mortgage payme" +
                    "nt\r\nor car loan payment.");
            this.buttonPMT.UseVisualStyleBackColor = true;
            this.buttonPMT.Click += new System.EventHandler(this.buttonPMT_Click);
            // 
            // buttonFV
            // 
            this.buttonFV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFV.Location = new System.Drawing.Point(356, 262);
            this.buttonFV.Name = "buttonFV";
            this.buttonFV.Size = new System.Drawing.Size(75, 23);
            this.buttonFV.TabIndex = 17;
            this.buttonFV.Text = "Solve";
            this.toolTip.SetToolTip(this.buttonFV, "Solve for ending loan valance.");
            this.buttonFV.UseVisualStyleBackColor = true;
            this.buttonFV.Click += new System.EventHandler(this.buttonFV_Click);
            // 
            // buttonI
            // 
            this.buttonI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonI.Location = new System.Drawing.Point(356, 309);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(75, 23);
            this.buttonI.TabIndex = 18;
            this.buttonI.Text = "Solve";
            this.toolTip.SetToolTip(this.buttonI, "Solve for interest rate.");
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // groupBoxPP
            // 
            this.groupBoxPP.Controls.Add(this.radioButtonEnd);
            this.groupBoxPP.Controls.Add(this.radioButtonBegin);
            this.groupBoxPP.Location = new System.Drawing.Point(356, 361);
            this.groupBoxPP.Name = "groupBoxPP";
            this.groupBoxPP.Size = new System.Drawing.Size(119, 52);
            this.groupBoxPP.TabIndex = 19;
            this.groupBoxPP.TabStop = false;
            this.groupBoxPP.Text = "Payment Period";
            this.toolTip.SetToolTip(this.groupBoxPP, "Whether the payment starts in the beginning or at the end of period.\r\nChoose Begi" +
                    "n for loans such as auto loan.\r\nChoose End for mortgages.");
            // 
            // groupBoxPeriodType
            // 
            this.groupBoxPeriodType.Controls.Add(this.radioButtonPeriods);
            this.groupBoxPeriodType.Controls.Add(this.radioButtonYears);
            this.groupBoxPeriodType.Location = new System.Drawing.Point(444, 103);
            this.groupBoxPeriodType.Name = "groupBoxPeriodType";
            this.groupBoxPeriodType.Size = new System.Drawing.Size(108, 64);
            this.groupBoxPeriodType.TabIndex = 20;
            this.groupBoxPeriodType.TabStop = false;
            this.groupBoxPeriodType.Text = "Period Type";
            this.toolTip.SetToolTip(this.groupBoxPeriodType, "Choose to display either in Years or Periods.\r\nPeriods = (No. of Years) x (Period" +
                    "s per Year).\r\nAmortization section also uses this value for \r\ncalculations.");
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
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.Location = new System.Drawing.Point(33, 64);
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
            this.textBoxN.Location = new System.Drawing.Point(233, 124);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(121, 21);
            this.textBoxN.TabIndex = 22;
            this.toolTip.SetToolTip(this.textBoxN, "Total length of the loan or mortgage\r\nin number of years or periods.\r\nDepends on " +
                    "Period Type.");
            this.textBoxN.SelectionChangeCommitted += new System.EventHandler(this.textBoxN_SelectionChangeCommitted);
            this.textBoxN.GotFocus += new System.EventHandler(this.textBoxN_GotFocus);
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
            this.groupBoxAmort.Location = new System.Drawing.Point(38, 437);
            this.groupBoxAmort.Name = "groupBoxAmort";
            this.groupBoxAmort.Size = new System.Drawing.Size(533, 91);
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
            this.maskedTextBoxBalance.TabIndex = 9;
            this.maskedTextBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.maskedTextBoxBalance, "Ending balance\r\nat the end of \r\nspecified period.\r\nPrincipal amount left.");
            // 
            // maskedTextBoxInterest
            // 
            this.maskedTextBoxInterest.Location = new System.Drawing.Point(293, 48);
            this.maskedTextBoxInterest.Name = "maskedTextBoxInterest";
            this.maskedTextBoxInterest.ReadOnly = true;
            this.maskedTextBoxInterest.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxInterest.TabIndex = 8;
            this.maskedTextBoxInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.maskedTextBoxInterest, "Total interest paid");
            // 
            // maskedTextBoxPrincipal
            // 
            this.maskedTextBoxPrincipal.Location = new System.Drawing.Point(170, 50);
            this.maskedTextBoxPrincipal.Name = "maskedTextBoxPrincipal";
            this.maskedTextBoxPrincipal.ReadOnly = true;
            this.maskedTextBoxPrincipal.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPrincipal.TabIndex = 7;
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
            this.numericUpDownTo.TabIndex = 3;
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
            this.numericUpDownFrom.TabIndex = 2;
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
            // FormTVM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 562);
            this.Controls.Add(this.groupBoxAmort);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.groupBoxPeriodType);
            this.Controls.Add(this.groupBoxPP);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonFV);
            this.Controls.Add(this.buttonPMT);
            this.Controls.Add(this.buttonPV);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxI);
            this.Controls.Add(this.textBoxFV);
            this.Controls.Add(this.textBoxPMT);
            this.Controls.Add(this.textBoxPV);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lblFV);
            this.Controls.Add(this.lblPMT);
            this.Controls.Add(this.lblPV);
            this.Controls.Add(this.lblN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTVM";
            this.Load += new System.EventHandler(this.FormTVM_Load);
            this.Controls.SetChildIndex(this.lblN, 0);
            this.Controls.SetChildIndex(this.lblPV, 0);
            this.Controls.SetChildIndex(this.lblPMT, 0);
            this.Controls.SetChildIndex(this.lblFV, 0);
            this.Controls.SetChildIndex(this.lblI, 0);
            this.Controls.SetChildIndex(this.lblP, 0);
            this.Controls.SetChildIndex(this.textBoxPV, 0);
            this.Controls.SetChildIndex(this.textBoxPMT, 0);
            this.Controls.SetChildIndex(this.textBoxFV, 0);
            this.Controls.SetChildIndex(this.textBoxI, 0);
            this.Controls.SetChildIndex(this.textBoxP, 0);
            this.Controls.SetChildIndex(this.buttonN, 0);
            this.Controls.SetChildIndex(this.buttonPV, 0);
            this.Controls.SetChildIndex(this.buttonPMT, 0);
            this.Controls.SetChildIndex(this.buttonFV, 0);
            this.Controls.SetChildIndex(this.buttonI, 0);
            this.Controls.SetChildIndex(this.groupBoxPP, 0);
            this.Controls.SetChildIndex(this.groupBoxPeriodType, 0);
            this.Controls.SetChildIndex(this.labelHeading, 0);
            this.Controls.SetChildIndex(this.textBoxN, 0);
            this.Controls.SetChildIndex(this.groupBoxAmort, 0);
            this.groupBoxPP.ResumeLayout(false);
            this.groupBoxPP.PerformLayout();
            this.groupBoxPeriodType.ResumeLayout(false);
            this.groupBoxPeriodType.PerformLayout();
            this.groupBoxAmort.ResumeLayout(false);
            this.groupBoxAmort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}