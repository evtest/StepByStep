using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;

namespace auction
{
    [TestFixture]
    public class StartPage
    {
        public IWebDriver driver = null;

        [TestFixtureSetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://auction.cislink.com:555/");
        }

        [Test]
        public void StartTest()
        {
            BasePages bPage = new BasePages(driver);
            perem.Screen(driver, "scr_1");
            bPage = bPage.ClickElements(driver, "//*[contains(text(), 'вход')]");
            perem.Screen(driver, "scr_2");
            newLogPages lPage = bPage.LogIn(driver, "TestUser", "111111");
            perem.Screen(driver, "scr_4");
            lPage = lPage.ClickElements(driver, "//ul[@class='undermainmenu auction_childs s-float_l']/li[2]/a[@href]");
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until((d) => d.FindElement(By.XPath("//h1[contains(text(), 'История')]")));
            perem.Screen(driver, "scr_5");
            lPage = lPage.ClickElements(driver, "//ul[@class='undermainmenu auction_childs s-float_l']/li[1]/a[@href]");
            wait.Until(d => d.FindElement(By.XPath("//h1[contains(text(), 'Мои аукционы')]")));
            perem.Screen(driver, "scr_6");
            bPage = lPage.LogOuts(driver, "//i[@class='icon icon-shutdown']");
            perem.Screen(driver, "scr_7");
        }
        //wait.Until((d) => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete")); 
        //wait.Until((d) => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete")); 

        [TestFixtureTearDown]
        public void TestClose()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
