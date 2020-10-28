using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCTestsByShyshkina.Pages
{
    public class FootballPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[@data-stat-title = 'Scores & Fixtures']")]
        private IWebElement ScoresAndFixturesTab { get; set; }

        public FootballPage(IWebDriver driver) : base(driver)
        {
        }
        public FootballScoresAndFixturesPage ClickOnScoresAndFixturesTab()
        {
            ScoresAndFixturesTab.Click();
            return new FootballScoresAndFixturesPage(driver);
        }
    }
}
