using MarsOnboardingTask.Driver;
using MarsOnboardingTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinitions
{
    [Binding]
    public class EducationFeatureStepDefinitions: CommonDriver
    {
        // Page Objects initialization
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"I logged in successfully and navigate to Education Tab")]
        public void GivenILoggedInSuccessfullyAndIClickAddNewButtonInEducationTab()
        {
            // Open Chrome browser
            driver = new ChromeDriver();


            // Login page object intilialization and definition
            loginPageObj.LoginActions(driver);
            profilePageObj.GoToEducationTab(driver);
        }

        [When(@"I click on Add New button and add Education details")]
        public void WhenIFillInInTheDetailsAndClickOnAddButton()
        {
            profilePageObj.AddNewEducation(driver, "AUT", "New Zealand", "B.Sc", "Computer Science", "2018");
        }

        [Then(@"The Education details should be added and I should see Notification")]
        public void ThenTheEducationDetailsShouldBeAddedAndIShouldSeeNotification()
        {
            profilePageObj.CheckEducationNotification(driver, "Education has been added");

        }

        [Given(@"I logged in successfully and navigate to Education Tab to edit")]
        public void GivenILoggedInSuccessfullyAndIClickOnEditButtonInEducation()
        {
            // Open Chrome browser
            driver = new ChromeDriver();

            loginPageObj.LoginActions(driver);
            profilePageObj.GoToEducationTab(driver);

        }

        [When(@"I edit '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)' in Education Tab")]
        public void WhenIEditInEducationTab(string university, string country, string title, string degree, string year)
        {
            profilePageObj.EditEducation(driver, university, country, title, degree, year);
        }

        [Then(@"The Education details should be updated with '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)' and I should see '([^']*)'")]
        public void ThenTheEducationDetailsShouldBeUpdatedWithAndIShouldSee(string university, string country, string title, string degree, string year, string notification)
        {
            string editedUniversity = profilePageObj.GetEditedUniversity(driver);
            Assert.That(editedUniversity == university, "Actual university and expected university do not match");

            profilePageObj.CheckEducationNotification(driver, notification);
        }

        [Given(@"I click on the Delete button")]
        public void GivenIClickOnTheDeleteButton()
        {
            
        }

        [Then(@"The Education details should be deleted and I should see '([^']*)'")]
        public void ThenTheEducationDetailsShouldBeDeletedAndIShouldSee(string p0)
        {
           
        }
    }
}
