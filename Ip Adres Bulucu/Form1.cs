using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ip_Adres_Bulucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a, b;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
  

            if (textBox1.Text!="")
            {
                XmlTextReader reader = new XmlTextReader("http://ip-api.com/xml/" + textBox1.Text);
                while (reader.Read())
                {
                    if (reader.NodeType==XmlNodeType.Element)
                    {

                        if (reader.Name == "country")
                        {
                            reader.Read();
                            richTextBox1.Text += "Ülke: " + reader.Value.ToString() + "\n";
                        }
                        if (reader.Name == "regionName")
                        {
                            reader.Read();
                            richTextBox1.Text += "Şehir: " + reader.Value.ToString() + "\n";
                        }

                        if (reader.Name == "isp")
                        {
                            reader.Read();
                            richTextBox1.Text += "ISS: " + reader.Value.ToString() + "\n";
                        }
                        if (reader.Name== "lat")
                        {
                            reader.Read();
                            a = reader.Value;
                        }
                        if (reader.Name == "lon")
                        {
                            reader.Read();
                            b = reader.Value;
                        }
                    }
                }
                pictureBox1.LoadAsync("https://cache.ip-api.com/" + b + "," + a + ",10");
                reader.Close();
            }
        }
    }
}
