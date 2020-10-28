using OpenQA.Selenium;
using static BBCTestsByShyshkina.Pages.ScoreBoard;

namespace BBCTestsByShyshkina.Pages
{
    public class FootballChampScoresAndFixturesPage : BasePage
    {
        public FootballChampScoresAndFixturesPage(IWebDriver driver) : base(driver)
        {
        }

        public FootballChampScoresAndFixturesPage SelectDate(string date)
        {
            try { driver.FindElement(By.XPath("//a[contains(@href, '" + date + "')]")).Click(); }
            catch(StaleElementReferenceException) { driver.FindElement(By.XPath("//a[contains(@href, '" + date + "')]")).Click(); }
            return this;
        }

        public IWebElement GetSearchScoreArticle(string team1, string team2)
        {
            return driver
                .FindElement(By.XPath("//a/article[.//span[contains(@class, 'home')]//abbr[@title ='" + team1 + "'] " +
                "and .//span[contains(@class, 'away')]//abbr[@title ='" + team2 + "']]"));
        }

        public FootballMatchPage ClickOnTeamsMatch(string team1, string team2)
        {
            GetSearchScoreArticle(team1, team2).Click();
            return new FootballMatchPage(driver);
        }

        public Score GetTeamsScore(string team1, string team2)
        {
            ScoreBoard board = new ScoreBoard(driver);
            return board.GetScore(team1, team2);
        }
    }
}
