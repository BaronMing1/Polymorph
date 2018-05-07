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
    public partial class frmContainer : Form
    {
        public frmContainer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Name);
        }

        private void BuildChild() {
            Form frmchil2, frmChild3;
            frmchil2 = new Child2();
            frmChild3 = new Child3();

            frmchil2.Text = "Enfant #2";
            frmChild3.Text = "Enfant #3";


            frmchil2.MdiParent = this;
            frmChild3.MdiParent = this;

            frmchil2.Show();
            frmChild3.Show();


        }

        private void frmContainer_Load(object sender, EventArgs e)
        {
            BuildChild();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
