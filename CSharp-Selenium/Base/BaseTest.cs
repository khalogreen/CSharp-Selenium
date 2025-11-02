using CSharpSelenium.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.Base
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = DriverFactory.Create();
            //options.AddArgument("--start-maximized");
            //options.AddArgument("--disable-notifications");
            //options.AddArgument("--disable-popup-blocking");
            //options.AddArgument("--no-sandbox");
            //options.AddArgument("--disable-dev-shm-usage");
            //options.AddArgument("--headless=new");     // headless mode
            //options.AddArgument("--window-size=1920,1080");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
