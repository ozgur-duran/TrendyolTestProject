using TrendyolTestProject.Collections;
using TrendyolTestProject.Pages;

namespace TrendyolTestProject.Tests
{
    [TestFixture]
    public class SepeteEklemeTest:BaseTest
    {
        public void SignIn()
        {
            GoToURL(HomePageCollection.pageUrl);

        }
        [Test,Category("Erkek Spor Ayakkabı")]
        public async Task ErkekSporAyakkabiTest()
        {
            SignIn();
           
            HomePage homePage = new HomePage();
            KategoriPage kategoriPage = new KategoriPage();
            UrunPage urunPage=new UrunPage();
            SepetPage sepetPage = new SepetPage();

            homePage.EkraniTemizle();//Ekranı Temizler.
            Assert.AreEqual(HomePageCollection.pageUrl,webDriver.Url);

            homePage.GoToErkekSporAyakkabi();//Erkek Spor Ayakkabı sayfasına gidiyor.
            Assert.AreEqual(KategoriPageCollection.KategoriPageUrl, webDriver.Url);

            //Thread.Sleep(2000);
            string KategoriUrunBaslik = kategoriPage.GetUrun();//Erkek Spor Sayfasındaki ürünün başlığını getiriyor.
            kategoriPage.GoToUrunPage();//Ürün Sayfasına Gidiyor.
            //Thread.Sleep(2000);

            Assert.IsTrue(urunPage.GetUrunBaslik().Contains(KategoriUrunBaslik));//Ürün sayfasındaki ürünün başlığı ile tıklanan ürün başlığının aynı olduğunun testi yapılıyor.
            urunPage.GoToSepetimPage(); //Sepet sayfasına gidiyor.
            Assert.IsTrue(sepetPage.SepetSayfasimi());
            sepetPage.AnaSayfayaDon();
            Thread.Sleep(2000);
            await Task.CompletedTask;               
        }
    }
}
