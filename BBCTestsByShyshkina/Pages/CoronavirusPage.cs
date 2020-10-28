using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCTestsByShyshkina.Pages
{
    public class CoronavirusPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//nav[@class='nw-c-nav__wide-secondary']//a[@href='/news/have_your_say']")]
        private IWebElement YourCoronavirusStoriesTab { get; set; }

        public CoronavirusPage(IWebDriver driver) : base(driver)
        {
        }

        public CoronavirusStoriesPage ClickOnYourCoronavirusStoriesTab()
        {
            YourCoronavirusStoriesTab.Click();
            return new CoronavirusStoriesPage(driver);
        }
    }
}
