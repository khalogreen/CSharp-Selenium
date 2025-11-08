using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpSelenium.Drivers
{
    public static class DriverFactory
    {
        public static IWebDriver Create(string browser = "chrome")
        {
            browser = browser.ToLower();
            IWebDriver driver;

            switch (browser)
            {
                case "chrome":
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--start-maximized");
                    driver = new ChromeDriver(chromeOptions);
                    break;

                case "edge":
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;

                case "firefox":
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                default:
                    throw new ArgumentException($"Unsupported browser : {browser}");
            }
            
            return driver;
        }
    }
}
