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
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

			MaterialSkinManager managerSkinManager = MaterialSkinManager.Instance;
			managerSkinManager.AddFormToManage(this);
			managerSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

			managerSkinManager.ColorScheme = new ColorScheme(
				Primary.Blue400, Primary.Blue700,
				Primary.Blue600,Accent.Cyan400,
				TextShade.WHITE
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
	}
}
