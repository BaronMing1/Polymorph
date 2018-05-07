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
    public partial class frmEnum : Form
    {
        public frmEnum()
        {
            InitializeComponent();
        }

        enum salary {
            Fred = 31,
            Mario = 9,
            Anthony = 15,
            Junior = 21,
            Stephane = 51,
            Hugo = 27
        }
        private void frmEnum_Load(object sender, EventArgs e)
        {
            var tempSort = Enum.GetNames(typeof(salary));
            tempSort = tempSort.OrderBy(variableBidon => variableBidon.ToString()).ToArray();
            cboEnum.DataSource = tempSort;
        }

        private void cboEnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text = cboEnum.Text;
            int mySalary = (int)Enum.Parse(typeof(salary), cboEnum.SelectedItem.ToString());
            string mySalary2 = $"Le Salaire de {cboEnum.SelectedItem} est de {mySalary} de l'heure";
            lblSalary.Text = "Mon salaire est : " + mySalary.ToString();
            lblSalary.Text = mySalary2;
        }
    }
}
