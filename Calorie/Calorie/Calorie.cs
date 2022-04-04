using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie
{
    public partial class Calorie : Form
    {
        MysqlConnection mysql = new MysqlConnection();
        public Calorie()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mysql.Connection(true);
        }
    }
}
