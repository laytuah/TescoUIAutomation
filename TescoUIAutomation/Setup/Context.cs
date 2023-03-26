using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace TescoUIAutomation.Setup
{
    [Binding]
    public class Context
    {
        readonly IObjectContainer _objectContainer;
        IWebDriver _driver;
        string baseUrl = "http://Tesco.com";

        public Context(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        public void LoadApplicationUnderTest()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _driver.Navigate().GoToUrl(baseUrl);
        }
        
        [AfterScenario]
        public void CloseApplicationUnderTest()
        {
            _driver?.Quit();
        }
    }
}
