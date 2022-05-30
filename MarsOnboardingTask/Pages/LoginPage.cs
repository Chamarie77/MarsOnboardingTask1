using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnboardingTask.Pages
{
    internal class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            // launch localhost:5000 portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            try
            {              
                // click on "Sign In" link
                driver.FindElement(By.LinkText("Sign In")).Click();

                // identify username  textbox and enter valid email address
                IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                usernameTextbox.SendKeys("cmannatunga@yahoo.com");

                // identify password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys("onboardingMay22");
                // click on login button
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Prpfile  Page login page did not launch", ex.Message);
                throw;
            }           
        }
    }
}