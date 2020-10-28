using OpenQA.Selenium;
using System.Collections.Generic;

namespace BBCTestsByShyshkina
{
    public class Form
    {
        public void FillForm(IDictionary<string, string> values, IWebElement form)
        {
            foreach (var value in values)
                if (value.Value != null && value.Value != "check")
                    form.FindElement(By.XPath(".//*[contains(@aria-label, '" + value.Key + "')]")).SendKeys(value.Value);
                else if (value.Value == "check")
                    form.FindElement(By.XPath(".//p[contains(text(), '" + value.Key + "')]")).Click();
        }
    }
}
