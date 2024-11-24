using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace eldar_lab2
{ 
    [Binding]
    public class DeleteCustomersSteps
    {
        private IWebDriver driver;
        private MainPage mainPage;

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
            mainPage = new MainPage(driver);
        }

        [When(@"I navigate to the customers page")]
        public void WhenINavigateToTheCustomersPage()
        {
            Thread.Sleep(1000);
            mainPage.VisitCustomersPage();
        }

        [When(@"I delete all customers")]
        public void WhenIDeleteAllCustomers()
        {
            Thread.Sleep(1000);
            mainPage.DeleteAllCustomers();
        }

        [Then(@"there should be no customers left")]
        public void ThenThereShouldBeNoCustomersLeft()
        {
            Assert.That(mainPage.CheckNumberOfDeleteButtons(), Is.EqualTo(1));
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
