using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace auction
{
    public class LOginPage
    {
        private IWebDriver driver;

        public LOginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public HeadPage ClickElement(IWebDriver driver, string element)
        {
            driver.FindElement(By.XPath(element)).Click();
            return new HeadPage(driver);
        }
    }
}
