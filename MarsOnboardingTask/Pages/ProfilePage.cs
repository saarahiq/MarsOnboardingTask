using OpenQA.Selenium;
using MarsOnboardingTask.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MarsOnboardingTask.Pages
{
    public class ProfilePage
    {       
        

        public void GoToEducationTab(IWebDriver driver)
        {
            Thread.Sleep(1000);
            // Click on Education Tab
            IWebElement educationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();
            Thread.Sleep(1000);
        }
        public void AddNewEducation(IWebDriver driver, string university, string country, string title, string degree, string year)
        {

            Thread.Sleep(1000);

            // Click on Add New button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewButton.Click();
            Thread.Sleep(1000);

            // Input University in University Name textbox
            IWebElement universityTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            universityTextbox.SendKeys(university);
            Thread.Sleep(500);

            //Select Country option from dropdown list
            IWebElement countryDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countryDropdown.Click();
            Thread.Sleep(500);

            IWebElement selectedCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[@value='" + country + "']"));
            selectedCountry.Click();

            // Select Title option from dropdown list
            IWebElement titleDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropdown.Click();
            Thread.Sleep(500);

            IWebElement titleLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[@value='" + title + "']"));
            titleLevel.Click();

            // Input Degree in degree textbox
            IWebElement degreeTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreeTextbox.SendKeys(degree);
            Thread.Sleep(500);

            // Select Year option from dropdown list
            IWebElement yearDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearDropdown.Click();
            Thread.Sleep(500);

            IWebElement yearOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[@value='" + year + "']"));
            yearOption.Click();

            // Click on Add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addButton.Click();
            Thread.Sleep(500);
        }

        public void CheckEducationNotification(IWebDriver driver, string notification)
        {
            // Check if new Education has been created by Notication Popup
            IWebElement notificationPopup = driver.FindElement(By.XPath("/html/body/div[1]")); 

            Assert.That(notificationPopup.Text ==  notification, "Education has not been changed");
            Thread.Sleep(1000);
        }
        public void EditEducation(IWebDriver driver, string university, string country, string title, string degree, string year)
        {
            Thread.Sleep(1000);
            // Click on new Education edit button and make changes
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            editButton.Click();

            // Edit University textbox
            IWebElement editUniversityTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            editUniversityTextbox.Clear();
            editUniversityTextbox.SendKeys(university);
            Thread.Sleep(500);

            // Edit Country dropdown list
            IWebElement editCountryDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
            editCountryDropdown.Click();
            Thread.Sleep(500);

            IWebElement selectedCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select/option[@value='" + country + "']"));
            selectedCountry.Click();
            Thread.Sleep(500);

            // Edit Title dropdown list
            IWebElement editTitleDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
            editTitleDropdown.Click();

            IWebElement titleLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select/option[@value='" + title + "']"));
            titleLevel.Click();

            // Edit Degree textbox
            IWebElement editDegreeTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            editDegreeTextbox.Clear();
            editDegreeTextbox.SendKeys(degree);
            Thread.Sleep(1000);

            // Edit Year dropdown list
            IWebElement editYearDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));
            editYearDropdown.Click();

            IWebElement yearOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select/option[@value='" + year + "']"));
            yearOption.Click();
            Thread.Sleep(500);

            // Click on Update Button
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            updateButton.Click();
            Thread.Sleep(1000);
        }
        public void DeleteEducation(IWebDriver driver)
        {
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i"));
            deleteButton.Click();
            Thread.Sleep(1000);
        }

        public string GetUniversity(IWebDriver driver)
        {
            IWebElement actualUniversity = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return actualUniversity.Text;

        }
        public string GetCountry(IWebDriver driver)
        {
            IWebElement actualCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualCountry.Text;

        }
        public string GetTitle(IWebDriver driver)
        {
            IWebElement actualTitle = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return actualTitle.Text;

        }
        public string GetDegree(IWebDriver driver)
        {
            IWebElement actualDegree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return actualDegree.Text;

        }
        public string GetYear(IWebDriver driver)
        {
            IWebElement actualYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return actualYear.Text;

        }
    }
}
