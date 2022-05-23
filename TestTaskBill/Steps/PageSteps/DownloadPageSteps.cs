using NUnit.Framework;
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
    public class DownloadPageSteps
    {
        [When(@"Switch to '(\d+)' iframe index on Download page")]
        [Given(@"Switch to '(\d+)' iframe index on Download page")]
        public void WhenSwitchToIframeOnDownloadPage(int index)
        {
            new DownloadPage().SwitchToFrameByIndex(index);
        }

        [When(@"Click Start Download button on Download page")]
        public void WhenClickStartDownloadButtonOnDownloadPage()
        {
            new DownloadPage().StartDownload.Click();
        }

        [Then(@"File download title displayed is '(true|false)' on Download page")]
        public void ThenFileDownloadTitleIsDisplayed(bool displayed)
        {
            var actual = new DownloadPage().FileDownloadTitle.IsDisplayed();
            Assert.AreEqual(displayed, actual, $"File download title displayed is {actual}");
        }

        [Then(@"File is downloaded on Download page")]
        public void ThenFileIsDownloadedOnDownloadPage()
        {            
            Assert.True(new DownloadPage().IsFileDownloaded(), "File was not downloaded");
        }



    }
}
