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
	public partial class HistoricCompareAudit : UserControl
	{
		public HistoricCompareAudit()
		{
			InitializeComponent();

            int i;
            for (i = 0; i < AUDIT_SINGLE_PAGE.lstQuestions.Count; i++)
            {
                addItem(AUDIT_SINGLE_PAGE.lstQuestions[i], AUDIT_SINGLE_PAGE.oldAnswers[i+1], AUDIT_SINGLE_PAGE.currentAnswers[i+1]);
            }
		}

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addItem(string question, string oldAnswer, string currentAnswer)
        {
            HistoricCompareTable.Rows.Add();
            int lastAddedRow = HistoricCompareTable.Rows.Count - 1;
            
            HistoricCompareTable.Rows[lastAddedRow].Cells[0].Value = question;
            HistoricCompareTable.Rows[lastAddedRow].Cells[1].Value = oldAnswer;
            HistoricCompareTable.Rows[lastAddedRow].Cells[2].Value = currentAnswer;

        }

        private void GoToDiagram_Click(object sender, EventArgs e)
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
