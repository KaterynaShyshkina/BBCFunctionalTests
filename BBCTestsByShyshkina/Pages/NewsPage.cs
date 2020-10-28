using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace BBCTestsByShyshkina.Pages
{
    public class NewsPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'primary-item')]//h3")]
        private IWebElement PrimaryNewsTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'secondary-item')]//h3")]
        private IList<IWebElement> SecondaryNewsTitles { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'primary-item')]//a[contains(@class, 'section')]/span")]
        private IWebElement HeadlineArticleCategory { get; set; }

        [FindsBy(How = How.Id, Using = "orb-search-q")]
        private IWebElement SearchInput { get; set; }

        [FindsBy(How = How.Id, Using = "sign_in")]
        private IWebElement SignInPopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='sign_in-exit']")]
        private IWebElement SignInExitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//nav[@class='nw-c-nav__wide']//span[contains(text(), 'Coronavirus')]")]
        private IWebElement CoronavirusTab { get; set; }

        public NewsPage(IWebDriver driver) : base(driver)
        {
            if (ElementIsVisible(SignInPopup))
                SignInExitButton.Click();
        }

        public string GetPrimaryNewsTitleText()
        {
            return PrimaryNewsTitle.Text;
        }

        public IList<string> GetSecondaryNewsTitlesTexts()
        {
            IList<string> secondaryNewsTitlesTexts = new List<string>();
            foreach (IWebElement title in SecondaryNewsTitles)
            {
                secondaryNewsTitlesTexts.Add(title.Text);
            }
            return secondaryNewsTitlesTexts;
        }

        public SearchPage EnterHeadlineArticleCategoryToSearchInput()
        {
            SearchInput.SendKeys(HeadlineArticleCategory.Text + Keys.Enter);
            return new SearchPage(driver);
        }

        public CoronavirusPage ClickOnCoronavirusTab()
        {
            CoronavirusTab.Click();
            return new CoronavirusPage(driver);
        }
    }
}
