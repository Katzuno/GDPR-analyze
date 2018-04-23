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
using System.Net;

namespace GDPR_analyze
{
	public partial class AUDIT_SINGLE_PAGE : UserControl
	{
		protected uint count = 0;
		private Boolean[,] answers;
		private List<string> lstDetails;
		private List<string> lstQuestions;
		private List<string> lstRecommendNo;
		private List<string> lstRecommendPartial;
		private List<string> lstYes;
		private List<string> lstCategories;

		public AUDIT_SINGLE_PAGE()
		{
			InitializeComponent();


			lstDetails = new List<string>();
			lstQuestions = new List<string>();
			lstRecommendNo = new List<string>();
			lstRecommendPartial = new List<string>();
			lstYes = new List<string>();
			lstCategories = new List<string>();

			btnGenerateReport.Visible = false;
			bunifuFlatButton2.Visible = false;
			//string text1 = "Ar trebui sa efectuati un audit al informatiilor la nivel de companie sau in anumite domenii specifice de activitate. Acest audit ar trebui efectuat de o persoana ce cunoaste bine activitatea si modul de lucru al societatii.  Un audit al informatiilor este o evidenta a fluxurilor de date si a activelor pe care compania le gestioneaza."+ Environment.NewLine+ "Un inventar al datelor este in mod normal organizat in functie de ciclul de viata al datelor colectate, prelucrate, transferate, stocate, protejate si pastrate." + Environment.NewLine + "Un flux de informatii poate include un transfer de informatii dintr-o locatie in alta. De exemplu, informatiile pot ramane in compania dvs., pe cand un transfer are loc deoarece un departament sau alt birou este situat in alta parte (in afara sediului)." + Environment.NewLine+ "Dupa ce ati efectuat auditul informatiilor dvs., ar trebui sa puteti identifica eventualele riscuri.";
			//textBox1.Text = text1;

			ReadCsv(lstQuestions, lstDetails, lstRecommendNo, lstRecommendPartial, lstYes, lstCategories);

			answers = new Boolean[lstQuestions.Count, 4];
			Array.Clear(answers, 0, answers.Length);
			/*
			lstDetails.Add(text1);
			lstDetails.Add("Dupa finalizarea auditului informatiilor, ar trebui sa documentati constatarile intr-un registru de informatii. Acest lucru va va ajuta, de asemenea, sa va conformati principiului responsabilitatii din GDPR, care impune companiei dvs. sa demonstreze modul in care respecta principiile GDPR." + Environment.NewLine + "Daca aveti mai putin de 250 de angajati, trebuie sa tineti evidenta activitatilor de prelucrare care: nu sunt ocazionale; ar putea duce la un risc pentru drepturile si libertatile persoanelor; sau implica prelucrarea unor categorii speciale de date sau date privind condamnari penala si infracțiuni." + Environment.NewLine + "Daca aveti peste 250 de angajati, trebuie să înregistrați informațiile de mai sus și unele suplimentare, așa cum se prevede în GDPR.");
			lstDetails.Add("sdfghjkl");

			lstQuestions.Add("1) Ati efectuat un audit de informare pentru a intocmi fluxurile de date?");
			lstQuestions.Add("2) Ati documentat ce date personale detineti, de unde provin, cu cine le impartiti si ce faceti cu ele?");
			lstQuestions.Add("3) Aveti o evidenta scrisa a tuturor categoriilor de date cu caracter personal pe care compania dvs. le proceseaza? " + Environment.NewLine + "Categoriile de date cu caracter personal includ detalii de contact(nume, adresa, e - mail etc.), detalii pentru angajare(functia, gradul, locatia, evaluarile performantei etc.), detalii financiare(salariul și beneficiile, detalii despre contul bancar), precum si date cu caracter sensibil referitoare la sanatatea fizica si psihica sau condamnarile penale ?");
			*/
			txtQAudit.Text = lstQuestions[0];
			textBox1.Text = lstDetails[0];
			textBox2.Text = lstCategories[0];
		}

		private string FormatareParagraf(string paragraf)
		{			
			paragraf = paragraf.Replace("@", "\r\n");
			return paragraf;
		}

		private void ReadCsv(List<string> Questions, List<string> Details, List<string> RecommendNo, List<string> RecommendPartial, List<string> Yes, List<string> Categories)
		{
			using (var reader = new StreamReader("test.csv"))
			{
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					var values = line.Split(';');

					Questions.Add(FormatareParagraf(values[0]));
					Details.Add(FormatareParagraf(values[1]));
					RecommendNo.Add(FormatareParagraf(values[2]));
					RecommendPartial.Add(FormatareParagraf(values[3]));
					Yes.Add(FormatareParagraf(values[4]));
					Categories.Add(FormatareParagraf(values[5]));
				}
			}
		}

		private void btnGenerateReport_Click(object sender, EventArgs e)
		{
			GeneratePDF("testPDFblablabla");	
		}
		private string selectAnswer(int id_question)
		{
			int j;
			string polite = "Raspunsul dumneavoastra a fost: ";
			// 0 = NU ; 1 = DA ; 2 = NU inca ; 3 = Partial
			for (j = 0; j < 4; j++)
				if (answers[id_question, j] == true)
				{
					if (j == 0)
						return polite + "Nu";
					else if (j == 1)
						return polite + "Da";
					else if (j == 2)
						return polite + "Nu a fost inca implementat / planificat";
					else if (j == 3)
						return polite + "Partial implementat / planificat";
				}
			return "Nu s-a raspuns";
		}
		private string ourRecommendation(int id_question)
		{
			int j;
			// 0 = NU ; 1 = DA ; 2 = NU inca ; 3 = Partial
			for (j = 0; j < 4; j++)
				if (answers[id_question, j] == true)
				{
					if (j == 0 || j == 2)
						return lstRecommendNo[id_question];
					else if (j == 1)
						return lstYes[id_question];
					else if (j == 3)
						return lstRecommendPartial[id_question];
				}

			return "Nu s-a raspuns";//Nu ar trebui sa se ajunga aici
		}
		private void GeneratePDF(string nume_fisier)
		{
			int i;
			string data_text = "_"+ DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Minute.ToString();
			string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + nume_fisier + data_text+ ".pdf";

			Document pdfDoc = new Document();
			// set the page size, set the orientation
			pdfDoc.SetPageSize(PageSize.A4);
			// create a writer instance
			PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, new FileStream(Path, FileMode.Create));


			iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22, BaseColor.BLACK);
			iTextSharp.text.Font questionFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.BLACK);
			iTextSharp.text.Font answerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLDOBLIQUE, 12, BaseColor.BLACK);
			iTextSharp.text.Font recommendFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 12, BaseColor.BLACK);

			Paragraph title;
			title = new Paragraph("Rezultatele obtinute in urma auditului", titleFont);
			title.Alignment = Element.ALIGN_CENTER;
			//title.Font = titleFont;

			

			pdfDoc.Open();
			pdfDoc.Add(title);
			pdfDoc.Add(new Paragraph("\r\n"));
			pdfDoc.Add(new Paragraph("\r\n"));
			for (i = 0; i < lstQuestions.Count; i++)
			{
				Paragraph textQ = new Paragraph(lstQuestions[i] + "\r\n", questionFont);
				textQ.Font = FontFactory.GetFont(FontFactory.COURIER_BOLD, 15, BaseColor.RED);
				pdfDoc.Add(textQ);
				pdfDoc.Add(new Paragraph(selectAnswer(i) + "\r\n", answerFont));
				pdfDoc.Add(new Paragraph("Recomandarea noastra este: \r\n", recommendFont) );
				pdfDoc.Add(new Paragraph(ourRecommendation(i) + "\r\n", recommendFont));
				pdfDoc.Add(new Paragraph("\r\n"));
			}
			
			pdfDoc.Close();

			System.Diagnostics.Process.Start(Path);
		}

		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{
			//verific daca a bifat	
			if (chkNo.Checked == false && chkNoImplement.Checked == false && chkPartial.Checked == false && chkYes.Checked == false)
			{
				MessageBox.Show("Trebuie sa alegeti unul din raspunsurile afisate", "ATENTIE!",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (count >= 0)
				{
					bunifuFlatButton2.Visible = true;
				}
				else
				{
					bunifuFlatButton2.Visible = false;
				}
				//colectez informatia de la intrebarea precedenta (mai ales daca a fost schimbata)
				// 0 = NU ; 1 = DA ; 2 = NU inca ; 3 = Partial
				if (chkNo.Checked)
				{
					answers[count, 0] = true;
					answers[count, 1] = false;
					answers[count, 2] = false;
					answers[count, 3] = false;
				}
				else if (chkYes.Checked)
				{
					answers[count, 0] = false;
					answers[count, 1] = true;
					answers[count, 2] = false;
					answers[count, 3] = false;
				}
				else if (chkNoImplement.Checked)
				{
					answers[count, 0] = false;
					answers[count, 1] = false;
					answers[count, 2] = true;
					answers[count, 3] = false;
				}
				else if (chkPartial.Checked)
				{
					answers[count, 0] = false;
					answers[count, 1] = false;
					answers[count, 2] = true;
					answers[count, 3] = true;
				}


				//Trec la intrebarea urmatoare, schimb intrebare + detalii
				if (count < lstQuestions.Count - 1)
				{
					txtQAudit.Text = lstQuestions[(int)count + 1];
					textBox1.Text = lstDetails[(int)count + 1];
					textBox2.Text = lstCategories[(int)count + 1];

					//pun informatia in butoane de la intrebarea la care trec

					chkNo.Checked = answers[count + 1, 0];
					chkYes.Checked = answers[count + 1, 1];
					chkNoImplement.Checked = answers[count + 1, 2];
					chkPartial.Checked = answers[count + 1, 3];
				}
				else
				{
					//Disable la butoane previous si next;
					bunifuFlatButton2.Visible = false;
					bunifuFlatButton3.Visible = false;

					//disable butoane check
					chkNo.Visible = false;
					chkYes.Visible = false;
					chkNoImplement.Visible = false;
					chkPartial.Visible = false;

					//Enable Genereaza raportul
					btnGenerateReport.Visible = true;

					txtQAudit.Text = "Felicitari, ati rezolvat auditul. Scorul dvs este X";
					textBox1.Text = " ";
					textBox2.Text = " ";
				}

					count++;
				
			}
		}

		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{

			if (count == 1)
			{
				bunifuFlatButton2.Visible = false;
			}
			

			//colectez informatia de la intrebarea precedenta (mai ales daca a fost schimbata)
			// 0 = NU ; 1 = DA ; 2 = NU inca ; 3 = Partial
			if (chkNo.Checked)
			{
				answers[count, 0] = true;
				answers[count, 1] = false;
				answers[count, 2] = false;
				answers[count, 3] = false;
			}
			else if (chkYes.Checked)
			{
				answers[count, 0] = false;
				answers[count, 1] = true;
				answers[count, 2] = false;
				answers[count, 3] = false;
			}
			else if (chkNoImplement.Checked)
			{
				answers[count, 0] = false;
				answers[count, 1] = false;
				answers[count, 2] = true;
				answers[count, 3] = false;
			}
			else if (chkPartial.Checked)
			{
				answers[count, 0] = false;
				answers[count, 1] = false;
				answers[count, 2] = false;
				answers[count, 3] = true;
			}

			//repun informatia precedenta
			chkNo.Checked = answers[count-1, 0];
			chkYes.Checked = answers[count-1, 1];
			chkNoImplement.Checked = answers[count-1, 2];
			chkPartial.Checked = answers[count-1, 3];



			//Trec la intrebarea urmatoare, schimb intrebare + detalii
			if (count < lstQuestions.Count)
			{
				txtQAudit.Text = lstQuestions[(int)count-1];
				textBox1.Text = lstDetails[(int)count-1];
				textBox2.Text = lstCategories[(int)count - 1];
			}


			count--;

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
