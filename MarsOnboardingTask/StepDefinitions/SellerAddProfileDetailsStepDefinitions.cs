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
        public void ThenTheNewRecordShouldBeCreatedSuccessfully()
        {
            string newLanguage = profilePageObj.GetLanguage(driver);
            string newLevel = profilePageObj.GetLevel(driver);

            Assert.That(newLanguage.Equals("Sinhalese"), "Actual Language and expected Language do not match");
            Assert.That(newLevel.Equals("Native/Bilingual"), "Actual Level and expected Level do not match");

            profilePageObj.CloseBrowser(driver);
        }

        [When(@"I update '([^']*)' on existing Profile File")]
        public void WhenIUpdateOnExistingProfileFile(string p0)
        {
            profilePageObj.EditProfile(driver, p0);
        }

        [Then(@"the record should have the updated '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string language)
        {
            string editedLanguage = profilePageObj.GetEditedLanguage(driver);

            Assert.That(editedLanguage.Equals(language), "Actual language and expected language do not match");

            profilePageObj.CloseBrowser(driver);
        }


        [When(@"I Delete the Language Record")]
        public void WhenIDeleteTheLanguageRecord()
        {
            profilePageObj.DeleteAddedLanguage(driver);
        }

        [Then(@"The record should be Deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully()
        {
            profilePageObj.CloseBrowser(driver);
        }

        [When(@"I create a new record for Skills")]
        public void WhenICreateANewRecordForSkills()
        {
            
        }

        [Then(@"The new Skill record should be created successfully")]
        public void ThenTheNewSkillRecordShouldBeCreatedSuccessfully()
        {
            
        }

        [When(@"I update Skills on existing Profile File")]
        public void WhenIUpdateSkillsOnExistingProfileFile()
        {
            
        }

        [Then(@"The Skill record should have the updated")]
        public void ThenTheSkillRecordShouldHaveTheUpdated()
        {
            
        }

        [When(@"I Delete the Skills Record")]
        public void WhenIDeleteTheSkillsRecord()
        {
            
        }

        [Then(@"The Skill record should be Deleted successfully")]
        public void ThenTheSkillRecordShouldBeDeletedSuccessfully()
        {
            
        }

        [When(@"I create a new record for Education")]
        public void WhenICreateANewRecordForEducation()
        {
            
        }

        [When(@"I update Education on existing Profile File")]
        public void WhenIUpdateEducationOnExistingProfileFile()
        {
            
        }

        [Then(@"The Education record should have the updated")]
        public void ThenTheEducationRecordShouldHaveTheUpdated()
        {
            
        }

        [When(@"I Delete the Education Record")]
        public void WhenIDeleteTheEducationRecord()
        {
            
        }

        [Then(@"The Education record should be Deleted successfully")]
        public void ThenTheEducationRecordShouldBeDeletedSuccessfully()
        {
            
        }

        [When(@"I create a new record for Certifications")]
        public void WhenICreateANewRecordForCertifications()
        {
            
        }

        [When(@"I update Certifications on existing Profile File")]
        public void WhenIUpdateCertificationsOnExistingProfileFile()
        {
            
        }

        [Then(@"The Certifications record should have the updated")]
        public void ThenTheCertificationsRecordShouldHaveTheUpdated()
        {
            
        }

        [When(@"I Delete the Certifications Record")]
        public void WhenIDeleteTheCertificationsRecord()
        {
            
        }

        [Then(@"The Certifications record should be Deleted successfully")]
        public void ThenTheCertificationsRecordShouldBeDeletedSuccessfully()
        {
            
        }

    }
}
