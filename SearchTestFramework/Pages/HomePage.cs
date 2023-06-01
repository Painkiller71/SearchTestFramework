using OpenQA.Selenium;

namespace SearchTestFramework.Pages
{
    internal class HomePage : BasePage
    {
        private readonly By _searchButtonFromSuggestions = By.XPath("//div[@style]//input[@name='btnK']");
        private readonly By _searchTextarea = By.XPath("//textarea[@type='search']");

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickSearchButtonFromSuggestions()
        {
            Click(_searchButtonFromSuggestions);
        }

        public void PopulateSearchTextarea(string text)
        {
            SendKeys(_searchTextarea, text);
        }
    }
}