using MarsOnboardingTask.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsOnboardingTask.Pages
{
    internal class ProfilePage
    {
        public void AddDetailsToProfile(IWebDriver driver)
        {

            //click on multiple selection tab 

            // click on languages tab
            IWebElement languagesOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languagesOption.Click();

            // to add new languages
            //click on Add New button
            IWebElement addnewButtonLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButtonLanguage.Click();

            // to add a new language
            IWebElement languageTextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languageTextbox.SendKeys("Sinhalese");

            IWebElement languagelevelDropdownOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[1]"));
            languagelevelDropdownOption.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]", 10);
            IWebElement languageOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
            languageOption.Click();


            // Click on Add button for language
            IWebElement addLanguageButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addLanguageButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[1]", 10);


        }

        public string GetLanguage(IWebDriver driver)
        {
            IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
            return actualLanguage.Text;
        }

        public string GetLevel(IWebDriver driver)
        {
            IWebElement actualLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
            return actualLevel.Text;
        }

        public void EditProfile(IWebDriver driver, string language)
        {

            // wait until the entire profile page is displayed
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]", 6);


            // click on edit pen icon
            IWebElement goToEditIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i"));
            goToEditIcon.Click();

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input"));
            findRecordCreated.Clear();
            findRecordCreated.SendKeys(language);

            if (findRecordCreated.Text == "Japanese")
            {
                //click on update buton
                IWebElement updateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]"));
                updateButton.Click();

            }
            else
            {
                Assert.Fail("Record to be edited hasn't found.Record not edited");
            }
        }
        public string GetEditedLanguage(IWebDriver driver)
        {
            IWebElement createdLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input"));
            return createdLanguage.Text;
        }


    }
}    



    

