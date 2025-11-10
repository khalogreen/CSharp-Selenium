using CSharpSelenium.Configs;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpSelenium.Drivers
{
    public class DriverFactory
    {
        private readonly UiSettings _ui;

        public DriverFactory(UiSettings uiSettings)
        {
            _ui = uiSettings;
        }
        public IWebDriver CreateDriver()
        {
            IWebDriver driver;
            var browser = _ui.Browser.ToLower();

            switch (browser)
            {
                case "chrome":
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--start-maximized");
                    if (_ui.Headless)
                        chromeOptions.AddArgument("--headless=new");
                    driver = new ChromeDriver(chromeOptions);
                    break;

                case "edge":
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    var edgeOptions = new EdgeOptions();
                    if (_ui.Headless)
                        edgeOptions.AddArgument("--headless=new");
                    driver = new EdgeDriver(edgeOptions);
                    break;

                case "firefox":
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    var firefoxOptions = new FirefoxOptions();
                    if (_ui.Headless)
                        firefoxOptions.AddArgument("--headless=new");
                    driver = new FirefoxDriver(firefoxOptions);
                    break;

                default:
                    throw new ArgumentException($"Unsupported browser : {browser}");
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(_ui.Timeout);
            Console.WriteLine($"[DriverFactory] Browser: {_ui.Browser}, Headless: {_ui.Headless}");

            return driver;

        }
        //options.AddArgument("--start-maximized");
        //options.AddArgument("--disable-notifications");
        //options.AddArgument("--disable-popup-blocking");
        //options.AddArgument("--no-sandbox");
        //options.AddArgument("--disable-dev-shm-usage");
        //options.AddArgument("--headless=new");     // headless mode
        //options.AddArgument("--window-size=1920,1080");
    }
}
