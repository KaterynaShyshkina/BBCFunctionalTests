using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace BBCTestsByShyshkina.Pages
{
    public class SendYourQuestionsPage : BasePage
    {
        private readonly Form form = new Form();

        [FindsBy(How = How.Id, Using = "hearken-curiosity-4787")]
        private IWebElement HowToShareForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='input-error-message']")]
        private IList<IWebElement> InputErrorMessages { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Submit')]")]
        private IWebElement SubmitFormButton { get; set; }

        public SendYourQuestionsPage(IWebDriver driver) : base(driver)
        {
        }

        public void FillHaveYouSayForm(IDictionary<string, string> values)
        {
            form.FillForm(values, HowToShareForm);
            SubmitFormButton.Click();
        }

        public bool IsAnyOfInputErrorMessagesVisible()
        {
            foreach (IWebElement element in InputErrorMessages)
            {
                if (element.Displayed)
                    return true;
            }
            return false;
        }

    }
}
