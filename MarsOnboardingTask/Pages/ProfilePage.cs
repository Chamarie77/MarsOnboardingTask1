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
            IWebElement languagesOption = driver.FindElement(By.XPath("//form//a[contains(text(),'Languages')]"));
            languagesOption.Click();

            // to add new languages
            //click on Add New button
            IWebElement addnewButtonLanguage = driver.FindElement(By.XPath("//div[contains(text(),'Add New')]"));
            addnewButtonLanguage.Click();

            Wait.WaitToBeClickable(driver, "xpath", "//input[@placeholder='Add Language']", 10);
            // to add a new language
            IWebElement languageTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            languageTextbox.SendKeys("Sinhalese");

            IWebElement languagelevelDropdownOption = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            languagelevelDropdownOption.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//select[@class='ui dropdown']/option[@value='Native/Bilingual']", 10);
            IWebElement languageOption = driver.FindElement(By.XPath("//select[@class='ui dropdown']/option[@value='Native/Bilingual']"));
            languageOption.Click();


            // Click on Add button for language
            IWebElement addLanguageButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Add']"));
            addLanguageButton.Click();

            // To find remove icon
            IWebElement deleteElement = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            Wait.WaitToBeVisible(driver, "XPath", "//i[@class='remove icon']", 20);

        }

        //To delete added language
        public void DeleteAddedLanguage(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, "XPath", "//i[@class='remove icon']", 20);
            IWebElement deleteElement = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            deleteElement.Click();
        }

        // To close browser
        public void CloseBrowser(IWebDriver driver)
        {
            driver.Quit();
        }
        
        // To get the language
        public string GetLanguage(IWebDriver driver)
        {
            IWebElement actualLanguage = driver.FindElement(By.XPath("//td[contains(text(),'Sinhalese')]"));
            return actualLanguage.Text;
        }
        
        // To get the language level
        public string GetLevel(IWebDriver driver)
        {
            IWebElement actualLevel = driver.FindElement(By.XPath("//td[contains(text(),'Native/Bilingual')]"));
            return actualLevel.Text;
        }

        public void EditProfile(IWebDriver driver, string language)
        {

            // wait until the entire profile page is displayed
               Wait.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']//form", 6);
               Wait.WaitToBeVisible(driver, "XPath", "//form//i[@class='outline write icon']", 5); 
           

            // click on edit pen icon
            IWebElement goToEditIcon = driver.FindElement(By.XPath("//span/i[@class='outline write icon']"));
            goToEditIcon.Click();

            // to find the created record
            IWebElement findRecordCreated = driver.FindElement(By.XPath("//form//table//input"));
            findRecordCreated.Clear();
            findRecordCreated.SendKeys(language);
           
            if (findRecordCreated.GetDomProperty("value").Equals(language))
            {
                //click on update buton
                IWebElement updateButton = driver.FindElement(By.XPath("//form//table//span/input[@value='Update']"));
                updateButton.Click();
                Wait.WaitToBeVisible(driver, "XPath", "//i[@class='remove icon']", 20);
            }
            else
            {
                Assert.Fail("Record to be edited hasn't found.Record not edited");
            }
        }
        public string GetEditedLanguage(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, "XPath", "//i[@class='remove icon']", 20);
            IWebElement createdLanguage = driver.FindElement(By.XPath("//div[@data-tab='first']//td"));
            return createdLanguage.Text;
        }


    }
}    



    

