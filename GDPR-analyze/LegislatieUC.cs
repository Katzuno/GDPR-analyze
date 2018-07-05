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
        private void downloadFile(string url, string pdfName)
        {
            //string pdfName = "Ghid_GDPR_ultima_varianta_ANSPDCP_RO";
            //string url = "https://drive.google.com/open?id=1hrfNHsd5JdYvc3nuqmHGj_FnFd3sHVHE";
            MessageBox.Show(url);
            // Create an instance of WebClient
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                wc.DownloadFileAsync(new System.Uri(url),
                pdf_download_path + pdfName + ".pdf");
            }
            MessageBox.Show("Fisier descarcat in folderul: " + pdf_download_path);
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1hrfNHsd5JdYvc3nuqmHGj_FnFd3sHVHE", linkLabel0.Text);
        }

        private void linkLabel0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1hrfNHsd5JdYvc3nuqmHGj_FnFd3sHVHE", linkLabel0.Text);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            //pictureBox1.Image.Palette = ColorPallete
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1Nylfwrt70N4WWwDwTI_tMO3L4ZZZ3Blu", linkLabel1.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1Nylfwrt70N4WWwDwTI_tMO3L4ZZZ3Blu", linkLabel1.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1HGE5p8AR0OdW7weiKEVFdYTrK646Ogtj", linkLabel2.Text);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1HGE5p8AR0OdW7weiKEVFdYTrK646Ogtj", linkLabel2.Text);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1NyY6OAmrtTpjYxkdLPvZgsjYgAJ79_ye", linkLabel5.Text);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1NyY6OAmrtTpjYxkdLPvZgsjYgAJ79_ye", linkLabel5.Text);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1_jjVxHA_QYlXwVBO52xDDdHqj7PA10ok", linkLabel4.Text);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1_jjVxHA_QYlXwVBO52xDDdHqj7PA10ok", linkLabel4.Text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1g3nt9Q3uKDGvSccUKeKJXMQUzS1dxJ0x", linkLabel3.Text);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1g3nt9Q3uKDGvSccUKeKJXMQUzS1dxJ0x", linkLabel3.Text);
        }
    }
}
