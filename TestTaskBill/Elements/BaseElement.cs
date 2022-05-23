using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskBill.Core;

namespace TestTaskBill.Elements
{
    public abstract class BaseElement
    {
        protected IWebElement Element { get; set; }
        private By Locator { get; set; }

        protected IWebDriver driver = Singleton.GetInstance();
        public BaseElement(By locator, int waitingTime = 10)
        {
            Locator = locator;
            Element = Waiters.waitUntilElementVisible(Locator, waitingTime);
        }

        public List<IWebElement> CreateListOfElements(By locator)
        {
            return driver.FindElements(locator).ToList();
        }
        
        public string GetAttribute(string attName)
        {
            return Element.GetAttribute(attName);
        }

        public void Click()
        {
            Element.Click();
        }

        public bool IsDisplayed()
        {
            return Element.Displayed;
        }

        public string GetText()
        {
            return Element.Text;
        }
    }
}
