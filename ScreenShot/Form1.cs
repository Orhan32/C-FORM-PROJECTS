using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap foto;
        Graphics grafik;
        private void ekrangörüntüsü()
        {
            foto = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            grafik = Graphics.FromImage(foto);
            grafik.CopyFromScreen(0, 0, 0, 0, new Size(foto.Width, foto.Height));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;

            ekrangörüntüsü();

            this.Opacity = 1;

            var yer = Application.ExecutablePath;
            foto.Save(yer.Substring(10,0) + "Ekran Görüntüsü.jpeg", ImageFormat.Jpeg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ekrangörüntüsü();
            pictureBox1.Image = foto;
        }
    }
}
