using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MarsOnboardingTask
{
    internal class Profile_Tests
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // launch localhost:5000 portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

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

            // check if user is logged in successfully
           // IWebElement helloChamarie = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));


          //  if (helloChamarie.Text == "Hi  Chamarie")
         //   {
          //      Console.WriteLine("Logged successfully, test passed.");
         //   }
          //  else
           // {
          //      Console.WriteLine("Login failed. Test failed");
         //   }

            // Add details to the profile file

            // go to profile file
            IWebElement hichamarieDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            hichamarieDropdown.Click();

            IWebElement chamariedropdownOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[1]"));
            chamariedropdownOption.Click();

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
            languageTextbox.SendKeys("Japanese");

            IWebElement languagelevelDropdownOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languagelevelDropdownOption.Click();

            IWebElement languageOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));

            // Click on Add button for language
            IWebElement addLanguageButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addLanguageButton.Click();

            // click on Skills tab
            IWebElement skillsOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsOption.Click();

            // to add new skills
            //click on Add button for language
            IWebElement addnewButtonSkills = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButtonSkills.Click();

            // add a new skill
            IWebElement skillsTextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillsTextbox.SendKeys("SpecFlow");

            IWebElement skillLevelDropdownOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevelDropdownOption.Click();

            IWebElement skillOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));

            // Click on Add button for skill
            IWebElement addSkillButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        }
    }
}