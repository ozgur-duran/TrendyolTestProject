using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TrendyolTestProject.Collections;

namespace TrendyolTestProject.Pages
{
    public class SepetPage:BaseCollection
    {
        IWebDriver driver;
        public SepetPage()
        {
            driver = webDriver;
        }
        WebDriverWait wait => new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        IWebElement SepetPageLogo => wait.Until((d) =>
        {
            return d.FindElement(By.Id(SepetPageCollection.sepetPageLogoId));
        });


        public bool SepetSayfasimi()
        {
            if (driver.Url==SepetPageCollection.sepetPageUrl)
                return true;
            return false;
        }
        public void AnaSayfayaDon()
        {
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

    }
}
