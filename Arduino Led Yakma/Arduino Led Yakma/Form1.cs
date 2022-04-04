using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Led_Yakma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ledyak_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            lbl_leddurum.Text = "Led yanıyor";
        }

        private void btn_ledsondur_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            lbl_leddurum.Text = "Led söndü";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }
    }
}
