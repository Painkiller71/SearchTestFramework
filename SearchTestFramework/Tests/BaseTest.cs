using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SearchTestFramework.Tests.Tests
{
    [TestFixture]
    internal abstract class BaseTest
    {
        protected IWebDriver Driver;
        private readonly string _baseUrl = "https://www.google.com";

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_baseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}