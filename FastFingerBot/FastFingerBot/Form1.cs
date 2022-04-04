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

namespace FastFingerBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IWebDriver driver;

        private void Form1_Load(object sender, EventArgs e)
        {
            ChromeDriverService cds = ChromeDriverService.CreateDefaultService();
            cds.HideCommandPromptWindow = true;
            ChromeOptions co = new ChromeOptions();
            co.AddArguments(@"user-data-dir=" + Application.StartupPath + "\\profile");
            co.AddExcludedArgument("enable-automation");
            driver = new ChromeDriver(cds, co);
            driver.Navigate().GoToUrl("https://10fastfingers.com/typing-test/turkish");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 250; i++)
            {
                IWebElement element = driver.FindElement(By.XPath(@"//*[@id=""row1""]/span["+i+"]"));
                listBox1.Items.Add(element);
            }
        }
    }
}
