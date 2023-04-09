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
        public void AddNewLanguage(IWebDriver driver, string language)
        {
            Thread.Sleep(2000);

            // Click on Add New button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")); 
            addNewButton.Click();
            Thread.Sleep(1000);

            // Input Language into Add Language textbox
            IWebElement languageTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languageTextbox.SendKeys(language);

            // Select Level option from dropdown list
            IWebElement levelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            levelDropdown.Click();
            Thread.Sleep(1000);

            IWebElement fluentOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            fluentOption.Click();

            // Click on Add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(500);
           
        } 
        public void EditLanguage(IWebDriver driver, string language)
        {

        }
        public void CheckLanguageNotification(IWebDriver driver, string language)
        {
            // Check if new Language has been created by Notication Popup
            IWebElement notificationPopup = driver.FindElement(By.XPath("/html/body/div[1]/div"));

            Assert.That(notificationPopup.Text == language + " has been added to your languages", "Language has not been successfully added");
        }

        public void GoToSkillsTab(IWebDriver driver)
        {
            Thread.Sleep(1000);

            // Click on Skills Tab
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();
            Thread.Sleep(1000);
        }
        public void AddNewSkill(IWebDriver driver)
        {
            Thread.Sleep(1000);

            // Click on Add New button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(1000);

            // Input Skill in Skills textbox
            IWebElement skillTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillTextbox.SendKeys("Selenium");

            // Select Level option from dropdown list
            IWebElement levelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            levelDropdown.Click();

            IWebElement beginnerOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            beginnerOption.Click();

            // Click on Add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();
            Thread.Sleep(500);

        }
        public void CheckSkillsNotification(IWebDriver driver)
        {
            IWebElement notificationPopup = driver.FindElement(By.XPath("/html/body/div[1]/div"));

            Assert.That(notificationPopup.Text == "Selenium has been added to your skills", "Skill has not been successfully added");
        }

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

            Assert.That(notificationPopup.Text ==  notification, "Education has not been successfully added");
        }
        public void EditEducation(IWebDriver driver, string university, string country, string title, string degree, string year)
        {
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
            Thread.Sleep(500);

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
        public string GetEditedUniversity(IWebDriver driver)
        {
            IWebElement actualUniversity = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return actualUniversity.Text;

        }

    }
}
