using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace auction
{
    public class NewPage
    {
        private IWebDriver driver;

        public NewPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public void LogIn(string LogIn, string Password)
        {
            driver.FindElement(By.XPath("//*[@id='Login']")).SendKeys(LogIn);
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys(Password);
            driver.FindElement(By.XPath("//*[@id='login-button']")).Submit();   
        }

        public BasePage ClickElement(string element)
        {
            driver.FindElement(By.XPath(element)).Click();
            return new BasePage(driver);
        }
    }
}
