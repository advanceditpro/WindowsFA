using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Globalization;
using System.Threading;
using System.Collections.Specialized;
using System.IO;
using System.Xml;

namespace WindowsFA
{
    public partial class FormPE : WindowsFA.FormFA
    {
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        Boolean xmlHasChanged = false;

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPE));
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Timer indexTimer;
//        private System.Windows.Forms.Panel animationCanvas;

        string xmlFilename = "";
        string xmloutput = "";

        bool isAnimating = false;
        bool isFirstTime = true;
        int animCanvasWidth;
        int animCanvasHeight;

        Image imageCelPanel_left;
        Image imageCelPanel_right;

        Image imageCelPanel_bear_left;
        Image imageCelPanel_bear_right;

        Sprite[] spriteArray;
        Sprite[] spriteArrayBackup;
        Screen screen;

        Rectangle r;      

        private PriceEarning pe1 = new PriceEarning();
        private PriceEarning peQuoted = new PriceEarning();
        private StringCollection symbolHistory = new StringCollection();
        int currentSymbolHistoryIndex;
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
        public FormPE()
        {
            InitializeComponent();
            this.numericUpDownYield.Enabled = false;
            setformTitle("Price Earning Analysis - FA");
            this.Text = formTitle;

            //this.openToolStripButton.Visible = false;
            //this.saveToolStripButton.Visible = false;
            
            //this.openToolStripMenuItem.Visible = false;
            //this.toolStripSeparator3.Visible = false;
            //this.saveToolStripMenuItem.Visible = false;
            //this.saveAsToolStripMenuItem.Visible = false;

            this.components = new System.ComponentModel.Container();
//            this.animationCanvas = new System.Windows.Forms.Panel();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.indexTimer = new System.Windows.Forms.Timer(this.components);
            animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            indexTimer.Tick += new EventHandler(indexTimer_Tick);
            Random random = new Random();
            indexTimer.Interval = 20000 + random.Next(500, 5000); ;
            indexTimer.Enabled = true;
            r = new Rectangle(0, 0, animationCanvas.Width, animationCanvas.Height);
            animCanvasWidth = r.Width-5;
            animCanvasHeight = r.Height-2;

            StartAnimation();

            }


        private void StartAnimation()
        {
            // Load images for animation.
            try
            {
                /*
                string path = Directory.GetCurrentDirectory() + "\\redbull_tiny_to_left.gif";
                imageCelPanel_left = Image.FromFile(path);
                path = Directory.GetCurrentDirectory() + "\\redbull_tiny_to_right.gif";
                //MessageBox.Show(path);
                imageCelPanel_right = Image.FromFile(path);
                */
                imageCelPanel_left = ((System.Drawing.Image)(resources.GetObject("redbull_tiny_to_left")));
                imageCelPanel_right = ((System.Drawing.Image)(resources.GetObject("redbull_tiny_to_right")));
                imageCelPanel_bear_left = ((System.Drawing.Image)(resources.GetObject("bear_tiny_to_left")));
                imageCelPanel_bear_right = ((System.Drawing.Image)(resources.GetObject("bear_tiny_to_right")));

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Image file not found." );
            }
            if(isAnimating == false)
            {
            if (isFirstTime == true)
            {
                // Class for doing actual drawing, along with offscreen.
                screen = new Screen(animationCanvas, r, System.Windows.Forms.Panel.DefaultBackColor, System.Windows.Forms.Panel.DefaultBackColor);
                isFirstTime = false;
            }

            if (screen == null || imageCelPanel_left == null || imageCelPanel_right == null)
            {
                MessageBox.Show("Animation not initialized!");
                return;
            }
            isAnimating = true;  

            int numSprites = 4 ;

            // Bigger values = shorter delays.
            int delayMS = 75 ;

            //-------------------------------------------------------------
            // Create requested # of sprites.
            //-------------------------------------------------------------
            spriteArray = new Sprite[numSprites];
            spriteArrayBackup = new Sprite[numSprites];

//            for (int i = 0; i < numSprites; i++)
            {
                spriteArray[0] = new Sprite(imageCelPanel_left,
                                           1, 60, 50, 1,
                                           animCanvasWidth,
                                           animCanvasHeight);
                spriteArray[0].makeNewCoordinates();
                spriteArray[1] = new Sprite(imageCelPanel_right,
                                           1, 60, 50, 1,
                                           animCanvasWidth,
                                           animCanvasHeight);
                spriteArray[1].makeNewCoordinates();
                spriteArray[2] = new Sprite(imageCelPanel_bear_left,
                                           1, 60, 50, 1,
                                           animCanvasWidth,
                                           animCanvasHeight);
                spriteArray[2].makeNewCoordinates();
                spriteArray[3] = new Sprite(imageCelPanel_bear_right,
                                           1, 60, 50, 1,
                                           animCanvasWidth,
                                           animCanvasHeight);
                spriteArray[3].makeNewCoordinates();
                for (int i = 0; i < numSprites; i++)
                {
                    spriteArrayBackup[i]=spriteArray[i];
                }

            }
            //-------------------------------------------------------------
            // Start our thread.
            animationTimer.Interval = delayMS;
            animationTimer.Enabled = true;
            }
            else
            {
            // Stop animation.
            isAnimating = false;
            // (This kills animation thread in Timer method.)
            // This will also reset Start/Stop button to "Start."
            }

        }

        private void recalcThreaded()
        {
            try
            {
                this.toolStripStatusLabel1.Text = "Retrieving quote...";
                Cursor = Cursors.WaitCursor;
//                Thread t = new Thread(recalc);
                if (this.backgroundWorker1.CancellationPending)
                { return; }
                if (this.backgroundWorker1.IsBusy)
                { this.backgroundWorker1.CancelAsync(); this.backgroundWorker1.RunWorkerAsync(); }
                else {this.backgroundWorker1.RunWorkerAsync();}
//                t.Start();
            }
            catch (InvalidOperationException)
            {
                this.toolStripStatusLabel1.Text = "Busy retrieving quote...";
                
            }
        
        }

        private void recalc() 
        {
            try
            {
                pe1.setSymbol(maskedTextBoxSymbol.Text.Trim());
                try
                {
                    if (Program.cApp.QuoteSourceIndex == 0)
                    {
                        pe1.GetQuotesYahoo();
                    }
                    if (Program.cApp.QuoteSourceIndex == 1)
                    {
                        pe1.GetQuotesGoogle();
                    }
                }
                catch (System.IO.FileNotFoundException)
                {
                    pe1.GetQuotesYahoo();
                }
                if (!symbolHistory.Contains(pe1.getSymbol()))
                {
                    symbolHistory.Add(pe1.getSymbol());
                    currentSymbolHistoryIndex = symbolHistory.Count - 1;
                    xmlHasChanged = true;
                }
                //recalc1();
                //backupPE();
                //calcPriceChange();
                //maskedTextBoxSymbol.SelectAll();
            }
            catch (WebException)
            {
                MessageBox.Show("Could not retrieve the quote.", "Internet error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid value returned.\nPlease contact support.", "Invalid value error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(maskedTextBoxSymbol.Text + " is not a valid ticker symbol.\nTry with valid symbol.", "Invalid ticker symbol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //Cursor = Cursors.Default;
            //maskedTextBoxSymbol.SelectAll();
        }
        private void recalc1()
        {
            try
            {
                numericUpDownEPS.Value = (decimal)pe1.getEPS("calc");
                numericUpDownPE.Value = (decimal)pe1.getPE("calc");
                numericUpDownPrice.Value = (decimal)pe1.getPrice();
                numericUpDownYield.Value = (decimal)(100 * pe1.getYield("calc"));
                //            nfi.CurrencyDecimalDigits = 0;
                //            maskedTextBoxMarketCap.Text = pe1.getMarketCap().ToString("C", nfi);
                maskedTextBoxMarketCap.Text = pe1.getMarketCapstr();
                maskedTextBoxCompanyName.Text = pe1.getCompanyName();
                refreshBackForward();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private void refreshBackForward()
        {
            if (symbolHistory.Count > 1 && currentSymbolHistoryIndex > 0)
            {
                buttonBack.Enabled = true;
            }
            else
            {
                buttonBack.Enabled = false;
            }
            if (symbolHistory.Count > 1 && currentSymbolHistoryIndex < symbolHistory.Count - 1)
            {
                buttonForward.Enabled = true;
            }
            else
            {
                buttonForward.Enabled = false;
            }
            if (symbolHistory.Count > 0)
            {
                comboBoxBack.Enabled = true;
                comboBoxBack.Items.Clear();
                comboBoxBack.Items.AddRange(new object[] { });
                for (int i = 0; i < symbolHistory.Count; i++)
                {
                    comboBoxBack.Items.Add(symbolHistory[i].ToString());
                }
            }
            else
            {
                comboBoxBack.Enabled = false;
            }
        }

        private void calcPriceChange()
        {
            double dPriceChange;
            double dPriceChangePercent;
            string strPriceChange;
            string strPriceChangePercent;
            dPriceChange = (Math.Round(pe1.getPrice() - peQuoted.getPrice(), 2));
            dPriceChangePercent = ((pe1.getPrice() - peQuoted.getPrice()) / peQuoted.getPrice());
            strPriceChange = (dPriceChange).ToString("C", nfi);
            strPriceChangePercent = (dPriceChangePercent).ToString("P", nfi);
            maskedTextBoxPriceChange.Text = strPriceChange;
            maskedTextBoxPriceChangePercent.Text = strPriceChangePercent;
            if (dPriceChange < 0.0)
            {
                maskedTextBoxPriceChange.BackColor = Color.Orange;
                maskedTextBoxPriceChangePercent.BackColor = Color.Orange;
            }
            else if (dPriceChange > 0.0)
            {
                maskedTextBoxPriceChange.BackColor = Color.LawnGreen;
                maskedTextBoxPriceChangePercent.BackColor = Color.LawnGreen;
            }
            else
            {
                maskedTextBoxPriceChange.BackColor = System.Windows.Forms.MaskedTextBox.DefaultBackColor;
                maskedTextBoxPriceChangePercent.BackColor = System.Windows.Forms.MaskedTextBox.DefaultBackColor;
            }

        } //calcPriceChange

        private void refreshIndex()
        {
            try
            {
                this.toolStripStatusLabel1.Text = "Retrieving market indices...";
                Cursor = Cursors.WaitCursor;
                if (this.backgroundWorker2.CancellationPending)
                { return; }
                if (this.backgroundWorker2.IsBusy)
                { this.backgroundWorker2.CancelAsync(); this.backgroundWorker2.RunWorkerAsync(); }
                else { this.backgroundWorker2.RunWorkerAsync(); }
            }
            catch (InvalidOperationException)
            {
                this.toolStripStatusLabel1.Text = "Busy getting market indices...";

            }
        }

        private void calcPriceOpenChange()
        {
            double dPriceChange;
            double dPriceChangePercent;
            string strPriceChange;
            string strPriceChangePercent;
            dPriceChange = (Math.Round(pe1.getPrice() - pe1.getPriceOpen(), 2));
            dPriceChangePercent = ((pe1.getPrice() - pe1.getPriceOpen()) / pe1.getPrice());
            strPriceChange = (dPriceChange).ToString("C", nfi);
            strPriceChangePercent = (dPriceChangePercent).ToString("P", nfi);
            maskedTextBoxPriceOpen.Text = pe1.getPriceOpen().ToString("C", nfi);
            maskedTextBoxPriceChangeMarket.Text = strPriceChange;
            maskedTextBoxPriceChangeMarketPercent.Text = strPriceChangePercent;
            if (dPriceChange < 0.0)
            {
                maskedTextBoxPriceChangeMarketPercent.BackColor = Color.Orange;
                maskedTextBoxPriceChangeMarket.BackColor = Color.Orange;
                spriteArray[0] = spriteArrayBackup[2];
                spriteArray[1] = spriteArrayBackup[3];
            }
            else if (dPriceChange > 0.0)
            {
                maskedTextBoxPriceChangeMarketPercent.BackColor = Color.LawnGreen;
                maskedTextBoxPriceChangeMarket.BackColor = Color.LawnGreen;
                spriteArray[2] = spriteArrayBackup[0];
                spriteArray[3] = spriteArrayBackup[1];
            }
            else
            {
                maskedTextBoxPriceChangeMarketPercent.BackColor = System.Windows.Forms.MaskedTextBox.DefaultBackColor;
                maskedTextBoxPriceChangeMarket.BackColor = System.Windows.Forms.MaskedTextBox.DefaultBackColor;
            }

        }

        private void negEPSMessageBox()
        {
            toolStripStatusLabel1.Text = "EPS is negative. Therefore, P/E is invalid.";
            MessageBox.Show("Either EPS or P/E ratio is out of range.\n" +
                        "Cannot calculate Price, or P/E ratio based on negative EPS(earnings per share).\n" +
                        "P/E was temporarily set to negative value.", "Negative EPS error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void backupPE()
        {
            peQuoted.setSymbol(pe1.getSymbol());
            peQuoted.setPrice(pe1.getPrice());
            peQuoted.setEPS(pe1.getEPS());
            peQuoted.setPE(pe1.getPE());
            peQuoted.setYield(pe1.getYield());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentSymbolHistoryIndex > 0)
            {
                currentSymbolHistoryIndex = currentSymbolHistoryIndex - 1;
            }
            maskedTextBoxSymbol.Text=symbolHistory[currentSymbolHistoryIndex].ToString();
            recalcThreaded();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (currentSymbolHistoryIndex < symbolHistory.Count)
            {
                currentSymbolHistoryIndex = currentSymbolHistoryIndex + 1;
            }
            try
            {
                maskedTextBoxSymbol.Text = symbolHistory[currentSymbolHistoryIndex].ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                currentSymbolHistoryIndex = symbolHistory.Count-1;
                maskedTextBoxSymbol.Text = symbolHistory[currentSymbolHistoryIndex].ToString();
            }
            recalcThreaded();

        }
        protected void indexTimer_Tick(object sender, EventArgs e)
        {
            refreshIndex();
        }

        protected void animationTimer_Tick(object sender, System.EventArgs e)
        {
            // Using a timer here for animation
            // (not a separate thread as in Java.
            // Run animation.
            if (isAnimating == true)
            {
                //-------------------------------------
                // Do animation work.
                //-------------------------------------
                // Draw offscreen.      
                Graphics g = screen.getGraphics();

                // Display and move every Sprite object.

                // Sort array first -- This allows smaller (= more distant) 
                // objects to be drawn first.
                if (spriteArray.Length > 1)
                    Sprite.sortArrayByZOrder(spriteArray);

                // Erase and redraw objects off-screen.
                screen.erase();

                // Draw each object.
                for (int i = 0; i < spriteArray.Length; i++)
                {
                    spriteArray[i].draw(g);
                    spriteArray[i].calcNextCoordinates();
                }

                // Now 'flip' screen -- copy offscreen content to visible screen.
                screen.flip();

            }
            else
            {
                // To-here, we're cleaning-up animation.
                // Change button to 'Start' for next run.
                animationTimer.Enabled = false;
            }
        }


        public override void SaveXml(bool confirm)
        {
            if (xmlHasChanged)
            {
                if (confirm)
                {
                    if (MessageBox.Show("Do you want to save the changes you made to your worksheet?", "Finance Advisor - Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }
                }
                if (xmlFilename == "")
                {
                    mainSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    mainSaveFileDialog.Filter = "Quote List Files (*.quo)|*.quo|TVM Files (*.tvm)|*.tvm|CFLO Files (*.cfo)|*.cfo|All Files (*.*)|*.*";
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
                            <PE>
                                <Symbol id="0">YHOO</Symbol>
                                <Symbol id="1">MSFT</Symbol>
                            </PE>
                        </FA>                       
                        */
                        // Write XML data.
                        writer.WriteStartElement("FA");
                        writer.WriteStartElement("PE");
                        for (int i = 0; i < symbolHistory.Count; i++)
                        {
                            writer.WriteStartElement("Symbol");
                            string id = i.ToString();
                            writer.WriteAttributeString("id", id);
                            writer.WriteString(symbolHistory[i].ToString());
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement(); //PE
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
            openFileDialog.Filter = "Quote List Files (*.quo)|*.quo|TVM Files (*.tvm)|*.tvm|CFLO Files (*.cfo)|*.cfo|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    xmlFilename = openFileDialog.FileName;
                    xmlHasChanged = true;
                    doc.Load(xmlFilename);
                    XmlNode root = doc.DocumentElement;
                    XmlNodeList fa_pe_symbol = doc.GetElementsByTagName("Symbol");
                    symbolHistory.Clear();
                    for (int i=0; i < fa_pe_symbol.Count; i++)
                    {
                        if (symbolHistory.Count <= i)
                        {
                            symbolHistory.Add(fa_pe_symbol[i].InnerText);
                        }
                        else
                        {
                            symbolHistory[i] = fa_pe_symbol[i].InnerText;
                        }
                    }
                    /*
                     * Sample document
                     * 
                    <?xml version="1.0" encoding="utf-16"?>
                    <FA>
                            <PE>
                                <Symbol id="0">YHOO</Symbol>
                                <Symbol id="1">MSFT</Symbol>
                            </PE>
                    </FA>                       
                    */
                    this.Text = formTitle + " - " + xmlFilename;
                    xmlHasChanged = false;
                    refreshBackForward();
                }
                catch (XmlException)
                {
                    MessageBox.Show("Invalid file.\nThe file you have opened is not valid for this application.", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Incomplete file.\nThe file you have opened is not valid for this application.", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //catch (ArgumentOutOfRangeException)
                //{
                //    MessageBox.Show("Value is out of range.\nThe file you have opened is not valid for this application.", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

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
            Configuration.Serialize("config.xml", Program.cApp);
            Application.Exit();
        }




    }
}

