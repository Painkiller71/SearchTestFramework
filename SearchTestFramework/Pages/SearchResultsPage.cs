using OpenQA.Selenium;

namespace SearchTestFramework.Pages
{
    internal class SearchResultsPage : BasePage
    {
        private readonly By _searchTextarea = By.XPath("//textarea[@type='search']");

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetSearchTextareaText()
        {
            return GetElement(_searchTextarea).Text;
        }
    }
}