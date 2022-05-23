using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskBill.Elements;

namespace TestTaskBill.Core
{
    public static class Waiters
    {
        public static IWebElement waitUntilElementVisible(By locator, int waitingTime = 10)
        {
            var driver = Singleton.GetInstance();
            IWebElement tmp = driver.FindElement(locator);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitingTime));
            wait.Until(d => driver.FindElement(locator).Displayed);
            return tmp;
        }

        public static void waitUntilElementAttributeGetsValue(BaseElement element, string attribute, string value, int waitingTime = 50)
        {
            var driver = Singleton.GetInstance();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitingTime));
            wait.Until(d => element.GetAttribute(attribute) == value);            
        }

        public static void waitUntilElementHasText(BaseElement element, string text, int waitingTime = 50)
        {
            var driver = Singleton.GetInstance();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitingTime));
            wait.Until(d => element.GetText() == text);
        }       

    }
}
