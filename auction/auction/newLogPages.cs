using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace auction
{
    class newLogPages
    {
        private IWebDriver _driver;

        public newLogPages(IWebDriver driver)
        {
            this._driver = driver;
        }

        public newLogPages ClickElements(IWebDriver driver, string element)
        {
            driver.FindElement(By.XPath(element)).Click();
            return new newLogPages(driver);
        }

        public BasePages LogOuts(IWebDriver driver, string element)
        {
            driver.FindElement(By.XPath(element)).Click();
            return new BasePages(driver);
        }
    }
}
