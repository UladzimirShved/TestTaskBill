using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskBill.Core
{
    public class Singleton
    {
        private static IWebDriver instance = null;
        protected Singleton()
        {
        }
        public static IWebDriver GetInstance()
        {
            var browser = "Chrome";

            if (instance == null)
            {
                instance = BrowserFactory.GetBrowser(browser);
                instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                instance.Manage().Window.Maximize();
                instance.Navigate().GoToUrl("https://www.globalsqa.com/");
            }            
            return instance;
        }
    }
}
