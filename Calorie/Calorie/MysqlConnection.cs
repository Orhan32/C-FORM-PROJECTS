using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie
{
    class MysqlConnection
    {
        public void Connection(bool ctrl)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ("Server=localhost;database=kalori;user id=root;");
            if (ctrl == true)
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Bağlantı Başarılı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    throw;
                }
            }
            else
            {
                try
                {
                    connection.Close();
                    MessageBox.Show("Bağlantı Kapatıldı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    throw;
                }
            }
        }
    }
}
