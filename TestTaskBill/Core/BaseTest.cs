using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestTaskBill.Core
{
    [Binding]
    public static class BaseTest
    {
        [AfterScenario]
        public static void TearDown()
        {
            Singleton.GetInstance().Quit();
        }        
    }
}
