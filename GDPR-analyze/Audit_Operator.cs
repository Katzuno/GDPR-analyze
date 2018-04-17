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
    public partial class Audit : UserControl
    {
        public Audit()
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
          
        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Audit_Load(object sender, EventArgs e)
        {

        }

		
	}
}
