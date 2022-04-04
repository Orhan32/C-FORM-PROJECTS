using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sınav
{
    public partial class frmSınav : Form
    {
        public frmSınav()
        {
            InitializeComponent();
        }

        private void frmSınav_Load(object sender, EventArgs e)
        {
            using (var baglan= new MySqlConnection("server=localhost;Database=Sınav;UID=root;PWD=123456789"))
            {
                try
                {
                    baglan.Open();
                    lbl_Baglanti.Text = "Veritabanına Bağlanıldı";
                    lbl_Baglanti.ForeColor = Color.Green;
                    baglan.Close();

                    using (var cmd = new MySqlCommand("select * from sorular", baglan))
                    {
                        try
                        {

                            cmd.Connection.Open();
                            MySqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                pb_Image.Load(dr["resimUrl"].ToString());
                                lbl_Soru.Text = dr["soru"].ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    lbl_Baglanti.Text = "Veritabanına Bağlanılmadı: "+ex.Message;
                    lbl_Baglanti.ForeColor = Color.Red;
                }
            }

        }
    }
}
