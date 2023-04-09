using MarsOnboardingTask.Driver;
using MarsOnboardingTask.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions: CommonDriver
    {
        // Page Objects initialization
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"I logged in successfully and I am in the Languages Tab")]
        public void GivenILoggedInSuccessfullyAndIClickAddNewButton()
        {
            // Open Chrome browser
            driver = new ChromeDriver();

            // Login page object intilialization and definition
            loginPageObj.LoginActions(driver);
        }

        [When(@"I click on Add New button and create a Language and Level")]
        public void WhenICreateANewLanguageAndLevel()
        {
            profilePageObj.AddNewLanguage(driver, "English");
        }

        [Then(@"The language should be added and I should see Notification")]
        public void ThenTheLanguageShouldBeAddedAndIShouldSeeNotification()
        {
            profilePageObj.CheckLanguageNotification(driver, "English");
        }
        
        [Given(@"I logged in successfully and I click on Edit button")]
        public void GivenILoggedInSuccessfullyAndIClickOnEditButton()
        {
           
        }

        [When(@"I edit '([^']*)' and '([^']*)'")]
        public void WhenIEditAnd(string language, string fluent)
        {
            
        }

        [When(@"I click on Update button")]
        public void WhenIClickOnUpdateButton()
        {
            
        }

        [Then(@"The language should be updated and I should see '([^']*)'")]
        public void ThenTheLanguageShouldBeUpdatedAndIShouldSee(string p0)
        {
            
        }
    }
}
