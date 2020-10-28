using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCTestsByShyshkina.Pages
{
    public class SearchPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//li[1]//a[contains(@class, 'PromoLink')]/span")]
        private IWebElement FirstArticleName { get; set; }

        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetFirstArticleNameText()
        {
            return FirstArticleName.Text;
        }
    }
}
