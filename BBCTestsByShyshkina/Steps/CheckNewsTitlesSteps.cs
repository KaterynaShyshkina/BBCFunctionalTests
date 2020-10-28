using BBCTestsByShyshkina.Driver;
using BBCTestsByShyshkina.Pages;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace BBCTestsByShyshkina.Steps
{
    [Binding]
    public class CheckNewsTitlesSteps
    {
        private NewsPage newsPage;
        private SearchPage searchPage;

        [Given(@"User is on the BBC Home page '(.*)'")]
        public void GivenUserIsOnTheBBCHomePage(string bbcUrl)
        {
            DriverInstance.GetInstance().Navigate().GoToUrl(bbcUrl);
        }
        
        [When(@"User goes to the News page")]
        public void WhenUserGoesToTheNewsPage()
        {
            newsPage = new HomePage(DriverInstance.GetInstance()).ClickOnNewsTab();
        }
        
        [When(@"User searches headline article category name through the search input field")]
        public void WhenUserSearchesHeadlineArticleCategoryNameThroughTheSearchInputField()
        {
            searchPage = newsPage.EnterHeadlineArticleCategoryToSearchInput();
        }
        
        [Then(@"the headline article title should contain '(.*)'")]
        public void ThenTheHeadlineArticleTitleShouldContain(string expectedPrimaryNewsTitleText)
        {
            Assert.AreEqual(expectedPrimaryNewsTitleText, newsPage.GetPrimaryNewsTitleText());
        }
        
        [Then(@"the secondary articles titles should contain names")]
        public void ThenTheSecondaryArticlesTitlesShouldContainNames(Table table)
        {
            Assert.IsTrue(new HashSet<string>(table.Rows.Select(s => s[0]).ToList()).SetEquals(newsPage.GetSecondaryNewsTitlesTexts()));
        }
        
        [Then(@"the first article title on the Search page should contain '(.*)'")]
        public void ThenTheFirstArticleTitleOnTheSearchPageShouldContain(string expectedFirstArticleNameText)
        {
            Assert.AreEqual(expectedFirstArticleNameText, searchPage.GetFirstArticleNameText());
        }
    }
}
