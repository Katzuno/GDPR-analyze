using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GDPR_analyze
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            panel1.Visible = false;
            bunifuCustomLabel1.Visible = true;
            bunifuCustomLabel3.Visible = true;
          
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void Login_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            bunifuCustomLabel1.Visible = false;
            bunifuCustomLabel3.Visible = false;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            bunifuCustomLabel1.Visible = true;
            bunifuCustomLabel3.Visible = true;
        }

		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
			//de verificat daca exista user-ul si apoi catre home page
		}
	}
}
