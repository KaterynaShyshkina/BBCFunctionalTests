using BBCTestsByShyshkina.Driver;
using BBCTestsByShyshkina.Pages;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace BBCTestsByShyshkina.Steps
{
    [Binding]
    public class SubmitSendQuestionFormSteps
    {
        private SendYourQuestionsPage sendYourQuestions;

        [When(@"User goes to the Send Your Question page")]
        public void WhenUserGoesToTheSendYourQuestionPage()
        {
            sendYourQuestions = new HomePage(DriverInstance.GetInstance()).ClickOnNewsTab()
                                                                          .ClickOnCoronavirusTab()
                                                                          .ClickOnYourCoronavirusStoriesTab()
                                                                          .ClickOnSendYourQuestions();
        }
        
        [When(@"User submits form without filling all required fields")]
        public void WhenUserSubmitsFormWithoutFillingAllRequiredFields(Table table)
        {
            Dictionary<string, string> formWithoutRequiredFieldsFilling = table.Rows.ToDictionary
                                        (key => key.Values.ElementAt(0), value => value.Values.ElementAt(1));
            sendYourQuestions.FillHaveYouSayForm(formWithoutRequiredFieldsFilling);
        }
        
        [Then(@"the error message is shown")]
        public void ThenTheErrorMessageIsShown()
        {
            Assert.IsTrue(sendYourQuestions.IsAnyOfInputErrorMessagesVisible());
        }
    }
}
