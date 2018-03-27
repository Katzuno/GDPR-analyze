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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool focus = false;
        private void Login_Form_Paint(object sender, PaintEventArgs e)
        {
            if (focus)
            {
                textBox1.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.DarkOrange);
                Graphics g = e.Graphics;
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(textBox1.Location.X - variance, textBox1.Location.Y - variance, textBox1.Width + variance, textBox1.Height + variance));
            }
            else
            {
                textBox1.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.Text = "";
            focus = true;
            this.Refresh();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.Text = "";
            focus = false;
            this.Refresh();
        }
    }
}
