using System;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
namespace WindowsFA
{
    partial class FormPE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPE));
            this.groupBoxPE = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.comboBoxBack = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxPriceChangeMarketPercent = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPriceChangeMarket = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPriceOpen = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.animationCanvas = new System.Windows.Forms.Panel();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelQuoteDelayed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxPriceChangePercent = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPriceChange = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMarketCap = new System.Windows.Forms.MaskedTextBox();
            this.labelMarket = new System.Windows.Forms.Label();
            this.maskedTextBoxCompanyName = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxPE = new System.Windows.Forms.CheckBox();
            this.checkBoxEPS = new System.Windows.Forms.CheckBox();
            this.checkBoxPrice = new System.Windows.Forms.CheckBox();
            this.buttonQuote = new System.Windows.Forms.Button();
            this.labelSymbol = new System.Windows.Forms.Label();
            this.maskedTextBoxSymbol = new System.Windows.Forms.MaskedTextBox();
            this.labelYield = new System.Windows.Forms.Label();
            this.numericUpDownYield = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPE = new System.Windows.Forms.NumericUpDown();
            this.labelPE = new System.Windows.Forms.Label();
            this.numericUpDownEPS = new System.Windows.Forms.NumericUpDown();
            this.labelEPS = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPE
            // 
            this.groupBoxPE.Controls.Add(this.webBrowser1);
            this.groupBoxPE.Controls.Add(this.comboBoxBack);
            this.groupBoxPE.Controls.Add(this.maskedTextBoxPriceChangeMarketPercent);
            this.groupBoxPE.Controls.Add(this.maskedTextBoxPriceChangeMarket);
            this.groupBoxPE.Controls.Add(this.maskedTextBoxPriceOpen);
            this.groupBoxPE.Controls.Add(this.label4);
            this.groupBoxPE.Controls.Add(this.label3);
            this.groupBoxPE.Controls.Add(this.animationCanvas);
            this.groupBoxPE.Controls.Add(this.buttonForward);
            this.groupBoxPE.Controls.Add(this.buttonBack);
            this.groupBoxPE.Controls.Add(this.pictureBox1);
            this.groupBoxPE.Controls.Add(this.labelQuoteDelayed);
            this.groupBoxPE.Controls.Add(this.label2);
            this.groupBoxPE.Controls.Add(this.maskedTextBoxPriceChangePercent);
            this.groupBoxPE.Controls.Add(this.maskedTextBoxPriceChange);
            this.groupBoxPE.Controls.Add(this.maskedTextBoxMarketCap);
            this.groupBoxPE.Controls.Add(this.labelMarket);
            this.groupBoxPE.Controls.Add(this.maskedTextBoxCompanyName);
            this.groupBoxPE.Controls.Add(this.checkBoxPE);
            this.groupBoxPE.Controls.Add(this.checkBoxEPS);
            this.groupBoxPE.Controls.Add(this.checkBoxPrice);
            this.groupBoxPE.Controls.Add(this.buttonQuote);
            this.groupBoxPE.Controls.Add(this.labelSymbol);
            this.groupBoxPE.Controls.Add(this.maskedTextBoxSymbol);
            this.groupBoxPE.Controls.Add(this.labelYield);
            this.groupBoxPE.Controls.Add(this.numericUpDownYield);
            this.groupBoxPE.Controls.Add(this.numericUpDownPE);
            this.groupBoxPE.Controls.Add(this.labelPE);
            this.groupBoxPE.Controls.Add(this.numericUpDownEPS);
            this.groupBoxPE.Controls.Add(this.labelEPS);
            this.groupBoxPE.Controls.Add(this.labelPrice);
            this.groupBoxPE.Controls.Add(this.numericUpDownPrice);
            this.groupBoxPE.Location = new System.Drawing.Point(27, 105);
            this.groupBoxPE.Name = "groupBoxPE";
            this.groupBoxPE.Size = new System.Drawing.Size(740, 425);
            this.groupBoxPE.TabIndex = 3;
            this.groupBoxPE.TabStop = false;
            this.groupBoxPE.Text = "P/E Analysis";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(464, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(270, 74);
            this.webBrowser1.TabIndex = 40;
            // 
            // comboBoxBack
            // 
            this.comboBoxBack.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxBack.DropDownWidth = 100;
            this.comboBoxBack.Enabled = false;
            this.comboBoxBack.FormattingEnabled = true;
            this.comboBoxBack.Location = new System.Drawing.Point(122, 58);
            this.comboBoxBack.Name = "comboBoxBack";
            this.comboBoxBack.Size = new System.Drawing.Size(19, 21);
            this.comboBoxBack.TabIndex = 39;
            this.comboBoxBack.SelectedIndexChanged += new System.EventHandler(this.comboBoxBack_SelectedIndexChanged);
            // 
            // maskedTextBoxPriceChangeMarketPercent
            // 
            this.maskedTextBoxPriceChangeMarketPercent.Location = new System.Drawing.Point(227, 183);
            this.maskedTextBoxPriceChangeMarketPercent.Name = "maskedTextBoxPriceChangeMarketPercent";
            this.maskedTextBoxPriceChangeMarketPercent.ReadOnly = true;
            this.maskedTextBoxPriceChangeMarketPercent.Size = new System.Drawing.Size(65, 20);
            this.maskedTextBoxPriceChangeMarketPercent.TabIndex = 38;
            this.maskedTextBoxPriceChangeMarketPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBoxPriceChangeMarket
            // 
            this.maskedTextBoxPriceChangeMarket.Location = new System.Drawing.Point(156, 183);
            this.maskedTextBoxPriceChangeMarket.Name = "maskedTextBoxPriceChangeMarket";
            this.maskedTextBoxPriceChangeMarket.ReadOnly = true;
            this.maskedTextBoxPriceChangeMarket.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxPriceChangeMarket.TabIndex = 37;
            this.maskedTextBoxPriceChangeMarket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBoxPriceOpen
            // 
            this.maskedTextBoxPriceOpen.Location = new System.Drawing.Point(371, 111);
            this.maskedTextBoxPriceOpen.Name = "maskedTextBoxPriceOpen";
            this.maskedTextBoxPriceOpen.ReadOnly = true;
            this.maskedTextBoxPriceOpen.Size = new System.Drawing.Size(86, 20);
            this.maskedTextBoxPriceOpen.TabIndex = 36;
            this.maskedTextBoxPriceOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Change (Market)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Open";
            // 
            // animationCanvas
            // 
            this.animationCanvas.Location = new System.Drawing.Point(326, 317);
            this.animationCanvas.Name = "animationCanvas";
            this.animationCanvas.Size = new System.Drawing.Size(364, 66);
            this.animationCanvas.TabIndex = 33;
            // 
            // buttonForward
            // 
            this.buttonForward.Enabled = false;
            this.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonForward.Image = ((System.Drawing.Image)(resources.GetObject("buttonForward.Image")));
            this.buttonForward.Location = new System.Drawing.Point(76, 39);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(40, 40);
            this.buttonForward.TabIndex = 23;
            this.toolTip.SetToolTip(this.buttonForward, "Retrive next quote");
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Enabled = false;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(30, 39);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 40);
            this.buttonBack.TabIndex = 22;
            this.toolTip.SetToolTip(this.buttonBack, "Retrieve previous quote");
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(30, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // labelQuoteDelayed
            // 
            this.labelQuoteDelayed.AutoSize = true;
            this.labelQuoteDelayed.Location = new System.Drawing.Point(52, 350);
            this.labelQuoteDelayed.Name = "labelQuoteDelayed";
            this.labelQuoteDelayed.Size = new System.Drawing.Size(336, 26);
            this.labelQuoteDelayed.TabIndex = 20;
            this.labelQuoteDelayed.Text = "Quotes delayed, except where indicated otherwise.\r\nEducational purpose only. Valu" +
                "es might not be up-to-date or accurate.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Change (by Analysis)";
            // 
            // maskedTextBoxPriceChangePercent
            // 
            this.maskedTextBoxPriceChangePercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxPriceChangePercent.Location = new System.Drawing.Point(227, 229);
            this.maskedTextBoxPriceChangePercent.Name = "maskedTextBoxPriceChangePercent";
            this.maskedTextBoxPriceChangePercent.ReadOnly = true;
            this.maskedTextBoxPriceChangePercent.Size = new System.Drawing.Size(65, 20);
            this.maskedTextBoxPriceChangePercent.TabIndex = 18;
            this.maskedTextBoxPriceChangePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.maskedTextBoxPriceChangePercent, "Percent change in stock price from the quoted or retrived amount.");
            // 
            // maskedTextBoxPriceChange
            // 
            this.maskedTextBoxPriceChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxPriceChange.Location = new System.Drawing.Point(156, 229);
            this.maskedTextBoxPriceChange.Name = "maskedTextBoxPriceChange";
            this.maskedTextBoxPriceChange.ReadOnly = true;
            this.maskedTextBoxPriceChange.Size = new System.Drawing.Size(65, 20);
            this.maskedTextBoxPriceChange.TabIndex = 17;
            this.maskedTextBoxPriceChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.maskedTextBoxPriceChange, "Change in stock price from the quoted or retrived price.");
            // 
            // maskedTextBoxMarketCap
            // 
            this.maskedTextBoxMarketCap.Location = new System.Drawing.Point(526, 111);
            this.maskedTextBoxMarketCap.Name = "maskedTextBoxMarketCap";
            this.maskedTextBoxMarketCap.ReadOnly = true;
            this.maskedTextBoxMarketCap.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxMarketCap.TabIndex = 16;
            this.maskedTextBoxMarketCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMarket
            // 
            this.labelMarket.AutoSize = true;
            this.labelMarket.Location = new System.Drawing.Point(524, 95);
            this.labelMarket.Name = "labelMarket";
            this.labelMarket.Size = new System.Drawing.Size(62, 13);
            this.labelMarket.TabIndex = 15;
            this.labelMarket.Text = "Market Cap";
            // 
            // maskedTextBoxCompanyName
            // 
            this.maskedTextBoxCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxCompanyName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCompanyName.Location = new System.Drawing.Point(30, 18);
            this.maskedTextBoxCompanyName.Name = "maskedTextBoxCompanyName";
            this.maskedTextBoxCompanyName.ReadOnly = true;
            this.maskedTextBoxCompanyName.Size = new System.Drawing.Size(460, 15);
            this.maskedTextBoxCompanyName.TabIndex = 14;
            this.maskedTextBoxCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxPE
            // 
            this.checkBoxPE.AutoSize = true;
            this.checkBoxPE.Location = new System.Drawing.Point(527, 208);
            this.checkBoxPE.Name = "checkBoxPE";
            this.checkBoxPE.Size = new System.Drawing.Size(51, 17);
            this.checkBoxPE.TabIndex = 12;
            this.checkBoxPE.Text = "Fixed";
            this.checkBoxPE.UseVisualStyleBackColor = true;
            this.checkBoxPE.CheckedChanged += new System.EventHandler(this.checkBoxPE_CheckedChanged);
            // 
            // checkBoxEPS
            // 
            this.checkBoxEPS.AutoSize = true;
            this.checkBoxEPS.Location = new System.Drawing.Point(337, 208);
            this.checkBoxEPS.Name = "checkBoxEPS";
            this.checkBoxEPS.Size = new System.Drawing.Size(51, 17);
            this.checkBoxEPS.TabIndex = 11;
            this.checkBoxEPS.Text = "Fixed";
            this.checkBoxEPS.UseVisualStyleBackColor = true;
            this.checkBoxEPS.CheckedChanged += new System.EventHandler(this.checkBoxEPS_CheckedChanged);
            // 
            // checkBoxPrice
            // 
            this.checkBoxPrice.AutoSize = true;
            this.checkBoxPrice.Location = new System.Drawing.Point(30, 209);
            this.checkBoxPrice.Name = "checkBoxPrice";
            this.checkBoxPrice.Size = new System.Drawing.Size(51, 17);
            this.checkBoxPrice.TabIndex = 10;
            this.checkBoxPrice.Text = "Fixed";
            this.checkBoxPrice.UseVisualStyleBackColor = true;
            this.checkBoxPrice.CheckedChanged += new System.EventHandler(this.checkBoxPrice_CheckedChanged);
            // 
            // buttonQuote
            // 
            this.buttonQuote.Location = new System.Drawing.Point(136, 127);
            this.buttonQuote.Name = "buttonQuote";
            this.buttonQuote.Size = new System.Drawing.Size(75, 23);
            this.buttonQuote.TabIndex = 1;
            this.buttonQuote.Text = "Retrieve";
            this.buttonQuote.UseVisualStyleBackColor = true;
            this.buttonQuote.Click += new System.EventHandler(this.buttonQuote_Click);
            // 
            // labelSymbol
            // 
            this.labelSymbol.AutoSize = true;
            this.labelSymbol.Location = new System.Drawing.Point(27, 111);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.Size = new System.Drawing.Size(41, 13);
            this.labelSymbol.TabIndex = 9;
            this.labelSymbol.Text = "Symbol";
            // 
            // maskedTextBoxSymbol
            // 
            this.maskedTextBoxSymbol.Location = new System.Drawing.Point(30, 127);
            this.maskedTextBoxSymbol.Name = "maskedTextBoxSymbol";
            this.maskedTextBoxSymbol.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSymbol.TabIndex = 0;
            this.maskedTextBoxSymbol.Text = "YHOO";
            this.maskedTextBoxSymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxSymbol_KeyPress);
            this.maskedTextBoxSymbol.GotFocus += new System.EventHandler(this.maskedTextBoxSymbol_GotFocus);
            // 
            // labelYield
            // 
            this.labelYield.AutoSize = true;
            this.labelYield.Location = new System.Drawing.Point(334, 275);
            this.labelYield.Name = "labelYield";
            this.labelYield.Size = new System.Drawing.Size(30, 13);
            this.labelYield.TabIndex = 7;
            this.labelYield.Text = "Yield";
            // 
            // numericUpDownYield
            // 
            this.numericUpDownYield.DecimalPlaces = 2;
            this.numericUpDownYield.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownYield.Location = new System.Drawing.Point(337, 291);
            this.numericUpDownYield.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownYield.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownYield.Name = "numericUpDownYield";
            this.numericUpDownYield.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYield.TabIndex = 5;
            this.numericUpDownYield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownYield.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.numericUpDownYield, "Yield based on P/E ratio.");
            // 
            // numericUpDownPE
            // 
            this.numericUpDownPE.DecimalPlaces = 2;
            this.numericUpDownPE.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPE.Location = new System.Drawing.Point(527, 183);
            this.numericUpDownPE.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPE.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownPE.Name = "numericUpDownPE";
            this.numericUpDownPE.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPE.TabIndex = 4;
            this.numericUpDownPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPE.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.numericUpDownPE, "Price/EPS or Price to Earning ratio.");
            this.numericUpDownPE.ValueChanged += new System.EventHandler(this.numericUpDownPE_ValueChanged);
            this.numericUpDownPE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownPE_KeyPress);
            // 
            // labelPE
            // 
            this.labelPE.AutoSize = true;
            this.labelPE.Location = new System.Drawing.Point(524, 167);
            this.labelPE.Name = "labelPE";
            this.labelPE.Size = new System.Drawing.Size(26, 13);
            this.labelPE.TabIndex = 4;
            this.labelPE.Text = "P/E";
            // 
            // numericUpDownEPS
            // 
            this.numericUpDownEPS.DecimalPlaces = 2;
            this.numericUpDownEPS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownEPS.Location = new System.Drawing.Point(337, 183);
            this.numericUpDownEPS.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownEPS.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownEPS.Name = "numericUpDownEPS";
            this.numericUpDownEPS.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEPS.TabIndex = 3;
            this.numericUpDownEPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownEPS.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.numericUpDownEPS, "Earnings per share.");
            this.numericUpDownEPS.ValueChanged += new System.EventHandler(this.numericUpDownEPS_ValueChanged);
            this.numericUpDownEPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownEPS_KeyPress);
            // 
            // labelEPS
            // 
            this.labelEPS.AutoSize = true;
            this.labelEPS.Location = new System.Drawing.Point(334, 167);
            this.labelEPS.Name = "labelEPS";
            this.labelEPS.Size = new System.Drawing.Size(28, 13);
            this.labelEPS.TabIndex = 2;
            this.labelEPS.Text = "EPS";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(27, 167);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownPrice.Location = new System.Drawing.Point(30, 183);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrice.TabIndex = 2;
            this.numericUpDownPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownPrice.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.numericUpDownPrice, "Stock price.");
            this.numericUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownPrice_ValueChanged);
            this.numericUpDownPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price Earning Analysis";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFA.Properties.Resources.check;
            this.pictureBox2.Location = new System.Drawing.Point(256, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // FormPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(790, 571);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxPE);
            this.Name = "FormPE";
            this.Controls.SetChildIndex(this.groupBoxPE, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.groupBoxPE.ResumeLayout(false);
            this.groupBoxPE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void comboBoxBack_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.maskedTextBoxSymbol.Text = comboBoxBack.SelectedItem.ToString();
            buttonQuote_Click(sender, e);
        }


        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            recalc();
        }
        void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            refreshIndex();
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            checkBoxEPS.Checked = cEPS;
            checkBoxPE.Checked = cPE;
            checkBoxPrice.Checked = cPrice;
            if (pe1.getEPS() < 0.0)
            {
                negEPSMessageBox();
                pe1.lockPrice(true);
                checkBoxPrice.Checked = true;
                numericUpDownPrice.ReadOnly = true;
            }
            recalc1();
            backupPE();
            calcPriceChange();
            calcPriceOpenChange();
            refreshIndex();
            maskedTextBoxSymbol.SelectAll();
            Cursor = Cursors.Default;
            this.toolStripStatusLabel1.Text = "Done.";

        }

        void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                webBrowser1.DocumentText = pe1.GetQuotesIndex();
                Cursor = Cursors.Default;
                this.toolStripStatusLabel1.Text = "Done.";
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                Cursor = Cursors.Default;
                this.toolStripStatusLabel1.Text = "Busy...";
            }
            catch (System.Net.WebException)
            {
                Cursor = Cursors.Default;
                this.toolStripStatusLabel1.Text = "Busy...";
            }
        }
        void numericUpDownPE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                numericUpDownPE_ValueChanged(sender, e);
            }
        }

        void numericUpDownPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                numericUpDownPrice_ValueChanged(sender, e);
            }
        }

        void numericUpDownEPS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                numericUpDownEPS_ValueChanged(sender, e);
            }
        }

        void maskedTextBoxSymbol_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                buttonQuote_Click(sender, e);
                //getQuote(sender, e);
            }
        }

        void checkBoxEPS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEPS.Checked)
            {
                pe1.lockEPS(true);
                numericUpDownEPS.ReadOnly = true;
            }
            else
            {
                pe1.lockEPS(false);
                numericUpDownEPS.ReadOnly = false;
            }
            calcPriceChange();
        }

        void checkBoxPE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPE.Checked)
            {
                pe1.lockPE(true);
                numericUpDownPE.ReadOnly = true;
                if (checkBoxPrice.Checked)
                {
                    pe1.lockPrice(true);
                    checkBoxPrice.Checked = false;
                }
            }
            else
            {
                pe1.lockPE(false);
                numericUpDownPE.ReadOnly = false;
            }
            calcPriceChange();
        }

        void checkBoxPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrice.Checked)
            {
                pe1.lockPrice(true);
                numericUpDownPrice.ReadOnly = true;
                if (checkBoxPE.Checked)
                {
                    pe1.lockPE(true);
                    checkBoxPE.Checked = false;
                }
            }
            else
            {
                pe1.lockPrice(false);
                numericUpDownPrice.ReadOnly = false;
            }
            calcPriceChange();
        }

        void numericUpDownPE_ValueChanged(object sender, EventArgs e)
        {
            pe1.setPE((Double)(numericUpDownPE.Value));
            recalc1();
            calcPriceChange();
        }

        void numericUpDownEPS_ValueChanged(object sender, EventArgs e)
        {
            pe1.setEPS((Double)(numericUpDownEPS.Value));
            recalc1();
            calcPriceChange();
        }

        void numericUpDownPrice_ValueChanged(object sender, System.EventArgs e)
        {
            pe1.setPrice((Double)(numericUpDownPrice.Value));
            recalc1();
            calcPriceChange();
        }


        void maskedTextBoxSymbol_GotFocus(object sender, System.EventArgs e)
        {
            maskedTextBoxSymbol.SelectAll();
        }

        //private void getQuote(object sender, System.EventArgs e)
        //{
        //    try
        //    {
        //        Thread t = new Thread(buttonQuote_Click(sender, e));
        //        t.Start(sender, e);
        //    }
        //    catch (TimeoutException)
        //    {
        //        MessageBox.Show("Time out.", "Time out", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void buttonQuote_Click(object sender, System.EventArgs e)
        {
            cEPS = checkBoxEPS.Checked;
            cPE = checkBoxPE.Checked;
            cPrice = checkBoxPrice.Checked;
            maskedTextBoxSymbol.Text = maskedTextBoxSymbol.Text.Trim().ToUpper();
            checkBoxEPS.Checked = false;
            checkBoxPE.Checked = false;
            checkBoxPrice.Checked = false;
            recalcThreaded();
        }


        #endregion

        private System.Windows.Forms.GroupBox groupBoxPE;
        private System.Windows.Forms.Label labelPE;
        private System.Windows.Forms.NumericUpDown numericUpDownEPS;
        private System.Windows.Forms.Label labelEPS;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPE;
        private System.Windows.Forms.Label labelYield;
        private System.Windows.Forms.NumericUpDown numericUpDownYield;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSymbol;
        private System.Windows.Forms.Label labelSymbol;
        private System.Windows.Forms.Button buttonQuote;
        private System.Windows.Forms.CheckBox checkBoxPrice;
        private System.Windows.Forms.CheckBox checkBoxPE;
        private System.Windows.Forms.CheckBox checkBoxEPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMarketCap;
        private System.Windows.Forms.Label labelMarket;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCompanyName;
        private MaskedTextBox maskedTextBoxPriceChange;
        private MaskedTextBox maskedTextBoxPriceChangePercent;
        private Label label2;
        private Label labelQuoteDelayed;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonForward;
        private Button buttonBack;
        private BackgroundWorker backgroundWorker1;
        private BackgroundWorker backgroundWorker2;
        private bool cEPS;
        private bool cPE;
        private bool cPrice;
        private Panel animationCanvas;
        private Label label4;
        private Label label3;
        private MaskedTextBox maskedTextBoxPriceChangeMarket;
        private MaskedTextBox maskedTextBoxPriceOpen;
        private MaskedTextBox maskedTextBoxPriceChangeMarketPercent;
        private ComboBox comboBoxBack;
        private WebBrowser webBrowser1;

    }
}
