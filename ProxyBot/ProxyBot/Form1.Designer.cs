namespace ProxyBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Baslat = new System.Windows.Forms.Button();
            this.lb_Proxy = new System.Windows.Forms.ListBox();
            this.tb_Site = new System.Windows.Forms.TextBox();
            this.btn_ProxtCek = new System.Windows.Forms.Button();
            this.lbl_ToplamProxy = new System.Windows.Forms.Label();
            this.btn_IceAktar = new System.Windows.Forms.Button();
            this.btn_DisaAktar = new System.Windows.Forms.Button();
            this.btn_Seleniumkapat = new System.Windows.Forms.Button();
            this.lb_Hata = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Baslat
            // 
            this.btn_Baslat.Location = new System.Drawing.Point(12, 12);
            this.btn_Baslat.Name = "btn_Baslat";
            this.btn_Baslat.Size = new System.Drawing.Size(75, 23);
            this.btn_Baslat.TabIndex = 0;
            this.btn_Baslat.Text = "Başlat";
            this.btn_Baslat.UseVisualStyleBackColor = true;
            this.btn_Baslat.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Proxy
            // 
            this.lb_Proxy.FormattingEnabled = true;
            this.lb_Proxy.Location = new System.Drawing.Point(12, 96);
            this.lb_Proxy.Name = "lb_Proxy";
            this.lb_Proxy.Size = new System.Drawing.Size(340, 95);
            this.lb_Proxy.TabIndex = 1;
            // 
            // tb_Site
            // 
            this.tb_Site.Location = new System.Drawing.Point(12, 41);
            this.tb_Site.Name = "tb_Site";
            this.tb_Site.Size = new System.Drawing.Size(340, 20);
            this.tb_Site.TabIndex = 3;
            this.tb_Site.Text = "https://ip-adresim.net/";
            // 
            // btn_ProxtCek
            // 
            this.btn_ProxtCek.Location = new System.Drawing.Point(145, 197);
            this.btn_ProxtCek.Name = "btn_ProxtCek";
            this.btn_ProxtCek.Size = new System.Drawing.Size(75, 23);
            this.btn_ProxtCek.TabIndex = 4;
            this.btn_ProxtCek.Text = "Proxy Çek";
            this.btn_ProxtCek.UseVisualStyleBackColor = true;
            this.btn_ProxtCek.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_ToplamProxy
            // 
            this.lbl_ToplamProxy.AutoSize = true;
            this.lbl_ToplamProxy.Location = new System.Drawing.Point(9, 80);
            this.lbl_ToplamProxy.Name = "lbl_ToplamProxy";
            this.lbl_ToplamProxy.Size = new System.Drawing.Size(74, 13);
            this.lbl_ToplamProxy.TabIndex = 5;
            this.lbl_ToplamProxy.Text = "Toplam Proxy:";
            // 
            // btn_IceAktar
            // 
            this.btn_IceAktar.Location = new System.Drawing.Point(12, 197);
            this.btn_IceAktar.Name = "btn_IceAktar";
            this.btn_IceAktar.Size = new System.Drawing.Size(75, 23);
            this.btn_IceAktar.TabIndex = 6;
            this.btn_IceAktar.Text = "İçe Aktar";
            this.btn_IceAktar.UseVisualStyleBackColor = true;
            this.btn_IceAktar.Click += new System.EventHandler(this.btn_IceAktar_Click);
            // 
            // btn_DisaAktar
            // 
            this.btn_DisaAktar.Location = new System.Drawing.Point(277, 197);
            this.btn_DisaAktar.Name = "btn_DisaAktar";
            this.btn_DisaAktar.Size = new System.Drawing.Size(75, 23);
            this.btn_DisaAktar.TabIndex = 7;
            this.btn_DisaAktar.Text = "Dışa Aktar";
            this.btn_DisaAktar.UseVisualStyleBackColor = true;
            this.btn_DisaAktar.Click += new System.EventHandler(this.btn_DisaAktar_Click);
            // 
            // btn_Seleniumkapat
            // 
            this.btn_Seleniumkapat.Location = new System.Drawing.Point(129, 247);
            this.btn_Seleniumkapat.Name = "btn_Seleniumkapat";
            this.btn_Seleniumkapat.Size = new System.Drawing.Size(108, 23);
            this.btn_Seleniumkapat.TabIndex = 8;
            this.btn_Seleniumkapat.Text = "Selenium Kapat";
            this.btn_Seleniumkapat.UseVisualStyleBackColor = true;
            this.btn_Seleniumkapat.Click += new System.EventHandler(this.btn_Seleniumkapat_Click);
            // 
            // lb_Hata
            // 
            this.lb_Hata.FormattingEnabled = true;
            this.lb_Hata.Location = new System.Drawing.Point(12, 276);
            this.lb_Hata.Name = "lb_Hata";
            this.lb_Hata.Size = new System.Drawing.Size(340, 69);
            this.lb_Hata.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 353);
            this.Controls.Add(this.lb_Hata);
            this.Controls.Add(this.btn_Seleniumkapat);
            this.Controls.Add(this.btn_DisaAktar);
            this.Controls.Add(this.btn_IceAktar);
            this.Controls.Add(this.lbl_ToplamProxy);
            this.Controls.Add(this.btn_ProxtCek);
            this.Controls.Add(this.tb_Site);
            this.Controls.Add(this.lb_Proxy);
            this.Controls.Add(this.btn_Baslat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Baslat;
        private System.Windows.Forms.ListBox lb_Proxy;
        private System.Windows.Forms.TextBox tb_Site;
        private System.Windows.Forms.Button btn_ProxtCek;
        private System.Windows.Forms.Label lbl_ToplamProxy;
        private System.Windows.Forms.Button btn_IceAktar;
        private System.Windows.Forms.Button btn_DisaAktar;
        private System.Windows.Forms.Button btn_Seleniumkapat;
        private System.Windows.Forms.ListBox lb_Hata;
    }
}

