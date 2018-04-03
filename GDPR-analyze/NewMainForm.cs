using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDPR_analyze
{
	
	public partial class NewMainForm : Form
	{
		int panelWidth;
		int panelHeigth;
		int meniuPanel;
		string text = "";

		int panelWidthmin;
		int panelWidthmax;

		public NewMainForm()
		{
			InitializeComponent();

			panelWidth = panel5.Width;
			panelHeigth = panel5.Height;
			meniuPanel = panel5.Width;
			panelWidthmax = panelWidthmin = meniuPanel;

			panel5.Height = panelHeigth;
			panel5.Width = 0;
			main_pnl.Width = main_pnl.Width + meniuPanel;

			text = textBox1.Text;
            //Hidden = false;

            
		}


		private void button3_MouseEnter(object sender, EventArgs e)
		{
			button3.UseVisualStyleBackColor = false;
			button3.BackColor = Color.DarkOrange;
		}

		private void button3_MouseLeave(object sender, EventArgs e)
		{
			button3.UseVisualStyleBackColor = true;
			button3.BackColor = Color.DimGray;
		}

		private void button4_MouseEnter(object sender, EventArgs e)
		{
			button4.UseVisualStyleBackColor = false;
			button4.BackColor = Color.DarkOrange;
		}

		private void button4_MouseLeave(object sender, EventArgs e)
		{
			button4.UseVisualStyleBackColor = true;
			button4.BackColor = Color.DimGray;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			
			//this.WindowState = FormWindowState.Maximized;
			if (WindowState.ToString() == "Normal")
			{
				this.WindowState = FormWindowState.Maximized;
				panelWidth = panel5.Width;
				panelHeigth = panel5.Height;

				//panelWidthmax = panel5.Width;
			}
			else
			{
				this.WindowState = FormWindowState.Normal;
				//panelWidth = panel5.Width;
				panelHeigth = panel5.Height;

				panelWidthmin = panelWidthmax;
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;

			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//timer1.Start();
			//291; 661
			if(panel5.Height == panelHeigth && panel5.Width == panelWidth)
			{
				
				panel5.Height = panelHeigth;
				panel5.Width = 0;
			}
			else
			{
				panel5.Height = panelHeigth;
				panel5.Width = panelWidthmax;

			}

		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			if (textBox1.Text.Trim() != "" || textBox1.Text != null)
			{
				textBox1.Text = "";
			}
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			textBox1.Text = text;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (panel5.Height == panelHeigth && panel5.Width == panelWidth)
			{
				
				panel5.Height = panelHeigth;
				panel5.Width = 0;

				main_pnl.Width = main_pnl.Width + meniuPanel;
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
            foreach (Control ctrl in panel2.Controls)
            {
                ctrl.Dispose();//Inchide controale deja existente
            }
            //Buton Audit
            Control audit = new Audit();
            panel2.Controls.Add(audit);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel2.Controls)
            {
                ctrl.Dispose();//Inchide controale deja existente
            }
            Control formulare = new Formulare();
            panel2.Controls.Add(formulare);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel2.Controls)
            {
                ctrl.Dispose();//Inchide controale deja existente
            }
            Control acces = new Solicita_acces();
            panel2.Controls.Add(acces);
        }
    }
}
