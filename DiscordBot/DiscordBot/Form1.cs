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

namespace DiscordBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string randomkod()
        {
            Random rnd = new Random();
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < 16; i++)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            string kod = "http://discord.gift/"+res.ToString();
            return kod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            site();
        }

        IWebDriver driver;

        private async void site()
        {
            await Task.Run(async () =>
            {
                ChromeDriverService cds = ChromeDriverService.CreateDefaultService();
                cds.HideCommandPromptWindow = true;
                ChromeOptions co = new ChromeOptions();
                co.AddArguments(@"user-data-dir=" + Application.StartupPath + "\\profile");
                co.AddExcludedArgument("enable-automation");
                driver = new ChromeDriver(cds, co);
                driver.Navigate().GoToUrl("https://discord.com/channels/730905860976410702/730907991938695180");
                try
                {
                    for (int i = 0; i < 16; i++)
                    {
                        IWebElement eogenerator = driver.FindElement(By.CssSelector("#app-mount > div.app-1q1i1E > div > div.layers-3iHuyZ.layers-3q14ss > div > div > div > div.content-98HsJk > div.chat-3bRxxu > div > main > form > div > div > div > div > div.textArea-12jD-V.textAreaSlate-1ZzRVj.slateContainer-3Qkn2x > div.markup-2BOw-j.slateTextArea-1Mkdgw.fontSize16Padding-3Wk7zP > div"));
                        eogenerator.SendKeys(randomkod());
                        eogenerator.SendKeys(OpenQA.Selenium.Keys.Enter);
                        await Task.Delay(2000);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                await Task.Delay(100);
            });
        }
    }
}
