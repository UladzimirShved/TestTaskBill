using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskBill.Core
{
    internal class BrowserFactory
    {
        public static IWebDriver GetBrowser(String browser)
        {
            IWebDriver driver = null;

            switch (browser)
            {

                case "Chrome":

                    if (driver == null)
                    {
                        driver = new ChromeDriver();
                    }
                    break;                
            }
            return driver;
        }
    }
}
