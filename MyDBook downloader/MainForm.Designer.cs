
namespace MyDBook_downloader
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartStopScrapingBTN = new System.Windows.Forms.Button();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.URLTB = new System.Windows.Forms.TextBox();
            this.URLBTN = new System.Windows.Forms.Button();
            this.RangeFromTB = new System.Windows.Forms.TextBox();
            this.RangeToTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BookIdTB = new System.Windows.Forms.TextBox();
            this.LoginPageBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartStopScrapingBTN
            // 
            this.StartStopScrapingBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartStopScrapingBTN.Location = new System.Drawing.Point(331, 415);
            this.StartStopScrapingBTN.Name = "StartStopScrapingBTN";
            this.StartStopScrapingBTN.Size = new System.Drawing.Size(119, 23);
            this.StartStopScrapingBTN.TabIndex = 0;
            this.StartStopScrapingBTN.Text = "Start scraping";
            this.StartStopScrapingBTN.UseVisualStyleBackColor = true;
            this.StartStopScrapingBTN.Click += new System.EventHandler(this.StartScraping_Click);
            // 
            // Browser
            // 
            this.Browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Browser.Location = new System.Drawing.Point(12, 62);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(776, 347);
            this.Browser.TabIndex = 1;
            // 
            // URLTB
            // 
            this.URLTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URLTB.Location = new System.Drawing.Point(12, 12);
            this.URLTB.Name = "URLTB";
            this.URLTB.Size = new System.Drawing.Size(598, 20);
            this.URLTB.TabIndex = 2;
            // 
            // URLBTN
            // 
            this.URLBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.URLBTN.Location = new System.Drawing.Point(616, 10);
            this.URLBTN.Name = "URLBTN";
            this.URLBTN.Size = new System.Drawing.Size(61, 23);
            this.URLBTN.TabIndex = 3;
            this.URLBTN.Text = "Go";
            this.URLBTN.UseVisualStyleBackColor = true;
            this.URLBTN.Click += new System.EventHandler(this.URLButton_Click);
            // 
            // RangeFromTB
            // 
            this.RangeFromTB.Location = new System.Drawing.Point(48, 36);
            this.RangeFromTB.Name = "RangeFromTB";
            this.RangeFromTB.ShortcutsEnabled = false;
            this.RangeFromTB.Size = new System.Drawing.Size(75, 20);
            this.RangeFromTB.TabIndex = 4;
            this.RangeFromTB.Text = "1";
            this.RangeFromTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RangeFromTB_KeyPress);
            // 
            // RangeToTB
            // 
            this.RangeToTB.Location = new System.Drawing.Point(129, 36);
            this.RangeToTB.Name = "RangeToTB";
            this.RangeToTB.ShortcutsEnabled = false;
            this.RangeToTB.Size = new System.Drawing.Size(83, 20);
            this.RangeToTB.TabIndex = 5;
            this.RangeToTB.Text = "1300";
            this.RangeToTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RangeToTB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pages";
            // 
            // ProgressLBL
            // 
            this.ProgressLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressLBL.Location = new System.Drawing.Point(630, 39);
            this.ProgressLBL.Name = "ProgressLBL";
            this.ProgressLBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressLBL.Size = new System.Drawing.Size(158, 23);
            this.ProgressLBL.TabIndex = 7;
            this.ProgressLBL.Text = "Progress 0/0";
            this.ProgressLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Book ID (you must own it)";
            // 
            // BookIdTB
            // 
            this.BookIdTB.Location = new System.Drawing.Point(364, 36);
            this.BookIdTB.Name = "BookIdTB";
            this.BookIdTB.ShortcutsEnabled = false;
            this.BookIdTB.Size = new System.Drawing.Size(130, 20);
            this.BookIdTB.TabIndex = 9;
            this.BookIdTB.Text = "GIAC90_G9075484A";
            // 
            // LoginPageBTN
            // 
            this.LoginPageBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPageBTN.Location = new System.Drawing.Point(705, 10);
            this.LoginPageBTN.Name = "LoginPageBTN";
            this.LoginPageBTN.Size = new System.Drawing.Size(83, 23);
            this.LoginPageBTN.TabIndex = 10;
            this.LoginPageBTN.Text = "Login page";
            this.LoginPageBTN.UseVisualStyleBackColor = true;
            this.LoginPageBTN.Click += new System.EventHandler(this.LoginPageBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginPageBTN);
            this.Controls.Add(this.BookIdTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProgressLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RangeToTB);
            this.Controls.Add(this.RangeFromTB);
            this.Controls.Add(this.URLBTN);
            this.Controls.Add(this.URLTB);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.StartStopScrapingBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MyDbook Scraper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartStopScrapingBTN;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.TextBox URLTB;
        private System.Windows.Forms.Button URLBTN;
        private System.Windows.Forms.TextBox RangeFromTB;
        private System.Windows.Forms.TextBox RangeToTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProgressLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BookIdTB;
        private System.Windows.Forms.Button LoginPageBTN;
    }
}

