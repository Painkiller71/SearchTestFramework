using OpenQA.Selenium;

namespace SearchTestFramework.Pages
{
    internal class HomePage : BasePage
    {
        private readonly By _searchButton = By.XPath("(//input[@name='btnK'])[last()]");
        private readonly By _searchTextarea = By.XPath("//textarea[@type='search']");

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickSearchButton()
        {
            Click(_searchButton);
        }

        public void PopulateSearchTextarea(string text)
        {
            SendKeys(_searchTextarea, text);
            SendKeys(Keys.Escape.ToString());
        }
    }
}