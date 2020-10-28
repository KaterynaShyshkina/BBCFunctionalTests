using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCTestsByShyshkina.Pages
{
    public class FootballScoresAndFixturesPage : BasePage
    {
       
        [FindsBy(How = How.Id, Using = "downshift-0-input")]
        private IWebElement SearchInput { get; set; }

        [FindsBy(How = How.Id, Using = "downshift-0-item-0")]
        private IWebElement FirstItemInSearchResults { get; set; }

        public FootballScoresAndFixturesPage(IWebDriver driver) : base(driver)
        {
        }
        public FootballChampScoresAndFixturesPage EnterChampionshipToSearchInput(string keyword)
        {
            SearchInput.SendKeys(keyword);
            FirstItemInSearchResults.Click();
            return new FootballChampScoresAndFixturesPage(driver);
        }
    }
}
