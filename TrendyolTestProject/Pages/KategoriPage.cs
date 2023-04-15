using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TrendyolTestProject.Collections;

namespace TrendyolTestProject.Pages
{
    public class KategoriPage:BaseCollection
    {
        IWebDriver driver;
        public KategoriPage()
        {
            driver = webDriver;
        }
        WebDriverWait wait => new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        IWebElement KaplamaExit => wait.Until((d) =>
        {
            return d.FindElement(By.Id(KategoriPageCollection.UrunKaplamaId));
        });
        IWebElement Urun => wait.Until((d) =>
        {
            return d.FindElement(By.XPath(KategoriPageCollection.urunXpath));
        });
        
       

        public string GetUrun()
        {
            return Urun.Text;
        }
        public void GoToUrunPage()
        {
            bool x=true;
            try
            {
                Urun.Click();
                x=false;
            }
            catch (ElementClickInterceptedException no)
            {
                KaplamaExit.Click();
                Console.WriteLine("Hata oluştu: " + no.Message);
            }
            if (x)
            {
                Urun.Click();
            }
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }
    }
}
