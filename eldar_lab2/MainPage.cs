using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eldar_lab2
{
    public class MainPage : PageBase
    {
        private By bankManagerButton = By.XPath("//button[contains(text(), 'Bank Manager Login')]");
        private By customersButton = By.XPath("//button[contains(text(), 'Customers')]");
        private By deleteButton = By.XPath("//button[contains(text(), 'Delete')]");

        public MainPage(IWebDriver driver) : base(driver) { }

        public void VisitCustomersPage()
        {
            Click(bankManagerButton);
            Thread.Sleep(1000);
            Click(customersButton);
        }

        public void DeleteAllCustomers()
        {
            foreach (var button in Elements(deleteButton))
            {
                button.Click();
                Thread.Sleep(1000);
            }
        }

        public int CheckNumberOfDeleteButtons()
        {
            return Elements(deleteButton).Count;
        }
    }
}
