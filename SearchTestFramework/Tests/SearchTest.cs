using NUnit.Framework;
using SearchTestFramework.Pages;

namespace SearchTestFramework.Tests.Tests
{
    [TestFixture]
    internal class SearchTest : BaseTest
    {
        private SearchResultsPage _searchResultsPage;
        private HomePage _homePage;

        [SetUp]
        public void Before()
        {
            _searchResultsPage = new SearchResultsPage(Driver);
            _homePage = new HomePage(Driver);
        }

        [Test(Description = "Verify that an user see same search text as he entered")]
        public void TestTextareaIsSameAsUserEntered()
        {
            var expectedText = "Hello World";

            _homePage.PopulateSearchTextarea(expectedText);
            _homePage.ClickSearchButton();
            var actualText = _searchResultsPage.GetSearchTextareaText();

            Assert.AreEqual(expectedText, actualText);
        }
    }
}