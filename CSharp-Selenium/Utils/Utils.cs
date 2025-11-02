using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.Utils
{
    public class WaitHelper
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public WaitHelper(IWebDriver driver, int timeOutSeconds = 10, int pillingMs = 500)
        {
            _driver = driver;
            _wait = new WebDriverWait(new SystemClock(), driver, TimeSpan.FromSeconds(timeOutSeconds), TimeSpan.FromMilliseconds(pillingMs));

            _wait.IgnoreExceptionTypes(
                typeof(NoSuchElementException),
                typeof(StaleElementReferenceException),
                typeof(ElementNotInteractableException)
                );
        }

        public IWebElement Visible(By locator)
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
        public IWebElement Clickable(By locator) => _wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        public bool UrlContains(string substring) => _wait.Until(ExpectedConditions.UrlContains(substring));
        public T Until<T>(Func<IWebDriver, T> condition) => _wait.Until(condition);
    }
    public class Utils
    {
        

        //protected readonly IWebDriver Driver;
        //protected readonly WebDriverWait Wait;
        //private int defaultTimeOut = 30;
        //public static IWebElement WaitForClickable(IWebDriver driver, By locator, int timeout = defaultTimeOut)
        //{
        //    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
        //    return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        //}
        //public static IWebElement WaitForVisible(IWebDriver driver, By locator, int timeout = defaultTimeOut)
        //{
        //    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
        //    return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        //}
    }
}
