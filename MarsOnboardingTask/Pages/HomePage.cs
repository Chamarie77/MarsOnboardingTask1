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

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/div[1]", 10);

            IWebElement profileDropDown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span", 10);           
            profileDropDown.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//a[text()[contains(.,'Go to Profile')]]", 10);            
            IWebElement profileLink = driver.FindElement(By.XPath("//a[text()[contains(.,'Go to Profile')]]"));
            profileLink.Click();
        }

    }
}
