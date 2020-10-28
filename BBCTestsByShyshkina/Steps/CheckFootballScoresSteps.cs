using BBCTestsByShyshkina.Driver;
using BBCTestsByShyshkina.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using static BBCTestsByShyshkina.Pages.ScoreBoard;

namespace BBCTestsByShyshkina.Steps
{
    [Binding]
    public class CheckFootballScoresSteps
    {
        private FootballScoresAndFixturesPage footballScoresAndFixturesPage;
        private Score score;
        private FootballMatchPage footballMatchPage;

        [When(@"User goes to the Football Scores And Fixtures Page")]
        public void WhenUserGoesToTheFootballScoresAndFixturesPage()
        {
            footballScoresAndFixturesPage = new HomePage(DriverInstance.GetInstance()).ClickOnSportTab()
                                                                                      .ClickOnFootballTab()
                                                                                      .ClickOnScoresAndFixturesTab();
        }
        
        [When(@"searches (.*) and (.*) that have played (.*) in (.*)")]
        public void WhenSearchesAndThatHavePlayedIn(string homeTeam, string guestTeam, string date, string championship)
        {
            score = footballScoresAndFixturesPage.EnterChampionshipToSearchInput(championship)
                                                 .SelectDate(date)
                                                 .GetTeamsScore(homeTeam, guestTeam);
        }
        
        [When(@"User clicks on (.*) or (.*)")]
        public void WhenUserClicksOnOr(string homeTeam, string guestTeam)
        {
            footballMatchPage = new FootballChampScoresAndFixturesPage(DriverInstance.GetInstance()).ClickOnTeamsMatch(homeTeam, guestTeam);
        }
        
        [Then(@"the specific score \((.*) : (.*)\) is displayed")]
        public void ThenTheSpecificScoreIsDisplayed(int homePoints, int guestPoints)
        {
            Assert.IsTrue(homePoints == score.Team1Score, "Team 1 score is not equal to expected");
            Assert.IsTrue(guestPoints == score.Team2Score, "Team 2 score is not equal to expected");
        }
        
        [Then(@"the same score \((.*) : (.*)\) is displayed at the center of the screen")]
        public void ThenTheSameScoreIsDisplayedAtTheCenterOfTheScreen(int homePoints, int guestPoints)
        {
            Assert.IsTrue(homePoints == footballMatchPage.GetHomeTeamScore());
            Assert.IsTrue(guestPoints == footballMatchPage.GetGuestTeamScore());
        }
    }
}
