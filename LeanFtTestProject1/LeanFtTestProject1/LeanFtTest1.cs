using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HP.LFT.SDK;
using HP.LFT.SDK.Web;
using HP.LFT.Report;
using LeanFtAppModelProject1;
using System.Threading;
using System.Linq;
using System.Data;

namespace LeanFtTestProject1
{
    [TestClass]
    public class LeanFtTest1 : UnitTestClassBase<LeanFtTest1>
    {
        IBrowser browser;
        ApplicationModel marketMainPage;
        const uint shortWaiting = 5;
        const uint longWaiting = 15;
        
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            GlobalSetup(context);
        }

        [TestInitialize]        
        public void TestInitialize()
        {
            browser = BrowserChoose.GetBrowser(TestContext.DataRow);
            browser.Navigate("http://market.yandex.ru");

            marketMainPage = new ApplicationModel(browser);
        }
        
        [TestMethod]
        [DataSource("ExcelDataSourceValues")]
        public void TestMethod1()
        {            
            Helper.WaitAndCheckElementToExist(
                marketMainPage.MainPage.YandexLogoImage,
                "Logo exist",
                shortWaiting);

            marketMainPage.MainPage.ElectronikLink.Click();
            marketMainPage.MainPage.MobilePhoneLink.Click();

            Helper.WaitAndCheckElementToExist(
                marketMainPage.MobilePhonesPage.MobilePhoneHeaderWebElement,
                "Mobile phone header exist",
                longWaiting);
            
            var values = new MobileValues(TestContext.DataRow);

            marketMainPage.MobilePhonesPage.PriceFromEditField.SetValue(values.priceFrom);
            marketMainPage.MobilePhonesPage.PriceToEditField.SetValue(values.priceTo);
            Helper.SelectItem(marketMainPage.MobilePhonesPage.PlatformSelectListBox, values.platform);
            Helper.SelectItem(marketMainPage.MobilePhonesPage.TypeSelectListBox, values.type);
            marketMainPage.MobilePhonesPage.SetFiltersButton.Click();

            Assert.IsTrue(marketMainPage.SearchResultPage.ProductCardsWebElement.Exists(longWaiting));
            Assert.AreEqual(marketMainPage.SearchResultPage.PriceFromEditField.Value, values.priceFrom);
            Assert.AreEqual(marketMainPage.SearchResultPage.PriceToEditField.Value, values.priceTo);
            Assert.IsTrue(Helper.IsItemSelected(browser, values.platform, 5));
            Assert.IsTrue(Helper.IsItemSelected(browser, values.type, 5));
        }

        public void SetValuesAndSubmit(MobileValues values)
        {
            
        }

        public void CheckValues(MobileValues values)
        {
            
        }

        [TestCleanup]
        public void TestCleanup()
        {
            browser.CloseAllTabs();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalTearDown();
        }
    }
}
