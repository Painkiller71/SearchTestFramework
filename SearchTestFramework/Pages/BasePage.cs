using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SearchTestFramework.Pages
{
    internal abstract class BasePage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        protected void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        protected IWebElement WaitUntilElementVisible(By by)
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        protected IWebElement GetElement(By by)
        {
            return WaitUntilElementVisible(by);
        }

        protected void Click(By by)
        {
            GetElement(by).Click();
        }

        protected void SendKeys(By by, string text, bool clear = false)
        {
            var element = GetElement(by);
            if (clear)
            {
                element.Clear();
            }
            element.SendKeys(text);
        }

        public void SendKeys(string key)
        {
            new Actions(_driver).SendKeys(key).Perform();
        }
    }
}