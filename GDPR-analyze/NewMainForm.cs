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
			btn_audit.UseVisualStyleBackColor = false;
			btn_audit.BackColor = Color.DarkOrange;
		}

		private void button3_MouseLeave(object sender, EventArgs e)
		{
			btn_audit.UseVisualStyleBackColor = true;
			btn_audit.BackColor = Color.DimGray;
		}

		private void button4_MouseEnter(object sender, EventArgs e)
		{
			btn_form.UseVisualStyleBackColor = false;
			btn_form.BackColor = Color.DarkOrange;
		}

		private void button4_MouseLeave(object sender, EventArgs e)
		{
			btn_form.UseVisualStyleBackColor = true;
			btn_form.BackColor = Color.DimGray;
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
			foreach (Control ctrl in main_pnl.Controls)
			{

				ctrl.Dispose();//Inchide controale deja existente

			}
			//Buton Audit
			panel5.Width = 0;
			Control audit = new Audit();
            main_pnl.Controls.Add(audit);
			
		}

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in main_pnl.Controls)
            {
                ctrl.Dispose();//Inchide controale deja existente
            }
			panel5.Width = 0;
			Control formulare = new Formulare();
            main_pnl.Controls.Add(formulare);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in main_pnl.Controls)
            {
                ctrl.Dispose();//Inchide controale deja existente
            }
			panel5.Width = 0;
			Control acces = new Solicita_acces();
            main_pnl.Controls.Add(acces);
        }

	}
}
