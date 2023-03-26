using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TescoUIAutomation.Pages;
using TescoUIAutomation.Setup;

namespace TescoUIAutomation.StepDefinition
{
    [Binding]
    public class RegisterSteps
    {
        Context _context;
        Homepage _homepage;
        RegisterPage _registerpage;

        public RegisterSteps(Context context, Homepage homepage, RegisterPage registerpage)
        {
            _context = context;
            _homepage = homepage;
            _registerpage = registerpage;

        }
        
        [Given(@"that Tesco website is loaded on a browser")]
        public void GivenThatTescoWebsiteIsLoadedOnABrowser()
        {
            _context.LoadApplicationUnderTest();
            _registerpage.AcceptCookies();
        }

        [When(@"a user clicks on the Register Link")]
        public void WhenAUserClicksOnTheRegisterLink()
        {
            _homepage.ClickOnRegisterLink();
        }

        [When(@"a user fills in the Email Address field with '(.*)'")]
        public void WhenAUserFillsInTheEmailAddressFieldWith(string email)
        {
            _registerpage.FillInEmailField(email);
        }

        [When(@"a user fills in the Password field with '(.*)'")]
        public void WhenAUserFillsInThePasswordFieldWith(string password)
        {
            _registerpage.FillInPasswordField(password);
        }

        [When(@"a user selects '(.*)' from the Title dropdown")]
        public void WhenAUserSelectsFromTheTitleDropdown(string title)
        {
            _registerpage.selectTitle(title);
        }

        [When(@"a user fills in the First Name field with '(.*)'")]
        public void WhenAUserFillsInTheFirstNameFieldWith(string firstName)
        {
            _registerpage.FillInFirstNameField(firstName);
        }

        [When(@"a user fills in the Last Name field with '(.*)'")]
        public void WhenAUserFillsInTheLastNameFieldWith(string lastName)
        {
            _registerpage.FillInLastNameField(lastName);
        }

        [When(@"a user fills in the Phone Number field with '(.*)'")]
        public void WhenAUserFillsInThePhoneNumberFieldWith(string phoneNumber)
        {
            _registerpage.FillInPhoneNumberField(phoneNumber);
        }

        [When(@"a user clicks the Add address manually link")]
        public void WhenAUserClicksTheAddAddressManuallyLink()
        {
            _registerpage.EnterManualAddressLink();
        }

        [When(@"a user fills in the Address Line 1 field with (.*)")]
        public void WhenAUserFillsInTheAddressLineFieldWith(string addressLineOne)
        {
            _registerpage.FillInAddressLineOneField(addressLineOne);
        }

        [When(@"a user fills in the Town or city field with '(.*)'")]
        public void WhenAUserFillsInTheTownOrCityFieldWith(string town)
        {
            _registerpage.FillInTownField(town);
        }

        [When(@"a user fills in the Post code field with '(.*)'")]
        public void WhenAUserFillsInThePostCodeFieldWith(string postCode)
        {
            _registerpage.FillInPostCodeField(postCode);
        }

        [When(@"a user clicks on the Create account button")]
        public void WhenAUserClicksOnTheCreateAccountButton()
        {
            _registerpage.ClickOnCreateButton();
        }

        [Then(@"a new user account '(.*)' must be created")]
        public void ThenANewUserAccountMustBeCreated(string expectedResult)
        {
            string actualResult = _registerpage.CheckConfirmationText();
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}
