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

namespace Among_US
{
    public partial class Form1 : Form
    {
        Mem memory = new Mem();
        public static string SpeedHack = "GameAssembly.dll+0x00DAE56C,0x4BC,0x0,0x5C";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = memory.GetProcIdFromName("Among Us");
            if (PID>1)
            {
                memory.OpenProcess(PID);
                Thread th = new Thread(Speed) { IsBackground = true };
                th.Start();
            }
        }

        private void Speed()
        {
            while (true)
            {
                if (checkBox1.Checked)
                {
                    memory.WriteMemory(SpeedHack, "int", "5");
                    Thread.Sleep(2);
                }
                Thread.Sleep(2);
            }
        }
    }
}
