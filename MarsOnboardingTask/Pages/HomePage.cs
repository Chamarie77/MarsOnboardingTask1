using MarsOnboardingTask.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnboardingTask.Pages
{
    internal class HomePage
    {
        public void GoToProfilePage(IWebDriver driver)
        {
            // go to profile file

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/div[1]", 20);

            IWebElement profileDropDown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span", 20);           
            profileDropDown.Click();

            Wait.WaitToBeClickable(driver, "XPath", ".//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[1]", 20);            
            IWebElement profileLink = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[1]"));
            profileLink.Click();
        }

        // go to profile file
        //var xPath = By.XPath(".//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[1]");
        //By.XPath("/html/body/div/div[1]/div[1]/div[1]");
        //var elements  = driver.FindElement(xPath);
        ///var hichamarieDropdown = driver.FindElements(xPath);
        //Wait.WaitToBeClickable(driver, "XPath", ".//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[1]", 20);
        //IWebElement hichamarieDropdown = driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
        //hichamarieDropdown.Click();

        //Wait.WaitToBeClickable(driver, "XPath", ".//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[1]", 20);
        //    var xPath = By.XPath(".//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[1]");
        //IWebElement elementsA = driver.FindElement(xPath);
        //elementsA.Click();
        //IWebElement chamariedropdownOption = driver.FindElement(By.XPath("//a[@href='Account/Profile']"));
        //chamariedropdownOption.Click();

    }
}
