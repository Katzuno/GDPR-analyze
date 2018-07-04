using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;

namespace GDPR_analyze
{
	public partial class LegislatieUC : UserControl
	{
        private string pdf_download_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GDPR_Downloads\\";

        public LegislatieUC()
		{
			InitializeComponent();
		}
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            System.Windows.Forms.ProgressBar pb = new System.Windows.Forms.ProgressBar();
            pb.Value = e.ProgressPercentage;

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string pdfName = "Ghid_GDPR_ultima_varianta_ANSPDCP_RO";
            string url = "https://www.ithit.ro/download/" + pdfName + ".pdf";
            MessageBox.Show(url);
            // Create an instance of WebClient
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(new System.Uri(url),
                pdf_download_path + pdfName + ".pdf");
            }
            MessageBox.Show("File downloaded in " + pdf_download_path);
        }

        private void ghid_gdpr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string pdfName = "Ghid_GDPR_ultima_varianta_ANSPDCP_RO";
            string url = "https://www.ithit.ro/download/" + pdfName + ".pdf";
            MessageBox.Show(url);
            // Create an instance of WebClient
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(new System.Uri(url),
                pdf_download_path + pdfName + ".pdf");
            }
            MessageBox.Show("File downloaded in " + pdf_download_path);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            //pictureBox1.Image.Palette = ColorPallete
        }
    }
}
