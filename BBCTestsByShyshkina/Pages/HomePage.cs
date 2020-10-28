using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCTestsByShyshkina.Pages
{
    public class HomePage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//div[@id='orb-nav-links']//a[contains(text(), 'News')]")]
        private IWebElement NewsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='orb-nav-links']//a[contains(text(), 'Sport')]")]
        private IWebElement SportLink { get; set; }

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public NewsPage ClickOnNewsTab()
        {
            NewsLink.Click();
            return new NewsPage(driver);
        }

        public SportPage ClickOnSportTab()
        {
            SportLink.Click();
            return new SportPage(driver);
        }
    }
}
