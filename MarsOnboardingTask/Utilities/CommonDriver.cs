using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MarsOnboardingTask.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.Driver
{
    [Binding]
    public class CommonDriver
    {
        public static IWebDriver driver;

        [AfterScenario]
        public static void AfterTestRun()
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}
