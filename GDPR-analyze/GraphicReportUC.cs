using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDPR_analyze
{
	public partial class GraphicReportUC : UserControl
	{
		public int panelH = 0;
		public int panelW = 0;
		public GraphicReportUC()
		{
			InitializeComponent();


			//rand 1
			grfBazaLegala.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[0], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[0]);
			grfLegalitate.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[1], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[1]);
			grfConsimtamant.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[2], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[2]);

			//rand 2
			grfDrepturiPViz.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[3], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[3]);
			grfImputernicit.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[4], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[4]);
			grfRiscuri.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[5], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[5]);

			//rand 3
			grfResponsabil.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[6], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[6]);
			grfSecuritate.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[7], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[7]);
			grfIncalcare.Value = displayAsPercentage(AUDIT_SINGLE_PAGE.lstNrQPerCty[8], AUDIT_SINGLE_PAGE.lstYesNumberPerCty[8]);


		}

        private int displayAsPercentage(int total, int value)
        {
            int percentage;
            percentage = value * 100 / total;
            return percentage;
        }

        private void legalGrf_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGauge2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGauge3_Load(object sender, EventArgs e)
        {

        }

		private void GraphicReportUC_SizeChanged(object sender, EventArgs e)
		{
			panelH = panel1.Size.Height;
			panelW = panel1.Size.Width;

			//if (panelW > 1000)
			//{
			//randul 1
			panel2.Width = panel4.Width = panel5.Width = panelW / 3;
			//randul 2
			panel7.Width = panel8.Width = panel9.Width = panelW / 3;
			//
			//randul 3
			panel14.Width = panel13.Width = panel12.Width = panelW / 3;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			Panel main_pnl = this.Parent as Panel;
			UserControl generalDiagram = new GeneralDiagramUC();
			generalDiagram.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
			generalDiagram.Dock = DockStyle.Fill;
			main_pnl.Controls.Clear();
			main_pnl.Controls.Add(generalDiagram);
		}
	}
}
