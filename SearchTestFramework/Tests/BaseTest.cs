using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SearchTestFramework.Models;
using SearchTestFramework.Util;

namespace SearchTestFramework.Tests.Tests
{
    [TestFixture]
    internal abstract class BaseTest
    {
        protected IWebDriver Driver;
        protected static SeleniumOptions SeleniumOptions => ConfigurationManager.GetSeleniumOptions();

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(SeleniumOptions.BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}