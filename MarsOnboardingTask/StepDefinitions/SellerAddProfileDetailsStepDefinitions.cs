using MarsOnboardingTask.Pages;
using MarsOnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsOnboardingTask.StepDefinitions
{
    [Binding]
    public class SellerAddProfileDetailsStepDefinitions : CommonDriver
    {
        // page objects initialization
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"I logged into localhost:(.*)/Home successfully")]
        public void GivenILoggedIntoLocalhostHomeSuccessfully(int p0)
        {
            // open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
           
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I navigate to Profile Page")]
        public void WhenINavigateToProfilePage()
        {
            // Home page object initialization and definition
            
            homePageObj.GoToProfilePage(driver);

        }

        [When(@"I create a new record for Language")]
        public void WhenICreateANewRecordForLanguage()
        {
            
            profilePageObj.AddDetailsToProfile(driver);
        }

        [Then(@"Then the new record should be created successfully")]
        public void ThenThenTheNewRecordShouldBeCreatedSuccessfully()
        {
            Thread.Sleep(5000);
            //ProfilePage profilePageObj = new ProfilePage();
            string newLanguage = profilePageObj.GetLanguage(driver);
            string newLevel = profilePageObj.GetLevel(driver);

            Assert.That(newLanguage.Equals("Sinhalese"), "Actual Language and expected Language do not match" );
            Assert.That(newLevel.Equals("Native/Bilingual"), "Actual Level and expected Level do not match");
        }
              
        
        
        [When(@"I update '([^']*)' on existing Profile File")]
        public void WhenIUpdateOnExistingProfileFile(string p0)
        {
            profilePageObj.EditProfile(driver, p0);
            
        }

        [Then(@"the record should have the updated '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string japanese)
        {
            string editedLanguage = profilePageObj.GetEditedLanguage(driver);

            Assert.That(editedLanguage == "Actual language and expected language do not match");
        }

    }
}
