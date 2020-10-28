using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCTestsByShyshkina.Pages
{
    public class CoronavirusStoriesPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(), 'Send us')]/..")]
        private IWebElement HowToShareLink { get; set; }

        public CoronavirusStoriesPage(IWebDriver driver) : base(driver)
        {
        }

        public SendYourQuestionsPage ClickOnSendYourQuestions()
        {
            HowToShareLink.Click();
            return new SendYourQuestionsPage(driver);
        }
    }
}
