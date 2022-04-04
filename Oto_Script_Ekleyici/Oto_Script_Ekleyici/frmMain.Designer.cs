namespace Oto_Script_Ekleyici
{
    partial class btn_Asagi
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.brn_ScriptCek = new System.Windows.Forms.Button();
            this.lb_ScriptCek = new System.Windows.Forms.ListBox();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.brn_Yukari = new System.Windows.Forms.Button();
            this.btn_Asa = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.cb_Startup = new System.Windows.Forms.CheckBox();
            this.cb_Protected = new System.Windows.Forms.CheckBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Bir Klasör Seçin";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // brn_ScriptCek
            // 
            this.brn_ScriptCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.brn_ScriptCek.Location = new System.Drawing.Point(12, 12);
            this.brn_ScriptCek.Name = "brn_ScriptCek";
            this.brn_ScriptCek.Size = new System.Drawing.Size(113, 30);
            this.brn_ScriptCek.TabIndex = 0;
            this.brn_ScriptCek.Text = "Scriptleri Çek";
            this.brn_ScriptCek.UseVisualStyleBackColor = true;
            this.brn_ScriptCek.Click += new System.EventHandler(this.brn_ScriptCek_Click);
            // 
            // lb_ScriptCek
            // 
            this.lb_ScriptCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lb_ScriptCek.FormattingEnabled = true;
            this.lb_ScriptCek.ItemHeight = 18;
            this.lb_ScriptCek.Location = new System.Drawing.Point(131, 12);
            this.lb_ScriptCek.Name = "lb_ScriptCek";
            this.lb_ScriptCek.Size = new System.Drawing.Size(254, 166);
            this.lb_ScriptCek.TabIndex = 1;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Temizle.Location = new System.Drawing.Point(310, 184);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 27);
            this.btn_Temizle.TabIndex = 2;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.lb_Temizle_Click);
            // 
            // brn_Yukari
            // 
            this.brn_Yukari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brn_Yukari.Location = new System.Drawing.Point(12, 112);
            this.brn_Yukari.Name = "brn_Yukari";
            this.brn_Yukari.Size = new System.Drawing.Size(113, 30);
            this.brn_Yukari.TabIndex = 3;
            this.brn_Yukari.Text = "Yukarı Taşı";
            this.brn_Yukari.UseVisualStyleBackColor = true;
            this.brn_Yukari.Click += new System.EventHandler(this.brn_Yukari_Click);
            // 
            // btn_Asa
            // 
            this.btn_Asa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Asa.Location = new System.Drawing.Point(12, 148);
            this.btn_Asa.Name = "btn_Asa";
            this.btn_Asa.Size = new System.Drawing.Size(113, 30);
            this.btn_Asa.TabIndex = 4;
            this.btn_Asa.Text = "Aşağı taşı";
            this.btn_Asa.UseVisualStyleBackColor = true;
            this.btn_Asa.Click += new System.EventHandler(this.btn_Asa_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Sil.Location = new System.Drawing.Point(131, 184);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(94, 27);
            this.btn_Sil.TabIndex = 5;
            this.btn_Sil.Text = "Seçileni Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // cb_Startup
            // 
            this.cb_Startup.AutoSize = true;
            this.cb_Startup.Checked = true;
            this.cb_Startup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Startup.Location = new System.Drawing.Point(12, 262);
            this.cb_Startup.Name = "cb_Startup";
            this.cb_Startup.Size = new System.Drawing.Size(60, 17);
            this.cb_Startup.TabIndex = 8;
            this.cb_Startup.Text = "Startup";
            this.cb_Startup.UseVisualStyleBackColor = true;
            // 
            // cb_Protected
            // 
            this.cb_Protected.AutoSize = true;
            this.cb_Protected.Location = new System.Drawing.Point(12, 285);
            this.cb_Protected.Name = "cb_Protected";
            this.cb_Protected.Size = new System.Drawing.Size(72, 17);
            this.cb_Protected.TabIndex = 9;
            this.cb_Protected.Text = "Protected";
            this.cb_Protected.UseVisualStyleBackColor = true;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Kaydet.Location = new System.Drawing.Point(12, 304);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(124, 30);
            this.btn_Kaydet.TabIndex = 10;
            this.btn_Kaydet.Text = "Scriptleri Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Asagi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 346);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.cb_Protected);
            this.Controls.Add(this.cb_Startup);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Asa);
            this.Controls.Add(this.brn_Yukari);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.lb_ScriptCek);
            this.Controls.Add(this.brn_ScriptCek);
            this.MaximumSize = new System.Drawing.Size(416, 385);
            this.MinimumSize = new System.Drawing.Size(416, 385);
            this.Name = "btn_Asagi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mta Otomatik Script Ekleyici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button brn_ScriptCek;
        private System.Windows.Forms.ListBox lb_ScriptCek;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button brn_Yukari;
        private System.Windows.Forms.Button btn_Asa;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.CheckBox cb_Startup;
        private System.Windows.Forms.CheckBox cb_Protected;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

