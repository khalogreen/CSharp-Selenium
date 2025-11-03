using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
