using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;

namespace GDPR_analyze
{
	public partial class AUDIT_SINGLE_PAGE : UserControl
	{
		public AUDIT_SINGLE_PAGE()
		{
			InitializeComponent();
			btnGenerateReport.Visible = false;

			string text = "Ar trebui sa efectuati un audit al informatiilor la nivel de companie sau in anumite domenii specifice de activitate. Acest audit ar trebui efectuat de o persoana ce cunoaste bine activitatea si modul de lucru al societatii.  Un audit al informatiilor este o evidenta a fluxurilor de date si a activelor pe care compania le gestioneaza."+ Environment.NewLine+ "Un inventar al datelor este in mod normal organizat in functie de ciclul de viata al datelor colectate, prelucrate, transferate, stocate, protejate si pastrate." + Environment.NewLine + "Un flux de informatii poate include un transfer de informatii dintr-o locatie in alta. De exemplu, informatiile pot ramane in compania dvs., pe cand un transfer are loc deoarece un departament sau alt birou este situat in alta parte (in afara sediului)." + Environment.NewLine+ "Dupa ce ati efectuat auditul informatiilor dvs., ar trebui sa puteti identifica eventualele riscuri.";
			textBox1.Text = text;

			var lstQuestions = new List<string>();

			lstQuestions.Add("Ati efectuat un audit de informare pentru a intocmi fluxurile de date?");
			lstQuestions.Add("Ati documentat ce date personale detineti, de unde provin, cu cine le impartiti si ce faceti cu ele?");
			
		}

		private void btnGenerateReport_Click(object sender, EventArgs e)
		{
			string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\testPDF.pdf";

			Document pdfDoc = new Document();
			FileStream fs = File.Create(Path);
			PdfWriter.GetInstance(pdfDoc, fs);

			pdfDoc.Open();
			pdfDoc.Add(new Paragraph("TEST"));
			pdfDoc.Close();
		}

		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{
			//colectez informatia


			//resetez butoanele
			chkNo.Checked = false;
			chkYes.Checked = false;
			chkNoImplement.Checked = false;
			chkPartial.Checked = false;
		}

	}
}
