using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestTaskBill.Pages;

namespace TestTaskBill.Steps.PageSteps
{
    [Binding]
    public class PageNavigationSteps
    {
        [Given("Go to Download page")]
        [When("Go to Download page")]
        public void OpenDownloadPage()
        {
            new DownloadPage().NavigateTo();
        }



    }
}
