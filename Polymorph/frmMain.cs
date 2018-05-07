using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorph
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void enumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnum nyEnum = new frmEnum();
            nyEnum.Show();
        }

        private void polymorphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPolymorph myPolyM = new frmPolymorph();
            myPolyM.Show();
        }

        private void formEnfantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContainer myContainer = new frmContainer();
            myContainer.Show();
        }

        private void asyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsync myAsync = new frmAsync();
            myAsync.Show();
        }

        private void richtextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRichTextBox myRich = new frmRichTextBox();
            myRich.Show();
        }
    }
}
