using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
namespace GDPR_analyze
{
    public partial class Audit_Procesator : UserControl
    {
        public Audit_Procesator()
        {
            InitializeComponent();
            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.ColorScheme = new ColorScheme(
                Primary.Orange100, Primary.Orange100, Primary.Orange100,
                Accent.Orange400, TextShade.WHITE
                );
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
          //test
        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Audit_Load(object sender, EventArgs e)
        {

        }

		private void pictureBox10_MouseHover(object sender, EventArgs e)
		{
			ToolTip ToolTip1 = new ToolTip();
			ToolTip1.SetToolTip(
				this.pictureBox10, 
				"Ar trebui sa efectuati un audit al informatiilor la nivel de companie sau in anumite domenii specifice de activitate." + 
				Environment.NewLine +
				"Acest audit ar trebui efectuat de o persoana ce cunoaste bine activitatea si modul de lucru al societatii."+ 
				Environment.NewLine + 
				"Un audit al informatiilor este o evidenta a fluxurilor de date si a activelor pe care compania le gestioneaza." +
				Environment.NewLine + 
				"Un inventar al datelor este in mod normal organizat in functie de ciclul de viata al datelor colectate, prelucrate, transferate, stocate, protejate si pastrate."
				);
		}

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
