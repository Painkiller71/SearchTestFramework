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
            _wait = new WebDriverWait(driver, Constants.Constants.ExplicitWait);
        }

        protected void Click(By by)
        {
            GetElement(by).Click();
        }

        protected IWebElement GetElement(By by)
        {
            return WaitUntilElementVisible(by);
        }

        protected IWebElement GetElement(By by, int index)
        {
            return _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(by)).ElementAt(index);
        }

        protected void SendKeys(By by, string text)
        {
            GetElement(by).SendKeys(text);
        }

        protected void SendKeys(string key)
        {
            new Actions(_driver).SendKeys(key).Perform();
        }

        protected IWebElement WaitUntilElementVisible(By by)
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}