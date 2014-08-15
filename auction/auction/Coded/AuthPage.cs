using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace auction
{
    public class AuthPage
    {
        private IWebDriver _driver;

        public AuthPage(IWebDriver driver)
        {
            this._driver = driver;
        }

    }
}
