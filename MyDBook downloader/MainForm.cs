using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;

namespace MyDBook_downloader
{
    public partial class MainForm : Form
    {
        private bool isScraping = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Browser.ScriptErrorsSuppressed = true;
            Browser.Navigate("https://centralauthentication.giunti.it/cas/login?service=https%3A%2F%2Fmydbook.giuntitvp.it%2Fauthentication%2Fcas%3Fiframe%3Dfalse%26return%3Dhttps%253A%252F%252Fmydbook.giuntitvp.it%252Fapp%252Fhome");
        }

        private void StartScraping_Click(object sender, EventArgs e)
        {
            if (isScraping)
            {
                isScraping = false;
                return;
            }

            if (Convert.ToInt32(RangeFromTB.Text) < 1)
            {
                MessageBox.Show("The first page must be greater or equal to 1!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            StartStopScrapingBTN.Text = "Stop scraping";
            RangeFromTB.Enabled = false;
            RangeToTB.Enabled = false;
            BookIdTB.Enabled = false;
            URLBTN.Enabled = false;
            LoginPageBTN.Enabled = false;
            isScraping = true;

            for (int i = Convert.ToInt32(RangeFromTB.Text); i <= Convert.ToInt32(RangeToTB.Text); i++)
            {
                tryAgain:

                if (!isScraping)
                    break;

                try
                {
                    ProgressLBL.Text = "Progress " + i + "/" + Convert.ToInt32(RangeToTB.Text);

                    var imageUrl = "https://mydbook.giuntitvp.it/books/" + BookIdTB.Text + @"/pdf/pages/" + i + "?type=";

                    Browser.Navigate(imageUrl);

                    while (Browser.ReadyState != WebBrowserReadyState.Complete)
                        Application.DoEvents();

                    if (Browser.Document.Body.InnerHtml.Contains("Unauthorized"))
                    {
                        ProgressLBL.Text = "Progress 0/0";
                        StartStopScrapingBTN.Text = "Start scraping";
                        RangeFromTB.Enabled = true;
                        RangeToTB.Enabled = true;
                        BookIdTB.Enabled = true;
                        URLBTN.Enabled = true;
                        LoginPageBTN.Enabled = true;
                        isScraping = false;

                        MessageBox.Show(
                            "An error occurred during the scraping process:\n(401 - Unauthorized)\n\nThis error can occur if you don't own the selected book, or you included non existing pages in the range.",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    IHTMLDocument2 browserDocument = (IHTMLDocument2)Browser.Document.DomDocument;
                    IHTMLControlRange documentImages = (IHTMLControlRange)((HTMLBody)browserDocument.body).createControlRange();

                    foreach (IHTMLImgElement currentImage in browserDocument.images)
                    {
                        documentImages.add((IHTMLControlElement)currentImage);

                        documentImages.execCommand("Copy", false, null);

                        using (Bitmap bitmap = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap))
                        {
                            bitmap.Save(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\" + i +
                                     ".png");
                        }
                    }
                }
                catch (Exception)
                {
                    goto tryAgain;
                }
                
                Application.DoEvents();
            }

            MessageBox.Show("Scraping process finished!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ProgressLBL.Text = "Progress 0/0";
            StartStopScrapingBTN.Text = "Start scraping";
            RangeFromTB.Enabled = true;
            RangeToTB.Enabled = true;
            BookIdTB.Enabled = true;
            URLBTN.Enabled = true;
            LoginPageBTN.Enabled = true;
            isScraping = false;
        }

        private void URLButton_Click(object sender, EventArgs e)
        {
            Browser.Navigate(URLTB.Text);
        }

        private void RangeFromTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void RangeToTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void LoginPageBTN_Click(object sender, EventArgs e)
        {
            Browser.Navigate("https://centralauthentication.giunti.it/cas/login?service=https%3A%2F%2Fmydbook.giuntitvp.it%2Fauthentication%2Fcas%3Fiframe%3Dfalse%26return%3Dhttps%253A%252F%252Fmydbook.giuntitvp.it%252Fapp%252Fhome");
        }
    }
}
