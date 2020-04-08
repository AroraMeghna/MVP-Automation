using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace KMVPAutomation.StepBindings
{
    [Binding]
    public class MVPLoginSteps
    {
        public object Driver { get; private set; }
        public IWebDriver driver;
        public MVPLoginSteps() => driver = new ChromeDriver();

        [Given(@"I have navigated to MVP Portal website")]
        public void GivenIHaveNavigatedToMVPPortalWebsite()
        {
            driver.Navigate().GoToUrl("http://192.168.99.100:5000/");
            driver.Manage().Window.Maximize();
        }

        [Given(@"I have entered username")]
        public void GivenIHaveEnteredUsername()
        {
            driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();
            driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("mvpstudio.qa@gmail.com");
        }

        [Given(@"I have entered password")]
        public void GivenIHaveEnteredPassword()
        {
            driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("SydneyQa2018");
        }

        [When(@"I press the signin button")]
        public void WhenIPressTheSigninButton()
        {
            driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
        }
        
        [Then(@"I should be able navigate to MVP Portal")]
        public void ThenIShouldBeAbleNavigateToMVPPortal()
        {
            Thread.Sleep(10000);
            driver.Close();
            driver.Quit();

        }
    }
}
