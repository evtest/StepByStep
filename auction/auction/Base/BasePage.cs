using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace auction
{
    public class BasePage
    {
        private IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        public BasePage ClickElement(IWebDriver driver, string element)
        {
            driver.FindElement(By.XPath(element)).Click();
            return new BasePage(_driver);
        }

        public newLogPage LogIn(IWebDriver driver, string LogIn, string Password)
        {
            driver.FindElement(By.XPath("//*[@id='Login']")).SendKeys(LogIn);
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys(Password);
            driver.FindElement(By.XPath("//*[@id='login-button']")).Submit();
            return new newLogPage(driver);
        }

    }
}
