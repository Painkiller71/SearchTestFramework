using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SearchTestFramework
{
    internal class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            driver.Url = "https://www.google.com";
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}