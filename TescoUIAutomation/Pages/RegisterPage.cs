using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TescoUIAutomation.Pages
{
    public class RegisterPage
    {
        IWebDriver _driver;
        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }

        By emailField = By.Id("email");
        By passwordField = By.Id("password");
        By titleLocator = By.Id("title");
        By firstNameField = By.Id("first-name");
        By lastNameField = By.Id("last-name");
        By phoneNumberField = By.Id("phone-number");
        By manualAddressLink = By.XPath("//span[text()='Add address manually']");
        By addressLineOneField = By.Id("address-line1");
        By townField = By.Id("town");
        By postCodeField = By.Id("postcode");
        By submitBtn = By.XPath("//span[text()='Create account']");
        By confirmationText = By.XPath("//h1[text()='Hi Abdlateef, welcome to Tesco']");
        By acceptCookies = By.CssSelector("[class*='styled__BaseButton-rsekm1-0 styled__Secondary']");


        public void FillInEmailField(string email)
        {
            _driver.FindElement(emailField).Clear();
            _driver.FindElement(emailField).SendKeys(email);
        }

        public void FillInPasswordField(string password)
        {
            _driver.FindElement(passwordField).Clear();
            _driver.FindElement(passwordField).SendKeys(password);
        }

        public void selectTitle(string title)
        {
            var titleSelect = _driver.FindElement(titleLocator);
            titleSelect.Click();
            SelectElement select = new SelectElement(titleSelect);
            select.SelectByText(title);
        }

        public void FillInFirstNameField(string firstName)
        {
            _driver.FindElement(firstNameField).Clear();
            _driver.FindElement(firstNameField).SendKeys(firstName);
        }

        public void FillInLastNameField(string lastName)
        {
            _driver.FindElement(lastNameField).Clear();
            _driver.FindElement(lastNameField).SendKeys(lastName);
        }

        public void FillInPhoneNumberField(string phoneNumber)
        {
            _driver.FindElement(phoneNumberField).Clear();
            _driver.FindElement(phoneNumberField).SendKeys(phoneNumber);
        }

        public void EnterManualAddressLink()
        {
            _driver.FindElement(manualAddressLink).Click();
            
        }

        public void FillInAddressLineOneField(string addressLineOne)
        {
            _driver.FindElement(addressLineOneField).Clear();
            _driver.FindElement(addressLineOneField).SendKeys(addressLineOne);
        }

        public void FillInTownField(string town)
        {
            _driver.FindElement(townField).Clear();
            _driver.FindElement(townField).SendKeys(town);
        }

        public void FillInPostCodeField(string postCode)
        {
            _driver.FindElement(postCodeField).Clear();
            _driver.FindElement(postCodeField).SendKeys(postCode);
        }

        public void ClickOnCreateButton()
        {
            _driver.FindElement(submitBtn).Click();
        }

        public string CheckConfirmationText()
        {
            return _driver.FindElement(confirmationText).Text.Trim();
        }

        public void AcceptCookies()
        {
            _driver.FindElement(acceptCookies).Click();
        }
    }
}
