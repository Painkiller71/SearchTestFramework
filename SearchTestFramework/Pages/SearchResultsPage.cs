using OpenQA.Selenium;

namespace SearchTestFramework.Pages
{
    internal class SearchResultsPage : BasePage
    {
        private readonly By _searchResultHeaders = By.XPath("//div[starts-with(@class,'g ')]//a/h3");
        private readonly By _searchTextarea = By.XPath("//textarea[@type='search']");

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetSearchResultHeaderText(int index)
        {
            return GetElement(_searchResultHeaders, index).Text;
        }

        public string GetSearchTextareaText()
        {
            return GetElement(_searchTextarea).Text;
        }
    }
}