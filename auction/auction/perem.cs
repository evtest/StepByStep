using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace auction
{
    public class perem
    {
        public static void Screen(OpenQA.Selenium.IWebDriver driver, string fName)
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(fName + ".png", ImageFormat.Png);    
        }
    }
}
