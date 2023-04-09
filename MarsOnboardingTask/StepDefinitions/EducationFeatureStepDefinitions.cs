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
            profilePageObj.AddNewEducation(driver, "Massey", "New Zealand", "PHD", "Food Science", "2021");
            profilePageObj.AddNewEducation(driver, "AUT", "New Zealand", "B.Sc", "Computer Science", "2018");
        }

        [Then(@"The Education details should be added and I should see Notification")]
        public void ThenTheEducationDetailsShouldBeAddedAndIShouldSeeNotification()
        {
            profilePageObj.CheckEducationNotification(driver, "Education has been added");
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

        [When(@"I edit ([^']*), ([^']*), ([^']*), ([^']*), ([^']*) in Education Tab")]
        public void WhenIEditInEducationTab(string university, string country, string title, string degree, string year)
        {
            profilePageObj.EditEducation(driver, university, country, title, degree, year);
        }

        [Then(@"The Education details should be updated with ([^']*), ([^']*), ([^']*), ([^']*), ([^']*) and I should see ([^']*)")]
        public void ThenTheEducationDetailsShouldBeUpdatedWithAndIShouldSee(string university, string country, string title, string degree, string year, string notification)
        {
            if(notification == "This information is already exist.")
            {
                profilePageObj.CheckEducationNotification(driver, notification);
                Thread.Sleep(1000);
            }
            else if (notification == "Education as been updated")
            {
                string editedUniversity = profilePageObj.GetUniversity(driver);
                string editedCountry = profilePageObj.GetCountry(driver);
                string editedTitle = profilePageObj.GetTitle(driver);
                string editedDegree = profilePageObj.GetDegree(driver);
                string editedYear = profilePageObj.GetYear(driver);

                Assert.That(editedUniversity == university, "Actual university and expected university do not match");
                Assert.That(editedCountry == country, "Actual country and expected country do not match");
                Assert.That(editedTitle == title, "Actual title and expected title do not match");
                Assert.That(editedDegree == degree, "Actual degree and expected degree do not match");
                Assert.That(editedYear == year, "Actual year and expected year do not match");

                profilePageObj.CheckEducationNotification(driver, notification);
                Thread.Sleep(2000);
            }
        }

        [Given(@"I logged in successfully and navigate to Education Tab to delete")]
        public void GivenILoggedInSuccessfullyAndNavigateToEducationTabToDelete()
        {
            // Open Chrome browser
            driver = new ChromeDriver();

            loginPageObj.LoginActions(driver);
            profilePageObj.GoToEducationTab(driver);         
        }

        [When(@"I click on the Delete button for ([^']*), ([^']*), ([^']*), ([^']*), ([^']*)")]
        public void WhenIClickOnTheDeleteButtonFor(string university, string country, string title, string degree, string year)
        {
            profilePageObj.DeleteEducation(driver);
        }
        [Then(@"The Education details should be deleted and I should see ([^']*)")]
        public void ThenTheEducationDetailsShouldBeDeletedAndIShouldSee(string notification)
        {
            profilePageObj.CheckEducationNotification(driver, notification);
            Thread.Sleep(2000);
        }
    }
}
