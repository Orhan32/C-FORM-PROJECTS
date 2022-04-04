namespace Assault_Hack
{
    partial class Hack
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
            this.cb_Ammo = new System.Windows.Forms.CheckBox();
            this.btn_Hack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Ammo
            // 
            this.cb_Ammo.AutoSize = true;
            this.cb_Ammo.Location = new System.Drawing.Point(12, 12);
            this.cb_Ammo.Name = "cb_Ammo";
            this.cb_Ammo.Size = new System.Drawing.Size(84, 17);
            this.cb_Ammo.TabIndex = 0;
            this.cb_Ammo.Text = "Ammo Hack";
            this.cb_Ammo.UseVisualStyleBackColor = true;
            // 
            // btn_Hack
            // 
            this.btn_Hack.Location = new System.Drawing.Point(12, 64);
            this.btn_Hack.Name = "btn_Hack";
            this.btn_Hack.Size = new System.Drawing.Size(96, 23);
            this.btn_Hack.TabIndex = 1;
            this.btn_Hack.Text = "Hileyi Etkinleştir";
            this.btn_Hack.UseVisualStyleBackColor = true;
            this.btn_Hack.Click += new System.EventHandler(this.btn_Hack_Click);
            // 
            // Hack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 213);
            this.Controls.Add(this.btn_Hack);
            this.Controls.Add(this.cb_Ammo);
            this.Name = "Hack";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Ammo;
        private System.Windows.Forms.Button btn_Hack;
    }
}

