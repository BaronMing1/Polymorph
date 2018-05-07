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
    public partial class frmRichTextBox : Form
    {
        public frmRichTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            while (richTextBox1.Text.IndexOf("hi", startIndex) > -1)
            {
                richTextBox1.Select(richTextBox1.Text.IndexOf("hi", startIndex), "hi".Length);
                richTextBox1.SelectionColor = Color.Red;
                startIndex = richTextBox1.Text.IndexOf("hi", startIndex)+1;
            }

        }
    }
}
