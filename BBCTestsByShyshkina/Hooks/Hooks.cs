using BBCTestsByShyshkina.Driver;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BBCTestsByShyshkina.Hooks
{
    [Binding]
    class Hooks
    {
        public IWebDriver driver;

        [BeforeScenario]
        public void TestInitialize()
        {
            driver = DriverInstance.GetInstance();
        }

        [AfterScenario]
        public void TestCleanup()
        {
            DriverInstance.CloseBrowser();
        }
    }
}
