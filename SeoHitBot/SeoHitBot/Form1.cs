using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeoHitBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_Hit_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                try
                {

                    IWebDriver driver = new ChromeDriver();
                    string url = Uri.EscapeUriString("https://www.google.com/search?q=Orhan Kalkan");
                    driver.Navigate().GoToUrl(url);
                    await Task.Delay(2000);

                    driver.FindElement(By.CssSelector("#xjs > div > table > tbody > tr > td:nth-child(5) > a")).Click();

                    IList<IWebElement> sonuclar = driver.FindElements(By.CssSelector("#search"));
                    //foreach (IWebElement item in sonuclar)
                    //{
                    //    IWebElement a = item.FindElement(By.TagName("a"));
                    //    if (a.GetAttribute("href").Contains("orhankalkan.com"))
                    //    {
                    //        driver.Navigate().GoToUrl(a.GetAttribute("href"));
                    //        break;
                    //    }
                    //}
                    //driver.Quit();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Hata: " + Ex.Message);
                }
            });
        }
    }
}
