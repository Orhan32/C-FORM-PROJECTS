namespace Twitch_Bot
{
    partial class Twitch
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
            this.lblKanalAdi = new System.Windows.Forms.Label();
            this.tbKanalAdi = new System.Windows.Forms.TextBox();
            this.lbl_Metot = new System.Windows.Forms.Label();
            this.cbMetot = new System.Windows.Forms.ComboBox();
            this.lblKisi = new System.Windows.Forms.Label();
            this.nudKisi = new System.Windows.Forms.NumericUpDown();
            this.rtbProxy = new System.Windows.Forms.RichTextBox();
            this.lblProxy = new System.Windows.Forms.Label();
            this.btnProxy = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKanalAdi
            // 
            this.lblKanalAdi.AutoSize = true;
            this.lblKanalAdi.BackColor = System.Drawing.Color.White;
            this.lblKanalAdi.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKanalAdi.Location = new System.Drawing.Point(12, 79);
            this.lblKanalAdi.Name = "lblKanalAdi";
            this.lblKanalAdi.Size = new System.Drawing.Size(78, 21);
            this.lblKanalAdi.TabIndex = 0;
            this.lblKanalAdi.Text = "Kanal Adı:";
            // 
            // tbKanalAdi
            // 
            this.tbKanalAdi.Font = new System.Drawing.Font("Ebrima", 10F);
            this.tbKanalAdi.Location = new System.Drawing.Point(96, 79);
            this.tbKanalAdi.Name = "tbKanalAdi";
            this.tbKanalAdi.Size = new System.Drawing.Size(158, 26);
            this.tbKanalAdi.TabIndex = 1;
            // 
            // lbl_Metot
            // 
            this.lbl_Metot.AutoSize = true;
            this.lbl_Metot.BackColor = System.Drawing.Color.White;
            this.lbl_Metot.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Metot.Location = new System.Drawing.Point(12, 116);
            this.lbl_Metot.Name = "lbl_Metot";
            this.lbl_Metot.Size = new System.Drawing.Size(54, 21);
            this.lbl_Metot.TabIndex = 2;
            this.lbl_Metot.Text = "Metot:";
            // 
            // cbMetot
            // 
            this.cbMetot.Font = new System.Drawing.Font("Ebrima", 10F);
            this.cbMetot.FormattingEnabled = true;
            this.cbMetot.Items.AddRange(new object[] {
            "HTTP(s)",
            "SOCKS"});
            this.cbMetot.Location = new System.Drawing.Point(96, 116);
            this.cbMetot.Name = "cbMetot";
            this.cbMetot.Size = new System.Drawing.Size(121, 25);
            this.cbMetot.TabIndex = 3;
            // 
            // lblKisi
            // 
            this.lblKisi.AutoSize = true;
            this.lblKisi.BackColor = System.Drawing.Color.White;
            this.lblKisi.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisi.Location = new System.Drawing.Point(12, 153);
            this.lblKisi.Name = "lblKisi";
            this.lblKisi.Size = new System.Drawing.Size(37, 21);
            this.lblKisi.TabIndex = 0;
            this.lblKisi.Text = "Kişi:";
            // 
            // nudKisi
            // 
            this.nudKisi.Font = new System.Drawing.Font("Ebrima", 10F);
            this.nudKisi.Location = new System.Drawing.Point(96, 153);
            this.nudKisi.Name = "nudKisi";
            this.nudKisi.Size = new System.Drawing.Size(120, 26);
            this.nudKisi.TabIndex = 4;
            // 
            // rtbProxy
            // 
            this.rtbProxy.Font = new System.Drawing.Font("Ebrima", 12F);
            this.rtbProxy.Location = new System.Drawing.Point(14, 219);
            this.rtbProxy.Name = "rtbProxy";
            this.rtbProxy.Size = new System.Drawing.Size(330, 108);
            this.rtbProxy.TabIndex = 5;
            this.rtbProxy.Text = "";
            // 
            // lblProxy
            // 
            this.lblProxy.AutoSize = true;
            this.lblProxy.BackColor = System.Drawing.Color.White;
            this.lblProxy.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProxy.Location = new System.Drawing.Point(12, 195);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(52, 21);
            this.lblProxy.TabIndex = 6;
            this.lblProxy.Text = "Proxy:";
            // 
            // btnProxy
            // 
            this.btnProxy.BackColor = System.Drawing.Color.White;
            this.btnProxy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProxy.Font = new System.Drawing.Font("Ebrima", 9.5F);
            this.btnProxy.Location = new System.Drawing.Point(223, 195);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(121, 25);
            this.btnProxy.TabIndex = 7;
            this.btnProxy.Text = "Proxy Ekle";
            this.btnProxy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProxy.UseVisualStyleBackColor = false;
            this.btnProxy.Click += new System.EventHandler(this.btnProxy_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.DeepPink;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGonder.Font = new System.Drawing.Font("Ebrima", 10F);
            this.btnGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGonder.Location = new System.Drawing.Point(16, 339);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(330, 30);
            this.btnGonder.TabIndex = 8;
            this.btnGonder.Text = "İzleyici Gönderimini Başlat";
            this.btnGonder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // Twitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 381);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnProxy);
            this.Controls.Add(this.lblProxy);
            this.Controls.Add(this.rtbProxy);
            this.Controls.Add(this.nudKisi);
            this.Controls.Add(this.cbMetot);
            this.Controls.Add(this.lbl_Metot);
            this.Controls.Add(this.lblKisi);
            this.Controls.Add(this.tbKanalAdi);
            this.Controls.Add(this.lblKanalAdi);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Twitch";
            this.Text = "Twitch Viwer Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKanalAdi;
        private System.Windows.Forms.TextBox tbKanalAdi;
        private System.Windows.Forms.Label lbl_Metot;
        private System.Windows.Forms.ComboBox cbMetot;
        private System.Windows.Forms.Label lblKisi;
        private System.Windows.Forms.NumericUpDown nudKisi;
        private System.Windows.Forms.RichTextBox rtbProxy;
        private System.Windows.Forms.Label lblProxy;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.Button btnGonder;
    }
}

