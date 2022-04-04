using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
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

namespace ProxyBot
{
    public partial class Form1 : Form
    {
        public Form1()
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
                co.AddArgument("--proxy-server=" + proxy);
            }
            driver = new ChromeDriver(cds, co);
            await Task.Delay(2000);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                try
                {
                    for (int i = 0; i < lb_Proxy.Items.Count; i++)
                    {
                        driverBaslat(lb_Proxy.Items[i].ToString());
                        driver.Navigate().GoToUrl(tb_Site.Text);
                        await Task.Delay(2000);
                        driver.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            });
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                ChromeDriverService cds = ChromeDriverService.CreateDefaultService();
                cds.HideCommandPromptWindow = true;
                ChromeOptions co = new ChromeOptions();
                co.AddArguments(@"user-data-dir=" + Application.StartupPath + "\\profile");
                co.AddExcludedArgument("enable-automation");
                driver = new ChromeDriver(cds, co);
                driver.Navigate().GoToUrl("http://www.freeproxylists.net/");
                try
                {
                    IWebElement proxyIp = driver.FindElement(By.XPath("//table[@class='DataGrid']//tr[2]//td[3]"));
                    IWebElement proxyPort = driver.FindElement(By.CssSelector("body > div:nth-child(3) > div:nth-child(2) > table > tbody > tr:nth-child(2) > td:nth-child(2)"));
                    lb_Proxy.Items.Add(proxyIp + ":" + proxyPort);

                    //for (int i = 2; i < 53; i++)
                    //{
                    //    IWebElement proxyIp = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/table/tbody/tr["+i+"]/td[1]/a"));
                    //    IWebElement proxyPort = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/table/tbody/tr["+i+"]/td[2] "));
                    //    lb_Proxy.Items.Add(proxyIp + ":" + proxyPort);
                    //}
                    //for (int i = 2; i < 35; i++)
                    //{
                    //    IWebElement sayfa = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/a[" + i + "]"));
                    //}
                    //seleniumKapat();
                }
                catch (Exception Ex)
                {
                    lb_Hata.Items.Add("Hata: " + Ex.Message);
                }

                await Task.Delay(100);
            });
        }

        private void btn_DisaAktar_Click(object sender, EventArgs e)
        {
            string fileName = "data.txt";
            string lb_Data = "";
            foreach (string str in lb_Proxy.Items)
            {
                lb_Data += str + "\n";
            }

            File.WriteAllText(fileName, lb_Data);
        }

        private void btn_IceAktar_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                lb_Proxy.Items.Add(line);
                lbl_ToplamProxy.Text = "Toplam proxy: " + lb_Proxy.Items.Count.ToString();
            }
            sr.Close();
        }

        private void seleniumKapat()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        private void btn_Seleniumkapat_Click(object sender, EventArgs e)
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
