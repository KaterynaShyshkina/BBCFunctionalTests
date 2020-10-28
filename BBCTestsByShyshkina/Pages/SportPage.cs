using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCTestsByShyshkina.Pages
{
    public class SportPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@role = 'menubar']//a[@data-stat-title = 'Football']")]
        private IWebElement FootballTab { get; set; }

        [FindsBy(How = How.Id, Using = "sign_in")]
        private IWebElement SignInPopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='sign_in-exit']")]
        private IWebElement SignInExitButton { get; set; }

        public SportPage(IWebDriver driver) : base(driver) 
        {
            if (ElementIsVisible(SignInPopup))
                SignInExitButton.Click();
        }

        public FootballPage ClickOnFootballTab()
        {
            FootballTab.Click();
            return new FootballPage(driver);
        }
    }
}
