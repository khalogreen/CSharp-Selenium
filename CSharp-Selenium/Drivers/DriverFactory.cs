using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.Drivers
{
    public static class DriverFactory
    {
        public static IWebDriver Create()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            return new ChromeDriver(options);
        }
    }
}
