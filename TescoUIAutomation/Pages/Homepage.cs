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

        public RegisterPage ClickOnRegisterLink()
        {
            _driver.FindElement(registerLink).Click();
            return new RegisterPage(_driver);
        }

    }
}

