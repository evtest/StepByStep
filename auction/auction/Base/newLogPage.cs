using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace auction
{
    public class newLogPage
    {
        private IWebDriver _driver;

        public newLogPage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public newLogPage ClickElement(IWebDriver driver, string element)
        {
            _driver.FindElement(By.XPath(element)).Click();
            return new newLogPage(driver);
        }

        public BasePage LogOut(IWebDriver driver, string element)
        {
            _driver.FindElement(By.XPath(element)).Click();
            return new BasePage(driver);
        }
    }
}
