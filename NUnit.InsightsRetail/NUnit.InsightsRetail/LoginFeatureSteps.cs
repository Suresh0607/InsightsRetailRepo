using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.InsightsRetail
{
    [Binding]
    public class LoginFeatureSteps
    {
        private IWebDriver driver;

        [Given(@"I user logs into the application")]
        public void GivenIUserLogsIntoTheApplication()
        {
            System.Diagnostics.Debug.WriteLine("This is a New TestFW");
            CommonTestExecute ct = new CommonTestExecute();
            this.driver = ct.SetUp();
            driver.Navigate().GoToUrl("https://ce.invigorinsights.com/login.php");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='userName']")).SendKeys("qaautoinv2@yandex.com");
            driver.FindElement(By.XPath("//*[@id='password']")).SendKeys("Test@123");
            driver.FindElement(By.XPath("/html/body/div/div/div[1]/div/div[2]/form/fieldset/div[6]/div[2]/button")).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(1000)).Until(ExpectedConditions.ElementExists((By.Id("userName1"))));
         
        }
    }
}
