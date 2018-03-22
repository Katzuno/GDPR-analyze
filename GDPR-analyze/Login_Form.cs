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
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace GDPR_analyze
{
    public partial class Login_Form : MaterialForm
    {
        public Login_Form()
        {
            InitializeComponent();

            MaterialSkinManager managerSkinManager = MaterialSkinManager.Instance;
            managerSkinManager.AddFormToManage(this);
            managerSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            managerSkinManager.ColorScheme = new ColorScheme(
                Primary.Lime400, Primary.Cyan400,
                Primary.Lime200, Accent.Cyan700,
                TextShade.BLACK
                );
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

		private void submit_login_btn_Click(object sender, EventArgs e)
		{
			MainMenu main_menu = new MainMenu();
			this.Hide();
			main_menu.ShowDialog();
			this.Close();
		}

		private void login_bck_btn_Click(object sender, EventArgs e)
		{
			Start_Form start_form = new Start_Form();
			this.Hide();
			start_form.ShowDialog();
			this.Close();
		}

	}
}
