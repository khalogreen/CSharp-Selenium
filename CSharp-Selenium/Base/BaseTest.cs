using CSharpSelenium.Configs;
using CSharpSelenium.Drivers;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;

namespace CSharpSelenium.Base
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected UiSettings UiConfig;
        [SetUp]
        public void SetUp()
        {
            UiConfig = new ConfigReader().GetSection("Ui").Get<UiSettings>();
            Driver = new DriverFactory(UiConfig).CreateDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}
