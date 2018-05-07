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
    public partial class frmPolymorph : Form
    {
        public frmPolymorph()
        {
            InitializeComponent();
        }

        private void cboQUI_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cboQUI.SelectedIndex;
            List<cBaseFonctions> myList = new List<cBaseFonctions>
            {
                new cDeriveAnthony(),
                new cDeriveHugo(),
                new cDeriverMario()

            };

            cBaseFonctions objBaseFonction = myList[ind];

            objBaseFonction.humanModifier();
            lblInfo.Text = objBaseFonction.phrase;
        }

        private void cboPoussin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cboPoussin.SelectedIndex;
            List<cEggs> myList = new List<cEggs>
            {
                new cSerpent(),
                new cPoule(),

            };
            
            cEggs objBaseFonction = myList[ind];

            //objBaseFonction.Information(txtTypeAnimal.Text, txtTypePoil.Text, txtDeplacement.Text, txtIncubation.Text, txtNourriture.Text, txtFamille.Text);
            
            objBaseFonction.Information();
            lblPoussinInfo.Text = objBaseFonction.Phrase;
            //cPoule MaPoule = new cPoule();

        }
    }
}
