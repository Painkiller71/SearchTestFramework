using OpenQA.Selenium;

namespace SearchTestFramework.Pages
{
    internal class SearchResultsPage : BasePage
    {
        private readonly By _searchTextarea = By.XPath("//textarea[@type='search']");
        private readonly By _searchResultHeaders = By.XPath("//div[starts-with(@class,'g ')]//a/h3");

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetSearchTextareaText()
        {
            return GetElement(_searchTextarea).Text;
        }

        public string GetSearchResultHeaderText(int index)
        {
            return GetElement(_searchResultHeaders, index).Text;
        }
    }
}