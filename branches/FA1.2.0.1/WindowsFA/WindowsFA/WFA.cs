using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;
using System.Xml;

namespace WindowsFA
{
    public partial class WFA : Form
    {
        private int childFormNumber = 0;
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();

        public WFA()
        {
            InitializeComponent();
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

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "TVM Files (*.tvm)|*.tvm|CFLO Files (*.cfo)|*.cfo|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                doc.Load(FileName);
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "TVM Files (*.tvm)|*.tvm|CFLO Files (*.cfo)|*.cfo|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                doc.Save(FileName);
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
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
            childForm.MdiParent = this;
            childForm.Text = "Time Value of Money " + childFormNumber++;
            childForm.Show();
        }

        private void cFLOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new FormCFLO();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Cash Flow " + childFormNumber++;
            childForm.Show();

        }
        private void tVMMortgageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new FormTVMMortgage();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Mortgage Payment Calculator " + childFormNumber++;
            childForm.Show();

        }

        private void WFA_Load(object sender, EventArgs e)
        {

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

    }
}
