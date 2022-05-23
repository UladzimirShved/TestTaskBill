using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskBill.Core;

namespace TestTaskBill.Elements
{
    public class ProgressBar : BaseElement
    {
        public ProgressBar(By locator) : base(locator)  
        {

        }

        public bool IsCompleted()
        {            
            return Element.GetAttribute("aria-valuenow") == "100";
        }

        public void WaitUntilPercentage(int value)
        {
            Waiters.waitUntilElementAttributeGetsValue(this, "aria-valuenow", value.ToString());
        }


    }
}
