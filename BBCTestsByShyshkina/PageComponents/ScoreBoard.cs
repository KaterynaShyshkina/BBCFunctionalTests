using OpenQA.Selenium;
using System;

namespace BBCTestsByShyshkina.Pages
{
    public class ScoreBoard : FootballChampScoresAndFixturesPage
    {
        public ScoreBoard(IWebDriver driver) : base(driver)
        {
        }

        public class Score
        {
            public int Team1Score { get; }
            public int Team2Score { get; }
            public Score(int team1Score, int team2Score)
            {
                Team1Score = team1Score;
                Team2Score = team2Score;
            }
        }
        public Score GetScore(string team1, string team2)
        {
            IWebElement searchScoreArticle = driver.FindElement(By.XPath("//a/article[.//span[contains(@class, 'home')]//abbr[@title ='" + team1 + "'] " +
                "and .//span[contains(@class, 'away')]//abbr[@title ='" + team2 + "']]"));
            int team1Score = Int32.Parse(searchScoreArticle
                .FindElement(By.XPath(".//span[contains(@class, 'home')]//span[contains(@class, 'number')]")).Text);
            int team2Score = Int32.Parse(searchScoreArticle
                .FindElement(By.XPath(".//span[contains(@class, 'away')]//span[contains(@class, 'number')]")).Text);
            return new Score(team1Score, team2Score);
        }

        
    }
}
