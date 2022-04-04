using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedArduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string durum = serialPort1.ReadExisting();
                if (durum == "1")
                {
                    textBox1.Text = "LED YANIYOR";
                }
                else if (durum == "0")
                    textBox1.Text = "LED YANMIYOR";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            serialPort1.Close();
        }
    }
}
