using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskBill.Elements;

namespace TestTaskBill.Pages
{
    public class DownloadPage : BasePage
    {
        public DownloadPage() : base("demo-site/progress-bar/") { }        

        public Button StartDownload => new Button(By.Id("downloadButton"));

        public ProgressBar DownloadProgressBar => new ProgressBar(By.Id("progressbar"));

        public Label FileDownloadTitle => new Label(By.Id("ui-id-1"));

        public bool IsFileDownloaded()
        {
            DownloadProgressBar.WaitUntilPercentage(100);
            return DownloadProgressBar.IsCompleted();
        }

        public void SwitchToFrameByIndex(int index)
        {            
            Driver.SwitchTo().Frame(index);
        }
    }
}
