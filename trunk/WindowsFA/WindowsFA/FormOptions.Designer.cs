namespace WindowsFA
{
    partial class FormOptions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxStartup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxProxy = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxURL = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonProxy = new System.Windows.Forms.RadioButton();
            this.radioButtonDirect = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.radioButtonGoogle = new System.Windows.Forms.RadioButton();
            this.radioButtonYahoo = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxStartup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxProxy.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBoxSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage0);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.pictureBox2);
            this.tabPage0.Controls.Add(this.groupBoxStartup);
            this.tabPage0.Location = new System.Drawing.Point(4, 22);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage0.Size = new System.Drawing.Size(494, 298);
            this.tabPage0.TabIndex = 1;
            this.tabPage0.Text = "General";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFA.Properties.Resources.document;
            this.pictureBox2.Location = new System.Drawing.Point(28, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBoxStartup
            // 
            this.groupBoxStartup.Controls.Add(this.label1);
            this.groupBoxStartup.Controls.Add(this.radioButton3);
            this.groupBoxStartup.Controls.Add(this.radioButton2);
            this.groupBoxStartup.Controls.Add(this.radioButton1);
            this.groupBoxStartup.Location = new System.Drawing.Point(28, 60);
            this.groupBoxStartup.Name = "groupBoxStartup";
            this.groupBoxStartup.Size = new System.Drawing.Size(273, 215);
            this.groupBoxStartup.TabIndex = 0;
            this.groupBoxStartup.TabStop = false;
            this.groupBoxStartup.Text = "Startup Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Change will take effect when you \r\nrestart the application.";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(37, 118);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "P/E Analyzer";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(37, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(170, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Uneven Cash Flow Worksheet";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(37, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(168, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Loan and Mortgage Calculator";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBoxProxy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Network";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFA.Properties.Resources.internet;
            this.pictureBox1.Location = new System.Drawing.Point(30, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxProxy
            // 
            this.groupBoxProxy.Controls.Add(this.maskedTextBoxURL);
            this.groupBoxProxy.Controls.Add(this.radioButtonProxy);
            this.groupBoxProxy.Controls.Add(this.radioButtonDirect);
            this.groupBoxProxy.Location = new System.Drawing.Point(30, 64);
            this.groupBoxProxy.Name = "groupBoxProxy";
            this.groupBoxProxy.Size = new System.Drawing.Size(436, 199);
            this.groupBoxProxy.TabIndex = 0;
            this.groupBoxProxy.TabStop = false;
            this.groupBoxProxy.Text = "Configure Proxies to Access Internet";
            // 
            // maskedTextBoxURL
            // 
            this.maskedTextBoxURL.Location = new System.Drawing.Point(61, 130);
            this.maskedTextBoxURL.Name = "maskedTextBoxURL";
            this.maskedTextBoxURL.Size = new System.Drawing.Size(326, 20);
            this.maskedTextBoxURL.TabIndex = 2;
            // 
            // radioButtonProxy
            // 
            this.radioButtonProxy.AutoSize = true;
            this.radioButtonProxy.Location = new System.Drawing.Point(40, 107);
            this.radioButtonProxy.Name = "radioButtonProxy";
            this.radioButtonProxy.Size = new System.Drawing.Size(164, 17);
            this.radioButtonProxy.TabIndex = 1;
            this.radioButtonProxy.TabStop = true;
            this.radioButtonProxy.Text = "Automatic configuration URL:";
            this.radioButtonProxy.UseVisualStyleBackColor = true;
            this.radioButtonProxy.CheckedChanged += new System.EventHandler(this.radioButtonProxy_CheckedChanged);
            // 
            // radioButtonDirect
            // 
            this.radioButtonDirect.AutoSize = true;
            this.radioButtonDirect.Location = new System.Drawing.Point(40, 42);
            this.radioButtonDirect.Name = "radioButtonDirect";
            this.radioButtonDirect.Size = new System.Drawing.Size(347, 17);
            this.radioButtonDirect.TabIndex = 0;
            this.radioButtonDirect.TabStop = true;
            this.radioButtonDirect.Text = "Direct connection to the Internet or use default browser proxy setting";
            this.radioButtonDirect.UseVisualStyleBackColor = true;
            this.radioButtonDirect.CheckedChanged += new System.EventHandler(this.radioButtonDirect_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.groupBoxSource);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(494, 298);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Quote Source";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFA.Properties.Resources.info;
            this.pictureBox3.Location = new System.Drawing.Point(34, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // groupBoxSource
            // 
            this.groupBoxSource.Controls.Add(this.radioButtonGoogle);
            this.groupBoxSource.Controls.Add(this.radioButtonYahoo);
            this.groupBoxSource.Location = new System.Drawing.Point(34, 70);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(141, 121);
            this.groupBoxSource.TabIndex = 22;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "Quote Source";
            // 
            // radioButtonGoogle
            // 
            this.radioButtonGoogle.AutoSize = true;
            this.radioButtonGoogle.Location = new System.Drawing.Point(9, 80);
            this.radioButtonGoogle.Name = "radioButtonGoogle";
            this.radioButtonGoogle.Size = new System.Drawing.Size(100, 17);
            this.radioButtonGoogle.TabIndex = 1;
            this.radioButtonGoogle.TabStop = true;
            this.radioButtonGoogle.Text = "Google Finance";
            this.radioButtonGoogle.UseVisualStyleBackColor = true;
            // 
            // radioButtonYahoo
            // 
            this.radioButtonYahoo.AutoSize = true;
            this.radioButtonYahoo.Location = new System.Drawing.Point(9, 32);
            this.radioButtonYahoo.Name = "radioButtonYahoo";
            this.radioButtonYahoo.Size = new System.Drawing.Size(97, 17);
            this.radioButtonYahoo.TabIndex = 0;
            this.radioButtonYahoo.TabStop = true;
            this.radioButtonYahoo.Text = "Yahoo Finance";
            this.radioButtonYahoo.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(298, 342);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(135, 342);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 390);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.tabControl1.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxStartup.ResumeLayout(false);
            this.groupBoxStartup.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxProxy.ResumeLayout(false);
            this.groupBoxProxy.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBoxSource.ResumeLayout(false);
            this.groupBoxSource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxProxy;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxURL;
        private System.Windows.Forms.RadioButton radioButtonProxy;
        private System.Windows.Forms.RadioButton radioButtonDirect;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxStartup;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxSource;
        private System.Windows.Forms.RadioButton radioButtonGoogle;
        private System.Windows.Forms.RadioButton radioButtonYahoo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}