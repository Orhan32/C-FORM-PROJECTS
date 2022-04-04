using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AutoIt AutoIt = new AutoIt();
        Bitmap resim;
        private void button1_Click(object sender, EventArgs e)
        {
            resim = new Bitmap(40,25);
            Graphics gp = Graphics.FromImage(resim);
            gp.CopyFromScreen(82,370,0,0,new Size(50,25));
            pictureBox1.Image = resim;

            //string fileName = "./img" +@"\resim"+".png";
            //resim.Save(fileName);
            //AutoIt.mouseClick("LEFT",37,229,2,1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var img = new Bitmap(pictureBox1.Image);
            textBox1.Text = GetText(img).Trim();
            //var img = new Bitmap("./img/resim.png");
            //var ocr = new TesseractEngine("./tessdata", "eng");
            //var sonuc = ocr.Process(resim);
            //textBox1.Text = sonuc.GetText().Trim();
            Clipboard.SetText(textBox1.Text.Trim());
            //AutoIt.mouseClick("LEFT", 137, 378, 1, 1);
            //AutoIt.mouseClick("LEFT", 878, 50, 1, 1);
            //SendKeys.Send(textBox1.Text.Trim());

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string kelime = textBox1.Text;
            for (int i = 0; i < kelime.Length; i++)
            {
                AutoIt.mouseClick("LEFT", 137, 378, 1, 1);
                SendKeys.Send(kelime[i].ToString());

            }

        }

        public static string GetText(Bitmap imgsource)
        {
            var ocrtext = string.Empty;
            using (var engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default))
            {
                using (var img = PixConverter.ToPix(imgsource))
                {
                    using (var page = engine.Process(img))
                    {
                        ocrtext = page.GetText();
                    }
                }              
            }         
            return ocrtext;        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
