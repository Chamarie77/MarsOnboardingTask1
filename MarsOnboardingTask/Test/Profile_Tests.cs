using MarsOnboardingTask.Pages;
using MarsOnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MarsOnboardingTask.Tests
{
    [TestFixture]
    [Parallelizable] 
    internal class Profile_Tests : CommonDriver
    {
       // [SetUp]
              

        [Test, Order (1)]
        public void CreatProfile_Tests()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToProfilePage(driver);

            // Profile page object initialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddDetailsToProfile(driver);
        }


        [Test, Order (2) ]
        public void EditProfile_Tests()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToProfilePage(driver);

            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditProfile(driver, "Sinhalese");
        }

        
    }
}