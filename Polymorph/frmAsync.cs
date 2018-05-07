using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Polymorph
{
    public partial class frmAsync : Form
    {
        public frmAsync()
        {
            InitializeComponent();
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {

            lblAsync.Text = "Patient les 'programmeurs', nous traitons vos caprices";
            int start = 0;
            int stop = 18;

            progressBar1.Maximum = stop;
            progressBar1.Minimum = start;
            progressBar1.Step = 1;

            while (start < stop) {
                string mot =await myRunTask("Tout le monde");
                progressBar1.Value +=1;
                
                lblAsync.Text += mot;
                start++;

            }

        }



        private Task<string> myRunTask(string message) {
            return Task.Run<string>(() => myThreadSleep(message));
        }

        private string myThreadSleep(string message) {
            Thread.Sleep(500);
            return "Bonjour" + message + Environment.NewLine;
        }

        private void frmAsync_Load(object sender, EventArgs e)
        {

        }
    }
}
