using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TrendyolTestProject.Collections;

namespace TrendyolTestProject.Pages
{
    public class HomePage:BaseCollection
    {
        IWebDriver driver;
        public HomePage()
        {
            driver=webDriver;
            
        }
        WebDriverWait wait=>new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        IWebElement erkekKategori => wait.Until((d) =>
        {
            return d.FindElement(By.XPath(HomePageCollection.pageErkekKategori));
        });
        IWebElement erkekSporAyakkabi => wait.Until((d) =>
        {
            return d.FindElement(By.XPath(HomePageCollection.pageErkekSporAyakkabi));
        });
        IWebElement ReklamKapamaBtn => wait.Until((d) =>
        {
            return d.FindElement(By.Id(HomePageCollection.pageReklamCloseBtnId));
        });
        IWebElement CerezKabulEtBtn => wait.Until((d) =>
        {
            return d.FindElement(By.XPath(HomePageCollection.pageCerezKabulEtBtnXpath));
        });


        public void EkraniTemizle()
        {
            ReklamKapamaBtn.Click();
            CerezKabulEtBtn.Click();
        }
        
        public void GoToErkekSporAyakkabi()
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(30));
            Actions actions=new Actions(driver);
            actions.MoveToElement(erkekKategori).Perform(); //perform olmazsa çalışmıyor.
            Thread.Sleep(500);
            actions.MoveToElement(erkekSporAyakkabi).Perform();
            erkekSporAyakkabi.Click();
        }

    }
}
