using MarsOnboardingTask.Driver;
using MarsOnboardingTask.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinitions
{
    [Binding]
    public class SkillsFeatureStepDefinitions: CommonDriver 
    {
        // Page object initialization
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"I logged in successfully and navigated to Skills Tab")]
        public void GivenILoggedInSuccessfullyAndIClickAddNewButtonInSkillsTab()
        {
            // Open Chrome browser
            driver = new ChromeDriver();

            // Login page object intilialization and definition
            loginPageObj.LoginActions(driver);
            profilePageObj.GoToSkillsTab(driver);

        }

        [When(@"I click on Add New button and add a Skill and Level")]
        public void WhenICreateANewSkillAndLevel()
        {
            profilePageObj.AddNewSkill(driver);
        }

        [Then(@"The Skill should be added and I should see Notification")]
        public void ThenTheSkillShouldBeAddedAndIShouldSeeNotification()
        {
           profilePageObj.CheckSkillsNotification(driver);
        }

        [Given(@"I logged in successfully and I click on Edit button in Skills")]
        public void GivenILoggedInSuccessfullyAndIClickOnEditButtonInSkills()
        {
            
        }

        [When(@"I edit '([^']*)' and '([^']*)' in Skills Tab")]
        public void WhenIEditAndInSkillsTab(string javascript, string intermediate)
        {
            
        }

        [When(@"I click on Update button in Skills Tab")]
        public void WhenIClickOnUpdateButtonInSkillsTab()
        {
            
        }

        [Then(@"The Skill should be updated and I should see '([^']*)'")]
        public void ThenTheSkillShouldBeUpdatedAndIShouldSee(string p0)
        {
           
        }
    }
}
