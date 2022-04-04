
namespace Sınav
{
    partial class frmSınav
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
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.lbl_Soru = new System.Windows.Forms.Label();
            this.btn_Cevapla = new System.Windows.Forms.Button();
            this.rb_A = new System.Windows.Forms.RadioButton();
            this.rb_B = new System.Windows.Forms.RadioButton();
            this.rb_C = new System.Windows.Forms.RadioButton();
            this.rb_D = new System.Windows.Forms.RadioButton();
            this.lbl_Baglanti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Image
            // 
            this.pb_Image.Location = new System.Drawing.Point(13, 13);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(180, 190);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 0;
            this.pb_Image.TabStop = false;
            // 
            // lbl_Soru
            // 
            this.lbl_Soru.AutoSize = true;
            this.lbl_Soru.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Soru.Location = new System.Drawing.Point(195, 29);
            this.lbl_Soru.Name = "lbl_Soru";
            this.lbl_Soru.Size = new System.Drawing.Size(39, 20);
            this.lbl_Soru.TabIndex = 1;
            this.lbl_Soru.Text = "Soru";
            // 
            // btn_Cevapla
            // 
            this.btn_Cevapla.Location = new System.Drawing.Point(199, 180);
            this.btn_Cevapla.Name = "btn_Cevapla";
            this.btn_Cevapla.Size = new System.Drawing.Size(75, 23);
            this.btn_Cevapla.TabIndex = 2;
            this.btn_Cevapla.Text = "Cevapla";
            this.btn_Cevapla.UseVisualStyleBackColor = true;
            // 
            // rb_A
            // 
            this.rb_A.AutoSize = true;
            this.rb_A.Location = new System.Drawing.Point(199, 95);
            this.rb_A.Name = "rb_A";
            this.rb_A.Size = new System.Drawing.Size(50, 17);
            this.rb_A.TabIndex = 3;
            this.rb_A.TabStop = true;
            this.rb_A.Text = "Şık A";
            this.rb_A.UseVisualStyleBackColor = true;
            // 
            // rb_B
            // 
            this.rb_B.AutoSize = true;
            this.rb_B.Location = new System.Drawing.Point(400, 95);
            this.rb_B.Name = "rb_B";
            this.rb_B.Size = new System.Drawing.Size(50, 17);
            this.rb_B.TabIndex = 3;
            this.rb_B.TabStop = true;
            this.rb_B.Text = "Şık B";
            this.rb_B.UseVisualStyleBackColor = true;
            // 
            // rb_C
            // 
            this.rb_C.AutoSize = true;
            this.rb_C.Location = new System.Drawing.Point(199, 128);
            this.rb_C.Name = "rb_C";
            this.rb_C.Size = new System.Drawing.Size(50, 17);
            this.rb_C.TabIndex = 3;
            this.rb_C.TabStop = true;
            this.rb_C.Text = "Şık C";
            this.rb_C.UseVisualStyleBackColor = true;
            // 
            // rb_D
            // 
            this.rb_D.AutoSize = true;
            this.rb_D.Location = new System.Drawing.Point(400, 128);
            this.rb_D.Name = "rb_D";
            this.rb_D.Size = new System.Drawing.Size(51, 17);
            this.rb_D.TabIndex = 3;
            this.rb_D.TabStop = true;
            this.rb_D.Text = "Şık D";
            this.rb_D.UseVisualStyleBackColor = true;
            // 
            // lbl_Baglanti
            // 
            this.lbl_Baglanti.AutoSize = true;
            this.lbl_Baglanti.Location = new System.Drawing.Point(13, 210);
            this.lbl_Baglanti.Name = "lbl_Baglanti";
            this.lbl_Baglanti.Size = new System.Drawing.Size(35, 13);
            this.lbl_Baglanti.TabIndex = 4;
            this.lbl_Baglanti.Text = "label1";
            // 
            // frmSınav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 228);
            this.Controls.Add(this.lbl_Baglanti);
            this.Controls.Add(this.rb_D);
            this.Controls.Add(this.rb_C);
            this.Controls.Add(this.rb_B);
            this.Controls.Add(this.rb_A);
            this.Controls.Add(this.btn_Cevapla);
            this.Controls.Add(this.lbl_Soru);
            this.Controls.Add(this.pb_Image);
            this.Name = "frmSınav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSınav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Label lbl_Soru;
        private System.Windows.Forms.Button btn_Cevapla;
        private System.Windows.Forms.RadioButton rb_A;
        private System.Windows.Forms.RadioButton rb_B;
        private System.Windows.Forms.RadioButton rb_C;
        private System.Windows.Forms.RadioButton rb_D;
        private System.Windows.Forms.Label lbl_Baglanti;
    }
}

