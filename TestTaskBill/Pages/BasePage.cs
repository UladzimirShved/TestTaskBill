using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskBill.Core;

namespace TestTaskBill.Pages
{
    public abstract class BasePage
    {
        string Url { get; set; }
        public IWebDriver Driver { get; set; }
        private static string DefaultUrl = "https://www.globalsqa.com/";
        public BasePage(string url)
        {
            Driver = Singleton.GetInstance();
            Url = $"{DefaultUrl}{url}";
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(this.Url);
        }

        public void Quit()
        {
            Driver.Quit();
        }
    }
}
