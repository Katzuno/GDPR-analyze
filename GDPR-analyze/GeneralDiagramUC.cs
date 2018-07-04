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
	public partial class GeneralDiagramUC : UserControl
	{
		public GeneralDiagramUC()
		{
			InitializeComponent();

			int nrQuestions = AUDIT_SINGLE_PAGE.lstQuestions.Count;
			int nrTotalYes = AUDIT_SINGLE_PAGE.lstYesNumberPerCty.Sum();

			generalDiagram.Value = displayAsPercentage(nrQuestions, nrTotalYes);
            /*
            Bitmap bmp = new Bitmap(panel6.Width, this.panel.Height);

            this.panel.DrawToBitmap(bmp, new Rectangle(0, 0, this.panel.Width, this.panel.Height));

            bmp.Save("panel.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            */
        }

		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			Panel main_pnl = this.Parent as Panel;
			UserControl graphicReport = new GraphicReportUC();
			graphicReport.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
			graphicReport.Dock = DockStyle.Fill;
			main_pnl.Controls.Clear();
			main_pnl.Controls.Add(graphicReport);
		}

		private int displayAsPercentage(int total, int value)
		{
			int percentage;
			percentage = value * 100 / total;
			return percentage;
		}
	}
}
