using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnboardingTask.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver) 
        { 
            // Open Chrome browser
            driver.Manage().Window.Maximize();

            // Launch Mars website
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            Thread.Sleep(1000);

            try
            {
                // Identify the Sign In button and Click on it
                IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
                signInButton.Click();

                // Identify the email address textbox and enter valid email address
                IWebElement emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                emailTextbox.SendKeys("jessica@hotmail.com");

                // Identify the password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys("123123");

                // Identify login button and click on it 
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Mars website home page did not launch", ex.Message);
            }

           
        }
    }
}
