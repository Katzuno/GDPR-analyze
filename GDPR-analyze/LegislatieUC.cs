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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1Ji3i-lb2rfqS0So02wKRdl3b0GFkrzBP", linkLabel8.Text);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1Ji3i-lb2rfqS0So02wKRdl3b0GFkrzBP", linkLabel8.Text);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1hPRFxc1rwLhOOgbv7hnB7WuDYPkSYzav", linkLabel7.Text);
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1hPRFxc1rwLhOOgbv7hnB7WuDYPkSYzav", linkLabel7.Text);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1mB85vlXSCylib74J1118hiB2JVpzCJOd", linkLabel6.Text);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1mB85vlXSCylib74J1118hiB2JVpzCJOd", linkLabel6.Text);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1lzqJGpw00FfTcsOHX93_KoOTPZ4KImZW", linkLabel11.Text);
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1lzqJGpw00FfTcsOHX93_KoOTPZ4KImZW", linkLabel11.Text);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1R08ejstkqgw2xkXcKEDMVYI2GX0JygHQ", linkLabel10.Text);
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1R08ejstkqgw2xkXcKEDMVYI2GX0JygHQ", linkLabel10.Text);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1hzT2_3No-FX0xmwm3WN5QcdozpQRaiOM", linkLabel9.Text);
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1hzT2_3No-FX0xmwm3WN5QcdozpQRaiOM", linkLabel10.Text);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1lzqJGpw00FfTcsOHX93_KoOTPZ4KImZW", linkLabel14.Text);
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1lzqJGpw00FfTcsOHX93_KoOTPZ4KImZW", linkLabel14.Text);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1b9144jWl4UyN7n1Ewv2a_lytWNZXzf46", linkLabel13.Text);
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1b9144jWl4UyN7n1Ewv2a_lytWNZXzf46", linkLabel13.Text);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1hzT2_3No-FX0xmwm3WN5QcdozpQRaiOM", linkLabel12.Text);
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1hzT2_3No-FX0xmwm3WN5QcdozpQRaiOM", linkLabel12.Text);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1hGq_a2UlvBPU0DvDB7BAMI3U7YtlW81R", linkLabel17.Text);
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1hGq_a2UlvBPU0DvDB7BAMI3U7YtlW81R", linkLabel17.Text);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1PubE1JotIR8jHs78lQjTs2i1V7Vif139", linkLabel16.Text);
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1PubE1JotIR8jHs78lQjTs2i1V7Vif139", linkLabel16.Text);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1-o_ig8wILQPoAKl6715jxHGOO7DJDjnn", linkLabel15.Text);
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadFile("https://drive.google.com/open?id=1-o_ig8wILQPoAKl6715jxHGOO7DJDjnn", linkLabel15.Text);
        }
    }
}
