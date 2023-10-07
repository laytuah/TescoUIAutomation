using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TescoUIAutomation.Pages
{
    public class ConfirmationPage
    {
        private IWebDriver _driver;
        public ConfirmationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        By confirmationText = By.XPath("//h1[text()='Hi Abdlateef, welcome to Tesco']");
        By HomepageLink = By.XPath("//span[text()='Tesco.com']");

        public string CheckConfirmationText()
        {
            return _driver.FindElement(confirmationText).Text.Trim();
        }

        public Homepage ClickHomepageLink()
        {
            _driver.FindElement(HomepageLink).Click();
            return new Homepage(_driver);
        }
    }
}
