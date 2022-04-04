namespace SeoHitBot
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
            this.tb_Site = new System.Windows.Forms.TextBox();
            this.btn_Hit = new System.Windows.Forms.Button();
            this.tb_Aranacak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Site
            // 
            this.tb_Site.Location = new System.Drawing.Point(107, 44);
            this.tb_Site.Name = "tb_Site";
            this.tb_Site.Size = new System.Drawing.Size(208, 20);
            this.tb_Site.TabIndex = 0;
            // 
            // btn_Hit
            // 
            this.btn_Hit.Location = new System.Drawing.Point(116, 70);
            this.btn_Hit.Name = "btn_Hit";
            this.btn_Hit.Size = new System.Drawing.Size(75, 23);
            this.btn_Hit.TabIndex = 1;
            this.btn_Hit.Text = "Hit Yap";
            this.btn_Hit.UseVisualStyleBackColor = true;
            this.btn_Hit.Click += new System.EventHandler(this.btn_Hit_Click);
            // 
            // tb_Aranacak
            // 
            this.tb_Aranacak.Location = new System.Drawing.Point(107, 12);
            this.tb_Aranacak.Name = "tb_Aranacak";
            this.tb_Aranacak.Size = new System.Drawing.Size(208, 20);
            this.tb_Aranacak.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aranacak Kelime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gidilecek Site";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Aranacak);
            this.Controls.Add(this.btn_Hit);
            this.Controls.Add(this.tb_Site);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Site;
        private System.Windows.Forms.Button btn_Hit;
        private System.Windows.Forms.TextBox tb_Aranacak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

