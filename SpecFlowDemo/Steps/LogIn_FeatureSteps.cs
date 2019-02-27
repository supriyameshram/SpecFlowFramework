using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SpecFlowDemo.Utils;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
    [Binding]
    public class LogIn_FeatureSteps
    {
        private IWebDriver driver;
       [Given(@"User is on LogIn Page")]
        public void GivenUserIsOnLogInPage()
        {  
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Url = "http://demo.guru99.com/v4/";
            
        }

        [When(@"User enter credentials")]
        public void WhenUserEnterCredentials(Table table)
        {
            var dictionary = TableExtensions.ToDictionary(table);
            var test = dictionary["Username"];
            var test1 = dictionary["Password"];
            driver.FindElement(By.Name("uid")).SendKeys(dictionary["Username"]);
            driver.FindElement(By.Name("password")).SendKeys(dictionary["Password"]);
        }


        [When(@"Click on LogIn button")]
        public void WhenClickOnLogInButton()
        {
            driver.FindElement(By.Name("btnLogin")).Click();
        }


        [Then(@"Successful LogIn message should display")]
        public void ThenSuccessfulLogInMessageShouldDisplay()
        {
            Console.WriteLine("Login Successfully");
        }

        [When(@"User Click on LogOut button")]
        public void WhenUserLogOutFromTheApplication()
        {
            driver.FindElement(By.LinkText("Log out")).Click();
            driver.Close();
        }
      
        [Then(@"Successful Logout message should display")]
        public void ThenSuccessfulLogoutMessageShouldDisplay()
        {
            Console.WriteLine("Successful Logout");
        }
    }
}
