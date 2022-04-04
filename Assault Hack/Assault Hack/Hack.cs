using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Assault_Hack
{
    public partial class Hack : Form
    {
        Mem memory = new Mem();
        public static string RifleAmmo= "ac_client.exe+0x00109B74,150";
        public Hack()
        {
            InitializeComponent();
        }

        private void Ammo()
        {
            while(true)
            {
                if (cb_Ammo.Checked)
                {
                    memory.WriteMemory(RifleAmmo, "int", "32");
                    Thread.Sleep(2);
                }
                Thread.Sleep(2);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Hack_Click(object sender, EventArgs e)
        {
            int PID = memory.GetProcIdFromName("ac_client");
            if (PID > 1)
            {
                memory.OpenProcess(PID);
                Thread tr = new Thread(Ammo) { IsBackground = true };
                tr.Start();
            }
        }
    }
}
