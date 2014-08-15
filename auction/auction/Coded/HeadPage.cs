using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace auction
{
    public class HeadPage
    {
        private IWebDriver driver;

        public HeadPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public AuthPage ClickElement(string element)
        {
            driver.FindElement(By.XPath(element)).Click();
            return new AuthPage(driver);
        }

        public LOginPage LogIn(string LogIn, string Password)
        {
            driver.FindElement(By.XPath("//*[@id='Login']")).SendKeys(LogIn);
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys(Password);
            driver.FindElement(By.XPath("//*[@id='login-button']")).Submit();
            return new LOginPage(driver);
        }
    }
}
