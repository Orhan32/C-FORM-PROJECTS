using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using System.IO;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Twitch_Bot
{
    public partial class Twitch : MaterialForm
    {
        public Twitch()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        IWebDriver driver;
        public async void driverBaslat(string proxy)
        {
            ChromeDriverService cds = ChromeDriverService.CreateDefaultService();
            cds.HideCommandPromptWindow = true;
            ChromeOptions co = new ChromeOptions();

            if (!string.IsNullOrEmpty(proxy))
            {
                Proxy prxy = new Proxy();
                prxy.Kind = ProxyKind.Manual;
                prxy.IsAutoDetect = false;
                prxy.SslProxy = proxy;
                co.Proxy = prxy;
                co.AddArgument("ignore-certificate-errors");
                //co.AddArgument("--proxy-server=" + proxy);
            }
            driver = new ChromeDriver(cds, co);
            await Task.Delay(2000);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
            rtbProxy.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TXT|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbProxy.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private async void btnGonder_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                try
                {
                    for (int i = 0; i < rtbProxy.Lines.Length; i++)
                    {
                        driverBaslat(rtbProxy.Lines[i]);
                        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                        driver.Navigate().GoToUrl("https://www.twitch.tv/" + tbKanalAdi.Text);
                        await Task.Delay(1000);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}
