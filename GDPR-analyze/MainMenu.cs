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
    public partial class MainMenu : MaterialForm
    {
        public MainMenu()
        {
            InitializeComponent();
			//panelChoice.Height = btnAudit.Height;
			//panelChoice.Top = btnAudit.Top;


			MaterialSkinManager managerSkinManager = MaterialSkinManager.Instance;
			managerSkinManager.AddFormToManage(this);
			managerSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

			managerSkinManager.ColorScheme = new ColorScheme(
				Primary.Lime400, Primary.Cyan400,
				Primary.Lime200,Accent.Cyan700,
				TextShade.BLACK
				);

		}

        private void button1_Click(object sender, EventArgs e)
        {
            //SADASDASDAD
            //CACAT

			//mersi erik 2
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnAudit_Click(object sender, EventArgs e)
		{
			//panelChoice.Height = btnAudit.Height;
			//panelChoice.Top = btnAudit.Top;

			materialTabControl1.SelectTab("tabPageAudit");
		}

		private void btnFormulare_Click(object sender, EventArgs e)
		{
			//panelChoice.Height = btnFormulare.Height;
			//panelChoice.Top = btnFormulare.Top;
			materialTabControl1.SelectTab("tabPageForm");
		}

		private void btnReqAccess_Click(object sender, EventArgs e)
		{
			//panelChoice.Height = btnReqAccess.Height;
			//panelChoice.Top = btnReqAccess.Top;
		}

	}
}
