using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace BBCTestsByShyshkina.Pages
{
    public class FootballMatchPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'fixture__number--home')]")]
        private IWebElement Team1Score { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class, 'fixture__number--away')]")]
        private IWebElement Team2Score { get; set; }

        public FootballMatchPage(IWebDriver driver) : base(driver) { }

        public int GetHomeTeamScore()
        {
            return Int32.Parse(Team1Score.Text);
        }

        public int GetGuestTeamScore()
        {
            return Int32.Parse(Team2Score.Text);
        }

    }
}
