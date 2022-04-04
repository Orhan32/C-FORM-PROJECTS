using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MtaTrigger
{
    public partial class Form1 : Form
    {
        AutoIt AutoIt = new AutoIt();

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        //[DllImport("user32.dll")]
        //static extern void mouse_event(int a, int b, int c, int d, int swed);

        //int leftDown = 0x02;
        //int leftUp = 0x04;

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        Color oldCol;
        Color newCol;

        Point xy = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + 1, Screen.PrimaryScreen.Bounds.Height / 2 + 1);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(trigger) { IsBackground = true };
            th.Start();
            
        }
        void trigger()
        {
            while (true)
            {
                if (GetAsyncKeyState(Keys.LShiftKey)<0)
                {
                    Thread.Sleep(10);
                    oldCol = GetPixel(xy);
                    Thread.Sleep(5);
                    newCol = GetPixel(xy);
                    if (oldCol.Equals(newCol)==false)
                    {
                        Thread.Sleep(10);
                        //mouse_event(leftDown, 0, 0, 0, 0);
                        AutoIt.mouseClick("LEFT", 0, 0, 1, 1);
                        Thread.Sleep(2);
                        //mouse_event(leftUp, 0, 0, 0, 0);
                        AutoIt.mouseClick("LEFT", 0, 0, 1, 1);
                        Thread.Sleep(2000);
                    }
                }
                Thread.Sleep(2);
            }
        }
        Color GetPixel(Point position)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }
    }
}
