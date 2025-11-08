using OpenQA.Selenium;
using CSharpSelenium.Utils;

namespace CSharpSelenium.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;
        protected readonly WaitHelper Wait;
        protected string Url;
        protected string Title;
        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WaitHelper(Driver);
        }
        public virtual void GoTo()
        {
            Driver.Navigate().GoToUrl(this.Url);
        }
        protected IWebElement FindVisible(By locator) => Wait.Visible(locator);
        protected IWebElement FindClickable(By locator) => Wait.Clickable(locator);
        virtual protected void Click(By locator) => Wait.Clickable(locator).Click();
        virtual protected void TypeText(By locator, string text)
        {
            var element = Wait.Clickable(locator);
            element.Clear();
            element.SendKeys(text);
        }
        public string GetTitle()
        {
            return Driver.Title;
        }
        public void CheckTitle()
        {
            var currentTitle = GetTitle();
            Assert.That(currentTitle == this.Title, $"Title is wrong, it's {currentTitle} expected is {this.Title}");
        }
    }
}
