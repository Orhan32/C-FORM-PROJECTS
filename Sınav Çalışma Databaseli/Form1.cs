using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Entity.Validation;

namespace Sınav_Çalışma
{
    public partial class btn_ : Form
    {
        public btn_()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HU0MT49\\SQLEXPRESS;Initial Catalog=OgrBilSis;Integrated Security=True");

        private void veriyicek()
        {
            baglanti.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Ogrenciler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void cb1()
        {
            baglanti.Open();
            int deger = cbFakulte.SelectedIndex + 1;
            SqlCommand komut = new SqlCommand("SELECT * FROM Bolumler Bl INNER JOIN Fakulteler Fk ON Fk.FakulteID =Bl.FakulteID WHERE FK.FakulteID='" + deger + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbBolum.Items.Add(dr["BolumAdi"]);
            }
            dr.Close();
            baglanti.Close();
        }

        private void cb2()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Fakulteler", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbFakulte.Items.Add(dr["FakulteAdi"]);
            }
            dr.Close();
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            veriyicek();
            txtNo2.Clear();
            cb2();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtNo2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Bay")
            {
                rbBay.Checked = true;
            }
            else
            {
                rbBayan.Checked = true;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            if (rbBay.Checked == true)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO Ogrenciler(OgrNo,OgrAd,OgrSoyad,TCKimlik,Cinsiyet) VALUES ('" + txtNo.Text.ToString() + "','" + txtAd.Text.ToString() + "','" + txtSoyad.Text.ToString() + "','" + txtTc.Text.ToString() + "','" + rbBay.Text.ToString() + "')", baglanti);
                komut.ExecuteNonQuery();
            }
            else
            {
                SqlCommand komut = new SqlCommand("INSERT INTO Ogrenciler(OgrNo,OgrAd,OgrSoyad,TCKimlik,Cinsiyet) VALUES ('" + txtNo.Text.ToString() + "','" + txtAd.Text.ToString() + "','" + txtSoyad.Text.ToString() + "','" + txtTc.Text.ToString() + "','" + rbBayan.Text.ToString() + "')", baglanti);
                komut.ExecuteNonQuery();
            }

            baglanti.Close();
            veriyicek();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtNo2.Text == "")
            {
                MessageBox.Show("Lütfen Öğrenci No Giriniz.");
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Ogrenciler WHERE OgrNo='" + txtNo2.Text.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriyicek();
            txtNo2.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Ogrenciler SET OgrAd='" + txtAd.Text.ToString() + "',OgrSoyad='" + txtSoyad.Text.ToString() + "',TCKimlik='" + txtTc.Text.ToString() + "'WHERE OgrNo='" + txtNo.Text.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriyicek();
        }

        private void cbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBolum.Items.Clear();
            cbBolum.Text = "";
            cb1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_EntityEkle_Click(object sender, EventArgs e)
        {

        }

        private void btn_Goster_Click(object sender, EventArgs e)
        {
            string deger;
            if (checkBox1.Checked==true)
            {
                deger = "Ogrenciler";
                baglanti.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM "+deger+"", baglanti);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                FrmView frm1 = new FrmView();
                frm1.Show();
                FrmView frm2 = (FrmView)Application.OpenForms["FrmView"];
                frm2.dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            else if (checkBox2.Checked==true)
            {
                deger = "Notlar";
                baglanti.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM " + deger + "", baglanti);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                FrmView frm1 = new FrmView();
                frm1.Show();
                FrmView frm2 = (FrmView)Application.OpenForms["FrmView"];
                frm2.dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız!");
            }
        }
    }
}
