using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace KMVPAutomation.StepBindings
{
    [Binding]
    public class MVPADSkillsSteps : MVPLoginSteps
    //public class MVPADSkillsSteps
    {
        //public object Driver { get; private set; }
        //public IWebDriver driver;
        //public MVPADSkillsSteps() => driver = new ChromeDriver();

        [Given(@"I have logged in to MVP Portal and clicked on skills tab")]
        public void GivenIHaveLoggedInToMVPPortalAndClickedOnSkillsTab()
        {
            //driver.Navigate().GoToUrl("http://192.168.99.100:5000/");
            //driver.Manage().Window.Maximize();
            //driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();
            //driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("mvpstudio.qa@gmail.com");
            //driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("SydneyQa2018");
            //driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
            GivenIHaveNavigatedToMVPPortalWebsite();
            GivenIHaveEnteredUsername();
            GivenIHaveEnteredPassword();
            WhenIPressTheSigninButton();
            Thread.Sleep(5000);
            //Go to skills tab
            driver.FindElement(By.XPath("//A[@data-tab='second'][text()='Skills']")).Click();
        }
        
        [When(@"I click on add new button on skills tab")]
        public void WhenIClickOnAddNewButtonOnSkillsTab()
        {
            driver.FindElement(By.XPath("//th[text()='Skill']//following-sibling::th[@class='right aligned']/div[@class='ui teal button'][text()='Add New']")).Click();
        }
        
        [When(@"I Add skills as '(.*)'")]
        public void WhenIAddSkillsAs(string testSkills)
        {
            driver.FindElement(By.XPath("(//INPUT[@type='text' and @placeholder='Add Skill'])")).SendKeys(testSkills);
        }
        
        [When(@"I select skill level '(.*)'")]
        public void WhenISelectSkillLevel(string levelSkills)
        {
            // select the drop down list
            var skillLevel = driver.FindElement(By.Name("level"));
            //create select element object 
            var selectElement = new SelectElement(skillLevel);
            // select by text
            selectElement.SelectByText(levelSkills);

            Thread.Sleep(2000);
        }

        [When(@"I press click Add button to add skill")]
        public void WhenIPressClickAddButtonToAddSkill()
        {
            // Adding skills as beginner
            driver.FindElement(By.XPath("(//input[@class='ui teal button '])")).Click();
        }

        [Then(@"I should be able add and view new skills to my profile")]
        public void ThenIShouldBeAbleAddAndViewNewSkillsToMyProfile()
        {
            Thread.Sleep(5000);
        }
        
        [Then(@"I should be able to delete skills added")]
        public void ThenIShouldBeAbleToDeleteSkillsAdded()
        {
            driver.FindElement(By.XPath("//td[text()='Test Analyst1']//following-sibling::td[@class='right aligned']//i[@class='remove icon']")).Click();
            Thread.Sleep(10000);
            driver.Close();
            driver.Quit();
        }
    }
}
