using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MarsOnboardingTask
{
    internal class Program
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
            passwordTextbox.SendKeys("P4ssW0rd9768");
            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();

            // check if user is logged in successfully
            IWebElement  helloChamarie = driver.FindElement(By.XPath("//*[@id='account - profile - section'/div/div[1]/div[2]/div/span");
            
            if(helloChamarie.Text  == "Hi Chamarie")
            {
                Console.WriteLine("Logged successfully, test passed.");//*[@id="account-profile-section"]/div/div[1]/div[2]/div/span
            }
            else
            {
                Console.WriteLine("Login failed. Test failed");
            } 


        }
    }
}
