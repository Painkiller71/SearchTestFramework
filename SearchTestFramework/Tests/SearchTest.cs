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
            _homePage = new HomePage(Driver);
            _searchResultsPage = new SearchResultsPage(Driver);
        }

        [Test(Description = "Verify that an user see same search text as he entered")]
        public void TestTextareaIsSameAsUserEntered()
        {
            // Arrange
            var expectedText = "Hello World";

            // Act
            _homePage.PopulateSearchTextarea(expectedText);
            _homePage.ClickSearchButton();
            var actualText = _searchResultsPage.GetSearchTextareaText();

            // Assert
            Assert.AreEqual(expectedText, actualText);
        }

        [Test(Description = "Verify that an user see specific text for specific record")]
        public void TestFourthResultContrainsSeleniumIDE()
        {
            // Arrange
            var searchText = "Selenium IDE export to C#";
            var expectedText = "Selenium IDE";
            var index = 4;

            // Act
            _homePage.PopulateSearchTextarea(searchText);
            _homePage.ClickSearchButton();
            var actualResult = _searchResultsPage.GetSearchResultHeaderText(index);

            // Assert
            Assert.That(actualResult.Contains(expectedText), $"Actual string '{actualResult}' doesn't contain expected string '{expectedText}'");
        }
    }
}