using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Oto_Script_Ekleyici
{
    public partial class btn_Asagi : Form
    {
        public btn_Asagi()
        {
            InitializeComponent();
        }

        private void brn_ScriptCek_Click(object sender, EventArgs e)
        {

            DialogResult sonuc = folderBrowserDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                string yol = folderBrowserDialog1.SelectedPath;
                string[] dosyalar = Directory.GetDirectories(yol).Select(Path.GetFileName).ToArray();
                lb_ScriptCek.Items.AddRange(dosyalar);
            }
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (lb_ScriptCek.Items.Count>0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Metin Dosyası|*.txt";
                save.ValidateNames = true;
                save.FileName = "cikti.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StreamWriter Kayit = new StreamWriter(save.FileName);
                        string startup = "startup=\"1\"";
                        string protection = "";
                        if (cb_Protected.Checked == true)
                        {
                            protection = " protected=\"1\"";
                        }
                        else
                        {
                            protection = " protected=\"0\"";
                        }
                        if (cb_Startup.Checked == false)
                        {
                            startup = "startup=\"0\"";
                        }
                        foreach (var yazi in lb_ScriptCek.Items)
                        {
                            string cumle = "<resource src=\"" + yazi + "\" " + startup + protection + " />";
                            Kayit.WriteLine(cumle);
                        }
                        Kayit.Close();
                        MessageBox.Show("Başarıyla Kaydedildi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: "+ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("İlk Önce Scriptleri Çekin!");
            }

        }

        private void lb_Temizle_Click(object sender, EventArgs e)
        {
            lb_ScriptCek.Items.Clear();
        }

        private void brn_Yukari_Click(object sender, EventArgs e)
        {
            if (lb_ScriptCek.SelectedIndex > -1)
            {
                MoveItem(-1, lb_ScriptCek);
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapın!");
            }
        }

        private void btn_Asa_Click(object sender, EventArgs e)
        {
            if (lb_ScriptCek.SelectedIndex > -1)
            {
                MoveItem(1, lb_ScriptCek);
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapın!");
            }
        }


        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (lb_ScriptCek.SelectedIndex > 0)
            {
                object selected = lb_ScriptCek.SelectedItem;
                lb_ScriptCek.Items.Remove(selected);
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapın!");
            }
        }

        public void MoveItem(int direction, ListBox lb)
        {
            // Checking selected item
            if (lb.SelectedItem == null || lb.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lb.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lb.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lb.SelectedItem;

            // Removing removable element
            lb.Items.Remove(selected);
            // Insert it in new position
            lb.Items.Insert(newIndex, selected);
            // Restore selection
            lb.SetSelected(newIndex, true);
        }
    }
}
