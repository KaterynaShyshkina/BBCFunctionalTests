﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.4.0.0
//      SpecFlow Generator Version:3.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BBCTestsByShyshkina.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SubmitSendQuestionForm")]
    public partial class SubmitSendQuestionFormFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "SubmitSendQuestionForm.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "SubmitSendQuestionForm", "\tAs a user of BBC site\r\n\tI want to fill form on the Send Your Question page\r\n\tSo " +
                    "that I can send question to BBC", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Submit form")]
        [NUnit.Framework.CategoryAttribute("submit_invalid_form")]
        [NUnit.Framework.TestCaseAttribute("", "Myname", "test@test.test", "20", "01001", "0999999999", "check", "check", null)]
        [NUnit.Framework.TestCaseAttribute("My story", "", "test@test.test", "20", "01001", "0999999999", "check", "check", null)]
        [NUnit.Framework.TestCaseAttribute("My story", "Myname", "", "20", "01001", "0999999999", "check", "check", null)]
        public virtual void SubmitForm(string question, string name, string email, string age, string postcode, string tel, string _1StCheckbox, string _2DCheckbox, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "submit_invalid_form"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("question", question);
            argumentsOfScenario.Add("name", name);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("age", age);
            argumentsOfScenario.Add("postcode", postcode);
            argumentsOfScenario.Add("tel", tel);
            argumentsOfScenario.Add("1st checkbox", _1StCheckbox);
            argumentsOfScenario.Add("2d checkbox", _2DCheckbox);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Submit form", null, tagsOfScenario, argumentsOfScenario);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given("User is on the BBC Home page \'https://www.bbc.com/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.When("User goes to the Send Your Question page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table2.AddRow(new string[] {
                            "question",
                            string.Format("{0}", question)});
                table2.AddRow(new string[] {
                            "Name",
                            string.Format("{0}", name)});
                table2.AddRow(new string[] {
                            "Email",
                            string.Format("{0}", email)});
                table2.AddRow(new string[] {
                            "Age",
                            string.Format("{0}", age)});
                table2.AddRow(new string[] {
                            "Postcode",
                            string.Format("{0}", postcode)});
                table2.AddRow(new string[] {
                            "Telephone",
                            string.Format("{0}", tel)});
                table2.AddRow(new string[] {
                            "I am over 16",
                            string.Format("{0}", _1StCheckbox)});
                table2.AddRow(new string[] {
                            "I accept",
                            string.Format("{0}", _2DCheckbox)});
#line 10
 testRunner.And("User submits form without filling all required fields", ((string)(null)), table2, "And ");
#line hidden
#line 20
 testRunner.Then("the error message is shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
