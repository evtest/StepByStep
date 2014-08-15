using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace auction
{
    class BasePages
    {
        private IWebDriver _driver;

        public BasePages(IWebDriver driver)
        {
            this._driver = driver;
        }

        public BasePages ClickElements(IWebDriver driver, string element)
        {
            driver.FindElement(By.XPath(element)).Click();
            return new BasePages(driver);
        }

        public newLogPages LogIn(IWebDriver driver, string LogIn, string Password)
        {
            driver.FindElement(By.XPath("//*[@id='Login']")).SendKeys(LogIn);
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys(Password);
            perem.Screen(driver, "scr_3");
            driver.FindElement(By.XPath("//*[@id='login-button']")).Submit();
            return new newLogPages(driver);            
        }
    }
}
