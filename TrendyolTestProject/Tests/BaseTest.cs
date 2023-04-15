using OpenQA.Selenium.Chrome;
using TrendyolTestProject.Collections;

namespace TrendyolTestProject.Tests
{
    public class BaseTest:BaseCollection
    {
        [OneTimeSetUp]
        public void Open()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        public void Close()
        {
            webDriver.Quit();
        }
        public static void GoToURL(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }
    }
}
