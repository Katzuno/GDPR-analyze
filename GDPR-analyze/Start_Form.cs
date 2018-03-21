﻿using System;
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
    public partial class Start_Form : MaterialForm
    {
        public Start_Form()
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

        private void Start_Form_Load(object sender, EventArgs e)
        {

        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register_Form register = new Register_Form();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }
    }
}
