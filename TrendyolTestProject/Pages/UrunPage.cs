using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TrendyolTestProject.Collections;

namespace TrendyolTestProject.Pages
{
    public class UrunPage : BaseCollection
    {
        IWebDriver driver;
        public UrunPage()
        {
            driver = webDriver;
        }
        WebDriverWait wait => new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        IWebElement UrunBaslik => wait.Until((d) =>
        {
            return d.FindElement(By.ClassName(UrunPageCollection.UrunBaslikXpath));
        });

        IWebElement UrunSepeteEkleBtn => wait.Until((d) =>
        {
            return d.FindElement(By.ClassName(UrunPageCollection.UrunSepeteEkleXpath));
        });
        IWebElement UrunSepetimBtn => wait.Until((d) =>
        {
            return d.FindElement(By.ClassName(UrunPageCollection.UrunSepetimXpath));
        });
        public string GetUrunBaslik()
        {
            return UrunBaslik.Text;
        }
        public void GoToSepetimPage()
        {
            UrunSepeteEkleBtn.Click();
            UrunSepetimBtn.Click();
        }
    }
}
