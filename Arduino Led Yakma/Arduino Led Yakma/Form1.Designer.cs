namespace Arduino_Led_Yakma
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
            this.components = new System.ComponentModel.Container();
            this.btn_ledyak = new System.Windows.Forms.Button();
            this.btn_ledsondur = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbl_leddurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ledyak
            // 
            this.btn_ledyak.Location = new System.Drawing.Point(12, 72);
            this.btn_ledyak.Name = "btn_ledyak";
            this.btn_ledyak.Size = new System.Drawing.Size(137, 42);
            this.btn_ledyak.TabIndex = 0;
            this.btn_ledyak.Text = "LED YAK";
            this.btn_ledyak.UseVisualStyleBackColor = true;
            this.btn_ledyak.Click += new System.EventHandler(this.btn_ledyak_Click);
            // 
            // btn_ledsondur
            // 
            this.btn_ledsondur.Location = new System.Drawing.Point(225, 72);
            this.btn_ledsondur.Name = "btn_ledsondur";
            this.btn_ledsondur.Size = new System.Drawing.Size(137, 42);
            this.btn_ledsondur.TabIndex = 0;
            this.btn_ledsondur.Text = "LED SÖNDÜR";
            this.btn_ledsondur.UseVisualStyleBackColor = true;
            this.btn_ledsondur.Click += new System.EventHandler(this.btn_ledsondur_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // lbl_leddurum
            // 
            this.lbl_leddurum.AutoSize = true;
            this.lbl_leddurum.Location = new System.Drawing.Point(12, 146);
            this.lbl_leddurum.Name = "lbl_leddurum";
            this.lbl_leddurum.Size = new System.Drawing.Size(0, 13);
            this.lbl_leddurum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 227);
            this.Controls.Add(this.lbl_leddurum);
            this.Controls.Add(this.btn_ledsondur);
            this.Controls.Add(this.btn_ledyak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ledyak;
        private System.Windows.Forms.Button btn_ledsondur;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbl_leddurum;
    }
}

