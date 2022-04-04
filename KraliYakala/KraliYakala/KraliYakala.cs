using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KraliYakala
{
    public partial class KraliYakala : Form
    {
        public KraliYakala()
        {
            InitializeComponent();
        }

        private int sayicek()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 7);
            return sayi;
        }
        private void KraliYakala_Load(object sender, EventArgs e)
        {

        }

        private void button_Kart1_Click(object sender, EventArgs e)
        {
            int a =sayicek();
            label_Puan.Text = a.ToString();
        }
    }
}
