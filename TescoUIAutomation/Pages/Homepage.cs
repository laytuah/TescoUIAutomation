using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TescoUIAutomation.Pages;

namespace TescoUIAutomation.Pages
{
    public class Homepage
    {
        private IWebDriver _driver;

        public Homepage(IWebDriver driver)
        {
            _driver = driver;
        }

        By registerLink = By.CssSelector("a[href*='register']");
        By confirmationSalutation = By.XPath("//h1[@class='styled__StyledPageTitle-sc-119w3hf-0 geScBb styled__SalutationHeading-sc-1jsbdha-1 ldOZEY']");

        public RegisterPage ClickOnRegisterLink()
        {
            _driver.FindElement(registerLink).Click();
            return new RegisterPage(_driver);
        }

        public string CheckSalutation()
        {
            return _driver.FindElement(confirmationSalutation).Text.Trim();
        }

    }
}

