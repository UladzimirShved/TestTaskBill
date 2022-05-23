using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskBill.Elements
{
    public class IFrame : BaseElement
    {
        private By Locator;
        public IFrame(By locator) : base(locator)
        {
            Locator = locator;
        }       

        public void SwitchToIFrame(int index)
        {            
            driver.SwitchTo().Frame(index);
        }

    }
}
